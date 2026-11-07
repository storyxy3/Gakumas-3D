# Gakumas live rendering skeleton

Unity 6000.0.77f1 project targeting Android IL2CPP ARM64, with the game's URP14
fork and rendering assembly names. The project preserves structural metadata;
VL rendering method bodies are reconstructed from APK 3.5.3 with the remaining
native parity gaps recorded in [TASK_D_REPORT.md](TASK_D_REPORT.md). Other local
game/third-party method bodies remain DummyDll stubs.

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

These commands regenerate the original skeleton and overwrite reconstructed
method bodies. Preserve the Task D commits before intentionally regenerating.

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

The standalone host keeps its window open on the final black frame by default. Close the window to exit.
`--quit-at-end` exits after the ending presentation, and `--screenshots <times>` implies this option.
`--quit-after <seconds>` is a wall-clock playback limit and also exits when reached.
The client presentation pauses the director 0.4 seconds before its duration and fades black over 0.3 seconds;
the host retains a presentation clock through the remaining duration so screenshot requests can capture the fade.
`LIVE_CAPTURE actual` reports that presentation clock; `LIVE_END_FADE time` records where the director paused.
`LIVE_STOPPED` is followed by `LIVE_QUIT` for automatic runs or `LIVE_IDLE` for interactive runs.
Linux playback must remain silent (`--mute -noaudio`).

Optional playback recording: `--pose-log /absolute/path/poses.jsonl` copies completed bone transforms and Swing collider/chain state at approximately 0.1-second intervals. It does not evaluate or modify the animation graph. World transforms are after frame completion; job collider coordinates are in the Swing root space, and dynamic state retains root-motion cancellation. `--capture-fps 60` uses Unity's capture clock for repeatable offline playback; it does not change the Swing solver. `--stop-time 50` stops and exits at that timeline time, allowing bounded capture intervals with `--start-time`. Keep Linux capture runs silent with `--mute -noaudio` and the documented dummy audio environment.

Frame dump for frame-by-frame comparison: `--record-frames <dir>` writes every rendered frame (camera output texture,
host fade composited) as `f??????.jpg` plus `frames.tsv` (frame, timeline/presentation time, fade) and `geometry.txt`.
It runs on the capture clock (`--capture-fps`, default 60 with this option; the director then uses GameTime on every
platform), mutes audio and exits at the end. `--record-width N` scales frames to N pixels wide (default 960, 0 = native).
Bound it with `--start-time` / `--stop-time`. `/data/xy/gakumas/scripts/framecmp.py` compares a dump with the DMM recording.
