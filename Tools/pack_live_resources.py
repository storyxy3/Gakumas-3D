"""Package the original renderer and actor resource dependency closure.

Compiled shaders and streamed resource bytes stay original. Archive paths are
relocated, and type trees recovered from the original DummyDlls make the
stripped player data readable as an AssetBundle.
"""
from pathlib import Path

import UnityPy
from UnityPy.files.SerializedFile import FileIdentifier
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator
from UnityPy.helpers.Tpk import get_typetree_node
from UnityPy.helpers.TypeTreeNode import TypeTreeNode


RESOURCE_NAMES = {
    "vlactoreyeblinkdata", "vlactorfaciallimitdata", "vlactortalkdata",
    "defaultactoranimationdata", "campusactorbatchmaterial", "campuslivemixer",
    "actorfootshadowshader", "actorfootshadowtexture", "liveatlas", "game3dmanager", "vlbconfigoverride",
    "mot_all_chr_cmn_idle-001-add_lp_b", "mot_all_chr_cmn_idle-002-add_lp_b",
}


def pack(game_data: Path, template: Path, dummy_dll: Path, destination: Path, shaders=None):
    UnityPy.config.FALLBACK_UNITY_VERSION = "6000.0.77f1"
    original = UnityPy.load(str(game_data))
    generator = TypeTreeGenerator("6000.0.77f1")
    generator.load_local_dll_folder(str(dummy_dll))
    original.typetree_generator = generator
    source_files = {asset.name: asset for asset in original.assets}

    def resolve(owner, pointer):
        filename = owner.name if pointer["m_FileID"] == 0 else owner.externals[pointer["m_FileID"] - 1].name
        if filename == "unity default resources":
            return None
        return source_files[filename].objects[pointer["m_PathID"]]

    assets = {}
    for obj in original.objects:
        if obj.type.name == "ResourceManager":
            for name, pointer in obj.read_typetree()["m_Container"]:
                if name == "campuslivemixer":
                    mixer_object = resolve(obj.assets_file, pointer)
                    for component in mixer_object.read_typetree()["m_Component"]:
                        member = resolve(mixer_object.assets_file, component["component"])
                        if member.type.name != "MonoBehaviour":
                            continue
                        data = member.read_typetree()
                        if "_liveMixerGroup" in data:
                            assets["assets/campuslivemixergroup"] = resolve(member.assets_file, data["_liveMixerGroup"])
                elif name in RESOURCE_NAMES:
                    assets["resources/" + name] = resolve(obj.assets_file, pointer)
        elif obj.type.name == "MonoBehaviour":
            data = obj.parse_monobehaviour_head()
            if data.m_Name in ("CampusRenderPipelineUltimateAsset", "CampusActorSettings"):
                assets["assets/" + data.m_Name.lower()] = obj

    selected = {}
    pending = list(assets.values())
    streams = {Path(name).name: data for name, data in original.file.files.items() if not hasattr(data, "objects")}
    used_streams = set()

    def relocate_streams(value):
        changed = False
        if isinstance(value, dict):
            for key, child in value.items():
                if isinstance(child, str) and Path(child).name in streams:
                    stream = Path(child).name
                    value[key] = "archive:/CAB-trueend-resources/trueend-" + stream
                    used_streams.add(stream)
                    changed = True
                elif isinstance(child, (dict, list, tuple)):
                    changed |= relocate_streams(child)
        elif isinstance(value, (list, tuple)):
            for child in value:
                if isinstance(child, (dict, list, tuple)):
                    changed |= relocate_streams(child)
        return changed

    def dependencies(owner, value):
        if isinstance(value, dict):
            if set(value) == {"m_FileID", "m_PathID"}:
                if value["m_PathID"]:
                    dependency = resolve(owner, value)
                    if dependency is not None:
                        pending.append(dependency)
            else:
                for child in value.values():
                    dependencies(owner, child)
        elif isinstance(value, (list, tuple)):
            for child in value:
                dependencies(owner, child)

    while pending:
        obj = pending.pop()
        key = (obj.assets_file.name, obj.path_id)
        if key in selected:
            continue
        node = obj._get_typetree_node()
        if obj.type.name == "MonoBehaviour":
            nodes = []
            for child in node.traverse():
                entry = {key: value for key, value in child.to_dict().items() if key != "m_Children"}
                if (len(child.m_Children) == 1 and child.m_Children[0].m_Type == "Array"
                        and child.m_Children[0].m_Children[-1].m_Type != "char"):
                    entry["m_Type"] = "vector"
                entry["m_Type"] = entry["m_Type"].replace("PPtr<$", "PPtr<")
                if child.m_Level == 0:
                    entry["m_Type"] = "MonoBehaviour"
                entry["m_Version"] = 1
                entry["m_Index"] = len(nodes)
                entry["m_TypeFlags"] = int(entry["m_Type"] == "Array")
                entry["m_RefTypeHash"] = 0
                entry["m_ByteSize"] = {
                    "UInt8": 1, "SInt8": 1, "char": 1, "bool": 1,
                    "short": 2, "UInt16": 2, "int": 4, "unsigned int": 4,
                    "float": 4, "SInt64": 8, "UInt64": 8, "double": 8,
                }.get(entry["m_Type"], -1)
                nodes.append(entry)
            node = TypeTreeNode.from_list(nodes)
            header = get_typetree_node(obj.class_id, obj.version)
            header_names = {child.m_Name for child in header.m_Children}
            node.m_Children = list(header.m_Children) + [child for child in node.m_Children if child.m_Name not in header_names]
        try:
            data = obj.read_typetree(nodes=node)
        except Exception as error:
            raise ValueError(f"Cannot recover serialized resource {key} ({obj.type.name})") from error
        shader_changed = False
        if shaders is not None:
            data, shader_changed = shaders.replace(obj, data)
        obj.serialized_type.node = node
        for index, child in enumerate(node.traverse()):
            child.m_Index = index
            if child.m_TypeFlags is None:
                child.m_TypeFlags = int(child.m_Type == "Array")
            if child.m_MetaFlag is None:
                child.m_MetaFlag = 0
            if child.m_RefTypeHash is None:
                child.m_RefTypeHash = 0
        obj.serialized_type.type_dependencies = ()
        selected[key] = obj
        try:
            dependencies(obj.assets_file, data)
        except (KeyError, IndexError) as error:
            raise ValueError(f"Invalid resource dependency in {key} ({obj.type.name})") from error
        relocated = relocate_streams(data)
        if relocated or shader_changed:
            obj.save_typetree(data)

    wrapper = UnityPy.load(str(template))
    bundle_object = next(obj for obj in wrapper.objects if obj.type.name == "AssetBundle")
    directory = bundle_object.assets_file
    directory.objects = {bundle_object.path_id: bundle_object}
    directory.name = "CAB-trueend-resources"
    directory.externals = []
    wrapper.file.files = {directory.name: directory}
    file_ids = {}
    renamed = {filename: "CAB-trueend-" + filename for filename, _ in selected}
    for name, resource_file in original.file.files.items():
        if hasattr(resource_file, "objects"):
            objects = {obj.path_id: obj for (filename, _), obj in selected.items() if filename == resource_file.name}
            if not objects:
                continue
            resource_file.objects = objects
            types = []
            for obj in objects.values():
                if obj.serialized_type not in types:
                    types.append(obj.serialized_type)
                obj.type_id = types.index(obj.serialized_type)
            resource_file.types = types
            for obj in objects.values():
                if any("managedReference" in child.m_Type for child in obj.serialized_type.node.traverse()):
                    references = obj.read_typetree().get("references")
                    if references and any(entry.get("type", {}).get("class") for entry in references.get("RefIds", [])):
                        raise ValueError(f"Managed-reference metadata needs recovery in {resource_file.name}/{obj.path_id}: {references}")
            resource_file.ref_types = []
            script_indices = sorted({kind.script_type_index for kind in types if kind.script_type_index >= 0})
            resource_file.script_types = [resource_file.script_types[index] for index in script_indices]
            for kind in types:
                if kind.script_type_index >= 0:
                    kind.script_type_index = script_indices.index(kind.script_type_index)
            resource_file._enable_type_tree = True
            for dependency in resource_file.externals:
                if dependency.name in renamed:
                    dependency.path = "archive:/CAB-trueend-resources/" + renamed[dependency.name]
            resource_file.name = renamed[resource_file.name]
            name = resource_file.name
            external = object.__new__(FileIdentifier)
            external.temp_empty = ""
            external.guid = bytes(16)
            external.type = 0
            external.path = "archive:/CAB-trueend-resources/" + name
            directory.externals.append(external)
            file_ids[resource_file.name] = len(directory.externals)
        else:
            if Path(name).name not in used_streams:
                continue
            name = "trueend-" + Path(name).name
        wrapper.file.files[name] = resource_file

    pointers = {
        name: {"m_FileID": file_ids[obj.assets_file.name], "m_PathID": obj.path_id}
        for name, obj in assets.items()
    }
    index = bundle_object.read_typetree()
    index["m_Name"] = "trueend-resources"
    index["m_AssetBundleName"] = "trueend-resources"
    index["m_Dependencies"] = []
    index["m_PreloadTable"] = [
        {"m_FileID": file_ids[obj.assets_file.name], "m_PathID": obj.path_id}
        for obj in sorted(selected.values(), key=lambda obj: obj.type.name != "MonoScript")
    ]
    index["m_Container"] = [
        (name, {"preloadIndex": 0, "preloadSize": len(selected), "asset": pointer})
        for name, pointer in pointers.items()
    ]
    bundle_object.save_typetree(index)
    destination.write_bytes(wrapper.file.save())
    print(f"Packaged {len(selected)} original resource objects with {len(assets)} public roots")
    return sorted(assets)
