# Task H3 — True End dependency closure

**H3 remains incomplete.** This batch restores animation dispatch and factories for constraints, Quartz and IK, their data bindings, the dirty-data update path, collider conversion, Canvas rendering and audience penlight helpers. The swing factory and solver, full-body IK solver, campus look-at/joint execution, rig reset/sorting helpers, decal systems and actor shader-parameter uploads still need bodies.

The inventory now contains 1,654 distinct native names, including 584 names added beyond the H2 census. Original H2 coverage had 1,070 names. Every addition and its reachability reason is recorded in `Evidence/TaskH/h3-census-additions.json`.

## Assembly totals

| Assembly | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `ActorAnimation.Runtime` | 334 | 32 | 35 | 86 | 0 |
| `Qua.Utility` | 7 | 0 | 0 | 33 | 6 |
| `Uguiss-Timeline.Runtime` | 1 | 1 | 1 | 0 | 0 |
| `campus-submodule.Runtime` | 764 | 65 | 77 | 202 | 10 |
| **Total** | 1106 | 98 | 113 | 321 | 16 |

## Restored batches

- Animation dispatch follows FullBodyIK → LookAtLimit → JointLimit → Constraint → Quartz → Swing. Generic utility dispatch preserves in-place job writes. Root motion copies the scene locator transform. Disposal follows the APK order.
- Constraint and Quartz factories allocate the APK fixed capacities. Constraint evaluation reads each valid source and calls the recovered transform calculation. All eleven Quartz job types have binding, validity, resolution, execution and setting-update bodies. Frill calculation, setting conversions and static muscle constants are restored.
- The campus IK factory binds body, goal, hint and look-at effectors, limb and move handles, correction goals/colliders, nod-additive properties and head writeback properties. Effector data accessors and the dirty-source update paths now have bodies.
- Rig updates preserve the APK pointer traversal and dirty-flag resets for constraints, Quartz, breast, dynamic, static and chain data. Collision conversion and broad-phase bounds, animation manager property binding/defaults, volume defaults and camera callbacks are restored.
- Canvas renderer/data/pass and UIDrawObjects now construct passes, set filtering, draw Canvas and monitor images, adjust monitor-camera transforms, cull and release resources. AudiencePenlightComponent builds the repeating eight-color table and supplies its interface properties.

## Scope findings

The previous Task F result was **632 same / 36 [layout] / 37 [semantic] / 0 only-in-game**. The H2 report incorrectly described the 37 semantic entries as missing. H2 actually reported 630 same / 75 changed / 0 only-in-game.

APK branch scanning found zero direct callers of `CampusActorModelParts.AddCombinedOpaqueSubMesh`. The recovered `InitializeCampusMaterials` also contains no call to it. It is excluded from the added live census. Its body remains a skeleton. No artificial caller was added. The native caller scan is recorded in `h3-combined-submesh-callers.json`.

Missing signatures whose types identify exam battle, gasha, produce, message-log or April Fool features are marked out of scope. Their native callers are listed in `h3-out-of-scope-callers.txt` and the full signature/caller record. Erased/shared signatures with unproven live reachability remain `not done`. A missing `ToArray` specialization for a feature-specific element type inherits that feature restriction even when its direct native call was inlined.

## Verification

Verification uses APK decompilation/disassembly, Unity C# and IL2CPP compilation, and the supplied function-comparison tools. No tests or runtime harnesses were written or run.

The final build log is `.recon/task-h3/build-final-unity.log`. C# and native IL2CPP compilation completed. Gradle APK packaging still fails at `lintVitalAnalyzeRelease` with `For input string: "37.0"`. The final comparison ran after the last source change. Build verification is compilation-only. True End execution remains blocked by the unfinished dependency bodies.

The expanded raw comparison reports 1108 same, 416 changed and 130 only-in-game. Source stubs and missing overload signatures remain `not done` even if the raw comparator labels them `[semantic]`.

The final compiled source snapshot is `018e559`. The original 1,070-name H census reports 793 same, 152 changed and 125 only-in-game. The strict audit finds 146 missing signatures across 132 names in the expanded inventory, including overloads skipped by the canonical comparator. Generated LAYOUT.md, LAYOUT-ALL.md and Tools/build-artifacts.json were restored before commits.

Task F reports **629 same / 76 changed / 0 only-in-game**. Compared with H2, `VL.Animation.MotionLayerPlayable.OnPlayableDestroy` and `VLB.SRPHelper.IsUsingCustomRenderPipeline` acquire semantic flags, while `VL.MotionDefinePlayable.OnBehaviourPause` returns to same. The new flags come from native load thunks and the comparator's subsequent metadata-address tracking. Each inspected thunk executes the displaced load and branches back to the following instruction. Full instructions and target bodies are retained in `h3-task-f-branch-review.txt`.

The H census gains ten flags and loses six. Reviewed causes include constructor inlining, load thunks, metadata initialization order and neighboring-function boundaries. The raw flags are preserved. The final native review also records unresolved callees, including actor shader-parameter upload. Comparison found and corrected the Poncho local-position write and the sleeve job's driven-handle-only resolution.

`UpdateIKCorrectionColliderProperty<CampusActorAnimationRigData>` now emits through the recovered `CampusActorAnimationRig.UpdateIKCorrectionColliderProperty` caller. The source update matches the APK's boxed-job type check and copy. Artificial instantiation callers were not introduced.

## Remaining work

1. Reconstruct `CampusActorAnimationJob.CreateSwingSkeleton` and the swing solver, prewarm, reset, collision, chain and seated-correction dependency bodies. Binding accessors and collider conversion alone do not complete this path.
2. Reconstruct `ActorAnimationFullBodyIKJobSkeleton.Execute` and all its solving, pull, nod and correction callees. Complete the remaining `CampusActorAnimationLookAtLimit` and `CampusActorAnimationJointLimit` accessors, validity and execution bodies. Their constructors already have reconstructed field assignments. Restore the remaining rig reset/inactive-bone overrides and Quartz hierarchy sorting helpers.
3. Reconstruct the decal entity/chunk/update/culling/result/draw systems and renderer-feature lifecycle. Restore `CampusActorParameterPass.UpdateActorCommand` and reached shader-parameter helpers.
4. Resolve the remaining shared generic signatures through proven live callers. The explicit out-of-scope feature signatures are excluded from this work.
5. Review the retained semantic flags as unfinished dependencies gain bodies. The final native diff records remain available for instruction-level follow-up.

## H3 commits

- `59049f7` — Restore actor animation job dispatch, Quartz allocation and root lifecycle from APK
- `d18a238` — Reconstruct Quartz job binding execution conversions and dependent calculations
- `e56f7c9` — Restore constraint job sources evaluation and dirty flag lifecycle
- `00a3513` — Restore campus IK factory effector data bindings and rig dirty updates
- `5ce4ceb` — Restore animation manager volume flow and swing collider conversion
- `b4e7fca` — Restore canvas monitor rendering and audience penlight helpers
- `018e559` — Restore the real rig caller for IK collider update specialization

Earlier H/H2 commits and historical comparison evidence remain in git history and `Evidence/TaskH/h2-summary.json`.

## Per-type results

### ActorAnimation.Runtime

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `ActorAnimation.ActorAnimationConstraintBoneComponentBase` | 5 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformBone` | 9 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintTransformJobBone` | 5 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationConstraintUtility` | 0 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKJobSkeleton` | 0 | 0 | 0 | 21 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKLimbPart` | 15 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKMovePart` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKPullPart` | 2 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationFullBodyIKWriteBack` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKBodyEffector` | 8 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionCollider` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionComponentBase` | 5 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionGoal` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionJobCollider` | 0 | 2 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCorrectionJobGoal` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKCustomLookAtEffector` | 22 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKGoalEffector` | 9 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKHintEffector` | 8 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationIKLookAtEffector` | 4 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationManageData` | 6 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManageProperty` | 1 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationManagePropertyData` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationMathUtility` | 9 | 5 | 5 | 1 | 0 |
| `ActorAnimation.ActorAnimationNodAdditiveJob` | 25 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationParameter` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverBoneBase` | 5 | 0 | 0 | 5 | 0 |
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
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveBone` | 2 | 0 | 1 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveJobBone` | 5 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveSetting` | 1 | 1 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegBone` | 3 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegJobBone` | 5 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegSetting` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoBone` | 4 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverPonchoJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverRotationJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtBone` | 2 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverSkirtSetting` | 1 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverUtility` | 0 | 1 | 11 | 0 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistBone` | 2 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorAnimationQuartzDriverWaistJobBone` | 5 | 1 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<ActorAnimationJob, ActorAnimationRigData, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRig<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, object>` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerJobLocator` | 4 | 1 | 1 | 0 | 0 |
| `ActorAnimation.ActorAnimationRootControllerUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationSwingJobSkeleton` | 11 | 0 | 0 | 18 | 0 |
| `ActorAnimation.ActorAnimationSwingSkeletonUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorAnimationWindUtility` | 0 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorSwingAffineTransform` | 0 | 0 | 0 | 7 | 0 |
| `ActorAnimation.ActorSwingBreastBone` | 20 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingChain` | 4 | 1 | 2 | 0 | 0 |
| `ActorAnimation.ActorSwingChain.<>c__DisplayClass4_0` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingColliderUtility` | 0 | 2 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingCollisionUtility` | 0 | 0 | 0 | 15 | 0 |
| `ActorAnimation.ActorSwingDynamicBone` | 17 | 0 | 1 | 0 | 0 |
| `ActorAnimation.ActorSwingJobBreastBone` | 0 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorSwingJobBreastBoneCurve` | 0 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorSwingJobBreastBoneSetting` | 0 | 0 | 0 | 1 | 0 |
| `ActorAnimation.ActorSwingJobDynamicBone` | 0 | 0 | 0 | 3 | 0 |
| `ActorAnimation.ActorSwingJobDynamicBoneCash` | 0 | 0 | 0 | 2 | 0 |
| `ActorAnimation.ActorSwingJobLimitInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingJobReferenceLimitInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingStaticBone` | 11 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ActorSwingUtility` | 0 | 0 | 0 | 5 | 0 |
| `ActorAnimation.ChainInfo` | 1 | 0 | 0 | 0 | 0 |
| `ActorAnimation.ChainLayerInfo` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.LimitInfo` | 1 | 0 | 0 | 0 | 0 |

### Qua.Utility

| Type | same | [layout] | [semantic] | not done | out of scope |
|---|---:|---:|---:|---:|---:|
| `Qua.Extensions.IDictionaryExtensions` | 3 | 0 | 0 | 9 | 1 |
| `Qua.Extensions.IEnumerableExtensions` | 4 | 0 | 0 | 24 | 5 |

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
| `ActorAnimation.CampusActorAnimationJob` | 55 | 3 | 9 | 1 | 0 |
| `ActorAnimation.CampusActorAnimationJointLimit` | 1 | 0 | 0 | 12 | 0 |
| `ActorAnimation.CampusActorAnimationJointLimitUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationLookAtLimit` | 1 | 0 | 0 | 47 | 0 |
| `ActorAnimation.CampusActorAnimationLookAtLimitUtility` | 2 | 0 | 0 | 0 | 0 |
| `ActorAnimation.CampusActorAnimationRig` | 2 | 0 | 1 | 5 | 0 |
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
| `Campus.Common.CampusActorController` | 51 | 17 | 23 | 0 | 0 |
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
| `Campus.Common.CampusActorMaterialEffectPlayable` | 4 | 1 | 0 | 0 | 0 |
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
| `Campus.Common.Live.CampusLiveTimelineController` | 64 | 5 | 7 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c` | 17 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass113_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass114_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass115_0` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Common.Live.CampusLiveTimelineController.<>c__DisplayClass123_0` | 2 | 0 | 0 | 0 | 0 |
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
| `Campus.Crowd.CrowdVolume` | 9 | 2 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLight` | 28 | 0 | 2 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightCachedChunk` | 1 | 0 | 0 | 3 | 0 |
| `Campus.DecalLight.CampusDecalLightCombinedChunks` | 1 | 0 | 0 | 14 | 0 |
| `Campus.DecalLight.CampusDecalLightCulledChunk` | 0 | 0 | 0 | 4 | 0 |
| `Campus.DecalLight.CampusDecalLightCullingSystem` | 0 | 0 | 0 | 2 | 0 |
| `Campus.DecalLight.CampusDecalLightCullingSystem.CullingJob` | 0 | 0 | 0 | 1 | 0 |
| `Campus.DecalLight.CampusDecalLightDrawSystem` | 0 | 0 | 0 | 6 | 0 |
| `Campus.DecalLight.CampusDecalLightEntityChunk` | 1 | 0 | 0 | 0 | 0 |
| `Campus.DecalLight.CampusDecalLightEntityManager` | 1 | 0 | 0 | 3 | 0 |
| `Campus.DecalLight.CampusDecalLightRendererFeature` | 1 | 0 | 0 | 7 | 0 |
| `Campus.DecalLight.CampusDecalLightResultChunk` | 1 | 0 | 0 | 3 | 0 |
| `Campus.DecalLight.CampusDecalLightResultSystem` | 0 | 0 | 0 | 2 | 0 |
| `Campus.DecalLight.CampusDecalLightResultSystem.ResultJob` | 0 | 0 | 0 | 2 | 0 |
| `Campus.DecalLight.CampusDecalLightUpdateSystem` | 0 | 0 | 0 | 2 | 0 |
| `Campus.DecalLight.CampusDecalLightUpdateSystem.UpdateJob` | 0 | 0 | 0 | 2 | 0 |
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
| `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightTrack` | 2 | 0 | 0 | 0 | 0 |
| `Campus.Live.Equipment.Timeline.LiveEquipmentLaserClip` | 2 | 0 | 0 | 0 | 0 |
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
| `Campus.Rendering.CampusActorParameterPass` | 0 | 0 | 0 | 8 | 0 |
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
| `CanvasRT.CanvasRenderTextureRendererPass` | 5 | 0 | 2 | 0 | 0 |
| `FasterLinq` | 2 | 0 | 0 | 46 | 6 |
| `FasterLinq.SelectArray<ExamBattleResult, int>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ExamBattleResult, object>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<Int32Enum, UniTask>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<Int32Enum, ValueTuple<Int32Enum, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<Int32Enum, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<MessageLogSoundInfo, UniTask>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<ValueTuple<int, int, object, object>, UniTask<ValueTuple<bool, object>>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, ValueTuple<int, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, int>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<int, object, object>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, Int32Enum>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, int, int>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, int, object, object, object>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, int>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, object, object>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<ValueTuple<object, object>, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, ValueTuple<object, Int32Enum, bool, bool, int, int, int>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<ValueTuple<object, object>, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<int, int>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<int, object>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, Color>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, Int32Enum>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, MessageLogSoundInfo>` | 0 | 0 | 0 | 0 | 1 |
| `FasterLinq.SelectArray<object, UniTask<bool>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, UniTask<object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, UniTask>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, ValueTuple<Int32Enum, int, object, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, ValueTuple<object, bool>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, ValueTuple<object, int, object, object, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, ValueTuple<object, object>>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, Vector2>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, Vector3>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, bool>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, float>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, int>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<object, long>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<object, object>` | 1 | 0 | 0 | 0 | 0 |
| `FasterLinq.SelectArray<uint, Color>` | 0 | 0 | 0 | 1 | 0 |
| `FasterLinq.SelectArray<uint, bool>` | 0 | 0 | 0 | 1 | 0 |
