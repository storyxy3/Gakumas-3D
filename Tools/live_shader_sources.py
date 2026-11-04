"""Select original Android Vulkan shader programs for the Linux content copy."""
import hashlib

import UnityPy


class ShaderSources:
    def __init__(self, paths):
        self.shaders = {}
        self.inputs = []
        for path in paths:
            environment = UnityPy.load(str(path))
            self.inputs.append({"file": str(path), "sha256": hashlib.sha256(path.read_bytes()).hexdigest()})
            for obj in environment.objects:
                if obj.type.name in ("Shader", "ComputeShader"):
                    data = obj.read_typetree()
                    name = self.name(obj.type.name, data)
                    self.shaders[(obj.type.name, name)] = data

    @staticmethod
    def name(kind, data):
        return data["m_ParsedForm"]["m_Name"] if kind == "Shader" else data["m_Name"]

    def replace(self, obj, data):
        kind = obj.type.name
        if kind not in ("Shader", "ComputeShader"):
            return data, False
        name = self.name(kind, data)
        replacement = dict(self.shaders[(kind, name)])
        # Pointers retain the destination bundle's dependency identities.
        for field in ("m_Dependencies", "m_NonModifiableTextures", "m_AssetGUID"):
            if field in data:
                replacement[field] = data[field]
        if kind == "Shader" and 18 not in replacement["platforms"]:
            raise ValueError("Original Vulkan shader is unavailable for " + name)
        return replacement, True

    def repack(self, source, destination):
        environment = UnityPy.load(str(source))
        changed = []
        for obj in environment.objects:
            if obj.type.name in ("Shader", "ComputeShader"):
                data, _ = self.replace(obj, obj.read_typetree())
                obj.save_typetree(data)
                changed.append(self.name(obj.type.name, data))
        if changed:
            destination.write_bytes(environment.file.save())
        return changed
