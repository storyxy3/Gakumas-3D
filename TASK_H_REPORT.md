# Task H / H2 — True End game-code reconstruction

The 491 census entries previously marked unfinished in source now have restored
bodies. The strict `not done` count falls from 626 to 127. Those 127 names lack one
or more native generic signatures, totaling 141 signatures. Task H2 remains
incomplete at signature coverage and full dependency closure. Lower-level
non-census animation jobs and several rendering helpers still need reconstruction.

The input has 1,102 rows and 1,070 distinct native method names across 207 types.
Overloads are aggregated by native name. The final source snapshot is `7b23cff`.
The final compilation includes every source change in that commit.

## Assembly totals

| Assembly | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.Runtime` | 120 | 6 | 10 | 0 |
| `Qua.Utility` | 7 | 0 | 0 | 39 |
| `Uguiss-Timeline.Runtime` | 1 | 2 | 0 | 0 |
| `campus-submodule.Runtime` | 667 | 62 | 68 | 88 |
| **Total** | 795 | 70 | 78 | 127 |

The inventory contains 987 reconstructed source entries and 83 retained entries
reviewed against APK instructions. No selected source body remains marked
`unfinished`. Generic source definitions can be reconstructed while their native
instantiations remain absent.

The canonical final comparison reports 797 same, 148 changed, 125 only-in-game,
zero only-in-reference and zero re-signed. The strict signature audit additionally
marks `FasterLinq.Select<object, int>` and `FasterLinq.Select<object, object>` as
`not done` because their list overloads are absent. The comparator pairs their
array overloads and skips the missing signatures.

## Status definitions

- `same` requires a reconstructed or reviewed body, every original signature
  paired, and identical canonical normalized ARM64 sequences. The normalization
  masks certain offsets and addresses.
- `[layout]` retains the comparator's label when its reduced sequence agrees and
  its full normalized sequence differs.
- `[semantic]` retains the comparator's label for a reduced-sequence difference.
  Instruction scheduling, inlining, stripping and symbol-boundary artifacts can
  produce this result. The label remains recorded after reviewing those causes.
- `not done` means a selected signature is missing or its source body is unfinished.
  All current entries in this category have missing signatures.

## H2 reconstructed batches

- Timeline dependencies include `VLTimelineController` binding, lifecycle and
  playback, plus `SwitchPanoramaCamera.VirtualCamera`.
- Actor initialization includes animation, renderer, facial, expression, talk,
  model completion, animation setup, material reset/application, effect control,
  eye highlights, hip correction, model-part registration, prop constraints,
  face correction, virtual actor binding and actor layout.
- Rig and builder dependencies include creation, update, destruction, bone
  registration, secondary-bone sorting, IK overrides and data storage.
- All 22 previously unfinished ActorAnimation census entries have bodies,
  including constraint evaluation, Quartz calculations, swing chains and the
  remaining selected math helpers. ARM64 recovered the failed decompilations.
- Crowd includes animator/playable setup, animation time and weighting, bounds
  jobs, volume hierarchy, Timeline mixers and penlight control.
- Equipment includes controller and receiver lifecycle, persistent buffers,
  stream conversion jobs, material caching, directional/basic/component lights,
  laser mesh/color/dependency jobs and property enumerators. The underlying
  Timeline clip, behavior, track, curve and equipment-ID flow was also restored.
- Monitor and CanvasRT include the repeating dual-UV mesh, render-texture
  registration/lifecycle and image parameter updates.
- Timeline adapters include BPM, lights, subtitles, target images, video
  synchronization and volumes. Anchor axes and focused-eye calculations use the
  APK's disassembly where Hex-Rays failed.
- Audience penlight palettes/projection, mob overrides and decal-light component
  properties have restored bodies. Renderer visibility now reaches the generic
  actor controller and model-part renderer list.
- Real calls now emit additional FasterLinq and Qua.Utility specializations.
  Missing coverage decreased from 167 signatures across 152 names to 141 across
  127 names. Instantiation-only artificial callers were not introduced.

## Review of the original 36 semantic entries

11 now compare `same`, 3 compare `[layout]`, and 22 remain `[semantic]`.
The previously empty `ResetActorMaterialProperty`, master Timeline accessor and
panorama-camera accessor now have implementations. The retained differences
include switch scheduling, Unity Object equality versus inverted inequality,
callee inlining, metadata initialization and enumerator cleanup layout.

The final 78 semantic flags remain visible in the inventory. Representative
reviewed cases include the following.

- Quaternion and Quartz helpers differ in helper inlining, range-clamp placement
  and branch scheduling. Their recovered formulas and operands remain in source.
- Equipment property iterators preserve the APK state-machine types and fields.
  Interface dispatch and allocation/constructor inlining alter the normalized calls.
- Laser jobs differ in vector/quaternion inlining and floating-point instruction
  scheduling. Beam topology, color timing, cone/plane transforms and constants
  were checked against the APK.
- `UpdateLookAtEyePitchCorrection` has a protection-patched branch in the game
  that truncates the canonical method output. Full instructions were used for
  reconstruction.
- The final `GetFieldConstraintTargets` comparison acquires additional metadata
  classifications after code placement changed. Its source body is unchanged
  from the earlier matching comparison. The final flag is retained.
- `VLActorModelParts.SetRendererActive` has a reduced `cmp #0` difference after
  restoring its actual renderer loop. Its dependent controller methods now reach
  that implementation.

## Verification

Verification used compilation, APK decompilation/disassembly and the supplied
function-comparison tools. No tests or runtime harnesses were written or run.

`Tools/build_android.sh` completed C# and native IL2CPP compilation with zero C#
errors. The linked library is the input to the final comparison. APK packaging
fails at `:unityLibrary:lintVitalAnalyzeRelease` with `For input string: "37.0"`.
The complete local log is `.recon/task-h2/build-final-unity.log`.

The final `live_check.sh` comparison ran after the last source change. Generated
`LAYOUT.md`, `LAYOUT-ALL.md` and `Tools/build-artifacts.json` were restored before
committing. Binary and metadata fingerprints are recorded in the evidence.

The dependency comparison covers 16 names, with 15 same, one semantic difference
and zero missing. It includes the Timeline controller, panorama accessor, actor
animation update/defaults and renderer visibility dependencies.

Task F's 705-name raw comparison is now 630 same, 75 changed and zero only-in-game.
Its previous result was 632 same, 36 changed and 37 only-in-game. All 37 previously
absent names now emit native code. Two previously same names gained flags without
source changes to those methods. `MotionDefinePlayable.OnBehaviourPause` has
metadata-load classifications, and the fully shared skinning static constructor
includes neighboring function instructions. The final regression diff records
both flags. Task F's separate report retains its historical snapshot.

## Remaining work

1. Resolve the 141 missing native signatures using their real game callers.
   The 88 campus names are FasterLinq specializations. The 39 Qua.Utility names
   are collection/dictionary specializations. Examples involve `ExamBattleResult`,
   `MessageLogSoundInfo`, produce/gasha structs, UniTask and tuple shapes whose
   callers are outside the supplied live method census. Every exact signature is
   listed in `Evidence/TaskH/missing-signatures.json`.
2. Complete lower-level animation dependency closure. In particular,
   `CampusActorAnimationJob.Create`, its subjob factories, processing/update and
   destruction methods remain skeletons outside the selected list. Several
   underlying constraint/Quartz/swing/IK job constructors and execution bodies
   also remain skeletons. Restored rig and actor entry points reach these gaps.
3. Complete remaining non-census rendering helpers reached by restored adapters,
   including `CanvasRenderTextureRenderer` and `AudiencePenlightComponent`.
   Broader decal-renderer internals and unselected actor-model helpers such as
   `AddCombinedOpaqueSubMesh` remain outside this reconstruction batch.
4. Keep the 78 semantic flags under review as those dependencies and the remaining
   real generic callers are reconstructed. The per-name evidence distinguishes
   these flags from missing signatures.

The seven selected bodies whose Hex-Rays decompilation failed in Task H now have
ARM64-derived implementations. The remaining signature and dependency work above
has not been credited as complete.

## Commits

Task H's earlier source commits are `822b581`, `85f0135`, `060c570`, `bc5bf49` and
`d9f3fef`. Its prior report is `5c1e7aa`. H2 commits follow.

- `7d30652` — Restore APK timeline binding lifecycle and panorama camera accessor
- `2557f84` — Reconstruct actor initialization material updates talk and effect control from APK
- `1d6f2f2` — Restore rig lifecycle playable builder data storage and actor IK overrides
- `4565c5e` — Reconstruct constraint evaluation quartz rotations bend-roll math and swing chains
- `0ae7979` — Restore campus rig registration secondary-bone sorting and eye correction
- `6be530d` — Restore crowd animation graph, clip timing and bounds jobs from APK
- `7d02c5b` — Restore equipment controller, receiver, lighting and stream conversion jobs
- `98da0eb` — Restore canvas textures, monitor meshes and crowd timeline controls
- `6c62a22` — Restore crowd volume binding and virtual actor bone control
- `cc2c1ba` — Restore actor model part registration face correction and prop constraints
- `8de3c16` — Restore video timeline synchronization and camera-based light anchors
- `fff114e` — Reconstruct laser mesh generation color timing and dependency job
- `dfbfb2f` — Restore BPM light subtitle image and volume timeline adapters
- `5c05f9e` — Restore audience penlights decal-light properties and actor layout
- `facb477` — Restore equipment timeline sampling bindings and animation data flow
- `7b23cff` — Restore renderer visibility dependencies and final constructor defaults

## Evidence

The updated `Evidence/TaskH/method-status.json` contains all 1,070 names with
previous/current status, source status, APK addresses and missing signatures.
`h2-summary.json` contains assembly totals and the source commit. The canonical
outputs, reduced instruction review, dependency comparison, Task F regression,
compilation summary and fingerprints are described in `Evidence/TaskH/README.md`.

## Per-type results

### ActorAnimation.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.ActorAnimationConstraintBoneComponentBase` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformBone` | 9 | 2 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionCollider` | 6 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionGoal` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCustomLookAtEffector` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKGoalEffector` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManageData` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationMathUtility` | 8 | 4 | 5 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFrillBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFurisodeBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHairBone` | 2 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationBone` | 2 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtBone` | 2 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<ActorAnimationJob, ActorAnimationRigData, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerJobLocator` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingJobSkeleton` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingBreastBone` | 21 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingChain` | 5 | 0 | 2 | 0 |
| `ActorAnimation.ActorSwingChain.<>c__DisplayClass4_0` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingDynamicBone` | 18 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingStaticBone` | 11 | 0 | 0 | 0 |
| `ActorAnimation.ChainInfo` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ChainLayerInfo` | 2 | 0 | 0 | 0 |
| `ActorAnimation.LimitInfo` | 1 | 0 | 0 | 0 |

### Qua.Utility

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `Qua.Extensions.IDictionaryExtensions` | 3 | 0 | 0 | 10 |
| `Qua.Extensions.IEnumerableExtensions` | 4 | 0 | 0 | 29 |

### Uguiss-Timeline.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `Uguiss.Timeline.AbstractScriptPlayableCommand<object, object, object>` | 0 | 1 | 0 | 0 |
| `Uguiss.Timeline.TimelineEngineUtility` | 1 | 1 | 0 | 0 |

### campus-submodule.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.CampusActorAnimationFullBodyIKOverrideSettingHolder` | 1 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationInitializeData` | 1 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationJob` | 8 | 0 | 2 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimeline` | 9 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineAsset` | 3 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineTrack` | 2 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightVolume` | 5 | 1 | 0 | 0 |
| `Campus.AudiencePenlight.DefaultAudiencePenlight` | 5 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideAsset` | 3 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideTrack` | 2 | 0 | 0 | 0 |
| `Campus.Common.AnimationEventHandler` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorAnimation` | 21 | 1 | 0 | 0 |
| `Campus.Common.CampusActorController` | 53 | 17 | 21 | 0 |
| `Campus.Common.CampusActorController.<>c` | 1 | 0 | 1 | 0 |
| `Campus.Common.CampusActorController.OverrideActorMaterialPropertyData` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorController.ShaderIDs` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorEffectController` | 5 | 0 | 0 | 0 |
| `Campus.Common.CampusActorEyeHighlight` | 1 | 1 | 0 | 0 |
| `Campus.Common.CampusActorEyeHighlight.LimitData` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorFaceCorrection` | 6 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout` | 5 | 1 | 0 | 0 |
| `Campus.Common.CampusActorLayout.<>c` | 3 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.Constraint` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.Data` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialEffect` | 5 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialEffectPlayable` | 4 | 1 | 0 | 0 |
| `Campus.Common.CampusActorMaterialProperty` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorModelParts` | 3 | 1 | 1 | 0 |
| `Campus.Common.CampusActorTalkModel` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusCustomLookAtEffector` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusLightAnchor` | 8 | 0 | 1 | 0 |
| `Campus.Common.CampusLightAnchorBase` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusTransformAnchor` | 16 | 1 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController` | 18 | 0 | 1 | 0 |
| `Campus.Common.CampusVirtualActorController.FocusedEyeBoneResult` | 1 | 1 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController.HipsPosXZResult` | 2 | 0 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController.ScaleResult` | 2 | 0 | 0 | 0 |
| `Campus.Common.FloatCurve` | 3 | 0 | 0 | 0 |
| `Campus.Common.LayoutMotionDefine` | 1 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveEnvironment` | 3 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController` | 65 | 5 | 6 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c` | 17 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass113_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass114_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass115_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass123_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass124_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass124_1` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass126_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass129_0` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass129_1` | 2 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.LiveProp` | 1 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.LivePropSetting` | 1 | 0 | 0 | 0 |
| `Campus.Common.Panorama.PanoramaCameraHolder` | 2 | 0 | 1 | 0 |
| `Campus.Common.VideoImage` | 6 | 0 | 0 | 0 |
| `Campus.Crowd.ClipData` | 2 | 2 | 0 | 0 |
| `Campus.Crowd.CrowdAnimationBehaviour` | 8 | 6 | 0 | 0 |
| `Campus.Crowd.CrowdAnimationTimeline` | 33 | 2 | 0 | 0 |
| `Campus.Crowd.CrowdAnimator` | 7 | 8 | 1 | 0 |
| `Campus.Crowd.CrowdAnimator.<>c` | 2 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData` | 7 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.CrowdVolumeBoneData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.MeshData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.SubMeshData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdMotionDefine` | 4 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdOcclusionVolume` | 4 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineAsset` | 3 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineTrack` | 2 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineTrack.<>c` | 4 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdVolume` | 9 | 2 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLight` | 28 | 0 | 2 | 0 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight` | 3 | 0 | 1 | 0 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight.<get_GatherProperties>d__3` | 6 | 0 | 2 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser` | 4 | 1 | 5 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser.<get_GatherProperties>d__31` | 6 | 0 | 2 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob` | 0 | 2 | 3 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightBasic` | 5 | 0 | 2 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightBasic.<get_GatherProperties>d__13` | 6 | 0 | 2 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightComponent` | 3 | 1 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightComponent.<get_GatherProperties>d__6` | 6 | 0 | 2 | 0 |
| `Campus.Live.Equipment.EnvironmentBase` | 2 | 1 | 0 | 0 |
| `Campus.Live.Equipment.EquipmentValue` | 3 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentComponentProperty` | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentController` | 25 | 0 | 1 | 0 |
| `Campus.Live.Equipment.LiveEquipmentController.<>c` | 3 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentReceiver` | 12 | 2 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase` | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase<object>` | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightClip` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightTrack` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserClip` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserTrack` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightClip` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightTrack` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentTrackBase` | 1 | 0 | 0 | 0 |
| `Campus.Live.Monitor.MonitorRepeatImage` | 12 | 0 | 2 | 0 |
| `Campus.Live.SRTSubtitle` | 1 | 0 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController` | 11 | 0 | 1 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.<>c` | 4 | 0 | 1 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.MobPenlightSetting` | 1 | 0 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.RuntimeMobPenlightSetting` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.BeatDenominatorMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.BeatNumeratorMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmInfo` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmMarkerTrack` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmTimelineAsset` | 2 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmTimelineTrack` | 3 | 0 | 1 | 0 |
| `Campus.Timeline.CampusCutMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusDirectorControlAsset` | 2 | 0 | 0 | 0 |
| `Campus.Timeline.CampusDirectorControlTrack` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusLightAsset` | 2 | 0 | 0 | 0 |
| `Campus.Timeline.CampusLightTrack` | 4 | 0 | 3 | 0 |
| `Campus.Timeline.CampusSubTitleTimelineAsset` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusSubtitleBehaviour` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusSubtitleTrack` | 2 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageClip` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageClipBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageTrack` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVideoPlayerClip` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVideoPlayerTrack` | 2 | 0 | 1 | 0 |
| `Campus.Timeline.CampusVideoPlayerTrackBehaviour` | 17 | 5 | 2 | 0 |
| `Campus.Timeline.CampusVolumeTimelineAsset` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineTrack` | 3 | 0 | 0 | 0 |
| `Campus.Timeline.CurrentActorSignalData` | 1 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTexture` | 23 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTextureImage` | 5 | 0 | 0 | 0 |
| `FasterLinq` | 2 | 0 | 0 | 52 |
| `FasterLinq.SelectArray<ExamBattleResult, int>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ExamBattleResult, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, UniTask>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, ValueTuple<Int32Enum, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<MessageLogSoundInfo, UniTask>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, int, object, object>, UniTask<ValueTuple<bool, object>>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, ValueTuple<int, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, int>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, Int32Enum>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int, int>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int, object, object, object>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object, object>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<ValueTuple<object, object>, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<object, Int32Enum, bool, bool, int, int, int>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>` | 1 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<int, int>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<int, object>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Color>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Int32Enum>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, MessageLogSoundInfo>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask<bool>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask<object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<Int32Enum, int, object, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, bool>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, int, object, object, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, object>>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Vector2>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Vector3>` | 1 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, bool>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, float>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, int>` | 1 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, long>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, object>` | 1 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<uint, Color>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<uint, bool>` | 0 | 0 | 0 | 1 |
