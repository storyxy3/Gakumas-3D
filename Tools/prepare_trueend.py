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
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("destination", type=Path)
    parser.add_argument("--source", type=Path, default=Path("/data/xy/gakumas/work/live_ttmr001/pc"))
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
    manifest = {"sample": "ttmr001", "platform": "pc", "revision": evidence["revision"], "bundles": []}
    for entry in ordered:
        filename = entry["name"] + ".unity3d"
        source = args.source / "bundles" / filename
        digest = hashlib.sha256(source.read_bytes()).hexdigest()
        if digest != entry["decoded_sha256"]:
            raise ValueError("Source hash differs from verified dependency record for " + entry["name"])
        shutil.copyfile(source, args.destination / filename)
        manifest["bundles"].append({
            "name": entry["name"], "file": filename, "source": "DMM-PC",
            "sha256": digest, "dependencies": entry["dependencies"],
        })
    (args.destination / "manifest.json").write_text(json.dumps(manifest, indent=2) + "\n")
    print(f"Staged {len(ordered)} original bundles in {args.destination}")


if __name__ == "__main__":
    main()
