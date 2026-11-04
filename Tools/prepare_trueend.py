"""Stage the verified original PC dependency closure beside a standalone player.

The source bundles remain read-only. Run with the destination content directory,
for example Build/Content/ttmr001. This is player packaging, not reconstruction.
"""
import argparse
import hashlib
import json
from pathlib import Path
import shutil


def main():
    workspace = Path(__file__).resolve().parents[2]
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("destination", type=Path)
    parser.add_argument("--source", type=Path, default=workspace / "work/live_ttmr001/pc")
    parser.add_argument("--game-data", type=Path, default=workspace / "dmm/program-20261103/data.unity3d")
    parser.add_argument("--dummy-dll", type=Path, default=workspace / "work/il2cpp-3.5.3/DummyDll")
    parser.add_argument("--target", choices=("windows", "linux"), default="windows")
    parser.add_argument("--shader-source", type=Path, action="append", help="Original Android shader input for Linux, repeat for each source archive")
    args = parser.parse_args()
    evidence = json.loads((args.source / "verified_dependencies.json").read_text())
    entries = {entry["name"]: entry for entry in evidence["bundles"]}
    ordered = []
    visited = set()

    def visit(name):
        if name in visited:
            return
        visited.add(name)
        entry = entries[name]
        for dependency in entry["dependencies"]:
            visit(dependency)
        ordered.append(entry)

    for name in evidence["roots"]:
        visit(name)
    args.destination.mkdir(parents=True, exist_ok=True)
    manifest = {"sample": "ttmr001", "platform": args.target, "revision": evidence["revision"], "bundles": []}
    shaders = None
    if args.target == "linux":
        import UnityPy
        from live_shader_sources import ShaderSources
        UnityPy.config.FALLBACK_UNITY_VERSION = "6000.0.77f1"
        shader_paths = args.shader_source or [
            workspace / "extracted/com.bandainamcoent.idolmaster_gakuen/assets/bin/Data/data.unity3d",
            workspace / "extracted/UnityDataAssetPack/assets/bin/Data/datapack.unity3d",
            workspace / "work/models/shader.unity3d",
            workspace / "work/models/actor-shader.unity3d",
        ]
        shaders = ShaderSources(shader_paths)
        manifest["shader_sources"] = shaders.inputs
    from pack_live_resources import pack
    resource_file = args.destination / "trueend-resources.unity3d"
    resource_assets = pack(args.game_data, args.source / "bundles/crw_layout_env_3d_live_ttmr001-00-noon.unity3d", args.dummy_dll, resource_file, shaders)
    manifest["bundles"].append({
        "name": "trueend-resources", "file": resource_file.name,
        "source": "DMM-PC-player-20261103" + (" + Android Vulkan shader programs" if shaders else ""),
        "sha256": hashlib.sha256(resource_file.read_bytes()).hexdigest(),
        "original_sha256": hashlib.sha256(args.game_data.read_bytes()).hexdigest(),
        "dependencies": [], "assets": resource_assets,
    })
    for entry in ordered:
        filename = entry["name"] + ".unity3d"
        source = args.source / "bundles" / filename
        digest = hashlib.sha256(source.read_bytes()).hexdigest()
        if digest != entry["decoded_sha256"]:
            raise ValueError("Source hash differs from verified dependency record for " + entry["name"])
        shutil.copyfile(source, args.destination / filename)
        replaced_shaders = shaders.repack(source, args.destination / filename) if shaders else []
        manifest["bundles"].append({
            "name": entry["name"], "file": filename,
            "source": "DMM-PC" + (" + Android Vulkan shader programs" if replaced_shaders else ""),
            "sha256": hashlib.sha256((args.destination / filename).read_bytes()).hexdigest(),
            "original_sha256": digest, "dependencies": entry["dependencies"], "replaced_shaders": replaced_shaders,
        })
    (args.destination / "manifest.json").write_text(json.dumps(manifest, indent=2) + "\n")
    print(f"Staged {len(ordered)} original bundles in {args.destination}")


if __name__ == "__main__":
    main()
