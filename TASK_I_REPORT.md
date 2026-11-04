# Task I — True End host

## Playback checkpoint

The Linux Mono player builds with zero errors, loads the 31 verified DMM bundles plus a resource wrapper, builds Temari with five model parts and a valid humanoid avatar, binds the original directors through `CampusLiveBinder.SetupAsync`, and starts `CampusLiveTimelineController.Play`. Captures show the moving actor, hair, microphone, stage, camera cuts, equipment, lasers and penlights. A complete muted playback run is in progress. Native comparison and the Task F/H regression censuses are pending.

The original Ultimate pipeline, renderer resources, actor settings, tag/layer definitions and dynamically loaded actor resources come from the original player data. The standalone host supplies file access, process lifetime, window presentation and command-line controls. Reconstructed game methods remain in their original packages.

The host must create `Game3DManager` before loading the stage so scene components can register with its camera. Actor construction initially hides renderers. The native `Live3DPresenter.SetActorsActive` dispatches `IVLActorController.SetRendererActive`, which the host now invokes after binding.

## Audio finding

This sample's original music asset is an AudioClip named `sud_music_live_ttmr-001-ttmr_true-001`, with 154.583328 seconds of 48 kHz stereo audio. Native `LiveResourceManager.LoadAudioAsync` loads an AudioClip. Its caller passes that clip and an AudioSource to the live binder. The sample timeline references `AudioTrack` and `AudioPlayableAsset`, with no CRI audio track scripts found in the bundle. Native caller evidence is retained under `Evidence/TaskI/client-callers/audio`.

The host uses that original clip, its original mixer group and the reconstructed binder. Windows selects the game's default DSP clock. Linux uses the game-time clock because its audio device is disabled. All Linux runs use `-noaudio`, `--mute`, listener volume zero and a muted source. Audible playback remains unverified. The managed PJSK CriWare port is already present in `Packages/CriMw.CriWare.Runtime/Runtime/PJSK-Port`, with its source recorded in `IMPORT.json`. An ACB/AWB music path has not been found for this sample.

## Content

```sh
/data/xy/gakumas/tools/venv/bin/python Tools/prepare_trueend.py Build/Content/ttmr001
/data/xy/gakumas/tools/venv/bin/python Tools/prepare_trueend.py Build/Content-Linux/ttmr001 --target linux
```

The collector verifies all 31 source bundle hashes. Windows keeps their original DMM DX11 shader programs. The generated resource wrapper contains 268 original objects with 15 exported roots, including the pipeline, actor resources and live mixer group. Linux replaces shader programs with original Android Vulkan programs while preserving PC scene/material references. Exact sources, replacement names and hashes are in `Evidence/TaskI/bundle-sources.json` and `linux-bundle-sources.json`.

## Current limits

- Linux's VideoPlayer rejects the embedded monitor MP4. Monitor video playback requires checking on Windows.
- The Linux frames have severe bright and diffuse rendering artifacts. Windows remains the visual reference. Matching appearance has not been established.
- The original resources still reference the excluded `ColliderVisualizer.ColliderVisualizeRendererFeature` debug class. Its missing-script warnings remain.
- The new census contains 314 native names selected from changed methods and initializers. Compilation, native comparison and Task F/H results will be recorded after the current build finishes.
- Final portable Windows copy/build/run instructions are pending.
