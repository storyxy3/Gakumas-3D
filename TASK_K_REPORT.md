# Task K — True End ending

## Result

Restored the shadowed-beam intensity multiplier and VLB shader globals, including the original blue-noise texture and reversed-depth flag. Added the client's end-of-live pause and black fade to the standalone host. Capture runs and `--quit-at-end` request exit directly after presentation; default interactive runs remain open on black.

All changes are in `live-urp-codex` / `codex-f`. No tests were written or run, no Windows machine was accessed, the shared URP fork was not edited, and nothing was pushed.

## Causes and fixes

### Closing-shot brightening

`VLBDrawSystem.ExecuteHD` uploaded `drawCallChunk.colors[j]` unchanged. APK 3.5.3 `0xe0cc454`, specifically `0xe0cc66c–0xe0cc6a8`, multiplies this vector by `max(params1.c0.y, params1.c1.y)`: the inside/outside beam intensities. The reconstruction dropped that multiplication, so authored changes in intensity did not dim the shadowed beam.

The closing shot's `Campus Light Track (7)` controls light 109. Its overlapping clips change intensity from 0.1 to 1 over 151.0–151.8333. A separate head-anchored light changes 0 to 0.6 over 151.0–153.0. The volume/light clips already exist and their weighting path was retained. This brightening is authored lighting, not an additional screen fade.

Commit `b810ea0` restores the APK multiplication for every shadowed volumetric beam. `beam-hd.asm` and `ending-authored-data.json` contain the native and asset evidence.

### Background flicker

`VLB.Config.RefreshGlobalShaderProperties` was empty. `ShaderProperties.HD` also left its IDs at zero. Consequently the original 256×256 Alpha8 `VLBBlueNoise` texture was present in the content but never bound to `_VLB_JitteringNoiseTex`.

The original shadow-beam fragment shader samples that texture's alpha, adds `_ShadowParam.y`, and takes the fractional part to offset its raymarch samples. The existing CPU phase is `frac(floor(Time.timeAsDouble * 60) * 1.61803399)`, as in the APK. Without spatial noise, its temporal phase changes the beam coherently across pixels. The supplied Windows captures and baseline Linux captures show the resulting large, repeated changes in mean background brightness.

Commit `c0026b1` restores the complete shader-global method and HD property IDs. It also restores `_VLB_UsesReversedZBuffer`, dithering globals, the authored 2D noise texture, and camera blending distance. The original duplicate assignment to `GlobalNoiseTex2D` is retained. No seed, damping, brightness clamp, or replacement temporal filter was added.

The client calls this method from `Config.OnStartup`. The host loads its original Resources bundle asynchronously, so it invokes that same private method after loading the bundle and selecting the pipeline. This dispatch is host glue. The other unrelated Config stubs were not expanded.

`config-asset.json` confirms the existing Windows content references the required texture; `native-config` and `original-shadow-beam.frag.glsl` document the upload and consumer.

### Missing fade-out

The fade belongs to client presentation. APK `LivePresenter.CheckLiveEnd` (`0x863e52c`) checks the float timeline time against float duration minus 0.4. `OnEndLiveSequence` (`0x8634254`) pauses the live, and `LiveScenePresenter.OnLiveEndAsync` (`0x67119c8`) requests a black overlay over 0.3 seconds through `LiveSceneView.FadeBlackTintAsync` (`0x6711904`).

The fade method calls `CanvasGroupExtensions.DOFadeBlocking` (`0x7470db0`). That helper and `SetBlockingAlpha` (`0x7470d0c`) are now reconstructed, using the existing DOTween implementation and its easing. The final comparison matches `DOFadeBlocking`, its generated getter, and its constructor exactly; the alpha setter has only a layout flag.

Commit `6a5a1f5` connects the threshold, pause, and tween to the host. Commit `af8be86` lets the C# compiler generate the original closure names. The standalone host creates the overlay alpha holder, draws black over its existing display, and advances a presentation clock while the director is paused. Commit `80a0404` uses an opaque white texture tinted black for the host overlay. These are host glue; it does not import the game's result screens, network calls, or scene navigation.

With this asset's 155.6-second duration, the native threshold is approximately 155.2 and the 0.3-second fade finishes around 155.5. The supplied DMM labels show fading around 154.9–155.2 under the stipulated recording offset of +3.1 seconds. This approximately 0.3-second timing difference remains unresolved; the implementation keeps the APK constants instead of fitting a new offset to the recording. `end-clock.asm` confirms the client reads the director time directly.

### Host exit

Previously `Application.Quit()` was after multiple asynchronous scene-unload/frame waits. The ending Windows capture directory has no shutdown log, and the earlier supplied Windows log does show a successful shutdown; the precise reported Windows stall cannot be established from those files.

Commit `4883ae9` removes the dependency on that asynchronous cleanup path. When `--screenshots` or `--quit-at-end` is set, the host logs `LIVE_QUIT` immediately after `LIVE_STOPPED` and requests application exit, leaving shutdown teardown to Unity. An initial direct-exit capture revealed renderer-owned buffer and culling-group warnings. Commit `7e97822` adds synchronous `UniversalRenderPipelineAsset.DestroyRenderers` dispatch before exit and on manual application quit. This is the existing cleanup used by the pipeline asset’s `OnDisable`; it requires no scene-unload await. The wall-clock `--quit-after` limit also requests exit. With no automatic-exit option, it logs `LIVE_IDLE` and retains the final black screen until the user closes the window. README documents these behaviors.

## Captures and brightness continuity

The ending comparison uses the supplied Windows and DMM captures plus before/after Linux captures at 1280×720. Linux requests cover 148.0–155.5 every 0.1 seconds, with an additional final 155.6 capture. The source images remain in `.recon/task-k/{before,final}-ending`; logged times and means are retained in `Evidence/TaskK/ending-luminance.csv`.

The measure is mean encoded-RGB luma, `0.2126 R + 0.7152 G + 0.0722 B`, on the task's background and character boxes, scaled to each image resolution. These are luminance-continuity measurements, not pixel comparisons. Absolute Linux brightness remains different from Windows/DMM.

For the stable closing-shot interval 153.0–154.8 (18 adjacent pairs):

| Source | Background mean absolute change | Background maximum change | Character mean absolute change |
| --- | ---: | ---: | ---: |
| DMM | 0.790 | 1.308 | 1.470 |
| Supplied Windows before | 5.265 | 13.792 | 5.076 |
| Linux before | 3.738 | 8.588 | 7.191 |
| Linux final | 0.344 | 0.588 | 1.829 |

The final Linux background loses the repeated sawtooth pattern. Its closing-shot brightness rises smoothly from roughly 98 at 151.0 to 180 at 153.0; the baseline starts around 157 and fluctuates around 170–175. This demonstrates the restored authored brightening while retaining the known Linux shading difference.

The final ending run records `LIVE_END_FADE time=155.300000153482 duration=0.3`, reaches `fadeAlpha=1`, captures a completely black frame at presentation time 155.6, and logs `LIVE_STOPPED` then `LIVE_QUIT`. It exits with code 0 and has no exceptions, buffer-finalizer warnings, or undisposed culling group. Linux's approximately 0.1-second timeline steps defer the float threshold by one step; the native float subtraction is preserved.

[Ending luminance plot](Evidence/TaskK/ending-luminance.png), [first contact sheet](Evidence/TaskK/ending-contact-1.jpg), [second contact sheet](Evidence/TaskK/ending-contact-2.jpg), and [final black frame](Evidence/TaskK/ending-black.png) show the measurements and captures.

The across-live scan uses 165 captures in fifteen one-second windows (5–6, 15–16, …, 145–146), both before and after at 640×360. Adjacent pairs crossing an authored camera cut are excluded from the numeric summaries. `live-luminance.csv`, `luminance-summary.json`, and `live-continuity.png` retain every measured frame/window.

The authored shadowed-beam intervals for seven lights are listed in `shadowed-beam-intervals.json`: approximately 4.733–5.033, 15.467–15.583 and 16.333–16.450, 33.050–33.233, 100.250–100.800, 107.250–108.733, 147.183–147.283, and 150.933–155.600. The long ending hold makes this shared draw-path defect most apparent. The common fix covers all seven lights.

An additional 32 captures cover 100–101 and 107–109 seconds, including the longer non-ending shadowed-beam intervals. The background jumps when the beams activate around 100.25 and 107.25; these onsets are authored. The following curves do not show the regular repeating ending sawtooth. `beam-section-luminance.csv` and its plot retain the measured changes and camera-cut markers. Fast camera motion, designed flashes and particle activity still produce large luminance changes elsewhere; the scan does not classify every change as flicker or establish 60-fps Windows temporal equivalence.

Most sampled windows retain closely matching broad brightness profiles; for example, mean adjacent background changes at 15–16 / 35–36 / 95–96 seconds are 8.08 / 1.66 / 6.86 before and 8.31 / 1.62 / 6.90 after. Isolated deviations remain around 85.3, 125.4 and the end of the 145–146 window. These lie outside the authored shadowed-beam intervals, and the sparse, differently phased samples do not establish their cause. They are retained in the plot for PC review rather than claimed as solved. The scan covers selected windows, not every frame of the live.

## Native comparison and parity

All final comparisons use the arm64 library built after the last runtime-source commit `80a0404`, against APK 3.5.3. Task K adds seven method names (eight bodies because `ExecuteHD` has two overloads).

| Census | Same normalized instructions | Layout flags | Semantic flags | Only in game | Re-signed |
| --- | ---: | ---: | ---: | ---: | ---: |
| K | 5 | 1 | 1 | 0 | 0 |
| F | 631 | 35 | 39 | 0 | 0 |
| H expanded | 1271 | 138 | 142 | 125 | 0 |
| I | 252 | 23 | 40 | 0 | 0 |
| J | 90 | 20 | 19 | 0 | 0 |

K's remaining `ExecuteHD` semantic flag covers one fewer list lookup in the unchanged outer overload and a class-initialization call in the inner overload. The restored intensity operation was reviewed against the native instructions. `native-semantic-diff.txt` retains the raw differences; full instruction equivalence is not claimed.

F/H/I/J missing-name lists are unchanged. F and J have no new/reclassified flags. H flags unchanged `CampusActorController.InitializeActorAnimation` (layout), `InitializeExpression` (metadata/thunk attribution), and `CampusActorModelParts.InitializeCampusMaterials` (trailing inferred function interval). I flags the unchanged fully shared `Chunk.ResizeArray` instantiation, whose inferred interval includes neighboring UniTask methods. The animation layout difference omits unused method-info arguments. No reconstructed-source regression was identified; these raw flags are retained rather than treated as full native equivalence. Results and review are in `task-*-comparison.json`, `parity-review.json`, and `parity-new-flags.txt`.

`LAYOUT.md`, `LAYOUT-ALL.md`, and `Tools/build-artifacts.json` were restored after the comparison dump.

## Build and PC handoff

The final Linux player builds with `LIVE_BUILD Succeeded errors=0`. Android C# and native compilation complete; Gradle packaging reaches the existing `lintVitalAnalyzeRelease` / `For input string: "37.0"` failure. The comparison library is the newly built arm64 library, not the earlier artifact.

The final full run produces all 165 requested captures, reaches the client end threshold at director time 155.2844, finishes presentation at 155.6844 with fade alpha 1, and exits with code 0. The focused beam-section run produces all 32 captures and exits with code 0 at its explicit 180-second wall-clock limit. All three final runs have zero exceptions, zero graphics-buffer finalizer warnings, and zero undisposed-culling-group warnings. The final ending, full-playback and beam-section logs are committed in `Evidence/TaskK`. `build-inputs.json` records native/managed/content hashes and the source commit.

All Linux runs used `--mute -noaudio`, `SDL_AUDIODRIVER=dummy`, and `PULSE_SERVER=unix:/nonexistent`. Logs retain the known missing-script messages and unavailable Linux video decoder/audio-device messages; monitor-video or general shader parity on Linux is not claimed.

Claude must copy the updated project code, including `Assets/TrueEndHost`, the new `CanvasGroupExtensions.cs` and its metadata in `campus-submodule.Runtime`, and the three changed VLB files (`VLBDrawSystem.cs`, `Config.cs`, `ShaderProperties.cs`). Rebuild the Windows IL2CPP player using `LiveBuild.BuildWindows`. The shared URP fork and original content require no changes for this task.

The existing `Build/ttmr001-windows-content.tar.gz` is reusable: SHA-256 `d3267c0fa3a97c95215e7ba457cced42db1b19e2b373e56a4df18f414a13a291`; Windows manifest SHA-256 `53f9c5d76acc45eb047a01d728f6dff377b1e63946bebeca28c8287492e72a90`.

On the rebuilt PC player, review 151–153 seconds for the authored brightening, 153–154.8 for background stability, and the final black fade. Review other shadowed-beam sections using the continuity schedule. Capture playback should close automatically; a normal run should stay open and `--quit-at-end` should close it. Windows appearance, shutdown behavior, and the remaining recording-time discrepancy need that PC review; this task used only muted Linux playback.

## Reproducing the Linux captures

After `LiveBuild.BuildLinux`, the final ending invocation is:

```sh
env SDL_AUDIODRIVER=dummy PULSE_SERVER=unix:/nonexistent LIBGL_ALWAYS_SOFTWARE=1 \
  xvfb-run -a -s '-screen 0 1280x720x24' Build/Linux/TrueEnd.x86_64 \
  -force-vulkan -force-device-index 0 -noaudio \
  -screen-width 1280 -screen-height 720 -screen-fullscreen 0 \
  --sample ttmr001 --data "$PWD/Build/Content-Linux/ttmr001" --mute \
  --start-time 145 --quit-after 900 \
  --screenshots "$(cat Evidence/TaskK/ending-times.txt)" \
  --capture-dir "$PWD/.recon/task-k/final-ending" \
  -logFile "$PWD/.recon/task-k/final-ending.log"
```

The full pass uses 640×360, start time 0, wall limit 1800, and `continuity-times.txt`. The beam-section pass uses 640×360, start time 98, wall limit 180, and `beam-section-times.txt`. Both use the same silent environment/options. Native comparison uses the existing `live_check.sh` / `urp_func_diff.py`, Task K's `census-regex.txt`, and the previous F/H-expanded/I/J census regexes.
