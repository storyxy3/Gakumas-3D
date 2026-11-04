# Task J — True End and the DMM recording

## Result

Five committed fixes restore the instanced audience rendering path, correct laser ribbon orientation, restore stage anchors for the microphone and stand, correct the crowd billboard depth format, and copy the original live timestep settings.

The final Linux player builds with `LIVE_BUILD Succeeded errors=0`. Its muted playback reaches 155.6 seconds, produces all 277 requested captures, and exits with code 0. The final log contains zero exceptions. The Android native compilation completed and supplied the final arm64 comparison library. Android packaging reaches the existing Gradle failure in `lintVitalAnalyzeRelease` with `For input string: "37.0"`.

Linux renders the audience and laser fans. Its overall shading, motion blur, depth-of-field appearance, and monitor video still differ from DMM. Windows appearance and video playback require Claude's rebuilt PC player.

## Fixes and commits

| Commit | Change | Evidence |
| --- | --- | --- |
| `1338619` | Correct `LiveLaser.LaserVertexJob.LookCamera` quaternion multiplication order | `Evidence/TaskJ/laser.asm`, `laser-reconstruction.txt` |
| `72cf626` | Reconstruct crowd culling, buffers, GPU compute, billboard baking, instanced crowd and penlight draws, and disposal | `Evidence/TaskJ/native`, `render.asm`, `setup-compute.asm`, `billboard-matrices.asm` |
| `6a90829` | Restore `SetPropFieldConstraintTarget` and `ClearPropFieldConstraintTarget` | Native caller bodies and `Evidence/TaskJ/before-props` |
| `1f19095` | Use native `D16_UNorm` for the crowd billboard depth attachment and texture | Native billboard constructor and initial comparison |
| `7506960` | Copy original fixed timestep, maximum frame timestep, and particle timestep | `Evidence/TaskJ/original-time-manager.json` |

The crowd renderer feature, render systems, setup data, culling jobs, and GPU buffer operations were empty stubs. The original crowd layout, animation, timeline, meshes, shaders, and materials were already collected. The reconstructed feature registers the native PreDepth, GBuffer and motion-vector callbacks, schedules culling and animation, updates person and penlight buffers, bakes the billboard atlas, and submits the original detailed and billboard draw paths. The generic `EnumerableExtensions.ForEach` overload used during buffer cleanup was also restored from the APK.

The laser job previously multiplied the incoming beam rotation on the right. APK `0xddb7d94` produces `rotation * (invRoll * AxisAngle(Z, angle))`. This fixes the camera-facing ribbon orientation. The final native comparison classifies this method as a layout difference with matching normalized semantic instructions.

The prop binder already called `SetPropFieldConstraintTarget`, but its body was empty. Restoring the field-constraint lookup gives the microphone and stand their authored stage anchors. Both reconstructed prop methods have identical normalized instructions in the final comparison.

The original DMM `TimeManager` contains fixed-step count `5644799 / 141120000`, maximum timestep `0.1`, and maximum particle timestep `0.04`. Copying these settings addresses the project-default discrepancy. Frame-rate-sensitive particles and secondary motion still need the PC comparison.

## Comparison method

The capture schedule contains 277 requested times from 0 through 155 seconds. It combines a 2.5-second grid with samples 0.35 seconds before and after the starts of 108 authored camera shots. Very short shots can fall between samples. `Evidence/TaskJ/camera-cuts.json` records the shot list and its source, and `capture-times.txt` records the requests.

Each pair uses the actual timeline time written by `LIVE_CAPTURE`. The maximum requested-time overshoot was 0.153 seconds. The DMM frame is the nearest 60-fps frame at `actual + 3.1` seconds, using the supplied alignment. Camera composition and primary actor poses agree across most of the reviewed sequence within that alignment's approximately 0.1-second precision. The DMM active image is cropped to `(0,131,1920,818)` and Linux to `(0,88,1280,544)`, then each is resized to 640 by 272. The top-right recording overlay is outside the crop.

`Evidence/TaskJ/pairs` contains all 277 side-by-side images with DMM on the left. All 47 contact sheets were visually reviewed. `frame-index.json` records requested times, actual times, selected recording frames, and source capture paths. `final-full-playback.txt` records the final run. The earlier complete playback is retained in `initial-full-playback.txt`, and the two prop comparisons before the fix are in `before-props`.

### Differences

Times below are requested timeline seconds. The pair labels and index give actual times.

| Time / element | DMM | Player observation | Cause and status |
| --- | --- | --- | --- |
| 5, 25, 30, 37.5, 40 and other auditorium views — crowd | Dense rows of moving blue-white penlights and audience silhouettes | Original PC captures had empty floor sections. Final Linux frames contain crowd bodies and penlights across those sections | **Fixed missing drawing path.** Native crowd systems were stubs. Exact distant-row coverage and brightness remain for PC review because Linux greatly brightens the auditorium and seats |
| 21.017, 29.45–31.95, 42.283, 45–50, 92.5–94.783 — lasers | Thin purple, blue and yellow ribbons and fans | Final frames show those ribbons and fans in the stage lighting. The 90-second overhead view is strongly overexposed on Linux, limiting comparison of its thin beams | **Fixed orientation defect.** Reversed quaternion product in `LookCamera`. Per-frame intensity and alignment remain subject to Linux rendering and the recording offset |
| 4.683, 16.883, 17.5, 20, 37.917 — props | Microphone in the opening stand, hands moving around it, then handheld microphone | Before-fix frames lacked the opening microphone/stand. Final frames show the stage props and later handheld microphone | **Fixed.** Empty field-constraint target methods |
| 0 — opening presentation | Black frame with a small loading indicator at recording time 3.1 | The standalone host already displays the stage and its first frame has strong smearing | **Open host presentation difference.** The host starts the live directly. Client loading/fade presentation and first-frame temporal history are outside the restored live binder |
| 2.5–18.65, 25–40, 42.5–50 — diffuse lighting, fog and bloom | Dark auditorium, localized light pools and shafts, readable stage structures | Linux lights much more of the floor, seats and structures, clips some pools to white, and shows bright cyan contours | **Open.** Linux uses Android Vulkan programs on llvmpipe. The supplied earlier Windows captures are substantially closer to DMM. These frames cannot isolate a remaining shader, pipeline, or driver cause |
| 9.75–11.25 and 23.717–24.35 — focus and flares | Soft foreground/background focus with localized flare cores and streaks | Flare origins and beams are present, but Linux focus transitions, bright edges, and flare halo size differ | **Open.** Depth/temporal/post-processing appearance requires the DX11 comparison |
| 11.95–13.617, 43.717, 46.817–48.45, 50.55–51.083 — actor and hair | Primary pose and camera match the sequence, with stable facial detail and flowing hair | Linux preserves the primary action but smears moving features and gives different hair/cloth silhouettes | **Partially addressed.** Original fixed and maximum timestep settings are restored. Slow rendering, temporal effects, and secondary simulation still differ. Exact secondary-motion parity is open |
| 21.017–30, 38.817–40.817, 44.983–52.45, 86.783–87.5, 102.417–104.217 — monitor video | Animated clouds, blue cells, triangular patterns, and bright video transitions on the central and side screens | Linux video areas stay dark while the surrounding authored LED strips and lighting animate | **Open on Linux.** `VideoPlayer cannot play clip` identifies the decoder failure. Windows bundle and playback path are retained and inspected below |
| 70–73.583, 77.5–78.783 — blue particle burst | Blue curved trails rise over the stage and fall toward the crowd | The burst is present at the matching stage of the live, with shorter or differently shaped trails on Linux | **Partially addressed.** Original particle timestep is restored. The remaining shape, phase and brightness difference is unresolved under the slow Linux rendering cadence |
| 107.5–108.383, 114.083–115.65 — spark jets | Paired gold/white spark jets rise from the stage sides and disperse overhead | Both jets are present in the matching shots, with differences in individual spark positions and trail lengths | **Open appearance difference.** Original particle settings are restored, while simulation cadence, randomness and Linux post-processing prevent an exact visual match |
| 127.883–128.817, 131.817, 137.117–138.317 — late spark fountains | Narrow white particle columns beside the actor | The columns are present, with different individual particle positions and apparent width | **Open appearance difference.** Same particle-cadence and Linux brightness limitations as the earlier bursts |
| 146.717 and 147.75 — rapid camera cuts | One sample still shows the preceding wide shot, another the preceding hand close-up | Linux has already advanced to the following authored shot. Neighboring samples show the same sequence | **Open timing comparison.** The supplied 3.1-second recording offset has approximately 0.1-second precision, comparable to these boundary discrepancies. Sub-frame cut timing needs a refined recording alignment and the PC capture |
| 149.983–150.583 and 151.283–155 — ending crowd and actor | Waving crowd, followed by a darker blue actor close-up | Crowd and closing shots are present. Linux has a larger haze/flare footprint and different hair silhouettes | **Open appearance difference.** The restored crowd is visible through the ending, while the recurring rendering and secondary-motion differences remain |

The brightness, monitor-video and secondary-motion differences recur in later shots, including 95–105, 117.5, 120–125, 127.5 and 132.5–143.383 seconds. Close audience views at 95, 128.817 and 130.85 show the restored bodies and penlights, with different apparent crowd brightness and wave phase. Precise per-person animation phase remains open for the PC comparison.

## Monitor video and Windows path

DMM visibly plays the central monitor video, including cloud imagery around 22.5 seconds, blue cells around 28.75 seconds, and moving nested triangles around 45–51 seconds. Linux reports failure to play `eff_cav_mov_ttmr-001.mp4`.

The Windows content contains the original `eff_cav_mov_ttmr-001` VideoClip and embedded resource. Its metadata records 768 by 432 pixels, 30 fps, 4711 frames, and a 9,980,687-byte embedded stream. The bundle hash and metadata are in `Evidence/TaskJ/monitor-video.json`.

The timeline binds the Unity `VideoPlayer` and `VideoImage`. `CampusVideoPlayerTrackBehaviour` prepares the clip, enables the image on `PrepareCompleted`, plays in `APIOnly` mode, and synchronizes using clip-local time. `VideoImage.LateUpdate` takes `VideoPlayer.texture` for the canvas. The host leaves this path available on Windows. Its methods are included in the Task H re-check.

The supplied earlier Windows `player.log` records a decoded first frame at index 2, and its 30-second capture visibly shows blue video imagery on the central screen. This confirms that the existing Windows path has decoded and displayed the embedded clip. Playback in the rebuilt Task J Windows player remains for Claude to observe.

## Final native comparison and parity

All comparisons use the arm64 library compiled after runtime-source commit `7506960` and the game's APK 3.5.3 library. The Task J census contains 129 native method names with source paths and APK addresses. The Task H re-check uses the expanded H4 census.

| Census | Same normalized instructions | Layout flags | Semantic flags | Only in game | Re-signed |
| --- | ---: | ---: | ---: | ---: | ---: |
| Task J | 90 | 20 | 19 | 0 | 0 |
| Task F | 631 | 35 | 39 | 0 | 0 |
| Task H expanded | 1272 | 138 | 141 | 125 | 0 |
| Task I | 252 | 23 | 40 | 0 | 0 |

Raw results are in `native-comparison.json` and `task-{f,h,i}-comparison.json`. `native-semantic-diff.txt` and `native-review.json` explain the Task J flags. Remaining differences include `sizeof(uint/int)` versus `Marshal.SizeOf`, inlining, cached camera ID queries, constant and metadata placement, and inferred function boundaries. The penlight constructor also disposes the unused secondary buffer returned during initialization. These raw flags remain open native comparison results.

`parity-review.json` and `parity-new-flags.txt` retain the F/H/I changes relative to Task I's final snapshot. New flags occur in unchanged methods and involve constructor inlining, unused method-info arguments, generic metadata/thunks, and inferred intervals that include following functions. The F/H/I missing-name lists match their prior lists. No reconstructed-source regression was identified in this review. Full native equivalence remains unestablished.

Build results and input hashes are in `build-summary.txt` and `build-inputs.json`. The final playback retains the known missing-script warnings, disabled-audio initialization messages, and Linux video-decoder failure described in Task I.

The final capture used the following invocation after the final Linux build.

```sh
env SDL_AUDIODRIVER=dummy PULSE_SERVER=unix:/nonexistent LIBGL_ALWAYS_SOFTWARE=1 \
  xvfb-run -a -s '-screen 0 1280x720x24' Build/Linux/TrueEnd.x86_64 \
  -force-vulkan -force-device-index 0 -noaudio \
  -screen-width 1280 -screen-height 720 -screen-fullscreen 0 \
  --sample ttmr001 --data "$PWD/Build/Content-Linux/ttmr001" --mute \
  --start-time 0 --quit-after 2400 \
  --screenshots "$(cat Evidence/TaskJ/capture-times.txt)" \
  --capture-dir "$PWD/.recon/task-j/final-captures" \
  -logFile "$PWD/.recon/task-j/final-playback.log"
```

## PC handoff

Claude must copy the updated project code and `ProjectSettings/TimeManager.asset` to the PC and rebuild the Windows IL2CPP player using the Task I `LiveBuild.BuildWindows` entry. The five fixes require a player rebuild.

The existing Windows content archive remains usable because this task's fixes are in runtime code and project timing settings. The archive is `Build/ttmr001-windows-content.tar.gz`, SHA-256 `d3267c0fa3a97c95215e7ba457cced42db1b19e2b373e56a4df18f414a13a291`. Its manifest SHA-256 is `53f9c5d76acc45eb047a01d728f6dff377b1e63946bebeca28c8287492e72a90`.

On the rebuilt PC player, review the audience at 5, 30, 60 and 150 seconds, purple/yellow lasers at 90 and 92.5 seconds, stage-anchored props at 4.683 and 16.883 seconds, and monitor video at 22.5, 45, 90 and 120 seconds. Review the late particle effects and the open shading/temporal differences against the recording. Use actual `LIVE_CAPTURE` times with the same recording alignment.
