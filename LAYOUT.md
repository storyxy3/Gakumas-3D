# Android native layout acceptance

Unity **6000.0.77f1**, Android **IL2CPP ARM64**, compared with APK **3.5.3**.

- Editor batchmode import: successful; compiler/postprocessor errors: 0.
- Native IL2CPP conversion, C++ compilation and linking produced the library and metadata below. Il2CppDumper recovered metadata version 31.
- Unity build result: `LIVE_BUILD Failed errors=3`.
- Gradle packaging fails at `:unityLibrary:lintVitalAnalyzeRelease`, parsing SDK version `37.0`. The requested native artifacts are complete; no successful APK packaging is claimed.
- No tests were authored or run. No deployment was performed.

## Rendering-closure result

Local skeleton assemblies including Octo: **3631 matching**, **75 mismatching**, **422 indeterminate**, **8 missing**, **1595 extra**.

Across the local skeleton, registry and fork assemblies below, **26 types** have differing offsets for same-named declared instance fields; **20 types** have differing static-storage offsets. Other mismatches include field names/types/order, constants, interface/base declarations and explicit closure cuts. Inherited storage is evaluated in each declaring type.

Generic definitions with unavailable concrete offsets remain indeterminate. Compiler/linker-generated additions and stripping differences remain visible. This is a structural skeleton, not evidence of reconstructed runtime behavior.

[LAYOUT-ALL.md](LAYOUT-ALL.md) covers **every assembly present in the rebuilt native metadata**, including engine and framework classes. The detailed rendering table below lists every matching, mismatching, missing, extra or indeterminate type in the selected closure.

## Build provenance

- Project source/report checkpoint: `a5a8ea3a633aad7d6c5ae02812410d5f36e73abc`.
- URP/Core fork: `03f6b35f92be52d98a11ab58a15452ff416da537`.
- Rebuild: `bash Tools/build_android.sh`; dump and compare: `bash Tools/dump_layout.sh`.
- Input DummyDll hashes: [Tools/skeleton-inputs.json](Tools/skeleton-inputs.json). Package evidence: [PACKAGES.md](PACKAGES.md). Exact dependency cuts and compiler repairs: [CLOSURE.md](CLOSURE.md).

- `libil2cpp.so`: `Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main/jniLibs/arm64-v8a/libil2cpp.so`; SHA-256 `6cb006322125b56d6e9ef32326bf935afcf66b1631461386fe533685cabd2255`.
- `global-metadata.dat`: `Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main/assets/bin/Data/Managed/Metadata/global-metadata.dat`; SHA-256 `2c6cb512769a62cbbe5bfb97f3c781f37d8ba732638664f4182a9ed2c19ade2e`.

## Types with remaining instance-offset differences

- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomConfig`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomExAcbLoader`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomExOutputAnalyzer`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomListener`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomRegion`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriAtomSourceBase`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuvRawData`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriManaMovieController`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriManaMovieControllerForUI`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriManaMovieMaterial`
- `CriMw.CriWare.Runtime.dll` — `CriWare.CriManaMovieMaterialBase`
- `DOTween.dll` — `DG.Tweening.Core.DOTweenSettings`
- `DOTween.dll` — `DG.Tweening.Plugins.Core.PathCore.Path`
- `DOTween.dll` — `DG.Tweening.Plugins.Options.PathOptions`
- `DOTween.dll` — `DOTweenSettings.SafeModeOptions`
- `Unity.Burst.dll` — `Unity.Burst.BurstCompileAttribute`
- `Unity.Burst.dll` — `Unity.Burst.BurstCompilerOptions`
- `Unity.RenderPipelines.Core.Runtime.dll` — `DebugUI.EnumField`
- `Unity.RenderPipelines.Core.Runtime.dll` — `DebugUI.HistoryEnumField`
- `Unity.RenderPipelines.Core.Runtime.dll` — `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams`
- `Unity.RenderPipelines.Core.Runtime.dll` — `UnityEngine.Rendering.DynamicResolutionHandler`
- `Unity.RenderPipelines.Universal.Runtime.dll` — `UnityEngine.Rendering.Universal.DBufferRenderPass`
- `Unity.RenderPipelines.Universal.Runtime.dll` — `UnityEngine.Rendering.Universal.UniversalRenderer`
- `Unity.RenderPipelines.Universal.Runtime.dll` — `VL.Rendering.VLSRPRenderer`
- `campus-submodule.Runtime.dll` — `Campus.Common.Sound.CampusSoundPlayer`
- `campus-submodule.Runtime.dll` — `Campus.Timeline.CampusTimelineCriVideoPlayer`

# IL2CPP field layout comparison

Original: `/data/xy/gakumas/work/il2cpp-3.5.3/dump.cs`
SHA-256: `4bdd8715472c84f81f895f2fb373c724c787da3afc7a0c5b1e539a04c4387c46`

Build: `/data/xy/gakumas/live-urp/.recon/live-dump/dump.cs`
SHA-256: `2fa6ec978b0b08070326ac01688904896ae49ffeec417e15bb3e78e7db3e7c8c`

Assembly selection: `^(?:ActorAnimation\.Runtime\.dll&#124;AmplifyOcclusion\.Runtime\.dll&#124;Cinemachine\.dll&#124;CriMw\.CriWare\.Runtime\.dll&#124;DOTween\.dll&#124;Octo\.dll&#124;ProFlare\.Runtime\.dll&#124;Qua\.Base\.Runtime\.dll&#124;Qua\.PolygonUtility\.dll&#124;Qua\.Utility\.dll&#124;Qua\.VectorUI\.Runtime\.dll&#124;Titan\.Runtime\.dll&#124;Uguiss\-Timeline\.Runtime\.dll&#124;Uguiss\.Runtime\.dll&#124;UniRx\.dll&#124;UniTask\.Linq\.dll&#124;UniTask\.dll&#124;Unity\.Animation\.Rigging\.dll&#124;Unity\.Burst\.dll&#124;Unity\.Collections\.dll&#124;Unity\.Mathematics\.dll&#124;Unity\.Profiling\.Core\.dll&#124;Unity\.RenderPipelines\.Core\.Runtime\.dll&#124;Unity\.RenderPipelines\.Universal\.Runtime\.dll&#124;Unity\.TextMeshPro\.dll&#124;Unity\.Timeline\.dll&#124;Unity\.VisualEffectGraph\.Runtime\.dll&#124;UnityEngine\.UI\.dll&#124;campus\-submodule\.Runtime\.dll&#124;campus\-submodule\.Shader\.Runtime\.dll&#124;quaunity\-crypto\.dll&#124;quaunity\-global\.dll&#124;quaunity\-ui\.Runtime\.dll&#124;quaunity\-volumetriclightbeam\.Runtime\.dll&#124;vl\-unity\.Runtime\.dll)$`

Names are matched exactly within each assembly, including nested and compiler-generated types. Matching means equal type kind/base declarations and declared field names, types, order, storage kind and available offsets. Instance, static and thread-static offsets belong to separate storage areas; constants have no storage. Missing/extra types remain visible; stripping and compiler-generated renaming can cause these outcomes.

This report cannot establish object size, tail padding, concrete generic-instance layouts, method behavior, serialization attribute argument values, or runtime initialization. Inherited fields are compared in their declaring types. A type with no declared storage fields matches vacuously. Generic definitions and unavailable storage offsets are indeterminate. Dumps must come from the same architecture and compatible IL2CPP object model for offsets to be comparable.

| Assembly | Matching | Mismatching | Indeterminate | Missing from build | Extra in build |
| --- | ---: | ---: | ---: | ---: | ---: |
| `ActorAnimation.Runtime.dll` | 163 | 0 | 1 | 0 | 5 |
| `AmplifyOcclusion.Runtime.dll` | 18 | 0 | 0 | 0 | 5 |
| `Cinemachine.dll` | 178 | 6 | 0 | 0 | 11 |
| `CriMw.CriWare.Runtime.dll` | 310 | 28 | 0 | 6 | 131 |
| `DOTween.dll` | 121 | 17 | 0 | 2 | 66 |
| `Octo.dll` | 209 | 4 | 40 | 0 | 5 |
| `ProFlare.Runtime.dll` | 27 | 0 | 0 | 0 | 5 |
| `Qua.Base.Runtime.dll` | 12 | 1 | 0 | 0 | 5 |
| `Qua.PolygonUtility.dll` | 49 | 0 | 8 | 0 | 5 |
| `Qua.Utility.dll` | 25 | 0 | 8 | 0 | 5 |
| `Qua.VectorUI.Runtime.dll` | 29 | 0 | 4 | 0 | 5 |
| `Titan.Runtime.dll` | 286 | 0 | 24 | 0 | 5 |
| `Uguiss-Timeline.Runtime.dll` | 60 | 0 | 3 | 0 | 3 |
| `Uguiss.Runtime.dll` | 81 | 0 | 2 | 0 | 3 |
| `UniRx.dll` | 148 | 11 | 140 | 0 | 500 |
| `UniTask.Linq.dll` | 5 | 0 | 3 | 0 | 562 |
| `UniTask.dll` | 289 | 11 | 60 | 0 | 246 |
| `Unity.Animation.Rigging.dll` | 46 | 8 | 1 | 0 | 87 |
| `Unity.Burst.dll` | 23 | 9 | 0 | 0 | 68 |
| `Unity.Collections.dll` | 63 | 34 | 11 | 0 | 234 |
| `Unity.Mathematics.dll` | 19 | 21 | 0 | 0 | 64 |
| `Unity.Profiling.Core.dll` | 4 | 0 | 0 | 0 | 14 |
| `Unity.RenderPipelines.Core.Runtime.dll` | 257 | 23 | 24 | 8 | 208 |
| `Unity.RenderPipelines.Universal.Runtime.dll` | 543 | 34 | 10 | 1 | 184 |
| `Unity.TextMeshPro.dll` | 120 | 6 | 7 | 0 | 61 |
| `Unity.Timeline.dll` | 102 | 2 | 1 | 0 | 30 |
| `Unity.VisualEffectGraph.Runtime.dll` | 24 | 2 | 0 | 3 | 81 |
| `UnityEngine.UI.dll` | 183 | 2 | 3 | 0 | 20 |
| `campus-submodule.Runtime.dll` | 1088 | 2 | 40 | 0 | 5 |
| `campus-submodule.Shader.Runtime.dll` | 7 | 0 | 0 | 0 | 5 |
| `quaunity-crypto.dll` | 1 | 1 | 3 | 0 | 5 |
| `quaunity-global.dll` | 15 | 0 | 0 | 0 | 5 |
| `quaunity-ui.Runtime.dll` | 229 | 0 | 69 | 0 | 5 |
| `quaunity-volumetriclightbeam.Runtime.dll` | 138 | 0 | 0 | 0 | 5 |
| `vl-unity.Runtime.dll` | 321 | 0 | 17 | 0 | 9 |
| **Total** | 5193 | 222 | 479 | 20 | 2657 |

## ActorAnimation.Runtime.dll

<details><summary>Matching: 163</summary>

- `<Module>`
- `ActorAnimation.ActorAnimationBuilder`
- `ActorAnimation.ActorAnimationConstraintBoneBase`
- `ActorAnimation.ActorAnimationConstraintBoneComponentBase`
- `ActorAnimation.ActorAnimationConstraintBoneType`
- `ActorAnimation.ActorAnimationConstraintExecuteType`
- `ActorAnimation.ActorAnimationConstraintTransformBone`
- `ActorAnimation.ActorAnimationConstraintTransformJobBone`
- `ActorAnimation.ActorAnimationConstraintUtility`
- `ActorAnimation.ActorAnimationFullBodyIKCalcUtility`
- `ActorAnimation.ActorAnimationFullBodyIKJobSkeleton`
- `ActorAnimation.ActorAnimationFullBodyIKLimbPart`
- `ActorAnimation.ActorAnimationFullBodyIKMovePart`
- `ActorAnimation.ActorAnimationFullBodyIKPullPart`
- `ActorAnimation.ActorAnimationFullBodyIKPullPartSetting`
- `ActorAnimation.ActorAnimationFullBodyIKUtility`
- `ActorAnimation.ActorAnimationFullBodyIKWriteBack`
- `ActorAnimation.ActorAnimationFullbodyIKSimpleInitializer`
- `ActorAnimation.ActorAnimationFullbodyIKSimpleJob`
- `ActorAnimation.ActorAnimationIKBodyEffector`
- `ActorAnimation.ActorAnimationIKBodyEffectorLocator`
- `ActorAnimation.ActorAnimationIKCorrectionCollider`
- `ActorAnimation.ActorAnimationIKCorrectionColliderCollisionInfo`
- `ActorAnimation.ActorAnimationIKCorrectionColliderType`
- `ActorAnimation.ActorAnimationIKCorrectionComponentBase`
- `ActorAnimation.ActorAnimationIKCorrectionGoal`
- `ActorAnimation.ActorAnimationIKCorrectionJobCollider`
- `ActorAnimation.ActorAnimationIKCorrectionJobGoal`
- `ActorAnimation.ActorAnimationIKCustomLookAtEffector`
- `ActorAnimation.ActorAnimationIKGoalEffector`
- `ActorAnimation.ActorAnimationIKGoalEffectorLocator`
- `ActorAnimation.ActorAnimationIKHandleType`
- `ActorAnimation.ActorAnimationIKHintEffector`
- `ActorAnimation.ActorAnimationIKHintEffectorLocator`
- `ActorAnimation.ActorAnimationIKLookAtEffector`
- `ActorAnimation.ActorAnimationInitializeData`
- `ActorAnimation.ActorAnimationJob`
- `ActorAnimation.ActorAnimationJobBinder<TJob, TData>`
- `ActorAnimation.ActorAnimationLookAtEffectorLocator`
- `ActorAnimation.ActorAnimationManageData`
- `ActorAnimation.ActorAnimationManageProperty`
- `ActorAnimation.ActorAnimationManagePropertyData`
- `ActorAnimation.ActorAnimationMathUtility`
- `ActorAnimation.ActorAnimationNodAdditiveJob`
- `ActorAnimation.ActorAnimationParameter`
- `ActorAnimation.ActorAnimationQuartzDriverBoneBase`
- `ActorAnimation.ActorAnimationQuartzDriverBoneComponentBase`
- `ActorAnimation.ActorAnimationQuartzDriverBoneType`
- `ActorAnimation.ActorAnimationQuartzDriverFrillBone`
- `ActorAnimation.ActorAnimationQuartzDriverFrillJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverFrillSetting`
- `ActorAnimation.ActorAnimationQuartzDriverFrillSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverFurisodeBone`
- `ActorAnimation.ActorAnimationQuartzDriverFurisodeJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverFurisodeSetting`
- `ActorAnimation.ActorAnimationQuartzDriverFurisodeSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverHairBone`
- `ActorAnimation.ActorAnimationQuartzDriverHairJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverHairSetting`
- `ActorAnimation.ActorAnimationQuartzDriverHairSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmSetting`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidArmSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandSetting`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidHandSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveSetting`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidSleeveSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegSetting`
- `ActorAnimation.ActorAnimationQuartzDriverHumanoidUpLegSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverLateRotationSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverPonchoBone`
- `ActorAnimation.ActorAnimationQuartzDriverPonchoJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverPonchoSetting`
- `ActorAnimation.ActorAnimationQuartzDriverPonchoSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverRotationBone`
- `ActorAnimation.ActorAnimationQuartzDriverRotationComposeType`
- `ActorAnimation.ActorAnimationQuartzDriverRotationDecomposeType`
- `ActorAnimation.ActorAnimationQuartzDriverRotationJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverRotationSetting`
- `ActorAnimation.ActorAnimationQuartzDriverRotationSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverSimpleBoneBase`
- `ActorAnimation.ActorAnimationQuartzDriverSkirtBone`
- `ActorAnimation.ActorAnimationQuartzDriverSkirtJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverSkirtSetting`
- `ActorAnimation.ActorAnimationQuartzDriverSkirtSimpleBone`
- `ActorAnimation.ActorAnimationQuartzDriverUtility`
- `ActorAnimation.ActorAnimationQuartzDriverWaistBone`
- `ActorAnimation.ActorAnimationQuartzDriverWaistJobBone`
- `ActorAnimation.ActorAnimationQuartzDriverWaistSetting`
- `ActorAnimation.ActorAnimationQuartzDriverWaistSimpleBone`
- `ActorAnimation.ActorAnimationRig`
- `ActorAnimation.ActorAnimationRigData`
- `ActorAnimation.ActorAnimationRootControllerJobLocator`
- `ActorAnimation.ActorAnimationRootControllerUtility`
- `ActorAnimation.ActorAnimationSimpleInitializer`
- `ActorAnimation.ActorAnimationSwingBoneComponentBase`
- `ActorAnimation.ActorAnimationSwingJobSkeleton`
- `ActorAnimation.ActorAnimationSwingSkeletonCalcUtility`
- `ActorAnimation.ActorAnimationSwingSkeletonUtility`
- `ActorAnimation.ActorAnimationWindUtility`
- `ActorAnimation.ActorSwingAffineTransform`
- `ActorAnimation.ActorSwingBreastBone`
- `ActorAnimation.ActorSwingChain`
- `ActorAnimation.ActorSwingCollider`
- `ActorAnimation.ActorSwingColliderType`
- `ActorAnimation.ActorSwingColliderUtility`
- `ActorAnimation.ActorSwingCollisionUtility`
- `ActorAnimation.ActorSwingDynamicBone`
- `ActorAnimation.ActorSwingDynamicCollider`
- `ActorAnimation.ActorSwingGroup`
- `ActorAnimation.ActorSwingJobBreastBone`
- `ActorAnimation.ActorSwingJobBreastBoneCurve`
- `ActorAnimation.ActorSwingJobBreastBoneSetting`
- `ActorAnimation.ActorSwingJobChainBone`
- `ActorAnimation.ActorSwingJobCollider`
- `ActorAnimation.ActorSwingJobCollisionMask`
- `ActorAnimation.ActorSwingJobDynamicBone`
- `ActorAnimation.ActorSwingJobDynamicBoneCash`
- `ActorAnimation.ActorSwingJobLimitInfo`
- `ActorAnimation.ActorSwingJobReferenceLimitInfo`
- `ActorAnimation.ActorSwingJobSeatDynamicCorrection`
- `ActorAnimation.ActorSwingJobStaticBone`
- `ActorAnimation.ActorSwingStaticBone`
- `ActorAnimation.ActorSwingStaticCollider`
- `ActorAnimation.ActorSwingUtility`
- `ActorAnimation.AnimationCurveData`
- `ActorAnimation.AnimationCurveEvaluator`
- `ActorAnimation.ChainInfo`
- `ActorAnimation.ChainLayerInfo`
- `ActorAnimation.CollisionInfo`
- `ActorAnimation.CurveConversion`
- `ActorAnimation.DynamicType`
- `ActorAnimation.HitInfo`
- `ActorAnimation.IActorAnimation`
- `ActorAnimation.IActorAnimationBone`
- `ActorAnimation.IActorAnimationConstraintJobBone`
- `ActorAnimation.IActorAnimationFullBodyIK`
- `ActorAnimation.IActorAnimationJob`
- `ActorAnimation.IActorAnimationQuartzDriverJobBone`
- `ActorAnimation.IActorAnimationRigData`
- `ActorAnimation.IActorAnimationSwingSkeleton`
- `ActorAnimation.IActorSwingBone`
- `ActorAnimation.IActorSwingComponent`
- `ActorAnimation.InitialTransform`
- `ActorAnimation.KeyframeData`
- `ActorAnimation.LimitInfo`
- `ActorAnimation.ReferenceLimitInfo`
- `ActorAnimation.ResetType`
- `ActorAnimationRig.OnAddRigCallback<TJob, TData, TBinder>`
- `ActorAnimationRig.OnRemoveRigCallback<TJob, TData, TBinder>`
- `ActorAnimationRigData.<>c__DisplayClass90_0` (compiler-generated name)
- `ActorSwingChain.<>c__DisplayClass4_0` (compiler-generated name)
- `ActorSwingGroup.OnAddGroupCallback`
- `ActorSwingGroup.OnRemoveGroupCallback`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)

</details>

<details><summary>Indeterminate: 1</summary>

- `ActorAnimation.ActorAnimationRig<TJob, TData, TBinder>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=14386`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=7634`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## AmplifyOcclusion.Runtime.dll

<details><summary>Matching: 18</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `AmplifyOcclusion.AmplifyOcclusion`
- `AmplifyOcclusion.AmplifyOcclusionCommon`
- `AmplifyOcclusion.AmplifyOcclusionPass`
- `AmplifyOcclusion.AmplifyOcclusionRendererFeature`
- `AmplifyOcclusion.AmplifyOcclusionRenderingData`
- `AmplifyOcclusion.AmplifyOcclusionViewProjMatrix`
- `AmplifyOcclusion.ApplicationMethod`
- `AmplifyOcclusion.ApplicationMethodParameter`
- `AmplifyOcclusion.PerPixelNormalSource`
- `AmplifyOcclusion.PerPixelNormalSourceParameter`
- `AmplifyOcclusion.PropertyID`
- `AmplifyOcclusion.SampleCountLevel`
- `AmplifyOcclusion.SampleCountLevelParameter`
- `AmplifyOcclusion.TargetDesc`

</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=1113`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=686`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Cinemachine.dll

<details><summary>Matching: 178</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `AxisState.IInputAxisProvider`
- `AxisState.Recentering`
- `AxisState.SpeedMode`
- `CameraState.BlendHintValue`
- `CameraState.CustomBlendable`
- `Cinemachine.AxisState`
- `Cinemachine.AxisStatePropertyAttribute`
- `Cinemachine.BlendSourceVirtualCamera`
- `Cinemachine.CameraState`
- `Cinemachine.Cinemachine3rdPersonAim`
- `Cinemachine.Cinemachine3rdPersonFollow`
- `Cinemachine.CinemachineBasicMultiChannelPerlin`
- `Cinemachine.CinemachineBlend`
- `Cinemachine.CinemachineBlendDefinition`
- `Cinemachine.CinemachineBlendDefinitionPropertyAttribute`
- `Cinemachine.CinemachineBlendListCamera`
- `Cinemachine.CinemachineBlenderSettings`
- `Cinemachine.CinemachineBrain`
- `Cinemachine.CinemachineClearShot`
- `Cinemachine.CinemachineCollider`
- `Cinemachine.CinemachineCollisionImpulseSource`
- `Cinemachine.CinemachineComponentBase`
- `Cinemachine.CinemachineComposer`
- `Cinemachine.CinemachineConfiner`
- `Cinemachine.CinemachineCore`
- `Cinemachine.CinemachineDollyCart`
- `Cinemachine.CinemachineEmbeddedAssetPropertyAttribute`
- `Cinemachine.CinemachineExtension`
- `Cinemachine.CinemachineExternalCamera`
- `Cinemachine.CinemachineFixedSignal`
- `Cinemachine.CinemachineFollowZoom`
- `Cinemachine.CinemachineFramingTransposer`
- `Cinemachine.CinemachineFreeLook`
- `Cinemachine.CinemachineGroupComposer`
- `Cinemachine.CinemachineHardLockToTarget`
- `Cinemachine.CinemachineHardLookAt`
- `Cinemachine.CinemachineImpulseChannelPropertyAttribute`
- `Cinemachine.CinemachineImpulseDefinition`
- `Cinemachine.CinemachineImpulseDefinitionPropertyAttribute`
- `Cinemachine.CinemachineImpulseEnvelopePropertyAttribute`
- `Cinemachine.CinemachineImpulseListener`
- `Cinemachine.CinemachineImpulseSource`
- `Cinemachine.CinemachineIndependentImpulseListener`
- `Cinemachine.CinemachineInputProvider`
- `Cinemachine.CinemachineMixingCamera`
- `Cinemachine.CinemachineOrbitalTransposer`
- `Cinemachine.CinemachinePOV`
- `Cinemachine.CinemachinePath`
- `Cinemachine.CinemachinePathBase`
- `Cinemachine.CinemachinePipeline`
- `Cinemachine.CinemachinePixelPerfect`
- `Cinemachine.CinemachineSameAsFollowTarget`
- `Cinemachine.CinemachineSmoothPath`
- `Cinemachine.CinemachineStateDrivenCamera`
- `Cinemachine.CinemachineStoryboard`
- `Cinemachine.CinemachineTargetGroup`
- `Cinemachine.CinemachineTrackedDolly`
- `Cinemachine.CinemachineTransposer`
- `Cinemachine.CinemachineTriggerAction`
- `Cinemachine.CinemachineVirtualCamera`
- `Cinemachine.CinemachineVirtualCameraBase`
- `Cinemachine.DocumentationSortingAttribute`
- `Cinemachine.GroupWeightManipulator`
- `Cinemachine.ICinemachineCamera`
- `Cinemachine.ICinemachineTargetGroup`
- `Cinemachine.ISignalSource6D`
- `Cinemachine.LensSettings`
- `Cinemachine.LensSettingsPropertyAttribute`
- `Cinemachine.NoSaveDuringPlayAttribute`
- `Cinemachine.NoiseSettings`
- `Cinemachine.NoiseSettingsPropertyAttribute`
- `Cinemachine.OrbitalTransposerHeadingPropertyAttribute`
- `Cinemachine.PostFX.CinemachinePostProcessing`
- `Cinemachine.PostFX.CinemachineVolumeSettings`
- `Cinemachine.RuntimeUtility`
- `Cinemachine.SaveDuringPlayAttribute`
- `Cinemachine.SignalSourceAsset`
- `Cinemachine.StaticPointVirtualCamera`
- `Cinemachine.TagFieldAttribute`
- `Cinemachine.UpdateTracker`
- `Cinemachine.Utility.CinemachineDebug`
- `Cinemachine.Utility.HeadingTracker`
- `Cinemachine.Utility.PositionPredictor`
- `Cinemachine.Utility.SplineHelpers`
- `Cinemachine.Utility.UnityQuaternionExtensions`
- `Cinemachine.VcamTargetPropertyAttribute`
- `CinemachineBlendDefinition.Style`
- `CinemachineBlendListCamera.Instruction`
- `CinemachineBlenderSettings.CustomBlend`
- `CinemachineBrain.<AfterPhysics>d__32` (compiler-generated name)
- `CinemachineBrain.BrainEvent`
- `CinemachineBrain.BrainFrame`
- `CinemachineBrain.BrainUpdateMethod`
- `CinemachineBrain.UpdateMethod`
- `CinemachineBrain.VcamActivatedEvent`
- `CinemachineCameraOffset`
- `CinemachineClearShot.<>c` (compiler-generated name)
- `CinemachineClearShot.Pair`
- `CinemachineCollider.ResolutionStrategy`
- `CinemachineCollider.VcamExtraState`
- `CinemachineComposer.FovCache`
- `CinemachineConfiner.Mode`
- `CinemachineConfiner.VcamExtraState`
- `CinemachineCore.AxisInputDelegate`
- `CinemachineCore.GetBlendOverrideDelegate`
- `CinemachineCore.Stage`
- `CinemachineCore.UpdateFilter`
- `CinemachineCore.UpdateStatus`
- `CinemachineDebug.OnGUIDelegate`
- `CinemachineDollyCart.UpdateMethod`
- `CinemachineFollowZoom.VcamExtraState`
- `CinemachineFramingTransposer.AdjustmentMode`
- `CinemachineFramingTransposer.FramingMode`
- `CinemachineFreeLook.CreateRigDelegate`
- `CinemachineFreeLook.DestroyRigDelegate`
- `CinemachineFreeLook.Orbit`
- `CinemachineGroupComposer.AdjustmentMode`
- `CinemachineGroupComposer.FramingMode`
- `CinemachineImpulseDefinition.RepeatMode`
- `CinemachineImpulseDefinition.SignalSource`
- `CinemachineImpulseManager.EnvelopeDefinition`
- `CinemachineImpulseManager.ImpulseEvent`
- `CinemachineImpulseManager.ImpulseEvent.DirectionMode`
- `CinemachineImpulseManager.ImpulseEvent.DissipationMode`
- `CinemachineMixer`
- `CinemachineMixer.ClipInfo`
- `CinemachineOrbitalTransposer.<>c` (compiler-generated name)
- `CinemachineOrbitalTransposer.Heading`
- `CinemachineOrbitalTransposer.Heading.HeadingDefinition`
- `CinemachineOrbitalTransposer.UpdateHeadingDelegate`
- `CinemachinePOV.RecenterTargetMode`
- `CinemachinePath.Waypoint`
- `CinemachinePathBase.Appearance`
- `CinemachinePathBase.PositionUnits`
- `CinemachineRecomposer`
- `CinemachineShot`
- `CinemachineShotPlayable`
- `CinemachineSmoothPath.Waypoint`
- `CinemachineStateDrivenCamera.HashPair`
- `CinemachineStateDrivenCamera.Instruction`
- `CinemachineStateDrivenCamera.ParentHash`
- `CinemachineStoryboard.CanvasInfo`
- `CinemachineStoryboard.FillStrategy`
- `CinemachineTargetGroup.PositionMode`
- `CinemachineTargetGroup.RotationMode`
- `CinemachineTargetGroup.Target`
- `CinemachineTargetGroup.UpdateMethod`
- `CinemachineTouchInputMapper`
- `CinemachineTrack`
- `CinemachineTrackedDolly.AutoDolly`
- `CinemachineTrackedDolly.CameraUpMode`
- `CinemachineTransposer.AngularDampingMode`
- `CinemachineTransposer.BindingMode`
- `CinemachineTriggerAction.ActionSettings`
- `CinemachineTriggerAction.ActionSettings.Mode`
- `CinemachineTriggerAction.ActionSettings.TimeMode`
- `CinemachineTriggerAction.ActionSettings.TriggerEvent`
- `CinemachineVirtualCamera.<>c` (compiler-generated name)
- `CinemachineVirtualCamera.CreatePipelineDelegate`
- `CinemachineVirtualCamera.DestroyPipelineDelegate`
- `CinemachineVirtualCameraBase.BlendHint`
- `CinemachineVirtualCameraBase.StandbyUpdateMode`
- `CinemachineVirtualCameraBase.TransitionParams`
- `CinemachineVolumeSettings.FocusTrackingMode`
- `CinemachineVolumeSettings.VcamExtraState`
- `DocumentationSortingAttribute.Level`
- `HeadingTracker.Item`
- `NoiseSettings.NoiseParams`
- `NoiseSettings.TransformNoiseParams`
- `TargetPositionCache.CacheCurve`
- `TargetPositionCache.CacheCurve.Item`
- `TargetPositionCache.CacheEntry`
- `TargetPositionCache.CacheEntry.RecordingItem`
- `TargetPositionCache.Mode`
- `TargetPositionCache.TimeRange`
- `UpdateTracker.UpdateClock`

</details>

<details><summary>Mismatching: 6</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32'] → ['1672DAC6F125FB6B44B941CC71B6FBC9027E5DB05924E0324F01177DB22A2EEC', '59D92CD2635C7D85611315808CE940B840E5185886C7B52B7A8EE273C0C5A542', 'AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32']`
  - `AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32: offset '0x0' → '0x2ea2'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5907 1672DAC6F125FB6B44B941CC71B6FBC9027E5DB05924E0324F01177DB22A2EEC`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6031 59D92CD2635C7D85611315808CE940B840E5185886C7B52B7A8EE273C0C5A542`

- `Cinemachine.CinemachineImpulseManager`

  - `field declaration order/names: ['sInstance', 'm_ExpiredEvents', 'm_ActiveEvents', '<IgnoreTimeScale>k__BackingField'] → ['sInstance', 'Epsilon', 'm_ExpiredEvents', 'm_ActiveEvents', '<IgnoreTimeScale>k__BackingField']`
  - `extra field constant float Epsilon`

- `Cinemachine.TargetPositionCache`

  - `field declaration order/names: ['<UseCache>k__BackingField', 'kMaxResolution', '<Resolution>k__BackingField', 'm_CacheMode', '<CurrentTime>k__BackingField', 'm_Cache', 'm_CacheTimeRange'] → ['<UseCache>k__BackingField', 'kMaxResolution', '<Resolution>k__BackingField', 'm_CacheMode', '<CurrentTime>k__BackingField', 'm_Cache', 'm_CacheTimeRange', 'kWraparoundSlush']`
  - `extra field constant float kWraparoundSlush`

- `Cinemachine.Utility.Damper`

  - `field declaration order/names: [] → ['Epsilon', 'kNegligibleResidual', 'kLogNegligibleResidual']`
  - `extra field constant float Epsilon`
  - `extra field constant float kNegligibleResidual`
  - `extra field constant float kLogNegligibleResidual`

- `Cinemachine.Utility.UnityVectorExtensions`

  - `field declaration order/names: [] → ['Epsilon']`
  - `extra field constant float Epsilon`

- `UpdateTracker.UpdateStatus`

  - `field declaration order/names: ['windowStart', 'numWindowLateUpdateMoves', 'numWindowFixedUpdateMoves', 'numWindows', 'lastFrameUpdated', 'lastPos', '<PreferredUpdate>k__BackingField'] → ['kWindowSize', 'windowStart', 'numWindowLateUpdateMoves', 'numWindowFixedUpdateMoves', 'numWindows', 'lastFrameUpdated', 'lastPos', '<PreferredUpdate>k__BackingField']`
  - `extra field constant int kWindowSize`


</details>

<details><summary>Extra: 11</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5907`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6031`
- `Cinemachine.AxisBase`
- `Cinemachine.CinemachineInputAxisDriver`
- `Cinemachine.Utility.GaussianWindow1D_CameraRotation`
- `Cinemachine.Utility.GaussianWindow1D_Quaternion`
- `Cinemachine.Utility.GaussianWindow1D_Vector3`
- `Cinemachine.Utility.GaussianWindow1d<T>`
- `Cinemachine.Utility.UnityRectExtensions`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## CriMw.CriWare.Runtime.dll

<details><summary>Matching: 310</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=8927`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=9873`
- `AutoResisterRendererResourceFactories.RendererResourceFactoryAndroidH264Rgb`
- `AutoResisterRendererResourceFactories.RendererResourceFactoryAndroidSofdecPrimeYuv`
- `AutoResisterRendererResourceFactories.RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2`
- `AutoResisterRendererResourceFactories.RendererResourceFactorySofdecPrimeYuvRawData`
- `Common.CpuUsage`
- `CriAtom.NativeMethods`
- `CriAtomConfig.AndroidLowLatencyStandardVoicePoolConfig`
- `CriAtomConfig.EditorPcmOutputConfig`
- `CriAtomConfig.HcaMxVoicePoolConfig`
- `CriAtomConfig.InGamePreviewConfig`
- `CriAtomConfig.InGamePreviewSwitchMode`
- `CriAtomConfig.LinuxOutput`
- `CriAtomConfig.Ps4Atrac9VoicePoolConfig`
- `CriAtomConfig.Ps4Audio3dConfig`
- `CriAtomConfig.Ps4Audio3dConfig.VoicePoolConfig`
- `CriAtomConfig.Ps5PortConfig`
- `CriAtomConfig.StandardVoicePoolConfig`
- `CriAtomConfig.Switch2OpusVoicePoolConfig`
- `CriAtomConfig.SwitchOpusVoicePoolConfig`
- `CriAtomConfig.VitaAtrac9VoicePoolConfig`
- `CriAtomConfig.VitaManaVoicePoolConfig`
- `CriAtomEx.AisacControlInfo`
- `CriAtomEx.AisacInfo`
- `CriAtomEx.BiquadFilterType`
- `CriAtomEx.CharacterEncoding`
- `CriAtomEx.CueLinkCbFunc`
- `CriAtomEx.CueLinkInfo`
- `CriAtomEx.CuePos3dInfo`
- `CriAtomEx.CueType`
- `CriAtomEx.CurveType`
- `CriAtomEx.FormatInfo`
- `CriAtomEx.GameVariableInfo`
- `CriAtomEx.NativeVector`
- `CriAtomEx.PanType`
- `CriAtomEx.Parameter`
- `CriAtomEx.PerformanceInfo`
- `CriAtomEx.Randomize3dCalcType`
- `CriAtomEx.Randomize3dParamType`
- `CriAtomEx.ResourceUsage`
- `CriAtomEx.ResumeMode`
- `CriAtomEx.SilentMode`
- `CriAtomEx.SoundRendererType`
- `CriAtomEx.Speaker`
- `CriAtomEx.SpeakerAngles6ch`
- `CriAtomEx.SpeakerAngles8ch`
- `CriAtomEx.SpeakerSystem`
- `CriAtomEx.VoiceAllocationMethod`
- `CriAtomEx.VoiceControlMethod`
- `CriAtomEx.WaveformInfo`
- `CriAtomEx3dListener.Config`
- `CriAtomEx3dRegion.Config`
- `CriAtomEx3dRegion.UnsafeNativeMethods`
- `CriAtomEx3dSource.Config`
- `CriAtomEx3dTransceiver.Config`
- `CriAtomEx3dTransceiver.UnsafeNativeMethods`
- `CriAtomExAcbDebug.AcbInfo`
- `CriAtomExAcbDebug.AcbInfoForMarshaling`
- `CriAtomExAcbLoader.LoaderConfig`
- `CriAtomExAcbLoader.Status`
- `CriAtomExAcf.AcfAisacType`
- `CriAtomExAcf.AcfDspBusInfo`
- `CriAtomExAcf.AcfDspBusLinkInfo`
- `CriAtomExAcf.AcfDspBusLinkType`
- `CriAtomExAcf.AcfDspSettingInfo`
- `CriAtomExAcf.AcfDspSettingSnapshotInfo`
- `CriAtomExAcf.AcfInfo`
- `CriAtomExAcf.AisacGraphInfo`
- `CriAtomExAcf.AisacGraphType`
- `CriAtomExAcf.CategoryInfo`
- `CriAtomExAcf.CharacterEncoding`
- `CriAtomExAcf.DspBusOutputType`
- `CriAtomExAcf.GlobalAisacInfo`
- `CriAtomExAcf.SelectorInfo`
- `CriAtomExAcf.SelectorLabelInfo`
- `CriAtomExAcfDebug.AisacControlInfo`
- `CriAtomExAcfDebug.AisacControlInfoForMarshaling`
- `CriAtomExAcfDebug.AisacType`
- `CriAtomExAcfDebug.CategoryInfo`
- `CriAtomExAcfDebug.CategoryInfoForMarshaling`
- `CriAtomExAcfDebug.DspBusInfo`
- `CriAtomExAcfDebug.DspBusInfoForMarshaling`
- `CriAtomExAcfDebug.GlobalAisacInfo`
- `CriAtomExAcfDebug.GlobalAisacInfoForMarshaling`
- `CriAtomExAcfDebug.SelectorInfo`
- `CriAtomExAcfDebug.SelectorInfoForMarshaling`
- `CriAtomExAcfDebug.SelectorLabelInfo`
- `CriAtomExAcfDebug.SelectorLabelInfoForMarshaling`
- `CriAtomExAsr.BusAnalyzerConfig`
- `CriAtomExAsr.BusAnalyzerInfo`
- `CriAtomExAsrRack.Config`
- `CriAtomExAsrRack.IPlatformConfig`
- `CriAtomExAsrRack.NativeMethods`
- `CriAtomExAsrRack.PerformanceInfo`
- `CriAtomExAsrRack.PlatformConfig`
- `CriAtomExAsrRack.PlatformConfigAndroid`
- `CriAtomExAsrRack.StreamType`
- `CriAtomExAuxIn.Config`
- `CriAtomExBeatSync.CbFunc`
- `CriAtomExBeatSync.Info`
- `CriAtomExCategory.ReactAisacModulationParameter`
- `CriAtomExCategory.ReactDuckerCurveType`
- `CriAtomExCategory.ReactDuckerParameter`
- `CriAtomExCategory.ReactDuckerParameter.AisacControl`
- `CriAtomExCategory.ReactDuckerParameter.Target`
- `CriAtomExCategory.ReactDuckerParameter.Volume`
- `CriAtomExCategory.ReactDuckerTargetType`
- `CriAtomExCategory.ReactFadeParameter`
- `CriAtomExCategory.ReactHoldType`
- `CriAtomExCategory.ReactParameter`
- `CriAtomExCategory.ReactParameter.Parameter`
- `CriAtomExCategory.ReactStatus`
- `CriAtomExCategory.ReactType`
- `CriAtomExDebug.ResourcesInfo`
- `CriAtomExLatencyEstimator.EstimatorInfo`
- `CriAtomExLatencyEstimator.Status`
- `CriAtomExMic.Config`
- `CriAtomExMic.DeviceInfo`
- `CriAtomExMic.Effect`
- `CriAtomExOutputAnalyzer.Config`
- `CriAtomExOutputAnalyzer.InternalPcmCaptureCallback`
- `CriAtomExOutputAnalyzer.PcmCaptureCallback`
- `CriAtomExOutputPort.Config`
- `CriAtomExOutputPort.NativeMethods`
- `CriAtomExOutputPort.Type`
- `CriAtomExPlayback.Status`
- `CriAtomExPlayback.TrackInfo`
- `CriAtomExPlayer.Config`
- `CriAtomExPlayer.PitchShifterParameterId`
- `CriAtomExPlayer.Status`
- `CriAtomExPlayer.TimeStretchParameterId`
- `CriAtomExPlayerOutputAnalyzer.Config`
- `CriAtomExPlayerOutputAnalyzer.Type`
- `CriAtomExRawPcmVoicePool.RawPcmFormat`
- `CriAtomExRawPcmVoicePool.RawPcmPlayerConfig`
- `CriAtomExRawPcmVoicePool.RawPcmVoicePoolConfig`
- `CriAtomExSequencer.CriAtomExSequenceEventInfo`
- `CriAtomExSequencer.EventCallback`
- `CriAtomExSequencer.EventCbFunc`
- `CriAtomExSoundObject.Config`
- `CriAtomExStandardVoicePool.Config`
- `CriAtomExTween.Config`
- `CriAtomExTween.Config.Target`
- `CriAtomExTween.ParameterType`
- `CriAtomExVoicePool.ExPitchShifterConfig`
- `CriAtomExVoicePool.ExTimeStretchConfig`
- `CriAtomExVoicePool.PitchShifterConfig`
- `CriAtomExVoicePool.PitchShifterMode`
- `CriAtomExVoicePool.PlayerConfig`
- `CriAtomExVoicePool.TimeStretchConfig`
- `CriAtomExVoicePool.UsedVoicesInfo`
- `CriAtomExVoicePool.VoicePoolId`
- `CriAtomExWaveVoicePool.Config`
- `CriAtomOutputDeviceObserver.<CoroutineForCheck_ANDROID>d__25` (compiler-generated name)
- `CriAtomOutputDeviceObserver.DeviceConnectionChangeCallback`
- `CriAtomOutputDeviceObserver.OutputDeviceType`
- `CriAtomOutputDeviceObserver.UnsafeNativeMethods`
- `CriAtomPlugin.CallbackFromNativeDelegate`
- `CriAtomPlugin.FileOpenCondition`
- `CriAtomSourceBase.Status`
- `CriAtomTimelinePreviewer.PlayerSource`
- `CriAtomTimelinePreviewer.PreviewListener`
- `CriAtomTransceiver.SetControlIdMethod`
- `CriAudioReadStream.<>c__DisplayClass12_0` (compiler-generated name)
- `CriAudioReadStream.Delegate`
- `CriAudioReadStream.InternalDelegate`
- `CriAudioWriteStream.<>c__DisplayClass12_0` (compiler-generated name)
- `CriAudioWriteStream.Delegate`
- `CriAudioWriteStream.InternalDelegate`
- `CriDisposableObjectManager.ModuleType`
- `CriDisposableObjectManager.ObjectRef`
- `CriErrorNotifier.Callback`
- `CriErrorNotifier.ErrorCallbackFunc`
- `CriErrorNotifier.NativeMethod`
- `CriFs.NativeMethods`
- `CriFsBindRequest.BindType`
- `CriFsBinder.ContentsFileInfo`
- `CriFsBinder.Status`
- `CriFsInstaller.CopyPolicy`
- `CriFsInstaller.Status`
- `CriFsLoadFileRequest.Phase`
- `CriFsLoader.Status`
- `CriFsRequest.<CheckDone>d__23` (compiler-generated name)
- `CriFsRequest.DoneDelegate`
- `CriFsWebInstaller.Error`
- `CriFsWebInstaller.ModuleConfig`
- `CriFsWebInstaller.ModulePlatformConfig`
- `CriFsWebInstaller.Status`
- `CriFsWebInstaller.StatusInfo`
- `CriManaClipBase.MovieInfoStruct`
- `CriManaConfig.PCH264PlaybackConfig`
- `CriManaConfig.VitaH264PlaybackConfig`
- `CriManaConfig.WebGLConfig`
- `CriManaMixerBehaviour.<ProcessFrameOnSeeking>d__27` (compiler-generated name)
- `CriManaMixerBehaviour.ClipState`
- `CriManaMixerBehaviour.MovieMixerState`
- `CriManaMovieMaterialBase.OnApplicationPauseCallback`
- `CriManaMovieMaterialBase.RenderMode`
- `CriWare.CriAtomCueSheet`
- `CriWare.CriAtomDebugDetail.Utility`
- `CriWare.CriAtomEx3dListener`
- `CriWare.CriAtomEx3dRegion`
- `CriWare.CriAtomEx3dSource`
- `CriWare.CriAtomEx3dTransceiver`
- `CriWare.CriAtomExAcb`
- `CriWare.CriAtomExAcbDebug`
- `CriWare.CriAtomExAcf`
- `CriWare.CriAtomExAcfDebug`
- `CriWare.CriAtomExAsr`
- `CriWare.CriAtomExAsrRack`
- `CriWare.CriAtomExAuxIn`
- `CriWare.CriAtomExBeatSync`
- `CriWare.CriAtomExCategory`
- `CriWare.CriAtomExDebug`
- `CriWare.CriAtomExLatencyEstimator`
- `CriWare.CriAtomExMic`
- `CriWare.CriAtomExOutputPort`
- `CriWare.CriAtomExPlaybackDebug`
- `CriWare.CriAtomExPlayerOutputAnalyzer`
- `CriWare.CriAtomExRawPcmVoicePool`
- `CriWare.CriAtomExSequencer`
- `CriWare.CriAtomExSoundObject`
- `CriWare.CriAtomExStandardVoicePool`
- `CriWare.CriAtomExTween`
- `CriWare.CriAtomExVoicePool`
- `CriWare.CriAtomExWaveVoicePool`
- `CriWare.CriAtomOutputDeviceObserver`
- `CriWare.CriAtomSource`
- `CriWare.CriAtomTransceiver`
- `CriWare.CriAudioReadStream`
- `CriWare.CriAudioWriteStream`
- `CriWare.CriDisposable`
- `CriWare.CriDisposableObjectManager`
- `CriWare.CriDurationMeasurementScope`
- `CriWare.CriErrorNotifier`
- `CriWare.CriFs`
- `CriWare.CriFsBindRequest`
- `CriWare.CriFsBinder`
- `CriWare.CriFsConfig`
- `CriWare.CriFsInstallRequest`
- `CriWare.CriFsInstallRequestLegacy`
- `CriWare.CriFsInstaller`
- `CriWare.CriFsLoadAssetBundleRequest`
- `CriWare.CriFsLoadFileRequest`
- `CriWare.CriFsLoader`
- `CriWare.CriFsPlugin`
- `CriWare.CriFsRequest`
- `CriWare.CriFsUtility`
- `CriWare.CriFsWebInstallRequest`
- `CriWare.CriFsWebInstaller`
- `CriWare.CriMana.AlphaType`
- `CriWare.CriMana.AudioInfo`
- `CriWare.CriMana.Detail.AutoResisterRendererResourceFactories`
- `CriWare.CriMana.Detail.RendererResource`
- `CriWare.CriMana.Detail.RendererResourceAndroidH264Rgb`
- `CriWare.CriMana.Detail.RendererResourceAndroidSofdecPrimeYuv`
- `CriWare.CriMana.Detail.RendererResourceAndroidSofdecPrimeYuvLegacyGles2`
- `CriWare.CriMana.Detail.RendererResourceFactory`
- `CriWare.CriMana.Detail.RendererResourceFactoryPriorityAttribute`
- `CriWare.CriMana.EventPoint`
- `CriWare.CriMana.FrameInfo`
- `CriWare.CriMana.MovieInfo`
- `CriWare.CriMana.Player`
- `CriWare.CriMana.Settings`
- `CriWare.CriManaAmbisonicSource`
- `CriWare.CriManaConfig`
- `CriWare.CriManaMoviePlayerHolder`
- `CriWare.CriMonoBehaviour`
- `CriWare.CriMonoBehaviourManager`
- `CriWare.CriTimeline.Atom.CriAtomBehaviour`
- `CriWare.CriTimeline.Atom.CriAtomClip`
- `CriWare.CriTimeline.Atom.CriAtomClipBase`
- `CriWare.CriTimeline.Atom.CriAtomClipPlayConfig`
- `CriWare.CriTimeline.Atom.CriAtomMixerBehaviour`
- `CriWare.CriTimeline.Atom.CriAtomTimelinePreviewer`
- `CriWare.CriTimeline.Atom.CriAtomTrack`
- `CriWare.CriTimeline.Mana.CriManaBehaviour`
- `CriWare.CriTimeline.Mana.CriManaClip`
- `CriWare.CriTimeline.Mana.CriManaClipBase`
- `CriWare.CriTimeline.Mana.CriManaMixerBehaviour`
- `CriWare.CriTimeline.Mana.CriManaTrack`
- `CriWare.CriWareDecrypter`
- `CriWare.CriWareInitializer`
- `CriWare.CriWareMemoryReporter`
- `CriWare.CriWareProfilerReporter`
- `CriWareDecrypter.CallbackFromNativeDelegate`
- `CriWareDecrypter.Config`
- `CriWareErrorHandler.Callback`
- `CriWareErrorHandler.NativeMethod`
- `CriWareProfilerReporter.<>c` (compiler-generated name)
- `CriWareProfilerReporter.TargetReporterName`
- `Player.AudioTrack`
- `Player.CriManaUnityPlayer_RenderEventAction`
- `Player.CuePointCallback`
- `Player.CuePointCallbackFromNativeDelegate`
- `Player.MovieEventSyncMode`
- `Player.SetMode`
- `Player.ShaderDispatchCallback`
- `Player.Status`
- `Player.StatusChangeCallback`
- `Player.SubtitleCallbackFromNativeDelegate`
- `Player.SubtitleChangeCallback`
- `Player.TimerType`
- `RendererResourceAndroidH264Rgb.NativeTexture`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>

<details><summary>Mismatching: 28</summary>

- `CriAtom.SpeakerMapping`

  - `field declaration order/names: ['value__', 'Auto', 'Monaural', 'Stereo', 'Ch5_1', 'Ch7_1', 'Ch5_1_2', 'Ch7_1_2', 'Ch7_1_4', 'Ch7_1_4_4', 'Ambisonics1p', 'Ambisonics2p', 'Ambisonics3p', 'Object', 'Custom'] → ['value__', 'Auto', 'Monaural', 'Stereo', 'Ch5_1', 'Ch7_1', 'Ch5_1_2', 'Ch7_1_2', 'Ch7_1_4', 'Ambisonics1p']`
  - `missing field constant CriAtom.SpeakerMapping Ch7_1_4_4`
  - `missing field constant CriAtom.SpeakerMapping Ambisonics2p`
  - `missing field constant CriAtom.SpeakerMapping Ambisonics3p`
  - `missing field constant CriAtom.SpeakerMapping Object`
  - `missing field constant CriAtom.SpeakerMapping Custom`

- `CriAtomEx.CueInfo`

  - `field declaration order/names: ['id', 'type', 'name', 'userData', 'length', 'categories', 'numLimits', 'numBlocks', 'numTracks', 'numRelatedWaveForms', 'priority', 'headerVisibility', 'ignore_player_parameter', 'probability', 'panType', 'pos3dInfo', 'gameVariableInfo', 'volume', 'silentMode', 'pitch', 'selectorIndex'] → ['id', 'type', 'name', 'userData', 'length', 'categories', 'numLimits', 'numBlocks', 'numTracks', 'numRelatedWaveForms', 'priority', 'headerVisibility', 'ignore_player_parameter', 'probability', 'panType', 'pos3dInfo', 'gameVariableInfo', 'volume', 'silentMode']`
  - `missing field instance float pitch`
  - `missing field instance ushort selectorIndex`

- `CriAtomEx.Format`

  - `field declaration order/names: ['value__', 'ADX', 'HCA', 'HCA_MX', 'WAVE', 'RAW_PCM', 'AUDIO_BUFFER', 'HW1', 'HW2', 'HW3', 'MP3'] → ['value__', 'ADX', 'HCA', 'HCA_MX', 'WAVE', 'RAW_PCM', 'AUDIO_BUFFER']`
  - `missing field constant CriAtomEx.Format HW1`
  - `missing field constant CriAtomEx.Format HW2`
  - `missing field constant CriAtomEx.Format HW3`
  - `missing field constant CriAtomEx.Format MP3`

- `CriAtomEx.Randomize3dConfig`

  - `field declaration order/names: ['NumOfCalcParams', 'followsOriginalSource', 'calculationType', 'calculationParameters'] → ['followsOriginalSource', 'calculationType', 'calculationParameters', 'NumOfCalcParams']`

- `CriManaMovieMaterialBase.MaxFrameDrop`

  - `field declaration order/names: ['value__', 'Disabled', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten'] → ['value__', 'Disabled', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten', 'Infinite']`
  - `extra field constant CriManaMovieMaterialBase.MaxFrameDrop Infinite`

- `CriWare.Common`

  - `field declaration order/names: ['scriptVersionString', 'supportsCriFsInstaller', 'supportsCriFsWebInstaller', 'pluginName', 'pluginCallingConvention', 'engineName', '_managerObject'] → ['engineName', 'scriptVersionString', 'supportsCriFsInstaller', 'supportsCriFsWebInstaller', 'pluginName', 'pluginCallingConvention', '_managerObject']`

- `CriWare.CriAtom`

  - `field declaration order/names: ['acfFile', 'acfIsLoading', 'cueSheets', 'dspBusSetting', 'dontDestroyOnLoad', 'eventUserCallback', 'eventUserCbFunc', 'beatsyncUserCbFunc', 'obsoleteBeatSyncFunc', 'cueLinkUserCbFunc', '<instance>k__BackingField', 'acfRegisterGCHandle', 'dontRemoveExistsCueSheet'] → ['acfFile', 'acfIsLoading', 'cueSheets', 'dspBusSetting', 'dontDestroyOnLoad', 'eventUserCallback', 'eventUserCbFunc', 'beatsyncUserCbFunc', 'obsoleteBeatSyncFunc', 'cueLinkUserCbFunc', 'acfRegisterGCHandle', 'dontRemoveExistsCueSheet', '<instance>k__BackingField']`
  - `eventUserCallback: type 'CriAtomExSequencer.EventCallback' → 'Delegate'`
  - `eventUserCbFunc: type 'CriAtomExSequencer.EventCbFunc' → 'Delegate'`
  - `beatsyncUserCbFunc: type 'CriAtomExBeatSync.CbFunc' → 'Delegate'`
  - `obsoleteBeatSyncFunc: type 'CriAtomExBeatSync.CbFunc' → 'Delegate'`
  - `cueLinkUserCbFunc: type 'CriAtomEx.CueLinkCbFunc' → 'Delegate'`

- `CriWare.CriAtomConfig`

  - `field declaration order/names: ['acfFileName', 'maxVirtualVoices', 'maxVoiceLimitGroups', 'maxCategories', 'maxAisacs', 'maxBusSends', 'maxSequenceEventsPerFrame', 'maxBeatSyncCallbacksPerFrame', 'maxCueLinkCallbacksPerFrame', 'standardVoicePoolConfig', 'hcaMxVoicePoolConfig', 'outputSamplingRate', 'usesInGamePreview', 'inGamePreviewMode', 'switchInitializeSocket', 'switch2InitializeSocket', 'inGamePreviewConfig', 'serverFrequency', 'speakerMapping', 'asrOutputChannels', 'useRandomSeedWithTime', 'categoriesPerPlayback', 'maxFaders', 'maxBuses', 'maxPitch', 'maxParameterBlocks', 'soundRendererType', 'keepPlayingSoundOnPause', 'enableSonicSync', 'enableAtomSoundDisabledMode', 'enableAtomSoundDisabledModeLinux', 'editorPcmOutputConfig', 'pcBufferingTime', 'useMicrosoftSpatialSound', 'linuxOutput', 'linuxPulseLatencyUsec', 'iosEnableSonicSync', 'iosBufferingTime', 'iosOverrideIPodMusic', 'iosEnableOSNotificationHandling', 'androidEnableSonicSync', 'androidBufferingTime', 'androidStartBufferingTime', 'androidLowLatencyStandardVoicePoolConfig', 'androidUsesAndroidFastMixer', 'androidForceToUseAsrForDefaultPlayback', 'androidUsesAAudio', 'androidStreamType', 'vitaManaVoicePoolConfig', 'vitaAtrac9VoicePoolConfig', 'ps4Atrac9VoicePoolConfig', 'ps5PortConfig', 'ps5Mp3StreamingVoices', 'switchEnableSonicSync', 'switchOpusVoicePoolConfig', 'switch2OpusVoicePoolConfig', 'ps4Audio3dConfig', 'ps4Mp3StreamingVoices'] → ['switch2InitializeSocket', 'enableAtomSoundDisabledMode', 'enableAtomSoundDisabledModeLinux', 'iosEnableOSNotificationHandling', 'ps5Mp3StreamingVoices', 'switch2OpusVoicePoolConfig', 'ps4Mp3StreamingVoices', 'acfFileName', 'maxVirtualVoices', 'maxVoiceLimitGroups', 'maxCategories', 'maxAisacs', 'maxBusSends', 'maxSequenceEventsPerFrame', 'maxBeatSyncCallbacksPerFrame', 'maxCueLinkCallbacksPerFrame', 'standardVoicePoolConfig', 'hcaMxVoicePoolConfig', 'outputSamplingRate', 'usesInGamePreview', 'inGamePreviewMode', 'switchInitializeSocket', 'inGamePreviewConfig', 'serverFrequency', 'speakerMapping', 'asrOutputChannels', 'useRandomSeedWithTime', 'categoriesPerPlayback', 'maxFaders', 'maxBuses', 'maxPitch', 'maxParameterBlocks', 'soundRendererType', 'keepPlayingSoundOnPause', 'enableSonicSync', 'editorPcmOutputConfig', 'pcBufferingTime', 'useMicrosoftSpatialSound', 'linuxOutput', 'linuxPulseLatencyUsec', 'iosEnableSonicSync', 'iosBufferingTime', 'iosOverrideIPodMusic', 'androidEnableSonicSync', 'androidBufferingTime', 'androidStartBufferingTime', 'androidLowLatencyStandardVoicePoolConfig', 'androidUsesAndroidFastMixer', 'androidForceToUseAsrForDefaultPlayback', 'androidUsesAAudio', 'androidStreamType', 'vitaManaVoicePoolConfig', 'vitaAtrac9VoicePoolConfig', 'ps4Atrac9VoicePoolConfig', 'ps5PortConfig', 'switchEnableSonicSync', 'switchOpusVoicePoolConfig', 'ps4Audio3dConfig', 'webglWebAudioVoicePoolConfig']`
  - `acfFileName: offset '0x10' → '0x28'`
  - `maxVirtualVoices: offset '0x18' → '0x30'`
  - `maxVoiceLimitGroups: offset '0x1c' → '0x34'`
  - `maxCategories: offset '0x20' → '0x38'`
  - `maxAisacs: offset '0x24' → '0x3c'`
  - `maxBusSends: offset '0x28' → '0x40'`
  - `maxSequenceEventsPerFrame: offset '0x2c' → '0x44'`
  - `maxBeatSyncCallbacksPerFrame: offset '0x30' → '0x48'`
  - `maxCueLinkCallbacksPerFrame: offset '0x34' → '0x4c'`
  - `standardVoicePoolConfig: offset '0x38' → '0x50'`
  - `hcaMxVoicePoolConfig: offset '0x40' → '0x58'`
  - `outputSamplingRate: offset '0x48' → '0x60'`
  - `usesInGamePreview: offset '0x4c' → '0x64'`
  - `inGamePreviewMode: offset '0x50' → '0x68'`
  - `switchInitializeSocket: offset '0x54' → '0x6c'`
  - `switch2InitializeSocket: offset '0x55' → '0x10'`
  - `inGamePreviewConfig: offset '0x58' → '0x70'`
  - `serverFrequency: offset '0x60' → '0x78'`
  - `speakerMapping: offset '0x64' → '0x7c'`
  - `asrOutputChannels: offset '0x68' → '0x80'`
  - `useRandomSeedWithTime: offset '0x6c' → '0x84'`
  - `categoriesPerPlayback: offset '0x70' → '0x88'`
  - `maxFaders: offset '0x74' → '0x8c'`
  - `maxBuses: offset '0x78' → '0x90'`
  - `maxPitch: offset '0x7c' → '0x94'`
  - `maxParameterBlocks: offset '0x80' → '0x98'`
  - `soundRendererType: offset '0x84' → '0x9c'`
  - `keepPlayingSoundOnPause: offset '0x88' → '0xa0'`
  - `enableSonicSync: offset '0x89' → '0xa1'`
  - `enableAtomSoundDisabledMode: offset '0x8a' → '0x11'`
  - `enableAtomSoundDisabledModeLinux: offset '0x8b' → '0x12'`
  - `editorPcmOutputConfig: offset '0x90' → '0xa8'`
  - `pcBufferingTime: offset '0x98' → '0xb0'`
  - `useMicrosoftSpatialSound: offset '0x9c' → '0xb4'`
  - `linuxOutput: offset '0xa0' → '0xb8'`
  - `linuxPulseLatencyUsec: offset '0xa4' → '0xbc'`
  - `iosEnableSonicSync: offset '0xa8' → '0xc0'`
  - `iosBufferingTime: offset '0xac' → '0xc4'`
  - `iosOverrideIPodMusic: offset '0xb0' → '0xc8'`
  - `iosEnableOSNotificationHandling: offset '0xb1' → '0x13'`
  - `androidEnableSonicSync: offset '0xb2' → '0xc9'`
  - `androidBufferingTime: offset '0xb4' → '0xcc'`
  - `androidStartBufferingTime: offset '0xb8' → '0xd0'`
  - `androidLowLatencyStandardVoicePoolConfig: offset '0xc0' → '0xd8'`
  - `androidUsesAndroidFastMixer: offset '0xc8' → '0xe0'`
  - `androidForceToUseAsrForDefaultPlayback: offset '0xc9' → '0xe1'`
  - `androidUsesAAudio: offset '0xca' → '0xe2'`
  - `androidStreamType: offset '0xcc' → '0xe4'`
  - `vitaManaVoicePoolConfig: offset '0xd0' → '0xe8'`
  - `vitaAtrac9VoicePoolConfig: offset '0xd8' → '0xf0'`
  - `ps4Atrac9VoicePoolConfig: offset '0xe0' → '0xf8'`
  - `ps5PortConfig: offset '0xe8' → '0x100'`
  - `ps5Mp3StreamingVoices: offset '0xf0' → '0x14'`
  - `switchEnableSonicSync: offset '0xf4' → '0x108'`
  - `switchOpusVoicePoolConfig: offset '0xf8' → '0x110'`
  - `switch2OpusVoicePoolConfig: offset '0x100' → '0x18'`
  - `ps4Audio3dConfig: offset '0x108' → '0x118'`
  - `ps4Mp3StreamingVoices: offset '0x110' → '0x20'`
  - `extra field instance CriAtomConfig.WebGLWebAudioVoicePoolConfig webglWebAudioVoicePoolConfig`

- `CriWare.CriAtomEx`

  - `field declaration order/names: ['InvalidAisacControlId', 'randomize3dParamTable', 'androidDefaultSoundRendererType'] → ['InvalidAisacControlId', 'androidDefaultSoundRendererType']`
  - `missing field static Dictionary<CriAtomEx.Randomize3dCalcType, CriAtomEx.Randomize3dParamType[]> randomize3dParamTable`
  - `androidDefaultSoundRendererType: offset '0x8' → '0x0'`

- `CriWare.CriAtomExAcbLoader`

  - `bases: 'CriDisposable' → ''`
  - `handle: offset '0x20' → '0x10'`
  - `gch: offset '0x28' → '0x18'`

- `CriWare.CriAtomExOutputAnalyzer`

  - `field declaration order/names: ['MaximumSpectrumBands', 'handle', 'player', 'busName', 'numBands', 'numCapturedPcmSamples', 'userPcmCaptureCallback', 'dataL', 'dataR', 'pcmCapturerNumMaxData', 'InternalCallbackFunctionPointer', 'DelegateObject', 'DataL', 'DataR', 'UserPcmCaptureCallback'] → ['userPcmCaptureCallback', 'InternalCallbackFunctionPointer', 'DelegateObject', 'DataL', 'DataR', 'UserPcmCaptureCallback', 'MaximumSpectrumBands', 'handle', 'player', 'busName', 'numBands', 'numCapturedPcmSamples', 'dataL', 'dataR', 'pcmCapturerNumMaxData']`
  - `handle: offset '0x20' → '0x28'`
  - `player: offset '0x28' → '0x30'`
  - `busName: offset '0x30' → '0x38'`
  - `numBands: offset '0x38' → '0x40'`
  - `numCapturedPcmSamples: offset '0x3c' → '0x44'`
  - `userPcmCaptureCallback: offset '0x40' → '0x20'`

- `CriWare.CriAtomExPlayback`

  - `field declaration order/names: ['<id>k__BackingField', 'invalidId'] → ['invalidId', '<id>k__BackingField']`

- `CriWare.CriAtomExPlayer`

  - `_onBeatSyncCallback: type 'CriAtomExBeatSync.CbFunc' → 'Delegate'`
  - `_onSequenceCallback: type 'CriAtomExSequencer.EventCallback' → 'Delegate'`

- `CriWare.CriAtomListener`

  - `field declaration order/names: ['<nativeListener>k__BackingField', 'regionOnStart', 'activateListenerOnEnable', 'listenersList', 'exclusiveListener', 'dummyNativeListener', 'lastPosition', 'currentRegion', '_isActive'] → ['regionOnStart', 'activateListenerOnEnable', 'listenersList', 'exclusiveListener', 'dummyNativeListener', 'lastPosition', 'currentRegion', '_isActive', '<nativeListener>k__BackingField']`
  - `<nativeListener>k__BackingField: offset '0x30' → '0x58'`
  - `regionOnStart: offset '0x38' → '0x30'`
  - `activateListenerOnEnable: offset '0x40' → '0x38'`
  - `lastPosition: offset '0x44' → '0x3c'`
  - `currentRegion: offset '0x50' → '0x48'`
  - `_isActive: offset '0x58' → '0x50'`

- `CriWare.CriAtomPlugin`

  - `field declaration order/names: ['initializationCount', 'OnBeforeInitialize', 'OnInitialized', 'OnBeforeFinalize', 'OnFinalized', 'effectInterfaceList', 'isConfigured', 'timeSinceStartup', 'cpuUsage', 'CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT', 'CRIATOMPARAMETER2_ID_INVALID', 'temporalStorage'] → ['cpuUsage', 'temporalStorage', 'OnBeforeInitialize', 'OnInitialized', 'OnBeforeFinalize', 'initializationCount', 'OnFinalized', 'effectInterfaceList', 'isConfigured', 'timeSinceStartup', 'CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT', 'CRIATOMPARAMETER2_ID_INVALID']`
  - `initializationCount: offset '0x0' → '0x30'`
  - `OnBeforeInitialize: offset '0x8' → '0x18'`
  - `OnInitialized: offset '0x10' → '0x20'`
  - `OnBeforeFinalize: offset '0x18' → '0x28'`
  - `OnFinalized: offset '0x20' → '0x38'`
  - `effectInterfaceList: offset '0x28' → '0x40'`
  - `isConfigured: offset '0x30' → '0x48'`
  - `timeSinceStartup: offset '0x34' → '0x4c'`
  - `cpuUsage: offset '0x38' → '0x0'`
  - `CRIATOMUNITY_PARAMETER_ID_LOOP_COUNT: offset '0x44' → '0x50'`
  - `CRIATOMPARAMETER2_ID_INVALID: offset '0x48' → '0x54'`
  - `temporalStorage: offset '0x50' → '0x10'`

- `CriWare.CriAtomRegion`

  - `field declaration order/names: ['<region3dHn>k__BackingField', 'referringSources', 'referringListeners', 'referringTransceivers'] → ['referringTransceivers', '<region3dHn>k__BackingField', 'referringSources', 'referringListeners']`
  - `<region3dHn>k__BackingField: offset '0x30' → '0x38'`
  - `referringSources: offset '0x38' → '0x40'`
  - `referringListeners: offset '0x40' → '0x48'`
  - `referringTransceivers: offset '0x48' → '0x30'`

- `CriWare.CriAtomServer`

  - `field declaration order/names: ['_instance', 'profilerReporterInstance', 'onApplicationPausePreProcess', 'onApplicationPausePostProcess', 'KeepPlayingSoundOnPause', 'EnableAutoConsumePcmOutput', 'EnableBackgroundPlayback_ANDROID'] → ['profilerReporterInstance', 'EnableBackgroundPlayback_ANDROID', '_instance', 'onApplicationPausePreProcess', 'onApplicationPausePostProcess', 'KeepPlayingSoundOnPause', 'EnableAutoConsumePcmOutput']`
  - `_instance: offset '0x0' → '0x10'`
  - `profilerReporterInstance: offset '0x8' → '0x0'`
  - `KeepPlayingSoundOnPause: offset '0x10' → '0x18'`
  - `EnableAutoConsumePcmOutput: offset '0x11' → '0x19'`
  - `EnableBackgroundPlayback_ANDROID: offset '0x12' → '0x8'`

- `CriWare.CriAtomSourceBase`

  - `field declaration order/names: ['<player>k__BackingField', '<source>k__BackingField', 'initialized', 'lastPosition', 'hasValidPosition', 'currentRegion', 'currentListener', '_playOnStart', '_regionOnStart', '_listenerOnStart', '_use3dPositioning', '_freezeOrientation', '_loop', '_volume', '_pitch', '_androidUseLowLatencyVoicePool', 'need_to_player_update_all', '_use3dRandomization', '_randomPositionListMaxLength', 'randomize3dConfig'] → ['initialized', 'lastPosition', 'hasValidPosition', 'currentRegion', 'currentListener', '_playOnStart', '_regionOnStart', '_listenerOnStart', '_use3dPositioning', '_freezeOrientation', '_loop', '_volume', '_pitch', '_androidUseLowLatencyVoicePool', 'need_to_player_update_all', '_use3dRandomization', '_randomPositionListMaxLength', 'randomize3dConfig', '<player>k__BackingField', '<source>k__BackingField']`
  - `<player>k__BackingField: offset '0x30' → '0x98'`
  - `<source>k__BackingField: offset '0x38' → '0xa0'`
  - `initialized: offset '0x40' → '0x30'`
  - `lastPosition: offset '0x44' → '0x34'`
  - `hasValidPosition: offset '0x50' → '0x40'`
  - `currentRegion: offset '0x58' → '0x48'`
  - `currentListener: offset '0x60' → '0x50'`
  - `_playOnStart: offset '0x68' → '0x58'`
  - `_regionOnStart: offset '0x70' → '0x60'`
  - `_listenerOnStart: offset '0x78' → '0x68'`
  - `_use3dPositioning: offset '0x80' → '0x70'`
  - `_freezeOrientation: offset '0x81' → '0x71'`
  - `_loop: offset '0x82' → '0x72'`
  - `_volume: offset '0x84' → '0x74'`
  - `_pitch: offset '0x88' → '0x78'`
  - `_androidUseLowLatencyVoicePool: offset '0x8c' → '0x7c'`
  - `need_to_player_update_all: offset '0x8d' → '0x7d'`
  - `_use3dRandomization: offset '0x8e' → '0x7e'`
  - `_randomPositionListMaxLength: offset '0x90' → '0x80'`
  - `randomize3dConfig: offset '0x98' → '0x88'`

- `CriWare.CriFsServer`

  - `field declaration order/names: ['_instance', 'requestList', '<installBufferSize>k__BackingField'] → ['requestList', '_instance']`
  - `missing field instance int <installBufferSize>k__BackingField`

- `CriWare.CriMana.CodecType`

  - `field declaration order/names: ['value__', 'Unknown', 'SofdecPrime', 'H264', 'VP9', 'AV1'] → ['value__', 'Unknown', 'SofdecPrime', 'H264', 'VP9']`
  - `missing field constant CodecType AV1`

- `CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuvRawData`

  - `field declaration order/names: ['width', 'height', 'chromaWidth', 'chromaHeight', 'alphaWidth', 'alphaHeight', 'useUserShader', 'codecType', 'movieTextureST', 'movieChromaTextureST', 'movieAlphaTextureST', 'textures', 'currentTextureSet', 'drawTextureSet', 'nativePixels', 'playerID', 'hasTextureUpdated', 'isTextureReady', 'hasRenderedNewFrame'] → ['isTextureReady', 'width', 'height', 'chromaWidth', 'chromaHeight', 'alphaWidth', 'alphaHeight', 'useUserShader', 'codecType', 'movieTextureST', 'movieChromaTextureST', 'movieAlphaTextureST', 'textures', 'currentTextureSet', 'drawTextureSet', 'nativePixels', 'playerID', 'hasTextureUpdated', 'hasRenderedNewFrame', 'isStoppingForSeek']`
  - `width: offset '0x2c' → '0x30'`
  - `height: offset '0x30' → '0x34'`
  - `chromaWidth: offset '0x34' → '0x38'`
  - `chromaHeight: offset '0x38' → '0x3c'`
  - `alphaWidth: offset '0x3c' → '0x40'`
  - `alphaHeight: offset '0x40' → '0x44'`
  - `useUserShader: offset '0x44' → '0x48'`
  - `codecType: offset '0x48' → '0x4c'`
  - `movieTextureST: offset '0x4c' → '0x50'`
  - `movieChromaTextureST: offset '0x5c' → '0x60'`
  - `movieAlphaTextureST: offset '0x6c' → '0x70'`
  - `isTextureReady: offset '0x9d' → '0x2c'`
  - `hasRenderedNewFrame: offset '0x9e' → '0x9d'`
  - `extra field instance bool isStoppingForSeek`

- `CriWare.CriManaMovieController`

  - `target: offset '0xa0' → '0xa8'`
  - `useOriginalMaterial: offset '0xa8' → '0xb0'`
  - `originalMaterial: offset '0xb0' → '0xb8'`

- `CriWare.CriManaMovieControllerForUI`

  - `target: offset '0xa0' → '0xa8'`
  - `useOriginalMaterial: offset '0xa8' → '0xb0'`
  - `originalMaterial: offset '0xb0' → '0xb8'`

- `CriWare.CriManaMovieMaterial`

  - `_moviePath: offset '0x88' → '0x90'`
  - `_loop: offset '0x90' → '0x98'`
  - `_audioBaseConcatenation: offset '0x91' → '0x99'`
  - `_additiveMode: offset '0x92' → '0x9a'`
  - `_advancedAudio: offset '0x93' → '0x9b'`
  - `_ambisonics: offset '0x94' → '0x9c'`
  - `_applyTargetAlpha: offset '0x95' → '0x9d'`
  - `_uiRenderMode: offset '0x96' → '0x9e'`
  - `ambisonicSource: offset '0x98' → '0xa0'`

- `CriWare.CriManaMovieMaterialBase`

  - `field declaration order/names: ['playOnStart', 'restartOnEnable', '<isMaterialAvailable>k__BackingField', '<player>k__BackingField', 'renderMode', 'onApplicationPauseCallback', '_timerType', '_material', '_maxFrameDrop', 'materialOwn', 'isMonoBehaviourStartCalled', 'wasDisabled', 'wasPausedOnDisable', 'previousOnApplicationPauseStatus', 'frameEnd', 'unpauseOnApplicationUnpause', '<HaveRendererOwner>k__BackingField', 'playerHolder'] → ['playOnStart', 'restartOnEnable', 'renderMode', 'onApplicationPauseCallback', '_timerType', '_material', '_maxFrameDrop', 'materialOwn', 'isMonoBehaviourStartCalled', 'wasDisabled', 'wasPausedOnDisable', 'previousOnApplicationPauseStatus', 'frameEnd', 'unpauseOnApplicationUnpause', 'playerHolder', '<isMaterialAvailable>k__BackingField', '<player>k__BackingField', '<HaveRendererOwner>k__BackingField']`
  - `<isMaterialAvailable>k__BackingField: offset '0x32' → '0x78'`
  - `<player>k__BackingField: offset '0x38' → '0x80'`
  - `renderMode: offset '0x40' → '0x34'`
  - `onApplicationPauseCallback: offset '0x48' → '0x38'`
  - `_timerType: offset '0x50' → '0x40'`
  - `_material: offset '0x58' → '0x48'`
  - `_maxFrameDrop: offset '0x60' → '0x50'`
  - `materialOwn: offset '0x64' → '0x54'`
  - `isMonoBehaviourStartCalled: offset '0x65' → '0x55'`
  - `wasDisabled: offset '0x66' → '0x56'`
  - `wasPausedOnDisable: offset '0x67' → '0x57'`
  - `previousOnApplicationPauseStatus: offset '0x68' → '0x58'`
  - `frameEnd: offset '0x70' → '0x60'`
  - `unpauseOnApplicationUnpause: offset '0x78' → '0x68'`
  - `<HaveRendererOwner>k__BackingField: offset '0x79' → '0x88'`
  - `playerHolder: offset '0x80' → '0x70'`

- `CriWare.CriManaPlugin`

  - `field declaration order/names: ['initializationCount', 'isConfigured', 'enabledMultithreadedRendering', 'renderingEventOffset', 'OnBeforeInitialize', 'OnInitialized', 'OnBeforeFinalize', 'OnFinalized'] → ['OnBeforeInitialize', 'OnInitialized', 'OnBeforeFinalize', 'OnFinalized', 'initializationCount', 'isConfigured', 'enabledMultithreadedRendering', 'renderingEventOffset']`
  - `initializationCount: offset '0x0' → '0x20'`
  - `isConfigured: offset '0x4' → '0x24'`
  - `enabledMultithreadedRendering: offset '0x5' → '0x25'`
  - `renderingEventOffset: offset '0x8' → '0x28'`
  - `OnBeforeInitialize: offset '0x10' → '0x0'`
  - `OnInitialized: offset '0x18' → '0x8'`
  - `OnBeforeFinalize: offset '0x20' → '0x10'`
  - `OnFinalized: offset '0x28' → '0x18'`

- `CriWare.CriStructMemory<Type>`

  - `field declaration order/names: ['<bytes>k__BackingField', 'gch'] → ['gch', '<bytes>k__BackingField']`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CriWare.CriWareErrorHandler`

  - `field declaration order/names: ['enableDebugPrintOnTerminal', 'enableForceCrashOnError', 'dontDestroyOnLoad', '<errorMessage>k__BackingField', 'logPrefix', '_onCallback', 'callback', 'messageBufferCounts', 'unThreadSafeMessages', '_enableDebugPrintOnTerminal', 'initializationCount'] → ['_enableDebugPrintOnTerminal', 'enableDebugPrintOnTerminal', 'enableForceCrashOnError', 'dontDestroyOnLoad', 'logPrefix', '_onCallback', 'callback', 'messageBufferCounts', 'unThreadSafeMessages', 'initializationCount', '<errorMessage>k__BackingField']`
  - `<errorMessage>k__BackingField: offset '0x0' → '0x28'`
  - `_enableDebugPrintOnTerminal: offset '0x20' → '0x0'`
  - `initializationCount: offset '0x24' → '0x20'`


</details>

<details><summary>Missing: 6</summary>

- `CriAtom.<>c__DisplayClass68_0` (compiler-generated name)
- `CriAtom.<LoadAcbDataCoroutine>d__74` (compiler-generated name)
- `CriAtom.<LoadAcbFileCoroutine>d__72` (compiler-generated name)
- `CriAtomSource.<PlayAsync>d__11` (compiler-generated name)
- `CriManaMovieMaterialBase.<RestartPlayerRoutine>d__60` (compiler-generated name)
- `Player.<IssuePluginUpdatesForFrames>d__157` (compiler-generated name)

</details>

<details><summary>Extra: 131</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=1008`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=112`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=128`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=14422`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=15742`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=176`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=1792`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=36`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=48`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=512`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=544`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=64`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=640`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=66`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=68`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=96`
- `CriAtom.<>c__DisplayClass76_0` (compiler-generated name)
- `CriAtomAcbData.<>c` (compiler-generated name)
- `CriAtomAcbData.<>c__DisplayClass42_0` (compiler-generated name)
- `CriAtomAcbData.<ReadCommands>d__48` (compiler-generated name)
- `CriAtomAcbData.<SelectTracks>d__41` (compiler-generated name)
- `CriAtomAcbData.BiquadSetting`
- `CriAtomAcbData.BusSend`
- `CriAtomAcbData.Command`
- `CriAtomAcbData.Cue`
- `CriAtomAcbData.OffsetChoice`
- `CriAtomAcbData.ParameterLayer`
- `CriAtomAcbData.RandomState`
- `CriAtomAcbData.SelectionState`
- `CriAtomAcbData.WaveEvent`
- `CriAtomAcbData.Waveform`
- `CriAtomAfs2.<>c__DisplayClass18_0` (compiler-generated name)
- `CriAtomAfs2.Entry`
- `CriAtomCategoryState.<>c__DisplayClass26_0` (compiler-generated name)
- `CriAtomCategoryState.Category`
- `CriAtomCategoryState.CategoryConfig`
- `CriAtomCategoryState.LimitPool`
- `CriAtomCategoryState.React`
- `CriAtomCategoryState.ReactConfig`
- `CriAtomCategoryState.ReactPhase`
- `CriAtomCategoryState.Reservation`
- `CriAtomConfig.WebGLWebAudioVoicePoolConfig`
- `CriAtomDsp.Limiter`
- `CriAtomDsp.StereoMultiTap`
- `CriAtomDspI3dl2Reverb.SmoothDelay`
- `CriAtomDspMath.Biquad`
- `CriAtomDspMath.Complex`
- `CriAtomDspMath.Delay`
- `CriAtomDspReverb.Comb`
- `CriAtomFader.Command`
- `CriAtomFader.CommandKind`
- `CriAtomFader.Phase`
- `CriAtomLibm.Poly`
- `CriAtomMixer.<>c` (compiler-generated name)
- `CriAtomMixer.<>c__DisplayClass6_0` (compiler-generated name)
- `CriAtomMixer.<>c__DisplayClass6_1` (compiler-generated name)
- `CriAtomMixer.Bus`
- `CriAtomMixer.Link`
- `CriAtomNativeBackend.<>c` (compiler-generated name)
- `CriAtomNativeBackend.<>c__DisplayClass36_0` (compiler-generated name)
- `CriAtomNativeBackend.Aisac`
- `CriAtomNativeBackend.Analyzer`
- `CriAtomNativeBackend.AudioGroup`
- `CriAtomNativeBackend.Bank`
- `CriAtomNativeBackend.Binder`
- `CriAtomNativeBackend.Graph`
- `CriAtomNativeBackend.ManaAudioSource`
- `CriAtomNativeBackend.ManaEntry`
- `CriAtomNativeBackend.ManaFrame`
- `CriAtomNativeBackend.ManaPlayer`
- `CriAtomNativeBackend.Parameters`
- `CriAtomNativeBackend.Playback`
- `CriAtomNativeBackend.Player`
- `CriAtomNativeBackend.Spatial`
- `CriAtomNativeBackend.Voice`
- `CriAtomNativeBackend.Voice.PcmBlock`
- `CriAtomNativeBackend.Voice.SourceProgress`
- `CriAtomNativeBackend.VoiceFilter`
- `CriAtomNativeBackend.VoiceSlot`
- `CriAtomSource.<PlayAsync>d__10` (compiler-generated name)
- `CriAtomUtf.Column`
- `CriAtomUtf.Row`
- `CriAtomUtf.Table`
- `CriHcaDecoder`
- `CriHcaDecoderUnity`
- `CriHcaDecoderUnity.Handle`
- `CriHcaDecoderUnity.HcaDecoder`
- `CriHcaDecoderUnity.HcaDecoder.Channel`
- `CriHcaDecoderUnity.HcaDecoder.Config`
- `CriManaMovieMaterialBase.<RestartPlayerRoutine>d__61` (compiler-generated name)
- `CriManaMpeg1Decoder.Frame`
- `CriManaUsm.AudioInfo`
- `CriManaUsm.Packet`
- `CriManaUsm.SeekEntry`
- `CriManaUsm.VideoInfo`
- `CriWare.CriAtomAcbData`
- `CriWare.CriAtomAfs2`
- `CriWare.CriAtomAisacGraph`
- `CriWare.CriAtomAudioClock`
- `CriWare.CriAtomCategoryState`
- `CriWare.CriAtomDsp`
- `CriWare.CriAtomDspI3dl2Reverb`
- `CriWare.CriAtomDspMath`
- `CriWare.CriAtomDspReverb`
- `CriWare.CriAtomFader`
- `CriWare.CriAtomLevelMeter`
- `CriWare.CriAtomLibm`
- `CriWare.CriAtomMixer`
- `CriWare.CriAtomNativeBackend`
- `CriWare.CriAtomResampler`
- `CriWare.CriAtomSequenceClock`
- `CriWare.CriAtomUtf`
- `CriWare.CriMana.CriManaClock`
- `CriWare.CriMana.CriManaMpeg1Decoder`
- `CriWare.CriMana.Detail.RendererResourceIOSH264Yuv`
- `CriWare.CriMana.Detail.RendererResourcePlatform`
- `CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuv`
- `CriWare.CriManaAdxDecoder`
- `CriWare.CriManaAudioClock`
- `CriWare.CriManaUsm`
- `CriWare.CriWareNative`
- `CriWare.ICriWareNativeBackend`
- `HcaFileDecoder`
- `HcaFileDecoder.Metadata`
- `Player.<IssuePluginUpdatesForFrames>d__205` (compiler-generated name)

</details>


## DOTween.dll

<details><summary>Matching: 121</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=120`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=50`
- `DG.Tweening.AutoPlay`
- `DG.Tweening.AxisConstraint`
- `DG.Tweening.Color2`
- `DG.Tweening.Core.ABSSequentiable`
- `DG.Tweening.Core.DOGetter<T>`
- `DG.Tweening.Core.DOSetter<T>`
- `DG.Tweening.Core.DOTweenComponent`
- `DG.Tweening.Core.DOTweenExternalCommand`
- `DG.Tweening.Core.Easing.Bounce`
- `DG.Tweening.Core.Easing.EaseCurve`
- `DG.Tweening.Core.Easing.Flash`
- `DG.Tweening.Core.Enums.FilterType`
- `DG.Tweening.Core.Enums.NestedTweenFailureBehaviour`
- `DG.Tweening.Core.Enums.OperationType`
- `DG.Tweening.Core.Enums.RewindCallbackMode`
- `DG.Tweening.Core.Enums.SpecialStartupMode`
- `DG.Tweening.Core.Enums.UpdateMode`
- `DG.Tweening.Core.Enums.UpdateNotice`
- `DG.Tweening.Core.Extensions`
- `DG.Tweening.Core.SafeModeReport`
- `DG.Tweening.Core.SequenceCallback`
- `DG.Tweening.Core.TweenLink`
- `DG.Tweening.CustomPlugins.PureQuaternionPlugin`
- `DG.Tweening.DOVirtual`
- `DG.Tweening.Ease`
- `DG.Tweening.EaseFunction`
- `DG.Tweening.IDOTweenInit`
- `DG.Tweening.LinkBehaviour`
- `DG.Tweening.LogBehaviour`
- `DG.Tweening.LoopType`
- `DG.Tweening.PathMode`
- `DG.Tweening.PathType`
- `DG.Tweening.Plugins.Color2Plugin`
- `DG.Tweening.Plugins.ColorPlugin`
- `DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions>`
- `DG.Tweening.Plugins.Core.ITweenPlugin`
- `DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder`
- `DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder`
- `DG.Tweening.Plugins.Core.PathCore.ControlPoint`
- `DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder`
- `DG.Tweening.Plugins.Core.PathCore.LinearDecoder`
- `DG.Tweening.Plugins.Core.SpecialPluginsUtils`
- `DG.Tweening.Plugins.DoublePlugin`
- `DG.Tweening.Plugins.FloatPlugin`
- `DG.Tweening.Plugins.IntPlugin`
- `DG.Tweening.Plugins.LongPlugin`
- `DG.Tweening.Plugins.Options.ColorOptions`
- `DG.Tweening.Plugins.Options.FloatOptions`
- `DG.Tweening.Plugins.Options.IPlugOptions`
- `DG.Tweening.Plugins.Options.NoOptions`
- `DG.Tweening.Plugins.Options.OrientType`
- `DG.Tweening.Plugins.Options.RectOptions`
- `DG.Tweening.Plugins.Options.StringOptions`
- `DG.Tweening.Plugins.Options.UintOptions`
- `DG.Tweening.Plugins.Options.Vector3ArrayOptions`
- `DG.Tweening.Plugins.Options.VectorOptions`
- `DG.Tweening.Plugins.QuaternionPlugin`
- `DG.Tweening.Plugins.RectOffsetPlugin`
- `DG.Tweening.Plugins.RectPlugin`
- `DG.Tweening.Plugins.StringPlugin`
- `DG.Tweening.Plugins.StringPluginExtensions`
- `DG.Tweening.Plugins.UintPlugin`
- `DG.Tweening.Plugins.UlongPlugin`
- `DG.Tweening.Plugins.Vector2Plugin`
- `DG.Tweening.Plugins.Vector3ArrayPlugin`
- `DG.Tweening.Plugins.Vector3Plugin`
- `DG.Tweening.Plugins.Vector4Plugin`
- `DG.Tweening.RotateMode`
- `DG.Tweening.ScrambleMode`
- `DG.Tweening.Sequence`
- `DG.Tweening.ShortcutExtensions`
- `DG.Tweening.TweenCallback`
- `DG.Tweening.TweenCallback<T>`
- `DG.Tweening.TweenExtensions`
- `DG.Tweening.TweenSettingsExtensions`
- `DG.Tweening.TweenType`
- `DG.Tweening.Tweener`
- `DG.Tweening.UpdateType`
- `DOTweenComponent.<WaitForCompletion>d__17` (compiler-generated name)
- `DOTweenComponent.<WaitForElapsedLoops>d__20` (compiler-generated name)
- `DOTweenComponent.<WaitForKill>d__19` (compiler-generated name)
- `DOTweenComponent.<WaitForPosition>d__21` (compiler-generated name)
- `DOTweenComponent.<WaitForRewind>d__18` (compiler-generated name)
- `DOTweenComponent.<WaitForStart>d__22` (compiler-generated name)
- `DOTweenSettings.SettingsLocation`
- `DOVirtual.<>c__DisplayClass0_0` (compiler-generated name)
- `SafeModeReport.SafeModeReportType`
- `ShortcutExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass12_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass13_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass16_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass19_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass1_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass32_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass33_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass34_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass36_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass37_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass38_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass3_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass40_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass42_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass44_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass45_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass46_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass47_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass51_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass52_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass54_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass56_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass58_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass5_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass63_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass64_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass6_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass7_0` (compiler-generated name)
- `TweenManager.CapacityIncreaseMode`

</details>

<details><summary>Mismatching: 17</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663', '921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055', 'A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678', 'C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020'] → ['4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663', '921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055', '9262857CAD283202CA84B75E1CA9CC199A95E7D878F98BB9EAFB1E2F2AE67618', 'A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678', 'BEEF07BD55BBFB8B3AD6B8AAE4F8A07CF328AD0A16641540F61FC7F690990DF4', 'C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020']`
  - `A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678: offset '0x46' → '0xbf1'`
  - `C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020: offset '0xbe' → '0x1c99'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2987 9262857CAD283202CA84B75E1CA9CC199A95E7D878F98BB9EAFB1E2F2AE67618`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4144 BEEF07BD55BBFB8B3AD6B8AAE4F8A07CF328AD0A16641540F61FC7F690990DF4`

- `DG.Tweening.Core.DOTweenSettings`

  - `field declaration order/names: ['AssetName', 'AssetFullFilename', 'useSafeMode', 'safeModeOptions', 'timeScale', 'useSmoothDeltaTime', 'maxSmoothUnscaledTime', 'rewindCallbackMode', 'showUnityEditorReport', 'logBehaviour', 'drawGizmos', 'defaultRecyclable', 'defaultAutoPlay', 'defaultUpdateType', 'defaultTimeScaleIndependent', 'defaultEaseType', 'defaultEaseOvershootOrAmplitude', 'defaultEasePeriod', 'defaultAutoKill', 'defaultLoopType', 'debugMode', 'debugStoreTargetId', 'showPreviewPanel', 'storeSettingsLocation', 'modules', 'showPlayingTweens', 'showPausedTweens'] → ['AssetName', 'AssetFullFilename', 'useSafeMode', 'safeModeOptions', 'timeScale', 'useSmoothDeltaTime', 'maxSmoothUnscaledTime', 'rewindCallbackMode', 'showUnityEditorReport', 'logBehaviour', 'drawGizmos', 'defaultRecyclable', 'defaultAutoPlay', 'defaultUpdateType', 'defaultTimeScaleIndependent', 'defaultEaseType', 'defaultEaseOvershootOrAmplitude', 'defaultEasePeriod', 'defaultAutoKill', 'defaultLoopType', 'debugMode', 'debugStoreTargetId', 'showPreviewPanel', 'storeSettingsLocation', 'modules', 'createASMDEF', 'showPlayingTweens', 'showPausedTweens']`
  - `showPlayingTweens: offset '0x78' → '0x79'`
  - `showPausedTweens: offset '0x79' → '0x7a'`
  - `extra field instance bool createASMDEF`

- `DG.Tweening.Core.Debugger`

  - `field declaration order/names: ['_logPriority'] → ['_logPriority', '_LogPrefix']`
  - `extra field constant string _LogPrefix`

- `DG.Tweening.Core.Easing.EaseManager`

  - `field declaration order/names: [] → ['_PiOver2', '_TwoPi']`
  - `extra field constant float _PiOver2`
  - `extra field constant float _TwoPi`

- `DG.Tweening.Core.TweenManager`

  - `field declaration order/names: ['isUnityEditor', 'maxActive', 'maxTweeners', 'maxSequences', 'hasActiveTweens', 'hasActiveDefaultTweens', 'hasActiveLateTweens', 'hasActiveFixedTweens', 'hasActiveManualTweens', 'totActiveTweens', 'totActiveDefaultTweens', 'totActiveLateTweens', 'totActiveFixedTweens', 'totActiveManualTweens', 'totActiveTweeners', 'totActiveSequences', 'totPooledTweeners', 'totPooledSequences', 'totTweeners', 'totSequences', 'isUpdateLoop', '_activeTweens', '_pooledTweeners', '_PooledSequences', '_KillList', '_TweenLinks', '_totTweenLinks', '_maxActiveLookupId', '_requiresActiveReorganization', '_reorganizeFromId', '_minPooledTweenerId', '_maxPooledTweenerId', '_despawnAllCalledFromUpdateLoopCallback'] → ['_DefaultMaxTweeners', '_DefaultMaxSequences', '_MaxTweensReached', '_EpsilonVsTimeCheck', 'isUnityEditor', 'isDebugBuild', 'maxActive', 'maxTweeners', 'maxSequences', 'hasActiveTweens', 'hasActiveDefaultTweens', 'hasActiveLateTweens', 'hasActiveFixedTweens', 'hasActiveManualTweens', 'totActiveTweens', 'totActiveDefaultTweens', 'totActiveLateTweens', 'totActiveFixedTweens', 'totActiveManualTweens', 'totActiveTweeners', 'totActiveSequences', 'totPooledTweeners', 'totPooledSequences', 'totTweeners', 'totSequences', 'isUpdateLoop', '_activeTweens', '_pooledTweeners', '_PooledSequences', '_KillList', '_TweenLinks', '_totTweenLinks', '_maxActiveLookupId', '_requiresActiveReorganization', '_reorganizeFromId', '_minPooledTweenerId', '_maxPooledTweenerId', '_despawnAllCalledFromUpdateLoopCallback']`
  - `extra field constant int _DefaultMaxTweeners`
  - `extra field constant int _DefaultMaxSequences`
  - `extra field constant string _MaxTweensReached`
  - `extra field constant float _EpsilonVsTimeCheck`
  - `extra field static bool isDebugBuild`

- `DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions>`

  - `field declaration order/names: ['startValue', 'endValue', 'changeValue', 'plugOptions', 'getter', 'setter', 'tweenPlugin', '_TxtCantChangeSequencedValues'] → ['startValue', 'endValue', 'changeValue', 'plugOptions', 'getter', 'setter', 'tweenPlugin', '_TxtCantChangeSequencedValues', '_colorType', '_color32Type']`
  - `extra field instance Type _colorType`
  - `extra field instance Type _color32Type`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DG.Tweening.DOTween`

  - `field declaration order/names: ['Version', 'useSafeMode', 'nestedTweenFailureBehaviour', 'showUnityEditorReport', 'timeScale', 'useSmoothDeltaTime', 'maxSmoothUnscaledTime', 'rewindCallbackMode', '_logBehaviour', 'onWillLog', 'drawGizmos', 'debugMode', '_fooDebugStoreTargetId', 'defaultUpdateType', 'defaultTimeScaleIndependent', 'defaultAutoPlay', 'defaultAutoKill', 'defaultLoopType', 'defaultRecyclable', 'defaultEaseType', 'defaultEaseOvershootOrAmplitude', 'defaultEasePeriod', 'instance', 'maxActiveTweenersReached', 'maxActiveSequencesReached', 'safeModeReport', 'GizmosDelegates', 'initialized', 'isQuitting'] → ['Version', 'useSafeMode', 'safeModeLogBehaviour', 'nestedTweenFailureBehaviour', 'showUnityEditorReport', 'timeScale', 'useSmoothDeltaTime', 'maxSmoothUnscaledTime', 'rewindCallbackMode', '_logBehaviour', 'onWillLog', 'drawGizmos', 'debugMode', '_fooDebugStoreTargetId', 'defaultUpdateType', 'defaultTimeScaleIndependent', 'defaultAutoPlay', 'defaultAutoKill', 'defaultLoopType', 'defaultRecyclable', 'defaultEaseType', 'defaultEaseOvershootOrAmplitude', 'defaultEasePeriod', 'instance', '_foo_isQuitting', 'maxActiveTweenersReached', 'maxActiveSequencesReached', 'safeModeReport', 'GizmosDelegates', 'initialized', '_isQuittingFrame']`
  - `nestedTweenFailureBehaviour: offset '0xc' → '0x10'`
  - `showUnityEditorReport: offset '0x10' → '0x14'`
  - `timeScale: offset '0x14' → '0x18'`
  - `useSmoothDeltaTime: offset '0x18' → '0x1c'`
  - `maxSmoothUnscaledTime: offset '0x1c' → '0x20'`
  - `rewindCallbackMode: offset '0x20' → '0x24'`
  - `_logBehaviour: offset '0x24' → '0x28'`
  - `onWillLog: offset '0x28' → '0x30'`
  - `drawGizmos: offset '0x30' → '0x38'`
  - `debugMode: offset '0x31' → '0x39'`
  - `_fooDebugStoreTargetId: offset '0x32' → '0x3a'`
  - `defaultUpdateType: offset '0x34' → '0x3c'`
  - `defaultTimeScaleIndependent: offset '0x38' → '0x40'`
  - `defaultAutoPlay: offset '0x3c' → '0x44'`
  - `defaultAutoKill: offset '0x40' → '0x48'`
  - `defaultLoopType: offset '0x44' → '0x4c'`
  - `defaultRecyclable: offset '0x48' → '0x50'`
  - `defaultEaseType: offset '0x4c' → '0x54'`
  - `defaultEaseOvershootOrAmplitude: offset '0x50' → '0x58'`
  - `defaultEasePeriod: offset '0x54' → '0x5c'`
  - `instance: offset '0x58' → '0x60'`
  - `maxActiveTweenersReached: offset '0x60' → '0x6c'`
  - `maxActiveSequencesReached: offset '0x64' → '0x70'`
  - `safeModeReport: offset '0x68' → '0x74'`
  - `GizmosDelegates: offset '0x78' → '0x88'`
  - `initialized: offset '0x80' → '0x90'`
  - `missing field static bool isQuitting`
  - `extra field static SafeModeLogBehaviour safeModeLogBehaviour`
  - `extra field static bool _foo_isQuitting`
  - `extra field static int _isQuittingFrame`

- `DG.Tweening.Plugins.Core.PathCore.Path`

  - `field declaration order/names: ['_catmullRomDecoder', '_linearDecoder', '_cubicBezierDecoder', 'wpLengths', 'wps', 'type', 'subdivisionsXSegment', 'subdivisions', 'controlPoints', 'length', 'isFinalized', 'timesTable', 'lengthsTable', 'linearWPIndex', 'addedExtraStartWp', 'addedExtraEndWp', '_incrementalClone', '_incrementalIndex', '_decoder', '_changed', 'nonLinearDrawWps', 'targetPosition', 'lookAtPosition', 'gizmoColor'] → ['_catmullRomDecoder', '_linearDecoder', '_cubicBezierDecoder', 'wpLengths', 'wps', 'type', 'subdivisionsXSegment', 'subdivisions', 'controlPoints', 'length', 'isFinalized', 'timesTable', 'lengthsTable', 'linearWPIndex', 'addedExtraStartWp', 'addedExtraEndWp', 'plugOptions', '_incrementalClone', '_incrementalIndex', '_decoder', '_changed', 'nonLinearDrawWps', 'targetPosition', 'lookAtPosition', 'gizmoColor']`
  - `_incrementalClone: offset '0x58' → '0xc8'`
  - `_incrementalIndex: offset '0x60' → '0xd0'`
  - `_decoder: offset '0x68' → '0xd8'`
  - `_changed: offset '0x70' → '0xe0'`
  - `nonLinearDrawWps: offset '0x78' → '0xe8'`
  - `targetPosition: offset '0x80' → '0xf0'`
  - `lookAtPosition: offset '0x8c' → '0xfc'`
  - `gizmoColor: offset '0x9c' → '0x10c'`
  - `extra field instance PathOptions plugOptions`

- `DG.Tweening.Plugins.Core.PluginsManager`

  - `field declaration order/names: ['_floatPlugin', '_doublePlugin', '_intPlugin', '_uintPlugin', '_longPlugin', '_ulongPlugin', '_vector2Plugin', '_vector3Plugin', '_vector4Plugin', '_quaternionPlugin', '_colorPlugin', '_rectPlugin', '_rectOffsetPlugin', '_stringPlugin', '_vector3ArrayPlugin', '_color2Plugin', '_customPlugins'] → ['_floatPlugin', '_doublePlugin', '_intPlugin', '_uintPlugin', '_longPlugin', '_ulongPlugin', '_vector2Plugin', '_vector3Plugin', '_vector4Plugin', '_quaternionPlugin', '_colorPlugin', '_rectPlugin', '_rectOffsetPlugin', '_stringPlugin', '_vector3ArrayPlugin', '_color2Plugin', '_MaxCustomPlugins', '_customPlugins']`
  - `extra field constant int _MaxCustomPlugins`

- `DG.Tweening.Plugins.Options.PathOptions`

  - `field declaration order/names: ['mode', 'orientType', 'lockPositionAxis', 'lockRotationAxis', 'isClosedPath', 'lookAtPosition', 'lookAtTransform', 'lookAhead', 'hasCustomForwardDirection', 'forward', 'useLocalPosition', 'parent', 'isRigidbody', 'stableZRotation', 'startupRot', 'startupZRot', 'addedExtraStartWp', 'addedExtraEndWp'] → ['mode', 'orientType', 'lockPositionAxis', 'lockRotationAxis', 'isClosedPath', 'lookAtPosition', 'lookAtTransform', 'lookAhead', 'hasCustomForwardDirection', 'forward', 'useLocalPosition', 'parent', 'isRigidbody', 'isRigidbody2D', 'stableZRotation', 'startupRot', 'startupZRot', 'addedExtraStartWp', 'addedExtraEndWp']`
  - `stableZRotation: offset '0x51' → '0x52'`
  - `extra field instance bool isRigidbody2D`

- `DG.Tweening.Plugins.Options.QuaternionOptions`

  - `field declaration order/names: ['rotateMode', 'axisConstraint', 'up'] → ['rotateMode', 'axisConstraint', 'up', 'dynamicLookAt', 'dynamicLookAtWorldPosition']`
  - `extra field instance bool dynamicLookAt`
  - `extra field instance Vector3 dynamicLookAtWorldPosition`

- `DG.Tweening.Plugins.PathPlugin`

  - `field declaration order/names: [] → ['MinLookAhead']`
  - `extra field constant float MinLookAhead`

- `DG.Tweening.Tween`

  - `field declaration order/names: ['timeScale', 'isBackwards', 'id', 'stringId', 'intId', 'target', 'updateType', 'isIndependentUpdate', 'onPlay', 'onPause', 'onRewind', 'onUpdate', 'onStepComplete', 'onComplete', 'onKill', 'onWaypointChange', 'isFrom', 'isBlendable', 'isRecyclable', 'isSpeedBased', 'autoKill', 'duration', 'loops', 'loopType', 'delay', '<isRelative>k__BackingField', 'easeType', 'customEase', 'easeOvershootOrAmplitude', 'easePeriod', 'debugTargetId', 'typeofT1', 'typeofT2', 'typeofTPlugOptions', '<active>k__BackingField', 'isSequenced', 'sequenceParent', 'activeId', 'specialStartupMode', 'creationLocked', 'startupDone', '<playedOnce>k__BackingField', '<position>k__BackingField', 'fullDuration', 'completedLoops', 'isPlaying', 'isComplete', 'elapsedDelay', 'delayComplete', 'miscInt'] → ['timeScale', 'isBackwards', 'isInverted', 'id', 'stringId', 'intId', 'target', 'updateType', 'isIndependentUpdate', 'onPlay', 'onPause', 'onRewind', 'onUpdate', 'onStepComplete', 'onComplete', 'onKill', 'onWaypointChange', 'isFrom', 'isBlendable', 'isRecyclable', 'isSpeedBased', 'autoKill', 'duration', 'loops', 'loopType', 'delay', '<isRelative>k__BackingField', 'easeType', 'customEase', 'easeOvershootOrAmplitude', 'easePeriod', 'debugTargetId', 'typeofT1', 'typeofT2', 'typeofTPlugOptions', '<active>k__BackingField', 'isSequenced', 'sequenceParent', 'activeId', 'specialStartupMode', 'creationLocked', 'startupDone', '<playedOnce>k__BackingField', '<position>k__BackingField', 'fullDuration', 'completedLoops', 'isPlaying', 'isComplete', 'elapsedDelay', 'delayComplete', 'miscInt']`
  - `extra field instance bool isInverted`

- `DOTweenSettings.ModulesSetup`

  - `field declaration order/names: ['showPanel', 'audioEnabled', 'physicsEnabled', 'physics2DEnabled', 'spriteEnabled', 'uiEnabled', 'textMeshProEnabled', 'tk2DEnabled', 'deAudioEnabled', 'deUnityExtendedEnabled'] → ['showPanel', 'audioEnabled', 'physicsEnabled', 'physics2DEnabled', 'spriteEnabled', 'uiEnabled', 'textMeshProEnabled', 'tk2DEnabled', 'deAudioEnabled', 'deUnityExtendedEnabled', 'epoOutlineEnabled']`
  - `extra field instance bool epoOutlineEnabled`

- `DOTweenSettings.SafeModeOptions`

  - `field declaration order/names: ['nestedTweenFailureBehaviour'] → ['logBehaviour', 'nestedTweenFailureBehaviour']`
  - `nestedTweenFailureBehaviour: offset '0x10' → '0x14'`
  - `extra field instance SafeModeLogBehaviour logBehaviour`

- `ShortcutExtensions.<>c__DisplayClass61_0` (compiler-generated name)

  - `field declaration order/names: ['target'] → ['target', 'startPosY', 'offsetYSet', 'offsetY', 's', 'endValue', 'yTween']`
  - `extra field instance float startPosY`
  - `extra field instance bool offsetYSet`
  - `extra field instance float offsetY`
  - `extra field instance Sequence s`
  - `extra field instance Vector3 endValue`
  - `extra field instance Tween yTween`

- `ShortcutExtensions.<>c__DisplayClass62_0` (compiler-generated name)

  - `field declaration order/names: ['target'] → ['target', 'startPosY', 'offsetYSet', 'offsetY', 's', 'endValue', 'yTween']`
  - `extra field instance float startPosY`
  - `extra field instance bool offsetYSet`
  - `extra field instance float offsetY`
  - `extra field instance Sequence s`
  - `extra field instance Vector3 endValue`
  - `extra field instance Tween yTween`


</details>

<details><summary>Missing: 2</summary>

- `DG.Tweening.Core.Utils`
- `ShortcutExtensions.<>c__DisplayClass50_0` (compiler-generated name)

</details>

<details><summary>Extra: 66</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2987`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4144`
- `DG.Tweening.Core.DOTweenUtils`
- `DG.Tweening.Core.Enums.SafeModeLogBehaviour`
- `DG.Tweening.DOCurve`
- `DG.Tweening.EaseFactory`
- `DG.Tweening.Plugins.CircleOptions`
- `DG.Tweening.Plugins.CirclePlugin`
- `DG.Tweening.Plugins.Core.IPlugSetter<T1, T2, TPlugin, TPlugOptions>`
- `DG.Tweening.Plugins.Core.ITPlugin<T1, T2, TPlugOptions, TPlugin>`
- `DG.Tweening.TweenParams`
- `DOCurve.CubicBezier`
- `DOTween.<>c__DisplayClass66_0` (compiler-generated name)
- `DOVirtual.<>c__DisplayClass1_0` (compiler-generated name)
- `DOVirtual.<>c__DisplayClass2_0` (compiler-generated name)
- `DOVirtual.<>c__DisplayClass3_0` (compiler-generated name)
- `Debugger.Sequence`
- `EaseFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `EaseManager.<>c` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass10_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass11_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass14_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass15_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass17_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass18_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass20_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass21_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass22_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass23_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass24_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass25_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass26_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass27_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass28_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass29_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass2_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass30_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass31_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass35_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass39_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass41_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass43_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass48_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass4_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass53_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass55_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass57_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass59_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass60_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass65_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass66_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass67_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass68_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass69_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass70_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass71_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass72_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass73_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass74_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass75_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass76_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass77_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass8_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass9_0` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Octo.dll

<details><summary>Matching: 209</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `AndroidFileDownloadRequest.<Execute>d__10` (compiler-generated name)
- `AndroidFileDownloadRequest.Bridge`
- `AndroidFileDownloadRequest.NativeHttpAsyncTask`
- `AndroidFileDownloadRequest.NativeHttpResult`
- `AndroidFileDownloadRequest.NativeJavaObjectWrapper`
- `AndroidFileDownloadRequest.Result`
- `AssetBundleLoadRequest.<Execute>d__20` (compiler-generated name)
- `AssetBundleLoadRequest.<Prepare>d__19` (compiler-generated name)
- `AssetBundleManager.<>c__DisplayClass19_0` (compiler-generated name)
- `AssetBundleManager.<>c__DisplayClass20_0` (compiler-generated name)
- `AssetBundleManager.<>c__DisplayClass28_0` (compiler-generated name)
- `AssetBundleManager.<_CheckUnloadAssetKeeper>d__31` (compiler-generated name)
- `AssetBundleManager.<_LoadAssetBundle>d__28` (compiler-generated name)
- `AssetBundleManager.DeleteQueueIterator`
- `AssetBundleManager.RequestRollBack`
- `AssetBundleManager.RequestRollBack.<RollBack>d__6` (compiler-generated name)
- `AssetKeeper.AssetBundleLoadState`
- `AssetKeeper.AssetLoadState`
- `AssetLoader.<>c__DisplayClass31_0` (compiler-generated name)
- `AssetLoader.<>c__DisplayClass41_0` (compiler-generated name)
- `AssetLoader.<_LoadAssetBundle>d__42` (compiler-generated name)
- `AssetLoader.<_StartLoadAssetBundle>d__41` (compiler-generated name)
- `AssetLoader.AssetData`
- `AssetLoader.LoadAssetBundleCompleteEvent`
- `AssetLoader.LoadAssetCompleteEvent`
- `AssetLoader.LoadPriority`
- `AssetLoader.LoadState`
- `AssetLoader.RequestAssetData`
- `BaseBulkDownloader.<>c` (compiler-generated name)
- `BaseBulkDownloader.<>c__DisplayClass52_0` (compiler-generated name)
- `BaseBulkDownloader.<>c__DisplayClass54_0` (compiler-generated name)
- `BaseBulkDownloader.<>c__DisplayClass57_0` (compiler-generated name)
- `BaseExecutor.<>c__DisplayClass23_0` (compiler-generated name)
- `BaseExecutor.<ExecuteQueue>d__26` (compiler-generated name)
- `BaseExecutor.<RequestWithTimeout>d__29` (compiler-generated name)
- `BaseRequest.<Finish>d__10` (compiler-generated name)
- `BaseRequest.<Prepare>d__8` (compiler-generated name)
- `BaseRequest.<TimeoutWatcher>d__11` (compiler-generated name)
- `DataManager.<>c` (compiler-generated name)
- `DelayedFrameUnloadHandler.<FrameLoop>d__2` (compiler-generated name)
- `Dispatcher.<>c` (compiler-generated name)
- `DownloadHandlerFile.Worker`
- `Downloader.<>c__DisplayClass10_0` (compiler-generated name)
- `Downloader.<>c__DisplayClass13_0` (compiler-generated name)
- `Downloader.<RequestAfterCachingIsReady>d__9` (compiler-generated name)
- `IBulkDownloaderExtensions`
- `IBulkDownloaderExtensions.<WaitForTaskComplete>d__0` (compiler-generated name)
- `Item.<>c` (compiler-generated name)
- `Item.<>c__DisplayClass32_0` (compiler-generated name)
- `Item.<>c__DisplayClass36_0` (compiler-generated name)
- `Item.<GetFamily>d__35` (compiler-generated name)
- `LegacyUnloadHandler.<FrameLoop>d__2` (compiler-generated name)
- `MixBulkDownloader.<>c` (compiler-generated name)
- `Octo.ActionExtensions`
- `Octo.Asset.AssetBundleData`
- `Octo.Asset.AssetBundleLoadRequest`
- `Octo.Asset.AssetBundleManager`
- `Octo.Asset.AssetBundleOperator`
- `Octo.AssetBundleBaseBulkDownloader`
- `Octo.AssetBundleLoadHandler`
- `Octo.AssetBundleUnloadHandler`
- `Octo.AssetKeeper`
- `Octo.AssetLoader`
- `Octo.AssetLoaderError`
- `Octo.AssetLoaderExtensions`
- `Octo.AsyncDownloadException`
- `Octo.AsyncLoadException`
- `Octo.BaseBulkDownloader`
- `Octo.BulkDownloaderFactory`
- `Octo.Caching.CacheDeleteExecutor`
- `Octo.Caching.CacheState`
- `Octo.Caching.EmptyStorageList`
- `Octo.Caching.IStorageList`
- `Octo.Caching.OctoAndroidAppCaching`
- `Octo.Caching.OctoAndroidPackAppCaching`
- `Octo.Caching.OctoAppCaching`
- `Octo.Caching.OctoBaseCaching`
- `Octo.Caching.OctoCaching`
- `Octo.Caching.OctoHybridCaching`
- `Octo.Caching.Storage`
- `Octo.Caching.StorageList`
- `Octo.Caching.UnityCaching`
- `Octo.CachingType`
- `Octo.Data.DataManager`
- `Octo.Data.ItemFactory`
- `Octo.Data.ItemType`
- `Octo.Data.ItemWithDeps`
- `Octo.Data.ItemWithDepsAndTags`
- `Octo.Data.ItemWithTags`
- `Octo.Data.ObjectName`
- `Octo.Data.ProtoWriterExtensions`
- `Octo.Data.SecureFile`
- `Octo.Data.SecureProtoBufDatabase<T>`
- `Octo.DatabaseError`
- `Octo.DatabaseErrorCode`
- `Octo.DelayedFrameUnloadHandler`
- `Octo.DownloadError`
- `Octo.DownloadErrorCode`
- `Octo.DownloadErrorHandler`
- `Octo.Error`
- `Octo.ErrorExtensions`
- `Octo.GetResourceExtensionHandler`
- `Octo.IAssetBundleLoader`
- `Octo.IAssetBundleManager`
- `Octo.IAssetOperator`
- `Octo.IBulkDownloader`
- `Octo.ICaching`
- `Octo.ICachingInternal`
- `Octo.IDatabase`
- `Octo.IExecutor`
- `Octo.ILoader`
- `Octo.ILoader<T>`
- `Octo.IOctoCaching`
- `Octo.IOctoSettings`
- `Octo.IResourceLoader`
- `Octo.IUnloadHandler`
- `Octo.ImplicitDownloadHandler`
- `Octo.LegacyUnloadHandler`
- `Octo.LoadError`
- `Octo.LoadErrorHandler`
- `Octo.Loader.BaseExecutor`
- `Octo.Loader.BaseRequest`
- `Octo.Loader.Common`
- `Octo.Loader.Downloader`
- `Octo.Loader.IRequest`
- `Octo.Loader.LoadExecutor`
- `Octo.Loader.LoadStaus`
- `Octo.Loader.OctoAPI`
- `Octo.Loader.OctoAssetBundleLoader`
- `Octo.Loader.OctoAssetBundleLoaderExtensions`
- `Octo.Loader.OctoBaseLoader`
- `Octo.Loader.OctoResourceLoader`
- `Octo.Loader.UnityAssetBundleLoader`
- `Octo.MixBulkDownloader`
- `Octo.NamedError`
- `Octo.Network.AndroidFileDownloadRequest`
- `Octo.Network.AppInfo`
- `Octo.Network.Dispatcher`
- `Octo.Network.DownloadHandlerFile`
- `Octo.Network.ErrorLevel`
- `Octo.Network.ErrorReport`
- `Octo.Network.ErrorReportLog`
- `Octo.Network.IDownloadRequest`
- `Octo.Network.IDownloadResult`
- `Octo.Network.OctoEnvInfo`
- `Octo.Network.UnityEnvInfo`
- `Octo.Network.UnityWebRequestExtensions`
- `Octo.OctoExtensions`
- `Octo.OctoFullSettings`
- `Octo.OctoManager`
- `Octo.OctoSettings`
- `Octo.OnDownloadProgress`
- `Octo.ResourceBaseBulkDownloader`
- `Octo.SetupHelper`
- `Octo.SimpleUnloadHandler`
- `Octo.Statistics`
- `Octo.UnloadHandlerBase`
- `Octo.Util.Android.AndroidFileUtil`
- `Octo.Util.AppEmbedUtil`
- `Octo.Util.AppEventHandler`
- `Octo.Util.BufferPool`
- `Octo.Util.Bytes`
- `Octo.Util.MD5`
- `Octo.Util.MD5Value`
- `Octo.Util.PlatformUtil`
- `Octo.Util.Profiler`
- `Octo.Util.Timer`
- `Octo.VersionChecker`
- `Octo.WarmupState`
- `OctoAPI.<>c__DisplayClass16_0` (compiler-generated name)
- `OctoAPI.<>c__DisplayClass19_0` (compiler-generated name)
- `OctoAPI.<>c__DisplayClass21_0` (compiler-generated name)
- `OctoAPI.<>c__DisplayClass22_0` (compiler-generated name)
- `OctoAPI.<>c__DisplayClass23_0` (compiler-generated name)
- `OctoAPI.<DoSendErrorReport>d__30` (compiler-generated name)
- `OctoAppCaching.EmbeddedInfo`
- `OctoAssetBundleLoader.<>c__DisplayClass6_0` (compiler-generated name)
- `OctoAssetBundleLoader.<>c__DisplayClass8_0` (compiler-generated name)
- `OctoAssetBundleLoader.<LoadFromFileAsync>d__9` (compiler-generated name)
- `OctoAssetBundleLoaderExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `OctoAssetBundleLoaderExtensions.<LoadAssetBundleFromBytesAsyncCoroutine>d__2` (compiler-generated name)
- `OctoBaseCaching.<>c` (compiler-generated name)
- `OctoBaseCaching.<>c__DisplayClass61_0` (compiler-generated name)
- `OctoBaseCaching.<>c__DisplayClass62_0` (compiler-generated name)
- `OctoBaseLoader.<>c__DisplayClass11_0` (compiler-generated name)
- `OctoManager.<>c__DisplayClass127_0` (compiler-generated name)
- `OctoManager.<>c__DisplayClass128_0` (compiler-generated name)
- `OctoManager.<>c__DisplayClass97_0` (compiler-generated name)
- `OctoManager.<>c__DisplayClass98_0` (compiler-generated name)
- `OctoManager.<LoadAssetBundleAsync>d__128` (compiler-generated name)
- `OctoManager.<LoadAssetBundleAsync>d__130` (compiler-generated name)
- `OctoManager.<StartDbUpdateAsync>d__127` (compiler-generated name)
- `OctoManager.Internal`
- `PlatformUtil.Android`
- `Profiler.Token`
- `SecureFile.Mode`
- `SimpleUnloadHandler.<FrameLoop>d__2` (compiler-generated name)
- `Statistics.Network`
- `Statistics.Network.Internal`
- `Storage.<>c__DisplayClass25_0` (compiler-generated name)
- `Storage.State`
- `StorageList.<>c` (compiler-generated name)
- `UnityAssetBundleLoader.<>c__DisplayClass6_0` (compiler-generated name)
- `UnityAssetBundleLoader.<>c__DisplayClass8_0` (compiler-generated name)
- `UnityAssetBundleLoader.<>c__DisplayClass9_0` (compiler-generated name)
- `UnityAssetBundleLoader.<LoadFromAppCachingAsync>d__10` (compiler-generated name)

</details>

<details><summary>Mismatching: 4</summary>

- `DataManager.<>c__DisplayClass56_0` (compiler-generated name)

  - `db: type 'Database' → 'object'`

- `Octo.Data.AESCrypt`

  - `_fastAes: type 'FastAES' → 'object'`

- `Octo.Data.Item`

  - `state: type 'Data.State' → 'int'`

- `Octo.Proto.StaticSerializer`

  - `_serializer: type 'OCTProtoSerializer' → 'object'`


</details>

<details><summary>Indeterminate: 40</summary>

- `ActionExtensions.<>c__DisplayClass11_0<T1>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ActionExtensions.<>c__DisplayClass12_0<T1, T2>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<>c__DisplayClass16_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<>c__DisplayClass29_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<>c__DisplayClass29_1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<DoLoadAsset>d__18<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<LoadAssetAsync>d__30<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<LoadAssetAsync>d__32<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<LoadAssetAsyncInternal>d__29<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetKeeper.<LoadMainAssetAsync>d__31<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass29_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass29_1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass29_2<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass32_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass33_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<>c__DisplayClass43_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<_LoadAssetAsyncFromAssetBundle>d__46<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<_LoadAssetAsyncFromResources>d__47<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<_LoadAssetAsyncIncludeOtherRequest>d__43<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AssetLoader.<_WaitLoadAsset>d__45<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseDownloadRequest.<Finish>d__28<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseDownloadRequest.<TimeoutWatcher>d__27<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Common.<>c__DisplayClass2_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Common.CallbackEvents.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Common.CallbackEvents<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Common.Result<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dispatcher.<>c__DisplayClass1_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.AsyncLoadResult<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.Data.SecureSerializableDatabase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.LoadRequest<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.Loader.ResourceLoadRequest<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.Network.BaseDownloadRequest<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.Network.UnityDownloadRequest<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Octo.Util.FileUtil`

  - Limitation: _pathCombiner: no comparable storage offset

- `Octo.Util.OctoUtil`

  - Limitation: _sharedCharaBuffer: no comparable storage offset

- `OctoResourceLoader.<LoadLocalResource>d__6<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ResourceLoadRequest.<Execute>d__13<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ResourceLoadRequest.<Prepare>d__12<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityDownloadRequest.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityDownloadRequest.<Execute>d__6<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=6670`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=9813`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## ProFlare.Runtime.dll

<details><summary>Matching: 27</summary>

- `<Module>`
- `FlareData`
- `FlareOcclusion`
- `FlareOcclusion.CullingState`
- `FlarePixelOcclusion`
- `ProFlare`
- `ProFlareAtlas`
- `ProFlareAtlas.Element`
- `ProFlareBatch`
- `ProFlareBatch.Mode`
- `ProFlareBatchForSRP`
- `ProFlareBatchForSRPData`
- `ProFlareBatchForSRPData.<>c__DisplayClass48_0` (compiler-generated name)
- `ProFlareBatchForSRPData.<>c__DisplayClass48_1` (compiler-generated name)
- `ProFlareBatchForSRPData.<>c__DisplayClass48_2` (compiler-generated name)
- `ProFlareBatchForSRPData.<>c__DisplayClass48_3` (compiler-generated name)
- `ProFlareElement`
- `ProFlareElement.Type`
- `ProFlareElementData`
- `ProFlareInputData`
- `ProFlareProcessData`
- `ProFlareRenderingSystem`
- `ProFlareUpdateElementData`
- `ProFlareUpdateElementJob`
- `ProFlareUpdateInOutputData`
- `ProFlareUpdateJob`
- `SubElement`

</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1141`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=679`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Qua.Base.Runtime.dll

<details><summary>Matching: 12</summary>

- `<Module>`
- `HapticFeedback.AndroidGenerator`
- `HapticFeedback.IGenerator`
- `HapticFeedback.Power`
- `Qua.Base.AndroidUtil`
- `Qua.Base.HapticFeedback`
- `Qua.Base.ScreenUtil`
- `Qua.Base.StoreUtil`
- `StoreUtil.AndroidBridge`
- `StoreUtil.DummyBridge`
- `StoreUtil.IBridge`
- `StoreUtil.ReviewRequester`

</details>

<details><summary>Mismatching: 1</summary>

- `StoreUtil.AndroidBridge.<RequestReviewAndroid>d__3` (compiler-generated name)

  - `<reviewManager>5__2: type 'ReviewManager' → 'object'`
  - `<requestFlowOperation>5__3: type 'PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode>' → 'object'`
  - `<launchFlowOperation>5__4: type 'PlayAsyncOperation<VoidResult, ReviewErrorCode>' → 'object'`


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=264`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=398`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Qua.PolygonUtility.dll

<details><summary>Matching: 49</summary>

- `<Module>`
- `ClipperLib.ClipType`
- `ClipperLib.Clipper`
- `ClipperLib.ClipperBase`
- `ClipperLib.ClipperException`
- `ClipperLib.Direction`
- `ClipperLib.EdgeSide`
- `ClipperLib.Int128`
- `ClipperLib.IntPoint`
- `ClipperLib.IntersectNode`
- `ClipperLib.Join`
- `ClipperLib.LocalMinima`
- `ClipperLib.Maxima`
- `ClipperLib.OutPt`
- `ClipperLib.OutRec`
- `ClipperLib.PolyFillType`
- `ClipperLib.PolyNode`
- `ClipperLib.PolyType`
- `ClipperLib.Scanbeam`
- `ClipperLib.TEdge`
- `Dict.LessOrEqual<TValue>`
- `LibTessDotNet.CombineCallback`
- `LibTessDotNet.ContourOrientation`
- `LibTessDotNet.ContourVertex`
- `LibTessDotNet.DefaultPool`
- `LibTessDotNet.ElementType`
- `LibTessDotNet.Geom`
- `LibTessDotNet.IPool`
- `LibTessDotNet.ITypePool`
- `LibTessDotNet.Mesh`
- `LibTessDotNet.MeshUtils`
- `LibTessDotNet.PQHandle`
- `LibTessDotNet.Pooled<T>`
- `LibTessDotNet.Tess`
- `LibTessDotNet.Vec3`
- `LibTessDotNet.WindingRule`
- `MeshUtils.Edge`
- `MeshUtils.EdgePair`
- `MeshUtils.Face`
- `MeshUtils.Vertex`
- `PolygonUtility.Clipper`
- `PolygonUtility.LibTess`
- `PriorityHeap.LessOrEqual<TValue>`
- `Qua.PolygonUtility.IPooling`
- `Qua.PolygonUtility.Polygon`
- `Qua.PolygonUtility.PolygonPaths`
- `Qua.PolygonUtility.PolygonUtility`
- `Qua.PolygonUtility.Region`
- `Tess.ActiveRegion`

</details>

<details><summary>Indeterminate: 8</summary>

- `Dict.Node<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LibTessDotNet.DefaultTypePool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LibTessDotNet.Dict<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LibTessDotNet.PriorityHeap<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LibTessDotNet.PriorityQueue<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PriorityHeap.HandleElem<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PriorityQueue.StackItem<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.PolygonUtility.Pooling<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1320`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2459`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Qua.Utility.dll

<details><summary>Matching: 25</summary>

- `<Module>`
- `Qua.Extensions.DeconstructExtensions`
- `Qua.Extensions.GameObjectExtensions`
- `Qua.Extensions.GraphicExtensions`
- `Qua.Extensions.IDictionaryExtensions`
- `Qua.Extensions.IEnumerableExtensions`
- `Qua.Extensions.IListExtensions`
- `Qua.Extensions.IUniTaskExceptionHandler`
- `Qua.Extensions.RectTransformExtensions`
- `Qua.Extensions.StringExtensions`
- `Qua.Extensions.TransformExtensions`
- `Qua.Extensions.UniTaskExtension`
- `Qua.Utility.CancellationUtility`
- `Qua.Utility.HierarchyUtility`
- `Qua.Utility.ListPool<T>`
- `Qua.Utility.PathUtility`
- `Qua.Utility.QuittingState`
- `Qua.Utility.SingletonCreatorAttribute`
- `Qua.Utility.SingletonResourcePathAttribute`
- `Qua.Utility.UniTaskUtility`
- `Qua.Utility.Vector2AnchorAttribute`
- `Qua.Utility.VectorAnchorUtility`
- `UniTaskExtension.<RunAsync>d__6` (compiler-generated name)
- `UniTaskUtility.<>c__DisplayClass0_0` (compiler-generated name)
- `UniTaskUtility.<FromEventAsync>d__0` (compiler-generated name)

</details>

<details><summary>Indeterminate: 8</summary>

- `ListPool.ListContainer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.Utility.ComponentPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.Utility.ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.Utility.SimpleComponentPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.Utility.SimpleObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.Utility.Singleton<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskUtility.<>c__DisplayClass1_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskUtility.<FromEventAsync>d__1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1270`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1880`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Qua.VectorUI.Runtime.dll

<details><summary>Matching: 29</summary>

- `<Module>`
- `Circle.<>c__DisplayClass10_0` (compiler-generated name)
- `CircleRoundLine.<>c__DisplayClass30_0` (compiler-generated name)
- `Ellipse.<>c__DisplayClass10_0` (compiler-generated name)
- `Qua.VectorUI.Circle`
- `Qua.VectorUI.CircleRoundLine`
- `Qua.VectorUI.Ellipse`
- `Qua.VectorUI.RadarChart`
- `Qua.VectorUI.RadarChartOutlineSetter`
- `Qua.VectorUI.RoundBorder`
- `Qua.VectorUI.RoundedPolyline`
- `Qua.VectorUI.RoundedPolylineMesh`
- `Qua.VectorUI.RoundedPolylineOutlineSetter`
- `Qua.VectorUI.SharedMaterialGraphic<T>`
- `Qua.VectorUI.SimpleRoundLine`
- `Qua.VectorUI.VectorUIUtility`
- `RadarChartOutlineSetter.<>c__DisplayClass0_0` (compiler-generated name)
- `RoundBorder.<>c__DisplayClass25_0` (compiler-generated name)
- `RoundedPolyline.EndCapType`
- `RoundedPolyline.PropertyId`
- `RoundedPolyline.Vertex`
- `RoundedPolyline.VertexPositionType`
- `RoundedPolylineMesh.CornerMeshInfo`
- `RoundedPolylineMesh.CornerMeshInfo.<>c__DisplayClass13_0` (compiler-generated name)
- `RoundedPolylineMesh.EdgeMeshInfo`
- `RoundedPolylineMesh.EdgeMeshInfo.<>c__DisplayClass6_0` (compiler-generated name)
- `RoundedPolylineMesh.PartsMeshInfoBase`
- `RoundedPolylineOutlineSetter.<>c__DisplayClass0_0` (compiler-generated name)
- `SimpleRoundLine.<>c__DisplayClass6_0` (compiler-generated name)

</details>

<details><summary>Indeterminate: 4</summary>

- `MaterialCache.Entry<TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.VectorUI.GraphicOutlineSetterBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.VectorUI.MaterialCache<TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.VectorUI.SharedMaterialGraphic<T, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1196`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1390`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Titan.Runtime.dll

<details><summary>Matching: 286</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=40`
- `BoolValue.ValuePool`
- `ExpressionHolder.<>c` (compiler-generated name)
- `GaugeTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `IEnumerableExtensions.IdentityFunction<TElement>`
- `IdentifierToken.TokenPool`
- `IntegerToken.TokenPool`
- `IntegerValue.ValuePool`
- `IntervalTrack.<>c` (compiler-generated name)
- `LocalPathTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `LocalRotateTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `NormalTimelineTrack.<>c` (compiler-generated name)
- `NormalTimelineTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `NumberToken.TokenPool`
- `NumberValue.ValuePool`
- `ObjectValue.ValuePool`
- `ParametersOverrider.InstancePool`
- `Parser.InternalParser`
- `Parser.ParserPool`
- `ParticleTrack.<>c` (compiler-generated name)
- `ParticleTrack.<>c__DisplayClass1_0` (compiler-generated name)
- `ParticleTrack.<>c__DisplayClass2_0` (compiler-generated name)
- `SpriteAnimationTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `StringValue.ValuePool`
- `TextMeshProCharAlphaTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TextMeshProCharColorTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TextMeshProCharMeshModifier.<>c__DisplayClass36_0` (compiler-generated name)
- `TextMeshProCharMeshModifier.<>c__DisplayClass37_0` (compiler-generated name)
- `TextMeshProCharMeshModifier.ModificationData`
- `TextMeshProCharOffsetTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TextMeshProCharPivotTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TextMeshProCharRotationTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TextMeshProCharScaleTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `TimelineTweenExtensions.<>c__DisplayClass4_0` (compiler-generated name)
- `Titan.ActivationClip`
- `Titan.ActivationTrack`
- `Titan.AlphaParameter`
- `Titan.AnchorMaxClip`
- `Titan.AnchorMaxTrack`
- `Titan.AnchorMinClip`
- `Titan.AnchorMinTrack`
- `Titan.AnchorPositionClip`
- `Titan.AnchorPositionTrack`
- `Titan.ArrayParameter<T>`
- `Titan.ArrayTweenerClipBase<TValue>`
- `Titan.ArrayTweenerTrackBase<TClipAsset, TComponent, TValue, TParameter>`
- `Titan.ArrayTweenerTrackBase<TClipAsset, TComponent, TValue>`
- `Titan.BoolParameter`
- `Titan.BoolTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.BoolValue`
- `Titan.Callable`
- `Titan.CallbackEntry`
- `Titan.CallbackMarker`
- `Titan.CallbackTiming`
- `Titan.CanvasGroupAlphaClip`
- `Titan.CanvasGroupAlphaTrack`
- `Titan.CastException`
- `Titan.ColorArrayTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.ColorParameter`
- `Titan.ColorTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.ConditionBranchClip`
- `Titan.ConditionBranchTrack`
- `Titan.CustomTweenClip`
- `Titan.CustomTweenTrack`
- `Titan.DebugMarker`
- `Titan.DummyValueResolver`
- `Titan.EaseExtensions`
- `Titan.EaseInfo`
- `Titan.EaseSetting`
- `Titan.EmptyVariableTable`
- `Titan.ExpressionException`
- `Titan.ExpressionHolder`
- `Titan.ExpressionWithName`
- `Titan.FillAmountClip`
- `Titan.FillAmountTrack`
- `Titan.Float01Parameter`
- `Titan.FloatArrayTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.FloatParameter`
- `Titan.FloatTweenerTrackBase<TClipAsset, TComponent, TParameter>`
- `Titan.FloatTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.GaugeClip`
- `Titan.GaugeTrack`
- `Titan.GraphicAlphaClip`
- `Titan.GraphicAlphaTrack`
- `Titan.GraphicColorClip`
- `Titan.GraphicColorTrack`
- `Titan.GroupParameterTrack`
- `Titan.ICollectValueRevertersContext`
- `Titan.IComponentValueSetter<TComponent, TValue>`
- `Titan.IEnumerableExtensions`
- `Titan.IExpressionHolder`
- `Titan.IExpressionHolderExtensions`
- `Titan.IMemberAccessResolver`
- `Titan.IPathVertex`
- `Titan.ITimelineTween`
- `Titan.ITweenLoopInfo`
- `Titan.ITweenPlayer`
- `Titan.ITweenTrack`
- `Titan.IValueResolver`
- `Titan.IValueReverter`
- `Titan.IVariableDefinitionHolder`
- `Titan.IVariableTable`
- `Titan.IVariableValue`
- `Titan.IdentifierToken`
- `Titan.IntParameter`
- `Titan.IntTweenerTrackBase<TClipAsset, TComponent, TParameter>`
- `Titan.IntTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.IntegerToken`
- `Titan.IntegerValue`
- `Titan.IntervalClip`
- `Titan.IntervalTrack`
- `Titan.Legacy.SpriteAnimationClip`
- `Titan.Legacy.SpriteAnimationTrack`
- `Titan.LocalPathClip`
- `Titan.LocalPathClip3D`
- `Titan.LocalPathTrack`
- `Titan.LocalPathTrack3D`
- `Titan.LocalPosition3DClip`
- `Titan.LocalPosition3DTrack`
- `Titan.LocalPositionClip`
- `Titan.LocalPositionTrack`
- `Titan.LocalRotateClip`
- `Titan.LocalRotateTrack`
- `Titan.LongParameter`
- `Titan.LongTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.LoopableTweenClip`
- `Titan.MarkerExecutionType`
- `Titan.MemberAccessResolver`
- `Titan.MultipleNestClip`
- `Titan.MultipleNestTrack`
- `Titan.NestClip`
- `Titan.NestTrack`
- `Titan.NormalTimelineClip`
- `Titan.NormalTimelineTrack`
- `Titan.NullValue`
- `Titan.NumberToken`
- `Titan.NumberValue`
- `Titan.ObjectValue`
- `Titan.OffsetMaxClip`
- `Titan.OffsetMaxTrack`
- `Titan.OffsetMinClip`
- `Titan.OffsetMinTrack`
- `Titan.ParameterRangeAttribute`
- `Titan.ParametersOverrider`
- `Titan.ParseException`
- `Titan.Parser`
- `Titan.ParticleClip`
- `Titan.ParticlePlayType`
- `Titan.ParticleTrack`
- `Titan.PathClip2DBase`
- `Titan.PathClip3DBase`
- `Titan.PathTrack3DBase<TClipAsset>`
- `Titan.PathTrackBase<TClipAsset>`
- `Titan.PathVertex`
- `Titan.PathVertex3D`
- `Titan.PivotClip`
- `Titan.PivotTrack`
- `Titan.PlayableDirectorGroup`
- `Titan.RectMask2DPaddingClip`
- `Titan.RectMask2DPaddingParameter`
- `Titan.RectMask2DPaddingTrack`
- `Titan.RectMask2DSoftnessClip`
- `Titan.RectMask2DSoftnessTrack`
- `Titan.Scale3DClip`
- `Titan.Scale3DTrack`
- `Titan.ScaleClip`
- `Titan.ScaleTrack`
- `Titan.ScaleVector2Parameter`
- `Titan.SetTweenExecutionTiming`
- `Titan.SizeDeltaClip`
- `Titan.SizeDeltaTrack`
- `Titan.SizeWithCurrentAnchorsClip`
- `Titan.SizeWithCurrentAnchorsTrack`
- `Titan.SliderValueClip`
- `Titan.SliderValueTrack`
- `Titan.SpriteRendererAlphaClip`
- `Titan.SpriteRendererAlphaTrack`
- `Titan.SpriteRendererColorClip`
- `Titan.SpriteRendererColorTrack`
- `Titan.StateClipBase`
- `Titan.StateTrackBase<TClipAsset, TComponent>`
- `Titan.StringParameter`
- `Titan.StringTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.StringValue`
- `Titan.StringWrapper`
- `Titan.TextMeshProChangeTextClip`
- `Titan.TextMeshProChangeTextTrack`
- `Titan.TextMeshProCharAlphaClip`
- `Titan.TextMeshProCharAlphaTrack`
- `Titan.TextMeshProCharColorClip`
- `Titan.TextMeshProCharColorTrack`
- `Titan.TextMeshProCharMeshModifier`
- `Titan.TextMeshProCharOffsetClip`
- `Titan.TextMeshProCharOffsetTrack`
- `Titan.TextMeshProCharPivotClip`
- `Titan.TextMeshProCharPivotTrack`
- `Titan.TextMeshProCharRotationClip`
- `Titan.TextMeshProCharRotationTrack`
- `Titan.TextMeshProCharScaleClip`
- `Titan.TextMeshProCharScaleTrack`
- `Titan.TextMeshProCharTrackBase<TClipAsset, TValue, TParameter>`
- `Titan.TextMeshProColorClip`
- `Titan.TextMeshProColorTrack`
- `Titan.TextMeshProCountClip`
- `Titan.TextMeshProCountTrack`
- `Titan.TextMeshProFadeClip`
- `Titan.TextMeshProFadeTrack`
- `Titan.TextMeshProMaxVisibleCharactersClip`
- `Titan.TextMeshProMaxVisibleCharactersTrack`
- `Titan.TimelineTweenExtensions`
- `Titan.TitanAnimationTrackUtility`
- `Titan.TitanControlClip`
- `Titan.TitanControlClipBehaviour`
- `Titan.TitanControlMixerBehaviour`
- `Titan.TitanControlTrack`
- `Titan.TitanEase`
- `Titan.TitanPlayer`
- `Titan.TitanSettings`
- `Titan.TitanTrackBindingTypeAttribute`
- `Titan.TitanUtility`
- `Titan.Token`
- `Titan.TokenType`
- `Titan.TrackGroupVariableValue`
- `Titan.TrackStartTimeCache`
- `Titan.TweenClipBase`
- `Titan.TweenCreationContext`
- `Titan.TweenLoopInfoExtensions`
- `Titan.TweenMarkerBase`
- `Titan.TweenMarkerCallback`
- `Titan.TweenPlayer`
- `Titan.TweenTrackBase`
- `Titan.TweenTrackBase<TClipAsset, TComponent>`
- `Titan.TweenWithDelay`
- `Titan.TweenerClipBase`
- `Titan.UvPositionClip`
- `Titan.UvPositionTrack`
- `Titan.Value`
- `Titan.ValueResolverExtensions`
- `Titan.ValueType`
- `Titan.VariableDefinition`
- `Titan.VariableInputHandler`
- `Titan.VariableTable`
- `Titan.VariableType`
- `Titan.Vector2ArrayTweenerTrackBase<TClipAsset, TComponent>`
- `Titan.Vector2AxisType`
- `Titan.Vector2Parameter`
- `Titan.Vector2TweenerTrackBase<TClipAsset, TComponent, TParameter>`
- `Titan.Vector2TweenerTrackBase<TClipAsset, TComponent>`
- `Titan.Vector3AxisType`
- `Titan.Vector3Parameter`
- `Titan.Vector3TweenerTrackBase<TClipAsset, TComponent, TParameter>`
- `Titan.Vector3TweenerTrackBase<TClipAsset, TComponent>`
- `Titan.Vector4AxisType`
- `Titan.Vector4Parameter`
- `Titan.Vector4TweenerTrackBase<TClipAsset, TComponent, TParameter>`
- `Titan.Vector4TweenerTrackBase<TClipAsset, TComponent>`
- `Titan.VectorParameterLabelsAttribute`
- `Titan.WorldPathClip`
- `Titan.WorldPathClip3D`
- `Titan.WorldPathTrack`
- `Titan.WorldPathTrack3D`
- `Titan.WorldPosition3DClip`
- `Titan.WorldPosition3DTrack`
- `Titan.WorldPositionClip`
- `Titan.WorldPositionTrack`
- `TitanAnimationTrackUtility.<>c` (compiler-generated name)
- `TitanAnimationTrackUtility.<>c__DisplayClass1_0` (compiler-generated name)
- `TitanPlayer.AutoExecutionType`
- `TitanSettings.<>c` (compiler-generated name)
- `TitanUtility.<>c` (compiler-generated name)
- `TitanUtility.<>c__DisplayClass2_0` (compiler-generated name)
- `TitanUtility.<>c__DisplayClass6_0` (compiler-generated name)
- `TitanUtility.<>c__DisplayClass6_1` (compiler-generated name)
- `Token.TokenPool`
- `TrackStartTimeCache.<>c` (compiler-generated name)
- `TweenCreationContext.<>c` (compiler-generated name)
- `TweenCreationContext.<>c__DisplayClass60_0` (compiler-generated name)
- `TweenCreationContext.<>c__DisplayClass61_0` (compiler-generated name)
- `TweenCreationContext.<>c__DisplayClass63_0` (compiler-generated name)
- `TweenCreationContext.<>c__DisplayClass64_0` (compiler-generated name)
- `TweenCreationContext.<>c__DisplayClass64_1` (compiler-generated name)
- `VariableInputHandler.VariableInputType`
- `VariableTable.<>c` (compiler-generated name)
- `WorldPathTrack.<>c__DisplayClass0_0` (compiler-generated name)

</details>

<details><summary>Indeterminate: 24</summary>

- `ArrayTweenerTrackBase.<>c__DisplayClass2_0<TClipAsset, TComponent, TValue, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ColorArrayTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ColorTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FloatArrayTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FloatTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IEnumerableExtensions.IdentityFunction.<>c<TElement>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IntTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LongTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PathTrack3DBase.<>c__DisplayClass0_0<TClipAsset>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PathTrack3DBase.<>c__DisplayClass0_1<TClipAsset>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StateTrackBase.<>c__DisplayClass1_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.ComponentValueReverter<TComponent, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.ParameterBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.PathClipBase<TVector>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.TextMeshProCharClipBase<TValue, TParameter>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.TweenerClipBase<TValue, TParameter>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.TweenerTrackBase<TClipAsset, TComponent, TValue, TParameter>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TitanPlayer.<>c__DisplayClass58_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TweenerTrackBase.<>c__DisplayClass8_0<TClipAsset, TComponent, TValue, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Vector2ArrayTweenerTrackBase.<>c__DisplayClass0_0<TClipAsset, TComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Vector2TweenerTrackBase.<>c__DisplayClass1_0<TClipAsset, TComponent, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Vector3TweenerTrackBase.<>c__DisplayClass1_0<TClipAsset, TComponent, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Vector4TweenerTrackBase.<>c__DisplayClass1_0<TClipAsset, TComponent, TParameter>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=10013`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=15107`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Uguiss-Timeline.Runtime.dll

<details><summary>Matching: 60</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1463`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2349`
- `BranchData.<GetClips>d__9` (compiler-generated name)
- `BranchGroupData.<GetClips>d__15` (compiler-generated name)
- `Easing.<>c__DisplayClass54_0` (compiler-generated name)
- `Easing.<>c__DisplayClass57_0` (compiler-generated name)
- `Easing.<>c__DisplayClass60_0` (compiler-generated name)
- `Easing.<>c__DisplayClass63_0` (compiler-generated name)
- `Easing.<>c__DisplayClass66_0` (compiler-generated name)
- `Easing.<>c__DisplayClass69_0` (compiler-generated name)
- `TimelineClip.MergeData`
- `TimelineClip.WaitType`
- `TimelineManager.<>c` (compiler-generated name)
- `TimelineManager.<>c__DisplayClass57_0` (compiler-generated name)
- `TimelineManager.<UpdateGraphAsync>d__55` (compiler-generated name)
- `TimelineManager.<UpdateMixerAsync>d__57` (compiler-generated name)
- `TimelineManager.<UpdatePlayableAsync>d__59` (compiler-generated name)
- `TimelineManager.AsyncState`
- `TimelineManager.OffsetRange`
- `Uguiss.Timeline.AbstractBranchCommand`
- `Uguiss.Timeline.AbstractBranchCommand<T>`
- `Uguiss.Timeline.AbstractBranchGroupCommand`
- `Uguiss.Timeline.AbstractBranchGroupCommand<T>`
- `Uguiss.Timeline.AbstractCommandPlayableCommand`
- `Uguiss.Timeline.AbstractCommandPlayableCommand<TEngine, TCommand>`
- `Uguiss.Timeline.AbstractJSONParameter<T>`
- `Uguiss.Timeline.AbstractPlayableCommand`
- `Uguiss.Timeline.AbstractPlayableCommand<T>`
- `Uguiss.Timeline.AbstractScriptPlayableCommand<TEngine, TPlayable, TMixer>`
- `Uguiss.Timeline.AbstractTimelineCommand<T>`
- `Uguiss.Timeline.AudioTimelineElement`
- `Uguiss.Timeline.BranchData`
- `Uguiss.Timeline.BranchGroupData`
- `Uguiss.Timeline.ClipCaps`
- `Uguiss.Timeline.ClipCapsExtension`
- `Uguiss.Timeline.CommandMixerPlayable`
- `Uguiss.Timeline.CommandPlayable`
- `Uguiss.Timeline.DurationType`
- `Uguiss.Timeline.Easing`
- `Uguiss.Timeline.EasingFunction`
- `Uguiss.Timeline.EasingType`
- `Uguiss.Timeline.GetTimeOptions`
- `Uguiss.Timeline.GetTimeOptionsExtension`
- `Uguiss.Timeline.MixerPlayableBase`
- `Uguiss.Timeline.OffsetTargetsExtension`
- `Uguiss.Timeline.SkipTargets`
- `Uguiss.Timeline.TimelineClip`
- `Uguiss.Timeline.TimelineClipParameter`
- `Uguiss.Timeline.TimelineController`
- `Uguiss.Timeline.TimelineElement`
- `Uguiss.Timeline.TimelineEngine`
- `Uguiss.Timeline.TimelineEngineUtility`
- `Uguiss.Timeline.TimelineManager`
- `Uguiss.Timeline.TimelineManager<T>`
- `Uguiss.Timeline.TimelinePlayable`
- `Uguiss.Timeline.WaitMode`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>

<details><summary>Indeterminate: 3</summary>

- `AbstractTimelineCommand.<ExecuteAsync>d__0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TimelineManager.<>c__49<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Uguiss.Timeline.MixerPlayableBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 3</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=2491`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=2842`

</details>


## Uguiss.Runtime.dll

<details><summary>Matching: 81</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1576`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2305`
- `AbstractCommand.<>c__DisplayClass27_0` (compiler-generated name)
- `AbstractCommand.CommandAttribute`
- `AbstractCommand.OptionalParameterAttribute`
- `AbstractCommand.ParameterAttribute`
- `AbstractCommand.RequiredParameterAttribute`
- `CommandSetting.<>c__DisplayClass3_0` (compiler-generated name)
- `Engine.<>c__DisplayClass41_0` (compiler-generated name)
- `Engine.<ExecuteAsync>d__46` (compiler-generated name)
- `Engine.<GotoAsync>d__47` (compiler-generated name)
- `Engine.<LoadScriptAsync>d__31` (compiler-generated name)
- `Engine.<PreExecuteAsync>d__45` (compiler-generated name)
- `Engine.ScriptEndEvent`
- `Expression.<>c__DisplayClass11_0` (compiler-generated name)
- `Expression.<>c__DisplayClass12_0` (compiler-generated name)
- `Expression.ArityType`
- `Expression.AssociativityType`
- `Expression.EOFToken`
- `Expression.ErrorMessages`
- `Expression.LParenToken`
- `Expression.LiteralToken`
- `Expression.LiteralToken.<>c` (compiler-generated name)
- `Expression.OperandToken`
- `Expression.OperandType`
- `Expression.OperatorToken`
- `Expression.OperatorToken.<>c__DisplayClass1_0` (compiler-generated name)
- `Expression.OperatorToken.<>c__DisplayClass1_1` (compiler-generated name)
- `Expression.OperatorType`
- `Expression.ParenToken`
- `Expression.RParenToken`
- `Expression.Symbols`
- `Expression.Token`
- `Expression.TokenType`
- `Expression.VariableToken`
- `Parser.State`
- `Parser.Symbol`
- `Parser.Symbols`
- `SearchFilter.<>c` (compiler-generated name)
- `SearchFilter.<>c__DisplayClass8_0` (compiler-generated name)
- `SearchFilter.<>c__DisplayClass9_0` (compiler-generated name)
- `SearchFilter.ISearchTarget`
- `SearchFilter.Result`
- `SearchFilter.Result<T>`
- `SearchFilter.ResultRange`
- `Uguiss.AbstractCommand`
- `Uguiss.AbstractCommand<T>`
- `Uguiss.AbstractManager`
- `Uguiss.AbstractManager<T>`
- `Uguiss.AbstractParameter`
- `Uguiss.AbstractParameter<T>`
- `Uguiss.BoolListParameter`
- `Uguiss.BoolParameter`
- `Uguiss.CommandAlias`
- `Uguiss.CommandBuilder`
- `Uguiss.CommandInfo`
- `Uguiss.CommandListParameter`
- `Uguiss.CommandListParameter<T>`
- `Uguiss.CommandParameter`
- `Uguiss.CommandParameter<T>`
- `Uguiss.CommandSetting`
- `Uguiss.CommandType`
- `Uguiss.Engine`
- `Uguiss.Expression`
- `Uguiss.FloatListParameter`
- `Uguiss.FloatParameter`
- `Uguiss.Literal`
- `Uguiss.LiteralListParameter`
- `Uguiss.LiteralParameter`
- `Uguiss.LiteralType`
- `Uguiss.ParameterData`
- `Uguiss.Parser`
- `Uguiss.ScriptBuilder`
- `Uguiss.SearchFilter`
- `Uguiss.StringListParameter`
- `Uguiss.StringParameter`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>

<details><summary>Indeterminate: 2</summary>

- `ScriptBuilder.<>c__4<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SearchFilter.<>c__7<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 3</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=1979`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=2674`

</details>


## UniRx.dll

<details><summary>Matching: 148</summary>

- `<Module>`
- `AsObservableObservable.AsObservable<T>`
- `AsUnitObservableObservable.AsUnitObservable<T>`
- `CreateObservable.Create<T, TState>`
- `Disposable.AnonymousDisposable`
- `Disposable.EmptyDisposable`
- `DisposableExtensions.<MonitorTriggerHealth>d__2` (compiler-generated name)
- `EmptyObservable.Empty<T>`
- `FromEventObservable.FromEvent`
- `FromMicroCoroutineObservable.FromMicroCoroutine<T>`
- `MainThreadDispatcher.<>c` (compiler-generated name)
- `MainThreadDispatcher.<>c__DisplayClass6_0` (compiler-generated name)
- `MainThreadDispatcher.<RunEndOfFrameMicroCoroutine>d__33` (compiler-generated name)
- `MainThreadDispatcher.<RunFixedUpdateMicroCoroutine>d__32` (compiler-generated name)
- `MainThreadDispatcher.<RunUpdateMicroCoroutine>d__31` (compiler-generated name)
- `MainThreadDispatcher.CullingMode`
- `Observable.<>c__DisplayClass318_0` (compiler-generated name)
- `Observable.<>c__DisplayClass319_0` (compiler-generated name)
- `Observable.<EveryCycleCore>d__311` (compiler-generated name)
- `Observable.<TimerFrameCore>d__320` (compiler-generated name)
- `Observable.<TimerFrameCore>d__321` (compiler-generated name)
- `ObservableStateMachineTrigger.OnStateInfo`
- `ObservableStateMachineTrigger.OnStateMachineInfo`
- `ObserveExtensions.<EmptyEnumerator>d__3` (compiler-generated name)
- `OfTypeObservable.OfType<TSource, TResult>`
- `ReturnObservable.Return<T>`
- `Scheduler.<>c__DisplayClass11_0` (compiler-generated name)
- `Scheduler.<>c__DisplayClass11_1` (compiler-generated name)
- `Scheduler.<>c__DisplayClass12_0` (compiler-generated name)
- `Scheduler.<>c__DisplayClass12_1` (compiler-generated name)
- `Scheduler.CurrentThreadScheduler.Trampoline`
- `Scheduler.ImmediateScheduler`
- `Scheduler.MainThreadScheduler.<DelayAction>d__2` (compiler-generated name)
- `Scheduler.MainThreadScheduler.<PeriodicAction>d__3` (compiler-generated name)
- `Scheduler.ThreadPoolScheduler`
- `Scheduler.ThreadPoolScheduler.<>c__DisplayClass3_0` (compiler-generated name)
- `Scheduler.ThreadPoolScheduler.PeriodicTimer`
- `Scheduler.ThreadPoolScheduler.Timer`
- `StableCompositeDisposable.Binary`
- `StableCompositeDisposable.NAry`
- `StableCompositeDisposable.NAryUnsafe`
- `StableCompositeDisposable.Quaternary`
- `StableCompositeDisposable.Trinary`
- `Stubs.<>c` (compiler-generated name)
- `TimerObservable.<>c__DisplayClass6_0` (compiler-generated name)
- `TimerObservable.<>c__DisplayClass6_1` (compiler-generated name)
- `TimerObservable.<>c__DisplayClass6_2` (compiler-generated name)
- `TimerObservable.<>c__DisplayClass6_3` (compiler-generated name)
- `TimerObservable.Timer`
- `UniRx.BoolReactiveProperty`
- `UniRx.BooleanDisposable`
- `UniRx.CancellationDisposable`
- `UniRx.CompositeDisposable`
- `UniRx.Disposable`
- `UniRx.DisposableExtensions`
- `UniRx.FloatReactiveProperty`
- `UniRx.FrameCountType`
- `UniRx.ICancelable`
- `UniRx.IConnectableObservable<T>`
- `UniRx.IObserverLinkedList<T>`
- `UniRx.IOptimizedObservable<T>`
- `UniRx.IReactiveProperty<T>`
- `UniRx.IReadOnlyReactiveCollection<T>`
- `UniRx.IReadOnlyReactiveProperty<T>`
- `UniRx.IScheduler`
- `UniRx.ISchedulerPeriodic`
- `UniRx.IntReactiveProperty`
- `UniRx.InternalUtil.AsyncLock`
- `UniRx.InternalUtil.ExceptionExtensions`
- `UniRx.InternalUtil.ICancellableTaskCompletionSource`
- `UniRx.InternalUtil.MicroCoroutine`
- `UniRx.InternalUtil.ScheduledItem`
- `UniRx.InternalUtil.SchedulerQueue`
- `UniRx.InternalUtil.ThreadSafeQueueWorker`
- `UniRx.InternalUtil.UnityEqualityComparer`
- `UniRx.Observable`
- `UniRx.ObservableExtensions`
- `UniRx.ObserveExtensions`
- `UniRx.Observer`
- `UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, TR>`
- `UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, TR>`
- `UniRx.Operators.CombineLatestFunc<T1, T2, T3, TR>`
- `UniRx.Operators.FromEventObservable`
- `UniRx.Operators.ICombineLatestObservable`
- `UniRx.Operators.ISelect<TR>`
- `UniRx.Operators.ImmutableReturnUnitObservable`
- `UniRx.Operators.TimerObservable`
- `UniRx.OptimizedObservableExtensions`
- `UniRx.ReactivePropertyExtensions`
- `UniRx.SerialDisposable`
- `UniRx.SingleAssignmentDisposable`
- `UniRx.StableCompositeDisposable`
- `UniRx.StringReactiveProperty`
- `UniRx.Stubs`
- `UniRx.Triggers.ObservableAnimatorTrigger`
- `UniRx.Triggers.ObservableBeginDragTrigger`
- `UniRx.Triggers.ObservableCancelTrigger`
- `UniRx.Triggers.ObservableCanvasGroupChangedTrigger`
- `UniRx.Triggers.ObservableCollision2DTrigger`
- `UniRx.Triggers.ObservableCollisionTrigger`
- `UniRx.Triggers.ObservableDeselectTrigger`
- `UniRx.Triggers.ObservableDestroyTrigger`
- `UniRx.Triggers.ObservableDragTrigger`
- `UniRx.Triggers.ObservableDropTrigger`
- `UniRx.Triggers.ObservableEnableTrigger`
- `UniRx.Triggers.ObservableEndDragTrigger`
- `UniRx.Triggers.ObservableEventTrigger`
- `UniRx.Triggers.ObservableFixedUpdateTrigger`
- `UniRx.Triggers.ObservableInitializePotentialDragTrigger`
- `UniRx.Triggers.ObservableJointTrigger`
- `UniRx.Triggers.ObservableLateUpdateTrigger`
- `UniRx.Triggers.ObservableMoveTrigger`
- `UniRx.Triggers.ObservableParticleTrigger`
- `UniRx.Triggers.ObservablePointerClickTrigger`
- `UniRx.Triggers.ObservablePointerDownTrigger`
- `UniRx.Triggers.ObservablePointerEnterTrigger`
- `UniRx.Triggers.ObservablePointerExitTrigger`
- `UniRx.Triggers.ObservablePointerUpTrigger`
- `UniRx.Triggers.ObservableRectTransformTrigger`
- `UniRx.Triggers.ObservableScrollTrigger`
- `UniRx.Triggers.ObservableSelectTrigger`
- `UniRx.Triggers.ObservableStateMachineTrigger`
- `UniRx.Triggers.ObservableSubmitTrigger`
- `UniRx.Triggers.ObservableTransformChangedTrigger`
- `UniRx.Triggers.ObservableTrigger2DTrigger`
- `UniRx.Triggers.ObservableTriggerBase`
- `UniRx.Triggers.ObservableTriggerExtensions`
- `UniRx.Triggers.ObservableTriggerTrigger`
- `UniRx.Triggers.ObservableUpdateSelectedTrigger`
- `UniRx.Triggers.ObservableUpdateTrigger`
- `UniRx.Triggers.ObservableVisibleTrigger`
- `UniRx.Unit`
- `UniRx.UnityEventExtensions`
- `UniRx.UnityUIComponentExtensions`
- `UniRx.YieldInstructionCache`
- `UnityEqualityComparer.BoundsEqualityComparer`
- `UnityEqualityComparer.BoundsIntEqualityComparer`
- `UnityEqualityComparer.Color32EqualityComparer`
- `UnityEqualityComparer.ColorEqualityComparer`
- `UnityEqualityComparer.QuaternionEqualityComparer`
- `UnityEqualityComparer.RangeIntEqualityComparer`
- `UnityEqualityComparer.RectEqualityComparer`
- `UnityEqualityComparer.RectIntEqualityComparer`
- `UnityEqualityComparer.Vector2EqualityComparer`
- `UnityEqualityComparer.Vector2IntEqualityComparer`
- `UnityEqualityComparer.Vector3EqualityComparer`
- `UnityEqualityComparer.Vector3IntEqualityComparer`
- `UnityEqualityComparer.Vector4EqualityComparer`

</details>

<details><summary>Mismatching: 11</summary>

- `Observable.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__308_0'] → ['<>9', '<>9__308_0', '<>9__309_0', '<>9__310_0', '<>9__312_0', '<>9__313_0', '<>9__314_0', '<>9__315_0']`
  - `extra field static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__309_0`
  - `extra field static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__310_0`
  - `extra field static Func<long, Unit, long> <>9__312_0`
  - `extra field static Func<long, Unit, long> <>9__313_0`
  - `extra field static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__314_0`
  - `extra field static Func<IObserver<Unit>, CancellationToken, IEnumerator> <>9__315_0`

- `Scheduler.DefaultSchedulers`

  - `field declaration order/names: ['constantTime', 'tailRecursion', 'iteration', 'timeBasedOperations'] → ['constantTime', 'tailRecursion', 'iteration', 'timeBasedOperations', 'asyncConversions']`
  - `extra field static IScheduler asyncConversions`

- `Scheduler.MainThreadScheduler`

  - `bases: 'IScheduler, ISchedulerPeriodic' → 'IScheduler, ISchedulerPeriodic, ISchedulerQueueing'`

- `UniRx.BehaviorSubject<T>`

  - `bases: 'ISubject<T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>' → 'ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ISubject<T>`

  - `bases: 'IObserver<T>, IObservable<T>' → 'ISubject<T, T>, IObserver<T>, IObservable<T>'`

- `UniRx.ReactiveCollection<T>`

  - `bases: 'Collection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T>, IDisposable' → 'Collection<T>, IReactiveCollection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T>, IDisposable'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReactiveDictionary<TKey, TValue>`

  - `bases: 'IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IDisposable, ISerializable, IDeserializationCallback' → 'IReactiveDictionary<TKey, TValue>, IReadOnlyReactiveDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IDisposable, ISerializable, IDeserializationCallback'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReplaySubject<T>`

  - `bases: 'ISubject<T>, IObserver<T>, IObservable<T>, IOptimizedObservable<T>, IDisposable' → 'ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IOptimizedObservable<T>, IDisposable'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Scheduler`

  - `field declaration order/names: ['CurrentThread', 'Immediate', 'ThreadPool', 'mainThread'] → ['CurrentThread', 'Immediate', 'ThreadPool', 'mainThread', 'mainThreadIgnoreTimeScale', 'mainThreadFixedUpdate', 'mainThreadEndOfFrame']`
  - `extra field static IScheduler mainThreadIgnoreTimeScale`
  - `extra field static IScheduler mainThreadFixedUpdate`
  - `extra field static IScheduler mainThreadEndOfFrame`

- `UniRx.Subject<T>`

  - `bases: 'ISubject<T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>' → 'ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityUIComponentExtensions.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__7_0'] → ['<>9', '<>9__0_0', '<>9__3_0', '<>9__5_0', '<>9__6_0', '<>9__7_0', '<>9__8_0', '<>9__10_0', '<>9__11_0']`
  - `<>9__7_0: offset '0x8' → '0x28'`
  - `extra field static Action<string, Text> <>9__0_0`
  - `extra field static Action<bool, Selectable> <>9__3_0`
  - `extra field static Func<Toggle, IObserver<bool>, IDisposable> <>9__5_0`
  - `extra field static Func<Scrollbar, IObserver<float>, IDisposable> <>9__6_0`
  - `extra field static Func<Slider, IObserver<float>, IDisposable> <>9__8_0`
  - `extra field static Func<InputField, IObserver<string>, IDisposable> <>9__10_0`
  - `extra field static Func<Dropdown, IObserver<int>, IDisposable> <>9__11_0`


</details>

<details><summary>Indeterminate: 140</summary>

- `BehaviorSubject.Subscription<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.Buffer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferT.Buffer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferT<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferTC.<>c__DisplayClass8_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferTC<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferTS.<>c__DisplayClass9_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.BufferTS<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BufferObservable.Buffer_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest.CombineLatestObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest.LeftObserver<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest.RightObserver<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest<T1, T2, T3, T4, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest<T1, T2, T3, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CombineLatestObservable.CombineLatest<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcatObservable.Concat<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DelayFrameObservable.DelayFrame.<DrainQueue>d__14<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DelayFrameObservable.DelayFrame<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DelayFrameObservable.QueuePool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DistinctUntilChangedObservable.DistinctUntilChanged<T, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DistinctUntilChangedObservable.DistinctUntilChanged<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DoObservable.Do<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FirstObservable.First<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FirstObservable.First_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FromEventObservable.FromEvent<TDelegate, TEventArgs>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FromEventObservable.FromEvent<TDelegate>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FromEventObservable_.FromEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `MergeObservable.MergeConcurrentObserver.Merge<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `MergeObservable.MergeConcurrentObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `MergeObservable.MergeOuterObserver.Merge<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `MergeObservable.MergeOuterObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Observable.<CombineSources>d__29<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Observable.ConnectableObservable.Connection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Observable.ConnectableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObserveExtensions.<>c__DisplayClass2_0<TSource, TProperty>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObserveExtensions.<>c__DisplayClass2_1<TSource, TProperty>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObserveExtensions.<PublishPocoValueChanged>d__4<TSource, TProperty>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObserveExtensions.<PublishUnityObjectValueChanged>d__5<TSource, TProperty>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Observer.Subscribe<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Observer.Subscribe_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `OperatorObservableBase.<>c__DisplayClass3_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PairwiseObservable.Pairwise<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PriorityQueue.IndexedItem<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RefCountObservable.RefCount.<>c__DisplayClass2_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RefCountObservable.RefCount<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ReplaySubject.Subscription<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ReturnObservable.<>c__DisplayClass3_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ScheduledNotifier.<>c__DisplayClass4_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Scheduler.CurrentThreadScheduler`

  - Limitation: s_threadLocalQueue: no comparable storage offset
  - Limitation: s_clock: no comparable storage offset

- `SelectObservable.Select<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SelectObservable.Select_<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SelectWhereObservable.SelectWhere<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SkipObservable.Skip<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SkipObservable.Skip_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StartWithObservable.StartWith<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Stubs.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Subject.Subscription<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SwitchObservable.SwitchObserver.Switch<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SwitchObservable.SwitchObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThrottleFrameObservable.ThrottleFrame<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThrottleObservable.Throttle.<>c__DisplayClass9_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThrottleObservable.Throttle<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ToObservableObservable.ToObservable.<>c__DisplayClass2_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ToObservableObservable.ToObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.CollectionAddEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.CollectionMoveEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.CollectionRemoveEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.CollectionReplaceEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.DictionaryAddEvent<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.DictionaryRemoveEvent<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.DictionaryReplaceEvent<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.DisposedObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.EmptyObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.ImmutableList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.ListObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.PriorityQueue<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.InternalUtil.ThrowObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.MainThreadDispatcher`

  - Limitation: mainThreadToken: no comparable storage offset

- `UniRx.ObserverNode<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.AsObservableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.AsUnitObservableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.BufferObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObservable<T1, T2, T3, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObservable<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CombineLatestObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ConcatObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.CreateObservable<T, TState>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.DelayFrameObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.DistinctUntilChangedObservable<T, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.DistinctUntilChangedObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.DoObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.EmptyObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.FirstObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.FromEventObservable<TDelegate, TEventArgs>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.FromEventObservable<TDelegate>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.FromEventObservable_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.FromMicroCoroutineObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ImmediateReturnObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ImmutableEmptyObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.MergeObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.NthCombineLatestObserverBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.OfTypeObservable<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.OperatorObservableBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.OperatorObserverBase<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.PairwiseObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.RefCountObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ReturnObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.SelectObservable<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.SelectWhereObservable<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.SkipObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.StartWithObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.SwitchObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ThrottleFrameObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ThrottleObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.ToObservableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.WhereObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.WhereSelectObservable<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Operators.WithLatestFromObservable<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Pair<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReactiveProperty<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReadOnlyReactiveProperty<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ScheduledNotifier<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Stubs<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.TimeInterval<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEqualityComparer.Cache<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEventExtensions.<>c__1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEventExtensions.<>c__DisplayClass1_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WhereObservable.<>c__DisplayClass5_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WhereObservable.Where<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WhereObservable.Where_<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WhereSelectObservable.WhereSelect<T, TR>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WithLatestFromObservable.WithLatestFrom.LeftObserver<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WithLatestFromObservable.WithLatestFrom.RightObserver<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 500</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=14237`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=26188`
- `AggregateObservable.Aggregate<TSource, TAccumulate, TResult>`
- `AggregateObservable.Aggregate<TSource, TAccumulate>`
- `AggregateObservable.Aggregate<TSource>`
- `AmbObservable.AmbOuterObserver.Amb<T>`
- `AmbObservable.AmbOuterObserver.AmbDecisionObserver<T>`
- `AmbObservable.AmbOuterObserver.AmbState<T>`
- `AmbObservable.AmbOuterObserver<T>`
- `AsSingleUnitObservableObservable.AsSingleUnitObservable<T>`
- `AsyncMessageBroker.Subscription<T>`
- `AsyncObjectPool.<>c__DisplayClass13_0<T>` (compiler-generated name)
- `AsyncObjectPool.<>c__DisplayClass15_0<T>` (compiler-generated name)
- `AsyncObjectPool.<PreloadCore>d__16<T>` (compiler-generated name)
- `AsyncOperationExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `AsyncOperationExtensions.<>c__DisplayClass1_0<T>` (compiler-generated name)
- `AsyncOperationExtensions.<AsObservableCore>d__2<T>` (compiler-generated name)
- `AsyncReactiveCommand.<>c<T>` (compiler-generated name)
- `AsyncReactiveCommand.Subscription<T>`
- `AsyncReactiveCommandExtensions.<>c` (compiler-generated name)
- `AsyncReactiveCommandExtensions.<>c__DisplayClass4_0<T>` (compiler-generated name)
- `AsyncSubject.<>c__DisplayClass25_0<T>` (compiler-generated name)
- `AsyncSubject.AwaitObserver.<>c<T>` (compiler-generated name)
- `AsyncSubject.AwaitObserver<T>`
- `AsyncSubject.Subscription<T>`
- `BatchFrameObservable.BatchFrame`
- `BatchFrameObservable.BatchFrame.ReusableEnumerator`
- `BatchFrameObservable.BatchFrame.ReusableEnumerator<T>`
- `BatchFrameObservable.BatchFrame<T>`
- `BufferObservable.Buffer.Buffer_<TSource, TWindowBoundary>`
- `BufferObservable.Buffer<TSource, TWindowBoundary>`
- `CastObservable.Cast<TSource, TResult>`
- `CatchObservable.Catch<T, TException>`
- `CatchObservable.Catch<T>`
- `CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, T6, T7, TR>`
- `CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, T6, TR>`
- `ConcatObservable.<CombineSources>d__3<T>` (compiler-generated name)
- `ContinueWithObservable.ContinueWith<TSource, TResult>`
- `CoroutineAsyncBridge.<Run>d__7<T>` (compiler-generated name)
- `CoroutineAsyncBridge.<Run>d__8<T>` (compiler-generated name)
- `CountNotifier.<>c__DisplayClass10_0` (compiler-generated name)
- `CreateObservable.Create<T>`
- `CreateSafeObservable.CreateSafe<T>`
- `DefaultIfEmptyObservable.DefaultIfEmpty<T>`
- `DeferObservable.Defer<T>`
- `DelayFrameSubscriptionObservable.<>c<T>` (compiler-generated name)
- `DelayObservable.Delay<T>`
- `DelaySubscriptionObservable.<>c__DisplayClass6_0<T>` (compiler-generated name)
- `DelaySubscriptionObservable.<>c__DisplayClass6_1<T>` (compiler-generated name)
- `DelaySubscriptionObservable.<>c__DisplayClass6_2<T>` (compiler-generated name)
- `DematerializeObservable.Dematerialize<T>`
- `Disposable.AnonymousDisposable<T>`
- `DistinctObservable.Distinct<T, TKey>`
- `DistinctObservable.Distinct<T>`
- `DoObserverObservable.Do<T>`
- `DoOnCancelObservable.DoOnCancel<T>`
- `DoOnCompletedObservable.DoOnCompleted<T>`
- `DoOnErrorObservable.DoOnError<T>`
- `DoOnSubscribeObservable.DoOnSubscribe<T>`
- `DoOnTerminateObservable.DoOnTerminate<T>`
- `FinallyObservable.Finally<T>`
- `ForEachAsyncObservable.ForEachAsync<T>`
- `ForEachAsyncObservable.ForEachAsync_<T>`
- `FrameIntervalObservable.FrameInterval<T>`
- `FrameTimeIntervalObservable.FrameTimeInterval<T>`
- `FromCoroutineObservable.FromCoroutine<T>`
- `FromEventPatternObservable.FromEventPattern<TDelegate, TEventArgs>`
- `GroupByObservable.GroupBy<TSource, TKey, TElement>`
- `IgnoreElementsObservable.IgnoreElements<T>`
- `LastObservable.Last<T>`
- `LastObservable.Last_<T>`
- `MaterializeObservable.Materialize<T>`
- `Notification.<>c__DisplayClass21_0<T>` (compiler-generated name)
- `Notification.<>c__DisplayClass21_1<T>` (compiler-generated name)
- `Notification.OnCompletedNotification<T>`
- `Notification.OnErrorNotification<T>`
- `Notification.OnNextNotification<T>`
- `ObjectPool.<>c__DisplayClass14_0<T>` (compiler-generated name)
- `ObjectPool.<>c__DisplayClass15_0<T>` (compiler-generated name)
- `ObjectPool.<PreloadCore>d__16<T>` (compiler-generated name)
- `Observable.<>c__342<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass0_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass13_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass142_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass142_1<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass144_0` (compiler-generated name)
- `Observable.<>c__DisplayClass144_1` (compiler-generated name)
- `Observable.<>c__DisplayClass149_0<TSource, TException>` (compiler-generated name)
- `Observable.<>c__DisplayClass157_0<TSource, TException>` (compiler-generated name)
- `Observable.<>c__DisplayClass157_1<TSource, TException>` (compiler-generated name)
- `Observable.<>c__DisplayClass163_0<TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass163_1<TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass164_0<T1, TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass164_1<T1, TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass165_0<T1, T2, TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass165_1<T1, T2, TResult>` (compiler-generated name)
- `Observable.<>c__DisplayClass166_0` (compiler-generated name)
- `Observable.<>c__DisplayClass167_0<T1>` (compiler-generated name)
- `Observable.<>c__DisplayClass168_0<T1, T2>` (compiler-generated name)
- `Observable.<>c__DisplayClass246_0<T, TR>` (compiler-generated name)
- `Observable.<>c__DisplayClass248_0<T, TR>` (compiler-generated name)
- `Observable.<>c__DisplayClass287_0` (compiler-generated name)
- `Observable.<>c__DisplayClass288_0` (compiler-generated name)
- `Observable.<>c__DisplayClass289_0` (compiler-generated name)
- `Observable.<>c__DisplayClass290_0` (compiler-generated name)
- `Observable.<>c__DisplayClass292_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass293_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass295_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass296_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass300_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass301_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass302_0<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass302_1<T>` (compiler-generated name)
- `Observable.<>c__DisplayClass303_0` (compiler-generated name)
- `Observable.<NextFrameCore>d__316` (compiler-generated name)
- `Observable.<RepeatInfinite>d__130<T>` (compiler-generated name)
- `Observable.<ToAwaitableEnumerator>d__336<T>` (compiler-generated name)
- `Observable.<WrapEnumerator>d__291` (compiler-generated name)
- `Observable.<WrapEnumeratorYieldValue>d__294<T>` (compiler-generated name)
- `Observable.<WrapToCancellableEnumerator>d__297<T>` (compiler-generated name)
- `Observable.EveryAfterUpdateInvoker`
- `ObservableWWW.<>c__DisplayClass0_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass10_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass11_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass12_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass13_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass14_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass15_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass16_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass17_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass18_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass1_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass2_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass3_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass4_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass5_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass6_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass7_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass8_0` (compiler-generated name)
- `ObservableWWW.<>c__DisplayClass9_0` (compiler-generated name)
- `ObservableWWW.<Fetch>d__20` (compiler-generated name)
- `ObservableWWW.<FetchAssetBundle>d__23` (compiler-generated name)
- `ObservableWWW.<FetchBytes>d__22` (compiler-generated name)
- `ObservableWWW.<FetchText>d__21` (compiler-generated name)
- `ObservableYieldInstruction.ToYieldInstruction<T>`
- `ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<T>` (compiler-generated name)
- `ObserveOnObservable.ObserveOn.SchedulableAction<T>`
- `ObserveOnObservable.ObserveOn<T>`
- `ObserveOnObservable.ObserveOn_<T>`
- `Observer.AnonymousObserver<T>`
- `Observer.AutoDetachObserver<T>`
- `Observer.EmptyOnNextAnonymousObserver<T>`
- `Observer.Subscribe<T, TState1, TState2, TState3>`
- `Observer.Subscribe<T, TState1, TState2>`
- `Observer.Subscribe<T, TState>`
- `PairwiseObservable.Pairwise<T, TR>`
- `RangeObservable.<>c__DisplayClass4_0` (compiler-generated name)
- `RangeObservable.Range`
- `ReactiveCommand.<>c<T>` (compiler-generated name)
- `ReactiveCommandExtensions.<>c` (compiler-generated name)
- `ReactiveCommandExtensions.<>c__DisplayClass4_0<T>` (compiler-generated name)
- `ReactivePropertyExtensions.<>c` (compiler-generated name)
- `ReactivePropertyExtensions.<>c__DisplayClass5_0<T>` (compiler-generated name)
- `ReactivePropertyExtensions.<>c__DisplayClass5_1<T>` (compiler-generated name)
- `RefCountDisposable.InnerDisposable`
- `RepeatObservable.<>c__DisplayClass4_0<T>` (compiler-generated name)
- `RepeatObservable.<>c__DisplayClass4_1<T>` (compiler-generated name)
- `RepeatObservable.Repeat<T>`
- `RepeatSafeObservable.RepeatSafe<T>`
- `RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<T>` (compiler-generated name)
- `RepeatUntilObservable.RepeatUntil<T>`
- `SampleFrameObservable.SampleFrame.SampleFrameTick<T>`
- `SampleFrameObservable.SampleFrame<T>`
- `SampleObservable.Sample.SampleTick<T, T2>`
- `SampleObservable.Sample<T, T2>`
- `SampleObservable.Sample<T>`
- `ScanObservable.Scan<TSource, TAccumulate>`
- `ScanObservable.Scan<TSource>`
- `ScheduledNotifier.<>c__DisplayClass5_0<T>` (compiler-generated name)
- `ScheduledNotifier.<>c__DisplayClass6_0<T>` (compiler-generated name)
- `Scheduler.<>c__DisplayClass13_0` (compiler-generated name)
- `Scheduler.<>c__DisplayClass13_1` (compiler-generated name)
- `Scheduler.EndOfFrameMainThreadScheduler`
- `Scheduler.EndOfFrameMainThreadScheduler.<DelayAction>d__2` (compiler-generated name)
- `Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<T>` (compiler-generated name)
- `Scheduler.EndOfFrameMainThreadScheduler.<PeriodicAction>d__3` (compiler-generated name)
- `Scheduler.FixedUpdateMainThreadScheduler`
- `Scheduler.FixedUpdateMainThreadScheduler.<DelayAction>d__2` (compiler-generated name)
- `Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<T>` (compiler-generated name)
- `Scheduler.FixedUpdateMainThreadScheduler.<PeriodicAction>d__3` (compiler-generated name)
- `Scheduler.IgnoreTimeScaleMainThreadScheduler`
- `Scheduler.IgnoreTimeScaleMainThreadScheduler.<DelayAction>d__2` (compiler-generated name)
- `Scheduler.IgnoreTimeScaleMainThreadScheduler.<PeriodicAction>d__3` (compiler-generated name)
- `Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<T>`
- `Scheduler.MainThreadScheduler.QueuedAction<T>`
- `Scheduler.ThreadPoolScheduler.<>c__DisplayClass7_0<T>` (compiler-generated name)
- `SelectManyObservable.SelectManyEnumerableObserver<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyEnumerableObserver<TSource, TResult>`
- `SelectManyObservable.SelectManyEnumerableObserverWithIndex<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyEnumerableObserverWithIndex<TSource, TResult>`
- `SelectManyObservable.SelectManyObserverWithIndex.SelectMany<TSource, TResult>`
- `SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyObserverWithIndex<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyObserverWithIndex<TSource, TResult>`
- `SelectManyObservable.SelectManyOuterObserver.SelectMany<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyOuterObserver.SelectMany<TSource, TResult>`
- `SelectManyObservable.SelectManyOuterObserver<TSource, TCollection, TResult>`
- `SelectManyObservable.SelectManyOuterObserver<TSource, TResult>`
- `SingleObservable.Single<T>`
- `SingleObservable.Single_<T>`
- `SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther>`
- `SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<T, TOther>`
- `SkipUntilObservable.SkipUntilOuterObserver<T, TOther>`
- `SkipWhileObservable.SkipWhile<T>`
- `SkipWhileObservable.SkipWhile_<T>`
- `StartObservable.StartObserver<T>`
- `Stubs.<>c<T1, T2, T3>` (compiler-generated name)
- `Stubs.<>c<T1, T2>` (compiler-generated name)
- `SubjectExtensions.AnonymousSubject<T, U>`
- `SubjectExtensions.AnonymousSubject<T>`
- `SubscribeOnMainThreadObservable.<>c<T>` (compiler-generated name)
- `SubscribeOnObservable.<>c__DisplayClass3_0<T>` (compiler-generated name)
- `SynchronizeObservable.Synchronize<T>`
- `TakeLastObservable.TakeLast<T>`
- `TakeLastObservable.TakeLast_<T>`
- `TakeObservable.Take<T>`
- `TakeObservable.Take_<T>`
- `TakeUntilObservable.TakeUntil.TakeUntilOther<T, TOther>`
- `TakeUntilObservable.TakeUntil<T, TOther>`
- `TakeWhileObservable.TakeWhile<T>`
- `TakeWhileObservable.TakeWhile_<T>`
- `TaskObservableExtensions.<>c__DisplayClass15_0<TResult>` (compiler-generated name)
- `TaskObservableExtensions.<>c__DisplayClass3_0` (compiler-generated name)
- `TaskObservableExtensions.<>c__DisplayClass8_0<TResult>` (compiler-generated name)
- `ThrottleFirstFrameObservable.ThrottleFirstFrame.ThrottleFirstFrameTick<T>`
- `ThrottleFirstFrameObservable.ThrottleFirstFrame<T>`
- `ThrottleFirstObservable.ThrottleFirst<T>`
- `ThrowObservable.<>c__DisplayClass3_0<T>` (compiler-generated name)
- `ThrowObservable.Throw<T>`
- `TimeIntervalObservable.TimeInterval<T>`
- `TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<T>`
- `TimeoutFrameObservable.TimeoutFrame<T>`
- `TimeoutObservable.Timeout.<>c__DisplayClass8_0<T>` (compiler-generated name)
- `TimeoutObservable.Timeout<T>`
- `TimeoutObservable.Timeout_<T>`
- `TimestampObservable.Timestamp<T>`
- `ToArrayObservable.ToArray<TSource>`
- `ToListObservable.ToList<TSource>`
- `UniRx.AnimationCurveReactiveProperty`
- `UniRx.AsyncMessageBroker`
- `UniRx.AsyncOperationExtensions`
- `UniRx.AsyncReactiveCommand`
- `UniRx.AsyncReactiveCommand<T>`
- `UniRx.AsyncReactiveCommandExtensions`
- `UniRx.AsyncSubject<T>`
- `UniRx.BooleanNotifier`
- `UniRx.BoundsReactiveProperty`
- `UniRx.ByteReactiveProperty`
- `UniRx.ColorReactiveProperty`
- `UniRx.CoroutineAsyncBridge`
- `UniRx.CoroutineAsyncBridge<T>`
- `UniRx.CoroutineAsyncExtensions`
- `UniRx.CountChangedStatus`
- `UniRx.CountNotifier`
- `UniRx.Diagnostics.LogEntry`
- `UniRx.Diagnostics.LogEntryExtensions`
- `UniRx.Diagnostics.Logger`
- `UniRx.Diagnostics.ObservableDebugExtensions`
- `UniRx.Diagnostics.ObservableLogger`
- `UniRx.Diagnostics.UnityDebugSink`
- `UniRx.DictionaryDisposable<TKey, TValue>`
- `UniRx.DoubleReactiveProperty`
- `UniRx.EventPattern<TEventArgs>`
- `UniRx.EventPattern<TSender, TEventArgs>`
- `UniRx.FrameCountTypeExtensions`
- `UniRx.FrameInterval<T>`
- `UniRx.IAsyncMessageBroker`
- `UniRx.IAsyncMessagePublisher`
- `UniRx.IAsyncMessageReceiver`
- `UniRx.IAsyncReactiveCommand<T>`
- `UniRx.ICustomYieldInstructionErrorHandler`
- `UniRx.IEventPattern<TSender, TEventArgs>`
- `UniRx.IGroupedObservable<TKey, TElement>`
- `UniRx.IMessageBroker`
- `UniRx.IMessagePublisher`
- `UniRx.IMessageReceiver`
- `UniRx.IObserver<TValue, TResult>`
- `UniRx.IReactiveCollection<T>`
- `UniRx.IReactiveCommand<T>`
- `UniRx.IReactiveDictionary<TKey, TValue>`
- `UniRx.IReadOnlyReactiveDictionary<TKey, TValue>`
- `UniRx.ISchedulerLongRunning`
- `UniRx.ISchedulerQueueing`
- `UniRx.ISubject<TSource, TResult>`
- `UniRx.InspectorDisplayAttribute`
- `UniRx.InternalUtil.CancellableTaskCompletionSource<T>`
- `UniRx.InternalUtil.PromiseHelper`
- `UniRx.LongReactiveProperty`
- `UniRx.MainThreadDispatchType`
- `UniRx.MessageBroker`
- `UniRx.MultilineReactivePropertyAttribute`
- `UniRx.MultipleAssignmentDisposable`
- `UniRx.Notification`
- `UniRx.Notification<T>`
- `UniRx.NotificationKind`
- `UniRx.ObservableWWW`
- `UniRx.ObservableYieldInstruction<T>`
- `UniRx.ObserverExtensions`
- `UniRx.Operators.AggregateObservable<TSource, TAccumulate, TResult>`
- `UniRx.Operators.AggregateObservable<TSource, TAccumulate>`
- `UniRx.Operators.AggregateObservable<TSource>`
- `UniRx.Operators.AmbObservable<T>`
- `UniRx.Operators.AsSingleUnitObservableObservable<T>`
- `UniRx.Operators.BatchFrameObservable`
- `UniRx.Operators.BatchFrameObservable<T>`
- `UniRx.Operators.BufferObservable<TSource, TWindowBoundary>`
- `UniRx.Operators.CastObservable<TSource, TResult>`
- `UniRx.Operators.CatchObservable<T, TException>`
- `UniRx.Operators.CatchObservable<T>`
- `UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.ContinueWithObservable<TSource, TResult>`
- `UniRx.Operators.CreateObservable<T>`
- `UniRx.Operators.CreateSafeObservable<T>`
- `UniRx.Operators.DefaultIfEmptyObservable<T>`
- `UniRx.Operators.DeferObservable<T>`
- `UniRx.Operators.DelayFrameSubscriptionObservable<T>`
- `UniRx.Operators.DelayObservable<T>`
- `UniRx.Operators.DelaySubscriptionObservable<T>`
- `UniRx.Operators.DematerializeObservable<T>`
- `UniRx.Operators.DistinctObservable<T, TKey>`
- `UniRx.Operators.DistinctObservable<T>`
- `UniRx.Operators.DoObserverObservable<T>`
- `UniRx.Operators.DoOnCancelObservable<T>`
- `UniRx.Operators.DoOnCompletedObservable<T>`
- `UniRx.Operators.DoOnErrorObservable<T>`
- `UniRx.Operators.DoOnSubscribeObservable<T>`
- `UniRx.Operators.DoOnTerminateObservable<T>`
- `UniRx.Operators.FinallyObservable<T>`
- `UniRx.Operators.ForEachAsyncObservable<T>`
- `UniRx.Operators.FrameIntervalObservable<T>`
- `UniRx.Operators.FrameTimeIntervalObservable<T>`
- `UniRx.Operators.FromCoroutineObservable<T>`
- `UniRx.Operators.FromEventPatternObservable<TDelegate, TEventArgs>`
- `UniRx.Operators.GroupByObservable<TSource, TKey, TElement>`
- `UniRx.Operators.GroupedObservable<TKey, TElement>`
- `UniRx.Operators.IZipLatestObservable`
- `UniRx.Operators.IZipObservable`
- `UniRx.Operators.IgnoreElementsObservable<T>`
- `UniRx.Operators.ImmutableNeverObservable<T>`
- `UniRx.Operators.ImmutableReturnFalseObservable`
- `UniRx.Operators.ImmutableReturnInt32Observable`
- `UniRx.Operators.ImmutableReturnTrueObservable`
- `UniRx.Operators.LastObservable<T>`
- `UniRx.Operators.MaterializeObservable<T>`
- `UniRx.Operators.NeverObservable<T>`
- `UniRx.Operators.NthZipLatestObserverBase<T>`
- `UniRx.Operators.NthZipObserverBase<T>`
- `UniRx.Operators.ObserveOnObservable<T>`
- `UniRx.Operators.PairwiseObservable<T, TR>`
- `UniRx.Operators.RangeObservable`
- `UniRx.Operators.RepeatObservable<T>`
- `UniRx.Operators.RepeatSafeObservable<T>`
- `UniRx.Operators.RepeatUntilObservable<T>`
- `UniRx.Operators.SampleFrameObservable<T>`
- `UniRx.Operators.SampleObservable<T, T2>`
- `UniRx.Operators.SampleObservable<T>`
- `UniRx.Operators.ScanObservable<TSource, TAccumulate>`
- `UniRx.Operators.ScanObservable<TSource>`
- `UniRx.Operators.SelectManyObservable<TSource, TCollection, TResult>`
- `UniRx.Operators.SelectManyObservable<TSource, TResult>`
- `UniRx.Operators.SingleObservable<T>`
- `UniRx.Operators.SkipUntilObservable<T, TOther>`
- `UniRx.Operators.SkipWhileObservable<T>`
- `UniRx.Operators.StartObservable<T>`
- `UniRx.Operators.SubscribeOnMainThreadObservable<T>`
- `UniRx.Operators.SubscribeOnObservable<T>`
- `UniRx.Operators.SynchronizeObservable<T>`
- `UniRx.Operators.SynchronizedObserver<T>`
- `UniRx.Operators.TakeLastObservable<T>`
- `UniRx.Operators.TakeObservable<T>`
- `UniRx.Operators.TakeUntilObservable<T, TOther>`
- `UniRx.Operators.TakeWhileObservable<T>`
- `UniRx.Operators.ThrottleFirstFrameObservable<T>`
- `UniRx.Operators.ThrottleFirstObservable<T>`
- `UniRx.Operators.ThrowObservable<T>`
- `UniRx.Operators.TimeIntervalObservable<T>`
- `UniRx.Operators.TimeoutFrameObservable<T>`
- `UniRx.Operators.TimeoutObservable<T>`
- `UniRx.Operators.TimestampObservable<T>`
- `UniRx.Operators.ToArrayObservable<TSource>`
- `UniRx.Operators.ToListObservable<TSource>`
- `UniRx.Operators.Wait<T>`
- `UniRx.Operators.WhenAllObservable`
- `UniRx.Operators.WhenAllObservable<T>`
- `UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.ZipFunc<T1, T2, T3, T4, T5, TR>`
- `UniRx.Operators.ZipFunc<T1, T2, T3, T4, TR>`
- `UniRx.Operators.ZipFunc<T1, T2, T3, TR>`
- `UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, T5, TR>`
- `UniRx.Operators.ZipLatestFunc<T1, T2, T3, T4, TR>`
- `UniRx.Operators.ZipLatestFunc<T1, T2, T3, TR>`
- `UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, T5, TR>`
- `UniRx.Operators.ZipLatestObservable<T1, T2, T3, T4, TR>`
- `UniRx.Operators.ZipLatestObservable<T1, T2, T3, TR>`
- `UniRx.Operators.ZipLatestObservable<T>`
- `UniRx.Operators.ZipLatestObservable<TLeft, TRight, TResult>`
- `UniRx.Operators.ZipLatestObserver<T>`
- `UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR>`
- `UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, T6, TR>`
- `UniRx.Operators.ZipObservable<T1, T2, T3, T4, T5, TR>`
- `UniRx.Operators.ZipObservable<T1, T2, T3, T4, TR>`
- `UniRx.Operators.ZipObservable<T1, T2, T3, TR>`
- `UniRx.Operators.ZipObservable<T>`
- `UniRx.Operators.ZipObservable<TLeft, TRight, TResult>`
- `UniRx.Operators.ZipObserver<T>`
- `UniRx.QuaternionReactiveProperty`
- `UniRx.RangeReactivePropertyAttribute`
- `UniRx.ReactiveCollectionExtensions`
- `UniRx.ReactiveCommand`
- `UniRx.ReactiveCommand<T>`
- `UniRx.ReactiveCommandExtensions`
- `UniRx.ReactiveDictionaryExtensions`
- `UniRx.RectReactiveProperty`
- `UniRx.RefCountDisposable`
- `UniRx.ScheduledDisposable`
- `UniRx.Stubs<T1, T2, T3>`
- `UniRx.Stubs<T1, T2>`
- `UniRx.SubjectExtensions`
- `UniRx.TaskObservableExtensions`
- `UniRx.Timestamped`
- `UniRx.Timestamped<T>`
- `UniRx.Toolkit.AsyncObjectPool<T>`
- `UniRx.Toolkit.ObjectPool<T>`
- `UniRx.UnityGraphicExtensions`
- `UniRx.Vector2ReactiveProperty`
- `UniRx.Vector3ReactiveProperty`
- `UniRx.Vector4ReactiveProperty`
- `UniRx.WWWErrorException`
- `UniRx.WebRequestExtensions`
- `UnityEventExtensions.<>c` (compiler-generated name)
- `UnityEventExtensions.<>c__2<T0, T1>` (compiler-generated name)
- `UnityEventExtensions.<>c__3<T0, T1, T2>` (compiler-generated name)
- `UnityEventExtensions.<>c__4<T0, T1, T2, T3>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass2_0<T0, T1>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass2_1<T0, T1>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass3_0<T0, T1, T2>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass3_1<T0, T1, T2>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass4_0<T0, T1, T2, T3>` (compiler-generated name)
- `UnityEventExtensions.<>c__DisplayClass4_1<T0, T1, T2, T3>` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass0_1` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass1_0` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass1_1` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass2_0` (compiler-generated name)
- `UnityGraphicExtensions.<>c__DisplayClass2_1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `UnityUIComponentExtensions.<>c__1<T>` (compiler-generated name)
- `UnityUIComponentExtensions.<>c__2<T>` (compiler-generated name)
- `WebRequestExtensions.<>c__DisplayClass0_0<TResult>` (compiler-generated name)
- `WebRequestExtensions.<>c__DisplayClass0_1<TResult>` (compiler-generated name)
- `WebRequestExtensions.<>c__DisplayClass2_0` (compiler-generated name)
- `WhenAllObservable.WhenAll`
- `WhenAllObservable.WhenAll.WhenAllCollectionObserver`
- `WhenAllObservable.WhenAll.WhenAllCollectionObserver<T>`
- `WhenAllObservable.WhenAll<T>`
- `WhenAllObservable.WhenAll_`
- `WhenAllObservable.WhenAll_.WhenAllCollectionObserver`
- `WhenAllObservable.WhenAll_.WhenAllCollectionObserver<T>`
- `WhenAllObservable.WhenAll_<T>`
- `ZipLatestObservable.ZipLatest.LeftObserver<TLeft, TRight, TResult>`
- `ZipLatestObservable.ZipLatest.RightObserver<TLeft, TRight, TResult>`
- `ZipLatestObservable.ZipLatest.ZipLatestObserver<T>`
- `ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR>`
- `ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, T6, TR>`
- `ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, TR>`
- `ZipLatestObservable.ZipLatest<T1, T2, T3, T4, TR>`
- `ZipLatestObservable.ZipLatest<T1, T2, T3, TR>`
- `ZipLatestObservable.ZipLatest<T>`
- `ZipLatestObservable.ZipLatest<TLeft, TRight, TResult>`
- `ZipObservable.Zip.LeftZipObserver<TLeft, TRight, TResult>`
- `ZipObservable.Zip.RightZipObserver<TLeft, TRight, TResult>`
- `ZipObservable.Zip.ZipObserver<T>`
- `ZipObservable.Zip<T1, T2, T3, T4, T5, T6, T7, TR>`
- `ZipObservable.Zip<T1, T2, T3, T4, T5, T6, TR>`
- `ZipObservable.Zip<T1, T2, T3, T4, T5, TR>`
- `ZipObservable.Zip<T1, T2, T3, T4, TR>`
- `ZipObservable.Zip<T1, T2, T3, TR>`
- `ZipObservable.Zip<T>`
- `ZipObservable.Zip<TLeft, TRight, TResult>`

</details>


## UniTask.Linq.dll

<details><summary>Matching: 5</summary>

- `<Module>`
- `Cysharp.Threading.Tasks.Linq.CancellationTokenDisposable`
- `Cysharp.Threading.Tasks.Linq.Subscribe`
- `Cysharp.Threading.Tasks.Linq.UniTaskAsyncEnumerable`
- `Subscribe.<>c` (compiler-generated name)

</details>

<details><summary>Indeterminate: 3</summary>

- `Cysharp.Threading.Tasks.Linq.ToUniTaskAsyncEnumerableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Subscribe.<SubscribeAwaitCore>d__6<TSource>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ToUniTaskAsyncEnumerableObservable._ToUniTaskAsyncEnumerableObservable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 562</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=17792`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3707`
- `Aggregate.<AggregateAsync>d__0<TSource>` (compiler-generated name)
- `Aggregate.<AggregateAsync>d__1<TSource, TAccumulate>` (compiler-generated name)
- `Aggregate.<AggregateAsync>d__2<TSource, TAccumulate, TResult>` (compiler-generated name)
- `Aggregate.<AggregateAwaitAsync>d__3<TSource>` (compiler-generated name)
- `Aggregate.<AggregateAwaitAsync>d__4<TSource, TAccumulate>` (compiler-generated name)
- `Aggregate.<AggregateAwaitAsync>d__5<TSource, TAccumulate, TResult>` (compiler-generated name)
- `Aggregate.<AggregateAwaitWithCancellationAsync>d__6<TSource>` (compiler-generated name)
- `Aggregate.<AggregateAwaitWithCancellationAsync>d__7<TSource, TAccumulate>` (compiler-generated name)
- `Aggregate.<AggregateAwaitWithCancellationAsync>d__8<TSource, TAccumulate, TResult>` (compiler-generated name)
- `All.<AllAsync>d__0<TSource>` (compiler-generated name)
- `All.<AllAwaitAsync>d__1<TSource>` (compiler-generated name)
- `All.<AllAwaitWithCancellationAsync>d__2<TSource>` (compiler-generated name)
- `Any.<AnyAsync>d__0<TSource>` (compiler-generated name)
- `Any.<AnyAsync>d__1<TSource>` (compiler-generated name)
- `Any.<AnyAwaitAsync>d__2<TSource>` (compiler-generated name)
- `Any.<AnyAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `AppendPrepend._AppendPrepend.State<TSource>`
- `AppendPrepend._AppendPrepend<TSource>`
- `AsyncEnumerableSorter.<SortAsync>d__2<TElement>` (compiler-generated name)
- `AsyncSelectorEnumerableSorter.<ComputeKeysAsync>d__6<TElement, TKey>` (compiler-generated name)
- `AsyncSelectorWithCancellationEnumerableSorter.<ComputeKeysAsync>d__7<TElement, TKey>` (compiler-generated name)
- `Average.<AverageAsync>d__0` (compiler-generated name)
- `Average.<AverageAsync>d__12` (compiler-generated name)
- `Average.<AverageAsync>d__13<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__16` (compiler-generated name)
- `Average.<AverageAsync>d__17<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__1<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__20` (compiler-generated name)
- `Average.<AverageAsync>d__21<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__24` (compiler-generated name)
- `Average.<AverageAsync>d__25<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__28` (compiler-generated name)
- `Average.<AverageAsync>d__29<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__32` (compiler-generated name)
- `Average.<AverageAsync>d__33<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__36` (compiler-generated name)
- `Average.<AverageAsync>d__37<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__4` (compiler-generated name)
- `Average.<AverageAsync>d__5<TSource>` (compiler-generated name)
- `Average.<AverageAsync>d__8` (compiler-generated name)
- `Average.<AverageAsync>d__9<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__10<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__14<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__18<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__22<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__26<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__2<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__30<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__34<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__38<TSource>` (compiler-generated name)
- `Average.<AverageAwaitAsync>d__6<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__11<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__15<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__19<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__23<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__27<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__31<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__35<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__39<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `Average.<AverageAwaitWithCancellationAsync>d__7<TSource>` (compiler-generated name)
- `Buffer._Buffer<TSource>`
- `BufferSkip._BufferSkip<TSource>`
- `Cast._Cast<TResult>`
- `CombineLatest._CombineLatest.<DisposeAsync>d__107<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__115<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__123<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__131<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__27<T1, T2, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__35<T1, T2, T3, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__43<T1, T2, T3, T4, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__51<T1, T2, T3, T4, T5, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__59<T1, T2, T3, T4, T5, T6, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__67<T1, T2, T3, T4, T5, T6, T7, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__75<T1, T2, T3, T4, T5, T6, T7, T8, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__83<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__91<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest.<DisposeAsync>d__99<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>` (compiler-generated name)
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, T7, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, T6, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, T5, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, T4, TResult>`
- `CombineLatest._CombineLatest<T1, T2, T3, TResult>`
- `CombineLatest._CombineLatest<T1, T2, TResult>`
- `Concat._Concat.<RunSecondAfterDisposeAsync>d__16<TSource>` (compiler-generated name)
- `Concat._Concat.IteratingState<TSource>`
- `Concat._Concat<TSource>`
- `Contains.<ContainsAsync>d__0<TSource>` (compiler-generated name)
- `Count.<CountAsync>d__0<TSource>` (compiler-generated name)
- `Count.<CountAsync>d__1<TSource>` (compiler-generated name)
- `Count.<CountAwaitAsync>d__2<TSource>` (compiler-generated name)
- `Count.<CountAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `Create.AsyncWriter<T>`
- `Create._Create.<RunWriterTask>d__12<T>` (compiler-generated name)
- `Create._Create<T>`
- `Cysharp.Threading.Tasks.Linq.Aggregate`
- `Cysharp.Threading.Tasks.Linq.All`
- `Cysharp.Threading.Tasks.Linq.Any`
- `Cysharp.Threading.Tasks.Linq.AppendPrepend<TSource>`
- `Cysharp.Threading.Tasks.Linq.AsyncEnumerableSorter<TElement>`
- `Cysharp.Threading.Tasks.Linq.AsyncEnumeratorAwaitSelectorBase<TSource, TResult, TAwait>`
- `Cysharp.Threading.Tasks.Linq.AsyncEnumeratorBase<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.AsyncSelectorEnumerableSorter<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.AsyncSelectorWithCancellationEnumerableSorter<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.Average`
- `Cysharp.Threading.Tasks.Linq.Buffer<TSource>`
- `Cysharp.Threading.Tasks.Linq.BufferSkip<TSource>`
- `Cysharp.Threading.Tasks.Linq.Cast<TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, T7, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, T6, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, T5, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, T4, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, T3, TResult>`
- `Cysharp.Threading.Tasks.Linq.CombineLatest<T1, T2, TResult>`
- `Cysharp.Threading.Tasks.Linq.Concat<TSource>`
- `Cysharp.Threading.Tasks.Linq.Contains`
- `Cysharp.Threading.Tasks.Linq.Count`
- `Cysharp.Threading.Tasks.Linq.Create<T>`
- `Cysharp.Threading.Tasks.Linq.DefaultIfEmpty<TSource>`
- `Cysharp.Threading.Tasks.Linq.Distinct<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.Distinct<TSource>`
- `Cysharp.Threading.Tasks.Linq.DistinctAwait<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.DistinctAwaitWithCancellation<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.DistinctUntilChanged<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.DistinctUntilChanged<TSource>`
- `Cysharp.Threading.Tasks.Linq.DistinctUntilChangedAwait<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.DistinctUntilChangedAwaitWithCancellation<TSource, TKey>`
- `Cysharp.Threading.Tasks.Linq.Do<TSource>`
- `Cysharp.Threading.Tasks.Linq.ElementAt`
- `Cysharp.Threading.Tasks.Linq.Empty<T>`
- `Cysharp.Threading.Tasks.Linq.EveryUpdate`
- `Cysharp.Threading.Tasks.Linq.EveryValueChangedStandardObject<TTarget, TProperty>`
- `Cysharp.Threading.Tasks.Linq.EveryValueChangedUnityObject<TTarget, TProperty>`
- `Cysharp.Threading.Tasks.Linq.Except<TSource>`
- `Cysharp.Threading.Tasks.Linq.First`
- `Cysharp.Threading.Tasks.Linq.ForEach`
- `Cysharp.Threading.Tasks.Linq.GroupBy<TSource, TKey, TElement, TResult>`
- `Cysharp.Threading.Tasks.Linq.GroupBy<TSource, TKey, TElement>`
- `Cysharp.Threading.Tasks.Linq.GroupByAwait<TSource, TKey, TElement, TResult>`
- `Cysharp.Threading.Tasks.Linq.GroupByAwait<TSource, TKey, TElement>`
- `Cysharp.Threading.Tasks.Linq.GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>`
- `Cysharp.Threading.Tasks.Linq.GroupByAwaitWithCancellation<TSource, TKey, TElement>`
- `Cysharp.Threading.Tasks.Linq.GroupJoin<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.GroupJoinAwait<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.GroupJoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>`
- `Cysharp.Threading.Tasks.Linq.Intersect<TSource>`
- `Cysharp.Threading.Tasks.Linq.Join<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.JoinAwait<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.JoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>`
- `Cysharp.Threading.Tasks.Linq.Last`
- `Cysharp.Threading.Tasks.Linq.LongCount`
- `Cysharp.Threading.Tasks.Linq.Max`
- `Cysharp.Threading.Tasks.Linq.Merge<T>`
- `Cysharp.Threading.Tasks.Linq.Min`
- `Cysharp.Threading.Tasks.Linq.Never<T>`
- `Cysharp.Threading.Tasks.Linq.OfType<TResult>`
- `Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerable<TElement>`
- `Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerableAwait<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.OrderedAsyncEnumerableAwaitWithCancellation<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.Pairwise<TSource>`
- `Cysharp.Threading.Tasks.Linq.Publish<TSource>`
- `Cysharp.Threading.Tasks.Linq.QueueOperator<TSource>`
- `Cysharp.Threading.Tasks.Linq.Range`
- `Cysharp.Threading.Tasks.Linq.Repeat<TElement>`
- `Cysharp.Threading.Tasks.Linq.Return<TValue>`
- `Cysharp.Threading.Tasks.Linq.Reverse<TSource>`
- `Cysharp.Threading.Tasks.Linq.Select<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectAwait<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectAwaitWithCancellation<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectInt<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectIntAwait<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectIntAwaitWithCancellation<TSource, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectMany<TSource, TCollection, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectManyAwait<TSource, TCollection, TResult>`
- `Cysharp.Threading.Tasks.Linq.SelectManyAwaitWithCancellation<TSource, TCollection, TResult>`
- `Cysharp.Threading.Tasks.Linq.SequenceEqual`
- `Cysharp.Threading.Tasks.Linq.SingleOperator`
- `Cysharp.Threading.Tasks.Linq.Skip<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipLast<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipUntil<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipUntilCanceled<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhile<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhileAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhileAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhileInt<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhileIntAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.SkipWhileIntAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.Sum`
- `Cysharp.Threading.Tasks.Linq.SyncSelectorAsyncEnumerableSorter<TElement, TKey>`
- `Cysharp.Threading.Tasks.Linq.Take<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeLast<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeUntil<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeUntilCanceled<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhile<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhileAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhileAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhileInt<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhileIntAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.TakeWhileIntAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.Throw<TValue>`
- `Cysharp.Threading.Tasks.Linq.Timer`
- `Cysharp.Threading.Tasks.Linq.TimerFrame`
- `Cysharp.Threading.Tasks.Linq.ToArray`
- `Cysharp.Threading.Tasks.Linq.ToDictionary`
- `Cysharp.Threading.Tasks.Linq.ToHashSet`
- `Cysharp.Threading.Tasks.Linq.ToList`
- `Cysharp.Threading.Tasks.Linq.ToLookup`
- `Cysharp.Threading.Tasks.Linq.ToObservable<T>`
- `Cysharp.Threading.Tasks.Linq.ToUniTaskAsyncEnumerable<T>`
- `Cysharp.Threading.Tasks.Linq.ToUniTaskAsyncEnumerableTask<T>`
- `Cysharp.Threading.Tasks.Linq.ToUniTaskAsyncEnumerableUniTask<T>`
- `Cysharp.Threading.Tasks.Linq.Where<TSource>`
- `Cysharp.Threading.Tasks.Linq.WhereAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.WhereAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.WhereInt<TSource>`
- `Cysharp.Threading.Tasks.Linq.WhereIntAwait<TSource>`
- `Cysharp.Threading.Tasks.Linq.WhereIntAwaitWithCancellation<TSource>`
- `Cysharp.Threading.Tasks.Linq.Zip<TFirst, TSecond, TResult>`
- `Cysharp.Threading.Tasks.Linq.ZipAwait<TFirst, TSecond, TResult>`
- `Cysharp.Threading.Tasks.Linq.ZipAwaitWithCancellation<TFirst, TSecond, TResult>`
- `DefaultIfEmpty._DefaultIfEmpty.IteratingState<TSource>`
- `DefaultIfEmpty._DefaultIfEmpty<TSource>`
- `Distinct._Distinct<TSource, TKey>`
- `Distinct._Distinct<TSource>`
- `DistinctAwait._DistinctAwait<TSource, TKey>`
- `DistinctAwaitWithCancellation._DistinctAwaitWithCancellation<TSource, TKey>`
- `DistinctUntilChanged._DistinctUntilChanged<TSource, TKey>`
- `DistinctUntilChanged._DistinctUntilChanged<TSource>`
- `DistinctUntilChangedAwait._DistinctUntilChangedAwait<TSource, TKey>`
- `DistinctUntilChangedAwaitWithCancellation._DistinctUntilChangedAwaitWithCancellation<TSource, TKey>`
- `Do._Do<TSource>`
- `ElementAt.<ElementAtAsync>d__0<TSource>` (compiler-generated name)
- `Empty._Empty<T>`
- `EveryUpdate._EveryUpdate`
- `EveryUpdate._EveryUpdate.<>c` (compiler-generated name)
- `EveryValueChangedStandardObject._EveryValueChanged.<>c<TTarget, TProperty>` (compiler-generated name)
- `EveryValueChangedStandardObject._EveryValueChanged<TTarget, TProperty>`
- `EveryValueChangedUnityObject._EveryValueChanged.<>c<TTarget, TProperty>` (compiler-generated name)
- `EveryValueChangedUnityObject._EveryValueChanged<TTarget, TProperty>`
- `Except._Except<TSource>`
- `First.<FirstAsync>d__0<TSource>` (compiler-generated name)
- `First.<FirstAsync>d__1<TSource>` (compiler-generated name)
- `First.<FirstAwaitAsync>d__2<TSource>` (compiler-generated name)
- `First.<FirstAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `ForEach.<ForEachAsync>d__0<TSource>` (compiler-generated name)
- `ForEach.<ForEachAsync>d__1<TSource>` (compiler-generated name)
- `ForEach.<ForEachAwaitAsync>d__2<TSource>` (compiler-generated name)
- `ForEach.<ForEachAwaitAsync>d__3<TSource>` (compiler-generated name)
- `ForEach.<ForEachAwaitWithCancellationAsync>d__4<TSource>` (compiler-generated name)
- `ForEach.<ForEachAwaitWithCancellationAsync>d__5<TSource>` (compiler-generated name)
- `GroupBy._GroupBy.<CreateLookup>d__12<TSource, TKey, TElement>` (compiler-generated name)
- `GroupBy._GroupBy.<CreateLookup>d__13<TSource, TKey, TElement, TResult>` (compiler-generated name)
- `GroupBy._GroupBy<TSource, TKey, TElement, TResult>`
- `GroupBy._GroupBy<TSource, TKey, TElement>`
- `GroupByAwait._GroupByAwait.<CreateLookup>d__12<TSource, TKey, TElement>` (compiler-generated name)
- `GroupByAwait._GroupByAwait.<CreateLookup>d__15<TSource, TKey, TElement, TResult>` (compiler-generated name)
- `GroupByAwait._GroupByAwait<TSource, TKey, TElement, TResult>`
- `GroupByAwait._GroupByAwait<TSource, TKey, TElement>`
- `GroupByAwaitWithCancellation._GroupByAwaitWithCancellation.<CreateLookup>d__12<TSource, TKey, TElement>` (compiler-generated name)
- `GroupByAwaitWithCancellation._GroupByAwaitWithCancellation.<CreateLookup>d__15<TSource, TKey, TElement, TResult>` (compiler-generated name)
- `GroupByAwaitWithCancellation._GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>`
- `GroupByAwaitWithCancellation._GroupByAwaitWithCancellation<TSource, TKey, TElement>`
- `GroupJoin._GroupJoin.<CreateLookup>d__17<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `GroupJoin._GroupJoin<TOuter, TInner, TKey, TResult>`
- `GroupJoinAwait._GroupJoinAwait.<CreateLookup>d__22<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `GroupJoinAwait._GroupJoinAwait<TOuter, TInner, TKey, TResult>`
- `GroupJoinAwaitWithCancellation._GroupJoinAwaitWithCancellation.<CreateLookup>d__22<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `GroupJoinAwaitWithCancellation._GroupJoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>`
- `Intersect._Intersect<TSource>`
- `Join._Join.<CreateInnerHashSet>d__20<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `Join._Join<TOuter, TInner, TKey, TResult>`
- `JoinAwait._JoinAwait.<CreateInnerHashSet>d__24<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `JoinAwait._JoinAwait<TOuter, TInner, TKey, TResult>`
- `JoinAwaitWithCancellation._JoinAwaitWithCancellation.<CreateInnerHashSet>d__24<TOuter, TInner, TKey, TResult>` (compiler-generated name)
- `JoinAwaitWithCancellation._JoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>`
- `Last.<LastAsync>d__0<TSource>` (compiler-generated name)
- `Last.<LastAsync>d__1<TSource>` (compiler-generated name)
- `Last.<LastAwaitAsync>d__2<TSource>` (compiler-generated name)
- `Last.<LastAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `LongCount.<LongCountAsync>d__0<TSource>` (compiler-generated name)
- `LongCount.<LongCountAsync>d__1<TSource>` (compiler-generated name)
- `LongCount.<LongCountAwaitAsync>d__2<TSource>` (compiler-generated name)
- `LongCount.<LongCountAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__0<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__12` (compiler-generated name)
- `Max.<MaxAsync>d__13<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__16` (compiler-generated name)
- `Max.<MaxAsync>d__17<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__1<TSource, TResult>` (compiler-generated name)
- `Max.<MaxAsync>d__20` (compiler-generated name)
- `Max.<MaxAsync>d__21<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__24` (compiler-generated name)
- `Max.<MaxAsync>d__25<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__28` (compiler-generated name)
- `Max.<MaxAsync>d__29<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__32` (compiler-generated name)
- `Max.<MaxAsync>d__33<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__36` (compiler-generated name)
- `Max.<MaxAsync>d__37<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__4` (compiler-generated name)
- `Max.<MaxAsync>d__40` (compiler-generated name)
- `Max.<MaxAsync>d__41<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__5<TSource>` (compiler-generated name)
- `Max.<MaxAsync>d__8` (compiler-generated name)
- `Max.<MaxAsync>d__9<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__10<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__14<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__18<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__22<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__26<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__2<TSource, TResult>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__30<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__34<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__38<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__42<TSource>` (compiler-generated name)
- `Max.<MaxAwaitAsync>d__6<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__11<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__15<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__19<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__23<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__27<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__31<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__35<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__39<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__3<TSource, TResult>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__43<TSource>` (compiler-generated name)
- `Max.<MaxAwaitWithCancellationAsync>d__7<TSource>` (compiler-generated name)
- `Merge.MergeSourceState<T>`
- `Merge._Merge.<DisposeAsync>d__13<T>` (compiler-generated name)
- `Merge._Merge<T>`
- `Min.<MinAsync>d__0<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__12` (compiler-generated name)
- `Min.<MinAsync>d__13<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__16` (compiler-generated name)
- `Min.<MinAsync>d__17<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__1<TSource, TResult>` (compiler-generated name)
- `Min.<MinAsync>d__20` (compiler-generated name)
- `Min.<MinAsync>d__21<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__24` (compiler-generated name)
- `Min.<MinAsync>d__25<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__28` (compiler-generated name)
- `Min.<MinAsync>d__29<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__32` (compiler-generated name)
- `Min.<MinAsync>d__33<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__36` (compiler-generated name)
- `Min.<MinAsync>d__37<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__4` (compiler-generated name)
- `Min.<MinAsync>d__40` (compiler-generated name)
- `Min.<MinAsync>d__41<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__5<TSource>` (compiler-generated name)
- `Min.<MinAsync>d__8` (compiler-generated name)
- `Min.<MinAsync>d__9<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__10<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__14<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__18<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__22<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__26<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__2<TSource, TResult>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__30<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__34<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__38<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__42<TSource>` (compiler-generated name)
- `Min.<MinAwaitAsync>d__6<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__11<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__15<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__19<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__23<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__27<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__31<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__35<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__39<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__3<TSource, TResult>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__43<TSource>` (compiler-generated name)
- `Min.<MinAwaitWithCancellationAsync>d__7<TSource>` (compiler-generated name)
- `Never._Never<T>`
- `OfType._OfType<TResult>`
- `OrderedAsyncEnumerable._OrderedAsyncEnumerator.<CreateSortSource>d__11<TElement>` (compiler-generated name)
- `OrderedAsyncEnumerable._OrderedAsyncEnumerator<TElement>`
- `Pairwise._Pairwise<TSource>`
- `Publish.<ConsumeEnumerator>d__8<TSource>` (compiler-generated name)
- `Publish.ConnectDisposable<TSource>`
- `Publish._Publish<TSource>`
- `QueueOperator._Queue.<ConsumeAll>d__10<TSource>` (compiler-generated name)
- `QueueOperator._Queue.<DisposeAsync>d__11<TSource>` (compiler-generated name)
- `QueueOperator._Queue<TSource>`
- `Range._Range`
- `Repeat._Repeat<TElement>`
- `Return._Return<TValue>`
- `Reverse._Reverse.<MoveNextAsync>d__9<TSource>` (compiler-generated name)
- `Reverse._Reverse<TSource>`
- `Select._Select<TSource, TResult>`
- `SelectAwait._SelectAwait<TSource, TResult>`
- `SelectAwaitWithCancellation._SelectAwaitWithCancellation<TSource, TResult>`
- `SelectInt._Select<TSource, TResult>`
- `SelectIntAwait._SelectAwait<TSource, TResult>`
- `SelectIntAwaitWithCancellation._SelectAwaitWithCancellation<TSource, TResult>`
- `SelectMany._SelectMany.<DisposeAsync>d__26<TSource, TCollection, TResult>` (compiler-generated name)
- `SelectMany._SelectMany<TSource, TCollection, TResult>`
- `SelectManyAwait._SelectManyAwait.<DisposeAsync>d__32<TSource, TCollection, TResult>` (compiler-generated name)
- `SelectManyAwait._SelectManyAwait<TSource, TCollection, TResult>`
- `SelectManyAwaitWithCancellation._SelectManyAwaitWithCancellation.<DisposeAsync>d__32<TSource, TCollection, TResult>` (compiler-generated name)
- `SelectManyAwaitWithCancellation._SelectManyAwaitWithCancellation<TSource, TCollection, TResult>`
- `SequenceEqual.<SequenceEqualAsync>d__0<TSource>` (compiler-generated name)
- `SingleOperator.<SingleAsync>d__0<TSource>` (compiler-generated name)
- `SingleOperator.<SingleAsync>d__1<TSource>` (compiler-generated name)
- `SingleOperator.<SingleAwaitAsync>d__2<TSource>` (compiler-generated name)
- `SingleOperator.<SingleAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `Skip._Skip<TSource>`
- `SkipLast._SkipLast<TSource>`
- `SkipUntil._SkipUntil.<RunOther>d__18<TSource>` (compiler-generated name)
- `SkipUntil._SkipUntil<TSource>`
- `SkipUntilCanceled._SkipUntilCanceled<TSource>`
- `SkipWhile._SkipWhile<TSource>`
- `SkipWhileAwait._SkipWhileAwait<TSource>`
- `SkipWhileAwaitWithCancellation._SkipWhileAwaitWithCancellation<TSource>`
- `SkipWhileInt._SkipWhileInt<TSource>`
- `SkipWhileIntAwait._SkipWhileIntAwait<TSource>`
- `SkipWhileIntAwaitWithCancellation._SkipWhileIntAwaitWithCancellation<TSource>`
- `Subscribe.<SubscribeAwaitCore>d__7<TSource>` (compiler-generated name)
- `Subscribe.<SubscribeCore>d__2<TSource>` (compiler-generated name)
- `Subscribe.<SubscribeCore>d__3<TSource>` (compiler-generated name)
- `Subscribe.<SubscribeCore>d__4<TSource>` (compiler-generated name)
- `Subscribe.<SubscribeCore>d__5<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__0` (compiler-generated name)
- `Sum.<SumAsync>d__12` (compiler-generated name)
- `Sum.<SumAsync>d__13<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__16` (compiler-generated name)
- `Sum.<SumAsync>d__17<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__1<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__20` (compiler-generated name)
- `Sum.<SumAsync>d__21<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__24` (compiler-generated name)
- `Sum.<SumAsync>d__25<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__28` (compiler-generated name)
- `Sum.<SumAsync>d__29<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__32` (compiler-generated name)
- `Sum.<SumAsync>d__33<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__36` (compiler-generated name)
- `Sum.<SumAsync>d__37<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__4` (compiler-generated name)
- `Sum.<SumAsync>d__5<TSource>` (compiler-generated name)
- `Sum.<SumAsync>d__8` (compiler-generated name)
- `Sum.<SumAsync>d__9<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__10<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__14<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__18<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__22<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__26<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__2<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__30<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__34<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__38<TSource>` (compiler-generated name)
- `Sum.<SumAwaitAsync>d__6<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__11<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__15<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__19<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__23<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__27<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__31<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__35<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__39<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__3<TSource>` (compiler-generated name)
- `Sum.<SumAwaitWithCancellationAsync>d__7<TSource>` (compiler-generated name)
- `SyncSelectorAsyncEnumerableSorter.<ComputeKeysAsync>d__6<TElement, TKey>` (compiler-generated name)
- `Take._Take<TSource>`
- `TakeLast._TakeLast<TSource>`
- `TakeUntil._TakeUntil.<RunOther>d__17<TSource>` (compiler-generated name)
- `TakeUntil._TakeUntil<TSource>`
- `TakeUntilCanceled._TakeUntilCanceled<TSource>`
- `TakeWhile._TakeWhile<TSource>`
- `TakeWhileAwait._TakeWhileAwait<TSource>`
- `TakeWhileAwaitWithCancellation._TakeWhileAwaitWithCancellation<TSource>`
- `TakeWhileInt._TakeWhileInt<TSource>`
- `TakeWhileIntAwait._TakeWhileIntAwait<TSource>`
- `TakeWhileIntAwaitWithCancellation._TakeWhileIntAwaitWithCancellation<TSource>`
- `Throw._Throw<TValue>`
- `Timer._Timer`
- `Timer._Timer.<>c` (compiler-generated name)
- `TimerFrame._TimerFrame`
- `TimerFrame._TimerFrame.<>c` (compiler-generated name)
- `ToArray.<ToArrayAsync>d__0<TSource>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAsync>d__0<TSource, TKey>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAsync>d__1<TSource, TKey, TElement>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAwaitAsync>d__2<TSource, TKey>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAwaitAsync>d__3<TSource, TKey, TElement>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAwaitWithCancellationAsync>d__4<TSource, TKey>` (compiler-generated name)
- `ToDictionary.<ToDictionaryAwaitWithCancellationAsync>d__5<TSource, TKey, TElement>` (compiler-generated name)
- `ToHashSet.<ToHashSetAsync>d__0<TSource>` (compiler-generated name)
- `ToList.<ToListAsync>d__0<TSource>` (compiler-generated name)
- `ToLookup.<ToLookupAsync>d__0<TSource, TKey>` (compiler-generated name)
- `ToLookup.<ToLookupAsync>d__1<TSource, TKey, TElement>` (compiler-generated name)
- `ToLookup.<ToLookupAwaitAsync>d__2<TSource, TKey>` (compiler-generated name)
- `ToLookup.<ToLookupAwaitAsync>d__3<TSource, TKey, TElement>` (compiler-generated name)
- `ToLookup.<ToLookupAwaitWithCancellationAsync>d__4<TSource, TKey>` (compiler-generated name)
- `ToLookup.<ToLookupAwaitWithCancellationAsync>d__5<TSource, TKey, TElement>` (compiler-generated name)
- `ToLookup.Grouping<TKey, TElement>`
- `ToLookup.Lookup.<CreateAsync>d__6<TKey, TElement>` (compiler-generated name)
- `ToLookup.Lookup.<CreateAsync>d__7<TKey, TElement, TSource>` (compiler-generated name)
- `ToLookup.Lookup.<CreateAsync>d__8<TKey, TElement>` (compiler-generated name)
- `ToLookup.Lookup.<CreateAsync>d__9<TKey, TElement, TSource>` (compiler-generated name)
- `ToLookup.Lookup<TKey, TElement>`
- `ToObservable.<RunAsync>d__3<T>` (compiler-generated name)
- `ToObservable.CancellationTokenDisposable<T>`
- `ToUniTaskAsyncEnumerable._ToUniTaskAsyncEnumerable<T>`
- `ToUniTaskAsyncEnumerableTask._ToUniTaskAsyncEnumerableTask.<MoveNextAsync>d__7<T>` (compiler-generated name)
- `ToUniTaskAsyncEnumerableTask._ToUniTaskAsyncEnumerableTask<T>`
- `ToUniTaskAsyncEnumerableUniTask._ToUniTaskAsyncEnumerableUniTask.<MoveNextAsync>d__7<T>` (compiler-generated name)
- `ToUniTaskAsyncEnumerableUniTask._ToUniTaskAsyncEnumerableUniTask<T>`
- `UniTaskAsyncEnumerable.<>c__128<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__129<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__132<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__133<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__136<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__137<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__140<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__142<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__144<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__145<TSource, TKey>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__148<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__150<TSource, TKey, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__309<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__310<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__313<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__314<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__317<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__318<TSource, TResult>` (compiler-generated name)
- `UniTaskAsyncEnumerable.<>c__471<TFirst, TSecond>` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `Where._Where<TSource>`
- `WhereAwait._WhereAwait<TSource>`
- `WhereAwaitWithCancellation._WhereAwaitWithCancellation<TSource>`
- `WhereInt._Where<TSource>`
- `WhereIntAwait._WhereAwait<TSource>`
- `WhereIntAwaitWithCancellation._WhereAwaitWithCancellation<TSource>`
- `Zip._Zip.<DisposeAsync>d__18<TFirst, TSecond, TResult>` (compiler-generated name)
- `Zip._Zip<TFirst, TSecond, TResult>`
- `ZipAwait._ZipAwait.<DisposeAsync>d__21<TFirst, TSecond, TResult>` (compiler-generated name)
- `ZipAwait._ZipAwait<TFirst, TSecond, TResult>`
- `ZipAwaitWithCancellation._ZipAwaitWithCancellation.<DisposeAsync>d__21<TFirst, TSecond, TResult>` (compiler-generated name)
- `ZipAwaitWithCancellation._ZipAwaitWithCancellation<TFirst, TSecond, TResult>`

</details>


## UniTask.dll

<details><summary>Matching: 289</summary>

- `<Module>`
- `AsyncDestroyTrigger.<>c` (compiler-generated name)
- `AsyncDestroyTrigger.AwakeMonitor`
- `AutoResetUniTaskCompletionSource.<>c` (compiler-generated name)
- `Cysharp.Threading.Tasks.AsyncLazy`
- `Cysharp.Threading.Tasks.AsyncUnit`
- `Cysharp.Threading.Tasks.AwaiterActions`
- `Cysharp.Threading.Tasks.CancellationTokenExtensions`
- `Cysharp.Threading.Tasks.CancellationTokenSourceExtensions`
- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder`
- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder`
- `Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner`
- `Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise`
- `Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T>`
- `Cysharp.Threading.Tasks.CompletedTasks`
- `Cysharp.Threading.Tasks.DelayType`
- `Cysharp.Threading.Tasks.DeltaTimePlayerLoopTimer`
- `Cysharp.Threading.Tasks.EnumerableAsyncExtensions`
- `Cysharp.Threading.Tasks.EnumeratorAsyncExtensions`
- `Cysharp.Threading.Tasks.ExceptionExtensions`
- `Cysharp.Threading.Tasks.ExceptionHolder`
- `Cysharp.Threading.Tasks.IPlayerLoopItem`
- `Cysharp.Threading.Tasks.ITaskPoolNode<T>`
- `Cysharp.Threading.Tasks.ITriggerHandler<T>`
- `Cysharp.Threading.Tasks.IUniTaskAsyncDisposable`
- `Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T>`
- `Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T>`
- `Cysharp.Threading.Tasks.IUniTaskSource`
- `Cysharp.Threading.Tasks.IUniTaskSource<T>`
- `Cysharp.Threading.Tasks.IgnoreTimeScalePlayerLoopTimer`
- `Cysharp.Threading.Tasks.InjectPlayerLoopTimings`
- `Cysharp.Threading.Tasks.Internal.ArrayPoolUtil`
- `Cysharp.Threading.Tasks.Internal.Error`
- `Cysharp.Threading.Tasks.Internal.RuntimeHelpersAbstraction`
- `Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable`
- `Cysharp.Threading.Tasks.Internal.StateTuple`
- `Cysharp.Threading.Tasks.Internal.UnityWebRequestResultExtensions`
- `Cysharp.Threading.Tasks.Internal.ValueStopwatch`
- `Cysharp.Threading.Tasks.MoveNextSource`
- `Cysharp.Threading.Tasks.PlayerLoopTimer`
- `Cysharp.Threading.Tasks.PlayerLoopTiming`
- `Cysharp.Threading.Tasks.RealtimePlayerLoopTimer`
- `Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable`
- `Cysharp.Threading.Tasks.SwitchToThreadPoolAwaitable`
- `Cysharp.Threading.Tasks.TaskPool`
- `Cysharp.Threading.Tasks.Triggers.AsyncAnimatorIKTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncAnimatorMoveTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncApplicationFocusTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncApplicationPauseTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncApplicationQuitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncAudioFilterReadTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncAwakeTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncBecameInvisibleTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncBecameVisibleTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncBeforeTransformParentChangedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncBeginDragTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCancelTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionEnter2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionEnterTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionExit2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionExitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionStay2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncCollisionStayTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncControllerColliderHitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDeselectTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDisableTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDragTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDrawGizmosSelectedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDrawGizmosTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncDropTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncEnableTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncEndDragTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncFixedUpdateTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncGUITrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncInitializePotentialDragTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncJointBreak2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncJointBreakTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncLateUpdateTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncMoveTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncOnCanvasGroupChangedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncParticleCollisionTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncParticleSystemStoppedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncParticleTriggerTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncParticleUpdateJobScheduledTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPointerClickTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPointerDownTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPointerEnterTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPointerExitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPointerUpTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPostRenderTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPreCullTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncPreRenderTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncRectTransformDimensionsChangeTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncRectTransformRemovedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncRenderImageTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncRenderObjectTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncResetTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncScrollTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncSelectTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncServerInitializedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncStartTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncSubmitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTransformChildrenChangedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTransformParentChangedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerEnter2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerEnterTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerExit2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerExitTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerExtensions`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerStay2DTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerStayTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncUpdateSelectedTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncUpdateTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncValidateTrigger`
- `Cysharp.Threading.Tasks.Triggers.AsyncWillRenderObjectTrigger`
- `Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger`
- `Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler`
- `Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler`
- `Cysharp.Threading.Tasks.UniTask`
- `Cysharp.Threading.Tasks.UniTaskCancellationExtensions`
- `Cysharp.Threading.Tasks.UniTaskCompletionSourceCoreShared`
- `Cysharp.Threading.Tasks.UniTaskExtensions`
- `Cysharp.Threading.Tasks.UniTaskLoopRunners`
- `Cysharp.Threading.Tasks.UniTaskObservableExtensions`
- `Cysharp.Threading.Tasks.UniTaskScheduler`
- `Cysharp.Threading.Tasks.UniTaskStatus`
- `Cysharp.Threading.Tasks.UniTaskStatusExtensions`
- `Cysharp.Threading.Tasks.UniTaskVoid`
- `Cysharp.Threading.Tasks.UnityAsyncExtensions`
- `Cysharp.Threading.Tasks.UnityWebRequestException`
- `Cysharp.Threading.Tasks.YieldAwaitable`
- `EnumeratorAsyncExtensions.EnumeratorPromise`
- `EnumeratorAsyncExtensions.EnumeratorPromise.<>c` (compiler-generated name)
- `EnumeratorAsyncExtensions.EnumeratorPromise.<ConsumeEnumerator>d__19` (compiler-generated name)
- `EnumeratorAsyncExtensions.EnumeratorPromise.<UnwrapWaitAsyncOperation>d__22` (compiler-generated name)
- `EnumeratorAsyncExtensions.EnumeratorPromise.<UnwrapWaitForSeconds>d__21` (compiler-generated name)
- `PlayerLoopHelper.<>c` (compiler-generated name)
- `PlayerLoopHelper.<>c__DisplayClass20_0` (compiler-generated name)
- `PlayerLoopRunner.<>c` (compiler-generated name)
- `SwitchToMainThreadAwaitable.Awaiter`
- `SwitchToThreadPoolAwaitable.Awaiter`
- `System.Runtime.CompilerServices.AsyncMethodBuilderAttribute`
- `UniTask.<>c` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__82` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__84` (compiler-generated name)
- `UniTask.AsyncUnitSource`
- `UniTask.Awaiter`
- `UniTask.CanceledResultSource`
- `UniTask.DelayFramePromise`
- `UniTask.DelayFramePromise.<>c` (compiler-generated name)
- `UniTask.DelayIgnoreTimeScalePromise`
- `UniTask.DelayIgnoreTimeScalePromise.<>c` (compiler-generated name)
- `UniTask.DelayPromise`
- `UniTask.DelayPromise.<>c` (compiler-generated name)
- `UniTask.DelayRealtimePromise`
- `UniTask.DelayRealtimePromise.<>c` (compiler-generated name)
- `UniTask.ExceptionResultSource`
- `UniTask.IsCanceledSource`
- `UniTask.NextFramePromise`
- `UniTask.NextFramePromise.<>c` (compiler-generated name)
- `UniTask.WaitForEndOfFramePromise`
- `UniTask.WaitForEndOfFramePromise.<>c` (compiler-generated name)
- `UniTask.WaitUntilCanceledPromise`
- `UniTask.WaitUntilCanceledPromise.<>c` (compiler-generated name)
- `UniTask.WaitUntilPromise`
- `UniTask.WaitUntilPromise.<>c` (compiler-generated name)
- `UniTask.WaitWhilePromise`
- `UniTask.WaitWhilePromise.<>c` (compiler-generated name)
- `UniTask.WhenAllPromise`
- `UniTask.WhenAllPromise.<>c` (compiler-generated name)
- `UniTask.WhenAnyPromise`
- `UniTask.WhenAnyPromise.<>c` (compiler-generated name)
- `UniTask.YieldPromise`
- `UniTask.YieldPromise.<>c` (compiler-generated name)
- `UniTaskExtensions.<ContinueWith>d__58` (compiler-generated name)
- `UniTaskExtensions.<ContinueWith>d__59` (compiler-generated name)
- `UniTaskExtensions.<ForgetCoreWithCatch>d__50` (compiler-generated name)
- `UniTaskExtensions.AttachExternalCancellationSource`
- `UniTaskExtensions.AttachExternalCancellationSource.<RunTask>d__5` (compiler-generated name)
- `UniTaskExtensions.ToCoroutineEnumerator`
- `UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__6` (compiler-generated name)
- `UniTaskLoopRunners.UniTaskLoopRunnerEarlyUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerFixedUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerInitialization`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastEarlyUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastFixedUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastInitialization`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastPostLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastPreLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastPreUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastTimeUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldEarlyUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldFixedUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldInitialization`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldPostLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldPreLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldPreUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldTimeUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerLastYieldUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerPostLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerPreLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerPreUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerTimeUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldEarlyUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldFixedUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldInitialization`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldPostLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldPreLateUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldPreUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldTimeUpdate`
- `UniTaskLoopRunners.UniTaskLoopRunnerYieldUpdate`
- `UniTaskSynchronizationContext.Callback`
- `UnityAsyncExtensions.AsyncGPUReadbackRequestAwaiterConfiguredSource`
- `UnityAsyncExtensions.AsyncGPUReadbackRequestAwaiterConfiguredSource.<>c` (compiler-generated name)
- `UnityAsyncExtensions.AsyncOperationConfiguredSource`
- `UnityAsyncExtensions.AsyncOperationConfiguredSource.<>c` (compiler-generated name)
- `UnityAsyncExtensions.ResourceRequestAwaiter`
- `UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter`
- `UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource`
- `UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource.<>c` (compiler-generated name)
- `YieldAwaitable.Awaiter`

</details>

<details><summary>Mismatching: 11</summary>

- `Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`

  - `bases: 'IUniTaskSource, IValueTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>' → 'IUniTaskSource, IValueTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>, IPromise, IResolvePromise, IRejectPromise, ICancelPromise'`

- `Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>`

  - `bases: 'IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, ITaskPoolNode<AutoResetUniTaskCompletionSource<T>>' → 'IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, ITaskPoolNode<AutoResetUniTaskCompletionSource<T>>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.ArrayPool<T>`

  - `field declaration order/names: ['EmptyArray', 'Shared', 'buckets', 'locks'] → ['DefaultMaxNumberOfArraysPerBucket', 'EmptyArray', 'Shared', 'buckets', 'locks']`
  - `extra field constant int DefaultMaxNumberOfArraysPerBucket`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.ContinuationQueue`

  - `field declaration order/names: ['timing', 'gate', 'dequing', 'actionListCount', 'actionList', 'waitingListCount', 'waitingList'] → ['MaxArrayLength', 'InitialSize', 'timing', 'gate', 'dequing', 'actionListCount', 'actionList', 'waitingListCount', 'waitingList']`
  - `extra field constant int MaxArrayLength`
  - `extra field constant int InitialSize`

- `Cysharp.Threading.Tasks.Internal.MinimumQueue<T>`

  - `field declaration order/names: ['array', 'head', 'tail', 'size'] → ['MinimumGrow', 'GrowFactor', 'array', 'head', 'tail', 'size']`
  - `extra field constant int MinimumGrow`
  - `extra field constant int GrowFactor`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.PlayerLoopRunner`

  - `field declaration order/names: ['timing', 'runningAndQueueLock', 'arrayLock', 'unhandledExceptionCallback', 'tail', 'running', 'loopItems', 'waitQueue'] → ['InitialSize', 'timing', 'runningAndQueueLock', 'arrayLock', 'unhandledExceptionCallback', 'tail', 'running', 'loopItems', 'waitQueue']`
  - `extra field constant int InitialSize`

- `Cysharp.Threading.Tasks.PlayerLoopHelper`

  - `field declaration order/names: ['ThrowMarkerContinuationQueue', 'ThrowMarkerPlayerLoopRunner', 'mainThreadId', 'applicationDataPath', 'unitySynchronizationContext', 'yielders', 'runners'] → ['ThrowMarkerContinuationQueue', 'ThrowMarkerPlayerLoopRunner', 'mainThreadId', 'applicationDataPath', 'unitySynchronizationContext', 'yielders', 'runners', '<IsEditorApplicationQuitting>k__BackingField']`
  - `extra field static bool <IsEditorApplicationQuitting>k__BackingField`

- `Cysharp.Threading.Tasks.UniTaskCompletionSource`

  - `bases: 'IUniTaskSource, IValueTaskSource' → 'IUniTaskSource, IValueTaskSource, IPromise, IResolvePromise, IRejectPromise, ICancelPromise'`

- `Cysharp.Threading.Tasks.UniTaskCompletionSource<T>`

  - `bases: 'IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>' → 'IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.UniTaskSynchronizationContext`

  - `field declaration order/names: ['gate', 'dequing', 'actionListCount', 'actionList', 'waitingListCount', 'waitingList'] → ['MaxArrayLength', 'InitialSize', 'gate', 'dequing', 'actionListCount', 'actionList', 'waitingListCount', 'waitingList', 'opCount']`
  - `extra field constant int MaxArrayLength`
  - `extra field constant int InitialSize`
  - `extra field static int opCount`

- `UniTaskExtensions.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__33_0', '<>9__48_0'] → ['<>9', '<>9__33_0', '<>9__35_0', '<>9__48_0']`
  - `<>9__48_0: offset '0x10' → '0x18'`
  - `extra field static Action<object> <>9__35_0`


</details>

<details><summary>Indeterminate: 60</summary>

- `ArrayPoolUtil.RentArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AsyncTriggerBase.AsyncTriggerEnumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AsyncTriggerBase.AwakeMonitor<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AsyncUniTask.<>c<TStateMachine, T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AsyncUniTask.<>c<TStateMachine>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AsyncUniTaskVoid.<>c<TStateMachine>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AutoResetUniTaskCompletionSource.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.PooledDelegate<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StatePool<T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StatePool<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StatePool<T1>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.StateTuple<T1>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.TaskPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.TriggerEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Triggers.AsyncTriggerHandler<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.UniTask<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PooledDelegate.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RuntimeHelpersAbstraction.WellKnownNoReferenceContainsType<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.<RunOnThreadPool>d__87<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.Awaiter<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.CanceledResultSource<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.CanceledUniTaskCache<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.ExceptionResultSource<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.IsCanceledSource<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.NeverPromise<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2, T3>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T1, T2>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2, T3, T4>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAllPromise<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAnyLRPromise.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAnyLRPromise<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAnyPromise.<>c<T1, T2>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTask.WhenAnyPromise<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.<>c__32<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.<>c__51<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.<ContinueWith>d__54<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.<ContinueWith>d__56<T, TR>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.<ContinueWith>d__60<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.AttachExternalCancellationSource.<RunTask>d__5<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskExtensions.AttachExternalCancellationSource<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskObservableExtensions.FirstValueToUniTaskObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniTaskObservableExtensions.ToUniTaskObserver<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 246</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=35701`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4485`
- `AsyncInstantiateOperationExtensions.AsyncInstantiateOperationConfiguredSource`
- `AsyncInstantiateOperationExtensions.AsyncInstantiateOperationConfiguredSource.<>c` (compiler-generated name)
- `AsyncInstantiateOperationExtensions.AsyncInstantiateOperationConfiguredSource.<>c<T>` (compiler-generated name)
- `AsyncInstantiateOperationExtensions.AsyncInstantiateOperationConfiguredSource<T>`
- `AsyncReactiveProperty.Enumerator<T>`
- `AsyncReactiveProperty.WaitAsyncSource.<>c<T>` (compiler-generated name)
- `AsyncReactiveProperty.WaitAsyncSource<T>`
- `AsyncReactiveProperty.WithoutCurrentEnumerable<T>`
- `AsyncSubject.Subscription<T>`
- `CancellationTokenAwaitable.Awaiter`
- `CancellationTokenExtensions.<ToCancellationTokenCore>d__6` (compiler-generated name)
- `ChannelReader.<ReadAsyncCore>d__5<T>` (compiler-generated name)
- `Cysharp.Threading.Tasks.AsyncInstantiateOperationExtensions`
- `Cysharp.Threading.Tasks.AsyncLazy<T>`
- `Cysharp.Threading.Tasks.AsyncReactiveProperty<T>`
- `Cysharp.Threading.Tasks.AsyncUnityEventHandler`
- `Cysharp.Threading.Tasks.AsyncUnityEventHandler<T>`
- `Cysharp.Threading.Tasks.CancellationTokenAwaitable`
- `Cysharp.Threading.Tasks.CancellationTokenEqualityComparer`
- `Cysharp.Threading.Tasks.Channel`
- `Cysharp.Threading.Tasks.Channel<T>`
- `Cysharp.Threading.Tasks.Channel<TWrite, TRead>`
- `Cysharp.Threading.Tasks.ChannelClosedException`
- `Cysharp.Threading.Tasks.ChannelReader<T>`
- `Cysharp.Threading.Tasks.ChannelWriter<T>`
- `Cysharp.Threading.Tasks.CompilerServices.StateMachineUtility`
- `Cysharp.Threading.Tasks.IAsyncClickEventHandler`
- `Cysharp.Threading.Tasks.IAsyncDeselectEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncEndEditEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncEndTextSelectionEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncReactiveProperty<T>`
- `Cysharp.Threading.Tasks.IAsyncSelectEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncSubmitEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncTextSelectionEventHandler<T>`
- `Cysharp.Threading.Tasks.IAsyncValueChangedEventHandler<T>`
- `Cysharp.Threading.Tasks.ICancelPromise`
- `Cysharp.Threading.Tasks.IConnectableUniTaskAsyncEnumerable<T>`
- `Cysharp.Threading.Tasks.IPromise`
- `Cysharp.Threading.Tasks.IPromise<T>`
- `Cysharp.Threading.Tasks.IReadOnlyAsyncReactiveProperty<T>`
- `Cysharp.Threading.Tasks.IRejectPromise`
- `Cysharp.Threading.Tasks.IResolvePromise`
- `Cysharp.Threading.Tasks.IResolvePromise<T>`
- `Cysharp.Threading.Tasks.IUniTaskOrderedAsyncEnumerable<TElement>`
- `Cysharp.Threading.Tasks.Internal.ArrayUtil`
- `Cysharp.Threading.Tasks.Internal.AsyncSubject<T>`
- `Cysharp.Threading.Tasks.Internal.DiagnosticsExtensions`
- `Cysharp.Threading.Tasks.Internal.DisposedObserver<T>`
- `Cysharp.Threading.Tasks.Internal.EmptyDisposable`
- `Cysharp.Threading.Tasks.Internal.EmptyObserver<T>`
- `Cysharp.Threading.Tasks.Internal.ImmutableList<T>`
- `Cysharp.Threading.Tasks.Internal.ListObserver<T>`
- `Cysharp.Threading.Tasks.Internal.ThrowObserver<T>`
- `Cysharp.Threading.Tasks.Internal.UnityEqualityComparer`
- `Cysharp.Threading.Tasks.Internal.WeakDictionary<TKey, TValue>`
- `Cysharp.Threading.Tasks.Progress`
- `Cysharp.Threading.Tasks.ReadOnlyAsyncReactiveProperty<T>`
- `Cysharp.Threading.Tasks.ReturnToMainThread`
- `Cysharp.Threading.Tasks.ReturnToSynchronizationContext`
- `Cysharp.Threading.Tasks.SingleConsumerUnboundedChannel<T>`
- `Cysharp.Threading.Tasks.StateExtensions`
- `Cysharp.Threading.Tasks.SwitchToSynchronizationContextAwaitable`
- `Cysharp.Threading.Tasks.SwitchToTaskPoolAwaitable`
- `Cysharp.Threading.Tasks.TaskTracker`
- `Cysharp.Threading.Tasks.TextSelectionEventConverter`
- `Cysharp.Threading.Tasks.TimeoutController`
- `Cysharp.Threading.Tasks.UniTaskAsyncEnumerableExtensions`
- `Cysharp.Threading.Tasks.UniTaskCancelableAsyncEnumerable<T>`
- `Cysharp.Threading.Tasks.UniTaskValueTaskExtensions`
- `Cysharp.Threading.Tasks.UnityAwaitableExtensions`
- `Cysharp.Threading.Tasks.UnityBindingExtensions`
- `Cysharp.Threading.Tasks.UnityEventHandlerAsyncEnumerable`
- `Cysharp.Threading.Tasks.UnityEventHandlerAsyncEnumerable<T>`
- `Cysharp.Threading.Tasks.WhenEachEnumerable<T>`
- `Cysharp.Threading.Tasks.WhenEachResult<T>`
- `Cysharp.Threading.Tasks.WhenEachState`
- `DiagnosticsExtensions.<>c` (compiler-generated name)
- `EnumeratorAsyncExtensions.<Core>d__4` (compiler-generated name)
- `Progress.AnonymousProgress<T>`
- `Progress.NullProgress<T>`
- `Progress.OnlyValueChangedProgress<T>`
- `ReadOnlyAsyncReactiveProperty.<ConsumeEnumerator>d__7<T>` (compiler-generated name)
- `ReadOnlyAsyncReactiveProperty.Enumerator<T>`
- `ReadOnlyAsyncReactiveProperty.WaitAsyncSource.<>c<T>` (compiler-generated name)
- `ReadOnlyAsyncReactiveProperty.WaitAsyncSource<T>`
- `ReadOnlyAsyncReactiveProperty.WithoutCurrentEnumerable<T>`
- `ReturnToMainThread.Awaiter`
- `ReturnToSynchronizationContext.Awaiter`
- `SingleConsumerUnboundedChannel.SingleConsumerUnboundedChannelReader.ReadAllAsyncEnumerable<T>`
- `SingleConsumerUnboundedChannel.SingleConsumerUnboundedChannelReader<T>`
- `SingleConsumerUnboundedChannel.SingleConsumerUnboundedChannelWriter<T>`
- `StateMachineUtility.<>c` (compiler-generated name)
- `SwitchToSynchronizationContextAwaitable.Awaiter`
- `SwitchToTaskPoolAwaitable.Awaiter`
- `TaskPool.<GetCacheSizeInfo>d__4` (compiler-generated name)
- `UniTask.<>c__DisplayClass45_0` (compiler-generated name)
- `UniTask.<>c__DisplayClass46_0` (compiler-generated name)
- `UniTask.<>c__DisplayClass47_0<T>` (compiler-generated name)
- `UniTask.<>c__DisplayClass48_0` (compiler-generated name)
- `UniTask.<>c__DisplayClass49_0` (compiler-generated name)
- `UniTask.<>c__DisplayClass50_0<T>` (compiler-generated name)
- `UniTask.<>c__DisplayClass51_0<T>` (compiler-generated name)
- `UniTask.<>c__DisplayClass52_0<T0, T1>` (compiler-generated name)
- `UniTask.<>c__DisplayClass53_0<T0, T1, T2>` (compiler-generated name)
- `UniTask.<>c__DisplayClass54_0<T0, T1, T2, T3>` (compiler-generated name)
- `UniTask.<>c__DisplayClass55_0<T>` (compiler-generated name)
- `UniTask.<>c__DisplayClass56_0<T0, T1>` (compiler-generated name)
- `UniTask.<>c__DisplayClass57_0<T0, T1, T2>` (compiler-generated name)
- `UniTask.<>c__DisplayClass58_0<T0, T1, T2, T3>` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__83` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__85` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__86<T>` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__88<T>` (compiler-generated name)
- `UniTask.<RunOnThreadPool>d__89<T>` (compiler-generated name)
- `UniTask.<WaitForEndOfFrame>d__9` (compiler-generated name)
- `UniTask.DeferPromise`
- `UniTask.DeferPromise<T>`
- `UniTask.DeferPromiseWithState<TState, TResult>`
- `UniTask.DeferPromiseWithState<TState>`
- `UniTask.MemoizeSource`
- `UniTask.MemoizeSource<T>`
- `UniTask.WaitUntilPromise.<>c<T>` (compiler-generated name)
- `UniTask.WaitUntilPromise<T>`
- `UniTask.WaitUntilValueChangedStandardObjectPromise.<>c<T, U>` (compiler-generated name)
- `UniTask.WaitUntilValueChangedStandardObjectPromise<T, U>`
- `UniTask.WaitUntilValueChangedUnityObjectPromise.<>c<T, U>` (compiler-generated name)
- `UniTask.WaitUntilValueChangedUnityObjectPromise<T, U>`
- `UniTask.WaitWhilePromise.<>c<T>` (compiler-generated name)
- `UniTask.WaitWhilePromise<T>`
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9>` (compiler-generated name)
- `UniTask.WhenAllPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8>` (compiler-generated name)
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9>`
- `UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8>`
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8, T9>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7, T8>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6, T7>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5, T6>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4, T5>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3, T4>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T1, T2, T3>` (compiler-generated name)
- `UniTask.WhenAnyPromise.<>c<T>` (compiler-generated name)
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5, T6>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4, T5>`
- `UniTask.WhenAnyPromise<T1, T2, T3, T4>`
- `UniTask.WhenAnyPromise<T1, T2, T3>`
- `UniTask.WhenAnyPromise<T>`
- `UniTaskCancelableAsyncEnumerable.Enumerator<T>`
- `UniTaskExtensions.<>c__34<T>` (compiler-generated name)
- `UniTaskExtensions.<ContinueWith>d__55<T>` (compiler-generated name)
- `UniTaskExtensions.<ContinueWith>d__57<T, TR>` (compiler-generated name)
- `UniTaskExtensions.<ContinueWith>d__61<T>` (compiler-generated name)
- `UniTaskExtensions.<ForgetCoreWithCatch>d__53<T>` (compiler-generated name)
- `UniTaskExtensions.<Timeout>d__44` (compiler-generated name)
- `UniTaskExtensions.<Timeout>d__45<T>` (compiler-generated name)
- `UniTaskExtensions.<TimeoutWithoutException>d__46` (compiler-generated name)
- `UniTaskExtensions.<TimeoutWithoutException>d__47<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__62<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__63` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__64<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__65<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__66` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__67` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__68<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__69<T>` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__70` (compiler-generated name)
- `UniTaskExtensions.<Unwrap>d__71` (compiler-generated name)
- `UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<T>` (compiler-generated name)
- `UniTaskExtensions.ToCoroutineEnumerator<T>`
- `UniTaskObservableExtensions.<Fire>d__3<T>` (compiler-generated name)
- `UniTaskObservableExtensions.<Fire>d__4` (compiler-generated name)
- `UniTaskObservableExtensions.ReturnObservable<T>`
- `UniTaskObservableExtensions.ThrowObservable<T>`
- `UniTaskValueTaskExtensions.<AsUniTask>d__2<T>` (compiler-generated name)
- `UniTaskValueTaskExtensions.<AsUniTask>d__3` (compiler-generated name)
- `UnityAsyncExtensions.<WaitAsync>d__11` (compiler-generated name)
- `UnityAsyncExtensions.AssetBundleCreateRequestAwaiter`
- `UnityAsyncExtensions.AssetBundleCreateRequestConfiguredSource`
- `UnityAsyncExtensions.AssetBundleCreateRequestConfiguredSource.<>c` (compiler-generated name)
- `UnityAsyncExtensions.AssetBundleRequestAllAssetsAwaiter`
- `UnityAsyncExtensions.AssetBundleRequestAllAssetsConfiguredSource`
- `UnityAsyncExtensions.AssetBundleRequestAllAssetsConfiguredSource.<>c` (compiler-generated name)
- `UnityAsyncExtensions.AssetBundleRequestAwaiter`
- `UnityAsyncExtensions.AssetBundleRequestConfiguredSource`
- `UnityAsyncExtensions.AssetBundleRequestConfiguredSource.<>c` (compiler-generated name)
- `UnityAsyncExtensions.AsyncOperationAwaiter`
- `UnityAsyncExtensions.JobHandlePromise`
- `UnityAsyncExtensions.ResourceRequestConfiguredSource`
- `UnityAsyncExtensions.ResourceRequestConfiguredSource.<>c` (compiler-generated name)
- `UnityAwaitableExtensions.<AsUniTask>d__0` (compiler-generated name)
- `UnityAwaitableExtensions.<AsUniTask>d__1<T>` (compiler-generated name)
- `UnityBindingExtensions.<BindToCore>d__12<TSource, TObject>` (compiler-generated name)
- `UnityBindingExtensions.<BindToCore>d__2` (compiler-generated name)
- `UnityBindingExtensions.<BindToCore>d__6<T>` (compiler-generated name)
- `UnityBindingExtensions.<BindToCore>d__9` (compiler-generated name)
- `UnityEqualityComparer.BoundsEqualityComparer`
- `UnityEqualityComparer.BoundsIntEqualityComparer`
- `UnityEqualityComparer.Cache<T>`
- `UnityEqualityComparer.Color32EqualityComparer`
- `UnityEqualityComparer.ColorEqualityComparer`
- `UnityEqualityComparer.QuaternionEqualityComparer`
- `UnityEqualityComparer.RangeIntEqualityComparer`
- `UnityEqualityComparer.RectEqualityComparer`
- `UnityEqualityComparer.RectIntEqualityComparer`
- `UnityEqualityComparer.Vector2EqualityComparer`
- `UnityEqualityComparer.Vector2IntEqualityComparer`
- `UnityEqualityComparer.Vector3EqualityComparer`
- `UnityEqualityComparer.Vector3IntEqualityComparer`
- `UnityEqualityComparer.Vector4EqualityComparer`
- `UnityEventHandlerAsyncEnumerable.UnityEventHandlerAsyncEnumerator`
- `UnityEventHandlerAsyncEnumerable.UnityEventHandlerAsyncEnumerator<T>`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `WeakDictionary.Entry<TKey, TValue>`
- `WhenEachEnumerable.Enumerator.<DisposeAsync>d__12<T>` (compiler-generated name)
- `WhenEachEnumerable.Enumerator.<RunWhenEachTask>d__11<T>` (compiler-generated name)
- `WhenEachEnumerable.Enumerator<T>`

</details>


## Unity.Animation.Rigging.dll

<details><summary>Matching: 46</summary>

- `<Module>`
- `RigBuilder.OnAddRigBuilderCallback`
- `RigBuilder.OnRemoveRigBuilderCallback`
- `RigBuilderUtils.PlayableChain`
- `RigEffectorData.Style`
- `RigSyncSceneToStreamJob.PropertySyncer`
- `RigSyncSceneToStreamJob.TransformSyncer`
- `RigUtils.<>c` (compiler-generated name)
- `RigUtils.RigSyncSceneToStreamData`
- `UnityEngine.Animations.Rigging.AffineTransform`
- `UnityEngine.Animations.Rigging.AnimationJobBinder<TJob, TData>`
- `UnityEngine.Animations.Rigging.ConstraintsUtils`
- `UnityEngine.Animations.Rigging.ExpandChildrenAttribute`
- `UnityEngine.Animations.Rigging.IAnimationJobBinder`
- `UnityEngine.Animations.Rigging.IAnimationJobData`
- `UnityEngine.Animations.Rigging.IRigConstraint`
- `UnityEngine.Animations.Rigging.IRigEffectorHolder`
- `UnityEngine.Animations.Rigging.IRigLayer`
- `UnityEngine.Animations.Rigging.IRigSyncSceneToStreamData`
- `UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData`
- `UnityEngine.Animations.Rigging.IWeightedAnimationJob`
- `UnityEngine.Animations.Rigging.Property`
- `UnityEngine.Animations.Rigging.PropertyDescriptor`
- `UnityEngine.Animations.Rigging.PropertyType`
- `UnityEngine.Animations.Rigging.ReadOnlyTransformHandle`
- `UnityEngine.Animations.Rigging.ReadWriteTransformHandle`
- `UnityEngine.Animations.Rigging.Rig`
- `UnityEngine.Animations.Rigging.RigBuilder`
- `UnityEngine.Animations.Rigging.RigBuilderUtils`
- `UnityEngine.Animations.Rigging.RigEffectorData`
- `UnityEngine.Animations.Rigging.RigLayer`
- `UnityEngine.Animations.Rigging.RigSyncSceneToStreamJob`
- `UnityEngine.Animations.Rigging.RigSyncSceneToStreamJobBinder<T>`
- `UnityEngine.Animations.Rigging.RigSyncSceneToStreamJobBinderConstants`
- `UnityEngine.Animations.Rigging.RigTransform`
- `UnityEngine.Animations.Rigging.RigUtils`
- `UnityEngine.Animations.Rigging.SyncSceneToStreamAttribute`
- `UnityEngine.Animations.Rigging.SyncSceneToStreamLayer`
- `UnityEngine.Animations.Rigging.SyncableProperties`
- `UnityEngine.Animations.Rigging.TwoBoneIKConstraint`
- `UnityEngine.Animations.Rigging.TwoBoneIKConstraintData`
- `UnityEngine.Animations.Rigging.TwoBoneIKConstraintJob`
- `UnityEngine.Animations.Rigging.TwoBoneIKConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.Vector3Bool`
- `UnityEngine.Animations.Rigging.WeightedTransformArray`
- `WeightedTransformArray.Enumerator`

</details>

<details><summary>Mismatching: 8</summary>

- `UnityEngine.Animations.Rigging.AnimationRuntimeUtils`

  - `field declaration order/names: [] → ['k_SqrEpsilon']`
  - `extra field constant float k_SqrEpsilon`

- `UnityEngine.Animations.Rigging.ConstraintProperties`

  - `field declaration order/names: ['component', 'properties'] → ['k_Weight', 'component', 'properties']`
  - `extra field constant string k_Weight`

- `UnityEngine.Animations.Rigging.FloatProperty`

  - `bases: '' → 'IAnimatableProperty<float>'`

- `UnityEngine.Animations.Rigging.IntProperty`

  - `bases: '' → 'IAnimatableProperty<int>'`

- `UnityEngine.Animations.Rigging.QuaternionExt`

  - `field declaration order/names: ['zero'] → ['k_FloatMin', 'zero']`
  - `extra field constant float k_FloatMin`

- `UnityEngine.Animations.Rigging.RigProperties`

  - `field declaration order/names: ['component'] → ['k_Weight', 'component']`
  - `extra field constant string k_Weight`

- `UnityEngine.Animations.Rigging.Vector3Property`

  - `bases: '' → 'IAnimatableProperty<Vector3>'`

- `UnityEngine.Animations.Rigging.WeightedTransform`

  - `bases: 'IEquatable<WeightedTransform>' → 'ITransformProvider, IWeightProvider, IEquatable<WeightedTransform>'`


</details>

<details><summary>Indeterminate: 1</summary>

- `UnityEngine.Animations.Rigging.RigConstraint<TJob, TData, TBinder>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 87</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5133`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6870`
- `BoneRenderer.BoneShape`
- `ConstraintsUtils.<>c__DisplayClass2_0` (compiler-generated name)
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `MultiAimConstraintData.Axis`
- `MultiAimConstraintData.WorldUpType`
- `MultiAimConstraintJob.WorldUpType`
- `OverrideTransformData.Space`
- `OverrideTransformJob.Space`
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `TwistCorrectionData.Axis`
- `UnityEngine.Animations.Rigging.AnimationJobCache`
- `UnityEngine.Animations.Rigging.AnimationJobCacheBuilder`
- `UnityEngine.Animations.Rigging.BlendConstraint`
- `UnityEngine.Animations.Rigging.BlendConstraintData`
- `UnityEngine.Animations.Rigging.BlendConstraintJob`
- `UnityEngine.Animations.Rigging.BlendConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.BoneRenderer`
- `UnityEngine.Animations.Rigging.BoolProperty`
- `UnityEngine.Animations.Rigging.CacheIndex`
- `UnityEngine.Animations.Rigging.ChainIKConstraint`
- `UnityEngine.Animations.Rigging.ChainIKConstraintData`
- `UnityEngine.Animations.Rigging.ChainIKConstraintJob`
- `UnityEngine.Animations.Rigging.ChainIKConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.DampedTransform`
- `UnityEngine.Animations.Rigging.DampedTransformData`
- `UnityEngine.Animations.Rigging.DampedTransformJob`
- `UnityEngine.Animations.Rigging.DampedTransformJobBinder<T>`
- `UnityEngine.Animations.Rigging.IAnimatableProperty<T>`
- `UnityEngine.Animations.Rigging.IBlendConstraintData`
- `UnityEngine.Animations.Rigging.IChainIKConstraintData`
- `UnityEngine.Animations.Rigging.IDampedTransformData`
- `UnityEngine.Animations.Rigging.IMultiAimConstraintData`
- `UnityEngine.Animations.Rigging.IMultiParentConstraintData`
- `UnityEngine.Animations.Rigging.IMultiPositionConstraintData`
- `UnityEngine.Animations.Rigging.IMultiReferentialConstraintData`
- `UnityEngine.Animations.Rigging.IMultiRotationConstraintData`
- `UnityEngine.Animations.Rigging.IOverrideTransformData`
- `UnityEngine.Animations.Rigging.ITransformProvider`
- `UnityEngine.Animations.Rigging.ITwistChainConstraintData`
- `UnityEngine.Animations.Rigging.ITwistCorrectionData`
- `UnityEngine.Animations.Rigging.IWeightProvider`
- `UnityEngine.Animations.Rigging.MultiAimConstraint`
- `UnityEngine.Animations.Rigging.MultiAimConstraintData`
- `UnityEngine.Animations.Rigging.MultiAimConstraintJob`
- `UnityEngine.Animations.Rigging.MultiAimConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.MultiParentConstraint`
- `UnityEngine.Animations.Rigging.MultiParentConstraintData`
- `UnityEngine.Animations.Rigging.MultiParentConstraintJob`
- `UnityEngine.Animations.Rigging.MultiParentConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.MultiPositionConstraint`
- `UnityEngine.Animations.Rigging.MultiPositionConstraintData`
- `UnityEngine.Animations.Rigging.MultiPositionConstraintJob`
- `UnityEngine.Animations.Rigging.MultiPositionConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.MultiReferentialConstraint`
- `UnityEngine.Animations.Rigging.MultiReferentialConstraintData`
- `UnityEngine.Animations.Rigging.MultiReferentialConstraintJob`
- `UnityEngine.Animations.Rigging.MultiReferentialConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.MultiRotationConstraint`
- `UnityEngine.Animations.Rigging.MultiRotationConstraintData`
- `UnityEngine.Animations.Rigging.MultiRotationConstraintJob`
- `UnityEngine.Animations.Rigging.MultiRotationConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.OverrideRigConstraint<TConstraint, TJob, TData, TBinder>`
- `UnityEngine.Animations.Rigging.OverrideRigLayer`
- `UnityEngine.Animations.Rigging.OverrideTransform`
- `UnityEngine.Animations.Rigging.OverrideTransformData`
- `UnityEngine.Animations.Rigging.OverrideTransformJob`
- `UnityEngine.Animations.Rigging.OverrideTransformJobBinder<T>`
- `UnityEngine.Animations.Rigging.PropertyUtils`
- `UnityEngine.Animations.Rigging.TwistChainConstraint`
- `UnityEngine.Animations.Rigging.TwistChainConstraintData`
- `UnityEngine.Animations.Rigging.TwistChainConstraintJob`
- `UnityEngine.Animations.Rigging.TwistChainConstraintJobBinder<T>`
- `UnityEngine.Animations.Rigging.TwistCorrection`
- `UnityEngine.Animations.Rigging.TwistCorrectionData`
- `UnityEngine.Animations.Rigging.TwistCorrectionJob`
- `UnityEngine.Animations.Rigging.TwistCorrectionJobBinder<T>`
- `UnityEngine.Animations.Rigging.Vector2Property`
- `UnityEngine.Animations.Rigging.Vector3BoolProperty`
- `UnityEngine.Animations.Rigging.Vector3IntProperty`
- `UnityEngine.Animations.Rigging.Vector4Property`
- `UnityEngine.Animations.Rigging.WeightRangeAttribute`
- `UnityEngine.Animations.Rigging.WeightedTransformArrayBinder`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.Burst.dll

<details><summary>Matching: 23</summary>

- `$BurstDirectCallInitializer`
- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `BurstCompiler.FakeDelegate`
- `BurstRuntime.PreserveAttribute`
- `BurstString.CutoffMode`
- `BurstString.FormatOptions`
- `BurstString.NumberBuffer`
- `BurstString.NumberBufferKind`
- `BurstString.NumberFormatKind`
- `BurstString.PreserveAttribute`
- `BurstString.tBigInt.<m_blocks>e__FixedBuffer` (compiler-generated name)
- `BurstString.tFloatUnion32`
- `BurstString.tFloatUnion64`
- `SharedStatic.PreserveAttribute`
- `Unity.Burst.BurstRuntime`
- `Unity.Burst.CompilerServices.AssumeRangeAttribute`
- `Unity.Burst.FloatMode`
- `Unity.Burst.FloatPrecision`
- `Unity.Burst.OptimizeFor`
- `Unity.Burst.SharedStatic`

</details>

<details><summary>Mismatching: 9</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA', 'C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C', 'D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010', 'D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E'] → ['07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA', '6AC12597E10FFB084DEE014EEBFD52580EB845FD6B5CCA643AEAC527F7B02F2A', '7E9563F25F905835CDD9CB5F6CF596075C9A9778F115D3CCEE806C083485E938', '80E69247CBC7E738ECDB10A5DCF3EF62BB27B3AB61C6ECF146B2C57CEFFB212F', 'A199F717FBA4D1378A33D65E9660E45ADC176876A3450BACF2A80DA985FBDF14', 'C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C', 'D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010', 'D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E', 'FB12ADB2A1CCEFA04B565E53B2C1AA80A8EEA3FBCB184D7E2FB307244DF662D5']`
  - `C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C: offset '0x100' → '0x19f8'`
  - `D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010: offset '0x120' → '0x1a18'`
  - `D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E: offset '0x128' → '0x1a20'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 6AC12597E10FFB084DEE014EEBFD52580EB845FD6B5CCA643AEAC527F7B02F2A`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3832 7E9563F25F905835CDD9CB5F6CF596075C9A9778F115D3CCEE806C083485E938`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 80E69247CBC7E738ECDB10A5DCF3EF62BB27B3AB61C6ECF146B2C57CEFFB212F`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 A199F717FBA4D1378A33D65E9660E45ADC176876A3450BACF2A80DA985FBDF14`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3068 FB12ADB2A1CCEFA04B565E53B2C1AA80A8EEA3FBCB184D7E2FB307244DF662D5`

- `BurstString.tBigInt`

  - `field declaration order/names: ['m_length', 'm_blocks'] → ['c_BigInt_MaxBlocks', 'm_length', 'm_blocks']`
  - `extra field constant int c_BigInt_MaxBlocks`

- `Unity.Burst.BurstCompileAttribute`

  - `field declaration order/names: ['<FloatMode>k__BackingField', '<FloatPrecision>k__BackingField', '_disableSafetyChecks', '<OptimizeFor>k__BackingField'] → ['<FloatMode>k__BackingField', '<FloatPrecision>k__BackingField', '_compileSynchronously', '_debug', '_disableSafetyChecks', '_disableDirectCall', '<OptimizeFor>k__BackingField', '<Options>k__BackingField']`
  - `_disableSafetyChecks: offset '0x18' → '0x1c'`
  - `<OptimizeFor>k__BackingField: offset '0x1c' → '0x20'`
  - `extra field instance Nullable<bool> _compileSynchronously`
  - `extra field instance Nullable<bool> _debug`
  - `extra field instance Nullable<bool> _disableDirectCall`
  - `extra field instance string[] <Options>k__BackingField`

- `Unity.Burst.BurstCompiler`

  - `field declaration order/names: ['_IsEnabled', 'Options', 'DummyMethodInfo'] → ['_cmdBuilder', '_IsEnabled', 'Options', 'OnCompileILPPMethod2', 'DummyMethodInfo']`
  - `DummyMethodInfo: offset '0x10' → '0x18'`
  - `extra field thread-static BurstCompiler.CommandBuilder _cmdBuilder`
  - `extra field static Action OnCompileILPPMethod2`

- `Unity.Burst.BurstCompilerOptions`

  - `field declaration order/names: ['ForceDisableBurstCompilation', 'ForceBurstCompilationSynchronously', 'IsSecondaryUnityProcess', '_enableBurstCompilation', '_enableBurstSafetyChecks', '<IsGlobal>k__BackingField', '<OptionsChanged>k__BackingField'] → ['DisableCompilationArg', 'ForceSynchronousCompilationArg', 'DefaultLibraryName', 'BurstInitializeName', 'BurstInitializeExternalsName', 'BurstInitializeStaticsName', 'OptionBurstcSwitch', 'OptionGroup', 'OptionPlatform', 'OptionMinimumOSVersion', 'OptionBackend', 'OptionGlobalSafetyChecksSetting', 'OptionDisableSafetyChecks', 'OptionDisableOpt', 'OptionFastMath', 'OptionTarget', 'OptionOptLevel', 'OptionLogTimings', 'OptionOptForSize', 'OptionFloatPrecision', 'OptionFloatMode', 'OptionBranchProtection', 'OptionDisableWarnings', 'OptionAssemblyDefines', 'OptionDump', 'OptionFormat', 'OptionDebugTrap', 'OptionDisableVectors', 'OptionDebug', 'OptionDebugMode', 'OptionStaticLinkage', 'OptionJobMarshalling', 'OptionTempDirectory', 'OptionEnableDirectExternalLinking', 'OptionLinkerOptions', 'OptionEnableAutoLayoutFallbackCheck', 'OptionEnableFrameInfoRegistration', 'OptionGenerateLinkXml', 'OptionMetaDataGeneration', 'OptionDisableStringInterpolationInExceptionMessages', 'OptionPlatformConfiguration', 'OptionStackProtector', 'OptionStackProtectorBufferSize', 'OptionForceDisableFrameInfoRegistration', 'OptionCacheDirectory', 'OptionJitDisableFunctionCaching', 'OptionJitDisableAssemblyCaching', 'OptionJitEnableAssemblyCachingLogs', 'OptionJitEnableSynchronousCompilation', 'OptionJitCompilationPriority', 'OptionJitIsForFunctionPointer', 'OptionJitManagedFunctionPointer', 'OptionJitManagedDelegateHandle', 'OptionEnableInterpreter', 'OptionAotAssemblyFolder', 'OptionRootAssembly', 'OptionIncludeRootAssemblyReferences', 'OptionAotMethod', 'OptionAotType', 'OptionAotAssembly', 'OptionAotOutputPath', 'OptionAotKeepIntermediateFiles', 'OptionAotNoLink', 'OptionAotOnlyStaticMethods', 'OptionMethodPrefix', 'OptionAotNoNativeToolchain', 'OptionAotEmitLlvmObjects', 'OptionAotKeyFolder', 'OptionAotDecodeFolder', 'OptionVerbose', 'OptionValidateExternalToolChain', 'OptionCompilerThreads', 'OptionChunkSize', 'OptionPrintLogOnMissingPInvokeCallbackAttribute', 'OptionOutputMode', 'OptionAlwaysCreateOutput', 'OptionAotPdbSearchPaths', 'OptionSafetyChecks', 'OptionLibraryOutputMode', 'OptionCompilationId', 'OptionTargetFramework', 'OptionDiscardAssemblies', 'OptionSaveExtraContext', 'CompilerCommandShutdown', 'CompilerCommandCancel', 'CompilerCommandEnableCompiler', 'CompilerCommandDisableCompiler', 'CompilerCommandSetDefaultOptions', 'CompilerCommandTriggerSetupRecompilation', 'CompilerCommandIsCurrentCompilationDone', 'CompilerCommandTriggerRecompilation', 'CompilerCommandInitialize', 'CompilerCommandDomainReload', 'CompilerCommandVersionNotification', 'CompilerCommandGetTargetCpuFromHost', 'CompilerCommandSetProfileCallbacks', 'CompilerCommandUnloadBurstNatives', 'CompilerCommandIsNativeApiAvailable', 'CompilerCommandILPPCompilation', 'CompilerCommandIsArmTestEnv', 'CompilerCommandNotifyAssemblyCompilationNotRequired', 'CompilerCommandNotifyAssemblyCompilationFinished', 'CompilerCommandNotifyCompilationStarted', 'CompilerCommandNotifyCompilationFinished', 'CompilerCommandDirtyAllAssemblies', 'CompilerCommandAotCompilation', 'CompilerCommandRequestInitialiseDebuggerCommmand', 'CompilerCommandInitialiseDebuggerCommmand', 'CompilerCommandRequestSetProtocolVersionEditor', 'CompilerCommandSetProtocolVersionBurst', 'ForceDisableBurstCompilation', 'ForceBurstCompilationSynchronously', 'IsSecondaryUnityProcess', '_enableBurstCompilation', '_enableBurstCompileSynchronously', '_enableBurstSafetyChecks', '_enableBurstTimings', '_enableBurstDebug', '_forceEnableBurstSafetyChecks', '<IsGlobal>k__BackingField', '<OptionsChanged>k__BackingField']`
  - `_enableBurstSafetyChecks: offset '0x11' → '0x12'`
  - `<IsGlobal>k__BackingField: offset '0x12' → '0x16'`
  - `extra field constant string DisableCompilationArg`
  - `extra field constant string ForceSynchronousCompilationArg`
  - `extra field constant string DefaultLibraryName`
  - `extra field constant string BurstInitializeName`
  - `extra field constant string BurstInitializeExternalsName`
  - `extra field constant string BurstInitializeStaticsName`
  - `extra field constant string OptionBurstcSwitch`
  - `extra field constant string OptionGroup`
  - `extra field constant string OptionPlatform`
  - `extra field constant string OptionMinimumOSVersion`
  - `extra field constant string OptionBackend`
  - `extra field constant string OptionGlobalSafetyChecksSetting`
  - `extra field constant string OptionDisableSafetyChecks`
  - `extra field constant string OptionDisableOpt`
  - `extra field constant string OptionFastMath`
  - `extra field constant string OptionTarget`
  - `extra field constant string OptionOptLevel`
  - `extra field constant string OptionLogTimings`
  - `extra field constant string OptionOptForSize`
  - `extra field constant string OptionFloatPrecision`
  - `extra field constant string OptionFloatMode`
  - `extra field constant string OptionBranchProtection`
  - `extra field constant string OptionDisableWarnings`
  - `extra field constant string OptionAssemblyDefines`
  - `extra field constant string OptionDump`
  - `extra field constant string OptionFormat`
  - `extra field constant string OptionDebugTrap`
  - `extra field constant string OptionDisableVectors`
  - `extra field constant string OptionDebug`
  - `extra field constant string OptionDebugMode`
  - `extra field constant string OptionStaticLinkage`
  - `extra field constant string OptionJobMarshalling`
  - `extra field constant string OptionTempDirectory`
  - `extra field constant string OptionEnableDirectExternalLinking`
  - `extra field constant string OptionLinkerOptions`
  - `extra field constant string OptionEnableAutoLayoutFallbackCheck`
  - `extra field constant string OptionEnableFrameInfoRegistration`
  - `extra field constant string OptionGenerateLinkXml`
  - `extra field constant string OptionMetaDataGeneration`
  - `extra field constant string OptionDisableStringInterpolationInExceptionMessages`
  - `extra field constant string OptionPlatformConfiguration`
  - `extra field constant string OptionStackProtector`
  - `extra field constant string OptionStackProtectorBufferSize`
  - `extra field constant string OptionForceDisableFrameInfoRegistration`
  - `extra field constant string OptionCacheDirectory`
  - `extra field constant string OptionJitDisableFunctionCaching`
  - `extra field constant string OptionJitDisableAssemblyCaching`
  - `extra field constant string OptionJitEnableAssemblyCachingLogs`
  - `extra field constant string OptionJitEnableSynchronousCompilation`
  - `extra field constant string OptionJitCompilationPriority`
  - `extra field constant string OptionJitIsForFunctionPointer`
  - `extra field constant string OptionJitManagedFunctionPointer`
  - `extra field constant string OptionJitManagedDelegateHandle`
  - `extra field constant string OptionEnableInterpreter`
  - `extra field constant string OptionAotAssemblyFolder`
  - `extra field constant string OptionRootAssembly`
  - `extra field constant string OptionIncludeRootAssemblyReferences`
  - `extra field constant string OptionAotMethod`
  - `extra field constant string OptionAotType`
  - `extra field constant string OptionAotAssembly`
  - `extra field constant string OptionAotOutputPath`
  - `extra field constant string OptionAotKeepIntermediateFiles`
  - `extra field constant string OptionAotNoLink`
  - `extra field constant string OptionAotOnlyStaticMethods`
  - `extra field constant string OptionMethodPrefix`
  - `extra field constant string OptionAotNoNativeToolchain`
  - `extra field constant string OptionAotEmitLlvmObjects`
  - `extra field constant string OptionAotKeyFolder`
  - `extra field constant string OptionAotDecodeFolder`
  - `extra field constant string OptionVerbose`
  - `extra field constant string OptionValidateExternalToolChain`
  - `extra field constant string OptionCompilerThreads`
  - `extra field constant string OptionChunkSize`
  - `extra field constant string OptionPrintLogOnMissingPInvokeCallbackAttribute`
  - `extra field constant string OptionOutputMode`
  - `extra field constant string OptionAlwaysCreateOutput`
  - `extra field constant string OptionAotPdbSearchPaths`
  - `extra field constant string OptionSafetyChecks`
  - `extra field constant string OptionLibraryOutputMode`
  - `extra field constant string OptionCompilationId`
  - `extra field constant string OptionTargetFramework`
  - `extra field constant string OptionDiscardAssemblies`
  - `extra field constant string OptionSaveExtraContext`
  - `extra field constant string CompilerCommandShutdown`
  - `extra field constant string CompilerCommandCancel`
  - `extra field constant string CompilerCommandEnableCompiler`
  - `extra field constant string CompilerCommandDisableCompiler`
  - `extra field constant string CompilerCommandSetDefaultOptions`
  - `extra field constant string CompilerCommandTriggerSetupRecompilation`
  - `extra field constant string CompilerCommandIsCurrentCompilationDone`
  - `extra field constant string CompilerCommandTriggerRecompilation`
  - `extra field constant string CompilerCommandInitialize`
  - `extra field constant string CompilerCommandDomainReload`
  - `extra field constant string CompilerCommandVersionNotification`
  - `extra field constant string CompilerCommandGetTargetCpuFromHost`
  - `extra field constant string CompilerCommandSetProfileCallbacks`
  - `extra field constant string CompilerCommandUnloadBurstNatives`
  - `extra field constant string CompilerCommandIsNativeApiAvailable`
  - `extra field constant string CompilerCommandILPPCompilation`
  - `extra field constant string CompilerCommandIsArmTestEnv`
  - `extra field constant string CompilerCommandNotifyAssemblyCompilationNotRequired`
  - `extra field constant string CompilerCommandNotifyAssemblyCompilationFinished`
  - `extra field constant string CompilerCommandNotifyCompilationStarted`
  - `extra field constant string CompilerCommandNotifyCompilationFinished`
  - `extra field constant string CompilerCommandDirtyAllAssemblies`
  - `extra field constant string CompilerCommandAotCompilation`
  - `extra field constant string CompilerCommandRequestInitialiseDebuggerCommmand`
  - `extra field constant string CompilerCommandInitialiseDebuggerCommmand`
  - `extra field constant string CompilerCommandRequestSetProtocolVersionEditor`
  - `extra field constant string CompilerCommandSetProtocolVersionBurst`
  - `extra field instance bool _enableBurstCompileSynchronously`
  - `extra field instance bool _enableBurstTimings`
  - `extra field instance bool _enableBurstDebug`
  - `extra field instance bool _forceEnableBurstSafetyChecks`

- `Unity.Burst.BurstString`

  - `field declaration order/names: ['logTable', 'g_PowerOf10_U32', 'InfinityString', 'NanString', 'SplitByColon'] → ['logTable', 'g_PowerOf10_U32', 'InfinityString', 'NanString', 'SinglePrecision', 'DoublePrecision', 'SingleNumberBufferLength', 'DoubleNumberBufferLength', 'SinglePrecisionCustomFormat', 'DoublePrecisionCustomFormat', 'SplitByColon']`
  - `extra field constant int SinglePrecision`
  - `extra field constant int DoublePrecision`
  - `extra field constant int SingleNumberBufferLength`
  - `extra field constant int DoubleNumberBufferLength`
  - `extra field constant int SinglePrecisionCustomFormat`
  - `extra field constant int DoublePrecisionCustomFormat`

- `Unity.Burst.FunctionPointer<T>`

  - `bases: '' → 'IFunctionPointer'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Burst.Intrinsics.BurstTargetCpuAttribute`

  - `field declaration order/names: [] → ['TargetCpu']`
  - `extra field instance BurstTargetCpu TargetCpu`

- `Unity.Burst.SharedStatic<T>`

  - `field declaration order/names: ['_buffer'] → ['_buffer', 'DefaultAlignment']`
  - `extra field constant uint DefaultAlignment`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 68</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3068`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3832`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=512`
- `Arm.Neon`
- `BurstCompiler.<>c` (compiler-generated name)
- `BurstCompiler.<>c__DisplayClass17_0` (compiler-generated name)
- `BurstCompiler.BurstCompilerHelper`
- `BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate`
- `BurstCompiler.BurstCompilerHelper.IsBurstEnabled_00000145$BurstDirectCall`
- `BurstCompiler.BurstCompilerHelper.IsBurstEnabled_00000145$PostfixBurstDelegate`
- `BurstCompiler.CommandBuilder`
- `BurstCompiler.StaticTypeReinitAttribute`
- `BurstRuntime.HashCode32<T>`
- `BurstRuntime.HashCode64<T>`
- `BurstString.PrintFloatFormat`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `Unity.Burst.BurstExecutionEnvironment`
- `Unity.Burst.BurstTargetCpu`
- `Unity.Burst.CompilationPriority`
- `Unity.Burst.CompilerServices.Aliasing`
- `Unity.Burst.CompilerServices.Constant`
- `Unity.Burst.CompilerServices.Hint`
- `Unity.Burst.CompilerServices.IgnoreWarningAttribute`
- `Unity.Burst.CompilerServices.SkipLocalsInitAttribute`
- `Unity.Burst.DiagnosticId`
- `Unity.Burst.GlobalSafetyChecksSettingKind`
- `Unity.Burst.IFunctionPointer`
- `Unity.Burst.Intrinsics.Arm`
- `Unity.Burst.Intrinsics.Common`
- `Unity.Burst.Intrinsics.V128DebugView`
- `Unity.Burst.Intrinsics.V256DebugView`
- `Unity.Burst.Intrinsics.V64DebugView`
- `Unity.Burst.Intrinsics.X86`
- `Unity.Burst.Intrinsics.X86.DoGetCSRTrampoline_0000012A$BurstDirectCall`
- `Unity.Burst.Intrinsics.X86.DoGetCSRTrampoline_0000012A$PostfixBurstDelegate`
- `Unity.Burst.Intrinsics.X86.DoSetCSRTrampoline_00000129$BurstDirectCall`
- `Unity.Burst.Intrinsics.X86.DoSetCSRTrampoline_00000129$PostfixBurstDelegate`
- `Unity.Burst.Intrinsics.v128`
- `Unity.Burst.Intrinsics.v256`
- `Unity.Burst.Intrinsics.v64`
- `Unity.Burst.NativeDumpFlags`
- `Unity.Burst.NoAliasAttribute`
- `Unity.Burst.SafeStringArrayHelper`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `X86.Avx`
- `X86.Avx.CMP`
- `X86.Avx2`
- `X86.Bmi1`
- `X86.Bmi2`
- `X86.F16C`
- `X86.Fma`
- `X86.Fma.Union`
- `X86.MXCSRBits`
- `X86.Popcnt`
- `X86.RoundingMode`
- `X86.RoundingScope`
- `X86.Sse`
- `X86.Sse2`
- `X86.Sse3`
- `X86.Sse4_1`
- `X86.Sse4_2`
- `X86.Sse4_2.SIDD`
- `X86.Sse4_2.StrBoolArray`
- `X86.Sse4_2.StrBoolArray.<Bits>e__FixedBuffer` (compiler-generated name)
- `X86.Ssse3`

</details>


## Unity.Collections.dll

<details><summary>Matching: 63</summary>

- `$BurstDirectCallInitializer`
- `<Module>`
- `AllocatorManager.AllocatorHandle`
- `AllocatorManager.Block`
- `AllocatorManager.IAllocator`
- `AllocatorManager.Managed`
- `AllocatorManager.Range`
- `AllocatorManager.SharedStatics`
- `AllocatorManager.SharedStatics.TableEntry`
- `AllocatorManager.TableEntry`
- `AllocatorManager.TryFunction`
- `CollectionHelper.DummyJob`
- `EarlyInitHelpers.EarlyInitFunction`
- `Memory.Unmanaged`
- `Memory.Unmanaged.Array`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `NativeSortExtension.DefaultComparer<T>`
- `NativeStream.ConstructJob`
- `NativeStream.ConstructJobList`
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `Unicode.Rune`
- `Unity.Collections.ConversionError`
- `Unity.Collections.ExcludeFromBurstCompatTestingAttribute`
- `Unity.Collections.FixedStringMethods`
- `Unity.Collections.IIndexable<T>`
- `Unity.Collections.INativeList<T>`
- `Unity.Collections.IUTF8Bytes`
- `Unity.Collections.LowLevel.Unsafe.NativeListUnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.UnsafeDisposeJob`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDispose`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDisposeJob`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDisposeJob`
- `Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock`
- `Unity.Collections.LowLevel.Unsafe.UnsafeStreamRange`
- `Unity.Collections.LowLevel.Unsafe.UnsafeTextExtensions`
- `Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList`
- `Unity.Collections.NativeArrayExtensions`
- `Unity.Collections.NativeBitArrayDispose`
- `Unity.Collections.NativeBitArrayDisposeJob`
- `Unity.Collections.NativeHashMapDispose`
- `Unity.Collections.NativeHashMapDisposeJob`
- `Unity.Collections.NativeListDispose`
- `Unity.Collections.NativeListDisposeJob`
- `Unity.Collections.NativeQueueDispose`
- `Unity.Collections.NativeQueueDisposeJob`
- `Unity.Collections.NativeReferenceDispose`
- `Unity.Collections.NativeReferenceDisposeJob`
- `Unity.Collections.NativeRingQueueDispose`
- `Unity.Collections.NativeRingQueueDisposeJob`
- `Unity.Collections.NativeStreamDispose`
- `Unity.Collections.NativeStreamDisposeJob`
- `Unity.Collections.NativeTextDispose`
- `Unity.Collections.NativeTextDisposeJob`
- `Unity.Collections.UnsafeQueueBlockHeader`
- `Unity.Collections.UnsafeQueueDispose`
- `Unity.Collections.UnsafeQueueDisposeJob`
- `Unity.Jobs.DOTSCompilerGeneratedAttribute`
- `Unity.Jobs.EarlyInitHelpers`
- `UnsafeStream.ConstructJob`
- `UnsafeStream.ConstructJobList`
- `UnsafeStream.DisposeJob`
- `UnsafeStreamBlock.<Data>e__FixedBuffer` (compiler-generated name)
- `__JobReflectionRegistrationOutput__1652832624114795843`

</details>

<details><summary>Mismatching: 34</summary>

- `Unity.Collections.AllocatorManager`

  - `field declaration order/names: ['Invalid', 'None', 'Temp', 'TempJob', 'Persistent', 'AudioKernel', 'NumGlobalScratchAllocators', 'MaxNumGlobalAllocators', 'GlobalAllocatorBaseIndex', 'FirstGlobalScratchpadAllocatorIndex'] → ['Invalid', 'None', 'Temp', 'TempJob', 'Persistent', 'AudioKernel', 'kErrorNone', 'kErrorBufferOverflow', 'FirstUserIndex', 'MaxNumCustomAllocators', 'NumGlobalScratchAllocators', 'MaxNumGlobalAllocators', 'GlobalAllocatorBaseIndex', 'FirstGlobalScratchpadAllocatorIndex']`
  - `extra field constant int kErrorNone`
  - `extra field constant int kErrorBufferOverflow`
  - `extra field constant ushort FirstUserIndex`
  - `extra field constant ushort MaxNumCustomAllocators`

- `Unity.Collections.CollectionHelper`

  - `field declaration order/names: [] → ['CacheLineSize']`
  - `extra field constant int CacheLineSize`

- `Unity.Collections.GenerateTestsForBurstCompatibilityAttribute`

  - `field declaration order/names: ['<GenericTypeArguments>k__BackingField'] → ['<GenericTypeArguments>k__BackingField', 'RequiredUnityDefine', 'CompileTarget']`
  - `extra field instance string RequiredUnityDefine`
  - `extra field instance GenerateTestsForBurstCompatibilityAttribute.BurstCompatibleCompileTarget CompileTarget`

- `Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey>`

  - `field declaration order/names: ['Ptr', 'Keys', 'Next', 'Buckets', 'Count', 'Capacity', 'Log2MinGrowth', 'BucketCapacity', 'AllocatedIndex', 'FirstFreeIdx', 'SizeOfTValue', 'Allocator'] → ['Ptr', 'Keys', 'Next', 'Buckets', 'Count', 'Capacity', 'Log2MinGrowth', 'BucketCapacity', 'AllocatedIndex', 'FirstFreeIdx', 'SizeOfTValue', 'Allocator', 'kMinCapacity', 'kMaxCapacity']`
  - `extra field constant int kMinCapacity`
  - `extra field constant int kMaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeBitArray`

  - `bases: 'IDisposable' → 'INativeDisposable, IDisposable'`
  - `field declaration order/names: ['Ptr', 'Length', 'Capacity', 'Allocator'] → ['Ptr', 'Length', 'Capacity', 'Allocator', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`

- `Unity.Collections.LowLevel.Unsafe.UnsafeBitArrayDebugView`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance UnsafeBitArray Data`

- `Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<TKey, TValue>`

  - `bases: 'IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable' → 'INativeDisposable, IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable'`
  - `field declaration order/names: ['m_Data'] → ['m_Data', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDebuggerTypeProxy<TKey, TValue>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance HashMapHelper<TKey> Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeList<T>`

  - `bases: 'IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable' → 'INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeListTDebugView<T>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance UnsafeList<T> Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey, TValue>`

  - `bases: 'IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable' → 'INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable'`
  - `field declaration order/names: ['m_Buffer', 'm_AllocatorLabel'] → ['m_Buffer', 'm_AllocatorLabel', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase<TKey, TValue>`

  - `field declaration order/names: [] → ['SentinelRefilling', 'SentinelSwapInProgress']`
  - `extra field constant int SentinelRefilling`
  - `extra field constant int SentinelSwapInProgress`

- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData`

  - `field declaration order/names: ['values', 'keys', 'next', 'buckets', 'keyCapacity', 'bucketCapacityMask', 'allocatedIndexLength'] → ['values', 'keys', 'next', 'buckets', 'keyCapacity', 'bucketCapacityMask', 'allocatedIndexLength', 'kMaxCapacity', 'kFirstFreeTLSOffset', 'IntsPerCacheLine']`
  - `extra field constant int kMaxCapacity`
  - `extra field constant int kFirstFreeTLSOffset`
  - `extra field constant int IntsPerCacheLine`

- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue>`

  - `field declaration order/names: [] → ['m_Target']`
  - `extra field instance UnsafeParallelHashMap<TKey, TValue> m_Target`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<T>`

  - `bases: 'IDisposable' → 'INativeDisposable, IDisposable'`
  - `field declaration order/names: ['Ptr', 'Allocator', 'm_Capacity', 'm_Filled', 'm_Write', 'm_Read'] → ['Ptr', 'Allocator', 'm_Capacity', 'm_Filled', 'm_Write', 'm_Read', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeRingQueueDebugView<T>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance UnsafeRingQueue<T> Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.UnsafeStream`

  - `bases: 'IDisposable' → 'INativeDisposable, IDisposable'`

- `Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData`

  - `field declaration order/names: ['Allocator', 'Blocks', 'BlockCount', 'Ranges', 'RangeCount'] → ['AllocationSize', 'Allocator', 'Blocks', 'BlockCount', 'Ranges', 'RangeCount']`
  - `extra field constant int AllocationSize`

- `Unity.Collections.LowLevel.Unsafe.UnsafeText`

  - `bases: 'IDisposable, IUTF8Bytes, INativeList<byte>, IIndexable<byte>' → 'INativeDisposable, IDisposable, IUTF8Bytes, INativeList<byte>, IIndexable<byte>'`
  - `field declaration order/names: ['m_UntypedListData'] → ['m_UntypedListData', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`

- `Unity.Collections.Memory`

  - `field declaration order/names: [] → ['k_MaximumRamSizeInBytes']`
  - `extra field constant long k_MaximumRamSizeInBytes`

- `Unity.Collections.NativeHashMap<TKey, TValue>`

  - `bases: 'IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable' → 'INativeDisposable, IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable'`
  - `field declaration order/names: ['m_Data'] → ['m_Data', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeHashMapDebuggerTypeProxy<TKey, TValue>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance HashMapHelper<TKey>* Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeList<T>`

  - `bases: 'IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable' → 'INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeListDebugView<T>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance UnsafeList<T>* Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeParallelHashMap<TKey, TValue>`

  - `bases: 'IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable' → 'INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable'`
  - `field declaration order/names: ['m_HashMapData'] → ['m_HashMapData', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeParallelHashMapDebuggerTypeProxy<TKey, TValue>`

  - `field declaration order/names: [] → ['m_Target']`
  - `extra field instance UnsafeParallelHashMap<TKey, TValue> m_Target`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeParallelHashSet<T>`

  - `bases: 'IDisposable, IEnumerable<T>, IEnumerable' → 'INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable'`
  - `field declaration order/names: ['m_Data'] → ['m_Data', 'MaxCapacity']`
  - `extra field constant int MaxCapacity`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeParallelHashSetDebuggerTypeProxy<T>`

  - `field declaration order/names: [] → ['Data']`
  - `extra field instance NativeParallelHashSet<T> Data`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeReference<T>`

  - `bases: 'IDisposable, IEquatable<NativeReference<T>>' → 'INativeDisposable, IDisposable, IEquatable<NativeReference<T>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeSortExtension`

  - `field declaration order/names: [] → ['k_IntrosortSizeThreshold']`
  - `extra field constant int k_IntrosortSizeThreshold`

- `Unity.Collections.NativeStream`

  - `bases: 'IDisposable' → 'INativeDisposable, IDisposable'`

- `Unity.Collections.Unicode`

  - `field declaration order/names: [] → ['kMaximumValidCodePoint']`
  - `extra field constant int kMaximumValidCodePoint`

- `Unity.Collections.UnsafeQueue<T>`

  - `bases: 'IDisposable' → 'INativeDisposable, IDisposable'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.UnsafeQueueData`

  - `field declaration order/names: ['m_FirstBlock', 'm_LastBlock', 'm_MaxItems', 'm_CurrentRead', 'm_CurrentWriteBlockTLS'] → ['m_BlockSize', 'm_FirstBlock', 'm_LastBlock', 'm_MaxItems', 'm_CurrentRead', 'm_CurrentWriteBlockTLS']`
  - `extra field constant int m_BlockSize`


</details>

<details><summary>Indeterminate: 11</summary>

- `AllocatorManager.Array16<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AllocatorManager.Array256<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AllocatorManager.Array32768<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `AllocatorManager.Array4096<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeList.ParallelWriter<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeParallelHashMap.ParallelWriter<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeParallelHashSet.ParallelWriter<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.KVPair<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeParallelMultiHashMapIterator<TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnsafeParallelHashMap.ParallelWriter<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 234</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=132`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=13868`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=19`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=192`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5461`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=64`
- `AllocatorManager.AllocatorCache<T>`
- `AllocatorManager.BlockHandle`
- `AllocatorManager.SharedStatics.IsAutoDispose`
- `AllocatorManager.SharedStatics.IsInstalled`
- `AllocatorManager.SlabAllocator`
- `AllocatorManager.SlabAllocator.Try_000000B9$BurstDirectCall`
- `AllocatorManager.SlabAllocator.Try_000000B9$PostfixBurstDelegate`
- `AllocatorManager.StackAllocator`
- `AllocatorManager.StackAllocator.Try_000000AB$BurstDirectCall`
- `AllocatorManager.StackAllocator.Try_000000AB$PostfixBurstDelegate`
- `CollectionHelper.LongDoubleUnion`
- `DataStreamReader.Context`
- `DataStreamWriter.StreamData`
- `FixedList128Bytes.Enumerator<T>`
- `FixedList32Bytes.Enumerator<T>`
- `FixedList4096Bytes.Enumerator<T>`
- `FixedList512Bytes.Enumerator<T>`
- `FixedList64Bytes.Enumerator<T>`
- `FixedString128Bytes.Enumerator`
- `FixedString32Bytes.Enumerator`
- `FixedString4096Bytes.Enumerator`
- `FixedString512Bytes.Enumerator`
- `FixedString64Bytes.Enumerator`
- `FixedStringUtils.UintFloatUnion`
- `GenerateTestsForBurstCompatibilityAttribute.BurstCompatibleCompileTarget`
- `HashMapHelper.Enumerator<TKey>`
- `IJobFilterExtensions.JobFilterProducer.ExecuteJobFunction<T>`
- `IJobFilterExtensions.JobFilterProducer.JobWrapper<T>`
- `IJobFilterExtensions.JobFilterProducer<T>`
- `IJobParallelForBatchExtensions.JobParallelForBatchProducer.ExecuteJobFunction<T>`
- `IJobParallelForBatchExtensions.JobParallelForBatchProducer<T>`
- `IJobParallelForDeferExtensions.JobParallelForDeferProducer.ExecuteJobFunction<T>`
- `IJobParallelForDeferExtensions.JobParallelForDeferProducer<T>`
- `Memory.Array`
- `NativeArrayExtensions.NativeArrayStaticId<T>`
- `NativeBitArray.ReadOnly`
- `NativeHashMap.Enumerator<TKey, TValue>`
- `NativeHashMap.ReadOnly<TKey, TValue>`
- `NativeHashSet.Enumerator<T>`
- `NativeHashSet.ReadOnly<T>`
- `NativeParallelHashMap.Enumerator<TKey, TValue>`
- `NativeParallelHashMap.ReadOnly<TKey, TValue>`
- `NativeParallelHashSet.Enumerator<T>`
- `NativeParallelHashSet.ReadOnly<T>`
- `NativeParallelMultiHashMap.Enumerator<TKey, TValue>`
- `NativeParallelMultiHashMap.KeyValueEnumerator<TKey, TValue>`
- `NativeParallelMultiHashMap.ParallelWriter<TKey, TValue>`
- `NativeParallelMultiHashMap.ReadOnly<TKey, TValue>`
- `NativeQueue.Enumerator<T>`
- `NativeQueue.ParallelWriter<T>`
- `NativeQueue.ReadOnly<T>`
- `NativeReference.ReadOnly<T>`
- `NativeStream.Reader`
- `NativeStream.Writer`
- `NativeText.Enumerator`
- `NativeText.ReadOnly`
- `RewindableAllocator.MemoryBlock`
- `RewindableAllocator.Union`
- `SortJob.SegmentSort<T, U>`
- `SortJob.SegmentSortMerge<T, U>`
- `SortJobDefer.SegmentSort<T, U>`
- `SortJobDefer.SegmentSortMerge<T, U>`
- `StreamCompressionModel.<bucketOffsets>e__FixedBuffer` (compiler-generated name)
- `StreamCompressionModel.<bucketSizes>e__FixedBuffer` (compiler-generated name)
- `StreamCompressionModel.<decodeTable>e__FixedBuffer` (compiler-generated name)
- `StreamCompressionModel.<encodeTable>e__FixedBuffer` (compiler-generated name)
- `StreamCompressionModel.SharedStaticCompressionModel`
- `UTF8ArrayUnsafeUtility.Comparison`
- `Unity.Collections.AllocatorHelper<T>`
- `Unity.Collections.ArrayOfArrays<T>`
- `Unity.Collections.AutoFreeAllocator`
- `Unity.Collections.AutoFreeAllocator.Try_000000E3$BurstDirectCall`
- `Unity.Collections.AutoFreeAllocator.Try_000000E3$PostfixBurstDelegate`
- `Unity.Collections.BitField32`
- `Unity.Collections.BitField32DebugView`
- `Unity.Collections.BitField64`
- `Unity.Collections.BitField64DebugView`
- `Unity.Collections.Bitwise`
- `Unity.Collections.BurstCompatibleAttribute`
- `Unity.Collections.ConcurrentMask`
- `Unity.Collections.CopyError`
- `Unity.Collections.DataStreamReader`
- `Unity.Collections.DataStreamWriter`
- `Unity.Collections.DoubleRewindableAllocators`
- `Unity.Collections.FixedBytes126`
- `Unity.Collections.FixedBytes128Align8`
- `Unity.Collections.FixedBytes16`
- `Unity.Collections.FixedBytes16Align8`
- `Unity.Collections.FixedBytes30`
- `Unity.Collections.FixedBytes32Align8`
- `Unity.Collections.FixedBytes4094`
- `Unity.Collections.FixedBytes4096Align8`
- `Unity.Collections.FixedBytes510`
- `Unity.Collections.FixedBytes512Align8`
- `Unity.Collections.FixedBytes62`
- `Unity.Collections.FixedBytes64Align8`
- `Unity.Collections.FixedList`
- `Unity.Collections.FixedList128Bytes<T>`
- `Unity.Collections.FixedList128BytesDebugView<T>`
- `Unity.Collections.FixedList128BytesExtensions`
- `Unity.Collections.FixedList32Bytes<T>`
- `Unity.Collections.FixedList32BytesDebugView<T>`
- `Unity.Collections.FixedList32BytesExtensions`
- `Unity.Collections.FixedList4096Bytes<T>`
- `Unity.Collections.FixedList4096BytesDebugView<T>`
- `Unity.Collections.FixedList4096BytesExtensions`
- `Unity.Collections.FixedList512Bytes<T>`
- `Unity.Collections.FixedList512BytesDebugView<T>`
- `Unity.Collections.FixedList512BytesExtensions`
- `Unity.Collections.FixedList64Bytes<T>`
- `Unity.Collections.FixedList64BytesDebugView<T>`
- `Unity.Collections.FixedList64BytesExtensions`
- `Unity.Collections.FixedList<T, U>`
- `Unity.Collections.FixedListExtensions`
- `Unity.Collections.FixedString`
- `Unity.Collections.FixedString128Bytes`
- `Unity.Collections.FixedString32Bytes`
- `Unity.Collections.FixedString4096Bytes`
- `Unity.Collections.FixedString512Bytes`
- `Unity.Collections.FixedString64Bytes`
- `Unity.Collections.FixedStringUtils`
- `Unity.Collections.FormatError`
- `Unity.Collections.HashSetExtensions`
- `Unity.Collections.INativeDisposable`
- `Unity.Collections.ListExtensions`
- `Unity.Collections.ListPair<Key, Value>`
- `Unity.Collections.Long1024`
- `Unity.Collections.Long512`
- `Unity.Collections.Long64`
- `Unity.Collections.Long8`
- `Unity.Collections.LowLevel.Unsafe.DataStreamExtensions`
- `Unity.Collections.LowLevel.Unsafe.HashSetExtensions`
- `Unity.Collections.LowLevel.Unsafe.NativeBitArrayUnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.NativeReferenceUnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible.Extensions`
- `Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer`
- `Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter32`
- `Unity.Collections.LowLevel.Unsafe.UnsafeAtomicCounter64`
- `Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafeHashSetDebuggerTypeProxy<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafeListExtensions`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBucketData`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSetDebuggerTypeProxy<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap<TKey, TValue>`
- `Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>`
- `Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafePtrListDebugView<T>`
- `Unity.Collections.LowLevel.Unsafe.UnsafePtrListExtensions`
- `Unity.Collections.LowLevel.Unsafe.UnsafeScratchAllocator`
- `Unity.Collections.LowLevel.Unsafe.UnsafeUtilityExtensions`
- `Unity.Collections.LowLevel.Unsafe.UntypedUnsafeParallelHashMap`
- `Unity.Collections.NativeBitArray`
- `Unity.Collections.NativeHashSet<T>`
- `Unity.Collections.NativeHashSetDebuggerTypeProxy<T>`
- `Unity.Collections.NativeKeyValueArrays<TKey, TValue>`
- `Unity.Collections.NativeListExtensions`
- `Unity.Collections.NativeParallelHashMapExtensions`
- `Unity.Collections.NativeParallelMultiHashMap<TKey, TValue>`
- `Unity.Collections.NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>`
- `Unity.Collections.NativeParallelMultiHashMapExtensions`
- `Unity.Collections.NativeQueue<T>`
- `Unity.Collections.NativeRingQueue<T>`
- `Unity.Collections.NativeRingQueueDebugView<T>`
- `Unity.Collections.NativeText`
- `Unity.Collections.NotBurstCompatible.Extensions`
- `Unity.Collections.Pair<Key, Value>`
- `Unity.Collections.ParseError`
- `Unity.Collections.RewindableAllocator`
- `Unity.Collections.RewindableAllocator.Try_000009F0$BurstDirectCall`
- `Unity.Collections.RewindableAllocator.Try_000009F0$PostfixBurstDelegate`
- `Unity.Collections.SortJob<T, U>`
- `Unity.Collections.SortJobDefer<T, U>`
- `Unity.Collections.Spinner`
- `Unity.Collections.StreamCompressionModel`
- `Unity.Collections.UIntFloat`
- `Unity.Collections.UTF8ArrayUnsafeUtility`
- `Unity.Collections.UnmanagedArray<T>`
- `Unity.Collections.xxHash3`
- `Unity.Collections.xxHash3.Hash128Long_00000A82$BurstDirectCall`
- `Unity.Collections.xxHash3.Hash128Long_00000A82$PostfixBurstDelegate`
- `Unity.Collections.xxHash3.Hash64Long_00000A7B$BurstDirectCall`
- `Unity.Collections.xxHash3.Hash64Long_00000A7B$PostfixBurstDelegate`
- `Unity.Collections.xxHashDefaultKey`
- `Unity.Jobs.IJobFilter`
- `Unity.Jobs.IJobFilterExtensions`
- `Unity.Jobs.IJobParallelForBatch`
- `Unity.Jobs.IJobParallelForBatchExtensions`
- `Unity.Jobs.IJobParallelForDefer`
- `Unity.Jobs.IJobParallelForDeferExtensions`
- `Unity.Jobs.IJobParallelForFilter`
- `Unity.Jobs.JobParallelIndexListExtensions`
- `Unity.Jobs.RegisterGenericJobTypeAttribute`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `UnsafeAppendBuffer.Reader`
- `UnsafeBitArray.ReadOnly`
- `UnsafeHashMap.Enumerator<TKey, TValue>`
- `UnsafeHashMap.ReadOnly<TKey, TValue>`
- `UnsafeHashSet.Enumerator<T>`
- `UnsafeHashSet.ReadOnly<T>`
- `UnsafeList.Enumerator<T>`
- `UnsafeList.ParallelReader<T>`
- `UnsafeList.ParallelWriter<T>`
- `UnsafeList.ReadOnly<T>`
- `UnsafeParallelHashMap.Enumerator<TKey, TValue>`
- `UnsafeParallelHashMap.ReadOnly<TKey, TValue>`
- `UnsafeParallelHashSet.Enumerator<T>`
- `UnsafeParallelHashSet.ParallelWriter<T>`
- `UnsafeParallelHashSet.ReadOnly<T>`
- `UnsafeParallelMultiHashMap.Enumerator<TKey, TValue>`
- `UnsafeParallelMultiHashMap.KeyValueEnumerator<TKey, TValue>`
- `UnsafeParallelMultiHashMap.ParallelWriter<TKey, TValue>`
- `UnsafeParallelMultiHashMap.ReadOnly<TKey, TValue>`
- `UnsafePtrList.ParallelReader<T>`
- `UnsafePtrList.ParallelWriter<T>`
- `UnsafePtrList.ReadOnly<T>`
- `UnsafeQueue.Enumerator<T>`
- `UnsafeQueue.ParallelWriter<T>`
- `UnsafeQueue.ReadOnly<T>`
- `UnsafeStream.Reader`
- `UnsafeStream.Writer`
- `xxHash3.StreamingState`
- `xxHash3.StreamingState.StreamingStateData`
- `xxHash3.ulong2`

</details>


## Unity.Mathematics.dll

<details><summary>Matching: 19</summary>

- `<Module>`
- `Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute`
- `Unity.Mathematics.Random`
- `Unity.Mathematics.bool2`
- `Unity.Mathematics.bool3`
- `Unity.Mathematics.bool4`
- `Unity.Mathematics.float2`
- `Unity.Mathematics.float3`
- `Unity.Mathematics.float4`
- `Unity.Mathematics.float4x4`
- `Unity.Mathematics.half2`
- `Unity.Mathematics.int2`
- `Unity.Mathematics.int3`
- `Unity.Mathematics.int4`
- `Unity.Mathematics.noise`
- `Unity.Mathematics.quaternion`
- `math.LongDoubleUnion`
- `math.RotationOrder`
- `math.ShuffleComponent`

</details>

<details><summary>Mismatching: 21</summary>

- `Unity.Mathematics.float2x2`

  - `field declaration order/names: ['c0', 'c1', 'identity'] → ['c0', 'c1', 'identity', 'zero']`
  - `extra field static float2x2 zero`

- `Unity.Mathematics.float2x3`

  - `field declaration order/names: ['c0', 'c1', 'c2'] → ['c0', 'c1', 'c2', 'zero']`
  - `extra field static float2x3 zero`

- `Unity.Mathematics.float3x3`

  - `field declaration order/names: ['c0', 'c1', 'c2', 'identity'] → ['c0', 'c1', 'c2', 'identity', 'zero']`
  - `extra field static float3x3 zero`

- `Unity.Mathematics.half`

  - `field declaration order/names: ['value'] → ['value', 'zero']`
  - `extra field static half zero`

- `Unity.Mathematics.math`

  - `field declaration order/names: [] → ['E_DBL', 'LOG2E_DBL', 'LOG10E_DBL', 'LN2_DBL', 'LN10_DBL', 'PI_DBL', 'PI2_DBL', 'PIHALF_DBL', 'TAU_DBL', 'TODEGREES_DBL', 'TORADIANS_DBL', 'SQRT2_DBL', 'EPSILON_DBL', 'INFINITY_DBL', 'NAN_DBL', 'FLT_MIN_NORMAL', 'DBL_MIN_NORMAL', 'E', 'LOG2E', 'LOG10E', 'LN2', 'LN10', 'PI', 'PI2', 'PIHALF', 'TAU', 'TODEGREES', 'TORADIANS', 'SQRT2', 'EPSILON', 'INFINITY', 'NAN']`
  - `extra field constant double E_DBL`
  - `extra field constant double LOG2E_DBL`
  - `extra field constant double LOG10E_DBL`
  - `extra field constant double LN2_DBL`
  - `extra field constant double LN10_DBL`
  - `extra field constant double PI_DBL`
  - `extra field constant double PI2_DBL`
  - `extra field constant double PIHALF_DBL`
  - `extra field constant double TAU_DBL`
  - `extra field constant double TODEGREES_DBL`
  - `extra field constant double TORADIANS_DBL`
  - `extra field constant double SQRT2_DBL`
  - `extra field constant double EPSILON_DBL`
  - `extra field constant double INFINITY_DBL`
  - `extra field constant double NAN_DBL`
  - `extra field constant float FLT_MIN_NORMAL`
  - `extra field constant double DBL_MIN_NORMAL`
  - `extra field constant float E`
  - `extra field constant float LOG2E`
  - `extra field constant float LOG10E`
  - `extra field constant float LN2`
  - `extra field constant float LN10`
  - `extra field constant float PI`
  - `extra field constant float PI2`
  - `extra field constant float PIHALF`
  - `extra field constant float TAU`
  - `extra field constant float TODEGREES`
  - `extra field constant float TORADIANS`
  - `extra field constant float SQRT2`
  - `extra field constant float EPSILON`
  - `extra field constant float INFINITY`
  - `extra field constant float NAN`

- `Unity.Mathematics.uint2`

  - `field declaration order/names: ['x', 'y'] → ['x', 'y', 'zero']`
  - `extra field static uint2 zero`

- `Unity.Mathematics.uint3`

  - `field declaration order/names: ['x', 'y', 'z'] → ['x', 'y', 'z', 'zero']`
  - `extra field static uint3 zero`

- `Unity.Mathematics.uint4`

  - `field declaration order/names: ['x', 'y', 'z', 'w'] → ['x', 'y', 'z', 'w', 'zero']`
  - `extra field static uint4 zero`

- `bool2.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y']`
  - `extra field instance bool x`
  - `extra field instance bool y`

- `bool3.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z']`
  - `extra field instance bool x`
  - `extra field instance bool y`
  - `extra field instance bool z`

- `bool4.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z', 'w']`
  - `extra field instance bool x`
  - `extra field instance bool y`
  - `extra field instance bool z`
  - `extra field instance bool w`

- `float2.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y']`
  - `extra field instance float x`
  - `extra field instance float y`

- `float3.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z']`
  - `extra field instance float x`
  - `extra field instance float y`
  - `extra field instance float z`

- `float4.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z', 'w']`
  - `extra field instance float x`
  - `extra field instance float y`
  - `extra field instance float z`
  - `extra field instance float w`

- `half2.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y']`
  - `extra field instance half x`
  - `extra field instance half y`

- `int2.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y']`
  - `extra field instance int x`
  - `extra field instance int y`

- `int3.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z']`
  - `extra field instance int x`
  - `extra field instance int y`
  - `extra field instance int z`

- `int4.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z', 'w']`
  - `extra field instance int x`
  - `extra field instance int y`
  - `extra field instance int z`
  - `extra field instance int w`

- `uint2.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y']`
  - `extra field instance uint x`
  - `extra field instance uint y`

- `uint3.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z']`
  - `extra field instance uint x`
  - `extra field instance uint y`
  - `extra field instance uint z`

- `uint4.DebuggerProxy`

  - `field declaration order/names: [] → ['x', 'y', 'z', 'w']`
  - `extra field instance uint x`
  - `extra field instance uint y`
  - `extra field instance uint z`
  - `extra field instance uint w`


</details>

<details><summary>Extra: 64</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5559`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=8823`
- `Unity.Mathematics.AffineTransform`
- `Unity.Mathematics.DoNotNormalizeAttribute`
- `Unity.Mathematics.Geometry.Math`
- `Unity.Mathematics.Geometry.MinMaxAABB`
- `Unity.Mathematics.Geometry.Plane`
- `Unity.Mathematics.PostNormalizeAttribute`
- `Unity.Mathematics.RigidTransform`
- `Unity.Mathematics.bool2x2`
- `Unity.Mathematics.bool2x3`
- `Unity.Mathematics.bool2x4`
- `Unity.Mathematics.bool3x2`
- `Unity.Mathematics.bool3x3`
- `Unity.Mathematics.bool3x4`
- `Unity.Mathematics.bool4x2`
- `Unity.Mathematics.bool4x3`
- `Unity.Mathematics.bool4x4`
- `Unity.Mathematics.double2`
- `Unity.Mathematics.double2x2`
- `Unity.Mathematics.double2x3`
- `Unity.Mathematics.double2x4`
- `Unity.Mathematics.double3`
- `Unity.Mathematics.double3x2`
- `Unity.Mathematics.double3x3`
- `Unity.Mathematics.double3x4`
- `Unity.Mathematics.double4`
- `Unity.Mathematics.double4x2`
- `Unity.Mathematics.double4x3`
- `Unity.Mathematics.double4x4`
- `Unity.Mathematics.float2x4`
- `Unity.Mathematics.float3x2`
- `Unity.Mathematics.float3x4`
- `Unity.Mathematics.float4x2`
- `Unity.Mathematics.float4x3`
- `Unity.Mathematics.half3`
- `Unity.Mathematics.half4`
- `Unity.Mathematics.int2x2`
- `Unity.Mathematics.int2x3`
- `Unity.Mathematics.int2x4`
- `Unity.Mathematics.int3x2`
- `Unity.Mathematics.int3x3`
- `Unity.Mathematics.int3x4`
- `Unity.Mathematics.int4x2`
- `Unity.Mathematics.int4x3`
- `Unity.Mathematics.int4x4`
- `Unity.Mathematics.svd`
- `Unity.Mathematics.uint2x2`
- `Unity.Mathematics.uint2x3`
- `Unity.Mathematics.uint2x4`
- `Unity.Mathematics.uint3x2`
- `Unity.Mathematics.uint3x3`
- `Unity.Mathematics.uint3x4`
- `Unity.Mathematics.uint4x2`
- `Unity.Mathematics.uint4x3`
- `Unity.Mathematics.uint4x4`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `double2.DebuggerProxy`
- `double3.DebuggerProxy`
- `double4.DebuggerProxy`
- `half3.DebuggerProxy`
- `half4.DebuggerProxy`

</details>


## Unity.Profiling.Core.dll

<details><summary>Matching: 4</summary>

- `<Module>`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `Unity.Profiling.ProfilerCounterValue<T>`

</details>

<details><summary>Extra: 14</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=355`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=689`
- `ProfilerMarker.AutoScope<TP1, TP2, TP3>`
- `ProfilerMarker.AutoScope<TP1, TP2>`
- `ProfilerMarker.AutoScope<TP1>`
- `Unity.Profiling.ProfilerCounter<T>`
- `Unity.Profiling.ProfilerMarker<TP1, TP2, TP3>`
- `Unity.Profiling.ProfilerMarker<TP1, TP2>`
- `Unity.Profiling.ProfilerMarker<TP1>`
- `Unity.Profiling.ProfilerMarkerExtension`
- `Unity.Profiling.ProfilerUtility`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.RenderPipelines.Core.Runtime.dll

<details><summary>Matching: 257</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `AtlasAllocator.<>c` (compiler-generated name)
- `AtlasAllocator.AtlasNode`
- `Blitter.BlitShaderIDs`
- `BoolParameter.DisplayType`
- `CommandBufferPool.<>c` (compiler-generated name)
- `CoreUtils.<>c` (compiler-generated name)
- `DebugActionState.DebugActionKeyType`
- `DebugDisplaySettingsUI.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.SettingsPanel`
- `DebugDisplaySettingsVolume.Styles`
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass1_0` (compiler-generated name)
- `DebugManager.<>c` (compiler-generated name)
- `DebugManager.UIMode`
- `DebugManager.UIState`
- `DebugUI.BitField`
- `DebugUI.BoolField`
- `DebugUI.Button`
- `DebugUI.ColorField`
- `DebugUI.Container`
- `DebugUI.EnumField.<>c` (compiler-generated name)
- `DebugUI.Flags`
- `DebugUI.FloatField`
- `DebugUI.Foldout.ContextMenuItem`
- `DebugUI.HistoryBoolField`
- `DebugUI.IContainer`
- `DebugUI.IntField`
- `DebugUI.MessageBox`
- `DebugUI.MessageBox.Style`
- `DebugUI.ObjectField`
- `DebugUI.ObjectListField`
- `DebugUI.ObjectPopupField`
- `DebugUI.Panel`
- `DebugUI.Panel.<>c` (compiler-generated name)
- `DebugUI.ProgressBarValue`
- `DebugUI.Table`
- `DebugUI.Table.Row`
- `DebugUI.UIntField`
- `DebugUI.Value`
- `DebugUI.ValueTuple`
- `DebugUI.Vector2Field`
- `DebugUI.Vector3Field`
- `DebugUI.Vector4Field`
- `DebugUI.Widget`
- `DebugUI.Widget.NameAndTooltip`
- `DebugUIHandlerCanvas.<>c` (compiler-generated name)
- `DebugUIHandlerCanvas.<>c__DisplayClass14_0` (compiler-generated name)
- `DebugUIHandlerContainer.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugUIHandlerEnumHistory.<RefreshAfterSanitization>d__4` (compiler-generated name)
- `DebugUIHandlerPersistentCanvas.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugUIHandlerPersistentCanvas.<>c__DisplayClass5_0` (compiler-generated name)
- `DebugUIHandlerToggleHistory.<RefreshAfterSanitization>d__4` (compiler-generated name)
- `DebugUpdater.<DoAfterInputModuleUpdated>d__9` (compiler-generated name)
- `DebugUpdater.<RefreshRuntimeUINextFrame>d__14` (compiler-generated name)
- `DynamicResolutionHandler.ScalerContainer`
- `DynamicResolutionHandler.UpsamplerScheduleType`
- `FSRUtils.ShaderConstants`
- `FrameTimeSampleHistory.<>c` (compiler-generated name)
- `HDROutputUtils.HDRDisplayInformation`
- `HDROutputUtils.Operation`
- `HDROutputUtils.ShaderPropertyId`
- `HableCurve.DirectParams`
- `HableCurve.Segment`
- `HableCurve.Uniforms`
- `LensFlareCommonSRP.<>c__DisplayClass21_0` (compiler-generated name)
- `LensFlareCommonSRP.<>c__DisplayClass22_0` (compiler-generated name)
- `LensFlareCommonSRP.<>c__DisplayClass40_0` (compiler-generated name)
- `LensFlareCommonSRP.<>c__DisplayClass40_1` (compiler-generated name)
- `LensFlareCommonSRP.<>c__DisplayClass40_2` (compiler-generated name)
- `LensFlareCommonSRP.LensFlareCompInfo`
- `PowerOfTwoTextureAtlas.BlitType`
- `ReloadAttribute.Package`
- `RenderGraph.CompiledPassInfo`
- `RenderGraph.CompiledResourceInfo`
- `RenderGraph.OnExecutionRegisteredDelegate`
- `RenderGraph.OnGraphRegisteredDelegate`
- `RenderGraphDebugData.PassDebugData`
- `RenderGraphDebugData.ResourceDebugData`
- `RenderGraphObjectPool.SharedObjectPoolBase`
- `RenderGraphResourceRegistry.RenderGraphResourcesData`
- `RenderGraphResourceRegistry.ResourceCallback`
- `RenderGraphResourceRegistry.ResourceCreateCallback`
- `Texture2DAtlas.BlitType`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferPool`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.DepthAccess`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.FastMemoryDesc`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<PassData>`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphBuilder`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugData`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDefaultResources`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphExecution`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogIndent`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphLogger`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphObjectPool`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphParameters`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfileId`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceType`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListHandle`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RendererListResource`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.ResourceHandle`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.TexturePool`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.TextureResource`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode`
- `UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants`
- `UnityEngine.Experimental.Rendering.XRLayout`
- `UnityEngine.Experimental.Rendering.XRMirrorView`
- `UnityEngine.Experimental.Rendering.XROcclusionMesh`
- `UnityEngine.Experimental.Rendering.XRPass`
- `UnityEngine.Experimental.Rendering.XRPassCreateInfo`
- `UnityEngine.Experimental.Rendering.XRSystem`
- `UnityEngine.Experimental.Rendering.XRView`
- `UnityEngine.Rendering.AdditionalPropertyAttribute`
- `UnityEngine.Rendering.ArrayExtensions`
- `UnityEngine.Rendering.AtlasAllocator`
- `UnityEngine.Rendering.Blitter`
- `UnityEngine.Rendering.BoolParameter`
- `UnityEngine.Rendering.BottleneckHistogram`
- `UnityEngine.Rendering.BottleneckHistory`
- `UnityEngine.Rendering.CameraCaptureBridge`
- `UnityEngine.Rendering.ClampedFloatParameter`
- `UnityEngine.Rendering.ClampedIntParameter`
- `UnityEngine.Rendering.ClearFlag`
- `UnityEngine.Rendering.ColorParameter`
- `UnityEngine.Rendering.ColorSpaceUtils`
- `UnityEngine.Rendering.ColorUtils`
- `UnityEngine.Rendering.CommandBufferPool`
- `UnityEngine.Rendering.ConstantBuffer`
- `UnityEngine.Rendering.ConstantBufferBase`
- `UnityEngine.Rendering.CoreMatrixUtils`
- `UnityEngine.Rendering.CoreProfileId`
- `UnityEngine.Rendering.CoreUnsafeUtils`
- `UnityEngine.Rendering.DebugAction`
- `UnityEngine.Rendering.DebugActionDesc`
- `UnityEngine.Rendering.DebugActionRepeatMode`
- `UnityEngine.Rendering.DebugActionState`
- `UnityEngine.Rendering.DebugDisplaySettingsPanel`
- `UnityEngine.Rendering.DebugDisplaySettingsUI`
- `UnityEngine.Rendering.DebugDisplaySettingsVolume`
- `UnityEngine.Rendering.DebugFrameTiming`
- `UnityEngine.Rendering.DebugUI`
- `UnityEngine.Rendering.DebugUpdater`
- `UnityEngine.Rendering.DepthBits`
- `UnityEngine.Rendering.DisplayInfoAttribute`
- `UnityEngine.Rendering.DynamicResScalePolicyType`
- `UnityEngine.Rendering.DynamicResScalerSlot`
- `UnityEngine.Rendering.DynamicResUpscaleFilter`
- `UnityEngine.Rendering.DynamicResolutionType`
- `UnityEngine.Rendering.FloatParameter`
- `UnityEngine.Rendering.FrameTimeSample`
- `UnityEngine.Rendering.FrameTimeSampleHistory`
- `UnityEngine.Rendering.GenerateHLSL`
- `UnityEngine.Rendering.GlobalDynamicResolutionSettings`
- `UnityEngine.Rendering.HDROutputUtils`
- `UnityEngine.Rendering.HLSLArray`
- `UnityEngine.Rendering.HableCurve`
- `UnityEngine.Rendering.HaltonSequence`
- `UnityEngine.Rendering.IAdditionalData`
- `UnityEngine.Rendering.IDebugData`
- `UnityEngine.Rendering.IDebugDisplaySettings`
- `UnityEngine.Rendering.IDebugDisplaySettingsData`
- `UnityEngine.Rendering.IDebugDisplaySettingsPanel`
- `UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable`
- `UnityEngine.Rendering.IDebugDisplaySettingsQuery`
- `UnityEngine.Rendering.IVolume`
- `UnityEngine.Rendering.IVolumeDebugSettings`
- `UnityEngine.Rendering.IVolumeDebugSettings2`
- `UnityEngine.Rendering.IntParameter`
- `UnityEngine.Rendering.LensFlareCommonSRP`
- `UnityEngine.Rendering.LensFlareComponentSRP`
- `UnityEngine.Rendering.LensFlareDataElementSRP`
- `UnityEngine.Rendering.LensFlareDataSRP`
- `UnityEngine.Rendering.ListChangedEventHandler<T>`
- `UnityEngine.Rendering.MSAASamples`
- `UnityEngine.Rendering.MinFloatParameter`
- `UnityEngine.Rendering.NoInterpCubemapParameter`
- `UnityEngine.Rendering.NoInterpTextureParameter`
- `UnityEngine.Rendering.NoInterpVector3Parameter`
- `UnityEngine.Rendering.PackingRules`
- `UnityEngine.Rendering.PerformDynamicRes`
- `UnityEngine.Rendering.PerformanceBottleneck`
- `UnityEngine.Rendering.ProfilingSampler`
- `UnityEngine.Rendering.ProfilingScope`
- `UnityEngine.Rendering.RTHandle`
- `UnityEngine.Rendering.RTHandleProperties`
- `UnityEngine.Rendering.RTHandleStaticHelpers`
- `UnityEngine.Rendering.RTHandleSystem`
- `UnityEngine.Rendering.RTHandles`
- `UnityEngine.Rendering.ReloadAttribute`
- `UnityEngine.Rendering.ReloadGroupAttribute`
- `UnityEngine.Rendering.RenderPipelineGraphicsSettingsContainer`
- `UnityEngine.Rendering.SRPLensFlareBlendMode`
- `UnityEngine.Rendering.SRPLensFlareDistribution`
- `UnityEngine.Rendering.SRPLensFlareType`
- `UnityEngine.Rendering.ScaleFunc`
- `UnityEngine.Rendering.ShaderGenUInt4`
- `UnityEngine.Rendering.ShaderVariantLogLevel`
- `UnityEngine.Rendering.Texture2DAtlas`
- `UnityEngine.Rendering.TextureCurve`
- `UnityEngine.Rendering.TextureCurveParameter`
- `UnityEngine.Rendering.TextureParameter`
- `UnityEngine.Rendering.UI.DebugUIHandlerBitField`
- `UnityEngine.Rendering.UI.DebugUIHandlerButton`
- `UnityEngine.Rendering.UI.DebugUIHandlerCanvas`
- `UnityEngine.Rendering.UI.DebugUIHandlerColor`
- `UnityEngine.Rendering.UI.DebugUIHandlerContainer`
- `UnityEngine.Rendering.UI.DebugUIHandlerEnumField`
- `UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory`
- `UnityEngine.Rendering.UI.DebugUIHandlerFloatField`
- `UnityEngine.Rendering.UI.DebugUIHandlerFoldout`
- `UnityEngine.Rendering.UI.DebugUIHandlerGroup`
- `UnityEngine.Rendering.UI.DebugUIHandlerHBox`
- `UnityEngine.Rendering.UI.DebugUIHandlerIndirectFloatField`
- `UnityEngine.Rendering.UI.DebugUIHandlerIndirectToggle`
- `UnityEngine.Rendering.UI.DebugUIHandlerIntField`
- `UnityEngine.Rendering.UI.DebugUIHandlerMessageBox`
- `UnityEngine.Rendering.UI.DebugUIHandlerObject`
- `UnityEngine.Rendering.UI.DebugUIHandlerObjectList`
- `UnityEngine.Rendering.UI.DebugUIHandlerObjectPopupField`
- `UnityEngine.Rendering.UI.DebugUIHandlerPanel`
- `UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas`
- `UnityEngine.Rendering.UI.DebugUIHandlerProgressBar`
- `UnityEngine.Rendering.UI.DebugUIHandlerRow`
- `UnityEngine.Rendering.UI.DebugUIHandlerToggle`
- `UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory`
- `UnityEngine.Rendering.UI.DebugUIHandlerUIntField`
- `UnityEngine.Rendering.UI.DebugUIHandlerVBox`
- `UnityEngine.Rendering.UI.DebugUIHandlerValue`
- `UnityEngine.Rendering.UI.DebugUIHandlerValueTuple`
- `UnityEngine.Rendering.UI.DebugUIHandlerVector2`
- `UnityEngine.Rendering.UI.DebugUIHandlerVector3`
- `UnityEngine.Rendering.UI.DebugUIHandlerVector4`
- `UnityEngine.Rendering.UI.DebugUIHandlerWidget`
- `UnityEngine.Rendering.UI.DebugUIPrefabBundle`
- `UnityEngine.Rendering.UI.UIFoldout`
- `UnityEngine.Rendering.Vector2Parameter`
- `UnityEngine.Rendering.Vector3Parameter`
- `UnityEngine.Rendering.Vector4Parameter`
- `UnityEngine.Rendering.Volume`
- `UnityEngine.Rendering.VolumeComponent`
- `UnityEngine.Rendering.VolumeComponentMenu`
- `UnityEngine.Rendering.VolumeComponentMenuForRenderPipeline`
- `UnityEngine.Rendering.VolumeParameter`
- `UnityEngine.Rendering.VolumeProfile`
- `UnityEngine.Rendering.VolumeStack`
- `UnityEngine.Rendering.XRGraphicsAutomatedTests`
- `VolumeComponent.<>c` (compiler-generated name)
- `VolumeManager.<>c` (compiler-generated name)
- `VolumeProfile.<>c` (compiler-generated name)

</details>

<details><summary>Mismatching: 23</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE'] → ['38793233ADA900082A111C7E55EFE257E4D5F249D46AD2DF189B753957ECB809', '45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097', '4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A', '90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4', 'BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158', 'C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF', 'EF53164C3F32C788A4FF2947C64BC24931A5C9584E065F82C97B3F809D88CB58', 'FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE']`
  - `FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE: offset '0x0' → '0xb650'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20324 38793233ADA900082A111C7E55EFE257E4D5F249D46AD2DF189B753957ECB809`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20316 EF53164C3F32C788A4FF2947C64BC24931A5C9584E065F82C97B3F809D88CB58`

- `DebugDisplaySettingsVolume.Strings`

  - `field declaration order/names: ['none', 'camera', 'parameter', 'component', 'debugViewNotSupported', 'volumeInfo', 'interpolatedValue', 'defaultValue', 'global', 'local'] → ['none', 'camera', 'parameter', 'component', 'debugViewNotSupported', 'parameterNotOverrided', 'volumeInfo', 'gameObject', 'resultValue', 'resultValueTooltip', 'globalDefaultValue', 'globalDefaultValueTooltip', 'qualityLevelValue', 'qualityLevelValueTooltip', 'interpolatedValue', 'defaultValue', 'global', 'local', 'volumeProfile']`
  - `volumeInfo: offset '0x28' → '0x30'`
  - `interpolatedValue: offset '0x30' → '0x70'`
  - `defaultValue: offset '0x38' → '0x78'`
  - `global: offset '0x40' → '0x80'`
  - `local: offset '0x48' → '0x88'`
  - `extra field static string parameterNotOverrided`
  - `extra field static string gameObject`
  - `extra field static string resultValue`
  - `extra field static string resultValueTooltip`
  - `extra field static string globalDefaultValue`
  - `extra field static string globalDefaultValueTooltip`
  - `extra field static string qualityLevelValue`
  - `extra field static string qualityLevelValueTooltip`
  - `extra field static string volumeProfile`

- `DebugDisplaySettingsVolume.WidgetFactory`

  - `field declaration order/names: [] → ['s_EmptyDebugUIValue']`
  - `extra field static DebugUI.Value s_EmptyDebugUIValue`

- `DebugDisplaySettingsVolume.WidgetFactory.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__2_0', '<>9__2_6', '<>9__3_2', '<>9__3_3', '<>9__3_6', '<>9__3_7', '<>9__3_9', '<>9__3_11'] → ['<>9', '<>9__9_2']`
  - `missing field static Func<object> <>9__2_0`
  - `missing field static Func<object> <>9__2_6`
  - `missing field static Func<object> <>9__3_2`
  - `missing field static Func<object> <>9__3_3`
  - `missing field static Func<object> <>9__3_6`
  - `missing field static Func<object> <>9__3_7`
  - `missing field static Func<FieldInfo, int> <>9__3_9`
  - `missing field static Func<DebugUI.Table.Row, string> <>9__3_11`
  - `extra field static Func<object> <>9__9_2`

- `DebugUI.EnumField`

  - `field declaration order/names: ['quickSeparators', '<getIndex>k__BackingField', '<setIndex>k__BackingField'] → ['quickSeparators', 'm_Indexes', '<getIndex>k__BackingField', '<setIndex>k__BackingField']`
  - `<getIndex>k__BackingField: offset '0x78' → '0x80'`
  - `<setIndex>k__BackingField: offset '0x80' → '0x88'`
  - `extra field instance int[] m_Indexes`

- `DebugUI.Field<T>`

  - `bases: 'DebugUI.Widget' → 'DebugUI.Widget, DebugUI.IValueField'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DebugUI.Foldout`

  - `bases: 'DebugUI.Container' → 'DebugUI.Container, DebugUI.IValueField'`

- `DebugUI.HistoryEnumField`

  - `<historyIndexGetter>k__BackingField: offset '0x88' → '0x90'`

- `HDROutputUtils.ShaderKeywords`

  - `field declaration order/names: ['HDRColorSpaceConversion', 'HDREncoding', 'HDRColorSpaceConversionAndEncoding', 'HDRInput'] → ['HDR_COLORSPACE_CONVERSION', 'HDR_ENCODING', 'HDR_COLORSPACE_CONVERSION_AND_ENCODING', 'HDR_INPUT', 'HDRColorSpaceConversion', 'HDREncoding', 'HDRColorSpaceConversionAndEncoding', 'HDRInput']`
  - `extra field constant string HDR_COLORSPACE_CONVERSION`
  - `extra field constant string HDR_ENCODING`
  - `extra field constant string HDR_COLORSPACE_CONVERSION_AND_ENCODING`
  - `extra field constant string HDR_INPUT`

- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphDebugParams`

  - `field declaration order/names: ['clearRenderTargetsAtCreation', 'clearRenderTargetsAtRelease', 'disablePassCulling', 'immediateMode', 'enableLogging', 'logFrameInformation', 'logResources'] → ['m_DebugItems', 'm_DebugPanel', 'clearRenderTargetsAtCreation', 'clearRenderTargetsAtRelease', 'disablePassCulling', 'immediateMode', 'enableLogging', 'logFrameInformation', 'logResources']`
  - `clearRenderTargetsAtCreation: offset '0x10' → '0x20'`
  - `clearRenderTargetsAtRelease: offset '0x11' → '0x21'`
  - `disablePassCulling: offset '0x12' → '0x22'`
  - `immediateMode: offset '0x13' → '0x23'`
  - `enableLogging: offset '0x14' → '0x24'`
  - `logFrameInformation: offset '0x15' → '0x25'`
  - `logResources: offset '0x16' → '0x26'`
  - `extra field instance DebugUI.Widget[] m_DebugItems`
  - `extra field instance DebugUI.Panel m_DebugPanel`

- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourcePool<Type>`

  - `field declaration order/names: ['m_ResourcePool', 'm_RemoveList', 'm_FrameAllocatedResources', 's_CurrentFrameIndex'] → ['m_ResourcePool', 'm_RemoveList', 'm_FrameAllocatedResources', 's_CurrentFrameIndex', 'kStaleResourceLifetime']`
  - `extra field constant int kStaleResourceLifetime`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry`

  - `field declaration order/names: ['m_CurrentRegistry', 'm_RenderGraphResources', 'm_RendererListResources', 'm_RenderGraphDebug', 'm_ResourceLogger', 'm_FrameInformationLogger', 'm_CurrentFrameIndex', 'm_ExecutionCount', 'm_CurrentBackbuffer', 'm_ActiveRendererLists'] → ['kSharedResourceLifetime', 'm_CurrentRegistry', 'm_RenderGraphResources', 'm_RendererListResources', 'm_RenderGraphDebug', 'm_ResourceLogger', 'm_FrameInformationLogger', 'm_CurrentFrameIndex', 'm_ExecutionCount', 'm_CurrentBackbuffer', 'kInitialRendererListCount', 'm_ActiveRendererLists']`
  - `extra field constant int kSharedResourceLifetime`
  - `extra field constant int kInitialRendererListCount`

- `UnityEngine.Rendering.CoreUtils`

  - `field declaration order/names: ['lookAtList', 'upVectorList', 'm_BlackCubeTexture', 'm_AssemblyTypes'] → ['lookAtList', 'upVectorList', 'obsoletePriorityMessage', 'editMenuPriority1', 'editMenuPriority2', 'editMenuPriority3', 'editMenuPriority4', 'assetCreateMenuPriority1', 'assetCreateMenuPriority2', 'assetCreateMenuPriority3', 'gameObjectMenuPriority', 'm_BlackCubeTexture', 'm_MagentaCubeTexture', 'm_MagentaCubeTextureArray', 'm_WhiteCubeTexture', 'm_EmptyUAV', 'm_BlackVolumeTexture', 'm_AssemblyTypes']`
  - `m_AssemblyTypes: offset '0x18' → '0x40'`
  - `extra field constant string obsoletePriorityMessage`
  - `extra field constant int editMenuPriority1`
  - `extra field constant int editMenuPriority2`
  - `extra field constant int editMenuPriority3`
  - `extra field constant int editMenuPriority4`
  - `extra field constant int assetCreateMenuPriority1`
  - `extra field constant int assetCreateMenuPriority2`
  - `extra field constant int assetCreateMenuPriority3`
  - `extra field constant int gameObjectMenuPriority`
  - `extra field static Cubemap m_MagentaCubeTexture`
  - `extra field static CubemapArray m_MagentaCubeTextureArray`
  - `extra field static Cubemap m_WhiteCubeTexture`
  - `extra field static RenderTexture m_EmptyUAV`
  - `extra field static Texture3D m_BlackVolumeTexture`

- `UnityEngine.Rendering.DebugManager`

  - `field declaration order/names: ['m_DebugActions', 'm_DebugActionStates', 'windowStateChanged', 'editorUIState', 'm_EnableRuntimeUI', 'runtimeUIState', 's_Instance', 'm_ReadOnlyPanels', 'm_Panels', 'onDisplayRuntimeUIChanged', 'onSetDirty', 'resetData', 'refreshEditorRequested', 'm_RequestedPanelIndex', 'm_Root', 'm_RootUICanvas', 'm_PersistentRoot', 'm_RootUIPersistentCanvas'] → ['kEnableDebugBtn1', 'kEnableDebugBtn2', 'kDebugPreviousBtn', 'kDebugNextBtn', 'kValidateBtn', 'kPersistentBtn', 'kDPadVertical', 'kDPadHorizontal', 'kMultiplierBtn', 'kResetBtn', 'kEnableDebug', 'm_DebugActions', 'm_DebugActionStates', 'windowStateChanged', 'editorUIState', 'm_EnableRuntimeUI', 'runtimeUIState', 's_Instance', 'm_ReadOnlyPanels', 'm_Panels', 'onDisplayRuntimeUIChanged', 'onSetDirty', 'resetData', 'refreshEditorRequested', 'm_RequestedPanelIndex', 'm_Root', 'm_RootUICanvas', 'm_PersistentRoot', 'm_RootUIPersistentCanvas']`
  - `extra field constant string kEnableDebugBtn1`
  - `extra field constant string kEnableDebugBtn2`
  - `extra field constant string kDebugPreviousBtn`
  - `extra field constant string kDebugNextBtn`
  - `extra field constant string kValidateBtn`
  - `extra field constant string kPersistentBtn`
  - `extra field constant string kDPadVertical`
  - `extra field constant string kDPadHorizontal`
  - `extra field constant string kMultiplierBtn`
  - `extra field constant string kResetBtn`
  - `extra field constant string kEnableDebug`

- `UnityEngine.Rendering.DynamicResolutionHandler`

  - `field declaration order/names: ['m_Enabled', 'm_UseMipBias', 'm_MinScreenFraction', 'm_MaxScreenFraction', 'm_CurrentFraction', 'm_ForcingRes', 'm_CurrentCameraRequest', 'm_PrevFraction', 'm_ForceSoftwareFallback', 'm_RunUpscalerFilterOnFullResolution', 'm_PrevHWScaleWidth', 'm_PrevHWScaleHeight', 'm_LastScaledSize', 's_ActiveScalerSlot', 's_ScalerContainers', '<filter>k__BackingField', 's_CameraUpscaleFilters', '<finalViewport>k__BackingField', 'type', 'm_CachedSettings', 's_CameraInstances', 's_DefaultInstance', 's_ActiveCameraId', 's_ActiveInstance', 's_ActiveInstanceDirty', 's_GlobalHwFraction', 's_GlobalHwUpresActive', 'm_UpsamplerSchedule'] → ['m_Enabled', 'm_UseMipBias', 'm_MinScreenFraction', 'm_MaxScreenFraction', 'm_CurrentFraction', 'm_ForcingRes', 'm_CurrentCameraRequest', 'm_PrevFraction', 'm_ForceSoftwareFallback', 'm_RunUpscalerFilterOnFullResolution', 'm_PrevHWScaleWidth', 'm_PrevHWScaleHeight', 'm_LastScaledSize', 's_ActiveScalerSlot', 's_ScalerContainers', '<filter>k__BackingField', 's_CameraUpscaleFilters', '<finalViewport>k__BackingField', 'type', 'm_CachedSettings', 'CameraDictionaryMaxcCapacity', 'm_OwnerCameraWeakRef', 's_CameraInstances', 's_DefaultInstance', 's_ActiveCameraId', 's_ActiveInstance', 's_ActiveInstanceDirty', 's_GlobalHwFraction', 's_GlobalHwUpresActive', 'm_UpsamplerSchedule']`
  - `m_UpsamplerSchedule: offset '0x88' → '0x90'`
  - `extra field constant int CameraDictionaryMaxcCapacity`
  - `extra field instance WeakReference m_OwnerCameraWeakRef`

- `UnityEngine.Rendering.FSRUtils`

  - `field declaration order/names: [] → ['kMaxSharpnessStops', 'kDefaultSharpnessStops', 'kDefaultSharpnessLinear']`
  - `extra field constant float kMaxSharpnessStops`
  - `extra field constant float kDefaultSharpnessStops`
  - `extra field constant float kDefaultSharpnessLinear`

- `UnityEngine.Rendering.HashFNV1A32`

  - `field declaration order/names: ['m_Hash'] → ['k_Prime', 'k_OffsetBasis', 'm_Hash']`
  - `extra field constant uint k_Prime`
  - `extra field constant uint k_OffsetBasis`

- `UnityEngine.Rendering.ObjectParameter<T>`

  - `field declaration order/names: [] → ['<parameters>k__BackingField']`
  - `extra field instance ReadOnlyCollection<VolumeParameter> <parameters>k__BackingField`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.PowerOfTwoTextureAtlas`

  - `field declaration order/names: ['m_MipPadding', 'm_RequestedTextures'] → ['m_MipPadding', 'k_MipmapFactorApprox', 'm_RequestedTextures']`
  - `extra field constant float k_MipmapFactorApprox`

- `UnityEngine.Rendering.TextureXR`

  - `field declaration order/names: ['m_MaxViews', 'm_BlackUIntTexture2DArrayRTH', 'm_BlackUIntTextureRTH', 'm_ClearTexture2DArrayRTH', 'm_ClearTextureRTH', 'm_MagentaTexture2DArrayRTH', 'm_MagentaTextureRTH', 'm_BlackTexture2DArrayRTH', 'm_BlackTextureRTH', 'm_BlackTexture3DRTH', 'm_WhiteTexture2DArrayRTH', 'm_WhiteTextureRTH'] → ['m_MaxViews', 'm_BlackUIntTexture2DArray', 'm_BlackUIntTexture', 'm_BlackUIntTexture2DArrayRTH', 'm_BlackUIntTextureRTH', 'm_ClearTexture2DArray', 'm_ClearTexture', 'm_ClearTexture2DArrayRTH', 'm_ClearTextureRTH', 'm_MagentaTexture2DArray', 'm_MagentaTexture', 'm_MagentaTexture2DArrayRTH', 'm_MagentaTextureRTH', 'm_BlackTexture', 'm_BlackTexture3D', 'm_BlackTexture2DArray', 'm_BlackTexture2DArrayRTH', 'm_BlackTextureRTH', 'm_BlackTexture3DRTH', 'm_WhiteTexture2DArray', 'm_WhiteTexture2DArrayRTH', 'm_WhiteTextureRTH']`
  - `m_BlackUIntTexture2DArrayRTH: offset '0x8' → '0x18'`
  - `m_BlackUIntTextureRTH: offset '0x10' → '0x20'`
  - `m_ClearTexture2DArrayRTH: offset '0x18' → '0x38'`
  - `m_ClearTextureRTH: offset '0x20' → '0x40'`
  - `m_MagentaTexture2DArrayRTH: offset '0x28' → '0x58'`
  - `m_MagentaTextureRTH: offset '0x30' → '0x60'`
  - `m_BlackTexture2DArrayRTH: offset '0x38' → '0x80'`
  - `m_BlackTextureRTH: offset '0x40' → '0x88'`
  - `m_BlackTexture3DRTH: offset '0x48' → '0x90'`
  - `m_WhiteTexture2DArrayRTH: offset '0x50' → '0xa0'`
  - `m_WhiteTextureRTH: offset '0x58' → '0xa8'`
  - `extra field static Texture m_BlackUIntTexture2DArray`
  - `extra field static Texture m_BlackUIntTexture`
  - `extra field static Texture2DArray m_ClearTexture2DArray`
  - `extra field static Texture2D m_ClearTexture`
  - `extra field static Texture2DArray m_MagentaTexture2DArray`
  - `extra field static Texture2D m_MagentaTexture`
  - `extra field static Texture2D m_BlackTexture`
  - `extra field static Texture3D m_BlackTexture3D`
  - `extra field static Texture2DArray m_BlackTexture2DArray`
  - `extra field static Texture2DArray m_WhiteTexture2DArray`

- `UnityEngine.Rendering.VolumeDebugSettings<T>`

  - `field declaration order/names: ['<selectedComponent>k__BackingField', 'm_SelectedCamera', 'm_SelectedCameraIndex', 'm_CamerasArray', 'm_Cameras', 's_ComponentPathAndType', 'weights', 'volumes', 'savedStates', '<additionalCameraDatas>k__BackingField'] → ['<selectedComponent>k__BackingField', 'm_SelectedCamera', 'm_SelectedCameraIndex', 'm_CamerasArray', 'm_Cameras', 's_ComponentPathAndType', 'weights', 'volumes', 'savedStates', 's_ComponentTypes', '<additionalCameraDatas>k__BackingField']`
  - `extra field static List<Type> s_ComponentTypes`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.VolumeManager`

  - `field declaration order/names: ['s_Instance', '<stack>k__BackingField', 's_SupportedVolumeComponentsForRenderPipeline', '<baseComponentTypeArray>k__BackingField', 'm_SortedVolumes', 'm_Volumes', 'm_SortNeeded', 'm_ComponentsDefaultState', 'm_TempColliders', 'm_DefaultStack'] → ['s_Instance', '<stack>k__BackingField', 's_SupportedVolumeComponentsForRenderPipeline', '<baseComponentTypeArray>k__BackingField', 'k_MaxLayerCount', 'm_SortedVolumes', 'm_Volumes', 'm_SortNeeded', 'm_ComponentsDefaultState', 'm_TempColliders', 'm_DefaultStack']`
  - `extra field constant int k_MaxLayerCount`

- `VolumeDebugSettings.<>c<T>` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__35_0', '<>9__37_0'] → ['<>9', '<>9__35_0', '<>9__37_0', '<>9__44_0', '<>9__44_1', '<>9__44_2']`
  - `extra field static Func<Type, bool> <>9__44_0`
  - `extra field static Func<Type, bool> <>9__44_1`
  - `extra field static Func<Type, string> <>9__44_2`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Indeterminate: 24</summary>

- `CoreUtils.<>c__88<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DebugDisplaySettings.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DebugUI.EnumField.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DebugUI.EnumField<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ListPool.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObjectPool.PooledObject<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RenderGraphObjectPool.SharedObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RenderGraphResourcePool.<>c<Type>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RenderGraphResourcePool.ResourceLogInfo<Type>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphPass<PassData>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResource<DescType, ResType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ConstantBuffer<CBType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ConstantBufferSingleton<CBType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.DebugDisplaySettings<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.DebugDisplaySettingsPanel<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.DynamicArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.GenericPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ListChangedEventArgs<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ListPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.ObservableList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.TProfilingSampler<TEnum>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.UI.DebugUIHandlerField<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.VolumeParameter<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 8</summary>

- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass2_1` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass2_2` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass2_3` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass3_1` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass3_2` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass3_3` (compiler-generated name)

</details>

<details><summary>Extra: 208</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20316`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20324`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=512`
- `AtlasAllocatorDynamic.AtlasNode`
- `AtlasAllocatorDynamic.AtlasNode.AtlasNodeFlags`
- `AtlasAllocatorDynamic.AtlasNodePool`
- `CoreUnsafeUtils.DefaultKeyGetter<T>`
- `CoreUnsafeUtils.FixedBufferStringQueue`
- `CoreUnsafeUtils.IKeyGetter<TValue, TKey>`
- `CoreUnsafeUtils.UintKeyGetter`
- `CoreUtils.Priorities`
- `CoreUtils.Sections`
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass7_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass9_0` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass9_1` (compiler-generated name)
- `DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain`
- `DebugManager.<>c__DisplayClass86_0` (compiler-generated name)
- `DebugUI.HBox`
- `DebugUI.IValueField`
- `DebugUI.VBox`
- `DictionaryPool.<>c<TKey, TValue>` (compiler-generated name)
- `DynamicArray.Iterator<T>`
- `DynamicArray.RangeEnumerable.RangeIterator<T>`
- `DynamicArray.RangeEnumerable<T>`
- `Hammersley.Hammersley2dSeq16`
- `Hammersley.Hammersley2dSeq16.<hammersley2dSeq16>e__FixedBuffer` (compiler-generated name)
- `Hammersley.Hammersley2dSeq256`
- `Hammersley.Hammersley2dSeq256.<hammersley2dSeq256>e__FixedBuffer` (compiler-generated name)
- `Hammersley.Hammersley2dSeq32`
- `Hammersley.Hammersley2dSeq32.<hammersley2dSeq32>e__FixedBuffer` (compiler-generated name)
- `Hammersley.Hammersley2dSeq64`
- `Hammersley.Hammersley2dSeq64.<hammersley2dSeq64>e__FixedBuffer` (compiler-generated name)
- `HashSetPool.<>c<T>` (compiler-generated name)
- `LightAnchor.Axes`
- `LightAnchor.UpDirection`
- `MeshGizmo.<>c__DisplayClass10_0` (compiler-generated name)
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `ObjectParameter.<>c<T>` (compiler-generated name)
- `PowerOfTwoTextureAtlas.<>c` (compiler-generated name)
- `ProbeBrickIndex.<>c` (compiler-generated name)
- `ProbeBrickIndex.Brick`
- `ProbeBrickIndex.BrickMeta`
- `ProbeBrickIndex.CellIndexUpdateInfo`
- `ProbeBrickIndex.ReservedBrick`
- `ProbeBrickIndex.VoxelMeta`
- `ProbeBrickPool.BrickChunkAlloc`
- `ProbeBrickPool.DataLocation`
- `ProbeCellIndices.IndexMetaData`
- `ProbeReferenceVolume.<>c` (compiler-generated name)
- `ProbeReferenceVolume.<>c__DisplayClass27_0` (compiler-generated name)
- `ProbeReferenceVolume.BlendingCellInfo`
- `ProbeReferenceVolume.Cell`
- `ProbeReferenceVolume.Cell.PerScenarioData`
- `ProbeReferenceVolume.CellInfo`
- `ProbeReferenceVolume.CellInstancedDebugProbes`
- `ProbeReferenceVolume.ExtraDataActionInput`
- `ProbeReferenceVolume.InitInfo`
- `ProbeReferenceVolume.RefVolTransform`
- `ProbeReferenceVolume.RuntimeResources`
- `ProbeReferenceVolume.Volume`
- `ProbeReferenceVolumeProfile.Version`
- `ProbeVolume.Mode`
- `ProbeVolume.Version`
- `ProbeVolumeAsset.AssetVersion`
- `ProbeVolumeAsset.CellCounts`
- `ProbeVolumeBakingProcessSettings.SettingsVersion`
- `ProbeVolumePerSceneData.PerScenarioData`
- `ProbeVolumePerSceneData.SerializablePerScenarioDataItem`
- `ProbeVolumeSceneData.BakingSet`
- `ProbeVolumeSceneData.SerializableBoundItem`
- `ProbeVolumeSceneData.SerializableHasPVItem`
- `ProbeVolumeSceneData.SerializablePVBakeSettings`
- `ProbeVolumeSceneData.SerializablePVProfile`
- `RTHandleSystem.ResizeMode`
- `RenderGraph.<>c` (compiler-generated name)
- `RenderGraph.ProfilingScopePassData`
- `RenderGraphDebugParams.Strings`
- `ShaderDebugPrintManager.DebugValueType`
- `ShaderDebugPrintManager.Profiling`
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferDesc`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferHandle`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.ComputeBufferResource`
- `UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphProfilingScope`
- `UnityEngine.LightAnchor`
- `UnityEngine.Rendering.APVConstantBufferRegister`
- `UnityEngine.Rendering.APVLeakReductionMode`
- `UnityEngine.Rendering.AnimationCurveParameter`
- `UnityEngine.Rendering.AtlasAllocatorDynamic`
- `UnityEngine.Rendering.BatchRendererGroupGlobals`
- `UnityEngine.Rendering.BitArray128`
- `UnityEngine.Rendering.BitArray16`
- `UnityEngine.Rendering.BitArray256`
- `UnityEngine.Rendering.BitArray32`
- `UnityEngine.Rendering.BitArray64`
- `UnityEngine.Rendering.BitArray8`
- `UnityEngine.Rendering.BitArrayUtilities`
- `UnityEngine.Rendering.BufferedRTHandleSystem`
- `UnityEngine.Rendering.CameraSwitcher`
- `UnityEngine.Rendering.ComponentSingleton<TType>`
- `UnityEngine.Rendering.CoreRPHelpURLAttribute`
- `UnityEngine.Rendering.CubemapParameter`
- `UnityEngine.Rendering.DebugProbeShadingMode`
- `UnityEngine.Rendering.DebugShapes`
- `UnityEngine.Rendering.DelegateUtility`
- `UnityEngine.Rendering.DictionaryPool<TKey, TValue>`
- `UnityEngine.Rendering.DocumentationInfo`
- `UnityEngine.Rendering.DocumentationUtils`
- `UnityEngine.Rendering.DynamicArrayExtensions`
- `UnityEngine.Rendering.FieldPacking`
- `UnityEngine.Rendering.FieldPrecision`
- `UnityEngine.Rendering.FloatRangeParameter`
- `UnityEngine.Rendering.FreeCamera`
- `UnityEngine.Rendering.GIContributors`
- `UnityEngine.Rendering.HDRColorspace`
- `UnityEngine.Rendering.HDREncoding`
- `UnityEngine.Rendering.HDRRangeReduction`
- `UnityEngine.Rendering.Hammersley`
- `UnityEngine.Rendering.HashSetPool<T>`
- `UnityEngine.Rendering.IBitArray`
- `UnityEngine.Rendering.ICloudBackground`
- `UnityEngine.Rendering.IShaderVariantSettings`
- `UnityEngine.Rendering.IVirtualTexturingEnabledRenderPipeline`
- `UnityEngine.Rendering.IVolumetricCloud`
- `UnityEngine.Rendering.KeyframeUtility`
- `UnityEngine.Rendering.LayerMaskParameter`
- `UnityEngine.Rendering.ListBuffer<T>`
- `UnityEngine.Rendering.ListBufferExtensions`
- `UnityEngine.Rendering.LookDev.IDataProvider`
- `UnityEngine.Rendering.LookDev.Sky`
- `UnityEngine.Rendering.LookDev.StageRuntimeInterface`
- `UnityEngine.Rendering.MaterialParameter`
- `UnityEngine.Rendering.MaterialQuality`
- `UnityEngine.Rendering.MaterialQualityUtilities`
- `UnityEngine.Rendering.MaxFloatParameter`
- `UnityEngine.Rendering.MaxIntParameter`
- `UnityEngine.Rendering.MeshGizmo`
- `UnityEngine.Rendering.MinIntParameter`
- `UnityEngine.Rendering.MousePositionDebug`
- `UnityEngine.Rendering.NoInterpClampedFloatParameter`
- `UnityEngine.Rendering.NoInterpClampedIntParameter`
- `UnityEngine.Rendering.NoInterpColorParameter`
- `UnityEngine.Rendering.NoInterpFloatParameter`
- `UnityEngine.Rendering.NoInterpFloatRangeParameter`
- `UnityEngine.Rendering.NoInterpIntParameter`
- `UnityEngine.Rendering.NoInterpMaxFloatParameter`
- `UnityEngine.Rendering.NoInterpMaxIntParameter`
- `UnityEngine.Rendering.NoInterpMinFloatParameter`
- `UnityEngine.Rendering.NoInterpMinIntParameter`
- `UnityEngine.Rendering.NoInterpRenderTextureParameter`
- `UnityEngine.Rendering.NoInterpVector2Parameter`
- `UnityEngine.Rendering.NoInterpVector4Parameter`
- `UnityEngine.Rendering.PackingAttribute`
- `UnityEngine.Rendering.ProbeBrickBlendingPool`
- `UnityEngine.Rendering.ProbeBrickIndex`
- `UnityEngine.Rendering.ProbeBrickPool`
- `UnityEngine.Rendering.ProbeCellIndices`
- `UnityEngine.Rendering.ProbeDilationSettings`
- `UnityEngine.Rendering.ProbeReferenceVolume`
- `UnityEngine.Rendering.ProbeReferenceVolumeProfile`
- `UnityEngine.Rendering.ProbeTouchupVolume`
- `UnityEngine.Rendering.ProbeVolume`
- `UnityEngine.Rendering.ProbeVolumeAsset`
- `UnityEngine.Rendering.ProbeVolumeBakingProcessSettings`
- `UnityEngine.Rendering.ProbeVolumeBlendingTextureMemoryBudget`
- `UnityEngine.Rendering.ProbeVolumeDebug`
- `UnityEngine.Rendering.ProbeVolumePerSceneData`
- `UnityEngine.Rendering.ProbeVolumeSHBands`
- `UnityEngine.Rendering.ProbeVolumeSceneData`
- `UnityEngine.Rendering.ProbeVolumeShadingParameters`
- `UnityEngine.Rendering.ProbeVolumeSystemParameters`
- `UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget`
- `UnityEngine.Rendering.ProfilingSample`
- `UnityEngine.Rendering.RemoveRangeExtensions`
- `UnityEngine.Rendering.RenderPipelineResources`
- `UnityEngine.Rendering.RenderTextureParameter`
- `UnityEngine.Rendering.SHCoefficients`
- `UnityEngine.Rendering.SceneRenderPipeline`
- `UnityEngine.Rendering.SerializableEnum`
- `UnityEngine.Rendering.SerializedDictionary<K, V, SK, SV>`
- `UnityEngine.Rendering.SerializedDictionary<K, V>`
- `UnityEngine.Rendering.ShaderDebugPrintInput`
- `UnityEngine.Rendering.ShaderDebugPrintInputProducer`
- `UnityEngine.Rendering.ShaderDebugPrintManager`
- `UnityEngine.Rendering.ShaderVariablesProbeVolumes`
- `UnityEngine.Rendering.SphericalHarmonicsL1`
- `UnityEngine.Rendering.SphericalHarmonicsL2Utils`
- `UnityEngine.Rendering.SurfaceDataAttributes`
- `UnityEngine.Rendering.SwapCollectionExtensions`
- `UnityEngine.Rendering.Texture2DAtlasDynamic`
- `UnityEngine.Rendering.Texture2DParameter`
- `UnityEngine.Rendering.Texture3DParameter`
- `UnityEngine.Rendering.TileLayoutUtils`
- `UnityEngine.Rendering.UnsafeGenericPool<T>`
- `UnityEngine.Rendering.VirtualOffsetSettings`
- `UnityEngine.Rendering.VolumeComponentDeprecated`
- `UnityEngine.Rendering.VolumeIsolationScope`
- `UnityEngine.Rendering.XRGraphics`
- `UnityEngine.Rendering.XRUtils`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `VolumeComponent.Indent`
- `VolumeDebugSettings.<>c__DisplayClass23_0<T>` (compiler-generated name)
- `XRGraphics.StereoRenderingMode`

</details>


## Unity.RenderPipelines.Universal.Runtime.dll

<details><summary>Matching: 543</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=960`
- `AdditionalLightsShadowCasterPass.<>c` (compiler-generated name)
- `AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer`
- `AdditionalLightsShadowCasterPass.PassData`
- `AdditionalLightsShadowCasterPass.ShadowResolutionRequest`
- `BuddyAllocator.Header`
- `Campus.Rendering.Debug.ActorDebugMaterialMode`
- `Campus.Rendering.Debug.CampusDebugDisplaySettings`
- `Campus.Rendering.Debug.CampusDebugDisplaySettingsCommonData`
- `Campus.Rendering.Debug.CampusRenderingDebug`
- `Campus.Rendering.Debug.CampusRenderingDebugPass`
- `Campus.Rendering.Debug.CampusRenderingOutlineDebugPass`
- `CampusDebugDisplaySettingsCommonData.RenderingPanel`
- `CampusDebugDisplaySettingsCommonData.RenderingPanel.<>c` (compiler-generated name)
- `CampusDebugDisplaySettingsCommonData.RenderingPanel.<>c__DisplayClass2_0` (compiler-generated name)
- `CampusRenderingOutlineDebugPass.<>c` (compiler-generated name)
- `ClearTargetsPass.<>c` (compiler-generated name)
- `ClearTargetsPass.PassData`
- `ColorGradingComputePass.PassData`
- `ColorGradingComputePass.ShaderConstants`
- `ColorGradingLutPass.<>c` (compiler-generated name)
- `ColorGradingLutPass.PassData`
- `ColorGradingLutPass.ShaderConstants`
- `ConvolutionBlur.<>c` (compiler-generated name)
- `CopyColorPass.<>c` (compiler-generated name)
- `CopyColorPass.PassData`
- `CopyDepthPass.<>c` (compiler-generated name)
- `CopyDepthPass.PassData`
- `DebugDisplaySettingsCommon.SettingsPanel.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugDisplaySettingsCommon.WidgetFactory`
- `DebugDisplaySettingsCommon.WidgetFactory.<>c` (compiler-generated name)
- `DebugDisplaySettingsLighting.SettingsPanel`
- `DebugDisplaySettingsLighting.Strings`
- `DebugDisplaySettingsLighting.WidgetFactory`
- `DebugDisplaySettingsLighting.WidgetFactory.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsLighting.WidgetFactory.<>c__DisplayClass1_0` (compiler-generated name)
- `DebugDisplaySettingsLighting.WidgetFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset`
- `DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData`
- `DebugDisplaySettingsMaterial.SettingsPanel`
- `DebugDisplaySettingsMaterial.SettingsPanel.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory`
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass10_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass1_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass4_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass5_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass6_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass7_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass8_0` (compiler-generated name)
- `DebugDisplaySettingsMaterial.WidgetFactory.<>c__DisplayClass9_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.SettingsPanel`
- `DebugDisplaySettingsRendering.SettingsPanel.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.TaaDebugMode`
- `DebugDisplaySettingsRendering.WidgetFactory`
- `DebugDisplaySettingsRendering.WidgetFactory.<>c` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass0_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass10_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass11_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass12_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass13_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass1_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass3_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass4_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass5_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass6_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass7_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass8_0` (compiler-generated name)
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass9_0` (compiler-generated name)
- `DebugDisplayStats.StatsPanel`
- `DebugHandler.DebugRenderPassEnumerable`
- `DebugHandler.DebugRenderPassEnumerable.Enumerator`
- `DebugHandler.DrawFunction`
- `DecalCreateDrawCallSystem.DrawCallJob`
- `DecalEntityIndexer.DecalEntityItem`
- `DecalEntityManager.<>c` (compiler-generated name)
- `DecalEntityManager.CombinedChunks`
- `DecalPrioritySystem.PrioritySortJob`
- `DecalProjector.DecalProjectorAction`
- `DecalUpdateCachedSystem.UpdateTransformsJob`
- `DeferredLights.InitParams`
- `DeferredLights.ShaderConstants`
- `DeferredPass.<>c` (compiler-generated name)
- `DeferredPass.PassData`
- `DepthNormalOnlyPass.<>c` (compiler-generated name)
- `DepthNormalOnlyPass.PassData`
- `DepthOnlyPass.<>c` (compiler-generated name)
- `DepthOnlyPass.PassData`
- `DownsampleBlur.<>c__DisplayClass8_0` (compiler-generated name)
- `DrawObjectsPass.<>c` (compiler-generated name)
- `DrawObjectsPass.PassData`
- `DrawSkyboxPass.<>c` (compiler-generated name)
- `DrawSkyboxPass.PassData`
- `EntityComponentEvent.EntityComponentAction<TComponent>`
- `EntityIndexer.EntityItem`
- `FinalBlitPass.<>c` (compiler-generated name)
- `FinalBlitPass.BlitMaterialData`
- `FinalBlitPass.BlitType`
- `FinalBlitPass.PassData`
- `FogUtility.<>c__DisplayClass7_0` (compiler-generated name)
- `ForwardLights.InitParams`
- `ForwardLights.LightConstantBuffer`
- `GBufferPass.<>c` (compiler-generated name)
- `GBufferPass.PassData`
- `HDRDebugViewPass.PassData`
- `HDRDebugViewPass.ShaderConstants`
- `InvokeOnRenderObjectCallbackPass.<>c` (compiler-generated name)
- `InvokeOnRenderObjectCallbackPass.PassData`
- `LightCookieManager.LightCookieMapping`
- `LightCookieManager.LightCookieMapping.<>c` (compiler-generated name)
- `LightCookieManager.LightCookieShaderData`
- `LightCookieManager.LightCookieShaderFormat`
- `LightCookieManager.Settings`
- `LightCookieManager.Settings.AtlasSettings`
- `LightCookieManager.ShaderBitArray`
- `LightCookieManager.ShaderProperty`
- `LightCookieManager.Sorting`
- `LightCookieManager.WorkMemory`
- `MainLightShadowCasterPass.<>c` (compiler-generated name)
- `MainLightShadowCasterPass.MainLightShadowConstantBuffer`
- `MainLightShadowCasterPass.PassData`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `MotionVectorRenderPass.<>c` (compiler-generated name)
- `MotionVectorRenderPass.PassData`
- `PixelPerfectCamera.CropFrame`
- `PixelPerfectCamera.GridSnapping`
- `PixelPerfectCamera.PixelPerfectFilterMode`
- `PlanarReflection.MaskType`
- `PlanarReflection.ShaderTagIdList`
- `PlanarReflection.ShaderTagIdList.<_tagIds>e__FixedBuffer` (compiler-generated name)
- `PlanarReflectionCullingSystem.CullingJob`
- `PlanarReflectionResultSystem.ResultJob`
- `PlanarReflectionUpdateCachedSystem.UpdateJob`
- `PlanarReflectionUtility.PropertyId`
- `PostProcessData.ShaderResources`
- `PostProcessData.TextureResources`
- `PostProcessPass.<>c` (compiler-generated name)
- `PostProcessPass.<>c__DisplayClass68_0` (compiler-generated name)
- `PostProcessPass.MaterialLibrary`
- `PostProcessPass.ShaderConstants`
- `PostProcessUtils.ShaderConstants`
- `ReflectionProbeManager.CachedProbe`
- `ReflectionProbeManager.CachedProbe.<dataIndices>e__FixedBuffer` (compiler-generated name)
- `ReflectionProbeManager.CachedProbe.<levels>e__FixedBuffer` (compiler-generated name)
- `ReflectionProbeManager.ShaderProperties`
- `RenderObjects.CustomCameraSettings`
- `RenderObjects.FilterSettings`
- `RenderObjects.RenderObjectsSettings`
- `RenderObjects.RenderObjectsSettings.OverrideMaterialMode`
- `RenderObjectsPass.<>c` (compiler-generated name)
- `RenderObjectsPass.PassData`
- `RenderTargetBufferSystem.SwapBuffer`
- `RenderingBridge.EventType`
- `RenderingBridge.RenderEvent`
- `RenderingLayerUtils.Event`
- `RenderingLayerUtils.MaskSize`
- `RenderingUtility.ShaderTagIds`
- `ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass`
- `ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.BlurTypes`
- `ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses`
- `ScreenSpaceAmbientOcclusionSettings.AOMethodOptions`
- `ScreenSpaceAmbientOcclusionSettings.AOSampleOption`
- `ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions`
- `ScreenSpaceAmbientOcclusionSettings.DepthSource`
- `ScreenSpaceAmbientOcclusionSettings.NormalQuality`
- `ScriptableRenderer.BeginXRPassData`
- `ScriptableRenderer.DrawGizmosPassData`
- `ScriptableRenderer.EndXRPassData`
- `ScriptableRenderer.PassData`
- `ScriptableRenderer.RTHandleRenderTargetIdentifierCompat`
- `ScriptableRenderer.RenderBlocks`
- `ScriptableRenderer.RenderBlocks.BlockRange`
- `ScriptableRenderer.RenderPassBlock`
- `ScriptableRenderer.RenderPassDescriptor`
- `ScriptableRenderer.RenderingFeatures`
- `ScriptableRenderer.VFXProcessCameraPassData`
- `ScriptableRendererData.DebugShaderResources`
- `ShaderVariablesScreenSpaceReflection.<_MipMinMax>e__FixedBuffer` (compiler-generated name)
- `ShaderVariablesVLDOFBokeh.<_BokehKernel>e__FixedBuffer` (compiler-generated name)
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `TemporalAA.Settings`
- `TemporalAA.ShaderConstants`
- `TemporalAA.ShaderKeywords`
- `TilingJob.<>c__DisplayClass19_0` (compiler-generated name)
- `TilingJob.<>c__DisplayClass20_0` (compiler-generated name)
- `UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera`
- `UnityEngine.Experimental.Rendering.Universal.RenderObjects`
- `UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass`
- `UnityEngine.Experimental.Rendering.Universal.RenderQueueType`
- `UnityEngine.Rendering.Universal.AntialiasingMode`
- `UnityEngine.Rendering.Universal.AntialiasingQuality`
- `UnityEngine.Rendering.Universal.Bloom`
- `UnityEngine.Rendering.Universal.BloomDownscaleMode`
- `UnityEngine.Rendering.Universal.BuddyAllocation`
- `UnityEngine.Rendering.Universal.BuddyAllocator`
- `UnityEngine.Rendering.Universal.CameraData`
- `UnityEngine.Rendering.Universal.CameraExtensions`
- `UnityEngine.Rendering.Universal.CameraOverrideOption`
- `UnityEngine.Rendering.Universal.CameraRenderType`
- `UnityEngine.Rendering.Universal.ChannelMixer`
- `UnityEngine.Rendering.Universal.ChromaticAberration`
- `UnityEngine.Rendering.Universal.ClearTargetsPass`
- `UnityEngine.Rendering.Universal.ColorAdjustments`
- `UnityEngine.Rendering.Universal.ColorCurves`
- `UnityEngine.Rendering.Universal.ColorGradingMode`
- `UnityEngine.Rendering.Universal.ColorLookup`
- `UnityEngine.Rendering.Universal.CopyDepthMode`
- `UnityEngine.Rendering.Universal.CustomLightingType`
- `UnityEngine.Rendering.Universal.DBufferSettings`
- `UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon`
- `UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting`
- `UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial`
- `UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering`
- `UnityEngine.Rendering.Universal.DebugDisplayStats`
- `UnityEngine.Rendering.Universal.DebugHandler`
- `UnityEngine.Rendering.Universal.DebugRenderSetup`
- `UnityEngine.Rendering.Universal.DebugWireframeMode`
- `UnityEngine.Rendering.Universal.DecalCachedChunk`
- `UnityEngine.Rendering.Universal.DecalChunk`
- `UnityEngine.Rendering.Universal.DecalCreateDrawCallSystem`
- `UnityEngine.Rendering.Universal.DecalCulledChunk`
- `UnityEngine.Rendering.Universal.DecalDrawCallChunk`
- `UnityEngine.Rendering.Universal.DecalDrawDBufferSystem`
- `UnityEngine.Rendering.Universal.DecalEntity`
- `UnityEngine.Rendering.Universal.DecalEntityChunk`
- `UnityEngine.Rendering.Universal.DecalEntityIndexer`
- `UnityEngine.Rendering.Universal.DecalEntityManager`
- `UnityEngine.Rendering.Universal.DecalInstanceData`
- `UnityEngine.Rendering.Universal.DecalPreviewPass`
- `UnityEngine.Rendering.Universal.DecalPrioritySystem`
- `UnityEngine.Rendering.Universal.DecalProjector`
- `UnityEngine.Rendering.Universal.DecalScaleMode`
- `UnityEngine.Rendering.Universal.DecalSubDrawCall`
- `UnityEngine.Rendering.Universal.DecalSurfaceData`
- `UnityEngine.Rendering.Universal.DecalType`
- `UnityEngine.Rendering.Universal.DecalUpdateCachedSystem`
- `UnityEngine.Rendering.Universal.DecalUpdateCulledSystem`
- `UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem`
- `UnityEngine.Rendering.Universal.DefaultMaterialType`
- `UnityEngine.Rendering.Universal.DepthOfField`
- `UnityEngine.Rendering.Universal.DepthOfFieldMode`
- `UnityEngine.Rendering.Universal.DepthOfFieldModeParameter`
- `UnityEngine.Rendering.Universal.DepthPrimingMode`
- `UnityEngine.Rendering.Universal.DisallowMultipleRendererFeature`
- `UnityEngine.Rendering.Universal.Downsampling`
- `UnityEngine.Rendering.Universal.DownscaleParameter`
- `UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass`
- `UnityEngine.Rendering.Universal.DrawSkyboxPass`
- `UnityEngine.Rendering.Universal.FilmGrain`
- `UnityEngine.Rendering.Universal.FilmGrainLookup`
- `UnityEngine.Rendering.Universal.FilmGrainLookupParameter`
- `UnityEngine.Rendering.Universal.HDRACESPreset`
- `UnityEngine.Rendering.Universal.HDRACESPresetParameter`
- `UnityEngine.Rendering.Universal.HDRColorBufferPrecision`
- `UnityEngine.Rendering.Universal.HDRDebugViewPass`
- `UnityEngine.Rendering.Universal.IPixelPerfectCamera`
- `UnityEngine.Rendering.Universal.IPostProcessComponent`
- `UnityEngine.Rendering.Universal.ImageScalingMode`
- `UnityEngine.Rendering.Universal.ImageUpscalingFilter`
- `UnityEngine.Rendering.Universal.InclusiveRange`
- `UnityEngine.Rendering.Universal.IntermediateTextureMode`
- `UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass`
- `UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass`
- `UnityEngine.Rendering.Universal.Internal.CopyColorPass`
- `UnityEngine.Rendering.Universal.Internal.CopyDepthPass`
- `UnityEngine.Rendering.Universal.Internal.DeferredConfig`
- `UnityEngine.Rendering.Universal.Internal.DeferredLights`
- `UnityEngine.Rendering.Universal.Internal.DeferredPass`
- `UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass`
- `UnityEngine.Rendering.Universal.Internal.DepthOnlyPass`
- `UnityEngine.Rendering.Universal.Internal.DrawObjectsPass`
- `UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass`
- `UnityEngine.Rendering.Universal.Internal.FinalBlitPass`
- `UnityEngine.Rendering.Universal.Internal.ForwardLights`
- `UnityEngine.Rendering.Universal.Internal.GBufferPass`
- `UnityEngine.Rendering.Universal.Internal.NormalReconstruction`
- `UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem`
- `UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass`
- `UnityEngine.Rendering.Universal.LODCrossFadeDitheringType`
- `UnityEngine.Rendering.Universal.LensDistortion`
- `UnityEngine.Rendering.Universal.LiftGammaGain`
- `UnityEngine.Rendering.Universal.LightCookieFormat`
- `UnityEngine.Rendering.Universal.LightCookieManager`
- `UnityEngine.Rendering.Universal.LightCookieResolution`
- `UnityEngine.Rendering.Universal.LightData`
- `UnityEngine.Rendering.Universal.LightExtensions`
- `UnityEngine.Rendering.Universal.LightLayerEnum`
- `UnityEngine.Rendering.Universal.LightMinMaxZJob`
- `UnityEngine.Rendering.Universal.LightRenderingMode`
- `UnityEngine.Rendering.Universal.MixedLightingSetup`
- `UnityEngine.Rendering.Universal.MotionBlur`
- `UnityEngine.Rendering.Universal.MotionBlurMode`
- `UnityEngine.Rendering.Universal.MotionBlurModeParameter`
- `UnityEngine.Rendering.Universal.MotionBlurQuality`
- `UnityEngine.Rendering.Universal.MotionBlurQualityParameter`
- `UnityEngine.Rendering.Universal.MotionVectorsPersistentData`
- `UnityEngine.Rendering.Universal.MsaaQuality`
- `UnityEngine.Rendering.Universal.NativeArrayExtensions`
- `UnityEngine.Rendering.Universal.NeutralRangeReductionMode`
- `UnityEngine.Rendering.Universal.NeutralRangeReductionModeParameter`
- `UnityEngine.Rendering.Universal.PaniniProjection`
- `UnityEngine.Rendering.Universal.PipelineDebugLevel`
- `UnityEngine.Rendering.Universal.PixelPerfectCameraInternal`
- `UnityEngine.Rendering.Universal.PlatformAutoDetect`
- `UnityEngine.Rendering.Universal.PostProcessData`
- `UnityEngine.Rendering.Universal.PostProcessParams`
- `UnityEngine.Rendering.Universal.PostProcessPasses`
- `UnityEngine.Rendering.Universal.PostProcessUtils`
- `UnityEngine.Rendering.Universal.PostProcessingData`
- `UnityEngine.Rendering.Universal.RTHandleResourcePool`
- `UnityEngine.Rendering.Universal.ReflectionProbeManager`
- `UnityEngine.Rendering.Universal.ReflectionProbeMinMaxZJob`
- `UnityEngine.Rendering.Universal.RenderPassEvent`
- `UnityEngine.Rendering.Universal.RenderPassEventsEnumValues`
- `UnityEngine.Rendering.Universal.RendererType`
- `UnityEngine.Rendering.Universal.RenderingData`
- `UnityEngine.Rendering.Universal.RenderingLayerUtils`
- `UnityEngine.Rendering.Universal.RenderingMode`
- `UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion`
- `UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings`
- `UnityEngine.Rendering.Universal.ScriptableRenderPass`
- `UnityEngine.Rendering.Universal.ScriptableRenderPassInput`
- `UnityEngine.Rendering.Universal.ScriptableRenderer`
- `UnityEngine.Rendering.Universal.ScriptableRendererData`
- `UnityEngine.Rendering.Universal.ScriptableRendererFeature`
- `UnityEngine.Rendering.Universal.ShEvalMode`
- `UnityEngine.Rendering.Universal.ShaderData`
- `UnityEngine.Rendering.Universal.ShaderPathID`
- `UnityEngine.Rendering.Universal.ShaderPropertyId`
- `UnityEngine.Rendering.Universal.ShaderTimeManager`
- `UnityEngine.Rendering.Universal.ShaderUtils`
- `UnityEngine.Rendering.Universal.ShaderVariantLogLevel`
- `UnityEngine.Rendering.Universal.ShadowCascadesOption`
- `UnityEngine.Rendering.Universal.ShadowData`
- `UnityEngine.Rendering.Universal.ShadowQuality`
- `UnityEngine.Rendering.Universal.ShadowSliceData`
- `UnityEngine.Rendering.Universal.ShadowsMidtonesHighlights`
- `UnityEngine.Rendering.Universal.SharedDecalEntityManager`
- `UnityEngine.Rendering.Universal.SoftShadowQuality`
- `UnityEngine.Rendering.Universal.SpaceFillingCurves`
- `UnityEngine.Rendering.Universal.SplitToning`
- `UnityEngine.Rendering.Universal.StencilStateData`
- `UnityEngine.Rendering.Universal.StoreActionsOptimization`
- `UnityEngine.Rendering.Universal.TaaPersistentData`
- `UnityEngine.Rendering.Universal.TemporalAA`
- `UnityEngine.Rendering.Universal.TemporalAAQuality`
- `UnityEngine.Rendering.Universal.TileRangeExpansionJob`
- `UnityEngine.Rendering.Universal.TilingJob`
- `UnityEngine.Rendering.Universal.Tonemapping`
- `UnityEngine.Rendering.Universal.TonemappingMode`
- `UnityEngine.Rendering.Universal.TonemappingModeParameter`
- `UnityEngine.Rendering.Universal.URPProfileId`
- `UnityEngine.Rendering.Universal.UniversalAdditionalCameraData`
- `UnityEngine.Rendering.Universal.UniversalAdditionalLightData`
- `UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset`
- `UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings`
- `UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources`
- `UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings`
- `UnityEngine.Rendering.Universal.UniversalRendererData`
- `UnityEngine.Rendering.Universal.UpscalingFilterSelection`
- `UnityEngine.Rendering.Universal.Vignette`
- `UnityEngine.Rendering.Universal.WhiteBalance`
- `UnityEngine.Rendering.Universal.XROcclusionMeshPass`
- `UnityEngine.Rendering.Universal.XRPassUniversal`
- `UnityEngine.Rendering.Universal.XRSystemData`
- `UnityEngine.Rendering.Universal.XRSystemUniversal`
- `UniversalRenderPipeline.<>c` (compiler-generated name)
- `UniversalRenderPipeline.Profiling`
- `UniversalRenderPipeline.SingleCameraRequest`
- `UniversalRenderPipelineAsset.TextureResources`
- `UniversalRenderPipelineEditorResources.MaterialResources`
- `UniversalRenderPipelineEditorResources.ShaderResources`
- `UniversalRenderer.RenderGraphFrameResources`
- `UniversalRenderer.RenderPassInputSummary`
- `VL.CustomRenderAction`
- `VL.CustomRenderPassData`
- `VL.CustomRenderPassUtility`
- `VL.CustomSubPassData`
- `VL.EntitySystem.Chunk`
- `VL.EntitySystem.Entity`
- `VL.EntitySystem.EntityIndexer`
- `VL.EntitySystem.ICombinedChunks`
- `VL.EntitySystem.IEntityChunk<TComponent, TChunkKey, TEntityChunk>`
- `VL.EntitySystem.IEntityChunk<TComponent, TEntityChunk>`
- `VL.EntitySystem.IEntityComponent`
- `VL.EntitySystem.IEntityComponent<TChunkKey>`
- `VL.EntitySystem.IEntityManager<TComponent>`
- `VL.Rendering.AABBUtility`
- `VL.Rendering.AOQualityOption`
- `VL.Rendering.AOQualityOptionParameter`
- `VL.Rendering.CameraPlanes`
- `VL.Rendering.CameraUtility`
- `VL.Rendering.CloudData`
- `VL.Rendering.CloudDataParameter`
- `VL.Rendering.CloudLayer`
- `VL.Rendering.ColorGradingComputePass`
- `VL.Rendering.ConvolutionBlur`
- `VL.Rendering.DeferredFogPasses`
- `VL.Rendering.DepthFog`
- `VL.Rendering.DepthOfFieldData`
- `VL.Rendering.Dof34QualitySetting`
- `VL.Rendering.Dof34QualitySettingParameter`
- `VL.Rendering.DofBokehQualitySetting`
- `VL.Rendering.DofBokehQualitySettingParameter`
- `VL.Rendering.DownsampleBlur`
- `VL.Rendering.FlareParameter`
- `VL.Rendering.FlareSetting`
- `VL.Rendering.FlareType`
- `VL.Rendering.FogUtility`
- `VL.Rendering.Internal.VLPostProcessPass`
- `VL.Rendering.Internal.VLPostProcessPasses`
- `VL.Rendering.IntervalType`
- `VL.Rendering.IntervalTypeParameter`
- `VL.Rendering.LightSpaceType`
- `VL.Rendering.LightSpaceTypeParameter`
- `VL.Rendering.MipChainBuffer`
- `VL.Rendering.MirrorBoundsParameter`
- `VL.Rendering.MirrorMeshParameter`
- `VL.Rendering.MirrorQuaternionParameter`
- `VL.Rendering.NoiseType`
- `VL.Rendering.NoiseTypeParameter`
- `VL.Rendering.PlanarReflection`
- `VL.Rendering.PlanarReflectionCachedChunk`
- `VL.Rendering.PlanarReflectionCombinedChunks`
- `VL.Rendering.PlanarReflectionCulledChunk`
- `VL.Rendering.PlanarReflectionCullingSystem`
- `VL.Rendering.PlanarReflectionDrawSystem`
- `VL.Rendering.PlanarReflectionEntityChunk`
- `VL.Rendering.PlanarReflectionEntityManager`
- `VL.Rendering.PlanarReflectionResultChunk`
- `VL.Rendering.PlanarReflectionResultSystem`
- `VL.Rendering.PlanarReflectionUpdateCachedSystem`
- `VL.Rendering.PlanarReflectionUtility`
- `VL.Rendering.PlanarReflectionVolumeComponent`
- `VL.Rendering.RenderingBridge`
- `VL.Rendering.RenderingUtility`
- `VL.Rendering.Shaders.ShaderVariablesScreenSpaceReflection`
- `VL.Rendering.Shaders.ShaderVariablesVLDOFBokeh`
- `VL.Rendering.SharedPlanarReflectionEntityManager`
- `VL.Rendering.SphereFog`
- `VL.Rendering.StarStreakType`
- `VL.Rendering.StarStreakTypeParameter`
- `VL.Rendering.SubWorld`
- `VL.Rendering.SubWorldMode`
- `VL.Rendering.SubWorldPass`
- `VL.Rendering.SubWorldUtility`
- `VL.Rendering.SubWorldVolume`
- `VL.Rendering.SubWorldVolumeParameter`
- `VL.Rendering.Texture3DParameter`
- `VL.Rendering.TonemappingModeParameter`
- `VL.Rendering.VLActorForward`
- `VL.Rendering.VLActorGBuffer`
- `VL.Rendering.VLActorParameter`
- `VL.Rendering.VLActorParameterPass`
- `VL.Rendering.VLActorTransparentPass`
- `VL.Rendering.VLBloom`
- `VL.Rendering.VLCameraBufferSystem`
- `VL.Rendering.VLCapturePass`
- `VL.Rendering.VLChromaticAberration`
- `VL.Rendering.VLCloud`
- `VL.Rendering.VLDOF`
- `VL.Rendering.VLDOFBokehQuality`
- `VL.Rendering.VLDebugDisplaySettings`
- `VL.Rendering.VLDebugDisplaySettingsData`
- `VL.Rendering.VLDebugDisplaySettingsPreviewRenderPass`
- `VL.Rendering.VLDecalDrawSystem`
- `VL.Rendering.VLDecalPass`
- `VL.Rendering.VLDeferredPass`
- `VL.Rendering.VLDensityFogVolume`
- `VL.Rendering.VLDiffusion`
- `VL.Rendering.VLGlobalLightProbe`
- `VL.Rendering.VLJumpFloodOutline`
- `VL.Rendering.VLLightProbeUtility`
- `VL.Rendering.VLLightmapVolume`
- `VL.Rendering.VLMirrorVolumeComponent`
- `VL.Rendering.VLMotionBlur`
- `VL.Rendering.VLMotionVectorRenderPass`
- `VL.Rendering.VLParaffin`
- `VL.Rendering.VLPostProcessData`
- `VL.Rendering.VLPreDepthIDPass`
- `VL.Rendering.VLRGBBlockNoise`
- `VL.Rendering.VLSRPAdditionalCameraData`
- `VL.Rendering.VLSRPCapture`
- `VL.Rendering.VLSRPRendererData`
- `VL.Rendering.VLSSRQualitySetting`
- `VL.Rendering.VLSSRQualitySettingParameter`
- `VL.Rendering.VLScreenSpaceAmbientOcclusion`
- `VL.Rendering.VLScreenSpaceReflection`
- `VL.Rendering.VLSimpleRenderer`
- `VL.Rendering.VLSimpleRendererData`
- `VL.Rendering.VLSkyPass`
- `VL.Rendering.VLStarStreak`
- `VL.Rendering.VLTextureBlur`
- `VL.Rendering.VLTonemapping`
- `VL.Rendering.VLTonemappingMode`
- `VL.Rendering.VLVirtualEffect`
- `VL.Rendering.VLVirtualEffectGBuffer`
- `VL.Rendering.VLWaveJitterGlitch`
- `VL.VLRenderQueue`
- `VLActorForward.<>c` (compiler-generated name)
- `VLActorTransparentPass.<>c` (compiler-generated name)
- `VLCameraBufferSystem.RenderData`
- `VLDebugDisplaySettingsData.Strings`
- `VLDebugDisplaySettingsData.VLRenderingPanel`
- `VLDebugDisplaySettingsData.WidgetFactory`
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass0_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass1_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass2_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass3_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass4_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass5_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass6_0` (compiler-generated name)
- `VLDebugDisplaySettingsData.WidgetFactory.<>c__DisplayClass7_0` (compiler-generated name)
- `VLDeferredPass.<>c` (compiler-generated name)
- `VLPostProcessPass.<>c__DisplayClass29_0` (compiler-generated name)
- `VLPostProcessPass.DOFHandles`
- `VLPostProcessPass.VLChromaticAberrationShaderConstants`
- `VLPostProcessPass.VLDOFPasses`
- `VLPostProcessPass.VLDOFShaderConstants`
- `VLPostProcessPass.VLJumpFloodOutlineShaderConstants`
- `VLPostProcessPass.VLMaterialLibrary`
- `VLPostProcessPass.VLMotionBlurShaderConstants`
- `VLPostProcessPass.VLRGBBockNoiseShaderConstants`
- `VLPostProcessPass.VLShaderConstants`
- `VLPostProcessPass.VLVirtualEffectShaderConstants`
- `VLPostProcessPass.VLWaveJitterGlitchShaderContents`
- `VLSRPCapture.<>c__DisplayClass5_0` (compiler-generated name)
- `VLSRPCapture.RequestData`
- `VLSRPCapture.SourceType`
- `VLSimpleRenderer.SimpleFinalBlitPass`
- `XROcclusionMeshPass.<>c` (compiler-generated name)
- `XROcclusionMeshPass.PassData`
- `XRSystemData.ShaderResources`

</details>

<details><summary>Mismatching: 34</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['05FE3BE7BD73808C8574173B558DD5BA6DF28AC65B45EB9E65503BBB699709EF', '08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6', '0ABF8AC68111CEBD27676BF5EF5DD92A3FEE0C68C2FDAB9B259C4795F93C7A8C', '28D0A1CE6AB47E8D0C1CC0E9F836A680871AA3942D4B8194B6EC886D038A96AA', '29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E', '4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D', '582A4261FE36A5D1E7D95B57714D681D1E70C11B28807118CEAE1A8DA5F9B4DD', '6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64', '636952D3023D8CF5D8245AC30EFB93A443BD4BC23B5E331D51ECB82425FDC30A', '67F97CD57FBAB63018C13EBA31B2DF63BC71EFF185FC0E19E116C63B1954D9EA', '888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1', '8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80', '9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD', 'B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137', 'BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE', 'C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101', 'E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01', 'E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A'] → ['05FE3BE7BD73808C8574173B558DD5BA6DF28AC65B45EB9E65503BBB699709EF', '08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6', '0ABF8AC68111CEBD27676BF5EF5DD92A3FEE0C68C2FDAB9B259C4795F93C7A8C', '18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34', '28D0A1CE6AB47E8D0C1CC0E9F836A680871AA3942D4B8194B6EC886D038A96AA', '29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E', '45D395DCEE2B50B91F9D5904A0B7AD67B9A8092EF84C9413FA530714EFEB41C5', '4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D', '582A4261FE36A5D1E7D95B57714D681D1E70C11B28807118CEAE1A8DA5F9B4DD', '6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64', '67F97CD57FBAB63018C13EBA31B2DF63BC71EFF185FC0E19E116C63B1954D9EA', '888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1', '8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80', '97CE6A56520B72FFD4F822EBB03072306ACDAFA96DB437BD907B5A5BF11B5E39', '9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD', 'B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137', 'BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE', 'C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101', 'E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01', 'E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A']`
  - `28D0A1CE6AB47E8D0C1CC0E9F836A680871AA3942D4B8194B6EC886D038A96AA: offset '0x34' → '0x4c'`
  - `29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E: offset '0xc4' → '0xdc'`
  - `4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D: offset '0xd8' → '0x7b36'`
  - `582A4261FE36A5D1E7D95B57714D681D1E70C11B28807118CEAE1A8DA5F9B4DD: offset '0xe4' → '0x7b42'`
  - `6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64: offset '0xea' → '0x7b48'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 636952D3023D8CF5D8245AC30EFB93A443BD4BC23B5E331D51ECB82425FDC30A`
  - `67F97CD57FBAB63018C13EBA31B2DF63BC71EFF185FC0E19E116C63B1954D9EA: offset '0x4b6' → '0x7f08'`
  - `888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1: offset '0x4c2' → '0x7f14'`
  - `8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80: offset '0x4d2' → '0x7f24'`
  - `9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD: offset '0x4de' → '0x10ffa'`
  - `B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137: offset '0x4ea' → '0x11006'`
  - `BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE: offset '0x4f6' → '0x11012'`
  - `C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101: offset '0x506' → '0x11022'`
  - `E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01: offset '0x516' → '0x11032'`
  - `E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A: offset '0x8d6' → '0x113f2'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=31302 45D395DCEE2B50B91F9D5904A0B7AD67B9A8092EF84C9413FA530714EFEB41C5`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=37066 97CE6A56520B72FFD4F822EBB03072306ACDAFA96DB437BD907B5A5BF11B5E39`

- `DebugDisplaySettingsCommon.SettingsPanel`

  - `field declaration order/names: [] → ['k_GoToSectionString']`
  - `extra field constant string k_GoToSectionString`

- `DebugDisplaySettingsMaterial.Strings`

  - `field declaration order/names: ['MaterialOverride', 'VertexAttribute', 'MaterialValidationMode', 'ValidationPreset', 'AlbedoCustomColor', 'AlbedoMinLuminance', 'AlbedoMaxLuminance', 'AlbedoHueTolerance', 'AlbedoSaturationTolerance', 'MetallicMinValue', 'MetallicMaxValue'] → ['AlbedoSettingsContainerName', 'MetallicSettingsContainerName', 'MaterialOverride', 'VertexAttribute', 'MaterialValidationMode', 'ValidationPreset', 'AlbedoCustomColor', 'AlbedoMinLuminance', 'AlbedoMaxLuminance', 'AlbedoHueTolerance', 'AlbedoSaturationTolerance', 'MetallicMinValue', 'MetallicMaxValue']`
  - `extra field constant string AlbedoSettingsContainerName`
  - `extra field constant string MetallicSettingsContainerName`

- `DebugDisplaySettingsRendering.Strings`

  - `field declaration order/names: ['MapOverlays', 'MapSize', 'AdditionalWireframeModes', 'WireframeNotSupportedWarning', 'OverdrawMode', 'MaxOverdrawCount', 'PostProcessing', 'MSAA', 'HDR', 'TaaDebugMode', 'PixelValidationMode', 'Channels', 'ValueRangeMin', 'ValueRangeMax', 'GameViewOnly'] → ['RangeValidationSettingsContainerName', 'MapOverlays', 'MapSize', 'AdditionalWireframeModes', 'WireframeNotSupportedWarning', 'OverdrawMode', 'MaxOverdrawCount', 'PostProcessing', 'MSAA', 'HDR', 'TaaDebugMode', 'PixelValidationMode', 'Channels', 'ValueRangeMin', 'ValueRangeMax']`
  - `missing field static DebugUI.Widget.NameAndTooltip GameViewOnly`
  - `extra field constant string RangeValidationSettingsContainerName`

- `DrawScreenSpaceUIPass.PassData`

  - `field declaration order/names: ['cmd', 'camera'] → ['cmd', 'camera', 'offscreenTexture']`
  - `extra field instance TextureHandle offscreenTexture`

- `ScriptableRenderer.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__136_0', '<>9__138_0', '<>9__139_0', '<>9__141_0', '<>9__143_0', '<>9__145_0'] → ['<>9', '<>9__135_0', '<>9__137_0', '<>9__138_0', '<>9__140_0', '<>9__142_0', '<>9__144_0']`
  - `missing field static RenderFunc<ScriptableRenderer.PassData> <>9__136_0`
  - `<>9__138_0: type 'RenderFunc<ScriptableRenderer.VFXProcessCameraPassData>' → 'RenderFunc<ScriptableRenderer.PassData>'`
  - `<>9__138_0: offset '0x10' → '0x18'`
  - `missing field static RenderFunc<ScriptableRenderer.PassData> <>9__139_0`
  - `missing field static RenderFunc<ScriptableRenderer.DrawGizmosPassData> <>9__141_0`
  - `missing field static RenderFunc<ScriptableRenderer.BeginXRPassData> <>9__143_0`
  - `missing field static RenderFunc<ScriptableRenderer.EndXRPassData> <>9__145_0`
  - `extra field static RenderFunc<ScriptableRenderer.PassData> <>9__135_0`
  - `extra field static RenderFunc<ScriptableRenderer.VFXProcessCameraPassData> <>9__137_0`
  - `extra field static RenderFunc<ScriptableRenderer.DrawGizmosPassData> <>9__140_0`
  - `extra field static RenderFunc<ScriptableRenderer.BeginXRPassData> <>9__142_0`
  - `extra field static RenderFunc<ScriptableRenderer.EndXRPassData> <>9__144_0`

- `ScriptableRenderer.Profiling`

  - `field declaration order/names: ['setMRTAttachmentsList', 'setAttachmentList', 'execute', 'setupFrameData', 'setPerCameraShaderVariables', 'sortRenderPasses', 'setupLights', 'setupCamera', 'vfxProcessCamera', 'addRenderPasses', 'setupRenderPasses', 'clearRenderingState', 'internalStartRendering', 'internalFinishRendering', 'drawGizmos', 'beginXRRendering', 'endXRRendering'] → ['setMRTAttachmentsList', 'setAttachmentList', 'execute', 'setupFrameData', 'k_Name', 'setPerCameraShaderVariables', 'sortRenderPasses', 'setupLights', 'setupCamera', 'vfxProcessCamera', 'addRenderPasses', 'setupRenderPasses', 'clearRenderingState', 'internalStartRendering', 'internalFinishRendering', 'drawGizmos', 'beginXRRendering', 'endXRRendering']`
  - `extra field constant string k_Name`

- `ScriptableRenderer.Profiling.RenderBlock`

  - `field declaration order/names: ['beforeRendering', 'mainRenderingOpaque', 'mainRenderingTransparent', 'afterRendering'] → ['k_Name', 'beforeRendering', 'mainRenderingOpaque', 'mainRenderingTransparent', 'afterRendering']`
  - `extra field constant string k_Name`

- `ScriptableRenderer.Profiling.RenderPass`

  - `field declaration order/names: ['configure', 'setRenderPassAttachments'] → ['k_Name', 'configure', 'setRenderPassAttachments']`
  - `extra field constant string k_Name`

- `UnityEngine.Rendering.Universal.CapturePass`

  - `field declaration order/names: ['m_CameraColorHandle', 'm_ProfilingSampler'] → ['m_CameraColorHandle', 'm_ProfilerTag', 'm_ProfilingSampler']`
  - `extra field constant string m_ProfilerTag`

- `UnityEngine.Rendering.Universal.DBufferRenderPass`

  - `field declaration order/names: ['s_DBufferNames', 's_DBufferDepthName', 'm_DrawSystem', 'm_Settings', 'm_DBufferClear', 'm_FilteringSettings', 'm_ShaderTagIdList', 'm_ProfilingSampler', 'm_DBufferClearSampler', 'm_DecalLayers', '<dBufferColorHandles>k__BackingField'] → ['s_DBufferNames', 's_DBufferDepthName', 'm_DrawSystem', 'm_Settings', 'm_DBufferClear', 'm_FilteringSettings', 'm_ShaderTagIdList', 'm_ProfilingSampler', 'm_DBufferClearSampler', 'm_DecalLayers', 'm_DBufferDepth', '<dBufferColorHandles>k__BackingField', '<depthHandle>k__BackingField']`
  - `<dBufferColorHandles>k__BackingField: offset '0x138' → '0x140'`
  - `extra field instance RTHandle m_DBufferDepth`
  - `extra field instance RTHandle <depthHandle>k__BackingField`

- `UnityEngine.Rendering.Universal.DecalDrawSystem`

  - `field declaration order/names: ['MaxBatchSize', 'm_EntityManager', 'm_WorldToDecals', 'm_NormalToDecals', 'm_DecalLayerMasks', 'm_Sampler'] → ['MaxBatchSize', 'm_EntityManager', 'm_WorldToDecals', 'm_NormalToDecals', 'm_DecalLayerMasks', 'm_Sampler', '<overrideMaterial>k__BackingField']`
  - `extra field instance Material <overrideMaterial>k__BackingField`

- `UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass`

  - `field declaration order/names: ['m_CascadeBorder', 'm_MaxShadowDistanceSq', 'm_ShadowCasterCascadesCount', 'm_MainLightShadowmapID', 'm_MainLightShadowmapTexture', 'm_EmptyMainLightShadowmapTexture', 's_EmptyShadowParams', 's_EmptyShadowmapSize', 'm_MainLightShadowMatrices', 'm_CascadeSlices', 'm_CascadeSplitDistances', 'm_CreateEmptyShadowmap', 'renderTargetWidth', 'renderTargetHeight', 'm_ProfilingSetupSampler'] → ['k_MaxCascades', 'k_ShadowmapBufferBits', 'm_CascadeBorder', 'm_MaxShadowDistanceSq', 'm_ShadowCasterCascadesCount', 'm_MainLightShadowmapID', 'm_MainLightShadowmapTexture', 'm_EmptyMainLightShadowmapTexture', 'k_EmptyShadowMapDimensions', 'k_MainLightShadowMapTextureName', 'k_EmptyMainLightShadowMapTextureName', 's_EmptyShadowParams', 's_EmptyShadowmapSize', 'm_MainLightShadowMatrices', 'm_CascadeSlices', 'm_CascadeSplitDistances', 'm_CreateEmptyShadowmap', 'renderTargetWidth', 'renderTargetHeight', 'm_ProfilingSetupSampler']`
  - `extra field constant int k_MaxCascades`
  - `extra field constant int k_ShadowmapBufferBits`
  - `extra field constant int k_EmptyShadowMapDimensions`
  - `extra field constant string k_MainLightShadowMapTextureName`
  - `extra field constant string k_EmptyMainLightShadowMapTextureName`

- `UnityEngine.Rendering.Universal.MotionVectorRenderPass`

  - `field declaration order/names: ['s_ShaderTags', 'm_Color', 'm_Depth', 'm_CameraMaterial', 'm_ObjectMaterial', 'm_FilteringSettings', 'm_PassData'] → ['kPreviousViewProjectionNoJitter', 'kViewProjectionNoJitter', 'kPreviousViewProjectionNoJitterStereo', 'kViewProjectionNoJitterStereo', 'k_TargetFormat', 's_ShaderTags', 'm_Color', 'm_Depth', 'm_CameraMaterial', 'm_ObjectMaterial', 'm_FilteringSettings', 'm_PassData']`
  - `extra field constant string kPreviousViewProjectionNoJitter`
  - `extra field constant string kViewProjectionNoJitter`
  - `extra field constant string kPreviousViewProjectionNoJitterStereo`
  - `extra field constant string kViewProjectionNoJitterStereo`
  - `extra field constant GraphicsFormat k_TargetFormat`

- `UnityEngine.Rendering.Universal.PostProcessPass`

  - `field declaration order/names: ['m_Descriptor', 'm_Source', 'm_Destination', 'm_Depth', 'm_InternalLut', 'm_MotionVectors', 'm_FullCoCTexture', 'm_HalfCoCTexture', 'm_PingTexture', 'm_PongTexture', 'm_BloomMipDown', 'm_BloomMipUp', 'm_BlendTexture', 'm_EdgeColorTexture', 'm_EdgeStencilTexture', 'm_TempTarget', 'm_TempTarget2', 'm_ProfilingRenderPostProcessing', 'm_ProfilingRenderFinalPostProcessing', 'm_Materials', 'm_Data', 'm_DepthOfField', 'm_MotionBlur', 'm_PaniniProjection', 'm_Bloom', 'm_LensDistortion', 'm_ChromaticAberration', 'm_Vignette', 'm_ColorLookup', 'm_ColorAdjustments', 'm_Tonemapping', 'm_FilmGrain', 'm_DefaultHDRFormat', 'm_UseRGBM', 'm_SMAAEdgeFormat', 'm_GaussianCoCFormat', 'm_DitheringTextureIndex', 'm_MRT2', 'm_BokehKernel', 'm_BokehHash', 'm_BokehMaxRadius', 'm_BokehRCPAspect', 'm_IsFinalPass', 'm_HasFinalPass', 'm_EnableColorEncodingIfNeeded', 'm_UseFastSRGBLinearConversion', 'm_SupportDataDrivenLensFlare', 'm_ResolveToScreen', 'm_UseSwapBuffer', 'm_ScalingSetupTarget', 'm_UpscaledTarget', 'm_BlitMaterial', 'k_ShaderPropertyId_ViewProjM', 'k_ShaderPropertyId_PrevViewProjM', 'k_ShaderPropertyId_ViewProjMStereo', 'k_ShaderPropertyId_PrevViewProjMStereo'] → ['m_Descriptor', 'm_Source', 'm_Destination', 'm_Depth', 'm_InternalLut', 'm_MotionVectors', 'm_FullCoCTexture', 'm_HalfCoCTexture', 'm_PingTexture', 'm_PongTexture', 'm_BloomMipDown', 'm_BloomMipUp', 'm_BlendTexture', 'm_EdgeColorTexture', 'm_EdgeStencilTexture', 'm_TempTarget', 'm_TempTarget2', 'k_RenderPostProcessingTag', 'k_RenderFinalPostProcessingTag', 'm_ProfilingRenderPostProcessing', 'm_ProfilingRenderFinalPostProcessing', 'm_Materials', 'm_Data', 'm_DepthOfField', 'm_MotionBlur', 'm_PaniniProjection', 'm_Bloom', 'm_LensDistortion', 'm_ChromaticAberration', 'm_Vignette', 'm_ColorLookup', 'm_ColorAdjustments', 'm_Tonemapping', 'm_FilmGrain', 'k_MaxPyramidSize', 'm_DefaultHDRFormat', 'm_UseRGBM', 'm_SMAAEdgeFormat', 'm_GaussianCoCFormat', 'm_DitheringTextureIndex', 'm_MRT2', 'm_BokehKernel', 'm_BokehHash', 'm_BokehMaxRadius', 'm_BokehRCPAspect', 'm_IsFinalPass', 'm_HasFinalPass', 'm_EnableColorEncodingIfNeeded', 'm_UseFastSRGBLinearConversion', 'm_SupportDataDrivenLensFlare', 'm_ResolveToScreen', 'm_UseSwapBuffer', 'm_ScalingSetupTarget', 'm_UpscaledTarget', 'm_BlitMaterial', 'k_ShaderPropertyId_ViewProjM', 'k_ShaderPropertyId_PrevViewProjM', 'k_ShaderPropertyId_ViewProjMStereo', 'k_ShaderPropertyId_PrevViewProjMStereo']`
  - `extra field constant string k_RenderPostProcessingTag`
  - `extra field constant string k_RenderFinalPostProcessingTag`
  - `extra field constant int k_MaxPyramidSize`

- `UnityEngine.Rendering.Universal.RenderingUtils`

  - `field declaration order/names: ['m_LegacyShaderPassNames', 's_EmptyAttachment', 's_FullscreenMesh', 'm_RenderTextureFormatSupport', 'm_GraphicsFormatSupport'] → ['m_LegacyShaderPassNames', 's_EmptyAttachment', 's_FullscreenMesh', 's_ErrorMaterial', 'm_RenderTextureFormatSupport', 'm_GraphicsFormatSupport']`
  - `m_RenderTextureFormatSupport: offset '0x88' → '0x90'`
  - `m_GraphicsFormatSupport: offset '0x90' → '0x98'`
  - `extra field static Material s_ErrorMaterial`

- `UnityEngine.Rendering.Universal.ShadowResolution`

  - `field declaration order/names: ['value__', '_256', '_512', '_1024', '_2048', '_4096', '_8192'] → ['value__', '_256', '_512', '_1024', '_2048', '_4096']`
  - `missing field constant ShadowResolution _8192`

- `UnityEngine.Rendering.Universal.ShadowUtils`

  - `field declaration order/names: ['m_ForceShadowPointSampling', '_ShadowBias', '_LightDirection', '_LightPosition'] → ['m_ForceShadowPointSampling', '_ShadowBias', '_LightDirection', '_LightPosition', 'kMinimumPunctualLightHardShadowResolution', 'kMinimumPunctualLightSoftShadowResolution']`
  - `extra field constant int kMinimumPunctualLightHardShadowResolution`
  - `extra field constant int kMinimumPunctualLightSoftShadowResolution`

- `UnityEngine.Rendering.Universal.TransparentSettingsPass`

  - `field declaration order/names: ['m_shouldReceiveShadows', 'm_ProfilingSampler'] → ['m_shouldReceiveShadows', 'm_ProfilerTag', 'm_ProfilingSampler']`
  - `extra field constant string m_ProfilerTag`

- `UnityEngine.Rendering.Universal.UniversalRenderPipeline`

  - `field declaration order/names: ['m_DebugDisplaySettingsUI', 'm_GlobalSettings', 'cameraStackRequiresDepthForPostprocessing', 's_RenderGraph', 's_RTHandlePool', 'useRenderGraph', 'pipelineAsset', 'enableHDROnce', 'k_DefaultLightPosition', 'k_DefaultLightColor', 'k_DefaultLightAttenuation', 'k_DefaultLightSpotDirection', 'k_DefaultLightsProbeChannel', 'm_ShadowBiasData', 'm_ShadowResolutionData', 'cameraComparison', 'lightsDelegate'] → ['k_ShaderTagName', 'k_DefaultRenderingLayerMask', 'm_DebugDisplaySettingsUI', 'm_GlobalSettings', 'cameraStackRequiresDepthForPostprocessing', 's_RenderGraph', 's_RTHandlePool', 'useRenderGraph', 'pipelineAsset', 'enableHDROnce', 'k_DefaultLightPosition', 'k_DefaultLightColor', 'k_DefaultLightAttenuation', 'k_DefaultLightSpotDirection', 'k_DefaultLightsProbeChannel', 'm_ShadowBiasData', 'm_ShadowResolutionData', 'cameraComparison', 'lightsDelegate']`
  - `extra field constant string k_ShaderTagName`
  - `extra field constant int k_DefaultRenderingLayerMask`

- `UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings`

  - `bases: 'RenderPipelineGlobalSettings, ISerializationCallbackReceiver' → 'RenderPipelineGlobalSettings, IShaderVariantSettings, ISerializationCallbackReceiver'`

- `UnityEngine.Rendering.Universal.UniversalRenderer`

  - `field declaration order/names: ['k_DepthNormalsOnly', 'm_Clustering', 'm_DepthPrepass', 'm_DepthNormalPrepass', 'm_PrimedDepthCopyPass', 'm_MotionVectorPass', 'm_MainLightShadowCasterPass', 'm_AdditionalLightsShadowCasterPass', 'm_GBufferPass', 'm_GBufferCopyDepthPass', 'm_DeferredPass', 'm_RenderOpaqueForwardOnlyPass', 'm_RenderOpaqueForwardPass', 'm_RenderOpaqueForwardWithRenderingLayersPass', 'm_DrawSkyboxPass', 'm_CopyDepthPass', 'm_CopyColorPass', 'm_TransparentSettingsPass', 'm_RenderTransparentForwardPass', 'm_OnRenderObjectCallbackPass', 'm_FinalBlitPass', 'm_CapturePass', 'm_XROcclusionMeshPass', 'm_XRCopyDepthPass', 'm_DrawOffscreenUIPass', 'm_DrawOverlayUIPass', 'm_ColorBufferSystem', 'm_ActiveCameraColorAttachment', 'm_ActiveCameraDepthAttachment', 'm_CameraDepthAttachment', 'm_XRTargetHandleAlias', 'm_CameraDepthAttachment_D3d_11', 'm_DepthTexture', 'm_NormalsTexture', 'm_DecalLayersTexture', 'm_OpaqueColor', 'm_MotionVectorColor', 'm_MotionVectorDepth', 'm_ForwardLights', 'm_DeferredLights', 'm_RenderingMode', 'm_DepthPrimingMode', 'm_CopyDepthMode', 'm_DepthPrimingRecommended', 'm_DefaultStencilState', 'm_LightCookieManager', 'm_IntermediateTextureMode', 'm_VulkanEnablePreTransform', 'm_BlitMaterial', 'm_BlitHDRMaterial', 'm_CopyDepthMaterial', 'm_SamplingMaterial', 'm_StencilDeferredMaterial', 'm_CameraMotionVecMaterial', 'm_ObjectMotionVecMaterial', 'm_PostProcessPasses', 'm_RenderGraphCameraColorHandle', 'm_RenderGraphCameraDepthHandle', 'm_ActiveRenderGraphColor', 'm_ActiveRenderGraphDepth', 'm_TargetIsBackbuffer', 'frameResources', 'm_UseIntermediateTexture'] → ['k_DepthStencilFormat', 'k_DepthBufferBits', 'k_FinalBlitPassQueueOffset', 'k_AfterFinalBlitPassQueueOffset', 'k_DepthNormalsOnly', 'm_Clustering', 'm_DepthPrepass', 'm_DepthNormalPrepass', 'm_PrimedDepthCopyPass', 'm_MotionVectorPass', 'm_MainLightShadowCasterPass', 'm_AdditionalLightsShadowCasterPass', 'm_GBufferPass', 'm_GBufferCopyDepthPass', 'm_DeferredPass', 'm_RenderOpaqueForwardOnlyPass', 'm_RenderOpaqueForwardPass', 'm_RenderOpaqueForwardWithRenderingLayersPass', 'm_DrawSkyboxPass', 'm_CopyDepthPass', 'm_CopyColorPass', 'm_TransparentSettingsPass', 'm_RenderTransparentForwardPass', 'm_OnRenderObjectCallbackPass', 'm_FinalBlitPass', 'm_CapturePass', 'm_XROcclusionMeshPass', 'm_XRCopyDepthPass', 'm_DrawOffscreenUIPass', 'm_DrawOverlayUIPass', 'm_ColorBufferSystem', 'm_ActiveCameraColorAttachment', 'm_ColorFrontBuffer', 'm_ActiveCameraDepthAttachment', 'm_CameraDepthAttachment', 'm_XRTargetHandleAlias', 'm_CameraDepthAttachment_D3d_11', 'm_DepthTexture', 'm_NormalsTexture', 'm_DecalLayersTexture', 'm_OpaqueColor', 'm_MotionVectorColor', 'm_MotionVectorDepth', 'm_ForwardLights', 'm_DeferredLights', 'm_RenderingMode', 'm_DepthPrimingMode', 'm_CopyDepthMode', 'm_DepthPrimingRecommended', 'm_DefaultStencilState', 'm_LightCookieManager', 'm_IntermediateTextureMode', 'm_VulkanEnablePreTransform', 'm_BlitMaterial', 'm_BlitHDRMaterial', 'm_CopyDepthMaterial', 'm_SamplingMaterial', 'm_StencilDeferredMaterial', 'm_CameraMotionVecMaterial', 'm_ObjectMotionVecMaterial', 'm_PostProcessPasses', 'm_RenderGraphCameraColorHandle', 'm_RenderGraphCameraDepthHandle', 'm_ActiveRenderGraphColor', 'm_ActiveRenderGraphDepth', 'm_TargetIsBackbuffer', 'frameResources', 'm_UseIntermediateTexture']`
  - `m_ActiveCameraDepthAttachment: offset '0x288' → '0x290'`
  - `m_CameraDepthAttachment: offset '0x290' → '0x298'`
  - `m_XRTargetHandleAlias: offset '0x298' → '0x2a0'`
  - `m_CameraDepthAttachment_D3d_11: offset '0x2a0' → '0x2a8'`
  - `m_DepthTexture: offset '0x2a8' → '0x2b0'`
  - `m_NormalsTexture: offset '0x2b0' → '0x2b8'`
  - `m_DecalLayersTexture: offset '0x2b8' → '0x2c0'`
  - `m_OpaqueColor: offset '0x2c0' → '0x2c8'`
  - `m_MotionVectorColor: offset '0x2c8' → '0x2d0'`
  - `m_MotionVectorDepth: offset '0x2d0' → '0x2d8'`
  - `m_ForwardLights: offset '0x2d8' → '0x2e0'`
  - `m_DeferredLights: offset '0x2e0' → '0x2e8'`
  - `m_RenderingMode: offset '0x2e8' → '0x2f0'`
  - `m_DepthPrimingMode: offset '0x2ec' → '0x2f4'`
  - `m_CopyDepthMode: offset '0x2f0' → '0x2f8'`
  - `m_DepthPrimingRecommended: offset '0x2f4' → '0x2fc'`
  - `m_DefaultStencilState: offset '0x2f5' → '0x2fd'`
  - `m_LightCookieManager: offset '0x308' → '0x310'`
  - `m_IntermediateTextureMode: offset '0x310' → '0x318'`
  - `m_VulkanEnablePreTransform: offset '0x314' → '0x31c'`
  - `m_BlitMaterial: offset '0x318' → '0x320'`
  - `m_BlitHDRMaterial: offset '0x320' → '0x328'`
  - `m_CopyDepthMaterial: offset '0x328' → '0x330'`
  - `m_SamplingMaterial: offset '0x330' → '0x338'`
  - `m_StencilDeferredMaterial: offset '0x338' → '0x340'`
  - `m_CameraMotionVecMaterial: offset '0x340' → '0x348'`
  - `m_ObjectMotionVecMaterial: offset '0x348' → '0x350'`
  - `m_PostProcessPasses: offset '0x350' → '0x358'`
  - `m_TargetIsBackbuffer: offset '0x390' → '0x398'`
  - `frameResources: offset '0x398' → '0x3a0'`
  - `extra field constant GraphicsFormat k_DepthStencilFormat`
  - `extra field constant int k_DepthBufferBits`
  - `extra field constant int k_FinalBlitPassQueueOffset`
  - `extra field constant int k_AfterFinalBlitPassQueueOffset`
  - `extra field instance RTHandle m_ColorFrontBuffer`

- `UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode`

  - `field declaration order/names: ['value__', 'EveryFrame', 'ViaScripting', 'UsePipelineSettings', 'UseMainCamera'] → ['value__', 'EveryFrame', 'ViaScripting', 'UsePipelineSettings']`
  - `missing field constant VolumeFrameworkUpdateMode UseMainCamera`

- `UnityEngine.Rendering.Universal.ZBinningJob`

  - `field declaration order/names: ['bins', 'minMaxZs', 'zBinScale', 'zBinOffset', 'binCount', 'wordsPerTile', 'lightCount', 'reflectionProbeCount', 'batchCount', 'viewCount', 'isOrthographic'] → ['batchSize', 'headerLength', 'bins', 'minMaxZs', 'zBinScale', 'zBinOffset', 'binCount', 'wordsPerTile', 'lightCount', 'reflectionProbeCount', 'batchCount', 'viewCount', 'isOrthographic']`
  - `extra field constant int batchSize`
  - `extra field constant int headerLength`

- `UniversalAdditionalCameraData.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__55_0'] → ['<>9', '<>9__64_0']`
  - `missing field static Predicate<Camera> <>9__55_0`
  - `extra field static Predicate<Camera> <>9__64_0`

- `UniversalRenderPipeline.Profiling.Pipeline`

  - `field declaration order/names: ['beginContextRendering', 'endContextRendering', 'beginCameraRendering', 'endCameraRendering', 'initializeCameraData', 'initializeStackedCameraData', 'initializeAdditionalCameraData', 'initializeRenderingData', 'initializeShadowData', 'initializeLightData', 'getPerObjectLightFlags', 'getMainLightIndex', 'setupPerFrameShaderConstants', 'setupPerCameraShaderConstants'] → ['beginContextRendering', 'endContextRendering', 'beginCameraRendering', 'endCameraRendering', 'k_Name', 'initializeCameraData', 'initializeStackedCameraData', 'initializeAdditionalCameraData', 'initializeRenderingData', 'initializeShadowData', 'initializeLightData', 'getPerObjectLightFlags', 'getMainLightIndex', 'setupPerFrameShaderConstants', 'setupPerCameraShaderConstants']`
  - `extra field constant string k_Name`

- `UniversalRenderPipeline.Profiling.Pipeline.Context`

  - `field declaration order/names: ['submit'] → ['k_Name', 'submit']`
  - `extra field constant string k_Name`

- `UniversalRenderPipeline.Profiling.Pipeline.Renderer`

  - `field declaration order/names: ['setupCullingParameters', 'setup'] → ['k_Name', 'setupCullingParameters', 'setup']`
  - `extra field constant string k_Name`

- `UniversalRenderer.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__93_0', '<>9__93_1'] → ['<>9', '<>9__92_0', '<>9__92_1']`
  - `missing field static Predicate<ScriptableRenderPass> <>9__93_0`
  - `missing field static Predicate<ScriptableRenderPass> <>9__93_1`
  - `extra field static Predicate<ScriptableRenderPass> <>9__92_0`
  - `extra field static Predicate<ScriptableRenderPass> <>9__92_1`

- `UniversalRenderer.Profiling`

  - `field declaration order/names: ['createCameraRenderTarget'] → ['k_Name', 'createCameraRenderTarget']`
  - `extra field constant string k_Name`

- `UniversalRendererData.ShaderResources`

  - `field declaration order/names: ['blitPS', 'copyDepthPS', 'screenSpaceShadowPS', 'samplingPS', 'stencilDeferredPS', 'fallbackErrorPS', 'fallbackLoadingPS', 'materialErrorPS', 'coreBlitPS', 'coreBlitColorAndDepthPS', 'blitHDROverlay', 'cameraMotionVector', 'objectMotionVector', 'dataDrivenLensFlare'] → ['blitPS', 'copyDepthPS', 'screenSpaceShadowPS', 'samplingPS', 'stencilDeferredPS', 'fallbackErrorPS', 'fallbackLoadingPS', 'materialErrorPS', 'coreBlitPS', 'coreBlitColorAndDepthPS', 'blitHDROverlay', 'cameraMotionVector', 'objectMotionVector', 'dataDrivenLensFlare', 'terrainDetailLitPS', 'terrainDetailGrassPS', 'terrainDetailGrassBillboardPS']`
  - `extra field instance Shader terrainDetailLitPS`
  - `extra field instance Shader terrainDetailGrassPS`
  - `extra field instance Shader terrainDetailGrassBillboardPS`

- `VL.Rendering.VLDecalRendererFeature`

  - `field declaration order/names: ['MaxDrawDistance', 'layer', '<sharedDecalEntityManager>k__BackingField', 'm_RecreateSystems', 'm_DecalPreviewPass', 'm_LitDecalPass', 'm_ActorDecalPass', 'm_DecalEntityManager', 'm_DecalUpdateCachedSystem', 'm_DecalUpdateCullingGroupSystem', 'm_DecalUpdateCulledSystem', 'm_DecalCreateDrawCallSystem', 'm_DecalPrioritySystem', '_vlLitDecalDrawSystem', '_actorDecalDrawSystem'] → ['MaxDrawDistance', 'layer', 'm_RecreateSystems', 'm_DecalPreviewPass', 'm_LitDecalPass', 'm_ActorDecalPass', 'm_DecalEntityManager', 'm_DecalUpdateCachedSystem', 'm_DecalUpdateCullingGroupSystem', 'm_DecalUpdateCulledSystem', 'm_DecalCreateDrawCallSystem', 'm_DecalPrioritySystem', '_vlLitDecalDrawSystem', '_actorDecalDrawSystem', '<sharedDecalEntityManager>k__BackingField']`

- `VL.Rendering.VLSRPRenderer`

  - `m_VLMotionVectorPass: offset '0x3a0' → '0x3a8'`
  - `m_DrawSkyboxPass: offset '0x3a8' → '0x3b0'`
  - `m_LitColorTexture: offset '0x3b0' → '0x3b8'`
  - `m_AdditionalInfoTexture: offset '0x3b8' → '0x3c0'`
  - `m_SkyMaterial: offset '0x3c0' → '0x3c8'`
  - `m_FogMaterial: offset '0x3c8' → '0x3d0'`
  - `m_VLPostProcessPasses: offset '0x3d0' → '0x3d8'`
  - `_vlDeferredPass: offset '0x420' → '0x428'`
  - `m_ActorForward: offset '0x428' → '0x430'`
  - `_vlPreDepthIDPass: offset '0x430' → '0x438'`

- `VLSRPRenderer.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__27_0', '<>9__27_1'] → ['<>9', '<>9__26_0', '<>9__26_1']`
  - `missing field static Predicate<ScriptableRenderPass> <>9__27_0`
  - `missing field static Predicate<ScriptableRenderPass> <>9__27_1`
  - `extra field static Predicate<ScriptableRenderPass> <>9__26_0`
  - `extra field static Predicate<ScriptableRenderPass> <>9__26_1`


</details>

<details><summary>Indeterminate: 10</summary>

- `EntityManager.TempChunks<TComponent, TChunkKey, TCombinedChunks, TEntityChunk>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LightCookieManager.Sorting.<>c__DisplayClass2_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LightCookieManager.WorkSlice<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Rendering.Universal.Fixed2<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.EntityChunk<TComponent, TChunkKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.EntityChunk<TComponent>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.EntityComponentEvent<TComponent>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.EntityManager<TComponent, TChunkKey, TCombinedChunks, TEntityChunk>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.SharedEntityManager<TManager, TComponent>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.EntitySystem.SingleEntityManager<TComponent, TCombinedChunks, TEntityChunk>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 1</summary>

- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass14_0` (compiler-generated name)

</details>

<details><summary>Extra: 184</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=31302`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=37066`
- `Clipper.NodeType`
- `DeferredLights.StencilDeferredPasses`
- `Dict.LessOrEqual<TValue>`
- `Dict.Node<TValue>`
- `DrawScreenSpaceUIPass.<>c` (compiler-generated name)
- `FinalBlitPass.BlitPassNames`
- `ForwardRendererData.ShaderResources`
- `FullScreenPassRendererFeature`
- `FullScreenPassRendererFeature.FullScreenRenderPass`
- `FullScreenPassRendererFeature.InjectionPoint`
- `FullScreenPassRendererFeature.Version`
- `HDRDebugViewPass.HDRDebugPassId`
- `IntersectionCompare.<xvasort>e__FixedBuffer` (compiler-generated name)
- `IntersectionCompare.<xvbsort>e__FixedBuffer` (compiler-generated name)
- `LayerBatch.<renderTargetIds>e__FixedBuffer` (compiler-generated name)
- `LayerBatch.<renderTargetUsed>e__FixedBuffer` (compiler-generated name)
- `Light2D.ComponentVersions`
- `Light2D.DeprecatedLightType`
- `Light2D.LightType`
- `Light2D.NormalMapQuality`
- `Light2D.OverlapOperation`
- `Light2DBlendStyle.BlendFactors`
- `Light2DBlendStyle.BlendMode`
- `Light2DBlendStyle.MaskChannelFilter`
- `Light2DBlendStyle.TextureChannel`
- `Light2DCullResult.<>c` (compiler-generated name)
- `LightUtility.LightMeshVertex`
- `LightUtility.PivotType`
- `MeshUtils.Edge`
- `MeshUtils.EdgePair`
- `MeshUtils.Face`
- `MeshUtils.Pooled<T>`
- `MeshUtils.Vertex`
- `PixelPerfectCamera.ComponentVersions`
- `PriorityHeap.HandleElem<TValue>`
- `PriorityHeap.LessOrEqual<TValue>`
- `PriorityQueue.StackItem<TValue>`
- `Render2DLightingPass.<>c` (compiler-generated name)
- `Renderer2D.<>c` (compiler-generated name)
- `Renderer2D.RenderPassInputSummary`
- `Renderer2DData.Renderer2DDefaultMaterialType`
- `ScreenSpaceShadows.ScreenSpaceShadowsPass`
- `ScreenSpaceShadows.ScreenSpaceShadowsPostPass`
- `ShaderUtils.<>c__DisplayClass2_0` (compiler-generated name)
- `ShadowCaster2D.ComponentVersions`
- `ShadowUtility.<>c` (compiler-generated name)
- `ShadowUtility.Edge`
- `TemporalAA.<>c` (compiler-generated name)
- `TemporalAA.TaaPassData`
- `Tess.ActiveRegion`
- `Tessellator.TestCellE`
- `Tessellator.TestEdgePointE`
- `Tessellator.TestHullEventE`
- `Tessellator.TestHullEventLe`
- `Tessellator.TestHullPointL`
- `Tessellator.TestHullPointU`
- `UnityEngine.Rendering.Universal.CameraTypeUtility`
- `UnityEngine.Rendering.Universal.CinemachineUniversalPixelPerfect`
- `UnityEngine.Rendering.Universal.ClipType`
- `UnityEngine.Rendering.Universal.Clipper`
- `UnityEngine.Rendering.Universal.ClipperBase`
- `UnityEngine.Rendering.Universal.ClipperException`
- `UnityEngine.Rendering.Universal.ClipperOffset`
- `UnityEngine.Rendering.Universal.ComponentUtility`
- `UnityEngine.Rendering.Universal.CompositeShadowCaster2D`
- `UnityEngine.Rendering.Universal.DecalDrawErrorSystem`
- `UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem`
- `UnityEngine.Rendering.Universal.DecalDrawGBufferSystem`
- `UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem`
- `UnityEngine.Rendering.Universal.DecalForwardEmissivePass`
- `UnityEngine.Rendering.Universal.DecalGBufferRenderPass`
- `UnityEngine.Rendering.Universal.DecalNormalBlend`
- `UnityEngine.Rendering.Universal.DecalRendererFeature`
- `UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass`
- `UnityEngine.Rendering.Universal.DecalScreenSpaceSettings`
- `UnityEngine.Rendering.Universal.DecalSettings`
- `UnityEngine.Rendering.Universal.DecalShaderPassNames`
- `UnityEngine.Rendering.Universal.DecalSkipCulledSystem`
- `UnityEngine.Rendering.Universal.DecalTechnique`
- `UnityEngine.Rendering.Universal.DecalTechniqueOption`
- `UnityEngine.Rendering.Universal.Direction`
- `UnityEngine.Rendering.Universal.Documentation`
- `UnityEngine.Rendering.Universal.DoublePoint`
- `UnityEngine.Rendering.Universal.EdgeSide`
- `UnityEngine.Rendering.Universal.EndType`
- `UnityEngine.Rendering.Universal.ForwardRenderer`
- `UnityEngine.Rendering.Universal.ForwardRendererData`
- `UnityEngine.Rendering.Universal.ILight2DCullResult`
- `UnityEngine.Rendering.Universal.IRenderPass2D`
- `UnityEngine.Rendering.Universal.Int128`
- `UnityEngine.Rendering.Universal.IntPoint`
- `UnityEngine.Rendering.Universal.IntRect`
- `UnityEngine.Rendering.Universal.Internal.LightFlag`
- `UnityEngine.Rendering.Universal.Internal.StencilUsage`
- `UnityEngine.Rendering.Universal.IntersectNode`
- `UnityEngine.Rendering.Universal.Join`
- `UnityEngine.Rendering.Universal.JoinType`
- `UnityEngine.Rendering.Universal.LayerBatch`
- `UnityEngine.Rendering.Universal.LayerUtility`
- `UnityEngine.Rendering.Universal.LibTessDotNet.CombineCallback`
- `UnityEngine.Rendering.Universal.LibTessDotNet.ContourOrientation`
- `UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex`
- `UnityEngine.Rendering.Universal.LibTessDotNet.Dict<TValue>`
- `UnityEngine.Rendering.Universal.LibTessDotNet.ElementType`
- `UnityEngine.Rendering.Universal.LibTessDotNet.Geom`
- `UnityEngine.Rendering.Universal.LibTessDotNet.Mesh`
- `UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils`
- `UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle`
- `UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap<TValue>`
- `UnityEngine.Rendering.Universal.LibTessDotNet.PriorityQueue<TValue>`
- `UnityEngine.Rendering.Universal.LibTessDotNet.Tess`
- `UnityEngine.Rendering.Universal.LibTessDotNet.Vec3`
- `UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule`
- `UnityEngine.Rendering.Universal.Light2D`
- `UnityEngine.Rendering.Universal.Light2DBlendStyle`
- `UnityEngine.Rendering.Universal.Light2DCullResult`
- `UnityEngine.Rendering.Universal.Light2DLookupTexture`
- `UnityEngine.Rendering.Universal.Light2DManager`
- `UnityEngine.Rendering.Universal.LightStats`
- `UnityEngine.Rendering.Universal.LightUtility`
- `UnityEngine.Rendering.Universal.LocalMinima`
- `UnityEngine.Rendering.Universal.Maxima`
- `UnityEngine.Rendering.Universal.MyIntersectNodeSort`
- `UnityEngine.Rendering.Universal.OutPt`
- `UnityEngine.Rendering.Universal.OutRec`
- `UnityEngine.Rendering.Universal.PinnedArray<T>`
- `UnityEngine.Rendering.Universal.PixelPerfectBackgroundPass`
- `UnityEngine.Rendering.Universal.PolyFillType`
- `UnityEngine.Rendering.Universal.PolyNode`
- `UnityEngine.Rendering.Universal.PolyTree`
- `UnityEngine.Rendering.Universal.PolyType`
- `UnityEngine.Rendering.Universal.PreTile`
- `UnityEngine.Rendering.Universal.PunctualLightData`
- `UnityEngine.Rendering.Universal.Render2DLightingPass`
- `UnityEngine.Rendering.Universal.RenderTargetHandle`
- `UnityEngine.Rendering.Universal.Renderer2D`
- `UnityEngine.Rendering.Universal.Renderer2DData`
- `UnityEngine.Rendering.Universal.RendererLighting`
- `UnityEngine.Rendering.Universal.RendererOverrideOption`
- `UnityEngine.Rendering.Universal.SampleCount`
- `UnityEngine.Rendering.Universal.Scanbeam`
- `UnityEngine.Rendering.Universal.ScreenSpaceShadows`
- `UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings`
- `UnityEngine.Rendering.Universal.ShaderKeywordStrings`
- `UnityEngine.Rendering.Universal.ShadowCaster2D`
- `UnityEngine.Rendering.Universal.ShadowCasterGroup2D`
- `UnityEngine.Rendering.Universal.ShadowCasterGroup2DManager`
- `UnityEngine.Rendering.Universal.ShadowRendering`
- `UnityEngine.Rendering.Universal.ShadowUtility`
- `UnityEngine.Rendering.Universal.TEdge`
- `UnityEngine.Rendering.Universal.TileData`
- `UnityEngine.Rendering.Universal.TileSize`
- `UnityEngine.Rendering.Universal.TileSizeExtensions`
- `UnityEngine.Rendering.Universal.URPHelpURLAttribute`
- `UnityEngine.Rendering.Universal.UTess.ArraySlice<T>`
- `UnityEngine.Rendering.Universal.UTess.ArraySliceDebugView<T>`
- `UnityEngine.Rendering.Universal.UTess.DelaEdgeCompare`
- `UnityEngine.Rendering.Universal.UTess.ICondition2<T, U>`
- `UnityEngine.Rendering.Universal.UTess.IntersectionCompare`
- `UnityEngine.Rendering.Universal.UTess.ModuleHandle`
- `UnityEngine.Rendering.Universal.UTess.PlanarGraph`
- `UnityEngine.Rendering.Universal.UTess.Refinery`
- `UnityEngine.Rendering.Universal.UTess.Smoothen`
- `UnityEngine.Rendering.Universal.UTess.TessCellCompare`
- `UnityEngine.Rendering.Universal.UTess.TessEdgeCompare`
- `UnityEngine.Rendering.Universal.UTess.TessEventCompare`
- `UnityEngine.Rendering.Universal.UTess.TessJunctionCompare`
- `UnityEngine.Rendering.Universal.UTess.TessLink`
- `UnityEngine.Rendering.Universal.UTess.Tessellator`
- `UnityEngine.Rendering.Universal.UTess.UBounds`
- `UnityEngine.Rendering.Universal.UTess.UCircle`
- `UnityEngine.Rendering.Universal.UTess.UEncroachingSegment`
- `UnityEngine.Rendering.Universal.UTess.UEvent`
- `UnityEngine.Rendering.Universal.UTess.UEventType`
- `UnityEngine.Rendering.Universal.UTess.UHull`
- `UnityEngine.Rendering.Universal.UTess.UStar`
- `UnityEngine.Rendering.Universal.UTess.UTriangle`
- `UnityEngine.Rendering.Universal.UTess.XCompare`
- `UnityEngine.Rendering.Universal.UpscalePass`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.TextMeshPro.dll

<details><summary>Matching: 120</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `TMP_FontAsset.<>c` (compiler-generated name)
- `TMP_FontFeatureTable.<>c` (compiler-generated name)
- `TMP_InputField.<CaretBlink>d__295` (compiler-generated name)
- `TMP_InputField.<MouseDragOutsideRect>d__316` (compiler-generated name)
- `TMP_InputField.CharacterValidation`
- `TMP_InputField.ContentType`
- `TMP_InputField.EditState`
- `TMP_InputField.InputType`
- `TMP_InputField.LineType`
- `TMP_InputField.OnChangeEvent`
- `TMP_InputField.OnValidateInput`
- `TMP_InputField.SelectionEvent`
- `TMP_InputField.SubmitEvent`
- `TMP_InputField.TextSelectionEvent`
- `TMP_InputField.TouchScreenKeyboardEvent`
- `TMP_MaterialManager.FallbackMaterial`
- `TMP_MaterialManager.MaskingMaterial`
- `TMP_ResourceManager.FontAssetRef`
- `TMP_Settings.LineBreakingTable`
- `TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7` (compiler-generated name)
- `TMP_SpriteAsset.<>c` (compiler-generated name)
- `TMP_Text.<>c` (compiler-generated name)
- `TMP_Text.CharacterSubstitution`
- `TMP_Text.MissingCharacterEventCallback`
- `TMP_Text.SpecialCharacter`
- `TMP_Text.TextBackingContainer`
- `TMP_Text.TextInputSources`
- `TMP_Text.TextProcessingElement`
- `TMPro.AtlasPopulationMode`
- `TMPro.CaretPosition`
- `TMPro.ColorMode`
- `TMPro.Extents`
- `TMPro.FaceInfo_Legacy`
- `TMPro.FastAction`
- `TMPro.FontAssetCreationSettings`
- `TMPro.FontStyles`
- `TMPro.FontWeight`
- `TMPro.GlyphAnchorPoint`
- `TMPro.GlyphValueRecord_Legacy`
- `TMPro.HighlightState`
- `TMPro.HorizontalAlignmentOptions`
- `TMPro.ITextPreprocessor`
- `TMPro.KerningPair`
- `TMPro.KerningTable`
- `TMPro.LigatureSubstitutionRecord`
- `TMPro.MarkPositionAdjustment`
- `TMPro.MarkToBaseAdjustmentRecord`
- `TMPro.MarkToMarkAdjustmentRecord`
- `TMPro.MarkupTag`
- `TMPro.MaskingTypes`
- `TMPro.MaterialReference`
- `TMPro.MaterialReferenceManager`
- `TMPro.MultipleSubstitutionRecord`
- `TMPro.RichTextTagAttribute`
- `TMPro.SetPropertyUtility`
- `TMPro.ShaderUtilities`
- `TMPro.TMP_Asset`
- `TMPro.TMP_Character`
- `TMPro.TMP_CharacterInfo`
- `TMPro.TMP_ColorGradient`
- `TMPro.TMP_Compatibility`
- `TMPro.TMP_FontAsset`
- `TMPro.TMP_FontAssetUtilities`
- `TMPro.TMP_FontFeatureTable`
- `TMPro.TMP_FontStyleStack`
- `TMPro.TMP_FontWeightPair`
- `TMPro.TMP_Glyph`
- `TMPro.TMP_InputField`
- `TMPro.TMP_InputValidator`
- `TMPro.TMP_LineInfo`
- `TMPro.TMP_LinkInfo`
- `TMPro.TMP_MaterialManager`
- `TMPro.TMP_MeshInfo`
- `TMPro.TMP_Offset`
- `TMPro.TMP_PageInfo`
- `TMPro.TMP_ScrollbarEventHandler`
- `TMPro.TMP_SelectionCaret`
- `TMPro.TMP_Settings`
- `TMPro.TMP_Sprite`
- `TMPro.TMP_SpriteAnimator`
- `TMPro.TMP_SpriteAsset`
- `TMPro.TMP_SpriteCharacter`
- `TMPro.TMP_SpriteGlyph`
- `TMPro.TMP_Style`
- `TMPro.TMP_StyleSheet`
- `TMPro.TMP_SubMesh`
- `TMPro.TMP_SubMeshUI`
- `TMPro.TMP_Text`
- `TMPro.TMP_TextElement`
- `TMPro.TMP_TextElementType`
- `TMPro.TMP_TextElement_Legacy`
- `TMPro.TMP_TextInfo`
- `TMPro.TMP_UpdateManager`
- `TMPro.TMP_Vertex`
- `TMPro.TMP_VertexDataUpdateFlags`
- `TMPro.TMP_WordInfo`
- `TMPro.TMPro_EventManager`
- `TMPro.TMPro_ExtensionMethods`
- `TMPro.TagUnitType`
- `TMPro.TagValueType`
- `TMPro.TextAlignmentOptions`
- `TMPro.TextContainer`
- `TMPro.TextContainerAnchors`
- `TMPro.TextElementType`
- `TMPro.TextMeshPro`
- `TMPro.TextMeshProUGUI`
- `TMPro.TextOverflowModes`
- `TMPro.TextProcessingElementType`
- `TMPro.TextRenderFlags`
- `TMPro.TextWrappingModes`
- `TMPro.TextureMappingOptions`
- `TMPro.VertexGradient`
- `TMPro.VertexSortingOrder`
- `TMPro.VerticalAlignmentOptions`
- `TMPro.WordWrapState`
- `TextMeshProUGUI.<DelayedGraphicRebuild>d__18` (compiler-generated name)
- `TextMeshProUGUI.<DelayedMaterialRebuild>d__19` (compiler-generated name)
- `UnityEngine.TextCore.OTL_FeatureTag`

</details>

<details><summary>Mismatching: 6</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB'] → ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB', '50D8F9B758CA049E70E848EB6297B10698B9DFE1BC09A250619124C983CAC0E8', 'CE288FEE87FD0C469553BE04A1827FA38389051875CAC152A072634634D7D780']`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3772 50D8F9B758CA049E70E848EB6297B10698B9DFE1BC09A250619124C983CAC0E8`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4040 CE288FEE87FD0C469553BE04A1827FA38389051875CAC152A072634634D7D780`

- `TMPro.Compute_DT_EventArgs`

  - `field declaration order/names: [] → ['EventType', 'ProgressPercentage', 'Colors']`
  - `extra field instance Compute_DistanceTransform_EventTypes EventType`
  - `extra field instance float ProgressPercentage`
  - `extra field instance Color[] Colors`

- `TMPro.TMP_Math`

  - `field declaration order/names: ['MAX_16BIT', 'MIN_16BIT'] → ['FLOAT_MAX', 'FLOAT_MIN', 'INT_MAX', 'INT_MIN', 'FLOAT_UNSET', 'INT_UNSET', 'MAX_16BIT', 'MIN_16BIT']`
  - `extra field constant float FLOAT_MAX`
  - `extra field constant float FLOAT_MIN`
  - `extra field constant int INT_MAX`
  - `extra field constant int INT_MIN`
  - `extra field constant float FLOAT_UNSET`
  - `extra field constant int INT_UNSET`

- `TMPro.TMP_ResourceManager`

  - `field declaration order/names: ['s_FontAssetReferences', 's_FontAssetNameReferenceLookup', 's_FontAssetFamilyNameAndStyleReferenceLookup', 's_FontAssetRemovalList', 'k_RegularStyleHashCode'] → ['s_TextSettings', 's_FontAssetReferences', 's_FontAssetNameReferenceLookup', 's_FontAssetFamilyNameAndStyleReferenceLookup', 's_FontAssetRemovalList', 'k_RegularStyleHashCode']`
  - `s_FontAssetReferences: offset '0x0' → '0x8'`
  - `s_FontAssetNameReferenceLookup: offset '0x8' → '0x10'`
  - `s_FontAssetFamilyNameAndStyleReferenceLookup: offset '0x10' → '0x18'`
  - `s_FontAssetRemovalList: offset '0x18' → '0x20'`
  - `k_RegularStyleHashCode: offset '0x20' → '0x28'`
  - `extra field static TMP_Settings s_TextSettings`

- `TMPro.TMP_TextParsingUtilities`

  - `field declaration order/names: ['s_Instance', 'k_EmojiLookup', 'k_EmojiPresentationFormLookup'] → ['s_Instance', 'k_LookupStringL', 'k_LookupStringU', 'k_EmojiLookup', 'k_EmojiPresentationFormLookup']`
  - `extra field constant string k_LookupStringL`
  - `extra field constant string k_LookupStringU`

- `TMPro.TMP_TextUtilities`

  - `field declaration order/names: ['m_rectWorldCorners'] → ['m_rectWorldCorners', 'k_lookupStringL', 'k_lookupStringU']`
  - `extra field constant string k_lookupStringL`
  - `extra field constant string k_lookupStringU`


</details>

<details><summary>Indeterminate: 7</summary>

- `TMP_ListPool.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.FastAction<A, B, C>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.FastAction<A, B>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.FastAction<A>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.TMP_ListPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.TMP_ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TMPro.TMP_TextProcessingStack<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 61</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3772`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4040`
- `ColorTween.ColorTweenCallback`
- `ColorTween.ColorTweenMode`
- `FloatTween.FloatTweenCallback`
- `KerningTable.<>c` (compiler-generated name)
- `KerningTable.<>c__DisplayClass3_0` (compiler-generated name)
- `KerningTable.<>c__DisplayClass4_0` (compiler-generated name)
- `KerningTable.<>c__DisplayClass5_0` (compiler-generated name)
- `TMP_Compatibility.AnchorPositions`
- `TMP_DefaultControls.Resources`
- `TMP_Dropdown.<>c__DisplayClass76_0` (compiler-generated name)
- `TMP_Dropdown.<>c__DisplayClass76_1` (compiler-generated name)
- `TMP_Dropdown.<DelayedDestroyDropdownList>d__90` (compiler-generated name)
- `TMP_Dropdown.DropdownEvent`
- `TMP_Dropdown.DropdownItem`
- `TMP_Dropdown.OptionData`
- `TMP_Dropdown.OptionDataList`
- `TMP_DynamicFontAssetUtilities.FontReference`
- `TMP_MaterialManager.<>c__DisplayClass9_0` (compiler-generated name)
- `TMP_TextUtilities.LineSegment`
- `TMPro.AlternateSubstitutionRecord`
- `TMPro.CaretInfo`
- `TMPro.CharacterElement`
- `TMPro.CodePoint`
- `TMPro.ColorTween`
- `TMPro.Compute_DistanceTransform_EventTypes`
- `TMPro.FloatTween`
- `TMPro.FontFeatureLookupFlags`
- `TMPro.GlyphPairKey`
- `TMPro.ITextElement`
- `TMPro.ITweenValue`
- `TMPro.KerningPairKey`
- `TMPro.MarkupAttribute`
- `TMPro.MarkupElement`
- `TMPro.MaskingOffsetMode`
- `TMPro.Mesh_Extents`
- `TMPro.SingleSubstitutionRecord`
- `TMPro.SpriteAssetUtilities.SpriteAssetImportFormats`
- `TMPro.SpriteAssetUtilities.TexturePacker_JsonArray`
- `TMPro.TMP_DefaultControls`
- `TMPro.TMP_Dropdown`
- `TMPro.TMP_DynamicFontAssetUtilities`
- `TMPro.TMP_FontUtilities`
- `TMPro.TMP_GlyphAdjustmentRecord`
- `TMPro.TMP_GlyphPairAdjustmentRecord`
- `TMPro.TMP_GlyphValueRecord`
- `TMPro.TMP_MaterialReference`
- `TMPro.TMP_SpriteInfo`
- `TMPro.TMP_UpdateRegistry`
- `TMPro.TagAttribute`
- `TMPro.TextProcessingElement`
- `TMPro.TweenRunner<T>`
- `TexturePacker_JsonArray.Frame`
- `TexturePacker_JsonArray.Meta`
- `TexturePacker_JsonArray.SpriteDataObject`
- `TexturePacker_JsonArray.SpriteFrame`
- `TexturePacker_JsonArray.SpriteSize`
- `TweenRunner.<Start>d__2<T>` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.Timeline.dll

<details><summary>Matching: 102</summary>

- `<Module>`
- `ActivationControlPlayable.InitialState`
- `ActivationControlPlayable.PostPlaybackState`
- `ActivationTrack.PostPlaybackState`
- `AnimationOutputWeightProcessor.WeightInfo`
- `AnimationPlayableAsset.<get_outputs>d__45` (compiler-generated name)
- `AnimationPlayableAsset.AnimationPlayableAssetUpgrade`
- `AnimationPlayableAsset.LoopMode`
- `AnimationTrack.<get_outputs>d__49` (compiler-generated name)
- `AnimationTrack.AnimationTrackUpgrade`
- `AudioPlayableAsset.<get_outputs>d__16` (compiler-generated name)
- `AudioTrack.<get_outputs>d__4` (compiler-generated name)
- `BlendUtility.<>c` (compiler-generated name)
- `ControlPlayableAsset.<GetControlableScripts>d__40` (compiler-generated name)
- `DirectorControlPlayable.PauseAction`
- `Extrapolation.<>c` (compiler-generated name)
- `TimeFieldAttribute.UseEditMode`
- `TimeNotificationBehaviour.<>c` (compiler-generated name)
- `TimeNotificationBehaviour.NotificationEntry`
- `TimelineAsset.<get_outputs>d__27` (compiler-generated name)
- `TimelineAsset.DurationMode`
- `TimelineAsset.EditorSettings`
- `TimelineClip.BlendCurveMode`
- `TimelineClip.ClipExtrapolation`
- `TimelineClip.TimelineClipUpgrade`
- `TimelineCreateUtilities.<>c__DisplayClass0_0` (compiler-generated name)
- `TimelineCreateUtilities.<>c__DisplayClass0_1` (compiler-generated name)
- `TimelinePlayable.TrackCacheManager`
- `Titan.TitanTrackBase`
- `TrackAsset.<>c` (compiler-generated name)
- `TrackAsset.<get_outputs>d__69` (compiler-generated name)
- `TrackAsset.TransientBuildData`
- `UnityEngine.Timeline.ActivationControlPlayable`
- `UnityEngine.Timeline.ActivationMixerPlayable`
- `UnityEngine.Timeline.ActivationPlayableAsset`
- `UnityEngine.Timeline.ActivationTrack`
- `UnityEngine.Timeline.AnimationOutputWeightProcessor`
- `UnityEngine.Timeline.AnimationPlayableAsset`
- `UnityEngine.Timeline.AnimationTrack`
- `UnityEngine.Timeline.AppliedOffsetMode`
- `UnityEngine.Timeline.AudioClipProperties`
- `UnityEngine.Timeline.AudioMixerProperties`
- `UnityEngine.Timeline.AudioPlayableAsset`
- `UnityEngine.Timeline.AudioTrack`
- `UnityEngine.Timeline.BlendUtility`
- `UnityEngine.Timeline.ClipCaps`
- `UnityEngine.Timeline.ControlPlayableAsset`
- `UnityEngine.Timeline.ControlTrack`
- `UnityEngine.Timeline.CurveEditUtility`
- `UnityEngine.Timeline.CustomStyleAttribute`
- `UnityEngine.Timeline.DirectorControlPlayable`
- `UnityEngine.Timeline.DiscreteTime`
- `UnityEngine.Timeline.Extrapolation`
- `UnityEngine.Timeline.FrameRateFieldAttribute`
- `UnityEngine.Timeline.GroupTrack`
- `UnityEngine.Timeline.HashUtility`
- `UnityEngine.Timeline.HideInMenuAttribute`
- `UnityEngine.Timeline.ICurvesOwner`
- `UnityEngine.Timeline.IInterval`
- `UnityEngine.Timeline.ILayerable`
- `UnityEngine.Timeline.IMarker`
- `UnityEngine.Timeline.INotificationOptionProvider`
- `UnityEngine.Timeline.IPropertyCollector`
- `UnityEngine.Timeline.IPropertyPreview`
- `UnityEngine.Timeline.ITimeControl`
- `UnityEngine.Timeline.ITimelineClipAsset`
- `UnityEngine.Timeline.ITimelineEvaluateCallback`
- `UnityEngine.Timeline.IgnoreOnPlayableTrackAttribute`
- `UnityEngine.Timeline.InfiniteRuntimeClip`
- `UnityEngine.Timeline.IntervalTreeNode`
- `UnityEngine.Timeline.Marker`
- `UnityEngine.Timeline.MarkerList`
- `UnityEngine.Timeline.MarkerTrack`
- `UnityEngine.Timeline.MatchTargetFields`
- `UnityEngine.Timeline.NotKeyableAttribute`
- `UnityEngine.Timeline.NotificationFlags`
- `UnityEngine.Timeline.NotificationUtilities`
- `UnityEngine.Timeline.PlayableTrack`
- `UnityEngine.Timeline.PrefabControlPlayable`
- `UnityEngine.Timeline.RuntimeClip`
- `UnityEngine.Timeline.RuntimeClipBase`
- `UnityEngine.Timeline.RuntimeElement`
- `UnityEngine.Timeline.ScheduleRuntimeClip`
- `UnityEngine.Timeline.SupportsChildTracksAttribute`
- `UnityEngine.Timeline.TimeControlPlayable`
- `UnityEngine.Timeline.TimeFieldAttribute`
- `UnityEngine.Timeline.TimeNotificationBehaviour`
- `UnityEngine.Timeline.TimeUtility`
- `UnityEngine.Timeline.TimelineAsset`
- `UnityEngine.Timeline.TimelineClip`
- `UnityEngine.Timeline.TimelineClipCapsExtensions`
- `UnityEngine.Timeline.TimelineCreateUtilities`
- `UnityEngine.Timeline.TimelinePlayable`
- `UnityEngine.Timeline.TimelineUndo`
- `UnityEngine.Timeline.TrackAsset`
- `UnityEngine.Timeline.TrackAssetExtensions`
- `UnityEngine.Timeline.TrackBindingFlags`
- `UnityEngine.Timeline.TrackBindingTypeAttribute`
- `UnityEngine.Timeline.TrackClipTypeAttribute`
- `UnityEngine.Timeline.TrackColorAttribute`
- `UnityEngine.Timeline.TrackOffset`
- `UnityEngine.Timeline.WeightUtility`

</details>

<details><summary>Mismatching: 2</summary>

- `UnityEngine.Timeline.IntervalTree<T>`

  - `field declaration order/names: ['m_Entries', 'm_Nodes', '<dirty>k__BackingField'] → ['kMinNodeSize', 'kInvalidNode', 'kCenterUnknown', 'm_Entries', 'm_Nodes', '<dirty>k__BackingField']`
  - `extra field constant int kMinNodeSize`
  - `extra field constant int kInvalidNode`
  - `extra field constant long kCenterUnknown`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Timeline.ParticleControlPlayable`

  - `field declaration order/names: ['m_LastPlayableTime', 'm_LastParticleTime', 'm_RandomSeed', '<particleSystem>k__BackingField'] → ['kUnsetTime', 'm_LastPlayableTime', 'm_LastParticleTime', 'm_RandomSeed', '<particleSystem>k__BackingField']`
  - `extra field constant float kUnsetTime`


</details>

<details><summary>Indeterminate: 1</summary>

- `IntervalTree.Entry<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 30</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4568`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5398`
- `AnimationPlayableAsset.Versions`
- `SignalReceiver.EventKeyValue`
- `TimeUtility.<>c` (compiler-generated name)
- `TimelineAsset.MediaType`
- `TimelineAsset.TimelineAssetUpgrade`
- `TimelineAsset.Versions`
- `TimelineClip.Versions`
- `TrackAsset.TrackAssetUpgrade`
- `TrackAsset.Versions`
- `UnityEngine.Timeline.AnimationPreviewUpdateCallback`
- `UnityEngine.Timeline.BasicPlayableBehaviour`
- `UnityEngine.Timeline.CustomSignalEventDrawer`
- `UnityEngine.Timeline.EntityId`
- `UnityEngine.Timeline.MatchTargetFieldConstants`
- `UnityEngine.Timeline.MenuCategoryAttribute`
- `UnityEngine.Timeline.ObjectId`
- `UnityEngine.Timeline.SelectionExtensions`
- `UnityEngine.Timeline.SignalAsset`
- `UnityEngine.Timeline.SignalEmitter`
- `UnityEngine.Timeline.SignalReceiver`
- `UnityEngine.Timeline.SignalTrack`
- `UnityEngine.Timeline.StandardFrameRates`
- `UnityEngine.Timeline.TimelineClipExtensions`
- `UnityEngine.Timeline.TimelineHelpURLAttribute`
- `UnityEngine.Timeline.TrackMediaType`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.VisualEffectGraph.Runtime.dll

<details><summary>Matching: 24</summary>

- `<Module>`
- `UnityEngine.VFX.EventAttribute`
- `UnityEngine.VFX.EventAttributes`
- `UnityEngine.VFX.PlayableTimeSpace`
- `UnityEngine.VFX.Utility.ExposedProperty`
- `UnityEngine.VFX.VFXRuntimeResources`
- `UnityEngine.VFX.VFXTimeSpaceHelper`
- `UnityEngine.VFX.VisualEffectControlClip`
- `UnityEngine.VFX.VisualEffectControlPlayableBehaviour`
- `UnityEngine.VFX.VisualEffectControlTrack`
- `UnityEngine.VFX.VisualEffectControlTrackMixerBehaviour`
- `UnityEngine.VFX.VisualEffectPlayableSerializedEvent`
- `UnityEngine.VFX.VisualEffectPlayableSerializedEventNoColor`
- `VFXTimeSpaceHelper.<GetEventNormalizedSpace>d__3` (compiler-generated name)
- `VisualEffectControlClip.ClipEvent`
- `VisualEffectControlClip.PrewarmClipSettings`
- `VisualEffectControlClip.ReinitMode`
- `VisualEffectControlTrack.<>c` (compiler-generated name)
- `VisualEffectControlTrack.ReinitMode`
- `VisualEffectControlTrackController.Chunk`
- `VisualEffectControlTrackController.Clip`
- `VisualEffectControlTrackController.Event`
- `VisualEffectControlTrackController.Event.ClipType`
- `VisualEffectControlTrackController.VisualEffectControlPlayableBehaviourComparer`

</details>

<details><summary>Mismatching: 2</summary>

- `UnityEngine.VFX.VisualEffectControlTrackController`

  - `field declaration order/names: ['m_LastChunk', 'm_LastEvent', 'm_LastPlayableTime', 'm_EventListIndexCache', 'm_Target', 'm_BackupReseedOnPlay', 'm_BackupStartSeed', 'm_Chunks'] → ['kErrorIndex', 'm_LastChunk', 'm_LastEvent', 'm_LastPlayableTime', 'm_EventListIndexCache', 'm_Target', 'm_BackupReseedOnPlay', 'm_BackupStartSeed', 'm_Chunks', 'kEpsilonEvent']`
  - `extra field constant int kErrorIndex`
  - `extra field static double kEpsilonEvent`

- `VisualEffectControlTrackController.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__23_1', '<>9__23_2', '<>9__23_0'] → ['<>9', '<>9__24_1', '<>9__24_0']`
  - `missing field static Func<VisualEffectControlTrackController.Event, int, <>f__AnonymousType0<VisualEffectControlTrackController.Event, int>> <>9__23_1`
  - `missing field static Func<<>f__AnonymousType0<VisualEffectControlTrackController.Event, int>, double> <>9__23_2`
  - `missing field static Func<VisualEffectControlTrackController.Event, double> <>9__23_0`
  - `extra field static Comparison<ValueTuple<VisualEffectControlTrackController.Event, int>> <>9__24_1`
  - `extra field static Comparison<VisualEffectControlTrackController.Event> <>9__24_0`


</details>

<details><summary>Missing: 3</summary>

- `<>f__AnonymousType0<<evt>j__TPar, <sourceIndex>j__TPar>` (compiler-generated name)
- `VisualEffectControlTrackController.<>c__DisplayClass19_0` (compiler-generated name)
- `VisualEffectControlTrackController.<ComputeRuntimeEvent>d__20` (compiler-generated name)

</details>

<details><summary>Extra: 81</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3566`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5143`
- `EventAttributeBool.<>c` (compiler-generated name)
- `EventAttributeFloat.<>c` (compiler-generated name)
- `EventAttributeInt.<>c` (compiler-generated name)
- `EventAttributeUInt.<>c` (compiler-generated name)
- `EventAttributeVector2.<>c` (compiler-generated name)
- `EventAttributeVector3.<>c` (compiler-generated name)
- `EventAttributeVector4.<>c` (compiler-generated name)
- `IncrementStripIndexOnStart.InputProperties`
- `LoopAndDelay.InputProperties`
- `MeshToSDFBaker.Kernels`
- `MeshToSDFBaker.ShaderProperties`
- `SpawnOverDistance.InputProperties`
- `UnityEngine.VFX.EventAttributeBool`
- `UnityEngine.VFX.EventAttributeColor`
- `UnityEngine.VFX.EventAttributeFloat`
- `UnityEngine.VFX.EventAttributeInt`
- `UnityEngine.VFX.EventAttributeUInt`
- `UnityEngine.VFX.EventAttributeValue<T>`
- `UnityEngine.VFX.EventAttributeVector2`
- `UnityEngine.VFX.EventAttributeVector3`
- `UnityEngine.VFX.EventAttributeVector4`
- `UnityEngine.VFX.IncrementStripIndexOnStart`
- `UnityEngine.VFX.LoopAndDelay`
- `UnityEngine.VFX.SDF.MeshToSDFBaker`
- `UnityEngine.VFX.SetSpawnTime`
- `UnityEngine.VFX.SpawnOverDistance`
- `UnityEngine.VFX.Utility.VFXAudioSpectrumBinder`
- `UnityEngine.VFX.Utility.VFXBinderAttribute`
- `UnityEngine.VFX.Utility.VFXBinderBase`
- `UnityEngine.VFX.Utility.VFXEnabledBinder`
- `UnityEngine.VFX.Utility.VFXEventBinderBase`
- `UnityEngine.VFX.Utility.VFXHierarchyAttributeMapBinder`
- `UnityEngine.VFX.Utility.VFXInputAxisBinder`
- `UnityEngine.VFX.Utility.VFXInputButtonBinder`
- `UnityEngine.VFX.Utility.VFXInputKeyBinder`
- `UnityEngine.VFX.Utility.VFXInputMouseBinder`
- `UnityEngine.VFX.Utility.VFXInputTouchBinder`
- `UnityEngine.VFX.Utility.VFXLightBinder`
- `UnityEngine.VFX.Utility.VFXMouseEventBinder`
- `UnityEngine.VFX.Utility.VFXMultiplePositionBinder`
- `UnityEngine.VFX.Utility.VFXOutputEventAbstractHandler`
- `UnityEngine.VFX.Utility.VFXPlaneBinder`
- `UnityEngine.VFX.Utility.VFXPositionBinder`
- `UnityEngine.VFX.Utility.VFXPreviousPositionBinder`
- `UnityEngine.VFX.Utility.VFXPropertyBinder`
- `UnityEngine.VFX.Utility.VFXPropertyBindingAttribute`
- `UnityEngine.VFX.Utility.VFXRaycastBinder`
- `UnityEngine.VFX.Utility.VFXRigidBodyCollisionEventBinder`
- `UnityEngine.VFX.Utility.VFXSpaceableBinder`
- `UnityEngine.VFX.Utility.VFXSphereBinder`
- `UnityEngine.VFX.Utility.VFXTerrainBinder`
- `UnityEngine.VFX.Utility.VFXTransformBinder`
- `UnityEngine.VFX.Utility.VFXTriggerEventBinder`
- `UnityEngine.VFX.Utility.VFXUIDropdownBinder`
- `UnityEngine.VFX.Utility.VFXUISliderBinder`
- `UnityEngine.VFX.Utility.VFXUIToggleBinder`
- `UnityEngine.VFX.Utility.VFXVelocityBinder`
- `UnityEngine.VFX.Utility.VFXVisibilityEventBinder`
- `UnityEngine.VFX.VFXTypeAttribute`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `VFXAudioSpectrumBinder.AudioSourceMode`
- `VFXEnabledBinder.Check`
- `VFXHierarchyAttributeMapBinder.Bone`
- `VFXHierarchyAttributeMapBinder.RadiusMode`
- `VFXMouseEventBinder.Activation`
- `VFXPropertyBinder.<GetPropertyBinders>d__17<T>` (compiler-generated name)
- `VFXRaycastBinder.Space`
- `VFXSpaceableBinder.BinderSpace`
- `VFXTimeSpaceHelper.<CollectClipEvents>d__1` (compiler-generated name)
- `VFXTriggerEventBinder.Activation`
- `VFXTypeAttribute.Usage`
- `VFXVisibilityEventBinder.Activation`
- `VisualEffectActivationBehaviour`
- `VisualEffectActivationBehaviour.AttributeType`
- `VisualEffectActivationBehaviour.EventState`
- `VisualEffectActivationClip`
- `VisualEffectControlTrackController.<ComputeRuntimeEvent>d__21` (compiler-generated name)

</details>


## UnityEngine.UI.dll

<details><summary>Matching: 183</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `AspectRatioFitter.AspectMode`
- `Button.<OnFinishSubmit>d__9` (compiler-generated name)
- `Button.ButtonClickedEvent`
- `CanvasScaler.ScaleMode`
- `CanvasScaler.ScreenMatchMode`
- `CanvasScaler.Unit`
- `CanvasUpdateRegistry.GraphicSortComparer`
- `ColorTween.ColorTweenCallback`
- `ColorTween.ColorTweenMode`
- `ContentSizeFitter.FitMode`
- `Dropdown.<>c__DisplayClass63_0` (compiler-generated name)
- `Dropdown.<DelayedDestroyDropdownList>d__75` (compiler-generated name)
- `Dropdown.DropdownEvent`
- `Dropdown.DropdownItem`
- `Dropdown.OptionData`
- `Dropdown.OptionDataList`
- `EventSystem.<>c__DisplayClass56_0` (compiler-generated name)
- `EventSystem.UIToolkitOverrideConfig`
- `EventTrigger.Entry`
- `EventTrigger.TriggerEvent`
- `ExecuteEvents.EventFunction<T1>`
- `FloatTween.FloatTweenCallback`
- `GraphicRaycaster.<>c` (compiler-generated name)
- `GraphicRaycaster.BlockingObjects`
- `GridLayoutGroup.Axis`
- `GridLayoutGroup.Constraint`
- `GridLayoutGroup.Corner`
- `Image.FillMethod`
- `Image.Type`
- `InputField.<CaretBlink>d__172` (compiler-generated name)
- `InputField.<MouseDragOutsideRect>d__196` (compiler-generated name)
- `InputField.CharacterValidation`
- `InputField.ContentType`
- `InputField.EditState`
- `InputField.EndEditEvent`
- `InputField.InputType`
- `InputField.LineType`
- `InputField.OnChangeEvent`
- `InputField.OnValidateInput`
- `InputField.SubmitEvent`
- `LayoutGroup.<DelayedSetDirty>d__56` (compiler-generated name)
- `LayoutRebuilder.<>c` (compiler-generated name)
- `LayoutUtility.<>c` (compiler-generated name)
- `MaskableGraphic.CullStateChangedEvent`
- `Navigation.Mode`
- `PanelEventHandler.PointerEvent`
- `PanelEventHandler.PointerEventType`
- `PhysicsRaycaster.RaycastHitComparer`
- `PointerEventData.FramePressState`
- `PointerEventData.InputButton`
- `PointerInputModule.ButtonState`
- `PointerInputModule.MouseButtonEventData`
- `PointerInputModule.MouseState`
- `ReflectionMethodsCache.GetRayIntersectionAllCallback`
- `ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback`
- `ReflectionMethodsCache.GetRaycastNonAllocCallback`
- `ReflectionMethodsCache.Raycast2DCallback`
- `ReflectionMethodsCache.Raycast3DCallback`
- `ReflectionMethodsCache.RaycastAllCallback`
- `ScrollRect.MovementType`
- `ScrollRect.ScrollRectEvent`
- `ScrollRect.ScrollbarVisibility`
- `Scrollbar.<ClickRepeat>d__59` (compiler-generated name)
- `Scrollbar.Axis`
- `Scrollbar.Direction`
- `Scrollbar.ScrollEvent`
- `Selectable.SelectionState`
- `Selectable.Transition`
- `Slider.Axis`
- `Slider.Direction`
- `Slider.SliderEvent`
- `StandaloneInputModule.InputMode`
- `StencilMaterial.MatEntry`
- `Toggle.ToggleEvent`
- `Toggle.ToggleTransition`
- `ToggleGroup.<>c` (compiler-generated name)
- `UnityEngine.EventSystems.AbstractEventData`
- `UnityEngine.EventSystems.AxisEventData`
- `UnityEngine.EventSystems.BaseEventData`
- `UnityEngine.EventSystems.BaseInput`
- `UnityEngine.EventSystems.BaseInputModule`
- `UnityEngine.EventSystems.BaseRaycaster`
- `UnityEngine.EventSystems.EventSystem`
- `UnityEngine.EventSystems.EventTrigger`
- `UnityEngine.EventSystems.EventTriggerType`
- `UnityEngine.EventSystems.ExecuteEvents`
- `UnityEngine.EventSystems.IBeginDragHandler`
- `UnityEngine.EventSystems.ICancelHandler`
- `UnityEngine.EventSystems.IDeselectHandler`
- `UnityEngine.EventSystems.IDragHandler`
- `UnityEngine.EventSystems.IDropHandler`
- `UnityEngine.EventSystems.IEndDragHandler`
- `UnityEngine.EventSystems.IEventSystemHandler`
- `UnityEngine.EventSystems.IInitializePotentialDragHandler`
- `UnityEngine.EventSystems.IMoveHandler`
- `UnityEngine.EventSystems.IPointerClickHandler`
- `UnityEngine.EventSystems.IPointerDownHandler`
- `UnityEngine.EventSystems.IPointerEnterHandler`
- `UnityEngine.EventSystems.IPointerExitHandler`
- `UnityEngine.EventSystems.IPointerMoveHandler`
- `UnityEngine.EventSystems.IPointerUpHandler`
- `UnityEngine.EventSystems.IScrollHandler`
- `UnityEngine.EventSystems.ISelectHandler`
- `UnityEngine.EventSystems.ISubmitHandler`
- `UnityEngine.EventSystems.IUpdateSelectedHandler`
- `UnityEngine.EventSystems.MoveDirection`
- `UnityEngine.EventSystems.Physics2DRaycaster`
- `UnityEngine.EventSystems.PhysicsRaycaster`
- `UnityEngine.EventSystems.PointerEventData`
- `UnityEngine.EventSystems.PointerInputModule`
- `UnityEngine.EventSystems.RaycastResult`
- `UnityEngine.EventSystems.RaycasterManager`
- `UnityEngine.EventSystems.StandaloneInputModule`
- `UnityEngine.EventSystems.TouchInputModule`
- `UnityEngine.EventSystems.UIBehaviour`
- `UnityEngine.UI.AnimationTriggers`
- `UnityEngine.UI.AspectRatioFitter`
- `UnityEngine.UI.BaseMeshEffect`
- `UnityEngine.UI.Button`
- `UnityEngine.UI.CanvasScaler`
- `UnityEngine.UI.CanvasUpdate`
- `UnityEngine.UI.ClipperRegistry`
- `UnityEngine.UI.Clipping`
- `UnityEngine.UI.ColorBlock`
- `UnityEngine.UI.ContentSizeFitter`
- `UnityEngine.UI.CoroutineTween.ColorTween`
- `UnityEngine.UI.CoroutineTween.FloatTween`
- `UnityEngine.UI.CoroutineTween.ITweenValue`
- `UnityEngine.UI.Dropdown`
- `UnityEngine.UI.FontData`
- `UnityEngine.UI.FontUpdateTracker`
- `UnityEngine.UI.Graphic`
- `UnityEngine.UI.GraphicRaycaster`
- `UnityEngine.UI.GraphicRegistry`
- `UnityEngine.UI.GridLayoutGroup`
- `UnityEngine.UI.HorizontalLayoutGroup`
- `UnityEngine.UI.HorizontalOrVerticalLayoutGroup`
- `UnityEngine.UI.ICanvasElement`
- `UnityEngine.UI.IClippable`
- `UnityEngine.UI.IClipper`
- `UnityEngine.UI.ILayoutController`
- `UnityEngine.UI.ILayoutElement`
- `UnityEngine.UI.ILayoutGroup`
- `UnityEngine.UI.ILayoutIgnorer`
- `UnityEngine.UI.ILayoutSelfController`
- `UnityEngine.UI.IMaskable`
- `UnityEngine.UI.IMaterialModifier`
- `UnityEngine.UI.IMeshModifier`
- `UnityEngine.UI.Image`
- `UnityEngine.UI.InputField`
- `UnityEngine.UI.LayoutElement`
- `UnityEngine.UI.LayoutGroup`
- `UnityEngine.UI.LayoutRebuilder`
- `UnityEngine.UI.LayoutUtility`
- `UnityEngine.UI.Mask`
- `UnityEngine.UI.MaskUtilities`
- `UnityEngine.UI.MaskableGraphic`
- `UnityEngine.UI.Misc`
- `UnityEngine.UI.MultipleDisplayUtilities`
- `UnityEngine.UI.Navigation`
- `UnityEngine.UI.Outline`
- `UnityEngine.UI.PositionAsUV1`
- `UnityEngine.UI.RawImage`
- `UnityEngine.UI.RectMask2D`
- `UnityEngine.UI.RectangularVertexClipper`
- `UnityEngine.UI.ReflectionMethodsCache`
- `UnityEngine.UI.ScrollRect`
- `UnityEngine.UI.Scrollbar`
- `UnityEngine.UI.Selectable`
- `UnityEngine.UI.SetPropertyUtility`
- `UnityEngine.UI.Shadow`
- `UnityEngine.UI.Slider`
- `UnityEngine.UI.SpriteState`
- `UnityEngine.UI.StencilMaterial`
- `UnityEngine.UI.Text`
- `UnityEngine.UI.Toggle`
- `UnityEngine.UI.ToggleGroup`
- `UnityEngine.UI.VertexHelper`
- `UnityEngine.UI.VerticalLayoutGroup`
- `UnityEngine.UIElements.PanelEventHandler`
- `UnityEngine.UIElements.PanelRaycaster`

</details>

<details><summary>Mismatching: 2</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB'] → ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB', '343486C59ECCEFEE9E92958A5520FEE462BD446416EB23B45CB5B67DA63545C8', 'D9E3E08208C634069F0CA9F66EEA4A6536A26D3350D1A938617376F7CE8C3C34']`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5699 343486C59ECCEFEE9E92958A5520FEE462BD446416EB23B45CB5B67DA63545C8`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6406 D9E3E08208C634069F0CA9F66EEA4A6536A26D3350D1A938617376F7CE8C3C34`

- `UnityEngine.UI.CanvasUpdateRegistry`

  - `field declaration order/names: ['s_Instance', 'm_PerformingLayoutUpdate', 'm_PerformingGraphicUpdate', 'm_CanvasUpdateProfilerStrings', 'm_LayoutRebuildQueue', 'm_GraphicRebuildQueue', 'onLayoutComplete', 's_SortLayoutFunction', 's_SortGraphicComparer'] → ['s_Instance', 'm_PerformingLayoutUpdate', 'm_PerformingGraphicUpdate', 'm_CanvasUpdateProfilerStrings', 'm_CullingUpdateProfilerString', 'm_LayoutRebuildQueue', 'm_GraphicRebuildQueue', 'onLayoutComplete', 's_SortLayoutFunction', 's_SortGraphicComparer']`
  - `extra field constant string m_CullingUpdateProfilerString`


</details>

<details><summary>Indeterminate: 3</summary>

- `TweenRunner.<Start>d__2<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UI.Collections.IndexedSet<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UI.CoroutineTween.TweenRunner<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 20</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5699`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6406`
- `DefaultControls.DefaultRuntimeFactory`
- `DefaultControls.IFactoryControls`
- `DefaultControls.Resources`
- `Image.Origin180`
- `Image.Origin360`
- `Image.Origin90`
- `Image.OriginHorizontal`
- `Image.OriginVertical`
- `UnityEditor.Rendering.BuiltIn.ShaderGraph.MaterialAccess`
- `UnityEditor.Rendering.Universal.MaterialAccess`
- `UnityEngine.EventSystems.EventHandle`
- `UnityEngine.UI.BaseVertexEffect`
- `UnityEngine.UI.DefaultControls`
- `UnityEngine.UI.IGraphicEnabledDisabled`
- `UnityEngine.UI.IMask`
- `UnityEngine.UI.IVertexModifier`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## campus-submodule.Runtime.dll

<details><summary>Matching: 1088</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=28`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=36`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=40`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5`
- `ABLoopVideoPlayer.<>c__DisplayClass17_0` (compiler-generated name)
- `ABLoopVideoPlayer.<InitializeAsync>d__16` (compiler-generated name)
- `ABLoopVideoPlayer.<LoadResourceAsync>d__17` (compiler-generated name)
- `ABLoopVideoPlayer.<SkipToLoopAsync>d__28` (compiler-generated name)
- `ABLoopVideoPlayer.<SkipToNextMovieAsync>d__30` (compiler-generated name)
- `ABLoopVideoPlayer.<TryInitializeAsync>d__15` (compiler-generated name)
- `ActorAnimation.CampusActorAnimationBuilder`
- `ActorAnimation.CampusActorAnimationFullBodyIKOverrideSettingHolder`
- `ActorAnimation.CampusActorAnimationFullBodyIKPullPart`
- `ActorAnimation.CampusActorAnimationIKLookAtEffector`
- `ActorAnimation.CampusActorAnimationInitializeData`
- `ActorAnimation.CampusActorAnimationJob`
- `ActorAnimation.CampusActorAnimationJointLimit`
- `ActorAnimation.CampusActorAnimationJointLimitUtility`
- `ActorAnimation.CampusActorAnimationLookAtLimit`
- `ActorAnimation.CampusActorAnimationLookAtLimitUtility`
- `ActorAnimation.CampusActorAnimationRig`
- `ActorAnimation.CampusActorAnimationRigData`
- `ActorAnimation.ICampusActorAnimationJointLimit`
- `ActorAnimation.ICampusActorAnimationLookAtLimit`
- `AndroidScreenOrientationController.<SetFixedLandscapeAsync>d__3` (compiler-generated name)
- `AndroidScreenOrientationController.<SetFixedLandscapeLeftAsync>d__4` (compiler-generated name)
- `AndroidScreenOrientationController.<SetFixedPortraitAsync>d__2` (compiler-generated name)
- `AndroidScreenOrientationController.<SetStartsWithLandscapeAsync>d__1` (compiler-generated name)
- `AndroidScreenOrientationController.<SetStartsWithPortraitAsync>d__0` (compiler-generated name)
- `AnimationEventHandler.<>c__DisplayClass12_0` (compiler-generated name)
- `AnimationEventHandler.<>c__DisplayClass14_0` (compiler-generated name)
- `AnimationEventHandler.<>c__DisplayClass21_0` (compiler-generated name)
- `AssetBundleSceneLoader.<>c__DisplayClass14_0` (compiler-generated name)
- `AssetBundleSceneLoader.<>c__DisplayClass18_0` (compiler-generated name)
- `AssetBundleSceneLoader.<>c__DisplayClass19_0` (compiler-generated name)
- `AssetBundleSceneLoader.<LoadAssetBundleAsync>d__14` (compiler-generated name)
- `AssetBundleSceneLoader.<LoadSceneAsync>d__13` (compiler-generated name)
- `AssetBundleSceneLoader.<LoadSceneFromLoadedAssetBundleAsync>d__16` (compiler-generated name)
- `AssetBundleSceneLoader.<UnloadAssetBundleAsync>d__21` (compiler-generated name)
- `AssetBundleSceneLoader.<UnloadSceneAsync>d__18` (compiler-generated name)
- `AssetBundleSceneLoader.<UnloadSceneAsync>d__19` (compiler-generated name)
- `BackgroundBlur.PropertyId`
- `BackgroundBlurExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `BackgroundBlurExtensions.<>c__DisplayClass1_0` (compiler-generated name)
- `BackgroundBlurExtensions.<>c__DisplayClass2_0` (compiler-generated name)
- `BillboardMatricesJobHandler.BillboardMatricesJob`
- `Blendable.Blend`
- `Blendable.PropertyId`
- `ButtonTouchEffect.PropertyId`
- `Campus.AnimationRigging.ActorAnimationAttributeConvertConstraint`
- `Campus.AnimationRigging.ActorAnimationAttributeConvertConstraintBinder`
- `Campus.AnimationRigging.ActorAnimationAttributeConvertConstraintData`
- `Campus.AnimationRigging.ActorAnimationAttributeConvertConstraintJob`
- `Campus.AnimationRigging.ConvertAttribute`
- `Campus.AnimationRigging.ConvertCalcType`
- `Campus.AudiencePenlight.AudiencePenlightComponent`
- `Campus.AudiencePenlight.AudiencePenlightTimeline`
- `Campus.AudiencePenlight.AudiencePenlightTimelineAsset`
- `Campus.AudiencePenlight.AudiencePenlightTimelineBehaviour`
- `Campus.AudiencePenlight.AudiencePenlightTimelineMixerBehaviour`
- `Campus.AudiencePenlight.AudiencePenlightTimelineTrack`
- `Campus.AudiencePenlight.AudiencePenlightVolume`
- `Campus.AudiencePenlight.AudiencePenlightVolumeComponent`
- `Campus.AudiencePenlight.AudiencePenlightVolumeParameter`
- `Campus.AudiencePenlight.DefaultAudiencePenlight`
- `Campus.AudiencePenlight.IAudiencePenlight`
- `Campus.AudiencePenlight.MobAudiencePenlightOverrideAsset`
- `Campus.AudiencePenlight.MobAudiencePenlightOverrideBehaviour`
- `Campus.AudiencePenlight.MobAudiencePenlightOverrideMixerBehaviour`
- `Campus.AudiencePenlight.MobAudiencePenlightOverrideTrack`
- `Campus.Common.ABLoopVideoPlayer`
- `Campus.Common.AndroidScreenOrientationController`
- `Campus.Common.Animation.CustomGraphAnimationPlayer`
- `Campus.Common.AnimationEventHandler`
- `Campus.Common.AssetBundleSceneLoader`
- `Campus.Common.BackgroundBlur`
- `Campus.Common.Blendable`
- `Campus.Common.ButtonTouchEffect`
- `Campus.Common.CampusActorAnimation`
- `Campus.Common.CampusActorAnimationJointLimitSetting`
- `Campus.Common.CampusActorController`
- `Campus.Common.CampusActorControllerUtility`
- `Campus.Common.CampusActorDescriptor`
- `Campus.Common.CampusActorEffectController`
- `Campus.Common.CampusActorEyeHighlight`
- `Campus.Common.CampusActorFaceCorrection`
- `Campus.Common.CampusActorHipCorrector`
- `Campus.Common.CampusActorLayout`
- `Campus.Common.CampusActorLitModel`
- `Campus.Common.CampusActorManager`
- `Campus.Common.CampusActorMaterialEffect`
- `Campus.Common.CampusActorMaterialEffectPlayable`
- `Campus.Common.CampusActorMaterialProperty`
- `Campus.Common.CampusActorModelKeeper`
- `Campus.Common.CampusActorModelParts`
- `Campus.Common.CampusActorRendererFeature`
- `Campus.Common.CampusActorSettings`
- `Campus.Common.CampusActorTalkModel`
- `Campus.Common.CampusButton`
- `Campus.Common.CampusButtonBase`
- `Campus.Common.CampusButtonToggle`
- `Campus.Common.CampusCameraSwitcher`
- `Campus.Common.CampusCanvas`
- `Campus.Common.CampusCanvasScaler`
- `Campus.Common.CampusCinemachineHeightController`
- `Campus.Common.CampusCinemachineRelativeScaleController`
- `Campus.Common.CampusColor`
- `Campus.Common.CampusColorExtensions`
- `Campus.Common.CampusColorManager`
- `Campus.Common.CampusCriActorTalk`
- `Campus.Common.CampusCriActorTalkFFT`
- `Campus.Common.CampusCustomLookAtEffector`
- `Campus.Common.CampusCustomLookAtEffectorPoseSetting`
- `Campus.Common.CampusCustomLookAtEyeCorrectionType`
- `Campus.Common.CampusFontOutlineSetting`
- `Campus.Common.CampusGlass`
- `Campus.Common.CampusGlassType`
- `Campus.Common.CampusGraphicRaycaster`
- `Campus.Common.CampusGyroController`
- `Campus.Common.CampusHomeSceneLayout`
- `Campus.Common.CampusLightAnchor`
- `Campus.Common.CampusLightAnchorBase`
- `Campus.Common.CampusLightAnchorGroup`
- `Campus.Common.CampusLoadAsyncSceneParam`
- `Campus.Common.CampusLoadSceneParam`
- `Campus.Common.CampusPhotographySceneLayout`
- `Campus.Common.CampusPhotographySceneLayoutCollection`
- `Campus.Common.CampusQualityManager`
- `Campus.Common.CampusResourceDefine`
- `Campus.Common.CampusSceneLayout`
- `Campus.Common.CampusSceneLayoutCollection`
- `Campus.Common.CampusSceneManager`
- `Campus.Common.CampusShaderRef`
- `Campus.Common.CampusSoundManager`
- `Campus.Common.CampusSubmoduleInitializer`
- `Campus.Common.CampusSwitchableCamera`
- `Campus.Common.CampusText`
- `Campus.Common.CampusTextLinkTouchArea`
- `Campus.Common.CampusTransformAnchor`
- `Campus.Common.CampusTransformAnchorGroup`
- `Campus.Common.CampusTween`
- `Campus.Common.CampusUIBase`
- `Campus.Common.CampusVideoManager`
- `Campus.Common.CampusVideoPlayer`
- `Campus.Common.CampusVideoPlayerUnityMaskable`
- `Campus.Common.CampusVirtualActorController`
- `Campus.Common.CampusVirtualActorSwitch`
- `Campus.Common.ColorGradient`
- `Campus.Common.ColorPaint`
- `Campus.Common.ConstantCurvePairMode`
- `Campus.Common.ConstantCurveValueBase`
- `Campus.Common.ContestAnimationClipCollection`
- `Campus.Common.ContestAnimationClipData`
- `Campus.Common.CriUserData`
- `Campus.Common.EffectDefine`
- `Campus.Common.EnumUtility`
- `Campus.Common.EnvironmentMotionDefine`
- `Campus.Common.Extensions.BackgroundBlurExtensions`
- `Campus.Common.Extensions.CanvasExtensions`
- `Campus.Common.Extensions.ColorExtensions`
- `Campus.Common.Extensions.ComponentExtensions`
- `Campus.Common.Extensions.EnumerableExtensions`
- `Campus.Common.Extensions.GameObjectExtensions`
- `Campus.Common.Extensions.IObservableExtensions`
- `Campus.Common.Extensions.LinearGradientExtensions`
- `Campus.Common.Extensions.ReactiveCollectionExtensions`
- `Campus.Common.Extensions.RectTransformExtensions`
- `Campus.Common.Extensions.SequenceExtensions`
- `Campus.Common.Extensions.TitanExtensions`
- `Campus.Common.Extensions.TweenExtensions`
- `Campus.Common.FloatCurve`
- `Campus.Common.GlobalWindParameter`
- `Campus.Common.GlobalWindRendererFeature`
- `Campus.Common.GlobalWindType`
- `Campus.Common.GlobalWindVolume`
- `Campus.Common.GoboLight.GoboData`
- `Campus.Common.GoboLight.GoboLight`
- `Campus.Common.GoboLight.GoboLightController`
- `Campus.Common.GoboLight.GoboLightJob`
- `Campus.Common.GoboLight.GoboLightUpdateJob`
- `Campus.Common.GoboLight.LightData`
- `Campus.Common.GoboLight.VertexLayout`
- `Campus.Common.GraphicMask`
- `Campus.Common.GraphicMaskBase`
- `Campus.Common.GraphicMaskTarget`
- `Campus.Common.GraphicsBurnEffectView`
- `Campus.Common.HomeEnvironmentCinemachineController`
- `Campus.Common.ICampusActorController`
- `Campus.Common.ICampusActorDescriptor`
- `Campus.Common.ICampusLightAnchor`
- `Campus.Common.ICampusSoundPlayer`
- `Campus.Common.ICampusTransformAnchor`
- `Campus.Common.ICampusTransformAnchorTarget`
- `Campus.Common.IMultiTouchable`
- `Campus.Common.IO.FileUtils`
- `Campus.Common.ImageScaler`
- `Campus.Common.LayoutMotionDefine`
- `Campus.Common.LinearGradient`
- `Campus.Common.LinearGradientGlass`
- `Campus.Common.Live.CampusCrossFadeImage`
- `Campus.Common.Live.CampusLiveActor`
- `Campus.Common.Live.CampusLiveBinder`
- `Campus.Common.Live.CampusLiveCameraOverlay`
- `Campus.Common.Live.CampusLiveEnvironment`
- `Campus.Common.Live.CampusLiveTimelineController`
- `Campus.Common.LookAt.CampusActorLookAtController`
- `Campus.Common.LookAt.CampusLookAtConstraint`
- `Campus.Common.LookAt.LookAtDefine`
- `Campus.Common.LookAt.LookAtUtility`
- `Campus.Common.LookAt.LookTargetType`
- `Campus.Common.MaskGpuUtility`
- `Campus.Common.MaskUtility`
- `Campus.Common.MotionDefineClip`
- `Campus.Common.MotionDefineGroup`
- `Campus.Common.MultipleGraphicMask`
- `Campus.Common.Octo.CampusOctoSetupper`
- `Campus.Common.Octo.MotionAssetKeeper`
- `Campus.Common.Octo.OctoTaskAbortException`
- `Campus.Common.Octo.ResourceUtility`
- `Campus.Common.Octo.ReusableAssetKeeper`
- `Campus.Common.Octo.SimpleAssetKeeper`
- `Campus.Common.OrientationType`
- `Campus.Common.Panorama.IPanoramaGyroCamera`
- `Campus.Common.Panorama.IPanoramaMoveCamera`
- `Campus.Common.Panorama.PanoramaActorLookAtController`
- `Campus.Common.Panorama.PanoramaCameraController`
- `Campus.Common.Panorama.PanoramaCameraHeightCorrectionExtension`
- `Campus.Common.Panorama.PanoramaCameraHeightCorrectionType`
- `Campus.Common.Panorama.PanoramaCameraHolder`
- `Campus.Common.Panorama.PanoramaCameraType`
- `Campus.Common.Panorama.PanoramaCraneActivityController`
- `Campus.Common.Panorama.PanoramaDefine`
- `Campus.Common.Panorama.PanoramaDroneActivityController`
- `Campus.Common.Panorama.PanoramaGamepadInputSettings`
- `Campus.Common.Panorama.PanoramaUtility`
- `Campus.Common.Panorama.SwitchPanoramaCamera`
- `Campus.Common.Panorama.SwitchPanoramaCameraHeightCorrectionUtility`
- `Campus.Common.ParticleColor`
- `Campus.Common.ParticleStartColorApplier`
- `Campus.Common.PerspectiveGraphic`
- `Campus.Common.PerspectiveTransform`
- `Campus.Common.PointDepth.PointDepthDataRendererFeature`
- `Campus.Common.PointDepthData`
- `Campus.Common.RotateRing`
- `Campus.Common.RoundBorder`
- `Campus.Common.SDFGraphic`
- `Campus.Common.ScreenOrientationControllerBase`
- `Campus.Common.ScreenOrientationManager`
- `Campus.Common.SerializableDictionary<TKey, TValue>`
- `Campus.Common.SerializableGuid`
- `Campus.Common.ShaderVariantGroup`
- `Campus.Common.Sound.SoundCache`
- `Campus.Common.SoundEnum`
- `Campus.Common.SoundInfo`
- `Campus.Common.StandaloneScreenOrientationController`
- `Campus.Common.TMPro.I18nTMProText`
- `Campus.Common.TMPro.ITMProTextStyleMask`
- `Campus.Common.TMPro.TMProTextStyleConfig`
- `Campus.Common.TMPro.TMProTextStyleConfigBase<T, TStyle>`
- `Campus.Common.TMPro.TMProTextStyleConfigStyle`
- `Campus.Common.TMPro.TMProTextStyleTypeBase<T>`
- `Campus.Common.TMProFontManager`
- `Campus.Common.TMProTextStyle`
- `Campus.Common.TMProTextStyleType`
- `Campus.Common.ThreadPriorityManager`
- `Campus.Common.ThreadPriorityScope`
- `Campus.Common.Titan.CampusTitanSettings`
- `Campus.Common.UICameraController`
- `Campus.Common.UIDragTracer`
- `Campus.Common.UIDrawObjects`
- `Campus.Common.UIExtensions`
- `Campus.Common.UIRenderResultCopyManager`
- `Campus.Common.UIRenderTargetBlurManager`
- `Campus.Common.UIRenderer.FinalUIRenderPassData`
- `Campus.Common.UIRenderer.IUIRenderPassData`
- `Campus.Common.UIRenderer.KawaseBlur`
- `Campus.Common.UIRenderer.UIRenderPass`
- `Campus.Common.UIRenderer.UIRenderPassData`
- `Campus.Common.UIRenderer.UIRenderPassType`
- `Campus.Common.UIRenderer.UIRenderResultCopyPass`
- `Campus.Common.UIRenderer.UIRenderTargetBlurPass`
- `Campus.Common.UIRenderer.UIRenderTargetBlurPassData`
- `Campus.Common.UIRenderer.UIRendererFeature`
- `Campus.Common.UIRendererManager`
- `Campus.Common.UISharedHub`
- `Campus.Common.UISharedHubRegistry`
- `Campus.Common.UITextureOverlay`
- `Campus.Common.UnitBezier`
- `Campus.Common.UvScale`
- `Campus.Common.VideoImage`
- `Campus.Crowd.BillboardMatricesJobHandler`
- `Campus.Crowd.BillboardMeshRenderSystem`
- `Campus.Crowd.BillboardQuality`
- `Campus.Crowd.BillboardQualityParameter`
- `Campus.Crowd.CellSortData`
- `Campus.Crowd.CellSortDataComparer`
- `Campus.Crowd.ClipData`
- `Campus.Crowd.Crowd`
- `Campus.Crowd.CrowdAnimationBehaviour`
- `Campus.Crowd.CrowdAnimationComponent`
- `Campus.Crowd.CrowdAnimationJob`
- `Campus.Crowd.CrowdAnimationTimeline`
- `Campus.Crowd.CrowdAnimator`
- `Campus.Crowd.CrowdColorPreset`
- `Campus.Crowd.CrowdComputePass`
- `Campus.Crowd.CrowdCullJob`
- `Campus.Crowd.CrowdData`
- `Campus.Crowd.CrowdMeshRenderSystem`
- `Campus.Crowd.CrowdModelData`
- `Campus.Crowd.CrowdMotionDefine`
- `Campus.Crowd.CrowdOcclusionVolume`
- `Campus.Crowd.CrowdRendererFeature`
- `Campus.Crowd.CrowdRenderingSetupData`
- `Campus.Crowd.CrowdSortJob`
- `Campus.Crowd.CrowdSystem`
- `Campus.Crowd.CrowdSystemData`
- `Campus.Crowd.CrowdTimelineAsset`
- `Campus.Crowd.CrowdTimelineBehaviour`
- `Campus.Crowd.CrowdTimelineMixerBehaviour`
- `Campus.Crowd.CrowdTimelineTrack`
- `Campus.Crowd.CrowdUtility`
- `Campus.Crowd.CrowdVolume`
- `Campus.Crowd.CrowdVolumeParameter`
- `Campus.Crowd.ICrowdAnimation`
- `Campus.Crowd.ICrowdPenlight`
- `Campus.Crowd.OctreeInfo`
- `Campus.Crowd.PenlightMeshRenderSystem`
- `Campus.Crowd.PersonInfo`
- `Campus.Crowd.VertexStreamType`
- `Campus.DecalLight.CampusDecalLight`
- `Campus.DecalLight.CampusDecalLightCachedChunk`
- `Campus.DecalLight.CampusDecalLightCombinedChunks`
- `Campus.DecalLight.CampusDecalLightCulledChunk`
- `Campus.DecalLight.CampusDecalLightCullingSystem`
- `Campus.DecalLight.CampusDecalLightDrawSystem`
- `Campus.DecalLight.CampusDecalLightEntityChunk`
- `Campus.DecalLight.CampusDecalLightEntityManager`
- `Campus.DecalLight.CampusDecalLightRendererFeature`
- `Campus.DecalLight.CampusDecalLightResultChunk`
- `Campus.DecalLight.CampusDecalLightResultSystem`
- `Campus.DecalLight.CampusDecalLightUpdateSystem`
- `Campus.DecalLight.SharedCampusDecalLightEntityManager`
- `Campus.Gasha.CardReversalType`
- `Campus.Gasha.CardType`
- `Campus.Gasha.DummyData.DummyCardParam`
- `Campus.Gasha.GahsaBindUseCase`
- `Campus.Gasha.GahsaSsrIdolVideoStartMarker`
- `Campus.Gasha.Gasha3DModelMarker`
- `Campus.Gasha.GashaActorMotionModel`
- `Campus.Gasha.GashaAnimationCalculatorV2`
- `Campus.Gasha.GashaBgmDownloadUseCase`
- `Campus.Gasha.GashaBgmMarker`
- `Campus.Gasha.GashaBgmModel`
- `Campus.Gasha.GashaBinder`
- `Campus.Gasha.GashaBuildGraphUseCase`
- `Campus.Gasha.GashaCanvasHelper`
- `Campus.Gasha.GashaCardModel`
- `Campus.Gasha.GashaCardNewDisplayMarker`
- `Campus.Gasha.GashaCardParam`
- `Campus.Gasha.GashaCardReversalUseCase`
- `Campus.Gasha.GashaEnvironment`
- `Campus.Gasha.GashaFadeOutHandler`
- `Campus.Gasha.GashaFadeOutStartMarker`
- `Campus.Gasha.GashaFreezeMarker`
- `Campus.Gasha.GashaGlobalEffect`
- `Campus.Gasha.GashaGlobalEffectBindParam`
- `Campus.Gasha.GashaGlobalEffectTitanHandler`
- `Campus.Gasha.GashaHapticMarker`
- `Campus.Gasha.GashaLightListStartMarker`
- `Campus.Gasha.GashaLightUpBehaviour`
- `Campus.Gasha.GashaLightUpClip`
- `Campus.Gasha.GashaLightUpMarker`
- `Campus.Gasha.GashaLightUpTrack`
- `Campus.Gasha.GashaParticleMarker`
- `Campus.Gasha.GashaPlayableDirectorHandler`
- `Campus.Gasha.GashaPlayer`
- `Campus.Gasha.GashaResourceView`
- `Campus.Gasha.GashaSceneModel`
- `Campus.Gasha.GashaSeMarker`
- `Campus.Gasha.GashaSequenceBindModel`
- `Campus.Gasha.GashaSoundManager`
- `Campus.Gasha.GashaStep`
- `Campus.Gasha.GashaSupportVoiceMarker`
- `Campus.Gasha.GashaTapSeekMarker`
- `Campus.Gasha.GashaTimelineController`
- `Campus.Gasha.GashaTransitionGraph`
- `Campus.Gasha.GashaTransitionNode`
- `Campus.Gasha.GashaVideoPlayerHandler`
- `Campus.Gasha.IGashaPlayer`
- `Campus.Gasha.RarityType`
- `Campus.Gasha.Sequences.CardIdolBase`
- `Campus.Gasha.Sequences.CardIdolSequence`
- `Campus.Gasha.Sequences.CardIdolSequenceSsr`
- `Campus.Gasha.Sequences.CardSupportSequence`
- `Campus.Gasha.Sequences.FadeOutVoicePlayer`
- `Campus.Gasha.Sequences.GashaId`
- `Campus.Gasha.Sequences.GashaListSequence`
- `Campus.Gasha.Sequences.GashaSequence`
- `Campus.Gasha.Sequences.GashaSequenceBase`
- `Campus.Gasha.Sequences.ISequenceDirector`
- `Campus.Gasha.Sequences.LightListSequenceParam`
- `Campus.Gasha.Sequences.LightParam`
- `Campus.Gasha.Sequences.TapToStartSequence`
- `Campus.Gasha.VolumetricLight.GashaVolumetricLight`
- `Campus.Live.CampusLiveAutoPhotoTimeData`
- `Campus.Live.CampusLiveCameraTranslation`
- `Campus.Live.CampusRenderInstances`
- `Campus.Live.Equipment.Environment.LiveDirectionalLight`
- `Campus.Live.Equipment.Environment.LiveLaser`
- `Campus.Live.Equipment.Environment.LiveLightBasic`
- `Campus.Live.Equipment.Environment.LiveLightComponent`
- `Campus.Live.Equipment.Environment.LiveParticleEffect`
- `Campus.Live.Equipment.Environment.LivePsyllium`
- `Campus.Live.Equipment.EnvironmentBase`
- `Campus.Live.Equipment.EquipmentExtensions`
- `Campus.Live.Equipment.EquipmentId`
- `Campus.Live.Equipment.EquipmentIdList`
- `Campus.Live.Equipment.EquipmentValue`
- `Campus.Live.Equipment.EquipmentValueFactor`
- `Campus.Live.Equipment.EquipmentValueFlags`
- `Campus.Live.Equipment.EquipmentValueType`
- `Campus.Live.Equipment.ILiveEquipmentProperty`
- `Campus.Live.Equipment.IUseFlags`
- `Campus.Live.Equipment.LiveEquipmentAnimationData`
- `Campus.Live.Equipment.LiveEquipmentComponentProperty`
- `Campus.Live.Equipment.LiveEquipmentController`
- `Campus.Live.Equipment.LiveEquipmentInitialData`
- `Campus.Live.Equipment.LiveEquipmentReceiver`
- `Campus.Live.Equipment.LiveEquipmentStreamData`
- `Campus.Live.Equipment.LiveEquipmentStreamJobType`
- `Campus.Live.Equipment.LiveEquipmentTimelineData`
- `Campus.Live.Equipment.Timeline.FireType`
- `Campus.Live.Equipment.Timeline.LiveEquipmentAnimationCurve`
- `Campus.Live.Equipment.Timeline.LiveEquipmentAssetBehaviour`
- `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase`
- `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightAssetBehaviour`
- `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightClip`
- `Campus.Live.Equipment.Timeline.LiveEquipmentDirectionalLightTrack`
- `Campus.Live.Equipment.Timeline.LiveEquipmentEffectClip`
- `Campus.Live.Equipment.Timeline.LiveEquipmentEffectTrack`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLaserAssetBehaviour`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLaserClip`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLaserTrack`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLightAssetBehaviour`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLightClip`
- `Campus.Live.Equipment.Timeline.LiveEquipmentLightTrack`
- `Campus.Live.Equipment.Timeline.LiveEquipmentPsylliumAssetBehaviour`
- `Campus.Live.Equipment.Timeline.LiveEquipmentPsylliumClip`
- `Campus.Live.Equipment.Timeline.LiveEquipmentPsylliumTrack`
- `Campus.Live.Equipment.Timeline.LiveEquipmentStreamJob`
- `Campus.Live.Equipment.Timeline.LiveEquipmentStreamJobUtility`
- `Campus.Live.Equipment.Timeline.LiveEquipmentTrackBase`
- `Campus.Live.Equipment.Timeline.LiveEquipmentTrackBehaviour`
- `Campus.Live.Equipment.Timeline.MovingMode`
- `Campus.Live.LivePanoramaCameraManager`
- `Campus.Live.LiveRenderingDebugData`
- `Campus.Live.LiveRenderingDebugFeature`
- `Campus.Live.Monitor.Monitor3DImage`
- `Campus.Live.Monitor.MonitorRepeatImage`
- `Campus.Live.SRTSubtitle`
- `Campus.Live.SubtitleData`
- `Campus.MobAudience.MobAudiencePenlightController`
- `Campus.MobAudience.MobAudiencePenlightOverride`
- `Campus.Photography.IPhotographyActor`
- `Campus.Photography.PhotographyActivityBlockingCinemachine`
- `Campus.Photography.PhotographyActivityCameraController`
- `Campus.Photography.PhotographyActivityController`
- `Campus.Photography.PhotographyActivityControllerModel`
- `Campus.Photography.PhotographyActivityMoveController`
- `Campus.Photography.PhotographyActorLookAtController`
- `Campus.Photography.PhotographyCaptureSpotData`
- `Campus.Photography.PhotographyConstraint`
- `Campus.Photography.PhotographyDefine`
- `Campus.Photography.PhotographySceneManager`
- `Campus.Photography.PhotographyScreenSpotData`
- `Campus.Photography.PhotographyUtility`
- `Campus.Rendering.BlitVolumetricHeightFogPass`
- `Campus.Rendering.CampusActorParameterPass`
- `Campus.Rendering.CampusActorParameterSettings`
- `Campus.Rendering.CampusActorRim`
- `Campus.Rendering.CampusActorShader`
- `Campus.Rendering.CampusGlobalParameterRendererFeature`
- `Campus.Rendering.CampusLitActor`
- `Campus.Rendering.CampusLitColorParameter`
- `Campus.Rendering.DrawVolumetricHeightFogPass`
- `Campus.Rendering.LightVolume`
- `Campus.Rendering.OverrideBaseColor`
- `Campus.Rendering.OverrideBaseMap`
- `Campus.Rendering.OverrideEmissionColor`
- `Campus.Rendering.RimFromLightVolume`
- `Campus.Rendering.SphereFogVolume`
- `Campus.Rendering.VegetationParameter`
- `Campus.Rendering.VolumetricHeightFog`
- `Campus.Rendering.VolumetricHeightFogFeature`
- `Campus.Rendering.VolumetricHeightFogRaymarchMode`
- `Campus.Rendering.VolumetricHeightFogSettings`
- `Campus.Rendering.VolumetricHeightFogVolume`
- `Campus.Timeline.AbLoopDestinationMarker`
- `Campus.Timeline.AbLoopJumpMarker`
- `Campus.Timeline.BeatDenominatorMarker`
- `Campus.Timeline.BeatNumeratorMarker`
- `Campus.Timeline.CampusActorResetMarker`
- `Campus.Timeline.CampusBpmInfo`
- `Campus.Timeline.CampusBpmMarkerTrack`
- `Campus.Timeline.CampusBpmTimelineAsset`
- `Campus.Timeline.CampusBpmTimelineBehaviour`
- `Campus.Timeline.CampusBpmTimelineMixer`
- `Campus.Timeline.CampusBpmTimelineTrack`
- `Campus.Timeline.CampusCriMixerBehaviour`
- `Campus.Timeline.CampusCriVideoPlayerAsset`
- `Campus.Timeline.CampusCriVideoPlayerBehaviour`
- `Campus.Timeline.CampusCriVideoPlayerTrack`
- `Campus.Timeline.CampusCriVideoSyncMarker`
- `Campus.Timeline.CampusCrossFadeAsset`
- `Campus.Timeline.CampusCrossFadeBehaviour`
- `Campus.Timeline.CampusCrossFadeMixerBehaviour`
- `Campus.Timeline.CampusCrossFadeTrack`
- `Campus.Timeline.CampusCurrentActorSignalBehaviour`
- `Campus.Timeline.CampusCurrentActorSignalClip`
- `Campus.Timeline.CampusCurrentActorSignalMixerBehaviour`
- `Campus.Timeline.CampusCurrentActorSignalTrack`
- `Campus.Timeline.CampusCutMarker`
- `Campus.Timeline.CampusDirectorControlAsset`
- `Campus.Timeline.CampusDirectorControlTrack`
- `Campus.Timeline.CampusForcedCameraBehaviour`
- `Campus.Timeline.CampusForcedCameraClip`
- `Campus.Timeline.CampusForcedCameraMixerBehaviour`
- `Campus.Timeline.CampusForcedCameraTrack`
- `Campus.Timeline.CampusLightAsset`
- `Campus.Timeline.CampusLightBehaviour`
- `Campus.Timeline.CampusLightMixerBehaviour`
- `Campus.Timeline.CampusLightTrack`
- `Campus.Timeline.CampusLookAtProhibitBehaviour`
- `Campus.Timeline.CampusLookAtProhibitClip`
- `Campus.Timeline.CampusLookAtProhibitMixerBehaviour`
- `Campus.Timeline.CampusLookAtProhibitTrack`
- `Campus.Timeline.CampusLoopEventReceiver`
- `Campus.Timeline.CampusMonitorAnimationPlayableAsset`
- `Campus.Timeline.CampusParticlePlayableAsset`
- `Campus.Timeline.CampusParticlePlayableBehaviour`
- `Campus.Timeline.CampusParticlePlayableTrack`
- `Campus.Timeline.CampusSubTitleTimelineAsset`
- `Campus.Timeline.CampusSubtitleBehaviour`
- `Campus.Timeline.CampusSubtitleTrack`
- `Campus.Timeline.CampusTargetImageClip`
- `Campus.Timeline.CampusTargetImageClipBehaviour`
- `Campus.Timeline.CampusTargetImageTrack`
- `Campus.Timeline.CampusTargetImageTrackBehaviour`
- `Campus.Timeline.CampusTimelineEventReceiver`
- `Campus.Timeline.CampusTweenAsset`
- `Campus.Timeline.CampusTweenBehaviour`
- `Campus.Timeline.CampusTweenMixerBehaviour`
- `Campus.Timeline.CampusTweenTrack`
- `Campus.Timeline.CampusVideoPlayerClip`
- `Campus.Timeline.CampusVideoPlayerTrack`
- `Campus.Timeline.CampusVideoPlayerTrackBehaviour`
- `Campus.Timeline.CampusVolumeProfileTimelineAsset`
- `Campus.Timeline.CampusVolumeProfileTimelineBehaviour`
- `Campus.Timeline.CampusVolumeProfileTimelineMixerBehaviour`
- `Campus.Timeline.CampusVolumeProfileTimelineTrack`
- `Campus.Timeline.CampusVolumeTimelineAsset`
- `Campus.Timeline.CampusVolumeTimelineBehaviour`
- `Campus.Timeline.CampusVolumeTimelineMixerBehaviour`
- `Campus.Timeline.CampusVolumeTimelineTrack`
- `Campus.Timeline.CurrentActorSignalData`
- `Campus.Timeline.ForcedCameraChangedInfo`
- `Campus.Timeline.IBpmTrack`
- `Campus.Timeline.ICurrentActorSignalController`
- `Campus.Timeline.ICurrentActorSignalNotifier`
- `Campus.Timeline.IForcedCameraController`
- `Campus.Timeline.IForcedCameraInternal`
- `Campus.Timeline.ILookAtProhibitController`
- `Campus.Timeline.ILookAtProhibitSource`
- `Campus.Timeline.IPanoramaCameraController`
- `Campus.Timeline.LookAtProhibitType`
- `Campus.Titan.BackgroundBlurBrightnessClip`
- `Campus.Titan.BackgroundBlurBrightnessTrack`
- `Campus.Titan.BackgroundBlurMixWhiteAmountClip`
- `Campus.Titan.BackgroundBlurMixWhiteAmountTrack`
- `Campus.Titan.CampusCanvasBlurHsvOffsetClip`
- `Campus.Titan.CampusCanvasBlurHsvOffsetTrack`
- `Campus.Titan.CampusCanvasBlurSizeClip`
- `Campus.Titan.CampusCanvasBlurSizeTrack`
- `Campus.Titan.CampusCanvasGroupAlphaClip`
- `Campus.Titan.CampusCanvasGroupAlphaTrack`
- `Campus.Titan.CampusSkipMarker`
- `Campus.Titan.CampusSoundEffectMarker`
- `Campus.Titan.CampusTapWaitMarker`
- `Campus.Titan.CampusVoiceMarker`
- `Campus.Titan.CampusWaitEndMarker`
- `Campus.Titan.CharacterDearnessReport`
- `Campus.Titan.CharacterDearnessReportView`
- `Campus.Titan.CharacterEpisodeReportData`
- `Campus.Titan.EpisodeReportData`
- `Campus.Titan.GraphicsBurnEffectClip`
- `Campus.Titan.GraphicsBurnEffectTrack`
- `Campus.Titan.ILoadAssetTrack`
- `Campus.Titan.ISoundEffectPlayer`
- `Campus.Titan.ITitanAdvBridge`
- `Campus.Titan.LinearGradientColorClip`
- `Campus.Titan.LinearGradientColorTrack`
- `Campus.Titan.LinearGradientPositionClip`
- `Campus.Titan.LinearGradientPositionTrack`
- `Campus.Titan.LoadCharacterDearnessReportTrack`
- `Campus.Titan.LoadCharacterEpisodeReportTrack`
- `Campus.Titan.LoadTextureTrack`
- `Campus.Titan.ReportData`
- `Campus.Titan.RotateRingClip`
- `Campus.Titan.RotateRingTrack`
- `Campus.Titan.RotateRingValue`
- `Campus.Titan.RotateRingValueParameter`
- `Campus.Titan.RoundBorderBorderSizeClip`
- `Campus.Titan.RoundBorderBorderSizeTrack`
- `Campus.Titan.RoundBorderCircleClip`
- `Campus.Titan.RoundBorderCircleTrack`
- `Campus.Titan.RoundBorderRoundClip`
- `Campus.Titan.RoundBorderRoundTrack`
- `Campus.Titan.RoundParameter`
- `Campus.Titan.RuntimeSoundEffectPlayer`
- `Campus.Titan.SetBlocksRaycastsType`
- `Campus.Titan.SoundEffectClip`
- `Campus.Titan.SoundEffectTrack`
- `Campus.Titan.TitanAssetBundleLoader`
- `Campus.Titan.TitanExtensions`
- `Campus.Titan.TitanMemoData`
- `Campus.Titan.TitanSeekableInOutPlayer`
- `Campus.live.CampusLiveVolumeController`
- `Campus.live.VolumeProfileData`
- `CampusActorAnimationRigData.<>c__DisplayClass133_0` (compiler-generated name)
- `CampusActorController.<>c` (compiler-generated name)
- `CampusActorController.<>c__DisplayClass70_0` (compiler-generated name)
- `CampusActorController.<>c__DisplayClass71_0` (compiler-generated name)
- `CampusActorController.<>c__DisplayClass71_1` (compiler-generated name)
- `CampusActorController.<>c__DisplayClass98_0` (compiler-generated name)
- `CampusActorController.<ActorLoadAsync>d__71` (compiler-generated name)
- `CampusActorController.<BuildAsync>d__69` (compiler-generated name)
- `CampusActorController.<OnBuildModelSuccessAsync>d__84` (compiler-generated name)
- `CampusActorController.<_BuildAsync>d__70` (compiler-generated name)
- `CampusActorController.OverrideActorMaterialPropertyData`
- `CampusActorController.ShaderIDs`
- `CampusActorDescriptor.<>c` (compiler-generated name)
- `CampusActorDescriptor.UniqueIdTypeEqualityComparer`
- `CampusActorEyeHighlight.LimitData`
- `CampusActorLayout.<>c` (compiler-generated name)
- `CampusActorLayout.Constraint`
- `CampusActorLayout.Data`
- `CampusActorManager.<>c` (compiler-generated name)
- `CampusActorManager.<>c__DisplayClass18_0` (compiler-generated name)
- `CampusActorManager.<>c__DisplayClass19_0` (compiler-generated name)
- `CampusActorManager.<>c__DisplayClass22_0` (compiler-generated name)
- `CampusActorManager.<SafeUpdateActorAsync>d__20` (compiler-generated name)
- `CampusActorManager.<UpdateActorAsync>d__21` (compiler-generated name)
- `CampusActorManager.<UpdateCacheActorAsync>d__19` (compiler-generated name)
- `CampusActorManager.ActorInfo`
- `CampusActorModelKeeper.<>c__DisplayClass5_0` (compiler-generated name)
- `CampusActorModelKeeper.<>c__DisplayClass5_1` (compiler-generated name)
- `CampusActorRendererFeature.CampusActorRenderPass`
- `CampusActorRendererFeature.CampusActorRenderPass.<>c` (compiler-generated name)
- `CampusActorShader.Property`
- `CampusActorShader.ShaderType`
- `CampusButton.<LongTapLoopActionAsync>d__11` (compiler-generated name)
- `CampusButtonBase.<>c__DisplayClass42_0` (compiler-generated name)
- `CampusButtonBase.<>c__DisplayClass43_0` (compiler-generated name)
- `CampusButtonBase.<DisabledTransitionAsync>d__38` (compiler-generated name)
- `CampusButtonBase.<PressedTransitionAsync>d__31` (compiler-generated name)
- `CampusButtonBase.<WaitClickAsync>d__42` (compiler-generated name)
- `CampusButtonBase.<WaitPressAsync>d__43` (compiler-generated name)
- `CampusCanvas.CanvasDirection`
- `CampusCanvasGroupAlphaTrack.<>c__DisplayClass4_0` (compiler-generated name)
- `CampusColorManager.<>c__DisplayClass5_0` (compiler-generated name)
- `CampusCriVideoPlayerTrack.<>c` (compiler-generated name)
- `CampusCriVideoPlayerTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `CampusCrossFadeBehaviour.CrossFadeType`
- `CampusCustomLookAtEffector.CampusCustomLookAtEffectorPoseSettingWeight`
- `CampusCustomLookAtEffector.EnableLimitWeightCalcType`
- `CampusDecalLight.LightShapeType`
- `CampusDecalLightCullingSystem.CullingJob`
- `CampusDecalLightResultSystem.ResultJob`
- `CampusDecalLightUpdateSystem.UpdateJob`
- `CampusFontOutlineSetting.<>c__DisplayClass7_0` (compiler-generated name)
- `CampusFontOutlineSetting.OutlineColor`
- `CampusForcedCameraMixerBehaviour.ClipInfo`
- `CampusGyroController.<InitializeAsync>d__19` (compiler-generated name)
- `CampusHomeSceneLayout.<>c__DisplayClass32_0` (compiler-generated name)
- `CampusHomeSceneLayout.<WaitUntilHomeBlendEndAsync>d__32` (compiler-generated name)
- `CampusLightMixerBehaviour.LightInfo`
- `CampusLightMixerBehaviour.TransformInfo`
- `CampusLiveBinder.<>c` (compiler-generated name)
- `CampusLiveBinder.<>c__DisplayClass39_0` (compiler-generated name)
- `CampusLiveBinder.<>c__DisplayClass39_1` (compiler-generated name)
- `CampusLiveBinder.<>c__DisplayClass46_0` (compiler-generated name)
- `CampusLiveBinder.<SetupAsync>d__39` (compiler-generated name)
- `CampusLiveBinder.BindParams`
- `CampusLiveBinder.DirectorName`
- `CampusLiveBinder.ReferencePropertyName`
- `CampusLiveBinder.TrackName`
- `CampusLiveTimelineController.<>c` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass113_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass114_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass115_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass123_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass124_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass124_1` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass126_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass129_0` (compiler-generated name)
- `CampusLiveTimelineController.<>c__DisplayClass129_1` (compiler-generated name)
- `CampusLiveTimelineController.ForcedCameraState`
- `CampusLiveTimelineController.LiveProp`
- `CampusLiveTimelineController.LivePropSetting`
- `CampusOctoSetupper.<>c` (compiler-generated name)
- `CampusOctoSetupper.<>c__DisplayClass33_0` (compiler-generated name)
- `CampusOctoSetupper.<SetupAsync>d__33` (compiler-generated name)
- `CampusOctoSetupper.OctoEnvType`
- `CampusPhotographySceneLayout.ActorLookAtSetting`
- `CampusPhotographySceneLayout.ActorSetting`
- `CampusPhotographySceneLayout.SceneLayoutLookAngleLimit`
- `CampusQualityManager.QualityLevel`
- `CampusRenderInstances.TransformData`
- `CampusRenderInstances.UpdateJob`
- `CampusResourceDefine.SE`
- `CampusResourceDefine.SE.LiveBattle`
- `CampusSceneLayout.<>c` (compiler-generated name)
- `CampusSceneLayout.<>c__DisplayClass27_0` (compiler-generated name)
- `CampusSceneLayout.<WaitUntilActiveCameraAsync>d__27` (compiler-generated name)
- `CampusSceneLayout.SituationType`
- `CampusSceneManager.<>c__DisplayClass26_0` (compiler-generated name)
- `CampusSceneManager.<InvokeTaskAsync>d__31` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__18` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__19` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__20` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__21` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__22` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__23` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__24` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__25` (compiler-generated name)
- `CampusSceneManager.<LoadSceneAsync>d__26` (compiler-generated name)
- `CampusSceneManager.<OnCompleteActivationAsync>d__27` (compiler-generated name)
- `CampusSceneManager.<UnloadSceneAsync>d__32` (compiler-generated name)
- `CampusSceneManager.<UnloadSceneAsync>d__33` (compiler-generated name)
- `CampusSoundManager.<>c__DisplayClass13_0` (compiler-generated name)
- `CampusSoundManager.<>c__DisplayClass24_0` (compiler-generated name)
- `CampusSoundManager.<>c__DisplayClass25_0` (compiler-generated name)
- `CampusSoundManager.<>c__DisplayClass26_0` (compiler-generated name)
- `CampusSoundManager.<>c__DisplayClass65_0` (compiler-generated name)
- `CampusSoundManager.<PauseBgmAsync>d__18` (compiler-generated name)
- `CampusSoundManager.<PlayBgmOnceAsync>d__46` (compiler-generated name)
- `CampusSoundManager.<ReturnScheduleAsync>d__16` (compiler-generated name)
- `CampusSoundManager.<StopBgmAsync>d__22` (compiler-generated name)
- `CampusSoundManager.<SwitchBgmAsync>d__13` (compiler-generated name)
- `CampusSoundManager.<UnpauseBgmAsync>d__20` (compiler-generated name)
- `CampusSoundManager.<_DownloadAsync>d__27` (compiler-generated name)
- `CampusSoundManager.<_InitializeAsync>d__8` (compiler-generated name)
- `CampusSoundManager.<_PlayBgmAsync>d__11` (compiler-generated name)
- `CampusSoundManager.<_PlaySingleAsync>d__24` (compiler-generated name)
- `CampusSoundManager.<_PreloadAsync>d__25` (compiler-generated name)
- `CampusSoundManager.<_SetCurrentBgmPlayer>d__14` (compiler-generated name)
- `CampusSoundPlayer.<>c__DisplayClass30_0` (compiler-generated name)
- `CampusSoundPlayer.<>c__DisplayClass49_0` (compiler-generated name)
- `CampusText.<ApplyFontIdAsync>d__42` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<>c` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<DownloadMovieAsync>d__26` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<LightScrubToFrameAsync>d__41` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<OnEnableAsync>d__22` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<PrepareForScrubSeekAsync>d__43` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<RunScrubLoopAsync>d__40` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<SetMovieInfo>d__27` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<WaitForDisplayReadyAsync>d__45` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<WaitForPlayerStoppedAsync>d__44` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.<WaitForStatusAsync>d__46` (compiler-generated name)
- `CampusTimelineCriVideoPlayer.MovieInfo`
- `CampusTimelineCriVideoPlayer.VideoPlayerState`
- `CampusTransformAnchor.Axes`
- `CampusTransformAnchor.UpDirection`
- `CampusUIBase.PropertyId`
- `CampusVideoPlayer.<>c__DisplayClass47_0` (compiler-generated name)
- `CampusVideoPlayer.<InitializeAsync>d__29` (compiler-generated name)
- `CampusVideoPlayer.<LoadResourceAsync>d__30` (compiler-generated name)
- `CampusVideoPlayer.<TryInitializeAsync>d__28` (compiler-generated name)
- `CampusVideoPlayerUnityMaskable.PropertyId`
- `CampusVirtualActorController.FocusedEyeBoneResult`
- `CampusVirtualActorController.HipsPosXZResult`
- `CampusVirtualActorController.ScaleResult`
- `CampusVirtualActorSwitch.SourceVirualActor`
- `CanvasRT.CanvasRenderTexture`
- `CanvasRT.CanvasRenderTextureImage`
- `CanvasRT.CanvasRenderTextureRenderer`
- `CanvasRT.CanvasRenderTextureRendererData`
- `CanvasRT.CanvasRenderTextureRendererPass`
- `CardIdolSequence.<Play>d__12` (compiler-generated name)
- `CardIdolSequence.<Setup>d__11` (compiler-generated name)
- `CardIdolSequence.CardIdolBindParam`
- `CardIdolSequenceSsr.<>c` (compiler-generated name)
- `CardIdolSequenceSsr.<OnClickedAsync>d__45` (compiler-generated name)
- `CardIdolSequenceSsr.<Play>d__37` (compiler-generated name)
- `CardIdolSequenceSsr.<PlayTitanAnimationLoopAsync>d__38` (compiler-generated name)
- `CardIdolSequenceSsr.<Setup>d__36` (compiler-generated name)
- `CardIdolSequenceSsr.CardIdolSsrBindParam`
- `CardIdolSequenceSsr.MovieType`
- `CardSupportSequence.<>c__DisplayClass26_0` (compiler-generated name)
- `CardSupportSequence.<OnClickedAsync>d__32` (compiler-generated name)
- `CardSupportSequence.<Play>d__27` (compiler-generated name)
- `CardSupportSequence.<Setup>d__26` (compiler-generated name)
- `CardSupportSequence.CardSupportBindParam`
- `CharacterDearnessReportView.<>c` (compiler-generated name)
- `CharacterDearnessReportView.<>c__DisplayClass26_0` (compiler-generated name)
- `CharacterDearnessReportView.<>c__DisplayClass27_0` (compiler-generated name)
- `CharacterDearnessReportView.<>c__DisplayClass30_0` (compiler-generated name)
- `CharacterDearnessReportView.<>c__DisplayClass31_0` (compiler-generated name)
- `CharacterDearnessReportView.<LoadTextureAsync>d__28` (compiler-generated name)
- `CharacterDearnessReportView.<SetDataAndLoadAssetAsync>d__30` (compiler-generated name)
- `ClipData.<>c__DisplayClass5_0` (compiler-generated name)
- `ColorPaint.PaintMode`
- `ColorPaint.PropertyId`
- `Common.Live.CampusLiveCanvasProjection`
- `Common.Live.CampusLiveOverrideAsset`
- `Common.Live.MuteTrackComponentDisableTarget`
- `Common.Live.MuteTrackDisableSetting`
- `Common.Live.OverrideActorHierarchyTransform`
- `Common.Live.OverrideActorMotionClip`
- `Common.Live.OverrideActorMotionTrack`
- `Common.Live.OverrideHierarchyTransforms`
- `Common.Live.OverrideMonitorSprite`
- `Common.TextColorMultiplier`
- `Common.VerticesMultiplier`
- `ContestAnimationClipCollection.<>c` (compiler-generated name)
- `ContestAnimationClipCollection.<>c__DisplayClass2_0` (compiler-generated name)
- `ContestAnimationClipCollection.IgnoreFlag`
- `CrowdAnimator.<>c` (compiler-generated name)
- `CrowdColorPreset.ColorType`
- `CrowdModelData.CrowdVolumeBoneData`
- `CrowdModelData.MeshData`
- `CrowdModelData.SubMeshData`
- `CrowdRendererFeature.Settings`
- `CrowdSystem.EventType`
- `CrowdTimelineTrack.<>c` (compiler-generated name)
- `EnumUtility.EnumCastType`
- `EnumUtility.IntComparer`
- `EnumUtility.NumericComparer`
- `EnvironmentBase.<get_GatherProperties>d__11` (compiler-generated name)
- `EquipmentId.<get_flags>d__18` (compiler-generated name)
- `FadeOutVoicePlayer.<Play>d__1` (compiler-generated name)
- `FasterLinq`
- `FreezeSequenceWrapper.<Play>d__2` (compiler-generated name)
- `GahsaBindUseCase.<>c` (compiler-generated name)
- `GahsaBindUseCase.<Execute>d__1` (compiler-generated name)
- `GahsaBindUseCase.Result`
- `Gasha.Sequences.FreezeSequenceWrapper`
- `Gasha.Sequences.GashaFreezeEffect`
- `Gasha.Sequences.GashaNoneSequence`
- `Gasha.Sequences.IGashaFadeOut`
- `Gasha.Sequences.IGashaFreeze`
- `Gasha.Sequences.SequenceHelper.SequenceBgmHelper`
- `Gasha.Sequences.SequenceHelper.SequenceBindHelper`
- `Gasha.Sequences.SequenceHelper.SequenceNotifyHelper`
- `Gasha.Sequences.SequenceHelper.SequenceParticleHelper`
- `Gasha.Sequences.SequenceHelper.SequencePlayHelper`
- `Gasha.Sequences.SequenceHelper.SequenceSetupHelper`
- `Gasha3DModelMarker.ShowType`
- `GashaAnimationCalculatorV2.<>c` (compiler-generated name)
- `GashaBgmMarker.BgmType`
- `GashaBinder.<Bind>d__1` (compiler-generated name)
- `GashaBinder.BindParams`
- `GashaBuildGraphUseCase.<>c` (compiler-generated name)
- `GashaBuildGraphUseCase.<>c__DisplayClass1_0` (compiler-generated name)
- `GashaCardModel.<>c` (compiler-generated name)
- `GashaCardModel.CardInfo`
- `GashaCardModel.PickupSsrCardInfo`
- `GashaCardReversalUseCase.<>c` (compiler-generated name)
- `GashaFreezeEffect.<Play>d__3` (compiler-generated name)
- `GashaGlobalEffect.<>c__DisplayClass24_0` (compiler-generated name)
- `GashaGlobalEffect.<PlayFreeze>d__19` (compiler-generated name)
- `GashaGlobalEffect.<SetUp>d__12` (compiler-generated name)
- `GashaGlobalEffect.ParticleId`
- `GashaGlobalEffectTitanHandler.<PlayAsync>d__4` (compiler-generated name)
- `GashaHapticMarker.SerializedPower`
- `GashaListSequence.<>c` (compiler-generated name)
- `GashaListSequence.<>c__DisplayClass21_0` (compiler-generated name)
- `GashaListSequence.<>c__DisplayClass21_1` (compiler-generated name)
- `GashaListSequence.<>c__DisplayClass22_0` (compiler-generated name)
- `GashaListSequence.<>c__DisplayClass25_0` (compiler-generated name)
- `GashaListSequence.<OnClickedAsync>d__34` (compiler-generated name)
- `GashaListSequence.<Play>d__22` (compiler-generated name)
- `GashaListSequence.<Setup>d__21` (compiler-generated name)
- `GashaListSequence.LightUpSeKeyValue`
- `GashaListSequence.OverrideRarity`
- `GashaNoneSequence.<Play>d__0` (compiler-generated name)
- `GashaParticleMarker.PlayState`
- `GashaPlayableDirectorHandler.<>c__DisplayClass13_0` (compiler-generated name)
- `GashaPlayableDirectorHandler.<PlayAsync>d__13` (compiler-generated name)
- `GashaPlayableDirectorHandler.Director`
- `GashaPlayableDirectorHandler.IPlayableDirector`
- `GashaPlayer.<PlayAsync>d__11` (compiler-generated name)
- `GashaPlayer.<PlaySequence>d__16` (compiler-generated name)
- `GashaResourceView.<SetAsync>d__4` (compiler-generated name)
- `GashaResourceView.<SetAsync>d__5` (compiler-generated name)
- `GashaSceneModel.<>c__DisplayClass12_0` (compiler-generated name)
- `GashaSequence.<>c` (compiler-generated name)
- `GashaSequence.<Play>d__24` (compiler-generated name)
- `GashaSequence.<Setup>d__23` (compiler-generated name)
- `GashaSequence.GashaSequenceBindParam`
- `GashaSequenceBase.<Setup>d__5` (compiler-generated name)
- `GashaSoundManager.<DownloadAsync>d__6` (compiler-generated name)
- `GashaTimelineController.<Bind>d__20` (compiler-generated name)
- `GashaTimelineController.ActorMotionDefineKeyValue`
- `GashaTimelineController.BindResult`
- `GashaTimelineController.GashaTimelineBindParam`
- `GashaVideoPlayerHandler.<InitializeAsync>d__9` (compiler-generated name)
- `GashaVideoPlayerHandler.<PlayAsync>d__10` (compiler-generated name)
- `GashaVideoPlayerHandler.ABLoopVideoPlayer`
- `GashaVideoPlayerHandler.ABLoopVideoPlayer.<InitializeAsync>d__10` (compiler-generated name)
- `GashaVideoPlayerHandler.CampusVideoPlayer`
- `GashaVideoPlayerHandler.CampusVideoPlayer.<InitializeAsync>d__9` (compiler-generated name)
- `GashaVideoPlayerHandler.IGashaVideoPlayer`
- `GashaVolumetricLight.<>c__DisplayClass13_0` (compiler-generated name)
- `GashaVolumetricLight.GashaVolumetricLightParam`
- `GashaVolumetricLight.RarityTimelineKeyValue`
- `GlobalWindRendererFeature.GlobalWindPass`
- `GraphicMaskBase.PropertyId`
- `GraphicsBurnEffectView.PropertyId`
- `ImageScaler.Direction`
- `KawaseBlur.<>c` (compiler-generated name)
- `LinearGradient.ColorStep`
- `LinearGradient.PropertyId`
- `LinearGradientExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `LinearGradientExtensions.<>c__DisplayClass3_0` (compiler-generated name)
- `LiveDirectionalLight.<get_GatherProperties>d__3` (compiler-generated name)
- `LiveEquipmentController.<>c` (compiler-generated name)
- `LiveLaser.<get_GatherProperties>d__31` (compiler-generated name)
- `LiveLaser.LaserType`
- `LiveLaser.LaserVertexJob`
- `LiveLaser.LightType`
- `LiveLaser.VertexLayout`
- `LiveLightBasic.<get_GatherProperties>d__13` (compiler-generated name)
- `LiveLightComponent.<get_GatherProperties>d__6` (compiler-generated name)
- `LivePanoramaCameraManager.<>c` (compiler-generated name)
- `LivePanoramaCameraManager.<>c__DisplayClass54_0` (compiler-generated name)
- `LivePanoramaCameraManager.<>c__DisplayClass56_0` (compiler-generated name)
- `LivePanoramaCameraManager.<>c__DisplayClass57_0` (compiler-generated name)
- `LivePanoramaCameraManager.<>c__DisplayClass58_0` (compiler-generated name)
- `LivePanoramaCameraManager.<InitializeAsync>d__40` (compiler-generated name)
- `LivePsyllium.<get_GatherProperties>d__2` (compiler-generated name)
- `LoadCharacterDearnessReportTrack.<LoadAsync>d__2` (compiler-generated name)
- `LoadCharacterDearnessReportTrack.<LoadTextureAsync>d__3` (compiler-generated name)
- `LoadCharacterEpisodeReportTrack.<LoadAsync>d__0` (compiler-generated name)
- `LoadCharacterEpisodeReportTrack.<LoadRedPenTextureAsync>d__1` (compiler-generated name)
- `LoadTextureTrack.<LoadAsync>d__0` (compiler-generated name)
- `MaskGpuUtility.GpuData`
- `MaskUtility.ClippingType`
- `MaskUtility.PolygonStride`
- `MaskUtility.UIPolygon`
- `MaskUtility.UIQuad`
- `MaskUtility.UIVertexMini`
- `MaskedHeaderStream.<>c__DisplayClass44_0` (compiler-generated name)
- `MaskedHeaderStream.<ReadAsync>d__42` (compiler-generated name)
- `MaskedHeaderStream.<WriteAsync>d__43` (compiler-generated name)
- `MobAudiencePenlightController.<>c` (compiler-generated name)
- `MobAudiencePenlightController.MobPenlightSetting`
- `MobAudiencePenlightController.RuntimeMobPenlightSetting`
- `MotionDefineGroup.<>c__DisplayClass7_0` (compiler-generated name)
- `PanoramaActorLookAtController.<>c` (compiler-generated name)
- `PanoramaActorLookAtController.<PlayEyeBlinkOnLookAtAsync>d__37` (compiler-generated name)
- `PanoramaActorLookAtController.FocusUpdateReasonType`
- `PenlightMeshRenderSystem.<>c` (compiler-generated name)
- `PhotographyActivityBlockingCinemachine.<>c__DisplayClass23_0` (compiler-generated name)
- `PhotographyActivityController.<>c__DisplayClass22_0` (compiler-generated name)
- `PhotographyActivityController.<GetDofFocalPoint>d__22` (compiler-generated name)
- `PhotographySceneManager.<InitializeAsync>d__29` (compiler-generated name)
- `PhotographySceneManager.<LoadBackgroundAsync>d__31` (compiler-generated name)
- `PhotographySceneManager.<LoadSceneLayoutCollectionAsync>d__30` (compiler-generated name)
- `PhotographySceneManager.<ReleaseAssetsAsync>d__45` (compiler-generated name)
- `PhotographySceneManager.<UnloadBackgroundAsync>d__32` (compiler-generated name)
- `PhotographyScreenSpotData.ActorScreenSpot`
- `PhotographyScreenSpotData.CameraScreenSpot`
- `PointDepthDataRendererFeature.PointDepthDataPass`
- `RectTransformExtensions.<>c__DisplayClass15_0` (compiler-generated name)
- `ResourceUtility.<>c__DisplayClass0_0` (compiler-generated name)
- `RotateRingTrack.<>c__DisplayClass0_0` (compiler-generated name)
- `RoundBorder.PropertyId`
- `SDFGraphic.PropertyId`
- `ScreenOrientationControllerBase.<>c` (compiler-generated name)
- `ScreenOrientationControllerBase.<>c__DisplayClass31_0` (compiler-generated name)
- `ScreenOrientationControllerBase.<>c__DisplayClass35_0` (compiler-generated name)
- `ScreenOrientationControllerBase.<InternalSetOrientationAsync>d__29` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetAutoAfterRotateDeviceAsync>d__35` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetAutoAsync>d__30` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetFixedAsync>d__32` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetFixedLazyAsync>d__39` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetScreenOrientationAsync>d__34` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetStartsWithAsync>d__33` (compiler-generated name)
- `ScreenOrientationControllerBase.<SetStartsWithLazyAsync>d__38` (compiler-generated name)
- `ScreenOrientationControllerBase.OrientationPair`
- `ScreenOrientationManager.<>c__DisplayClass26_0` (compiler-generated name)
- `ScreenOrientationManager.<AfterChangeOrientationAsync>d__26` (compiler-generated name)
- `ScreenOrientationManager.<BeforeChangeOrientationAsync>d__25` (compiler-generated name)
- `SequenceBgmHelper.<>c` (compiler-generated name)
- `SequenceExtensions.<>c` (compiler-generated name)
- `SequenceExtensions.<>c__DisplayClass9_0` (compiler-generated name)
- `SequencePlayHelper.<>c` (compiler-generated name)
- `SequenceSetupHelper.<>c__DisplayClass0_0` (compiler-generated name)
- `SequenceSetupHelper.<DownloadMarkerSeAndBgm>d__1` (compiler-generated name)
- `SequenceSetupHelper.<DownloadVideosInChildren>d__0` (compiler-generated name)
- `SerializableGuid.GuidUtil`
- `SerializableGuid.HashCode`
- `SoundCache.<>c__DisplayClass16_0` (compiler-generated name)
- `SoundCache.<DownloadCueSheetAsync>d__6` (compiler-generated name)
- `SoundCache.<InitializeAsync>d__1` (compiler-generated name)
- `SoundCache.<LoadAcfAsync>d__2` (compiler-generated name)
- `SoundCache.<LoadCueSheetAsync>d__3` (compiler-generated name)
- `SoundEffectTrack.<>c__DisplayClass2_0` (compiler-generated name)
- `SoundEffectTrack.<LoadAsync>d__3` (compiler-generated name)
- `SoundEffectTrack.PlayingWatcher`
- `SoundEffectTrack.PlayingWatcher.<>c` (compiler-generated name)
- `SoundEffectTrack.PlayingWatcher.<>c__DisplayClass10_0` (compiler-generated name)
- `SoundEnum.SoundEffectType`
- `SoundEnum.SoundVolumeType`
- `StandaloneScreenOrientationController.<>c` (compiler-generated name)
- `StandaloneScreenOrientationController.<AdjustScreenResolutionForSetScreenResolutionFallbackAsync>d__13` (compiler-generated name)
- `StandaloneScreenOrientationController.<SetFixedLandscapeAsync>d__10` (compiler-generated name)
- `StandaloneScreenOrientationController.<SetFixedLandscapeLeftAsync>d__11` (compiler-generated name)
- `StandaloneScreenOrientationController.<SetFixedPortraitAsync>d__9` (compiler-generated name)
- `StandaloneScreenOrientationController.<SetStartsWithLandscapeAsync>d__8` (compiler-generated name)
- `StandaloneScreenOrientationController.<SetStartsWithPortraitAsync>d__7` (compiler-generated name)
- `StandaloneScreenOrientationController.<ToggleResolution>d__12` (compiler-generated name)
- `StandaloneScreenOrientationController.Rect`
- `TMProFontManager.<>c` (compiler-generated name)
- `TapToStartSequence.<<OnClickAsync>g__Haptic&#124;29_0>d` (compiler-generated name)
- `TapToStartSequence.<OnClickAsync>d__29` (compiler-generated name)
- `TapToStartSequence.<Play>d__23` (compiler-generated name)
- `TapToStartSequence.<Setup>d__22` (compiler-generated name)
- `TapToStartSequence.TapToStartSequenceBindParam`
- `ThreadPriorityManager.PriorityLayer`
- `Titan.SiblingIndexClip`
- `Titan.SiblingIndexTrack`
- `Titan.SpriteAnimationClip`
- `Titan.SpriteAnimationTrack`
- `Titan.SpriteRendererAnimationClip`
- `Titan.SpriteRendererAnimationTrack`
- `Titan.UITextureOverlayPositionClip`
- `Titan.UITextureOverlayRotationClip`
- `Titan.UITextureOverlayScaleClip`
- `TitanAssetBundleLoader.<LoadAndInstantiateAsync>d__3` (compiler-generated name)
- `TitanAssetBundleLoader.<LoadAndPlayAsync>d__2` (compiler-generated name)
- `TitanAssetBundleLoader.<LoadAsync>d__4` (compiler-generated name)
- `TitanExtensions.<>c__DisplayClass0_0` (compiler-generated name)
- `TitanExtensions.<>c__DisplayClass10_0` (compiler-generated name)
- `TitanExtensions.<>c__DisplayClass6_0` (compiler-generated name)
- `TitanExtensions.<>c__DisplayClass7_0` (compiler-generated name)
- `TitanExtensions.<LoadAllAssetsAsync>d__0` (compiler-generated name)
- `TitanExtensions.<PlayAsync>d__0` (compiler-generated name)
- `TitanExtensions.<PlayAsync>d__1` (compiler-generated name)
- `TitanExtensions.<PlayInternalAsync>d__4` (compiler-generated name)
- `TitanExtensions.<PlayUntilWaitEndMarkerAsync>d__5` (compiler-generated name)
- `TitanExtensions.<PlayUntilWaitEndMarkerAsync>d__6` (compiler-generated name)
- `TitanSeekableInOutPlayer.<>c__DisplayClass9_0` (compiler-generated name)
- `TweenExtensions.<>c__DisplayClass10_0` (compiler-generated name)
- `TweenExtensions.<>c__DisplayClass4_0` (compiler-generated name)
- `TweenExtensions.<>c__DisplayClass8_0` (compiler-generated name)
- `TweenExtensions.<>c__DisplayClass9_0` (compiler-generated name)
- `TweenExtensions.<WaitAsync>d__2` (compiler-generated name)
- `TweenExtensions.<WaitAsync>d__4` (compiler-generated name)
- `TweenExtensions.<WaitWithKillTrueAsync>d__3` (compiler-generated name)
- `UICameraController.<CaptureRequestAsync>d__17` (compiler-generated name)
- `UICameraController.<CaptureRequestAsync>d__18` (compiler-generated name)
- `UIRendererFeature.<>c__DisplayClass19_0` (compiler-generated name)
- `UIRendererManager.<>c` (compiler-generated name)
- `UITextureOverlay.OverlayPivotType`
- `UITextureOverlay.OverlayTransform`
- `UITextureOverlay.PropertyId`
- `UITextureOverlay.ShaderKeyword`
- `UnitBezier.<>c__DisplayClass12_0` (compiler-generated name)
- `UvScale.PropertyId`
- `Vision.Common.UITextureOverlayPositionTrack`
- `Vision.Common.UITextureOverlayRotationTrack`
- `Vision.Common.UITextureOverlayScaleTrack`
- `VolumetricHeightFogVolume.ShaderIDs`
- `__JobReflectionRegistrationOutput__4211293288313638495`
- `uPalette.Generated.ColorEntry`
- `uPalette.Generated.ColorEntryExtensions`
- `uPalette.Generated.ColorTheme`
- `uPalette.Generated.ColorThemeExtensions`

</details>

<details><summary>Mismatching: 2</summary>

- `Campus.Common.Sound.CampusSoundPlayer`

  - `_userData: offset '0xf8' → '0xf0'`
  - `onSoundPlayed: offset '0x100' → '0xf8'`
  - `_acb: offset '0x108' → '0x100'`
  - `_isPreparePlay: offset '0x110' → '0x108'`

- `Campus.Timeline.CampusTimelineCriVideoPlayer`

  - `movieName: offset '0xb8' → '0xc0'`
  - `downloadOnEnable: offset '0xc0' → '0xc8'`
  - `_moviePath: offset '0xc8' → '0xd0'`
  - `_isTimelineClipActive: offset '0xd0' → '0xd8'`
  - `_lastSyncedTimelineTime: offset '0xd8' → '0xe0'`
  - `_lastScrubFrame: offset '0xe0' → '0xe8'`
  - `_scrubTargetFrame: offset '0xe4' → '0xec'`
  - `_scrubLoopRunning: offset '0xe8' → '0xf0'`
  - `_scrubLoopCts: offset '0xf0' → '0xf8'`
  - `_isInteractiveScrubActive: offset '0xf8' → '0x100'`
  - `_movieInfo: offset '0x100' → '0x108'`
  - `IsRecording: offset '0x108' → '0x110'`


</details>

<details><summary>Indeterminate: 40</summary>

- `AnimationEventHandler.CreatedEntry<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.ConstantCurveValueBase<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.LRUCache<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.MaskedHeaderStream`

  - Limitation: _sharedByteBuffer: no comparable storage offset

- `Campus.Common.MaskedHeaderStreamUtility`

  - Limitation: _signatureBuffer: no comparable storage offset

- `Campus.Common.Octo.CampusAssetKeeperBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.Octo.ImageResourceViewBase<TImageAsset, TImageComponent>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.PureSingleton<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.SerializableDictionary<TKey, TValue, Type>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.SerializableKeyAndValue<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.SerializableTuple<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Common.TMPro.TMProTextStyleBase<TTextStyleType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Campus.Live.Equipment.Timeline.LiveEquipmentClipBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CampusAssetKeeperBase.<>c__DisplayClass19_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CampusAssetKeeperBase.<DoLoadAssetAsync>d__19<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CampusAssetKeeperBase.<LoadAssetByAssetNameAsync>d__18<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CampusAssetKeeperBase.<LoadAssetByExAssetNameAsync>d__17<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `EnumUtility.CachedEnumValue.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `EnumUtility.CachedEnumValue<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `EnumUtility.StringUtility`

  - Limitation: _sharedCharaBuffer: no comparable storage offset

- `EnumerableExtensions.<>c__7<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `EnumerableExtensions.CompareSelector<T, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FasterLinq.<>c__DisplayClass4_0<TSource, TMiddle, TResult>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FasterLinq.SelectArray<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `FasterLinq.SelectList<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IObservableExtensions.<>c__0<T1, T2>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IObservableExtensions.<>c__1<T1, T2, T3>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ImageResourceViewBase.<SetAsync>d__11<TImageAsset, TImageComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ImageResourceViewBase.<SetAsync>d__12<TImageAsset, TImageComponent>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LRUCache.<>c<TKey, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LRUCache.Node<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ReactiveCollectionExtensions.<>c__DisplayClass0_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ReusableAssetKeeper.<>c__DisplayClass5_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ReusableAssetKeeper.<LoadAssetAsync>d__5<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SequentialTrackBase.<>c__DisplayClass3_0<TClipAsset, TComponent, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SerializableDictionary.<>c<TKey, TValue, Type>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SerializableDictionary.<>c__DisplayClass11_0<TKey, TValue, Type>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SerializableDictionary.<>c__DisplayClass9_0<TKey, TValue, Type>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.SequentialClipBase<TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Titan.SequentialTrackBase<TClipAsset, TComponent, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=57168`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=57987`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## campus-submodule.Shader.Runtime.dll

<details><summary>Matching: 7</summary>

- `<Module>`
- `Campus.Rendering.Shaders.ShaderVariablesActorLighting`
- `ShaderVariablesActorLighting.<_LightAttenuations>e__FixedBuffer` (compiler-generated name)
- `ShaderVariablesActorLighting.<_LightColors>e__FixedBuffer` (compiler-generated name)
- `ShaderVariablesActorLighting.<_LightData>e__FixedBuffer` (compiler-generated name)
- `ShaderVariablesActorLighting.<_LightDirections>e__FixedBuffer` (compiler-generated name)
- `ShaderVariablesActorLighting.<_LightPositions>e__FixedBuffer` (compiler-generated name)

</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=114`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=58`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## quaunity-crypto.dll

<details><summary>Matching: 1</summary>

- `<Module>`

</details>

<details><summary>Mismatching: 1</summary>

- `Qua.Crypto.AES`

  - `_fastAes: type 'FastAES' → 'object'`


</details>

<details><summary>Indeterminate: 3</summary>

- `Qua.Crypto.Hash`

  - Limitation: _hashCharBuffer: no comparable storage offset

- `Qua.Crypto.MD5`

  - Limitation: _hashAlgorithm: no comparable storage offset

- `Qua.Crypto.SHA256`

  - Limitation: _hashAlgorithm: no comparable storage offset


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=240`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=80`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## quaunity-global.dll

<details><summary>Matching: 15</summary>

- `<Module>`
- `Qua.Global.IFontLoader`
- `Qua.Global.QuaGlobalManager`
- `Qua.Global.QuaGlobalSetting`
- `Qua.Global.QuaGlobalTextMeshProUGUI`
- `Qua.Global.ResourcesFontLoader`
- `QuaGlobalManager.<LoadCorrectFontAsync>d__24` (compiler-generated name)
- `QuaGlobalManager.<LoadFontAsync>d__25` (compiler-generated name)
- `QuaGlobalManager.<LoadFontAsyncInternal>d__26` (compiler-generated name)
- `QuaGlobalManager.FontContainer`
- `QuaGlobalSetting.FontSetting`
- `QuaGlobalTextMeshProUGUI.<Awake>d__4` (compiler-generated name)
- `QuaGlobalTextMeshProUGUI.<ChangedDefaultFontId>d__5` (compiler-generated name)
- `QuaGlobalTextMeshProUGUI.<UpdateFont>d__6` (compiler-generated name)
- `ResourcesFontLoader.<LoadAsync>d__0` (compiler-generated name)

</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=366`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=713`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## quaunity-ui.Runtime.dll

<details><summary>Matching: 229</summary>

- `<Module>`
- `ButtonBase.<>c__DisplayClass23_0` (compiler-generated name)
- `CanvasUtility.CameraComparer`
- `ClippingRectFitter.FitMode`
- `CrossFlickGesture.CrossDirectionData`
- `CustomAnchor.ExecuteType`
- `CustomAnchor.TargetInfo`
- `CustomArcFlickGesture.<>c` (compiler-generated name)
- `DialogPresenterBase.<>c__DisplayClass48_0` (compiler-generated name)
- `DialogPresenterBase.<BackToFrontAsync>d__46` (compiler-generated name)
- `DialogPresenterBase.<CloseAsync>d__42` (compiler-generated name)
- `DialogPresenterBase.<FrontToBackAsync>d__44` (compiler-generated name)
- `DialogPresenterBase.<InitializeAsync>d__37` (compiler-generated name)
- `DialogPresenterBase.<OpenAsync>d__39` (compiler-generated name)
- `DialogPresenterBase.<WaitForCloseAsync>d__48` (compiler-generated name)
- `DialogPresenterBase.State`
- `DoubleClickGesture.StateType`
- `GraphicFlip.DirectionType`
- `GraphicStyleConfig.Style`
- `GridListViewBase.<>c__DisplayClass19_0` (compiler-generated name)
- `ImageBorderGradient.Margins`
- `LineImage.VertexData`
- `ListEnum.CellPositionType`
- `ListEnum.DirectionType`
- `LongTapGesture.<LongTapEnumerator>d__71` (compiler-generated name)
- `LongTapGesture.ClickDetectType`
- `MirrorImage.MirrorEdge`
- `MirrorImage.VertRect`
- `Outline2D.EffectType`
- `Qua.UI.AdjacentOnlySnapToCell`
- `Qua.UI.AndroidBackKeyDirector`
- `Qua.UI.AnimationCurveImage`
- `Qua.UI.BlockingBoardViewBase`
- `Qua.UI.BlockingPresenterBase`
- `Qua.UI.BlockingViewBase`
- `Qua.UI.BoxTouchArea`
- `Qua.UI.ButtonBase`
- `Qua.UI.CanvasUtility`
- `Qua.UI.CircleTouchArea`
- `Qua.UI.ClippingRectFitter`
- `Qua.UI.CondensedText`
- `Qua.UI.CrossFlickDirection`
- `Qua.UI.CrossFlickGesture`
- `Qua.UI.CustomAnchor`
- `Qua.UI.CustomArcFlickDirectionData`
- `Qua.UI.CustomArcFlickGesture`
- `Qua.UI.DialogPresenterBase`
- `Qua.UI.DialogRequestType`
- `Qua.UI.DoubleClickGesture`
- `Qua.UI.DragGesture`
- `Qua.UI.FitToChild`
- `Qua.UI.FlickGestureBase`
- `Qua.UI.FullScreen`
- `Qua.UI.GraphicFlip`
- `Qua.UI.GraphicStyleBase<TGraphicStyleType>`
- `Qua.UI.GraphicStyleConfig`
- `Qua.UI.GraphicStyleTypeBase<T>`
- `Qua.UI.GridListCellArrangementContext`
- `Qua.UI.GridListPresenterBase<TView, TCellPresenter, TItemModel>`
- `Qua.UI.GridListViewBase`
- `Qua.UI.I18n`
- `Qua.UI.I18nConfig`
- `Qua.UI.I18nHelper`
- `Qua.UI.I18nText`
- `Qua.UI.I18nTextAssetReader`
- `Qua.UI.I18nTextAssetReaderBase`
- `Qua.UI.I18nTextBase`
- `Qua.UI.I18nValueConverterBase`
- `Qua.UI.IAndroidBackKeyScenePresenter`
- `Qua.UI.IBlockingPresenter`
- `Qua.UI.IBlockingProvider`
- `Qua.UI.IDefaultStateProvider`
- `Qua.UI.IDialogRequest`
- `Qua.UI.IFlickDirectionData`
- `Qua.UI.II18n`
- `Qua.UI.IListPresenter`
- `Qua.UI.IListPresenter<TCellPresenter, TItemModel>`
- `Qua.UI.IListPresenter<TItemModel>`
- `Qua.UI.IListView`
- `Qua.UI.IQuaParentPresenter`
- `Qua.UI.IQuaSafeArea`
- `Qua.UI.IQuaScreenPresenter`
- `Qua.UI.ITextStyleMask`
- `Qua.UI.ITypicalAnchorManager<TAnchorType>`
- `Qua.UI.IWindowNodePool`
- `Qua.UI.IWindowNodeState`
- `Qua.UI.ImageBorderGradient`
- `Qua.UI.InfiniteListViewBase`
- `Qua.UI.InfiniteSnapListViewBase`
- `Qua.UI.Internal.ActionExtensions`
- `Qua.UI.Internal.AsyncLoadUtility`
- `Qua.UI.Internal.ClassEnum<T>`
- `Qua.UI.Internal.ClassEnumBase`
- `Qua.UI.Internal.ColorSpaceConversion`
- `Qua.UI.Internal.CsvParser`
- `Qua.UI.Internal.CsvWrapper`
- `Qua.UI.Internal.IUIStyle`
- `Qua.UI.Internal.ListUtility`
- `Qua.UI.Internal.MirrorImageUtility`
- `Qua.UI.Internal.PrefabManager`
- `Qua.UI.Internal.QuittingState`
- `Qua.UI.Internal.ScrollAnimationTween`
- `Qua.UI.Internal.ShaderProperties`
- `Qua.UI.Internal.SystemUtility`
- `Qua.UI.Internal.TabPageButtonPair`
- `Qua.UI.Internal.UICrypto`
- `Qua.UI.Internal.UIStyleComponentBase`
- `Qua.UI.Internal.WindowSystemStateUtility`
- `Qua.UI.LineImage`
- `Qua.UI.ListCellPresenterBase<TItemModel>`
- `Qua.UI.ListContentFrontElement`
- `Qua.UI.ListEnum`
- `Qua.UI.ListReusableCellViewBase`
- `Qua.UI.ListViewBase`
- `Qua.UI.LongTapGesture`
- `Qua.UI.MirrorGraphicEffect`
- `Qua.UI.MirrorImage`
- `Qua.UI.MouseButtonType`
- `Qua.UI.MouseButtonTypeExtensions`
- `Qua.UI.Outline2D`
- `Qua.UI.PhysicsShapeRaycastFilter`
- `Qua.UI.QuaGridLayoutGroup`
- `Qua.UI.QuaParentPresenterBase`
- `Qua.UI.QuaSafeArea`
- `Qua.UI.QuaScenePresenterBase`
- `Qua.UI.QuaScrollRect`
- `Qua.UI.QuaUIBehaviour`
- `Qua.UI.QuaWindowNodePool`
- `Qua.UI.RectTransformEventTrigger`
- `Qua.UI.RectTransformModifierBase`
- `Qua.UI.RectUtility`
- `Qua.UI.RemoveDialogRequest`
- `Qua.UI.RotationGesture`
- `Qua.UI.ScaleGesture`
- `Qua.UI.ScreenFitter`
- `Qua.UI.ScreenOrientationChangeWatcher`
- `Qua.UI.ScreenPresenterBase`
- `Qua.UI.ScreenViewBase`
- `Qua.UI.SimpleBlockingBoardPresenter`
- `Qua.UI.SimpleBlockingBoardView`
- `Qua.UI.SimpleBlockingEnum`
- `Qua.UI.SimpleBlockingManager`
- `Qua.UI.SimpleBlockingPresenter`
- `Qua.UI.SimpleBlockingView`
- `Qua.UI.SimpleButton`
- `Qua.UI.SnapListViewBase`
- `Qua.UI.SnapToCell`
- `Qua.UI.TF`
- `Qua.UI.TabButtonBase`
- `Qua.UI.TabPageBase`
- `Qua.UI.TextMeshProUGUIRuby`
- `Qua.UI.TextStyleConfig`
- `Qua.UI.TextStyleConfigStyle`
- `Qua.UI.TextStyleTypeBase<T>`
- `Qua.UI.TouchDrawerUtils`
- `Qua.UI.TouchRectDrawer`
- `Qua.UI.TouchResultDrawer`
- `Qua.UI.TransitionInfo`
- `Qua.UI.TransitionNode`
- `Qua.UI.TransitionOptionalData`
- `Qua.UI.TransitionParam`
- `Qua.UI.TransitionTree`
- `Qua.UI.TransitionTreeSetting`
- `Qua.UI.TypicalAnchor`
- `Qua.UI.TypicalAnchorBase`
- `Qua.UI.TypicalAnchorManager`
- `Qua.UI.UIContentArea`
- `Qua.UI.UICurveEditor`
- `Qua.UI.UICurveHandle`
- `Qua.UI.UICurveKeyframe`
- `Qua.UI.UIDentEffect`
- `Qua.UI.UIEventUtility`
- `Qua.UI.UILineFrame`
- `Qua.UI.UIPartsManager`
- `Qua.UI.UIRootManager`
- `Qua.UI.UIScroll`
- `Qua.UI.WindowNode`
- `Qua.UI.WindowNodeState<T>`
- `Qua.UI.WindowPresenterBase`
- `Qua.UI.WindowViewBase`
- `QuaGridLayoutGroup.Axis`
- `QuaGridLayoutGroup.Constraint`
- `QuaGridLayoutGroup.Corner`
- `QuaParentPresenterBase.<ApplyTransitionAsync>d__4` (compiler-generated name)
- `QuaScenePresenterBase.<InitializeBaseAsync>d__1` (compiler-generated name)
- `RectTransformEventTrigger.RectTransformEvent`
- `ScreenFitter.Padding`
- `ScreenFitter.ScreenOrientationPadding`
- `ScreenPresenterBase.<InitializeBaseAsync>d__4` (compiler-generated name)
- `SimpleBlockingEnum.SimpleBlockingType`
- `SimpleButton.<ColorTintTransitionAsync>d__12` (compiler-generated name)
- `SimpleButton.<DisabledTransitionAsync>d__10` (compiler-generated name)
- `SimpleButton.<PressedTransitionAsync>d__9` (compiler-generated name)
- `TabButtonBase.<CloseAsync>d__5` (compiler-generated name)
- `TabButtonBase.<OpenAsync>d__3` (compiler-generated name)
- `TabPageBase.<CloseAsync>d__6` (compiler-generated name)
- `TabPageBase.<OpenAsync>d__4` (compiler-generated name)
- `TextMeshProUGUIRuby.<>c__DisplayClass54_0` (compiler-generated name)
- `TextMeshProUGUIRuby.<>c__DisplayClass56_0` (compiler-generated name)
- `TextMeshProUGUIRuby.RubyInfo`
- `TouchRectDrawer.<>c` (compiler-generated name)
- `TransitionTreeSetting.Node`
- `TypicalAnchor.AnchorInfo`
- `TypicalAnchor.AnchorType`
- `UICurveEditor.<>c__DisplayClass30_0` (compiler-generated name)
- `UICurveEditor.<>c__DisplayClass33_0` (compiler-generated name)
- `UICurveKeyframe.<>c__DisplayClass19_0` (compiler-generated name)
- `UICurveKeyframe.HandleEdge`
- `UIDentEffect.CornerDents`
- `UILineFrame.CornerData`
- `UILineFrame.CornerType`
- `UILineFrame.CornerUV`
- `UILineFrame.CornerUvType`
- `UIScroll.UpdateType`
- `WindowNode.WindowNodeType`
- `WindowPresenterBase.<ApplyTransitionAsync>d__37` (compiler-generated name)
- `WindowPresenterBase.<CloseChildrenAsync>d__30` (compiler-generated name)
- `WindowPresenterBase.<CreateNodeAsync>d__44` (compiler-generated name)
- `WindowPresenterBase.<GetNodePrefabFromStateAsync>d__45` (compiler-generated name)
- `WindowPresenterBase.<InitializeBaseAsync>d__18` (compiler-generated name)
- `WindowPresenterBase.<OnBehindCloseAsync>d__23` (compiler-generated name)
- `WindowPresenterBase.<OnCloseInAsync>d__20` (compiler-generated name)
- `WindowPresenterBase.<OnCloseOutAsync>d__22` (compiler-generated name)
- `WindowPresenterBase.<OnOpenOutAsync>d__19` (compiler-generated name)
- `WindowPresenterBase.<OpenChildAsync>d__39` (compiler-generated name)
- `WindowPresenterBase.<OpenNodeAsync>d__38` (compiler-generated name)
- `WindowPresenterBase.<OpenTreeAsync>d__24` (compiler-generated name)
- `WindowPresenterBase.<PreparePoolAsync>d__36` (compiler-generated name)
- `WindowPresenterBase.<SwitchAsync>d__33` (compiler-generated name)

</details>

<details><summary>Indeterminate: 69</summary>

- `AsyncLoadUtility.<LoadAssetAsync>d__0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass14_0.<<OpenDialogAsync>b__1>d<TDialogId, TDialog>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass14_0<TDialogId, TDialog>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass16_0.<<CloseAllDialogAsync>b__0>d<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass16_0<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass17_0<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<>c__DisplayClass19_0<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<CloseAllDialogAsync>d__16<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<ExecuteRequestAsync>d__23<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<InitializeBlockingObjectAsync>d__24<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<OpenDialogAsync>d__14<TDialogId, TDialog>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<OpenDialogAsync>d__15<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<OpenNewDialogAsync>d__31<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<PrevDialogBackToFrontAsync>d__32<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<RemoveDialogAsync>d__21<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DialogManagerBase.<SafeCloseDialogAsync>d__17<TDialogId>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicTabBase.<>c__DisplayClass2_0.<<BuildTabsAsync>b__0>d<TTabElement, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicTabBase.<>c__DisplayClass2_0<TTabElement, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicTabBase.<>c__DisplayClass2_1<TTabElement, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicTabBase.<AddTabAsync>d__3<TTabElement, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicTabBase.<BuildTabsAsync>d__2<TTabElement, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GenericTabButtonBase.<InitializeAsync>d__4<TTabItem>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GenericTabPageBase.<InitializeAsync>d__4<TTabItem>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GridListPresenterBase.<>c__DisplayClass2_0.<<GetSortedTargetCellTable>g__GetOtherCells&#124;0>d<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GridListPresenterBase.<>c__DisplayClass2_0<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GridListPresenterBase.<GetSortedTargetCellTable>d__2<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `InfiniteListPresenterBase.<InitializeAsync>d__1<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `InfiniteSnapListPresenterBase.<InitializeAsync>d__10<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ListPresenterBase.<GetSortedTargetCells>d__51<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ListPresenterBase.<InitializeAsync>d__39<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ListReusableCellPresenterBase.<SelfInitializeAsync>d__6<TCellView, TCellModel, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PrefabManager.<LoadPrefabAsync>d__1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.BlockingBoardPresenterBase<TBlockingBoardView>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.BlockingManagerBase<TBlockingManager, TBlockingType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.BlockingPresenterBase<TView, TBoardPresenter, TBoardView>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.DialogManagerBase<TDialogId>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.DialogPresenterBase<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.DynamicTabBase<TTabElement, TTabButton, TTabPage>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.GenericTabButtonBase<TTabItem>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.GenericTabPageBase<TTabItem>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.InfiniteListPresenterBase<TView, TCellPresenter, TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.InfiniteSnapListPresenterBase<TView, TCellPresenter, TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.Internal.UIStyleComponentBase<TComponent, TStyleType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.Internal.UIStyleConfigBase<T, TStyle>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.ListPresenterBase<TView, TCellPresenter, TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.ListReusableCellModelBase<TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.ListReusableCellPresenterBase<TCellView, TCellModel, TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.OpenDialogRequest<TDialogId>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.QuaScreenPresenterBase<TView, TTransitionParam>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.QuaWindowPresenterBase<TView, TTransitionParam>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.ScreenStateBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.SnapListPresenterBase<TView, TCellPresenter, TItemModel>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.StaticTabBase<T, TTabButton, TTabPage>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TabBase<TTabButton, TTabPage>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TextStyleBase<TTextStyleType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TextStyleConfigBase<T, TStyle>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TouchDrawerManagerBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TypicalAnchorBase<TAnchorType, TAnchorInfo>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.TypicalAnchorManagerBase<T, TAnchorType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Qua.UI.WindowStateBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `QuaScreenPresenterBase.<InitializeBaseAsync>d__2<TView, TTransitionParam>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `QuaWindowPresenterBase.<InitializeBaseAsync>d__1<TView, TTransitionParam>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SnapListPresenterBase.<InitializeAsync>d__9<TView, TCellPresenter, TItemModel>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StaticTabBase.<>c__DisplayClass2_0<T, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StaticTabBase.<InitializeAsync>d__1<T, TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TabBase.<OpenByIndexAsync>d__4<TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TabBase.<OpenTabInternalAsync>d__13<TTabButton, TTabPage>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TabBase.TabData<TTabButton, TTabPage>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TypicalAnchorBase.AnchorInfoBase<TAnchorType, TAnchorInfo>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10904`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12955`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## quaunity-volumetriclightbeam.Runtime.dll

<details><summary>Matching: 138</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `BeamGeometrySD.<CoUpdateFadeOut>d__26` (compiler-generated name)
- `Consts.Beam`
- `Consts.Beam.HD`
- `Consts.Beam.SD`
- `Consts.Cookie`
- `Consts.DustParticles`
- `Consts.DynOcclusion`
- `Consts.Effects`
- `Consts.Internal`
- `Consts.Shadow`
- `DynamicOcclusionAbstractBase.ProcessOcclusionSource`
- `DynamicOcclusionDepthBuffer.<>c` (compiler-generated name)
- `DynamicOcclusionRaycasting.HitResult`
- `EffectAbstractBase.ComponentsToChange`
- `EffectFlicker.<CoChangeIntensity>d__12` (compiler-generated name)
- `EffectFlicker.<CoFlicker>d__11` (compiler-generated name)
- `EffectFlicker.<CoUpdate>d__10` (compiler-generated name)
- `EffectPulse.<CoUpdate>d__4` (compiler-generated name)
- `EntityIndexer.EntityItem`
- `MaterialManager.BlendingMode`
- `MaterialManager.ColorGradient`
- `MaterialManager.HD`
- `MaterialManager.HD.Attenuation`
- `MaterialManager.HD.Cookie`
- `MaterialManager.HD.Shadow`
- `MaterialManager.IStaticProperties`
- `MaterialManager.MaterialsGroup`
- `MaterialManager.Noise3D`
- `MaterialManager.SD`
- `MaterialManager.SD.DepthBlend`
- `MaterialManager.SD.DynamicOcclusion`
- `MaterialManager.SD.MeshSkewing`
- `MaterialManager.SD.ShaderAccuracy`
- `MaterialManager.StaticPropertiesHD`
- `MaterialManager.StaticPropertiesSD`
- `MaterialModifier.Callback`
- `MaterialModifier.Interface`
- `MeshGenerator.<>c__DisplayClass6_0` (compiler-generated name)
- `MeshGenerator.<>c__DisplayClass6_1` (compiler-generated name)
- `PolygonHelper.Plane2D`
- `ShaderKeywords.HD`
- `ShaderProperties.HD`
- `ShaderProperties.SD`
- `SkewingHandleSD.<CoUpdate>d__9` (compiler-generated name)
- `TransformUtils.Packed`
- `TriggerZone.TriggerZoneUpdateRate`
- `Utils.FloatPackingPrecision`
- `VLB.AttenuationEquation`
- `VLB.AttenuationEquationHD`
- `VLB.BatchingHelper`
- `VLB.BeamGeometryAbstractBase`
- `VLB.BeamGeometryHD`
- `VLB.BeamGeometrySD`
- `VLB.BlendingMode`
- `VLB.Chunk`
- `VLB.ColorMode`
- `VLB.Config`
- `VLB.Consts`
- `VLB.CookieChannel`
- `VLB.CullingJob`
- `VLB.Dimensions`
- `VLB.DirtyProps`
- `VLB.DynamicOcclusionAbstractBase`
- `VLB.DynamicOcclusionDepthBuffer`
- `VLB.DynamicOcclusionRaycasting`
- `VLB.DynamicOcclusionUpdateRate`
- `VLB.EffectAbstractBase`
- `VLB.EffectFlicker`
- `VLB.EffectPulse`
- `VLB.Entity`
- `VLB.EntityIndexer`
- `VLB.FeatureEnabledColorGradient`
- `VLB.GlobalMeshHD`
- `VLB.GlobalMeshSD`
- `VLB.HighlightNullAttribute`
- `VLB.InitializeCullJob`
- `VLB.MaterialManager`
- `VLB.MaterialModifier`
- `VLB.MeshGenerator`
- `VLB.MeshType`
- `VLB.MinMaxRangeAttribute`
- `VLB.MinMaxRangeFloat`
- `VLB.Noise3D`
- `VLB.NoiseMode`
- `VLB.ParticlesDirection`
- `VLB.PlaneAlignment`
- `VLB.PlatformHelper`
- `VLB.PolygonHelper`
- `VLB.RaymarchingQuality`
- `VLB.RenderPipeline`
- `VLB.RenderingMode`
- `VLB.SRPHelper`
- `VLB.ShaderAccuracy`
- `VLB.ShaderKeywords`
- `VLB.ShaderMode`
- `VLB.ShaderProperties`
- `VLB.ShadowUpdateRate`
- `VLB.SharedVLBEntityManager`
- `VLB.SkewingHandleSD`
- `VLB.SpotLightHelper`
- `VLB.SubDrawCall`
- `VLB.TrackRealtimeChangesOnLightHD`
- `VLB.TransformUtils`
- `VLB.TriggerZone`
- `VLB.Utils`
- `VLB.UtilsBeamProps`
- `VLB.VLBCachedChunk`
- `VLB.VLBCulledChunk`
- `VLB.VLBCullingSystem`
- `VLB.VLBDrawCallChunk`
- `VLB.VLBDrawCallSystem`
- `VLB.VLBDrawSystem`
- `VLB.VLBEntityChunk`
- `VLB.VLBEntityManager`
- `VLB.VLBUpdateCachedSystem`
- `VLB.VolumetricCookieHD`
- `VLB.VolumetricDustParticles`
- `VLB.VolumetricLightBeamAbstractBase`
- `VLB.VolumetricLightBeamHD`
- `VLB.VolumetricLightBeamHD2D`
- `VLB.VolumetricLightBeamSD`
- `VLB.VolumetricShadowHD`
- `VLBDrawCallSystem.DrawCallJob`
- `VLBEntityManager.<>c` (compiler-generated name)
- `VLBEntityManager.CombinedChunks`
- `VLBUpdateCachedSystem.UpdateTransformsJob`
- `VolumetricDustParticles.<>c` (compiler-generated name)
- `VolumetricLightBeamAbstractBase.AttachedLightType`
- `VolumetricLightBeamSD.<CoPlaytimeUpdate>d__221` (compiler-generated name)
- `VolumetricLightBeamSD.OnBeamGeometryInitialized`
- `VolumetricLightBeamSD.OnWillCameraRenderCB`
- `VolumetricLightBeamSD.VolumetricLightBeamAction`
- `VolumetricShadowHD.<>c` (compiler-generated name)
- `VolumetricShadowHD.ProcessOcclusionSource`
- `__JobReflectionRegistrationOutput__13854810216981216507`

</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=2977`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=4987`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## vl-unity.Runtime.dll

<details><summary>Matching: 321</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `ActorExpressionSymbol.Method`
- `ActorShadowPass.<>c__DisplayClass33_0` (compiler-generated name)
- `ActorShadowPass.ActorShadowData`
- `ActorShadowPass.GetBoundsEvent`
- `AnimationPlayerBase.<>c__DisplayClass12_0` (compiler-generated name)
- `AnimationPlayerBase.<>c__DisplayClass13_0` (compiler-generated name)
- `AnimationPlayerBase.<>c__DisplayClass14_0` (compiler-generated name)
- `DownscalePass.SSAOBlurTypes`
- `DownscalePass.SSAOShaderPasses`
- `DownscaleSystemRendererFeature.Settings`
- `DownscaleTransparentPass.<>c` (compiler-generated name)
- `DrawActorShadowPass.Settings`
- `DrawMultiCameraPass.Settings`
- `DrawUIBlurPass.Settings`
- `DrawVLActor.Settings`
- `FullBodyIKJob.BodyEffectorHandle`
- `FullBodyIKJob.EffectorHandle`
- `FullBodyIKJob.HintEffectorHandle`
- `FullBodyIKJob.IKLimbHandle`
- `FullBodyIKJob.LimbPart`
- `FullBodyIKJob.LookEffectorHandle`
- `FullBodyIKJob.MoveHandle`
- `JobUtility.Array2DInfo`
- `LayerController.<WaitForCompletionAsync>d__12` (compiler-generated name)
- `LispParser.ParseMode`
- `MotionDefine.MotionDefineEnumerator`
- `MotionDefinePlayerTimelineTrack.<>c` (compiler-generated name)
- `MotionDefinePlayerTimelineTrack.<>c__DisplayClass2_0` (compiler-generated name)
- `MotionDefinePlayerTimelineTrack.<>c__DisplayClass3_0` (compiler-generated name)
- `MotionTimelinePlayable.<>c` (compiler-generated name)
- `UIBlurPass.BlurTargetType`
- `VL.AABB.AABBCalcJob`
- `VL.AABB.AABBData`
- `VL.AABB.AABBJobData`
- `VL.AABB.AABBPositionJob`
- `VL.AABB.AABBUtility`
- `VL.ActorMesh.CombineMeshJob`
- `VL.ActorMesh.VLActorSkinningModel`
- `VL.ActorMesh.VLActorSkinningSystem`
- `VL.ActorMesh.VertexLayoutStream1`
- `VL.ActorMotionDefine`
- `VL.Animation.AnimationPlayerBase`
- `VL.Animation.ClipEvent`
- `VL.Animation.ClipParam`
- `VL.Animation.EffectData`
- `VL.Animation.IAnimationController`
- `VL.Animation.IAnimationPlayer`
- `VL.Animation.ILayerAnimationController`
- `VL.Animation.IMotionDefinePlayer`
- `VL.Animation.IMotionDefinePlayerEvent`
- `VL.Animation.LayerController`
- `VL.Animation.LayerParam`
- `VL.Animation.Legacy.IVLAnimationClipPlayer`
- `VL.Animation.Legacy.IVLAnimationPlayerController`
- `VL.Animation.Legacy.VLAnimationClipParam`
- `VL.Animation.Legacy.VLAnimationClipParamEvent`
- `VL.Animation.Legacy.VLAnimationClipParamMixerPlayable`
- `VL.Animation.Legacy.VLAnimationClipPlayer`
- `VL.Animation.Legacy.VLAnimationClipPlayerParam`
- `VL.Animation.Legacy.VLAnimationClipPlayerParamEvent`
- `VL.Animation.Legacy.VLAnimationClipPlayerParamObject`
- `VL.Animation.Legacy.VLAnimationPlayerController`
- `VL.Animation.MotionClipPlayable`
- `VL.Animation.MotionDefinePlayer`
- `VL.Animation.MotionEffectPlayable`
- `VL.Animation.MotionLayerMixerPlayable`
- `VL.Animation.MotionLayerPlayable`
- `VL.Animation.MotionPrefabEffectPlayable`
- `VL.Animation.MotionTimelinePlayable`
- `VL.Animation.OnDisconnectRootPlayable`
- `VL.Animation.OnInsertRootPlayable`
- `VL.Animation.OutputType`
- `VL.Animation.PrefabControlPlayable`
- `VL.Animation.PrepareFrameEvent`
- `VL.Animation.RootPlayableData`
- `VL.Animation.Timeline.MotionDefinePlayerTimelineAsset`
- `VL.Animation.Timeline.MotionDefinePlayerTimelineTrack`
- `VL.Animation.Timeline.MotionDefinePlayerTimelineTrackLayerBehaviour`
- `VL.AnimationBindingData`
- `VL.AnimationCurveData`
- `VL.AnimationCurveEvaluator`
- `VL.AnimationData`
- `VL.Core.BlendShapeBindVertexData`
- `VL.Core.BlendShapeData`
- `VL.Core.BlendShapeLayout`
- `VL.Core.BlendShapeWeight`
- `VL.Core.BlendShapeWeight16`
- `VL.Core.BoneLinkData`
- `VL.Core.BoneNameToTransformDictionary`
- `VL.Core.ChildMapDictionary`
- `VL.Core.DefaultBoneInfo`
- `VL.Core.HumanBodyBoneMapDictionary`
- `VL.Core.InstanceIDToDefaultBoneInfoIndexDictionary`
- `VL.Core.MaterialInfo`
- `VL.Core.PartsIdMapDictionary`
- `VL.Core.UpdateBlendShapeBindVertexJob`
- `VL.Core.VLActorController`
- `VL.Core.VLActorDescriptor`
- `VL.Core.VLActorModelParts`
- `VL.Core.VLActorModelParts<TDescriptor>`
- `VL.CurveConversion`
- `VL.CustomClip`
- `VL.DefaultAnimationData`
- `VL.Ease.EaseFunction`
- `VL.Ease.EaseFunctions`
- `VL.Ease.EaseType`
- `VL.FaceSystem.VLActorFaceBindVertex`
- `VL.FaceSystem.VLActorFaceModel`
- `VL.IK.CustomLookAtEffector`
- `VL.IK.EffectorBase`
- `VL.IK.FullBodyIKJob`
- `VL.IK.IKBodyEffector`
- `VL.IK.IKGoalEffector`
- `VL.IK.IKHintEffector`
- `VL.IK.LookAtEffector`
- `VL.IVLActorController`
- `VL.IVLActorController<IDescriptor>`
- `VL.IVLActorDescriptor`
- `VL.IVLActorTalk`
- `VL.IVLActorTalkFFT<T>`
- `VL.IVLCameraController`
- `VL.IVLDefaultActorController`
- `VL.IVLDefaultActorController<TIDescriptor>`
- `VL.IVLDefaultActorDescriptor`
- `VL.IVLTransform`
- `VL.JobUtility`
- `VL.KeyframeData`
- `VL.LimitedLisp.Argument`
- `VL.LimitedLisp.ISymbol<T>`
- `VL.LimitedLisp.LispParser`
- `VL.MotionDefine`
- `VL.MotionDefinePlayable`
- `VL.MotionEffectBase`
- `VL.MotionPrefabEffect`
- `VL.Preset.Layout`
- `VL.Preset.PresetActorDescriptor`
- `VL.Preset.PresetFile`
- `VL.Preset.PresetModelData`
- `VL.Preset.PresetModelMotionData`
- `VL.Preset.VLAssetPresetBase`
- `VL.Preset.VLAssetPresetModelMotion`
- `VL.Preset.VLLayoutPreset`
- `VL.Preset.VLLayoutPresetBase`
- `VL.PropConstraintData`
- `VL.Rendering.ActorShadowPass`
- `VL.Rendering.DownscaleApplyPass`
- `VL.Rendering.DownscaleBuffers`
- `VL.Rendering.DownscalePass`
- `VL.Rendering.DownscaleSystemData`
- `VL.Rendering.DownscaleSystemRendererFeature`
- `VL.Rendering.DownscaleTransparentPass`
- `VL.Rendering.DrawActorShadowPass`
- `VL.Rendering.DrawMultiCameraPass`
- `VL.Rendering.DrawRenderTargetBlurPass`
- `VL.Rendering.DrawUIBlurPass`
- `VL.Rendering.DrawVLActor`
- `VL.Rendering.MultiCameraMaskPass`
- `VL.Rendering.MultiCameraPass`
- `VL.Rendering.RenderTargetBlurPass`
- `VL.Rendering.Skinning.BlendShapeInfo`
- `VL.Rendering.Skinning.ISkinning`
- `VL.Rendering.Skinning.IStream0`
- `VL.Rendering.Skinning.Skinning4`
- `VL.Rendering.Skinning.UpdateMatricesJob`
- `VL.Rendering.Skinning.VLSkinningModel`
- `VL.Rendering.Skinning.VertexLayoutStream2`
- `VL.Rendering.Skinning.VertexLayoutStreamPNT`
- `VL.Rendering.UIBlurPass`
- `VL.Rendering.VLActorShadow`
- `VL.Rendering.VLActorShadowDirectionalType`
- `VL.Rendering.VLActorShadowDirectionalTypeParameter`
- `VL.Rendering.VLMultiCamera`
- `VL.Rendering.VLSRPCameraController`
- `VL.Rendering.VLSRPDrawUIBlurPassSetting`
- `VL.Rendering.VLSRPRenderTargetBlur`
- `VL.Rendering.VLSRPTargetImage`
- `VL.ShaderIDs`
- `VL.ShaderKeywords`
- `VL.Subsystems.VLSubsystem`
- `VL.Subsystems.VLSubsystemRegistration`
- `VL.Timeline.Legacy.VLAnimationClipPlayerTimelineAsset`
- `VL.Timeline.Legacy.VLAnimationClipPlayerTimelineClipPlayable`
- `VL.Timeline.Legacy.VLAnimationClipPlayerTimelineMixerPlayable`
- `VL.Timeline.Legacy.VLAnimationClipPlayerTimelineTrack`
- `VL.Timeline.Legacy.VLAnimationClipPlayerTimelineTrackPlayable`
- `VL.Timeline.VLActorAnimationManagePropertyDataApplyMarker`
- `VL.Timeline.VLActorMotionResetMarker`
- `VL.Timeline.VLTimelineController`
- `VL.Unsafe.Jobs.ActorExpressionSymbol`
- `VL.Unsafe.Jobs.ActorExpressionSymbolEnumerator`
- `VL.Unsafe.Jobs.ExpressionData`
- `VL.Unsafe.Jobs.MuscleExpressionData`
- `VL.Unsafe.Jobs.RigFurisodeData`
- `VL.Unsafe.Jobs.TalkBlendShapeJobData`
- `VL.Unsafe.Jobs.TalkCurveJobData`
- `VL.Unsafe.Jobs.TalkJobData`
- `VL.Unsafe.Jobs.TalkTargetJobData`
- `VL.Unsafe.Jobs.VLActorExpressionJob`
- `VL.Unsafe.Jobs.VLActorRigFurisodeJob`
- `VL.Unsafe.Jobs.VLActorTalkJob`
- `VL.VLActorAABBCalcType`
- `VL.VLActorAO`
- `VL.VLActorBlendShapeIndexLimitData`
- `VL.VLActorBlendShapeLimitDataRuntime`
- `VL.VLActorBodyAdditiveAnimation`
- `VL.VLActorBodyType`
- `VL.VLActorCollider`
- `VL.VLActorColliderType`
- `VL.VLActorDefine`
- `VL.VLActorExpression`
- `VL.VLActorExpressionBone`
- `VL.VLActorExpressionUtility`
- `VL.VLActorExtension`
- `VL.VLActorEyeBlinkData`
- `VL.VLActorEyeBlinkDataRuntime`
- `VL.VLActorEyeHighlight`
- `VL.VLActorFaceBehaviour`
- `VL.VLActorFaceClip`
- `VL.VLActorFaceModelBlendShapeLimitDataRuntime`
- `VL.VLActorFaceModelEyeBlinkDataRuntime`
- `VL.VLActorFaceTargetCorrection`
- `VL.VLActorFacialLimitData`
- `VL.VLActorFacialSystem`
- `VL.VLActorFullBodyIK`
- `VL.VLActorPropFixConstraint`
- `VL.VLActorRaycastHit`
- `VL.VLActorRig`
- `VL.VLActorRigBone`
- `VL.VLActorRigFurisodeBone`
- `VL.VLActorSettings`
- `VL.VLActorShadowGroup`
- `VL.VLActorTalk`
- `VL.VLActorTalkData`
- `VL.VLActorTalkFFT`
- `VL.VLCameraController`
- `VL.VLCameraControllerSingleton<T>`
- `VL.VLCinemachineFocusPoint`
- `VL.VLDefaultActorController`
- `VL.VLDefaultActorDescriptor`
- `VL.VLDefaultActorManager`
- `VL.VLDefaultActorModelParts`
- `VL.VLDefaultActorModelParts<TDescriptor>`
- `VL.VLExtension`
- `VL.VLGyro`
- `VL.VLMath`
- `VL.VLMeshUtility`
- `VL.VLOutline`
- `VL.VLPrefabActorController`
- `VL.VLTalkMotionSelector`
- `VL.VLUtility`
- `VL.VLVirtualActorController`
- `VLActorAO.CapsuleData`
- `VLActorAO.UpdateJob`
- `VLActorCollider.<>c__DisplayClass6_0` (compiler-generated name)
- `VLActorController.<>c` (compiler-generated name)
- `VLActorExpressionBone.AxisData`
- `VLActorExpressionBone.AxisMaskType`
- `VLActorExpressionBone.AxisType`
- `VLActorExpressionBone.CalcType`
- `VLActorExpressionBone.TransformType`
- `VLActorEyeBlinkData.BlinkData`
- `VLActorEyeBlinkData.LimitData`
- `VLActorEyeHighlight.LimitData`
- `VLActorFaceBehaviour.FaceJob`
- `VLActorFaceClip.BindData`
- `VLActorFaceClip.BindType`
- `VLActorFaceModel.<>c` (compiler-generated name)
- `VLActorFaceTargetCorrection.FaceModelAngleTarget`
- `VLActorFaceTargetCorrection.IAngleTarget`
- `VLActorFaceTargetCorrection.SkinnedMeshAngleTarget`
- `VLActorFacialLimitData.BlendShapeData`
- `VLActorFacialLimitData.LimitData`
- `VLActorFacialSystem.<>c` (compiler-generated name)
- `VLActorFacialSystem.<>c__DisplayClass29_0` (compiler-generated name)
- `VLActorFacialSystem.<>c__DisplayClass30_0` (compiler-generated name)
- `VLActorFacialSystem.<>c__DisplayClass30_1` (compiler-generated name)
- `VLActorFacialSystem.<>c__DisplayClass36_0` (compiler-generated name)
- `VLActorFacialSystem.<>c__DisplayClass37_0` (compiler-generated name)
- `VLActorFacialSystem.BlinkState`
- `VLActorRig.<>c` (compiler-generated name)
- `VLActorRigFurisodeBone.VLActorRigFurisodeConnection`
- `VLActorRigFurisodeBone.VLActorRigReferenceAxis`
- `VLActorRigFurisodeBone.VLActorRigReferenceBone`
- `VLActorTalkData.TalkAdditiveBinding`
- `VLActorTalkData.TalkAdditiveData`
- `VLActorTalkData.TalkAdditiveType`
- `VLActorTalkData.TalkBlend`
- `VLActorTalkData.TalkCurve`
- `VLActorTalkData.TalkData`
- `VLAnimationClipParamMixerPlayable.LayerPlayables`
- `VLAnimationClipParamMixerPlayable.PlayEvent`
- `VLAnimationClipParamMixerPlayable.PrepareFrameEvent`
- `VLAnimationClipPlayer.<PlayCoroutine>d__40` (compiler-generated name)
- `VLAnimationClipPlayerParam.LayerParam`
- `VLAnimationPlayerController.<WaitForCompletionAsync>d__31` (compiler-generated name)
- `VLCinemachineFocusPoint.VcamFocusPointState`
- `VLGyro.<Initialize>d__41` (compiler-generated name)
- `VLGyro.RotationAxes`
- `VLGyro.UpdateType`
- `VLMultiCamera.MultiCameraData`
- `VLPrefabActorController.<>c__DisplayClass8_0` (compiler-generated name)
- `VLPrefabActorController.PrefabParts`
- `VLSRPCameraController.CameraAction`
- `VLSRPRenderTargetBlur.BlurRequest`
- `VLSRPTargetImage.TextureType`
- `VLSubsystemRegistration.<>c__DisplayClass3_0` (compiler-generated name)
- `VLSubsystemRegistration.VLBeforeRendering`
- `VLSubsystemRegistration.VLLastLateUpdate`
- `VLTimelineController.BindAction`
- `VLTimelineController.ReferenceBindParam`
- `VLVirtualActorController.<>c__DisplayClass14_0` (compiler-generated name)
- `VLVirtualActorController.BindData`
- `VLVirtualActorController.BoneResult`
- `VLVirtualActorController.ErrorResult`
- `VLVirtualActorController.IBindResult`
- `__JobReflectionRegistrationOutput__13641028655596313253`

</details>

<details><summary>Indeterminate: 17</summary>

- `VL.Core.SerializedDictionary<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Core.VLActorController<TModelParts, TDescriptor, TIDescriptor>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Core.VLActorManager<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Core.VLMonoBehaviourSingleton<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Rendering.Skinning.BlendShapeJob<TStream0>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Rendering.Skinning.CopyJob<TStream0>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Rendering.Skinning.SkinningJob<TStream0, TSkinning>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.Rendering.Skinning.VLSkinningSystem<TStream0, TSkinning>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.VLActorTalkBase<TActorTalkFFT, TAudioSource>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.VLActorTalkFFTBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.VLDefaultActorController<TModelParts, TDescriptor, TIDescriptor>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.VLDefaultActorManager<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VL.VLVirtualActorController<TController>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VLActorManager.<>c<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VLDefaultActorController.<>c<TModelParts, TDescriptor, TIDescriptor>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VLDefaultActorManager.<>c<TManager, TController, TIController, TModelParts, TDescriptor, TIDescriptor>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VLSkinningSystem.<>c<TStream0, TSkinning>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 9</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=11348`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=16447`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`
- `VL.Rendering.VLRenderingCompatibility`

</details>

