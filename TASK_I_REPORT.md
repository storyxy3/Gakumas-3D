# Task I — True End host

## Current state

The first Linux Mono build succeeds with zero build errors. The standalone host loads all 31 verified PC bundles, the original stage scene and the original timeline scene. `CampusLiveTimelineController.master.duration` is 155.6 seconds. Playback binding is still pending, and this checkpoint exits with an explicit error after loading.

The first muted run exposed empty constructors in `CampusActorRim`, `VolumetricHeightFog` and `GlobalWindParameter`. Their original APK constructors are now restored. Native evidence is in `Evidence/TaskI`. The repeated run reaches `LIVE_LOADED`. Function comparison and Task F/H parity remain pending.

Linux loading evidence is in `.recon/task-i/load-linux-volumes.log`. It also records one missing script, unsupported D3D shader variants and the missing monitor renderer at index 3. These remain open. No visual playback claim is made at this checkpoint.

## Content

`python3 Tools/prepare_trueend.py Build/Content/ttmr001` collects the 31 original, verified DMM-PC bundles in dependency order and writes `manifest.json`. Each source hash is checked against `work/live_ttmr001/pc/verified_dependencies.json`. The exact bundle names, dependencies and hashes are recorded in `Evidence/TaskI/bundle-sources.json`. Source bundles are read-only.

The inspected `shader` and `actor-shader` bundles in both the verified PC sample and `models/bundles` contain shader platform 4, D3D11. Linux-compatible shader collection is pending.

## Build preparation

`LiveBuild.BuildLinux` builds `Build/Linux/TrueEnd.x86_64` using Mono. `LiveBuild.BuildWindows` selects StandaloneWindows64, IL2CPP Release, minimal managed stripping and DX11, with output under `Build/Windows/TrueEnd.exe`. The Windows entry is reserved for Claude to invoke on the PC. Portable package paths and final copy/run instructions are pending.

The Linux loading invocation used Xvfb, llvmpipe, `-noaudio` and `--mute`. It loads content with `--data <content directory>`. The host also parses `--sample ttmr001`, `--start-time`, `--quit-after`, `--screenshots` and `--capture-dir`. Playback and capture handling are pending.

## Remaining work

- Restore the client actor construction and `CampusLiveBinder` from the APK, then invoke the game's timeline playback path.
- Supply original pipeline configuration and resources, resolve the missing script, and collect Linux-compatible shaders.
- Connect equipment, cameras, crowd, monitors, effects and post-processing through game code.
- Trace live audio and implement the requested managed CriWare path with source evidence.
- Finish portable Windows build preparation and run the new-method and Task F/H comparisons.
