# Task H4 — True End rendering closure

**The expanded rendering census is closed.** Its 1,676 native names contain 1,551 restored or native-reviewed rendering names and 125 out-of-scope names. No actionable method or unresolved signature remains within this closure.

## Assembly totals

| Assembly | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `ActorAnimation.Runtime` | 378 | 63 | 61 | 0 | 0 |
| `Qua.Utility` | 7 | 0 | 0 | 0 | 39 |
| `Uguiss-Timeline.Runtime` | 1 | 1 | 1 | 0 | 0 |
| `campus-submodule.Runtime` | 886 | 69 | 84 | 0 | 86 |
| **Total** | 1272 | 133 | 146 | 0 | 125 |

Raw comparison counts are 1,272 same, 279 changed and 125 only-in-game. The 279 changed names comprise 133 layout and 146 semantic flags. Every retained semantic flag has a per-method reason and its native differences in `Evidence/TaskH/h4-semantic-reasons.json`.

## Restored execution paths

- Campus joint/look-at limits, rig resets, inactive-bone handling, sorting and affine helpers now follow the APK bodies.
- Full-body IK includes pull iterations, hand correction colliders, look-at handling, nod additives and head writeback.
- Swing includes native factory allocations and bindings, static/dynamic/breast processing, fixed-step integration, prewarm stability, root-motion and height correction, wind, limits, collision, chain smoothing and seated correction. The curve evaluator and both chain-length overloads are included.
- Decal rendering includes entity/chunk allocation, resizing and disposal, transform jobs, culling/result dependencies, per-shape shader parameter packing, material variants, canvas texture fallback and instanced drawing with the APK 128-light limit.
- Actor shader uploads include MatCap, lit actors, reflection cubes, lightmap/probe parameters, vegetation, virtual effects and outline focal-length scaling. The global-parameter renderer feature and its volume/default-setting constructors are restored.
- The waist calculation now uses `Vector3.down`, identified from the APK static-field offset. This corrects the earlier `Vector3.back` translation. The canonical comparator normalizes field offsets, so this correction required checking the disassembly.

H4 adds 22 names beyond the H3 inventory. Their live callers are recorded in `h4-census-additions.json`, including IK collision helpers, curve evaluation, chain-length calculation and the actor parameter feature/settings/volume constructors.

## Generic scope decisions

All 141 absent native signatures have caller-based exclusions in `h4-generic-scope.json`. They cover 125 fully excluded names and additional unused overloads of names whose rendering instantiations are present. The supplied rendering closure excludes the main client and ADV assemblies, as established in `CLOSURE.md`.

The exclusions include exam/produce/gasha flows, event-bonus UI, home and costume scene setup, photography UI, message logs, deep links and client asset loading. The client-loading exclusion also includes `Campus.Live.LivePlayerPresenter` and `Campus.Live.Data.LiveFixedData` callers in Assembly-CSharp. Render-side actor initialization after model construction is included.

Native caller chains distinguish the remaining shared signatures. `CampusActorManager.GetFreeActorIndex` leads to exam/costume callers. `CampusSceneLayout.TryCreateActorLayoutPositionCache` leads through interactive scene-layout APIs to home/exam/produce/costume/event scenes. `CampusColorManager.ColorDictionary` supplies the client UI palette. Dictionary fallback helpers lead to memory-tag, photography, audition, dearness or deep-link code. Each signature records its named caller and address.

For inlined `ToArray` specializations, the corresponding `Select` construction identifies the feature. The seven-element event-bonus tuple is additionally traced through nested `Select` and `ToList` to `StoryEventBonusSheetPresenter.SetView` and `TourEventBonusSheetPresenter.SetIdolConsumptionBonus`.

## Retained native differences

The final review includes all 146 semantic flags. Causes include helper inlining, constructor aliases, complementary null predicates, interface-slot stripping, iterator/exception-state ordinals, constant materialization, switch ordering and neighboring unnamed functions. The comparison labels remain visible.

Three newly flagged ranges have identical complete method prefixes. `ActorAnimationQuartzDriverRotationJobBone.Update` matches for 20 instructions, `LiveEquipmentLaserClip..ctor` for 30, and the CrowdVolume hierarchy helper for 101. Their comparator ranges include following unnamed helpers. Evidence is in `h4-final-boundary-review.txt`.

Decal `UpdateParams` retains the APK radius lower-bound condition and short-capsule branch. Its final semantic-token multiset matches, with different switch/register ordering. The box mesh index bytes match the APK field hash. The generated metadata type name differs because the existing metadata postprocessor renames PrivateImplementationDetails.

## Verification and Task F

C# and native IL2CPP compilation completed after the final source change. The compiled source snapshot is `0c793f9`. The full Unity log is `.recon/task-h4/build-final-unity.log`, and binary/dump hashes are retained in `h4-input-SHA256SUMS`. Verification used compilation and function-by-function comparison.

Gradle APK packaging still fails at `lintVitalAnalyzeRelease` with `For input string: "37.0"`. The native IL2CPP output used for comparison was produced successfully.

Task F now reports **630 same / 36 [layout] / 39 [semantic] / 0 missing**. Compared with H3's 629 same, `VL.Animation.MotionLayerPlayable.OnPlayableDestroy` and `VLB.SRPHelper.IsUsingCustomRenderPipeline` return to same. Their earlier flags were displaced-load thunks and consequent metadata-address tracking.

The new final-build flag is `VLB.Consts.Beam..cctor`. At `0x4f8a014`, the rebuilt code branches to `0x4fbcfec`, loads `x19` from `[x19, #0x5b0]`, then branches back to `0x4f8a018`. The comparator consequently misattributes later loads to `TaskFactory.CommonCWAnyLogic`. The remaining constructor operations match. Full evidence is in `h4-task-f-review.txt` and `h4-task-f-thunk.txt`.

## Remaining TODOs and boundary

No unfinished body remains in the accepted rendering census. Two job-weight getter comments document getters stripped from the APK metadata but required to compile the C# interfaces. Unrelated client/backend/feature skeletons remain outside this census, with generic exclusions documented above. Native semantic flags remain as reviewed comparison differences.

## H4 commits

- `addc0b9` — Restore campus joint and look-at limit execution from APK
- `a8c0166` — Restore rig reset paths swing data resets and affine helpers from APK
- `02dedcb` — Restore full body IK solver pull and hand correction from APK
- `3ff0178` — Restore swing math wind and breast curve evaluation from APK
- `60ed9c6` — Restore swing simulation collision and factory closure from APK
- `a55e3d8` — Restore decal light entity jobs and instanced rendering from APK
- `0c793f9` — Restore actor shader parameters volume defaults and renderer entry point

Earlier H/H2/H3 reports and comparisons remain in git history and the historical evidence files.

## Per-type results

### ActorAnimation.Runtime

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `ActorAnimation.ActorAnimationConstraintBoneComponentBase` | 5 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformBone` | 9 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformJobBone` | 5 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintUtility` | 0 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKCalcUtility` | 0 | 1 | 2 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKJobSkeleton` | 4 | 13 | 4 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKLimbPart` | 15 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKMovePart` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKPullPart` | 3 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKWriteBack` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKBodyEffector` | 8 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionCollider` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionColliderCollisionInfo` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionComponentBase` | 5 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionGoal` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionJobCollider` | 0 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionJobGoal` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCustomLookAtEffector` | 22 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKGoalEffector` | 9 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKHintEffector` | 8 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKLookAtEffector` | 5 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManageData` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManageProperty` | 1 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManagePropertyData` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationMathUtility` | 9 | 5 | 6 | 0 | 0 |
| `ActorAnimation.ActorAnimationNodAdditiveJob` | 25 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationParameter` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverBoneBase` | 10 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFrillBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFrillJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFrillSetting` | 1 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFurisodeBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverFurisodeJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHairBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHairJobBone` | 4 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHairSetting` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmBone` | 3 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmJobBone` | 5 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmSetting` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandBone` | 3 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandJobBone` | 5 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandSetting` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveBone` | 3 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveJobBone` | 5 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveSetting` | 2 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegBone` | 3 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegJobBone` | 5 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegSetting` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoBone` | 4 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationJobBone` | 4 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtBone` | 1 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtSetting` | 1 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverUtility` | 0 | 1 | 11 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistBone` | 1 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<ActorAnimationJob, ActorAnimationRigData, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerJobLocator` | 4 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingJobSkeleton` | 16 | 5 | 8 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingSkeletonCalcUtility` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingSkeletonUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationWindUtility` | 0 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingAffineTransform` | 5 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingBreastBone` | 21 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingChain` | 5 | 0 | 2 | 0 | 0 |
| `ActorAnimation.ActorSwingChain.<>c__DisplayClass4_0` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingColliderUtility` | 0 | 2 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingCollisionUtility` | 7 | 5 | 3 | 0 | 0 |
| `ActorAnimation.ActorSwingDynamicBone` | 18 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingJobBreastBone` | 0 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingJobBreastBoneCurve` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingJobBreastBoneSetting` | 0 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingJobDynamicBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingJobDynamicBoneCash` | 1 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingJobLimitInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingJobReferenceLimitInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingStaticBone` | 11 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingUtility` | 4 | 1 | 0 | 0 | 0 |
| `ActorAnimation.AnimationCurveEvaluator` | 2 | 2 | 3 | 0 | 0 |
| `ActorAnimation.ChainInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ChainLayerInfo` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CurveConversion` | 1 | 0 | 1 | 0 | 0 |
| `ActorAnimation.LimitInfo` | 1 | 0 | 0 | 0 | 0 |

### Qua.Utility

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `Qua.Extensions.IDictionaryExtensions` | 3 | 0 | 0 | 0 | 10 |
| `Qua.Extensions.IEnumerableExtensions` | 4 | 0 | 0 | 0 | 29 |

### Uguiss-Timeline.Runtime

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `Uguiss.Timeline.AbstractScriptPlayableCommand<object, object, object>` | 0 | 1 | 0 | 0 | 0 |
| `Uguiss.Timeline.TimelineEngineUtility` | 1 | 0 | 1 | 0 | 0 |

### campus-submodule.Runtime

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `ActorAnimation.CampusActorAnimationFullBodyIKOverrideSettingHolder` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationFullBodyIKPullPart` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationIKLookAtEffector` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationInitializeData` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationJob` | 60 | 0 | 8 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationJointLimit` | 11 | 1 | 1 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationJointLimitUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationLookAtLimit` | 46 | 1 | 1 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationLookAtLimitUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationRig` | 3 | 4 | 1 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightComponent` | 9 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimeline` | 9 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineAsset` | 3 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineBehaviour` | 1 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightTimelineTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.AudiencePenlightVolume` | 5 | 1 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.DefaultAudiencePenlight` | 5 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideAsset` | 3 | 0 | 0 | 0 | 0 |
| `Campus.AudiencePenlight.MobAudiencePenlightOverrideTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.AnimationEventHandler` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorAnimation` | 21 | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorController` | 59 | 13 | 19 | 0 | 0 |
| `Campus.Common.CampusActorController.<>c` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorController.OverrideActorMaterialPropertyData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorController.ShaderIDs` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorEffectController` | 5 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorEyeHighlight` | 1 | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorEyeHighlight.LimitData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorFaceCorrection` | 6 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout` | 5 | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.<>c` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.Constraint` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorLayout.Data` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialEffect` | 5 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialEffectPlayable` | 3 | 2 | 0 | 0 | 0 |
| `Campus.Common.CampusActorMaterialProperty` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusActorModelParts` | 3 | 1 | 1 | 0 | 0 |
| `Campus.Common.CampusActorTalkModel` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusCustomLookAtEffector` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusLightAnchor` | 8 | 0 | 1 | 0 | 0 |
| `Campus.Common.CampusLightAnchorBase` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusTransformAnchor` | 16 | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController` | 18 | 0 | 1 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController.FocusedEyeBoneResult` | 1 | 1 | 0 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController.HipsPosXZResult` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.CampusVirtualActorController.ScaleResult` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.FloatCurve` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Common.LayoutMotionDefine` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveEnvironment` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController` | 62 | 4 | 10 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c` | 17 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass113_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass114_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass115_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass123_0` | 1 | 1 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass124_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass124_1` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass126_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass129_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass129_1` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.LiveProp` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.LivePropSetting` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Common.Panorama.PanoramaCameraHolder` | 2 | 0 | 1 | 0 | 0 |
| `Campus.Common.UIDrawObjects` | 1 | 0 | 1 | 0 | 0 |
| `Campus.Common.VideoImage` | 6 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.ClipData` | 2 | 2 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdAnimationBehaviour` | 8 | 6 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdAnimationTimeline` | 33 | 2 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdAnimator` | 7 | 8 | 1 | 0 | 0 |
| `Campus.Crowd.CrowdAnimator.<>c` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData` | 7 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.CrowdVolumeBoneData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.MeshData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdModelData.SubMeshData` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdMotionDefine` | 4 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdOcclusionVolume` | 4 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineAsset` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineBehaviour` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdTimelineTrack.<>c` | 4 | 0 | 0 | 0 | 0 |
| `Campus.Crowd.CrowdVolume` | 8 | 2 | 1 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLight` | 28 | 0 | 2 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCachedChunk` | 4 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCombinedChunks` | 15 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCulledChunk` | 4 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCullingSystem` | 2 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCullingSystem.CullingJob` | 1 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightDrawSystem` | 5 | 0 | 1 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightEntityChunk` | 1 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightEntityManager` | 2 | 1 | 1 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightRendererFeature` | 8 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightResultChunk` | 4 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightResultSystem` | 2 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightResultSystem.ResultJob` | 1 | 0 | 1 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightUpdateSystem` | 2 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightUpdateSystem.UpdateJob` | 0 | 0 | 2 | 0 | 0 |
| `Campus.DecalLight.SharedCampusDecalLightEntityManager` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight` | 4 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveDirectionalLight.<get_GatherProperties>d__3` | 7 | 0 | 1 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser` | 6 | 1 | 3 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser.<get_GatherProperties>d__31` | 6 | 0 | 2 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob` | 0 | 2 | 3 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightBasic` | 5 | 0 | 2 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightBasic.<get_GatherProperties>d__13` | 6 | 0 | 2 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightComponent` | 3 | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Environment.LiveLightComponent.<get_GatherProperties>d__6` | 6 | 0 | 2 | 0 | 0 |
| `Campus.Live.Equipment.EnvironmentBase` | 2 | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.EquipmentValue` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentComponentProperty` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentController` | 25 | 0 | 1 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentController.<>c` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.LiveEquipmentReceiver` | 12 | 2 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase<object>` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightClip` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightTrack` | 1 | 1 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserClip` | 1 | 0 | 1 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightClip` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLightTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentTrackBase` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Live.Monitor.MonitorRepeatImage` | 12 | 0 | 2 | 0 | 0 |
| `Campus.Live.SRTSubtitle` | 1 | 0 | 0 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController` | 11 | 0 | 1 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.<>c` | 4 | 0 | 1 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.MobPenlightSetting` | 1 | 0 | 0 | 0 | 0 |
| `Campus.MobAudience.MobAudiencePenlightController.RuntimeMobPenlightSetting` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Rendering.CampusActorParameterPass` | 7 | 1 | 0 | 0 | 0 |
| `Campus.Rendering.CampusActorParameterSettings` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Rendering.CampusGlobalParameterRendererFeature` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Rendering.CampusLitActor` | 0 | 0 | 1 | 0 | 0 |
| `Campus.Rendering.CampusLitColorParameter` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Rendering.VegetationParameter` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.BeatDenominatorMarker` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.BeatNumeratorMarker` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmInfo` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmMarkerTrack` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmTimelineAsset` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusBpmTimelineTrack` | 3 | 0 | 1 | 0 | 0 |
| `Campus.Timeline.CampusCutMarker` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusDirectorControlAsset` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusDirectorControlTrack` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusLightAsset` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusLightTrack` | 4 | 0 | 3 | 0 | 0 |
| `Campus.Timeline.CampusSubTitleTimelineAsset` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusSubtitleBehaviour` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusSubtitleTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageClip` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageClipBehaviour` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusTargetImageTrack` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVideoPlayerClip` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVideoPlayerTrack` | 2 | 0 | 1 | 0 | 0 |
| `Campus.Timeline.CampusVideoPlayerTrackBehaviour` | 17 | 5 | 2 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineAsset` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineBehaviour` | 1 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CampusVolumeTimelineTrack` | 3 | 0 | 0 | 0 | 0 |
| `Campus.Timeline.CurrentActorSignalData` | 1 | 0 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTexture` | 23 | 0 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTextureImage` | 5 | 0 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTextureRenderer` | 4 | 0 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTextureRendererData` | 2 | 0 | 0 | 0 | 0 |
| `CanvasRT.CanvasRenderTextureRendererPass` | 5 | 1 | 1 | 0 | 0 |
| `FasterLinq` | 4 | 0 | 0 | 0 | 50 |
| `FasterLinq.SelectArray<ExamBattleResult, int>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ExamBattleResult, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, UniTask>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, ValueTuple<Int32Enum, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<MessageLogSoundInfo, UniTask>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, int, object, object>, UniTask<ValueTuple<bool, object>>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, ValueTuple<int, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, int>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, Int32Enum>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int, int>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int, object, object, object>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, int>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object, object>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<ValueTuple<object, object>, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<object, Int32Enum, bool, bool, int, int, int>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<int, int>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<int, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Color>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Int32Enum>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, MessageLogSoundInfo>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask<bool>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask<object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<Int32Enum, int, object, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, bool>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, int, object, object, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, ValueTuple<object, object>>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Vector2>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, Vector3>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, bool>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, float>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, int>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, long>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, object>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<uint, Color>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<uint, bool>` | 0 | 0 | 0 | 0 | 1 |
