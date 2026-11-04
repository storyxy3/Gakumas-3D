# Task H — True End game-code reconstruction

**Task H is incomplete.** The source and native results below cover the supplied
True End census, not all methods in the four assemblies. Actor initialization,
character physics, crowd, equipment, monitor and timeline bodies still remain.
This is not an end-to-end playback completion claim.

The input has 1,102 method rows and 1,070 distinct native method names. Overloads
are aggregated by the canonical comparator. Generic instantiations remain separate
names. Existing bodies are counted only after reviewing their APK instructions;
unchanged skeletons are not automatically credited because they compile.

## Assembly totals

| Assembly | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.Runtime` | 108 | 3 | 3 | 22 |
| `Qua.Utility` | 2 | 0 | 0 | 44 |
| `Uguiss-Timeline.Runtime` | 1 | 2 | 0 | 0 |
| `campus-submodule.Runtime` | 275 | 17 | 33 | 560 |
| **Total** | 386 | 22 | 36 | 626 |

579 names have reconstructed or reviewed retained bodies. 491 names remain unfinished in source; 135 additional names have missing native signatures.

Raw comparator: 387 same / 532 changed / 151 only-in-game / 0 re-signed. The stricter audit finds 167 missing signatures across 152 names.

## Status definitions

- `same`: a reviewed/reconstructed source body has all original signatures paired,
  and the canonical normalized ARM64 sequences agree. Normalization masks some
  field offsets and address literals; this is not byte equality or a layout proof.
- `[layout]`: the comparator's reduced instruction sequence agrees while its full
  normalized sequence differs. This label is retained verbatim, not a proof of
  field layout or numerical equivalence.
- `[semantic]`: a reviewed/reconstructed body still has a canonical comparison
  difference. Known compiler differences are discussed below but remain flagged.
- `not done`: source reconstruction remains unfinished, or at least one selected
  original signature has no native counterpart. Missing generic signatures are
  included even when the canonical comparator skips them.

## Reconstructed and retained bodies

- Live controller: forced/user/panorama cameras, look-at prohibition, actor-slot
  signals, controlled-director traversal, track paths/muting and motion overrides.
  Callback order, exposed-reference resolution and LINQ operations follow the APK.
- ActorAnimation: swing static/dynamic/breast state and defaults, IK collider/goal
  defaults, handle setup, Quartz bone kinds and selected quaternion products,
  constraint source management, and eight math helpers including rotation-order
  conversion, axis permutation, coefficient clamping and degree-range adjustment.
  The constraint constructor initializes fields before the MonoBehaviour base call.
  `GetValidSourceCount` preserves the APK's addition when the field source is null.
- Campus actor animation: selected look-at, IK override, joint-limit, layout and
  reset methods; their ten selected job methods; required handle constructors,
  builder-playable accessor, and initialization/disposal dependencies. The failed
  job look-at decompilation was recovered from ARM64. It checks the target but binds
  the effector's own transform, as the APK does.
- Campus actor controller: field accessors, animation forwarding, renderer/collider
  reference count, blink/talk controls, material-override bookkeeping and human-scale
  lookup. Material reset itself remains unfinished.
- FasterLinq: array/list Select factories and value constructors, selected array
  conversion and enumerator paths. Native generic coverage is incomplete.
- Qua.Utility: the two selected generic definitions (`IsNullOrEmpty`) reconstructed
  from the APK. Enumeration checks `ICollection<T>`, then `IReadOnlyCollection<T>`,
  then `Enumerable.Any`; original RGCTX metadata confirms the interface order.
- Uguiss-Timeline: the JSON-escape regex initializer and both selected playable
  behavior helpers, plus the required base Playable property.
- Retained bodies include APK-empty methods and 71 separately reviewed constructors
  or zero clip-capability getters. These were inspected in disassembly and already
  matched, so no speculative body was added.

## Verification and limits

No tests, test assemblies, runtime harnesses or deployment were created or run.
Verification used `Tools/build_android.sh`, `live_check.sh`, the canonical
`urp_func_diff`/`live_show` comparison logic, APK decompilation and disassembly.
The final build has no C# errors and produces the native IL2CPP library used by the
comparison. APK packaging fails at `:unityLibrary:lintVitalAnalyzeRelease` with
`For input string: "37.0"`, the known Gradle limitation in the task instructions.
The build script's exit status alone is not treated as successful APK packaging.

The signature audit also catches the unemitted list overload of
`FasterLinq.Select<object, object>`; the array overload exists, so the ordinary
comparator silently skips the missing generic signature. All affected names are
`not done` below. Native instantiations were not forced through artificial callers.

Examples of retained comparison differences:

- Math `ToQuaternion` shares the sin/cos calculation before the rotation-order
  switch; the APK duplicates those calls in the cases. `ToEuler` tail-merges its
  `ThreeAxisRot` calls in the rebuild. Axis permutation and IK goal switches have
  different branch order. These are not repeatedly reformulated to chase codegen.
- The look-at-limit constructor may remain a call plus copies in the rebuild where
  the APK inlines the stores. Job data copies and metadata initialization also differ.
- Actor controller forwarding may inline the recovered target body. Equality-plus-
  return and inequality-plus-body can use different Unity Object operator calls.
- `RemoveOverrideMaterialProperty` still calls the unreconstructed
  `ResetActorMaterialProperty`; the rebuilt compiler removes that empty call.
  This is an unfinished dependency, not merely a compiler-only difference.
- The live controller still depends on out-of-scope `VLTimelineController.master`
  and `SwitchPanoramaCamera.VirtualCamera` skeletons. Several native differences
  stem from those accessors, and the restored callers cannot yet work end to end.

## Remaining work

1. Actor setup and per-frame execution: `CampusActorController.InitializeActorAnimation`,
   `InitializeFacial`, model build/reset, material application, skeleton correction,
   animation setup and remaining actor/layout/face/effect methods. Campus animation
   `OnUpdate`, rig/builder creation/update/destruction and other non-census callees
   also remain skeletons despite the completed selected forwarding paths.
2. Physics: constraint `Calc`/`LateUpdate`, the remaining nine selected math bodies,
   hair/rotation/skirt Quartz calculations and `ActorSwingChain` construction/update.
   Their formulas and control flow have not been fully reconstructed; no guessed
   implementation is substituted.
3. Audience penlights, crowd animator/timeline/volumes, equipment and light/laser
   updates, monitor mesh generation, CanvasRT lifecycle and remaining Timeline adapters.
4. Missing native instantiations for the reconstructed generic utility definitions.
   Those need real caller reconstruction and another signature-level comparison.
5. Resolve the retained `[semantic]` results after unfinished callees are restored.
   Re-run compilation and native comparison for each subsequent batch.

Of the original seven failed Hex-Rays bodies, job look-at setup now has an ARM64
reconstruction. The remaining failures are actor initialization, facial initialization,
constraint LateUpdate, camera-based anchor axes, focused-eye LateUpdate and monitor
mesh population. Other `not done` methods also have available decompilations but
have not been translated and verified; they are not claimed to be blocked by tools.

The exhaustive per-name inventory in `Evidence/TaskH/method-status.json` records
source status, raw comparator status, missing signatures and APK addresses. The
per-type tables below include every type represented in the supplied census.

## Commits

- `822b581` — Reconstruct live timeline camera, actor signals and track control from APK
- `85f0135` — Restore APK swing state, IK defaults, actor forwarding and field accessors
- `060c570` — Reconstruct collection and playable utility bodies from APK
- `bc5bf49` — Reconstruct actor animation job bindings, constraint sources and rotation helpers
- `d9f3fef` — Restore actor render, blink, talk and material override controls

## Per-type results

### ActorAnimation.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.ActorAnimationConstraintBoneComponentBase` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformBone` | 9 | 0 | 0 | 2 |
| `ActorAnimation.ActorAnimationIKCorrectionCollider` | 6 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionGoal` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCustomLookAtEffector` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKGoalEffector` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManageData` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationMathUtility` | 2 | 3 | 3 | 9 |
| `ActorAnimation.ActorAnimationQuartzDriverFrillBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFurisodeBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHairBone` | 2 | 0 | 0 | 1 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegBone` | 3 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationBone` | 2 | 0 | 0 | 1 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtBone` | 2 | 0 | 0 | 1 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistBone` | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<ActorAnimationJob, ActorAnimationRigData, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, object>` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerJobLocator` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingJobSkeleton` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingBreastBone` | 21 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingChain` | 0 | 0 | 0 | 7 |
| `ActorAnimation.ActorSwingChain.<>c__DisplayClass4_0` | 1 | 0 | 0 | 1 |
| `ActorAnimation.ActorSwingDynamicBone` | 18 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingStaticBone` | 11 | 0 | 0 | 0 |
| `ActorAnimation.ChainInfo` | 1 | 0 | 0 | 0 |
| `ActorAnimation.ChainLayerInfo` | 2 | 0 | 0 | 0 |
| `ActorAnimation.LimitInfo` | 1 | 0 | 0 | 0 |

### Qua.Utility

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `Qua.Extensions.IDictionaryExtensions` | 1 | 0 | 0 | 12 |
| `Qua.Extensions.IEnumerableExtensions` | 1 | 0 | 0 | 32 |

### Uguiss-Timeline.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `Uguiss.Timeline.AbstractScriptPlayableCommand<object, object, object>` | 0 | 1 | 0 | 0 |
| `Uguiss.Timeline.TimelineEngineUtility` | 1 | 1 | 0 | 0 |

### campus-submodule.Runtime

| Type | same | [layout] | [semantic] | not done |
|---|---:|---:|---:|---:|
| `ActorAnimation.CampusActorAnimationFullBodyIKOverrideSettingHolder` | 0 | 0 | 0 | 1 |
| `ActorAnimation.CampusActorAnimationInitializeData` | 0 | 0 | 0 | 1 |
| `ActorAnimation.CampusActorAnimationJob` | 7 | 0 | 3 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimeline` | 3 | 0 | 0 | 6 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineAsset` | 0 | 0 | 0 | 3 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineBehaviour` | 0 | 0 | 0 | 1 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineTrack` | 1 | 0 | 0 | 1 |
| `Campus.AudiencePenlight.AudiencePenlightVolume` | 1 | 0 | 0 | 5 |
| `Campus.AudiencePenlight.DefaultAudiencePenlight` | 2 | 0 | 0 | 3 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideAsset` | 2 | 0 | 0 | 1 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideTrack` | 1 | 0 | 0 | 1 |
| `Campus.Common.AnimationEventHandler` | 0 | 0 | 0 | 1 |
| `Campus.Common.CampusActorAnimation` | 12 | 9 | 1 | 0 |
| `Campus.Common.CampusActorController` | 27 | 5 | 12 | 47 |
| `Campus.Common.CampusActorController.<>c` | 1 | 0 | 0 | 1 |
| `Campus.Common.CampusActorController.OverrideActorMaterialPropertyData` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorController.ShaderIDs` | 0 | 0 | 0 | 1 |
| `Campus.Common.CampusActorEffectController` | 1 | 0 | 0 | 4 |
| `Campus.Common.CampusActorEyeHighlight` | 1 | 0 | 0 | 1 |
| `Campus.Common.CampusActorEyeHighlight.LimitData` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorFaceCorrection` | 2 | 0 | 0 | 4 |
| `Campus.Common.CampusActorLayout` | 1 | 0 | 0 | 5 |
| `Campus.Common.CampusActorLayout.<>c` | 1 | 0 | 0 | 2 |
| `Campus.Common.CampusActorLayout.Constraint` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.Data` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialEffect` | 1 | 0 | 0 | 4 |
| `Campus.Common.CampusActorMaterialEffectPlayable` | 1 | 0 | 0 | 4 |
| `Campus.Common.CampusActorMaterialProperty` | 0 | 0 | 0 | 1 |
| `Campus.Common.CampusActorModelParts` | 0 | 0 | 0 | 5 |
| `Campus.Common.CampusActorTalkModel` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusCustomLookAtEffector` | 0 | 0 | 0 | 1 |
| `Campus.Common.CampusLightAnchor` | 1 | 0 | 0 | 8 |
| `Campus.Common.CampusLightAnchorBase` | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusTransformAnchor` | 1 | 0 | 0 | 16 |
| `Campus.Common.CampusVirtualActorController` | 6 | 0 | 0 | 13 |
| `Campus.Common.CampusVirtualActorController.FocusedEyeBoneResult` | 1 | 0 | 0 | 1 |
| `Campus.Common.CampusVirtualActorController.HipsPosXZResult` | 1 | 0 | 0 | 1 |
| `Campus.Common.CampusVirtualActorController.ScaleResult` | 1 | 0 | 0 | 1 |
| `Campus.Common.FloatCurve` | 0 | 0 | 0 | 3 |
| `Campus.Common.LayoutMotionDefine` | 1 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveEnvironment` | 3 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController` | 57 | 3 | 16 | 0 |
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
| `Campus.Common.VideoImage` | 3 | 0 | 0 | 3 |
| `Campus.Crowd.ClipData` | 0 | 0 | 0 | 4 |
| `Campus.Crowd.CrowdAnimationBehaviour` | 2 | 0 | 0 | 12 |
| `Campus.Crowd.CrowdAnimationTimeline` | 7 | 0 | 0 | 28 |
| `Campus.Crowd.CrowdAnimator` | 0 | 0 | 0 | 16 |
| `Campus.Crowd.CrowdAnimator.<>c` | 1 | 0 | 0 | 1 |
| `Campus.Crowd.CrowdData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData` | 5 | 0 | 0 | 2 |
| `Campus.Crowd.CrowdModelData.CrowdVolumeBoneData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.MeshData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.SubMeshData` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdMotionDefine` | 1 | 0 | 0 | 3 |
| `Campus.Crowd.CrowdOcclusionVolume` | 1 | 0 | 0 | 3 |
| `Campus.Crowd.CrowdTimelineAsset` | 0 | 0 | 0 | 3 |
| `Campus.Crowd.CrowdTimelineBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineTrack` | 1 | 0 | 0 | 1 |
| `Campus.Crowd.CrowdTimelineTrack.<>c` | 1 | 0 | 0 | 3 |
| `Campus.Crowd.CrowdVolume` | 2 | 0 | 0 | 9 |
| `Campus.DecalLight.CampusDecalLight` | 7 | 0 | 0 | 23 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight` | 0 | 0 | 0 | 4 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight.<get_GatherProperties>d__3` | 1 | 0 | 0 | 7 |
| `Campus.Live.Equipment.Environment.LiveLaser` | 0 | 0 | 0 | 10 |
| `Campus.Live.Equipment.Environment.LiveLaser.<get_GatherProperties>d__31` | 1 | 0 | 0 | 7 |
| `Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob` | 0 | 0 | 0 | 5 |
| `Campus.Live.Equipment.Environment.LiveLightBasic` | 0 | 0 | 0 | 7 |
| `Campus.Live.Equipment.Environment.LiveLightBasic.<get_GatherProperties>d__13` | 1 | 0 | 0 | 7 |
| `Campus.Live.Equipment.Environment.LiveLightComponent` | 0 | 0 | 0 | 4 |
| `Campus.Live.Equipment.Environment.LiveLightComponent.<get_GatherProperties>d__6` | 1 | 0 | 0 | 7 |
| `Campus.Live.Equipment.EnvironmentBase` | 0 | 0 | 0 | 3 |
| `Campus.Live.Equipment.EquipmentValue` | 1 | 0 | 0 | 2 |
| `Campus.Live.Equipment.LiveEquipmentComponentProperty` | 0 | 0 | 0 | 1 |
| `Campus.Live.Equipment.LiveEquipmentController` | 4 | 0 | 0 | 22 |
| `Campus.Live.Equipment.LiveEquipmentController.<>c` | 1 | 0 | 0 | 2 |
| `Campus.Live.Equipment.LiveEquipmentReceiver` | 1 | 0 | 0 | 13 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase` | 0 | 0 | 0 | 1 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase<object>` | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightClip` | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightTrack` | 1 | 0 | 0 | 1 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserClip` | 0 | 0 | 0 | 2 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserTrack` | 1 | 0 | 0 | 1 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightClip` | 0 | 0 | 0 | 2 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightTrack` | 1 | 0 | 0 | 1 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentTrackBase` | 1 | 0 | 0 | 0 |
| `Campus.Live.Monitor.MonitorRepeatImage` | 2 | 0 | 0 | 12 |
| `Campus.Live.SRTSubtitle` | 1 | 0 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController` | 0 | 0 | 0 | 12 |
| `Campus.MobAudience.MobAudiencePenlightController.<>c` | 1 | 0 | 0 | 4 |
| `Campus.MobAudience.MobAudiencePenlightController.MobPenlightSetting` | 0 | 0 | 0 | 1 |
| `Campus.MobAudience.MobAudiencePenlightController.RuntimeMobPenlightSetting` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.BeatDenominatorMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.BeatNumeratorMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmInfo` | 0 | 0 | 0 | 1 |
| `Campus.Timeline.CampusBpmMarkerTrack` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmTimelineAsset` | 1 | 0 | 0 | 1 |
| `Campus.Timeline.CampusBpmTimelineTrack` | 1 | 0 | 0 | 3 |
| `Campus.Timeline.CampusCutMarker` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusDirectorControlAsset` | 1 | 0 | 0 | 1 |
| `Campus.Timeline.CampusDirectorControlTrack` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusLightAsset` | 1 | 0 | 0 | 1 |
| `Campus.Timeline.CampusLightTrack` | 2 | 0 | 0 | 5 |
| `Campus.Timeline.CampusSubTitleTimelineAsset` | 0 | 0 | 0 | 3 |
| `Campus.Timeline.CampusSubtitleBehaviour` | 0 | 0 | 0 | 3 |
| `Campus.Timeline.CampusSubtitleTrack` | 1 | 0 | 0 | 1 |
| `Campus.Timeline.CampusTargetImageClip` | 1 | 0 | 0 | 2 |
| `Campus.Timeline.CampusTargetImageClipBehaviour` | 0 | 0 | 0 | 1 |
| `Campus.Timeline.CampusTargetImageTrack` | 1 | 0 | 0 | 2 |
| `Campus.Timeline.CampusVideoPlayerClip` | 1 | 0 | 0 | 2 |
| `Campus.Timeline.CampusVideoPlayerTrack` | 0 | 0 | 0 | 3 |
| `Campus.Timeline.CampusVideoPlayerTrackBehaviour` | 0 | 0 | 0 | 24 |
| `Campus.Timeline.CampusVolumeTimelineAsset` | 2 | 0 | 0 | 1 |
| `Campus.Timeline.CampusVolumeTimelineBehaviour` | 1 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineTrack` | 1 | 0 | 0 | 2 |
| `Campus.Timeline.CurrentActorSignalData` | 1 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTexture` | 10 | 0 | 0 | 13 |
| `CanvasRT.CanvasRenderTextureImage` | 1 | 0 | 0 | 4 |
| `FasterLinq` | 1 | 0 | 0 | 53 |
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
| `FasterLinq.SelectArray<object, Vector3>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, bool>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, float>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, int>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, long>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, object>` | 1 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<uint, Color>` | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<uint, bool>` | 0 | 0 | 0 | 1 |
