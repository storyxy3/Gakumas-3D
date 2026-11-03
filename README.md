# Gakumas live rendering skeleton

Unity 6000.0.77f1 project targeting Android IL2CPP ARM64, with the game's URP14
fork and rendering assembly names. The project preserves structural metadata;
local game/third-party method bodies remain DummyDll stubs.

- [PACKAGES.md](PACKAGES.md): package sources, version evidence and unresolved exact patches.
- [CLOSURE.md](CLOSURE.md): included assemblies, exact dependency cuts and reproducible compiler repairs.
- [LAYOUT.md](LAYOUT.md): native field-layout comparison for rendering assemblies.
- [LAYOUT-ALL.md](LAYOUT-ALL.md): comparison for every assembly in the rebuilt native metadata.

## Build and compare

```sh
bash Tools/import.sh
bash Tools/build_android.sh
bash Tools/dump_layout.sh
```

The scripts use the server's Unity 6000.0.77f1, Xvfb and Android toolchain.
Gradle packaging can fail independently of the required native IL2CPP artifacts.
Logs and dumps are under the ignored `.recon` directory; binaries remain under
Unity's ignored `Library/Bee` output. Nothing is deployed.

The four embedded rendering package paths point to
`/data/xy/gakumas/work/urp14-fork-live` on branch `live-base`. The exact fork
checkpoint and native artifact hashes are recorded by the layout report.

## Regenerate source

```sh
python3 Tools/skeleton_from_dummydll.py
python3 Tools/generate_octo.py
python3 Packages/restore_registry.py
```

The canonical shared generator is also installed at
`/data/xy/gakumas/scripts/skeleton_from_dummydll.py`. Use `--refresh` to re-decompile
local assembly inputs. It retains raw ILSpy project output separately from the
field-preserving decompiler projection and compiler cleanup. Regeneration needs
the original read-only DummyDll directory and the existing .NET/ILSpy tools.
The registry restore script downloads the hash-recorded source archives and
reapplies the bounded game additions. Fork regeneration is documented in its
`Tools/SkeletonMerge/README.md`.

The metadata postprocessor needs the original DummyDll inputs during both Editor
and player compilation; see [its README](Assets/Editor/MetadataNames/README.md).
It restores original compiler-generated and event-field names that C# source
cannot declare directly.

No tests, test assemblies or Unity Test Framework are included.
