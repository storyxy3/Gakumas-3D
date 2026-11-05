# Task L handoff — 2026-11-05 16:56 HKT

Stopped because HANDOFF_NOW appeared at 16:55:55 (64% / user limit 65%). No new work after saving this handoff. User must raise quota / clear the marker before resuming. Read COMMON.md and check HANDOFF_NOW after every command/edit batch.

## Rules and task

Task: `/data/xy/gakumas/work/codex/TASK_L_skirt_physics.md`, tree `/data/xy/gakumas/live-urp-codex`, branch `codex-f`. Never write/run tests or verification harnesses. Never access the Windows PC, never push, never edit shared URP fork or old player. APK 3.5.3 is source of truth. Linux runs silent. Only compile/function comparison for code validation; brief explicitly also asks for playback geometry measurements/captures. Task K report and PHYSICS.md read. Need finish TASK_L_REPORT.md and final user summary, including PC instructions. No final report exists yet.

## Committed source work (all builds successful as described below)

- `cdeb467` Add optional read-only pose recording to live host. `Assets/TrueEndHost/LivePoseRecorder.cs`, `--pose-log`, asmdef refs. Copies final transforms and live NativeList state at ~0.1-second simulation intervals. Does NOT evaluate/modify animation graph. First recorder run hit NativeList LINQ enumeration NotImplementedException; corrected to indexed copy before this commit. Current recordings are successful.
- `ece66b1` **Actual physics fix:** restore APK return swizzles in `ActorAnimationMathUtility.ToEuler`. Five branches omitted axis rearrangements after ThreeAxisRot. XYZ must return `.zyx`, XZY `.zxy`, YXZ `.yzx`, YZX `.xzy`, ZXY `.yxz`, ZYX unchanged. All eight Temari skirt drivers use XYZ. Error fed swapped X/Z angles to skirt root limits/coefficient mapping. No collider sizes/masks/coefficients/solver iterations changed. Also affects other Quartz users of this shared helper.
- `7d497cd` Host capture controls `--capture-fps` (Unity capture clock), `--stop-time`, explicit skirt-chain hit counts; README. Last runtime source change. Linux + Android rebuilt after it. No further runtime source edits.

A WIP evidence commit is being made immediately after writing this handoff; get its hash with git log. Only evidence/docs were uncommitted at handoff.

## Native evidence and parity — DONE, do not redo absent source edits

`Evidence/TaskL/to-euler-game.asm`, `to-euler-rebuilt.asm`, `to-euler-review.md`, `to-euler-comparison.json`.
APK ToEuler `0x657cb30`; rebuilt `0x277e050`. **205 normalized instructions vs 205, exact equality**, including return moves. Prior build had 182 instructions. Task H explanation of this semantic flag as equivalent dispatch/inlining was WRONG. Hex-Rays untyped return hid register shuffles. The comparator's full norm retains moves, its semantic summary omits them.

Build logs `.recon/task-l/build-fixed-linux.log`: `LIVE_BUILD Succeeded errors=0`. `.recon/task-l/build-android.log`: C#/IL2CPP/native complete, existing Gradle `lintVitalAnalyzeRelease` / `For input string: "37.0"` packaging error. Native library timestamp 16:39:32. Final source snapshot `7d497cd`.

Ran live_check.sh on expanded L census, restored LAYOUT.md/LAYOUT-ALL.md/Tools/build-artifacts.json. WARNING: il2dis.py caches script.pkl without checking JSON age. Deleted stale **own** `.recon/live-dump/script.pkl`, regenerated before saving rebuilt assembly. Saved raw evidence is now correct. `urp_func_diff.py` reads JSON directly and comparisons were unaffected.

Final comparison files in Evidence/TaskL:
- F: 631 same / 35 layout / 39 semantic / 0 missing
- H expanded: 1272 / 139 / 140 / 125 missing
- I: 252 / 23 / 40 / 0
- J: 90 / 20 / 19 / 0
- K: 5 / 1 / 1 / 0
All re-signed = 0; all missing lists unchanged from Task K. F/I/J/K flags unchanged. H ToEuler resolves, InitializeExpression flag also resolves. H InitializeCampusMaterials reclassifies to layout: two unchanged metadata pointer loads hoisted around List.get_Item. H CreatePlayable gains semantic b FN because linker moves `ldr x20,[x20,#0xe40]` into thunk at 0x50a7664, then jumps back to 0x4e1d01c. Exact thunk and raw method saved. `parity-review.json` and `parity-new-flags.txt` document it. No reconstructed source regression found; don't claim entire library instruction equivalence.

L broad census: 556 names, 370 same / 59 layout / 115 semantic / 12 missing. `census-scope.json` separates runtime families (488 names: 369 same / 56 layout / 63 semantic) from dormant SimpleBone MonoBehaviours, ActorSwingGroup, non-Campus ActorAnimationJob generic specializations, and three no-live-caller configuration methods. Dormant stubs kept explicit. `nonlive-direct-callers.json` is APK branch-call audit, not proof against reflection/virtual dispatch. Do NOT claim all those stubs are implemented.

## Asset / pipeline findings

`body-authoring.json`, `scene-physics-settings.json` retained. Body: 90 dynamic / 24 static / 8 Skirt drivers / 4 HumanoidUpLeg / 2 chains. Hair: 96 dynamic / 10 Hair drivers / 1 chain. Face: 1 static. Actual live rig: 186 dynamic / 25 static / 69 chain segments. No Waist drivers or SimpleBone components in these actor assets. Static UpLeg + knee-to-hip Line colliders have matching short/long skirt masks; signed negative capsule half heights are correctly preserved. Seated correction disabled by motion asset; timeline cmmn-height flag 0. Root scale observed 1. Static job capsule positions match final transform-derived positions to ~1e-7 m in inspected sample. Chains update and hit. Their collisions could not compensate for incorrectly driven skirt roots and the subsequent native angle limits.

## Captures — ALL FINISHED at handoff, no Unity players or measurement processes active

Everything under `.recon/task-l`. All silent with SDL_AUDIODRIVER=dummy, PULSE_SERVER=unix:/nonexistent, LIBGL_ALWAYS_SOFTWARE=1, `--mute -noaudio`, xvfb, Vulkan. Logs end LIVE_STOPPED/LIVE_QUIT, no exceptions in successful runs. Need collect logs/hash/provenance into final evidence and count warnings/exceptions.

Full ordinary-clock runs:
- `before-poses.jsonl` (~520 MB), `before-scan/`, `before-scan.log`: original source/Burst, start 0, 15 captures at 10,20,...150. 1551 recorded samples, ends 155.29231 + fade. Typical Time.deltaTime=.1 because Linux slow.
- `after-poses.jsonl`, `after-scan/`, `after-scan.log`: fixed source/Burst, equivalent full pass, ends 155.228926 + fade. Complete.

60-fps capture-clock pairs, same start/stop and exact actual timestamps:
- `before-focus` / `after-focus`: start 42, stop 49.5; screenshots 43.8,44,47.8,47.9,48,49; each 76 pose samples. Includes strong clipping from full scan, though these cameras often hide skirt.
- `before-late` / `after-late`: start 115, stop 117.5; screenshots 116.1,116.3,116.5,116.7,117; each 26 samples. Complete and already measured.
- `before-visible` / `after-visible`: start 70, stop 72; screenshots 71,71.2,71.4,71.6. Complete, NOT YET MEASURED/VIEWED. Chosen because DMM full-body view shows skirt.
Each tag has `<tag>-poses.jsonl`, `<tag>.log`, and screenshot directory `<tag>/`.

### CRITICAL baseline binary provenance

`.recon/task-l/before-player/` is preserved original compiled Linux player. `.recon/task-l/paired-before-player/` is final player/host with original ActorAnimation.Runtime.dll **AND original Plugins/lib_burst_generated.so** (and matching old pdb). This lets both pairs use the final host's capture clock while physics is genuinely before/after.

First attempt only replaced managed DLL, forgot Burst, so both copies executed fixed physics. Those invalid baseline captures were moved into `.recon/task-l/shared-burst-captures/`. NEVER USE THEM. The current before-focus/before-late were rerun after replacing old Burst, and before-visible started with correct old Burst. Valid after copies were retained.

Hashes:
- Before managed ActorAnimation.Runtime.dll: c6d5625e4be33312db4a40d1203c7fa72177dc8acc405533424a4128191cb05b
- After managed: 603c9f21f0e11b06c583967337c9f1e021411106418984515ee10383ed42bc2b
- Before Burst (original + paired baseline): 3a5865e1d9faeb6ac8233f24af4715947a2d4e3d42de8b5f56dd0c63741d231a
- After Burst: 15c165e3978240376e76b84062ceafea396320d673dde5be57c93476957a29f0

## Measurements and next steps

`Evidence/TaskL/measure_poses.py` consumes saved JSONL only; no scene/solver/assertions. Needs system `python3` (has numpy/scipy), NOT tools/venv Python (no scipy). `measurement-method.md` explains world capsule reconstruction, masking, sphere overlap vs joint-centre penetration, sample clocks, and invalid shared-Burst captures excluded.

**At handoff I JUST revised this measurement script** to add separate worst-sphere/worst-centre names and skirt_chain_hits, and removed misleading nonpenetrating worst names. The existing CSV files were made with the previous script schema; REGENERATE all CSVs using the new Evidence script. It hasn't been run after that last revision, so inspect ordinary execution errors if any. `.recon/task-l/measure_poses.py` is the old version; use Evidence/TaskL version now. New script remains pure recording analysis, never run a simulation harness.

Known correct numbers (old schema):
- Full baseline maximum joint-centre penetration **46.608 mm** at **47.963538** (left front short skirt). Others: 43.963538 38.972 mm, 60.505989 36.391 mm, 106.700087 39.244 mm, 141.476439 45.254 mm.
- 60-fps **genuine** before-late: maximum centre **14.191577 mm**, maximum sphere overlap **32.779773 mm**; after-late centre/sphere **0 throughout 26 sampled frames**. At 116.1: before centre 3.527767 mm, sphere 18.527767 mm; at 116.2 centre 8.306939 mm, sphere 20.800855 mm (worst centre and sphere can be different pairs). After zero.
- Full after early samples at 43.8 and 47.9 were zero. Full after summary NOT YET computed/reviewed despite CSV having been generated.
- Genuine before-focus CSV was refreshed by final process before handoff; summary NOT YET read. Before-visible/after-visible have no CSV yet.

Next steps, in order:
1. Ensure user cleared HANDOFF_NOW after quota increase; otherwise do not restart work. No need rebuild if only evidence/report work.
2. Regenerate eight CSVs with final `Evidence/TaskL/measure_poses.py`: full before/after, focus before/after, late before/after, visible before/after. Use `.recon/task-l/{before,after}-poses.jsonl` for full runs; `<tag>-poses.jsonl` otherwise. Save `Evidence/TaskL/<tag>-measurements.csv` (full tags before-full/after-full).
3. Summarize maxima, frames >1 mm centre overlap, strongest leg-raise timings, paired exact timestamps and primary leg pose equality. Check residual overlaps honestly; original single-pass solver/angle limits aren't guaranteed zero sphere overlap. No invented compensation.
4. View visible 71.x frame pairs. Produce compact before/after/DMM frame sheets and a static geometry-over-time plot (matplotlib appropriate scientific chart). Current focus/late shots mostly face/wide shots, not useful for seeing skirt; 71.x selected for full-body view. DMM recording path `/data/xy/gakumas/work/dmm-reference/ttmr001-dmm-20261105.mkv`; recording t = timeline t - 3.1. Existing `.recon/task-l/dmm-lifts/` has low-res 12 reference frames + `dmm-lifts-sheet.jpg`; 71.4 and 85.5 are full-body. Full-size DMM 11.5/47.9/61.9 frames also exist. No DMM bone telemetry, don't fabricate numeric DMM penetration.
5. Preserve small representative raw pose-frame extracts/compressed JSON and CSVs/logs/PNG plots in Evidence, leave full 500 MB raw traces and player snapshots in .recon. Record hashes/source commit/native library/content manifests/Burst versions in build-inputs.json. All original content unchanged and Windows tar reusable (hash in Task K).
6. Write TASK_L_REPORT.md with cause/fix, APK return-register evidence, quantitative before/after numbers and frame pairs, asset/order audit, parity table + limitations, and Claude PC handoff. PC must rebuild BOTH Windows IL2CPP and Burst from fixed source; don't reuse Task K native Burst. Changed game code only ActorAnimationMathUtility.cs; host additions optional but if copied include asmdef and recorder. Review identified leg-lift intervals at normal frame rate. Never access PC yourself.
7. Commit final evidence/report in own tree, no push. Check git status and retained build/layout files. Final user answer same concise summary, with report link, key measured improvement, native parity, and PC instructions. No tests were written/run; no Windows access/shared URP edits.

Useful commands already used:
- Android comparison: scripts/live_check.sh "$PWD" "$(cat Evidence/TaskL/census-regex.txt)" then restore LAYOUT*.md and Tools/build-artifacts.json. Done after final source.
- F/H/I/J/K comparison regexes: .recon/task-f/census-regex.txt, Evidence/TaskH/h4-census-regex.txt, .recon/task-i/census-regex.txt, .recon/task-j/census-regex.txt, Evidence/TaskK/census-regex.txt. All done.
- Successful final Linux build uses Unity6000.0.77f1 -batchmode -force-glcore -noaudio -quit -buildTarget Linux64 -executeMethod LiveBuild.BuildLinux; ulimit 65536; silent environment/xvfb.
