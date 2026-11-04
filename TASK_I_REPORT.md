# Task I — True End host

## Result

The Linux Mono player builds with zero errors and plays `ttmr001` through the original `CampusLiveTimelineController.Play` path from 0 to 155.6 seconds. The full muted run exits successfully and captures frames at 5, 30, 60, 90, 120 and 150 seconds. Temari has five model parts, eight renderers and a valid humanoid avatar. The captures show animation, hair, microphone, stage, camera cuts, equipment, lasers and penlights. Original volumes and renderer resources are loaded. Linux appearance still has severe bright and diffuse artifacts, and its embedded monitor video fails to decode. Windows remains the visual reference.

The Windows deliverable is the prepared project, IL2CPP build entry, original DX11 content archive and the PC commands below. Windows compilation, appearance, audible synchronization and embedded-video playback remain for Claude's PC run.

Full playback evidence is in `Evidence/TaskI/linux-full-playback.txt` and `Evidence/TaskI/screenshots`. Actual screenshot times are 5.0000, 30.0125, 60.1933, 90.2043, 120.2158 and 150.0875 seconds. The final full run exits with code 0, releases the scene, actor, camera, pipeline and bundles, and logs no exceptions or `CullingGroup` disposal warning. An earlier short shutdown run is retained in `Evidence/TaskI/linux-shutdown-playback.txt`.

## Host and reconstructed code

`Assets/TrueEndHost` is a separate assembly for bundle access, resource lookup, command-line options, window presentation, captures and process lifetime. It supplies the original Ultimate pipeline, renderer resources, actor settings, tag/layer definitions and dynamically loaded actor resources from the original player data.

The host creates `Game3DManager` before the stage so scene components can register with its camera. It builds the actor through the original VL/Campus actor methods and binds the original directors through `CampusLiveBinder.SetupAsync`. Native `Live3DPresenter.SetActorsActive` dispatches `IVLActorController.SetRendererActive`, which the host invokes after binding. The original binder handles actor layout, motion references, props, camera, audio and equipment bindings. Playback runs through `CampusLiveTimelineController`.

Reconstructed runtime methods remain in their original packages. The new census lists 315 native names with source paths and APK addresses in `Evidence/TaskI/method-census.json`.

| Package | Names | Main restored areas |
| --- | ---: | --- |
| `campus-submodule.Runtime` | 64 | Live binder and async state machine, actor descriptor accessors, volume defaults |
| `vl-unity.Runtime` | 91 | Actor resource/model/avatar construction, animation access, downscale initialization |
| `quaunity-volumetriclightbeam.Runtime` | 115 | Beam entities and chunks, culling, draw parameters, SD/HD drawing, mesh generation |
| `ProFlare.Runtime` | 45 | Flare registration, scheduling, transform/element jobs, compute and rendering |

Caller decompilations are retained under `Evidence/TaskI/client-callers`. Method decompilations and assembly evidence are under `Evidence/TaskI/native` and the adjacent `.asm` files. Several Hex-Rays outputs report a decompilation failure, so those reconstructions use the retained assembly evidence. The census covers the methods selected for this task. The broader client closure and existing rendering parity limitations remain described in Tasks D/F/H.

## Native comparison and F/H parity

The final Android C# and IL2CPP compilation produces the arm64 native library used by `live_check.sh`. APK packaging still fails in Gradle `:unityLibrary:lintVitalAnalyzeRelease` with `For input string: "37.0"` after native compilation.

| Census | Same normalized instructions | Layout flags | Semantic flags | Only in game | Re-signed |
| --- | ---: | ---: | ---: | ---: | ---: |
| Task I | 253 | 23 | 39 | 0 | 0 |
| Task F re-check | 629 | 37 | 39 | 0 | 0 |
| Task H expanded re-check | 1280 | 132 | 139 | 125 | 0 |

The raw results are `Evidence/TaskI/native-comparison.json`, `task-f-comparison.json` and `task-h-comparison.json`. Method-level notes are in `native-review.json`, normalized differences in `native-semantic-diff.txt`, and regression explanations in `parity-review.json`. These raw semantic flags remain open comparison results. Full native equivalence has not been established.

Task F's H4 baseline was 630 same, 36 layout and 39 semantic. Task H's H4 baseline was 1272 same, 133 layout, 146 semantic and 125 only-in-game names. The current H exclusion list is identical to that baseline. New F flags arise in unchanged methods from a far load thunk in `MotionLayerPlayable.OnPlayableDestroy`, a tail-call shape in `VLActorFaceModel.Setup` and two beam-getter layout changes. The new H flag is the unchanged `CrowdTimelineTrack` constructor's inferred boundary. Their assembly evidence is included in the parity review. No reconstructed-source regression was identified in this re-check.

Native comparison corrections in commit `c17944e` restore the binder state-machine method names and exact director reference lookup, the beam double-sided getter, entity index/material cleanup, and original initializer order and log text. Commit `e1795e0` adds orderly host shutdown and corrects the double-sided getter to compare `MultiPass = 0`, matching the native immediate. It is the final runtime-source checkpoint. Input hashes in `Evidence/TaskI/SHA256SUMS` and build details in `build-inputs.json` identify the native comparison snapshot.

## Audio finding

This sample's original music asset is an AudioClip named `sud_music_live_ttmr-001-ttmr_true-001`, with 154.583328 seconds of 48 kHz stereo audio. Native `LiveResourceManager.LoadAudioAsync` loads an AudioClip. Its caller passes that clip and an AudioSource to the live binder. The sample timeline references `AudioTrack` and `AudioPlayableAsset`. Native caller evidence is retained under `Evidence/TaskI/client-callers/audio`.

The host follows this observed AudioClip path with the original mixer group and reconstructed binder. Windows selects the game's default DSP clock. Linux uses the game-time clock because its audio device is disabled. All Linux runs use `-noaudio`, `--mute`, listener volume zero and a muted source. Audible playback and synchronization remain unverified.

The managed PJSK CriWare port is already present in `Packages/CriMw.CriWare.Runtime/Runtime/PJSK-Port`, with its import source recorded in `IMPORT.json`. An ACB/AWB music path and CRI audio track scripts have not been found for this sample. The implementation therefore follows the native live caller's AudioClip path, which differs from the task's assumed ACB/AWB input.

## Content

Run the collector on the server with its existing UnityPy environment.

```sh
/data/xy/gakumas/tools/venv/bin/python Tools/prepare_trueend.py Build/Content/ttmr001
/data/xy/gakumas/tools/venv/bin/python Tools/prepare_trueend.py Build/Content-Linux/ttmr001 --target linux
tar -C Build/Content -czf Build/ttmr001-windows-content.tar.gz ttmr001
```

The collector verifies all 31 source bundle hashes. Windows keeps their original DMM DX11 shader programs. The generated resource wrapper contains 268 original objects with 15 exported roots, including the pipeline, actor resources and live mixer group. Each runtime set has 32 `.unity3d` files and `manifest.json`. Linux replaces shader programs with original Android Vulkan programs while preserving PC scene/material references. Per-bundle sources, dependencies, shader replacements and hashes are in `Evidence/TaskI/bundle-sources.json` and `linux-bundle-sources.json`.

The prepared Windows archive is `Build/ttmr001-windows-content.tar.gz`, 171872621 bytes, SHA-256 `d3267c0fa3a97c95215e7ba457cced42db1b19e2b373e56a4df18f414a13a291`. It extracts to a `ttmr001` folder. The runtime manifest SHA-256 is `53f9c5d76acc45eb047a01d728f6dff377b1e63946bebeca28c8287492e72a90`. Recreating the archive can change archive metadata and its hash.

## Remaining limits

- Linux VideoPlayer rejects `eff_cav_mov_ttmr-001.mp4`. The original video remains embedded in the timeline content. Monitor video playback needs checking on Windows.
- Linux llvmpipe frames have strong white blooms and diffuse artifacts. Matching the game's appearance and post-processing has not been established.
- Original resources reference the excluded `ColliderVisualizer.ColliderVisualizeRendererFeature` debug class. Its missing-script warnings remain. The original DMM timeline also contains `VL Paraffin Volume Track` with a null script reference. That authored missing reference is retained.
- Flare transform registration logs three null-transform performance warnings. Playback continues through the end.
- The semantic flags and prior Tasks D/F/H reconstruction limits remain visible in the comparison evidence. The successful playback establishes execution of this sample and its observed elements.

## Windows build on the PC

The prepared build uses Unity 6000.0.77f1, StandaloneWindows64, IL2CPP Release, minimal managed stripping, Linear color space and DX11. `LiveBuild.BuildWindows` writes `Build/Windows/TrueEnd.exe` and the accompanying player files.

Copy the project with its `Assets`, `Packages`, `ProjectSettings` and `.meta` files. Copy the shared fork and original DummyDlls into the following relative layout. Library and Temp are regenerated by the editor.

```text
C:\Gakumas\
  live-urp-codex\
    Assets\
    Packages\
    ProjectSettings\
  work\
    urp14-fork-live\
      com.unity.render-pipelines.core\
      com.unity.render-pipelines.universal\
      com.unity.render-pipelines.universal-config\
      com.unity.shadergraph\
    il2cpp-3.5.3\
      DummyDll\
```

The four local package references resolve through `../../work/urp14-fork-live` from `Packages`. The IL postprocessor reads the original DummyDll metadata during compilation. Its paths are configurable through `QA_RECON_PROJECT` and `QA_RECON_DUMMYDLL`.

Run in PowerShell from the copied project directory.

```powershell
$project = (Get-Location).Path
$env:QA_RECON_PROJECT = $project
$env:QA_RECON_DUMMYDLL = 'C:\Gakumas\work\il2cpp-3.5.3\DummyDll'
New-Item -ItemType Directory -Force "$project\Build" | Out-Null
& 'D:\tool\unity\6000.0.77f1\Editor\Unity.exe' `
  -batchmode -quit -projectPath $project -buildTarget Win64 `
  -executeMethod LiveBuild.BuildWindows -logFile "$project\Build\windows-build.log"
```

The build log should contain `LIVE_BUILD Succeeded errors=0`. The Windows module, MSVC and SDK supplied on the PC are used by this build.

The server collector produces `Build/Content/ttmr001`. Its 32 `.unity3d` files and `manifest.json` are the runtime content set. An archive is available as `Build/ttmr001-windows-content.tar.gz`. Extract it to `C:\Gakumas\content`, producing `C:\Gakumas\content\ttmr001`. Keep the complete generated `Build/Windows` directory together when copying the player.

```powershell
& '.\Build\Windows\TrueEnd.exe' `
  --sample ttmr001 --data 'C:\Gakumas\content\ttmr001' `
  --start-time 0 --screenshots 30,60,90,120,150 `
  --capture-dir "$project\Build\Windows\captures" `
  -screen-width 1920 -screen-height 1080 -screen-fullscreen 0 `
  -logFile "$project\Build\Windows\player.log"
```

This invocation enables audio and runs through the timeline's end. `--mute` silences the source. `--quit-after N` limits playback by elapsed wall-clock seconds. Screenshot times refer to timeline seconds, and the log records both requested and actual capture times. First-frame shader compilation can delay a capture. The default content path, when `--data` is omitted, is `TrueEnd_Data/StreamingAssets/ttmr001`.

Windows compilation, DX11 appearance, audible playback and embedded-video decoding remain for the PC run.

## Linux build and muted playback

```sh
ulimit -n 65536
QA_RECON_PROJECT="$PWD" xvfb-run -a -s '-screen 0 1280x720x24' \
  /data/xy/.toolchains/unity-6000.0.77f1/Editor/Unity \
  -batchmode -force-glcore -quit -buildTarget Linux64 -projectPath "$PWD" \
  -executeMethod LiveBuild.BuildLinux -logFile "$PWD/Build/linux-build.log"

env SDL_AUDIODRIVER=dummy PULSE_SERVER=unix:/nonexistent LIBGL_ALWAYS_SOFTWARE=1 \
  xvfb-run -a -s '-screen 0 1280x720x24' Build/Linux/TrueEnd.x86_64 \
  -force-vulkan -force-device-index 0 -noaudio \
  -screen-width 1280 -screen-height 720 -screen-fullscreen 0 \
  --sample ttmr001 --data "$PWD/Build/Content-Linux/ttmr001" --mute \
  --start-time 0 --quit-after 600 --screenshots 5,30,60,90,120,150 \
  --capture-dir "$PWD/Build/Linux/captures" -logFile "$PWD/Build/Linux/player.log"
```

Linux uses the original Android Vulkan shader programs with llvmpipe. Shader-source locations can be supplied with repeated `--shader-source` arguments to the collector. Its `--source`, `--game-data` and `--dummy-dll` options configure the original input locations. Collection requires the existing UnityPy environment on the server. The prepared content folder can be copied directly to the PC.
