# IL2CPP field layout comparison

Original: `/data/xy/gakumas/work/il2cpp-3.5.3/dump.cs`
SHA-256: `4bdd8715472c84f81f895f2fb373c724c787da3afc7a0c5b1e539a04c4387c46`

Build: `/data/xy/gakumas/live-urp/.recon/live-dump/dump.cs`
SHA-256: `b78cea3e9774d581a7596233125bfb7ff8d03a4dc528c337c0432056cb69821f`

Assembly selection: `^(?:ActorAnimation\.Runtime\.dll&#124;AmplifyOcclusion\.Runtime\.dll&#124;Cinemachine\.dll&#124;CriMw\.CriWare\.Runtime\.dll&#124;DOTween\.dll&#124;Mono\.Security\.dll&#124;Octo\.dll&#124;ProFlare\.Runtime\.dll&#124;Qua\.Base\.Runtime\.dll&#124;Qua\.PolygonUtility\.dll&#124;Qua\.Utility\.dll&#124;Qua\.VectorUI\.Runtime\.dll&#124;System\.Configuration\.dll&#124;System\.Core\.dll&#124;System\.Xml\.dll&#124;System\.dll&#124;Titan\.Runtime\.dll&#124;Uguiss\-Timeline\.Runtime\.dll&#124;Uguiss\.Runtime\.dll&#124;UniRx\.dll&#124;UniTask\.Linq\.dll&#124;UniTask\.dll&#124;Unity\.Animation\.Rigging\.dll&#124;Unity\.Burst\.Unsafe\.dll&#124;Unity\.Burst\.dll&#124;Unity\.Collections\.LowLevel\.ILSupport\.dll&#124;Unity\.Collections\.dll&#124;Unity\.Mathematics\.dll&#124;Unity\.Profiling\.Core\.dll&#124;Unity\.RenderPipeline\.Universal\.ShaderLibrary\.dll&#124;Unity\.RenderPipelines\.Core\.Runtime\.dll&#124;Unity\.RenderPipelines\.Universal\.Runtime\.dll&#124;Unity\.TextMeshPro\.dll&#124;Unity\.Timeline\.dll&#124;Unity\.VisualEffectGraph\.Runtime\.dll&#124;UnityEngine\.AIModule\.dll&#124;UnityEngine\.AndroidJNIModule\.dll&#124;UnityEngine\.AnimationModule\.dll&#124;UnityEngine\.AssetBundleModule\.dll&#124;UnityEngine\.AudioModule\.dll&#124;UnityEngine\.CoreModule\.dll&#124;UnityEngine\.DirectorModule\.dll&#124;UnityEngine\.GridModule\.dll&#124;UnityEngine\.HierarchyCoreModule\.dll&#124;UnityEngine\.IMGUIModule\.dll&#124;UnityEngine\.InputForUIModule\.dll&#124;UnityEngine\.InputLegacyModule\.dll&#124;UnityEngine\.InputModule\.dll&#124;UnityEngine\.ParticleSystemModule\.dll&#124;UnityEngine\.Physics2DModule\.dll&#124;UnityEngine\.PhysicsModule\.dll&#124;UnityEngine\.PropertiesModule\.dll&#124;UnityEngine\.SharedInternalsModule\.dll&#124;UnityEngine\.SpriteShapeModule\.dll&#124;UnityEngine\.SubsystemsModule\.dll&#124;UnityEngine\.TerrainModule\.dll&#124;UnityEngine\.TextCoreFontEngineModule\.dll&#124;UnityEngine\.TextCoreTextEngineModule\.dll&#124;UnityEngine\.TextRenderingModule\.dll&#124;UnityEngine\.TilemapModule\.dll&#124;UnityEngine\.UI\.dll&#124;UnityEngine\.UIElementsModule\.dll&#124;UnityEngine\.UIModule\.dll&#124;UnityEngine\.UnityAnalyticsCommonModule\.dll&#124;UnityEngine\.UnityWebRequestAssetBundleModule\.dll&#124;UnityEngine\.UnityWebRequestModule\.dll&#124;UnityEngine\.VFXModule\.dll&#124;UnityEngine\.VRModule\.dll&#124;UnityEngine\.VideoModule\.dll&#124;UnityEngine\.XRModule\.dll&#124;UnityEngine\.dll&#124;__Generated&#124;campus\-submodule\.Runtime\.dll&#124;campus\-submodule\.Shader\.Runtime\.dll&#124;mscorlib\.dll&#124;netstandard\.dll&#124;quaunity\-crypto\.dll&#124;quaunity\-global\.dll&#124;quaunity\-ui\.Runtime\.dll&#124;quaunity\-volumetriclightbeam\.Runtime\.dll&#124;vl\-unity\.Runtime\.dll)$`

Names are matched exactly within each assembly, including nested and compiler-generated types. Matching means equal type kind/base declarations and declared field names, types, order, storage kind and available offsets. Instance, static and thread-static offsets belong to separate storage areas; constants have no storage. Missing/extra types remain visible; stripping and compiler-generated renaming can cause these outcomes.

This report cannot establish object size, tail padding, concrete generic-instance layouts, method behavior, serialization attribute argument values, or runtime initialization. Inherited fields are compared in their declaring types. A type with no declared storage fields matches vacuously. Generic definitions and unavailable storage offsets are indeterminate. Dumps must come from the same architecture and compatible IL2CPP object model for offsets to be comparable.

| Assembly | Matching | Mismatching | Indeterminate | Missing from build | Extra in build |
| --- | ---: | ---: | ---: | ---: | ---: |
| `ActorAnimation.Runtime.dll` | 163 | 0 | 1 | 0 | 5 |
| `AmplifyOcclusion.Runtime.dll` | 18 | 0 | 0 | 0 | 5 |
| `Cinemachine.dll` | 177 | 6 | 0 | 1 | 12 |
| `CriMw.CriWare.Runtime.dll` | 343 | 0 | 1 | 0 | 3 |
| `DOTween.dll` | 139 | 0 | 1 | 0 | 5 |
| `Mono.Security.dll` | 5 | 0 | 0 | 80 | 0 |
| `Octo.dll` | 209 | 4 | 40 | 0 | 5 |
| `ProFlare.Runtime.dll` | 27 | 0 | 0 | 0 | 5 |
| `Qua.Base.Runtime.dll` | 12 | 1 | 0 | 0 | 5 |
| `Qua.PolygonUtility.dll` | 49 | 0 | 8 | 0 | 5 |
| `Qua.Utility.dll` | 25 | 0 | 8 | 0 | 5 |
| `Qua.VectorUI.Runtime.dll` | 29 | 0 | 4 | 0 | 5 |
| `System.Configuration.dll` | 0 | 0 | 0 | 0 | 10 |
| `System.Core.dll` | 12 | 0 | 25 | 666 | 0 |
| `System.Xml.dll` | 1 | 2 | 0 | 666 | 0 |
| `System.dll` | 124 | 10 | 9 | 620 | 20 |
| `Titan.Runtime.dll` | 286 | 0 | 24 | 0 | 5 |
| `Uguiss-Timeline.Runtime.dll` | 60 | 0 | 3 | 0 | 3 |
| `Uguiss.Runtime.dll` | 81 | 0 | 2 | 0 | 3 |
| `UniRx.dll` | 154 | 0 | 145 | 0 | 5 |
| `UniTask.Linq.dll` | 5 | 0 | 3 | 0 | 5 |
| `UniTask.dll` | 296 | 0 | 64 | 0 | 5 |
| `Unity.Animation.Rigging.dll` | 44 | 9 | 1 | 1 | 87 |
| `Unity.Burst.Unsafe.dll` | 3 | 0 | 0 | 0 | 1 |
| `Unity.Burst.dll` | 23 | 9 | 0 | 0 | 68 |
| `Unity.Collections.LowLevel.ILSupport.dll` | 0 | 0 | 0 | 0 | 7 |
| `Unity.Collections.dll` | 63 | 34 | 11 | 0 | 234 |
| `Unity.Mathematics.dll` | 19 | 21 | 0 | 0 | 64 |
| `Unity.Profiling.Core.dll` | 4 | 0 | 0 | 0 | 14 |
| `Unity.RenderPipeline.Universal.ShaderLibrary.dll` | 14 | 2 | 0 | 0 | 6 |
| `Unity.RenderPipelines.Core.Runtime.dll` | 257 | 23 | 24 | 8 | 208 |
| `Unity.RenderPipelines.Universal.Runtime.dll` | 543 | 31 | 10 | 4 | 184 |
| `Unity.TextMeshPro.dll` | 115 | 11 | 7 | 0 | 61 |
| `Unity.Timeline.dll` | 102 | 2 | 1 | 0 | 30 |
| `Unity.VisualEffectGraph.Runtime.dll` | 24 | 2 | 0 | 3 | 81 |
| `UnityEngine.AIModule.dll` | 3 | 0 | 0 | 0 | 0 |
| `UnityEngine.AndroidJNIModule.dll` | 44 | 1 | 0 | 4 | 0 |
| `UnityEngine.AnimationModule.dll` | 67 | 1 | 2 | 28 | 0 |
| `UnityEngine.AssetBundleModule.dll` | 6 | 0 | 0 | 2 | 0 |
| `UnityEngine.AudioModule.dll` | 19 | 0 | 0 | 15 | 0 |
| `UnityEngine.CoreModule.dll` | 852 | 2 | 35 | 91 | 17 |
| `UnityEngine.DirectorModule.dll` | 9 | 0 | 0 | 0 | 0 |
| `UnityEngine.GridModule.dll` | 2 | 0 | 0 | 0 | 0 |
| `UnityEngine.HierarchyCoreModule.dll` | 42 | 0 | 2 | 0 | 0 |
| `UnityEngine.IMGUIModule.dll` | 46 | 4 | 0 | 3 | 0 |
| `UnityEngine.InputForUIModule.dll` | 48 | 0 | 0 | 0 | 0 |
| `UnityEngine.InputLegacyModule.dll` | 13 | 1 | 0 | 1 | 0 |
| `UnityEngine.InputModule.dll` | 5 | 0 | 0 | 0 | 0 |
| `UnityEngine.ParticleSystemModule.dll` | 17 | 0 | 0 | 51 | 0 |
| `UnityEngine.Physics2DModule.dll` | 12 | 0 | 0 | 0 | 0 |
| `UnityEngine.PhysicsModule.dll` | 24 | 0 | 0 | 8 | 0 |
| `UnityEngine.PropertiesModule.dll` | 137 | 0 | 28 | 0 | 0 |
| `UnityEngine.SharedInternalsModule.dll` | 29 | 0 | 0 | 0 | 0 |
| `UnityEngine.SpriteShapeModule.dll` | 2 | 0 | 0 | 0 | 0 |
| `UnityEngine.SubsystemsModule.dll` | 16 | 0 | 0 | 0 | 0 |
| `UnityEngine.TerrainModule.dll` | 0 | 0 | 0 | 0 | 14 |
| `UnityEngine.TextCoreFontEngineModule.dll` | 25 | 0 | 0 | 0 | 0 |
| `UnityEngine.TextCoreTextEngineModule.dll` | 105 | 0 | 4 | 0 | 0 |
| `UnityEngine.TextRenderingModule.dll` | 15 | 0 | 0 | 1 | 0 |
| `UnityEngine.TilemapModule.dll` | 3 | 0 | 0 | 0 | 0 |
| `UnityEngine.UI.dll` | 182 | 2 | 3 | 1 | 21 |
| `UnityEngine.UIElementsModule.dll` | 1440 | 0 | 109 | 0 | 0 |
| `UnityEngine.UIModule.dll` | 11 | 0 | 0 | 1 | 0 |
| `UnityEngine.UnityAnalyticsCommonModule.dll` | 35 | 0 | 0 | 0 | 0 |
| `UnityEngine.UnityWebRequestAssetBundleModule.dll` | 2 | 0 | 0 | 2 | 0 |
| `UnityEngine.UnityWebRequestModule.dll` | 14 | 0 | 0 | 9 | 0 |
| `UnityEngine.VFXModule.dll` | 14 | 1 | 0 | 0 | 4 |
| `UnityEngine.VRModule.dll` | 3 | 0 | 0 | 0 | 1 |
| `UnityEngine.VideoModule.dll` | 16 | 0 | 0 | 0 | 0 |
| `UnityEngine.XRModule.dll` | 32 | 0 | 0 | 3 | 0 |
| `UnityEngine.dll` | 1 | 0 | 0 | 0 | 0 |
| `__Generated` | 5 | 0 | 0 | 0 | 0 |
| `campus-submodule.Runtime.dll` | 1089 | 1 | 40 | 0 | 5 |
| `campus-submodule.Shader.Runtime.dll` | 7 | 0 | 0 | 0 | 5 |
| `mscorlib.dll` | 1284 | 42 | 84 | 347 | 9 |
| `netstandard.dll` | 0 | 0 | 0 | 0 | 12 |
| `quaunity-crypto.dll` | 1 | 1 | 3 | 0 | 5 |
| `quaunity-global.dll` | 14 | 1 | 0 | 0 | 5 |
| `quaunity-ui.Runtime.dll` | 229 | 0 | 69 | 0 | 5 |
| `quaunity-volumetriclightbeam.Runtime.dll` | 138 | 0 | 0 | 0 | 5 |
| `vl-unity.Runtime.dll` | 321 | 0 | 17 | 0 | 5 |
| **Total** | 9805 | 224 | 788 | 2616 | 1274 |

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

<details><summary>Matching: 177</summary>

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

<details><summary>Missing: 1</summary>

- `CinemachineBrain.<AfterPhysics>d__32` (compiler-generated name)

</details>

<details><summary>Extra: 12</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5907`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6031`
- `Cinemachine.AxisBase`
- `Cinemachine.CinemachineInputAxisDriver`
- `Cinemachine.Utility.GaussianWindow1D_CameraRotation`
- `Cinemachine.Utility.GaussianWindow1D_Quaternion`
- `Cinemachine.Utility.GaussianWindow1D_Vector3`
- `Cinemachine.Utility.GaussianWindow1d<T>`
- `Cinemachine.Utility.UnityRectExtensions`
- `CinemachineBrain.<AfterPhysics>d__30` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## CriMw.CriWare.Runtime.dll

<details><summary>Matching: 343</summary>

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
- `CriAtom.<>c__DisplayClass68_0` (compiler-generated name)
- `CriAtom.<LoadAcbDataCoroutine>d__74` (compiler-generated name)
- `CriAtom.<LoadAcbFileCoroutine>d__72` (compiler-generated name)
- `CriAtom.NativeMethods`
- `CriAtom.SpeakerMapping`
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
- `CriAtomEx.CueInfo`
- `CriAtomEx.CueLinkCbFunc`
- `CriAtomEx.CueLinkInfo`
- `CriAtomEx.CuePos3dInfo`
- `CriAtomEx.CueType`
- `CriAtomEx.CurveType`
- `CriAtomEx.Format`
- `CriAtomEx.FormatInfo`
- `CriAtomEx.GameVariableInfo`
- `CriAtomEx.NativeVector`
- `CriAtomEx.PanType`
- `CriAtomEx.Parameter`
- `CriAtomEx.PerformanceInfo`
- `CriAtomEx.Randomize3dCalcType`
- `CriAtomEx.Randomize3dConfig`
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
- `CriAtomSource.<PlayAsync>d__11` (compiler-generated name)
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
- `CriManaMovieMaterialBase.<RestartPlayerRoutine>d__60` (compiler-generated name)
- `CriManaMovieMaterialBase.MaxFrameDrop`
- `CriManaMovieMaterialBase.OnApplicationPauseCallback`
- `CriManaMovieMaterialBase.RenderMode`
- `CriWare.Common`
- `CriWare.CriAtom`
- `CriWare.CriAtomConfig`
- `CriWare.CriAtomCueSheet`
- `CriWare.CriAtomDebugDetail.Utility`
- `CriWare.CriAtomEx`
- `CriWare.CriAtomEx3dListener`
- `CriWare.CriAtomEx3dRegion`
- `CriWare.CriAtomEx3dSource`
- `CriWare.CriAtomEx3dTransceiver`
- `CriWare.CriAtomExAcb`
- `CriWare.CriAtomExAcbDebug`
- `CriWare.CriAtomExAcbLoader`
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
- `CriWare.CriAtomExOutputAnalyzer`
- `CriWare.CriAtomExOutputPort`
- `CriWare.CriAtomExPlayback`
- `CriWare.CriAtomExPlaybackDebug`
- `CriWare.CriAtomExPlayer`
- `CriWare.CriAtomExPlayerOutputAnalyzer`
- `CriWare.CriAtomExRawPcmVoicePool`
- `CriWare.CriAtomExSequencer`
- `CriWare.CriAtomExSoundObject`
- `CriWare.CriAtomExStandardVoicePool`
- `CriWare.CriAtomExTween`
- `CriWare.CriAtomExVoicePool`
- `CriWare.CriAtomExWaveVoicePool`
- `CriWare.CriAtomListener`
- `CriWare.CriAtomOutputDeviceObserver`
- `CriWare.CriAtomPlugin`
- `CriWare.CriAtomRegion`
- `CriWare.CriAtomServer`
- `CriWare.CriAtomSource`
- `CriWare.CriAtomSourceBase`
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
- `CriWare.CriFsServer`
- `CriWare.CriFsUtility`
- `CriWare.CriFsWebInstallRequest`
- `CriWare.CriFsWebInstaller`
- `CriWare.CriMana.AlphaType`
- `CriWare.CriMana.AudioInfo`
- `CriWare.CriMana.CodecType`
- `CriWare.CriMana.Detail.AutoResisterRendererResourceFactories`
- `CriWare.CriMana.Detail.RendererResource`
- `CriWare.CriMana.Detail.RendererResourceAndroidH264Rgb`
- `CriWare.CriMana.Detail.RendererResourceAndroidSofdecPrimeYuv`
- `CriWare.CriMana.Detail.RendererResourceAndroidSofdecPrimeYuvLegacyGles2`
- `CriWare.CriMana.Detail.RendererResourceFactory`
- `CriWare.CriMana.Detail.RendererResourceFactoryPriorityAttribute`
- `CriWare.CriMana.Detail.RendererResourceSofdecPrimeYuvRawData`
- `CriWare.CriMana.EventPoint`
- `CriWare.CriMana.FrameInfo`
- `CriWare.CriMana.MovieInfo`
- `CriWare.CriMana.Player`
- `CriWare.CriMana.Settings`
- `CriWare.CriManaAmbisonicSource`
- `CriWare.CriManaConfig`
- `CriWare.CriManaMovieController`
- `CriWare.CriManaMovieControllerForUI`
- `CriWare.CriManaMovieMaterial`
- `CriWare.CriManaMovieMaterialBase`
- `CriWare.CriManaMoviePlayerHolder`
- `CriWare.CriManaPlugin`
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
- `CriWare.CriWareErrorHandler`
- `CriWare.CriWareInitializer`
- `CriWare.CriWareMemoryReporter`
- `CriWare.CriWareProfilerReporter`
- `CriWareDecrypter.CallbackFromNativeDelegate`
- `CriWareDecrypter.Config`
- `CriWareErrorHandler.Callback`
- `CriWareErrorHandler.NativeMethod`
- `CriWareProfilerReporter.<>c` (compiler-generated name)
- `CriWareProfilerReporter.TargetReporterName`
- `Player.<IssuePluginUpdatesForFrames>d__157` (compiler-generated name)
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

<details><summary>Indeterminate: 1</summary>

- `CriWare.CriStructMemory<Type>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 3</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=10587`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=8770`

</details>


## DOTween.dll

<details><summary>Matching: 139</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
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
- `DG.Tweening.Core.DOTweenSettings`
- `DG.Tweening.Core.Debugger`
- `DG.Tweening.Core.Easing.Bounce`
- `DG.Tweening.Core.Easing.EaseCurve`
- `DG.Tweening.Core.Easing.EaseManager`
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
- `DG.Tweening.Core.TweenManager`
- `DG.Tweening.Core.Utils`
- `DG.Tweening.CustomPlugins.PureQuaternionPlugin`
- `DG.Tweening.DOTween`
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
- `DG.Tweening.Plugins.Core.PathCore.Path`
- `DG.Tweening.Plugins.Core.PluginsManager`
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
- `DG.Tweening.Plugins.Options.PathOptions`
- `DG.Tweening.Plugins.Options.QuaternionOptions`
- `DG.Tweening.Plugins.Options.RectOptions`
- `DG.Tweening.Plugins.Options.StringOptions`
- `DG.Tweening.Plugins.Options.UintOptions`
- `DG.Tweening.Plugins.Options.Vector3ArrayOptions`
- `DG.Tweening.Plugins.Options.VectorOptions`
- `DG.Tweening.Plugins.PathPlugin`
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
- `DG.Tweening.Tween`
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
- `DOTweenSettings.ModulesSetup`
- `DOTweenSettings.SafeModeOptions`
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
- `ShortcutExtensions.<>c__DisplayClass50_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass51_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass52_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass54_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass56_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass58_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass5_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass61_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass62_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass63_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass64_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass6_0` (compiler-generated name)
- `ShortcutExtensions.<>c__DisplayClass7_0` (compiler-generated name)
- `TweenManager.CapacityIncreaseMode`

</details>

<details><summary>Indeterminate: 1</summary>

- `DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=4751`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=5484`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Mono.Security.dll

<details><summary>Matching: 5</summary>

- `<Module>`
- `Mono.Security.ASN1`
- `Mono.Security.ASN1Convert`
- `Mono.Security.BitConverterLE`
- `Mono.Security.Cryptography.CryptoConvert`

</details>

<details><summary>Missing: 80</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=18`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=48`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=64`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=9`
- `BigInteger.Kernel`
- `BigInteger.ModulusRing`
- `BigInteger.Sign`
- `Locale`
- `Mono.Math.BigInteger`
- `Mono.Math.Prime.ConfidenceFactor`
- `Mono.Math.Prime.Generator.PrimeGeneratorBase`
- `Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase`
- `Mono.Math.Prime.PrimalityTest`
- `Mono.Math.Prime.PrimalityTests`
- `Mono.Security.Authenticode.AuthenticodeBase`
- `Mono.Security.Authenticode.AuthenticodeDeformatter`
- `Mono.Security.Cryptography.MD2`
- `Mono.Security.Cryptography.MD2Managed`
- `Mono.Security.Cryptography.MD4`
- `Mono.Security.Cryptography.MD4Managed`
- `Mono.Security.Cryptography.PKCS1`
- `Mono.Security.Cryptography.PKCS8`
- `Mono.Security.Cryptography.RSAManaged`
- `Mono.Security.Interface.Alert`
- `Mono.Security.Interface.AlertDescription`
- `Mono.Security.Interface.AlertLevel`
- `Mono.Security.Interface.CipherSuiteCode`
- `Mono.Security.Interface.ICertificateValidator`
- `Mono.Security.Interface.MonoLocalCertificateSelectionCallback`
- `Mono.Security.Interface.MonoRemoteCertificateValidationCallback`
- `Mono.Security.Interface.MonoSslPolicyErrors`
- `Mono.Security.Interface.MonoTlsConnectionInfo`
- `Mono.Security.Interface.MonoTlsProvider`
- `Mono.Security.Interface.MonoTlsProviderFactory`
- `Mono.Security.Interface.MonoTlsSettings`
- `Mono.Security.Interface.TlsException`
- `Mono.Security.Interface.TlsProtocols`
- `Mono.Security.Interface.ValidationResult`
- `Mono.Security.PKCS7`
- `Mono.Security.Protocol.Ntlm.ChallengeResponse`
- `Mono.Security.Protocol.Ntlm.ChallengeResponse2`
- `Mono.Security.Protocol.Ntlm.MessageBase`
- `Mono.Security.Protocol.Ntlm.NtlmAuthLevel`
- `Mono.Security.Protocol.Ntlm.NtlmFlags`
- `Mono.Security.Protocol.Ntlm.NtlmSettings`
- `Mono.Security.Protocol.Ntlm.Type1Message`
- `Mono.Security.Protocol.Ntlm.Type2Message`
- `Mono.Security.Protocol.Ntlm.Type3Message`
- `Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension`
- `Mono.Security.X509.Extensions.BasicConstraintsExtension`
- `Mono.Security.X509.PKCS12`
- `Mono.Security.X509.SafeBag`
- `Mono.Security.X509.X501`
- `Mono.Security.X509.X509Certificate`
- `Mono.Security.X509.X509CertificateCollection`
- `Mono.Security.X509.X509Chain`
- `Mono.Security.X509.X509ChainStatusFlags`
- `Mono.Security.X509.X509Crl`
- `Mono.Security.X509.X509Extension`
- `Mono.Security.X509.X509ExtensionCollection`
- `Mono.Security.X509.X509Store`
- `Mono.Security.X509.X509StoreManager`
- `Mono.Security.X509.X509Stores`
- `PKCS12.DeriveBytes`
- `PKCS7.ContentInfo`
- `PKCS7.EncryptedData`
- `PKCS7.SignedData`
- `PKCS7.SignerInfo`
- `PKCS8.EncryptedPrivateKeyInfo`
- `PKCS8.PrivateKeyInfo`
- `RSAManaged.KeyGeneratedEventHandler`
- `X509CertificateCollection.X509CertificateEnumerator`
- `X509Crl.X509CrlEntry`

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


## System.Configuration.dll

<details><summary>Extra: 10</summary>

- `<Module>`
- `System.Configuration.ConfigurationCollectionAttribute`
- `System.Configuration.ConfigurationElement`
- `System.Configuration.ConfigurationElementCollection`
- `System.Configuration.ConfigurationPropertyCollection`
- `System.Configuration.ConfigurationSaveMode`
- `System.Configuration.ConfigurationSection`
- `System.Configuration.ConfigurationSectionGroup`
- `System.Configuration.IgnoreSection`
- `Unity.ThrowStub`

</details>


## System.Core.dll

<details><summary>Matching: 12</summary>

- `<Module>`
- `Enumerable.<RangeIterator>d__115` (compiler-generated name)
- `ReaderWriterLockSlim.TimeoutTracker`
- `SR`
- `System.Collections.Generic.ICollectionDebugView<T>`
- `System.Linq.Enumerable`
- `System.Linq.EnumerableSorter<TElement>`
- `System.Linq.Error`
- `System.Linq.IGrouping<TKey, TElement>`
- `System.Linq.IOrderedEnumerable<TElement>`
- `System.Threading.LockRecursionPolicy`
- `System.Threading.ReaderWriterCount`

</details>

<details><summary>Indeterminate: 25</summary>

- `Enumerable.<>c__DisplayClass6_0<TSource>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.<CastIterator>d__99<TResult>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.<DistinctIterator>d__68<TSource>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.<ReverseIterator>d__79<TSource>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.<SelectManyIterator>d__17<TSource, TResult>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.Iterator<TSource>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereArrayIterator<TSource>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereEnumerableIterator<TSource>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereListIterator<TSource>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereSelectArrayIterator<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereSelectEnumerableIterator<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Enumerable.WhereSelectListIterator<TSource, TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `HashSet.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `HashSet.Slot<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `OrderedEnumerable.<GetEnumerator>d__1<TElement>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Set.Slot<TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.HashSet<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.Buffer<TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.EmptyEnumerable<TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.EnumerableSorter<TElement, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.OrderedEnumerable<TElement, TKey>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.OrderedEnumerable<TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Linq.Set<TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.ReaderWriterLockSlim`

  - Limitation: t_rwc: no comparable storage offset


</details>

<details><summary>Missing: 666</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=120`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `AddInstruction.AddDouble`
- `AddInstruction.AddInt16`
- `AddInstruction.AddInt32`
- `AddInstruction.AddInt64`
- `AddInstruction.AddSingle`
- `AddInstruction.AddUInt16`
- `AddInstruction.AddUInt32`
- `AddInstruction.AddUInt64`
- `AddOvfInstruction.AddOvfInt16`
- `AddOvfInstruction.AddOvfInt32`
- `AddOvfInstruction.AddOvfInt64`
- `AddOvfInstruction.AddOvfUInt16`
- `AddOvfInstruction.AddOvfUInt32`
- `AddOvfInstruction.AddOvfUInt64`
- `AndInstruction.AndBoolean`
- `AndInstruction.AndByte`
- `AndInstruction.AndInt16`
- `AndInstruction.AndInt32`
- `AndInstruction.AndInt64`
- `AndInstruction.AndSByte`
- `AndInstruction.AndUInt16`
- `AndInstruction.AndUInt32`
- `AndInstruction.AndUInt64`
- `BindingRestrictions.BindingRestrictionsProxy`
- `BindingRestrictions.CustomRestriction`
- `BindingRestrictions.InstanceRestriction`
- `BindingRestrictions.MergedRestriction`
- `BindingRestrictions.TestBuilder`
- `BindingRestrictions.TestBuilder.AndNode`
- `BindingRestrictions.TypeRestriction`
- `BlockExpressionList.<GetEnumerator>d__18` (compiler-generated name)
- `CacheDict.Entry<TKey, TValue>`
- `CallSite.<>c<T>` (compiler-generated name)
- `CallSiteBinder.LambdaSignature<T>`
- `CastInstruction.CastInstructionNoT`
- `CastInstruction.CastInstructionNoT.Ref`
- `CastInstruction.CastInstructionNoT.Value`
- `CastInstruction.CastInstructionT<T>`
- `DebugInfo.DebugInfoComparer`
- `DecrementInstruction.DecrementDouble`
- `DecrementInstruction.DecrementInt16`
- `DecrementInstruction.DecrementInt32`
- `DecrementInstruction.DecrementInt64`
- `DecrementInstruction.DecrementSingle`
- `DecrementInstruction.DecrementUInt16`
- `DecrementInstruction.DecrementUInt32`
- `DecrementInstruction.DecrementUInt64`
- `DelegateHelpers.<>c` (compiler-generated name)
- `DelegateHelpers.TypeInfo`
- `DelegateHelpers.VBCallSiteDelegate0<T>`
- `DelegateHelpers.VBCallSiteDelegate1<T>`
- `DelegateHelpers.VBCallSiteDelegate2<T>`
- `DelegateHelpers.VBCallSiteDelegate3<T>`
- `DelegateHelpers.VBCallSiteDelegate4<T>`
- `DelegateHelpers.VBCallSiteDelegate5<T>`
- `DelegateHelpers.VBCallSiteDelegate6<T>`
- `DelegateHelpers.VBCallSiteDelegate7<T>`
- `DivInstruction.DivDouble`
- `DivInstruction.DivInt16`
- `DivInstruction.DivInt32`
- `DivInstruction.DivInt64`
- `DivInstruction.DivSingle`
- `DivInstruction.DivUInt16`
- `DivInstruction.DivUInt32`
- `DivInstruction.DivUInt64`
- `Enumerable.<AppendIterator>d__61<TSource>` (compiler-generated name)
- `Enumerable.<ConcatIterator>d__59<TSource>` (compiler-generated name)
- `Enumerable.<ExceptIterator>d__77<TSource>` (compiler-generated name)
- `Enumerable.<IntersectIterator>d__74<TSource>` (compiler-generated name)
- `Enumerable.<OfTypeIterator>d__97<TResult>` (compiler-generated name)
- `Enumerable.<PrependIterator>d__63<TSource>` (compiler-generated name)
- `Enumerable.<RepeatIterator>d__117<TResult>` (compiler-generated name)
- `Enumerable.<SelectIterator>d__5<TSource, TResult>` (compiler-generated name)
- `Enumerable.<SelectManyIterator>d__19<TSource, TResult>` (compiler-generated name)
- `Enumerable.<SelectManyIterator>d__23<TSource, TCollection, TResult>` (compiler-generated name)
- `Enumerable.<SkipIterator>d__31<TSource>` (compiler-generated name)
- `Enumerable.<SkipLastIterator>d__216<TSource>` (compiler-generated name)
- `Enumerable.<TakeIterator>d__25<TSource>` (compiler-generated name)
- `Enumerable.<TakeLastIterator>d__218<TSource>` (compiler-generated name)
- `Enumerable.<TakeWhileIterator>d__27<TSource>` (compiler-generated name)
- `Enumerable.<UnionIterator>d__71<TSource>` (compiler-generated name)
- `Enumerable.<WhereIterator>d__2<TSource>` (compiler-generated name)
- `Enumerable.<ZipIterator>d__65<TFirst, TSecond, TResult>` (compiler-generated name)
- `EqualInstruction.EqualBoolean`
- `EqualInstruction.EqualBooleanLiftedToNull`
- `EqualInstruction.EqualByte`
- `EqualInstruction.EqualByteLiftedToNull`
- `EqualInstruction.EqualChar`
- `EqualInstruction.EqualCharLiftedToNull`
- `EqualInstruction.EqualDouble`
- `EqualInstruction.EqualDoubleLiftedToNull`
- `EqualInstruction.EqualInt16`
- `EqualInstruction.EqualInt16LiftedToNull`
- `EqualInstruction.EqualInt32`
- `EqualInstruction.EqualInt32LiftedToNull`
- `EqualInstruction.EqualInt64`
- `EqualInstruction.EqualInt64LiftedToNull`
- `EqualInstruction.EqualReference`
- `EqualInstruction.EqualSByte`
- `EqualInstruction.EqualSByteLiftedToNull`
- `EqualInstruction.EqualSingle`
- `EqualInstruction.EqualSingleLiftedToNull`
- `EqualInstruction.EqualUInt16`
- `EqualInstruction.EqualUInt16LiftedToNull`
- `EqualInstruction.EqualUInt32`
- `EqualInstruction.EqualUInt32LiftedToNull`
- `EqualInstruction.EqualUInt64`
- `EqualInstruction.EqualUInt64LiftedToNull`
- `ExclusiveOrInstruction.ExclusiveOrBoolean`
- `ExclusiveOrInstruction.ExclusiveOrByte`
- `ExclusiveOrInstruction.ExclusiveOrInt16`
- `ExclusiveOrInstruction.ExclusiveOrInt32`
- `ExclusiveOrInstruction.ExclusiveOrInt64`
- `ExclusiveOrInstruction.ExclusiveOrSByte`
- `ExclusiveOrInstruction.ExclusiveOrUInt16`
- `ExclusiveOrInstruction.ExclusiveOrUInt32`
- `ExclusiveOrInstruction.ExclusiveOrUInt64`
- `ExpandoObject.<GetExpandoEnumerator>d__51` (compiler-generated name)
- `ExpandoObject.ExpandoData`
- `ExpandoObject.KeyCollection`
- `ExpandoObject.KeyCollection.<GetEnumerator>d__15` (compiler-generated name)
- `ExpandoObject.KeyCollectionDebugView`
- `ExpandoObject.MetaExpando`
- `ExpandoObject.MetaExpando.<>c__DisplayClass3_0` (compiler-generated name)
- `ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6` (compiler-generated name)
- `ExpandoObject.ValueCollection`
- `ExpandoObject.ValueCollection.<GetEnumerator>d__15` (compiler-generated name)
- `ExpandoObject.ValueCollectionDebugView`
- `Expression.<>c` (compiler-generated name)
- `Expression.BinaryExpressionProxy`
- `Expression.BlockExpressionProxy`
- `Expression.CatchBlockProxy`
- `Expression.ConditionalExpressionProxy`
- `Expression.ConstantExpressionProxy`
- `Expression.DebugInfoExpressionProxy`
- `Expression.DefaultExpressionProxy`
- `Expression.ExtensionInfo`
- `Expression.GotoExpressionProxy`
- `Expression.IndexExpressionProxy`
- `Expression.InvocationExpressionProxy`
- `Expression.LabelExpressionProxy`
- `Expression.LambdaExpressionProxy`
- `Expression.ListInitExpressionProxy`
- `Expression.LoopExpressionProxy`
- `Expression.MemberExpressionProxy`
- `Expression.MemberInitExpressionProxy`
- `Expression.MethodCallExpressionProxy`
- `Expression.NewArrayExpressionProxy`
- `Expression.NewExpressionProxy`
- `Expression.ParameterExpressionProxy`
- `Expression.RuntimeVariablesExpressionProxy`
- `Expression.SwitchCaseProxy`
- `Expression.SwitchExpressionProxy`
- `Expression.TryExpressionProxy`
- `Expression.TryGetFuncActionArgsResult`
- `Expression.TypeBinaryExpressionProxy`
- `Expression.UnaryExpressionProxy`
- `GreaterThanInstruction.GreaterThanByte`
- `GreaterThanInstruction.GreaterThanChar`
- `GreaterThanInstruction.GreaterThanDouble`
- `GreaterThanInstruction.GreaterThanInt16`
- `GreaterThanInstruction.GreaterThanInt32`
- `GreaterThanInstruction.GreaterThanInt64`
- `GreaterThanInstruction.GreaterThanSByte`
- `GreaterThanInstruction.GreaterThanSingle`
- `GreaterThanInstruction.GreaterThanUInt16`
- `GreaterThanInstruction.GreaterThanUInt32`
- `GreaterThanInstruction.GreaterThanUInt64`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualByte`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualChar`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32`
- `GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64`
- `HashSet.ElementCount<T>`
- `HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>` (compiler-generated name)
- `IdentityFunction.<>c<TElement>` (compiler-generated name)
- `IncrementInstruction.IncrementDouble`
- `IncrementInstruction.IncrementInt16`
- `IncrementInstruction.IncrementInt32`
- `IncrementInstruction.IncrementInt64`
- `IncrementInstruction.IncrementSingle`
- `IncrementInstruction.IncrementUInt16`
- `IncrementInstruction.IncrementUInt32`
- `IncrementInstruction.IncrementUInt64`
- `InitializeLocalInstruction.ImmutableBox`
- `InitializeLocalInstruction.ImmutableRefBox`
- `InitializeLocalInstruction.ImmutableValue`
- `InitializeLocalInstruction.MutableBox`
- `InitializeLocalInstruction.MutableValue`
- `InitializeLocalInstruction.Parameter`
- `InitializeLocalInstruction.ParameterBox`
- `InitializeLocalInstruction.Reference`
- `InstructionArray.DebugView`
- `InstructionList.DebugView`
- `InstructionList.DebugView.InstructionView`
- `InterpretedFrame.<GetStackTraceDebugInfo>d__29` (compiler-generated name)
- `LabelInfo.<>c` (compiler-generated name)
- `LeftShiftInstruction.LeftShiftByte`
- `LeftShiftInstruction.LeftShiftInt16`
- `LeftShiftInstruction.LeftShiftInt32`
- `LeftShiftInstruction.LeftShiftInt64`
- `LeftShiftInstruction.LeftShiftSByte`
- `LeftShiftInstruction.LeftShiftUInt16`
- `LeftShiftInstruction.LeftShiftUInt32`
- `LeftShiftInstruction.LeftShiftUInt64`
- `LessThanInstruction.LessThanByte`
- `LessThanInstruction.LessThanChar`
- `LessThanInstruction.LessThanDouble`
- `LessThanInstruction.LessThanInt16`
- `LessThanInstruction.LessThanInt32`
- `LessThanInstruction.LessThanInt64`
- `LessThanInstruction.LessThanSByte`
- `LessThanInstruction.LessThanSingle`
- `LessThanInstruction.LessThanUInt16`
- `LessThanInstruction.LessThanUInt32`
- `LessThanInstruction.LessThanUInt64`
- `LessThanOrEqualInstruction.LessThanOrEqualByte`
- `LessThanOrEqualInstruction.LessThanOrEqualChar`
- `LessThanOrEqualInstruction.LessThanOrEqualDouble`
- `LessThanOrEqualInstruction.LessThanOrEqualInt16`
- `LessThanOrEqualInstruction.LessThanOrEqualInt32`
- `LessThanOrEqualInstruction.LessThanOrEqualInt64`
- `LessThanOrEqualInstruction.LessThanOrEqualSByte`
- `LessThanOrEqualInstruction.LessThanOrEqualSingle`
- `LessThanOrEqualInstruction.LessThanOrEqualUInt16`
- `LessThanOrEqualInstruction.LessThanOrEqualUInt32`
- `LessThanOrEqualInstruction.LessThanOrEqualUInt64`
- `LightCompiler.<>c` (compiler-generated name)
- `LightCompiler.QuoteVisitor`
- `LightLambda.<>c__DisplayClass74_0` (compiler-generated name)
- `LightLambda.DebugViewPrinter`
- `ListProvider.<GetEnumerator>d__20<T>` (compiler-generated name)
- `LocalVariables.VariableScope`
- `Lookup.<GetEnumerator>d__12<TKey, TElement>` (compiler-generated name)
- `Lookup.Grouping.<GetEnumerator>d__7<TKey, TElement>` (compiler-generated name)
- `Lookup.Grouping<TKey, TElement>`
- `ModuloInstruction.ModuloDouble`
- `ModuloInstruction.ModuloInt16`
- `ModuloInstruction.ModuloInt32`
- `ModuloInstruction.ModuloInt64`
- `ModuloInstruction.ModuloSingle`
- `ModuloInstruction.ModuloUInt16`
- `ModuloInstruction.ModuloUInt32`
- `ModuloInstruction.ModuloUInt64`
- `MulInstruction.MulDouble`
- `MulInstruction.MulInt16`
- `MulInstruction.MulInt32`
- `MulInstruction.MulInt64`
- `MulInstruction.MulSingle`
- `MulInstruction.MulUInt16`
- `MulInstruction.MulUInt32`
- `MulInstruction.MulUInt64`
- `MulOvfInstruction.MulOvfInt16`
- `MulOvfInstruction.MulOvfInt32`
- `MulOvfInstruction.MulOvfInt64`
- `MulOvfInstruction.MulOvfUInt16`
- `MulOvfInstruction.MulOvfUInt32`
- `MulOvfInstruction.MulOvfUInt64`
- `NegateCheckedInstruction.NegateCheckedInt16`
- `NegateCheckedInstruction.NegateCheckedInt32`
- `NegateCheckedInstruction.NegateCheckedInt64`
- `NegateInstruction.NegateDouble`
- `NegateInstruction.NegateInt16`
- `NegateInstruction.NegateInt32`
- `NegateInstruction.NegateInt64`
- `NegateInstruction.NegateSingle`
- `NotEqualInstruction.NotEqualBoolean`
- `NotEqualInstruction.NotEqualByte`
- `NotEqualInstruction.NotEqualByteLiftedToNull`
- `NotEqualInstruction.NotEqualChar`
- `NotEqualInstruction.NotEqualCharLiftedToNull`
- `NotEqualInstruction.NotEqualDouble`
- `NotEqualInstruction.NotEqualDoubleLiftedToNull`
- `NotEqualInstruction.NotEqualInt16`
- `NotEqualInstruction.NotEqualInt16LiftedToNull`
- `NotEqualInstruction.NotEqualInt32`
- `NotEqualInstruction.NotEqualInt32LiftedToNull`
- `NotEqualInstruction.NotEqualInt64`
- `NotEqualInstruction.NotEqualInt64LiftedToNull`
- `NotEqualInstruction.NotEqualReference`
- `NotEqualInstruction.NotEqualSByte`
- `NotEqualInstruction.NotEqualSByteLiftedToNull`
- `NotEqualInstruction.NotEqualSingle`
- `NotEqualInstruction.NotEqualSingleLiftedToNull`
- `NotEqualInstruction.NotEqualUInt16`
- `NotEqualInstruction.NotEqualUInt16LiftedToNull`
- `NotEqualInstruction.NotEqualUInt32`
- `NotEqualInstruction.NotEqualUInt32LiftedToNull`
- `NotEqualInstruction.NotEqualUInt64`
- `NotEqualInstruction.NotEqualUInt64LiftedToNull`
- `NotInstruction.NotBoolean`
- `NotInstruction.NotByte`
- `NotInstruction.NotInt16`
- `NotInstruction.NotInt32`
- `NotInstruction.NotInt64`
- `NotInstruction.NotSByte`
- `NotInstruction.NotUInt16`
- `NotInstruction.NotUInt32`
- `NotInstruction.NotUInt64`
- `NullableMethodCallInstruction.EqualsClass`
- `NullableMethodCallInstruction.GetHashCodeClass`
- `NullableMethodCallInstruction.GetValue`
- `NullableMethodCallInstruction.GetValueOrDefault`
- `NullableMethodCallInstruction.GetValueOrDefault1`
- `NullableMethodCallInstruction.HasValue`
- `NullableMethodCallInstruction.ToStringClass`
- `NumericConvertInstruction.Checked`
- `NumericConvertInstruction.ToUnderlying`
- `NumericConvertInstruction.Unchecked`
- `OrInstruction.OrBoolean`
- `OrInstruction.OrByte`
- `OrInstruction.OrInt16`
- `OrInstruction.OrInt32`
- `OrInstruction.OrInt64`
- `OrInstruction.OrSByte`
- `OrInstruction.OrUInt16`
- `OrInstruction.OrUInt32`
- `OrInstruction.OrUInt64`
- `QuoteInstruction.ExpressionQuoter`
- `ReadOnlyCollectionBuilder.Enumerator<T>`
- `RightShiftInstruction.RightShiftByte`
- `RightShiftInstruction.RightShiftInt16`
- `RightShiftInstruction.RightShiftInt32`
- `RightShiftInstruction.RightShiftInt64`
- `RightShiftInstruction.RightShiftSByte`
- `RightShiftInstruction.RightShiftUInt16`
- `RightShiftInstruction.RightShiftUInt32`
- `RightShiftInstruction.RightShiftUInt64`
- `StackGuard.<>c__3<T1, T2>` (compiler-generated name)
- `SubInstruction.SubDouble`
- `SubInstruction.SubInt16`
- `SubInstruction.SubInt32`
- `SubInstruction.SubInt64`
- `SubInstruction.SubSingle`
- `SubInstruction.SubUInt16`
- `SubInstruction.SubUInt32`
- `SubInstruction.SubUInt64`
- `SubOvfInstruction.SubOvfInt16`
- `SubOvfInstruction.SubOvfInt32`
- `SubOvfInstruction.SubOvfInt64`
- `SubOvfInstruction.SubOvfUInt16`
- `SubOvfInstruction.SubOvfUInt32`
- `SubOvfInstruction.SubOvfUInt64`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>`
- `System.Collections.Generic.ArrayBuilder<T>`
- `System.Collections.Generic.BitHelper`
- `System.Dynamic.BinaryOperationBinder`
- `System.Dynamic.BindingRestrictions`
- `System.Dynamic.CallInfo`
- `System.Dynamic.ConvertBinder`
- `System.Dynamic.CreateInstanceBinder`
- `System.Dynamic.DeleteIndexBinder`
- `System.Dynamic.DeleteMemberBinder`
- `System.Dynamic.DynamicMetaObject`
- `System.Dynamic.DynamicMetaObjectBinder`
- `System.Dynamic.ExpandoClass`
- `System.Dynamic.ExpandoObject`
- `System.Dynamic.GetIndexBinder`
- `System.Dynamic.GetMemberBinder`
- `System.Dynamic.IDynamicMetaObjectProvider`
- `System.Dynamic.InvokeBinder`
- `System.Dynamic.InvokeMemberBinder`
- `System.Dynamic.SetIndexBinder`
- `System.Dynamic.SetMemberBinder`
- `System.Dynamic.UnaryOperationBinder`
- `System.Dynamic.Utils.CacheDict<TKey, TValue>`
- `System.Dynamic.Utils.CollectionExtensions`
- `System.Dynamic.Utils.ContractUtils`
- `System.Dynamic.Utils.EmptyReadOnlyCollection<T>`
- `System.Dynamic.Utils.ExpressionUtils`
- `System.Dynamic.Utils.ExpressionVisitorUtils`
- `System.Dynamic.Utils.ListArgumentProvider`
- `System.Dynamic.Utils.ListProvider<T>`
- `System.Dynamic.Utils.TypeExtensions`
- `System.Dynamic.Utils.TypeUtils`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>`
- `System.Linq.Expressions.AnalyzeTypeIsResult`
- `System.Linq.Expressions.ArrayBuilderExtensions`
- `System.Linq.Expressions.AssignBinaryExpression`
- `System.Linq.Expressions.BinaryExpression`
- `System.Linq.Expressions.Block2`
- `System.Linq.Expressions.Block3`
- `System.Linq.Expressions.Block4`
- `System.Linq.Expressions.Block5`
- `System.Linq.Expressions.BlockExpression`
- `System.Linq.Expressions.BlockExpressionList`
- `System.Linq.Expressions.BlockN`
- `System.Linq.Expressions.ByRefParameterExpression`
- `System.Linq.Expressions.CachedReflectionInfo`
- `System.Linq.Expressions.CatchBlock`
- `System.Linq.Expressions.CoalesceConversionBinaryExpression`
- `System.Linq.Expressions.Compiler.DelegateHelpers`
- `System.Linq.Expressions.ConditionalExpression`
- `System.Linq.Expressions.ConstantCheck`
- `System.Linq.Expressions.ConstantExpression`
- `System.Linq.Expressions.DebugInfoExpression`
- `System.Linq.Expressions.DefaultExpression`
- `System.Linq.Expressions.DynamicExpression`
- `System.Linq.Expressions.DynamicExpression1`
- `System.Linq.Expressions.DynamicExpression2`
- `System.Linq.Expressions.DynamicExpression3`
- `System.Linq.Expressions.DynamicExpression4`
- `System.Linq.Expressions.DynamicExpressionN`
- `System.Linq.Expressions.DynamicExpressionVisitor`
- `System.Linq.Expressions.ElementInit`
- `System.Linq.Expressions.Error`
- `System.Linq.Expressions.Expression`
- `System.Linq.Expressions.Expression0<TDelegate>`
- `System.Linq.Expressions.Expression1<TDelegate>`
- `System.Linq.Expressions.Expression2<TDelegate>`
- `System.Linq.Expressions.Expression3<TDelegate>`
- `System.Linq.Expressions.Expression<TDelegate>`
- `System.Linq.Expressions.ExpressionCreator<TDelegate>`
- `System.Linq.Expressions.ExpressionExtension`
- `System.Linq.Expressions.ExpressionN<TDelegate>`
- `System.Linq.Expressions.ExpressionStringBuilder`
- `System.Linq.Expressions.ExpressionType`
- `System.Linq.Expressions.ExpressionVisitor`
- `System.Linq.Expressions.FieldExpression`
- `System.Linq.Expressions.FullConditionalExpression`
- `System.Linq.Expressions.FullConditionalExpressionWithType`
- `System.Linq.Expressions.FullExpression<TDelegate>`
- `System.Linq.Expressions.GotoExpression`
- `System.Linq.Expressions.GotoExpressionKind`
- `System.Linq.Expressions.IArgumentProvider`
- `System.Linq.Expressions.IParameterProvider`
- `System.Linq.Expressions.IndexExpression`
- `System.Linq.Expressions.InstanceMethodCallExpression`
- `System.Linq.Expressions.InstanceMethodCallExpression0`
- `System.Linq.Expressions.InstanceMethodCallExpression1`
- `System.Linq.Expressions.InstanceMethodCallExpression2`
- `System.Linq.Expressions.InstanceMethodCallExpression3`
- `System.Linq.Expressions.InstanceMethodCallExpressionN`
- `System.Linq.Expressions.Interpreter.AddInstruction`
- `System.Linq.Expressions.Interpreter.AddOvfInstruction`
- `System.Linq.Expressions.Interpreter.AndInstruction`
- `System.Linq.Expressions.Interpreter.ArrayByRefUpdater`
- `System.Linq.Expressions.Interpreter.ArrayLengthInstruction`
- `System.Linq.Expressions.Interpreter.AssignLocalBoxedInstruction`
- `System.Linq.Expressions.Interpreter.AssignLocalInstruction`
- `System.Linq.Expressions.Interpreter.AssignLocalToClosureInstruction`
- `System.Linq.Expressions.Interpreter.BranchFalseInstruction`
- `System.Linq.Expressions.Interpreter.BranchInstruction`
- `System.Linq.Expressions.Interpreter.BranchLabel`
- `System.Linq.Expressions.Interpreter.BranchTrueInstruction`
- `System.Linq.Expressions.Interpreter.ByRefMethodInfoCallInstruction`
- `System.Linq.Expressions.Interpreter.ByRefNewInstruction`
- `System.Linq.Expressions.Interpreter.ByRefUpdater`
- `System.Linq.Expressions.Interpreter.CallInstruction`
- `System.Linq.Expressions.Interpreter.CastInstruction`
- `System.Linq.Expressions.Interpreter.CastReferenceToEnumInstruction`
- `System.Linq.Expressions.Interpreter.CastToEnumInstruction`
- `System.Linq.Expressions.Interpreter.CoalescingBranchInstruction`
- `System.Linq.Expressions.Interpreter.ConvertHelper`
- `System.Linq.Expressions.Interpreter.CreateDelegateInstruction`
- `System.Linq.Expressions.Interpreter.DebugInfo`
- `System.Linq.Expressions.Interpreter.DecrementInstruction`
- `System.Linq.Expressions.Interpreter.DefaultValueInstruction`
- `System.Linq.Expressions.Interpreter.DelegateHelpers`
- `System.Linq.Expressions.Interpreter.DivInstruction`
- `System.Linq.Expressions.Interpreter.DupInstruction`
- `System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction`
- `System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction`
- `System.Linq.Expressions.Interpreter.EnterFaultInstruction`
- `System.Linq.Expressions.Interpreter.EnterFinallyInstruction`
- `System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction`
- `System.Linq.Expressions.Interpreter.EnterTryFaultInstruction`
- `System.Linq.Expressions.Interpreter.EqualInstruction`
- `System.Linq.Expressions.Interpreter.ExceptionFilter`
- `System.Linq.Expressions.Interpreter.ExceptionHandler`
- `System.Linq.Expressions.Interpreter.ExceptionHelpers`
- `System.Linq.Expressions.Interpreter.ExclusiveOrInstruction`
- `System.Linq.Expressions.Interpreter.FieldByRefUpdater`
- `System.Linq.Expressions.Interpreter.FieldInstruction`
- `System.Linq.Expressions.Interpreter.GetArrayItemInstruction`
- `System.Linq.Expressions.Interpreter.GotoInstruction`
- `System.Linq.Expressions.Interpreter.GreaterThanInstruction`
- `System.Linq.Expressions.Interpreter.GreaterThanOrEqualInstruction`
- `System.Linq.Expressions.Interpreter.HybridReferenceDictionary<TKey, TValue>`
- `System.Linq.Expressions.Interpreter.IBoxableInstruction`
- `System.Linq.Expressions.Interpreter.IncrementInstruction`
- `System.Linq.Expressions.Interpreter.IndexMethodByRefUpdater`
- `System.Linq.Expressions.Interpreter.IndexedBranchInstruction`
- `System.Linq.Expressions.Interpreter.InitializeLocalInstruction`
- `System.Linq.Expressions.Interpreter.Instruction`
- `System.Linq.Expressions.Interpreter.InstructionArray`
- `System.Linq.Expressions.Interpreter.InstructionList`
- `System.Linq.Expressions.Interpreter.IntSwitchInstruction<T>`
- `System.Linq.Expressions.Interpreter.InterpretedFrame`
- `System.Linq.Expressions.Interpreter.InterpretedFrameInfo`
- `System.Linq.Expressions.Interpreter.Interpreter`
- `System.Linq.Expressions.Interpreter.LabelInfo`
- `System.Linq.Expressions.Interpreter.LabelScopeInfo`
- `System.Linq.Expressions.Interpreter.LabelScopeKind`
- `System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction`
- `System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction`
- `System.Linq.Expressions.Interpreter.LeaveFaultInstruction`
- `System.Linq.Expressions.Interpreter.LeaveFinallyInstruction`
- `System.Linq.Expressions.Interpreter.LeftShiftInstruction`
- `System.Linq.Expressions.Interpreter.LessThanInstruction`
- `System.Linq.Expressions.Interpreter.LessThanOrEqualInstruction`
- `System.Linq.Expressions.Interpreter.LightCompiler`
- `System.Linq.Expressions.Interpreter.LightDelegateCreator`
- `System.Linq.Expressions.Interpreter.LightLambda`
- `System.Linq.Expressions.Interpreter.LoadCachedObjectInstruction`
- `System.Linq.Expressions.Interpreter.LoadFieldInstruction`
- `System.Linq.Expressions.Interpreter.LoadLocalBoxedInstruction`
- `System.Linq.Expressions.Interpreter.LoadLocalFromClosureBoxedInstruction`
- `System.Linq.Expressions.Interpreter.LoadLocalFromClosureInstruction`
- `System.Linq.Expressions.Interpreter.LoadLocalInstruction`
- `System.Linq.Expressions.Interpreter.LoadObjectInstruction`
- `System.Linq.Expressions.Interpreter.LoadStaticFieldInstruction`
- `System.Linq.Expressions.Interpreter.LocalAccessInstruction`
- `System.Linq.Expressions.Interpreter.LocalDefinition`
- `System.Linq.Expressions.Interpreter.LocalVariable`
- `System.Linq.Expressions.Interpreter.LocalVariables`
- `System.Linq.Expressions.Interpreter.MethodInfoCallInstruction`
- `System.Linq.Expressions.Interpreter.ModuloInstruction`
- `System.Linq.Expressions.Interpreter.MulInstruction`
- `System.Linq.Expressions.Interpreter.MulOvfInstruction`
- `System.Linq.Expressions.Interpreter.NegateCheckedInstruction`
- `System.Linq.Expressions.Interpreter.NegateInstruction`
- `System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction`
- `System.Linq.Expressions.Interpreter.NewArrayInitInstruction`
- `System.Linq.Expressions.Interpreter.NewArrayInstruction`
- `System.Linq.Expressions.Interpreter.NewInstruction`
- `System.Linq.Expressions.Interpreter.NotEqualInstruction`
- `System.Linq.Expressions.Interpreter.NotInstruction`
- `System.Linq.Expressions.Interpreter.NullCheckInstruction`
- `System.Linq.Expressions.Interpreter.NullableMethodCallInstruction`
- `System.Linq.Expressions.Interpreter.NumericConvertInstruction`
- `System.Linq.Expressions.Interpreter.OffsetInstruction`
- `System.Linq.Expressions.Interpreter.OrInstruction`
- `System.Linq.Expressions.Interpreter.ParameterByRefUpdater`
- `System.Linq.Expressions.Interpreter.PopInstruction`
- `System.Linq.Expressions.Interpreter.PropertyByRefUpdater`
- `System.Linq.Expressions.Interpreter.QuoteInstruction`
- `System.Linq.Expressions.Interpreter.RethrowException`
- `System.Linq.Expressions.Interpreter.RightShiftInstruction`
- `System.Linq.Expressions.Interpreter.RuntimeLabel`
- `System.Linq.Expressions.Interpreter.RuntimeVariables`
- `System.Linq.Expressions.Interpreter.RuntimeVariablesInstruction`
- `System.Linq.Expressions.Interpreter.ScriptingRuntimeHelpers`
- `System.Linq.Expressions.Interpreter.SetArrayItemInstruction`
- `System.Linq.Expressions.Interpreter.StoreFieldInstruction`
- `System.Linq.Expressions.Interpreter.StoreLocalBoxedInstruction`
- `System.Linq.Expressions.Interpreter.StoreLocalInstruction`
- `System.Linq.Expressions.Interpreter.StoreStaticFieldInstruction`
- `System.Linq.Expressions.Interpreter.StringSwitchInstruction`
- `System.Linq.Expressions.Interpreter.SubInstruction`
- `System.Linq.Expressions.Interpreter.SubOvfInstruction`
- `System.Linq.Expressions.Interpreter.ThrowInstruction`
- `System.Linq.Expressions.Interpreter.TryCatchFinallyHandler`
- `System.Linq.Expressions.Interpreter.TryFaultHandler`
- `System.Linq.Expressions.Interpreter.TypeAsInstruction`
- `System.Linq.Expressions.Interpreter.TypeEqualsInstruction`
- `System.Linq.Expressions.Interpreter.TypeIsInstruction`
- `System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction`
- `System.Linq.Expressions.InvocationExpression`
- `System.Linq.Expressions.InvocationExpression0`
- `System.Linq.Expressions.InvocationExpression1`
- `System.Linq.Expressions.InvocationExpression2`
- `System.Linq.Expressions.InvocationExpression3`
- `System.Linq.Expressions.InvocationExpression4`
- `System.Linq.Expressions.InvocationExpression5`
- `System.Linq.Expressions.InvocationExpressionN`
- `System.Linq.Expressions.LabelExpression`
- `System.Linq.Expressions.LabelTarget`
- `System.Linq.Expressions.LambdaExpression`
- `System.Linq.Expressions.ListInitExpression`
- `System.Linq.Expressions.LogicalBinaryExpression`
- `System.Linq.Expressions.LoopExpression`
- `System.Linq.Expressions.MemberAssignment`
- `System.Linq.Expressions.MemberBinding`
- `System.Linq.Expressions.MemberBindingType`
- `System.Linq.Expressions.MemberExpression`
- `System.Linq.Expressions.MemberInitExpression`
- `System.Linq.Expressions.MemberListBinding`
- `System.Linq.Expressions.MemberMemberBinding`
- `System.Linq.Expressions.MethodBinaryExpression`
- `System.Linq.Expressions.MethodCallExpression`
- `System.Linq.Expressions.MethodCallExpression0`
- `System.Linq.Expressions.MethodCallExpression1`
- `System.Linq.Expressions.MethodCallExpression2`
- `System.Linq.Expressions.MethodCallExpression3`
- `System.Linq.Expressions.MethodCallExpression4`
- `System.Linq.Expressions.MethodCallExpression5`
- `System.Linq.Expressions.MethodCallExpressionN`
- `System.Linq.Expressions.NewArrayBoundsExpression`
- `System.Linq.Expressions.NewArrayExpression`
- `System.Linq.Expressions.NewArrayInitExpression`
- `System.Linq.Expressions.NewExpression`
- `System.Linq.Expressions.NewValueTypeExpression`
- `System.Linq.Expressions.OpAssignMethodConversionBinaryExpression`
- `System.Linq.Expressions.ParameterExpression`
- `System.Linq.Expressions.PrimitiveParameterExpression<T>`
- `System.Linq.Expressions.PropertyExpression`
- `System.Linq.Expressions.RuntimeVariablesExpression`
- `System.Linq.Expressions.Scope1`
- `System.Linq.Expressions.ScopeExpression`
- `System.Linq.Expressions.ScopeN`
- `System.Linq.Expressions.ScopeWithType`
- `System.Linq.Expressions.SimpleBinaryExpression`
- `System.Linq.Expressions.StackGuard`
- `System.Linq.Expressions.Strings`
- `System.Linq.Expressions.SwitchCase`
- `System.Linq.Expressions.SwitchExpression`
- `System.Linq.Expressions.SymbolDocumentInfo`
- `System.Linq.Expressions.TryExpression`
- `System.Linq.Expressions.TypeBinaryExpression`
- `System.Linq.Expressions.TypedConstantExpression`
- `System.Linq.Expressions.TypedDynamicExpression1`
- `System.Linq.Expressions.TypedDynamicExpression2`
- `System.Linq.Expressions.TypedDynamicExpression3`
- `System.Linq.Expressions.TypedDynamicExpression4`
- `System.Linq.Expressions.TypedDynamicExpressionN`
- `System.Linq.Expressions.TypedParameterExpression`
- `System.Linq.Expressions.UnaryExpression`
- `System.Linq.Expressions.Utils`
- `System.Linq.GroupedEnumerable<TSource, TKey, TElement>`
- `System.Linq.IQueryable<T>`
- `System.Linq.IdentityFunction<TElement>`
- `System.Linq.Lookup<TKey, TElement>`
- `System.Runtime.CompilerServices.CallSite`
- `System.Runtime.CompilerServices.CallSite<T>`
- `System.Runtime.CompilerServices.CallSiteBinder`
- `System.Runtime.CompilerServices.CallSiteOps`
- `System.Runtime.CompilerServices.DynamicAttribute`
- `System.Runtime.CompilerServices.IRuntimeVariables`
- `System.Runtime.CompilerServices.IStrongBox`
- `System.Runtime.CompilerServices.ReadOnlyCollectionBuilder<T>`
- `System.Runtime.CompilerServices.RuleCache<T>`
- `System.Runtime.CompilerServices.RuntimeOps`
- `System.Runtime.CompilerServices.StrongBox<T>`
- `System.Runtime.CompilerServices.TrueReadOnlyCollection<T>`
- `System.Security.Cryptography.AesCryptoServiceProvider`
- `System.Security.Cryptography.AesManaged`
- `System.Security.Cryptography.AesTransform`
- `System.Security.Cryptography.SHA256CryptoServiceProvider`
- `System.Security.Cryptography.X509Certificates.RSACertificateExtensions`
- `System.Threading.Tasks.TaskExtensions`
- `TypeUtils.<>c` (compiler-generated name)

</details>


## System.Xml.dll

<details><summary>Matching: 1</summary>

- `<Module>`

</details>

<details><summary>Mismatching: 2</summary>

- `System.Xml.XmlNode`

  - `bases: 'ICloneable, IEnumerable' → ''`
  - `field declaration order/names: ['parentNode'] → []`
  - `missing field instance XmlNode parentNode`

- `System.Xml.XmlReader`

  - `bases: 'IDisposable' → ''`


</details>

<details><summary>Missing: 666</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=112`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=28`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=36`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=38`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=40`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=416`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=44`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=56`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=64`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=664`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=68`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=960`
- `AstNode.AstType`
- `Axis.AxisType`
- `CompiledIdentityConstraint.ConstraintRole`
- `DatatypeImplementation.SchemaDatatypeMap`
- `DtdParser.LiteralType`
- `DtdParser.ParseElementOnlyContent_LocalFrame`
- `DtdParser.ScanningFunction`
- `DtdParser.Token`
- `DtdParser.UndeclaredNotation`
- `DtdValidator.NamespaceManager`
- `EnumMap.EnumMapMember`
- `FacetsChecker.FacetsCompiler`
- `FacetsChecker.FacetsCompiler.Map`
- `Function.FunctionType`
- `MS.Internal.Xml.Cache.XPathDocumentNavigator`
- `MS.Internal.Xml.Cache.XPathNode`
- `MS.Internal.Xml.Cache.XPathNodeHelper`
- `MS.Internal.Xml.Cache.XPathNodeInfoAtom`
- `MS.Internal.Xml.Cache.XPathNodePageInfo`
- `MS.Internal.Xml.Cache.XPathNodeRef`
- `MS.Internal.Xml.XPath.AstNode`
- `MS.Internal.Xml.XPath.Axis`
- `MS.Internal.Xml.XPath.Filter`
- `MS.Internal.Xml.XPath.Function`
- `MS.Internal.Xml.XPath.Group`
- `MS.Internal.Xml.XPath.Operand`
- `MS.Internal.Xml.XPath.Operator`
- `MS.Internal.Xml.XPath.Root`
- `MS.Internal.Xml.XPath.Variable`
- `MS.Internal.Xml.XPath.XPathParser`
- `MS.Internal.Xml.XPath.XPathScanner`
- `Microsoft.CSharp.CSharpCodeProvider`
- `Microsoft.CSharp.CodeDomProvider`
- `NameTable.Entry`
- `NamespaceList.ListType`
- `Operator.Op`
- `ReadContentAsBinaryHelper.State`
- `SR`
- `SchemaAttDef.Reserve`
- `SchemaCollectionPreprocessor.Compositor`
- `SchemaDeclBase.Use`
- `SchemaNames.Token`
- `SecureStringHasher.HashCodeOfStringDelegate`
- `SequenceNode.SequenceConstructPosContext`
- `System.LocalAppContextSwitches`
- `System.MonoTODOAttribute`
- `System.Xml.AsyncHelper`
- `System.Xml.AttributePSVIInfo`
- `System.Xml.AttributeProperties`
- `System.Xml.Base64Encoder`
- `System.Xml.BinHexDecoder`
- `System.Xml.BinHexEncoder`
- `System.Xml.BinXmlDateTime`
- `System.Xml.BinXmlSqlDecimal`
- `System.Xml.BinXmlSqlMoney`
- `System.Xml.BinXmlToken`
- `System.Xml.BinaryCompatibility`
- `System.Xml.BitStack`
- `System.Xml.Bits`
- `System.Xml.ByteStack`
- `System.Xml.CachingEventHandler`
- `System.Xml.CharEntityEncoderFallback`
- `System.Xml.CharEntityEncoderFallbackBuffer`
- `System.Xml.ConformanceLevel`
- `System.Xml.DomNameTable`
- `System.Xml.DtdParser`
- `System.Xml.DtdProcessing`
- `System.Xml.ElementProperties`
- `System.Xml.EmptyEnumerator`
- `System.Xml.EntityHandling`
- `System.Xml.ExceptionType`
- `System.Xml.Formatting`
- `System.Xml.HWStack`
- `System.Xml.HtmlEncodedRawTextWriter`
- `System.Xml.HtmlEncodedRawTextWriterIndent`
- `System.Xml.HtmlTernaryTree`
- `System.Xml.HtmlUtf8RawTextWriter`
- `System.Xml.HtmlUtf8RawTextWriterIndent`
- `System.Xml.IDtdAttributeInfo`
- `System.Xml.IDtdAttributeListInfo`
- `System.Xml.IDtdDefaultAttributeInfo`
- `System.Xml.IDtdEntityInfo`
- `System.Xml.IDtdInfo`
- `System.Xml.IDtdParser`
- `System.Xml.IDtdParserAdapter`
- `System.Xml.IDtdParserAdapterV1`
- `System.Xml.IDtdParserAdapterWithValidation`
- `System.Xml.IValidationEventHandling`
- `System.Xml.IXmlLineInfo`
- `System.Xml.IXmlNamespaceResolver`
- `System.Xml.IncrementalReadDecoder`
- `System.Xml.IncrementalReadDummyDecoder`
- `System.Xml.LineInfo`
- `System.Xml.NameTable`
- `System.Xml.NamespaceHandling`
- `System.Xml.NewLineHandling`
- `System.Xml.OnRemoveWriter`
- `System.Xml.OpenedHost`
- `System.Xml.PositionInfo`
- `System.Xml.QueryOutputWriter`
- `System.Xml.ReadContentAsBinaryHelper`
- `System.Xml.ReadState`
- `System.Xml.ReaderPositionInfo`
- `System.Xml.Ref`
- `System.Xml.Res`
- `System.Xml.SafeAsciiDecoder`
- `System.Xml.Schema.ActiveAxis`
- `System.Xml.Schema.AllElementsContentValidator`
- `System.Xml.Schema.Asttree`
- `System.Xml.Schema.AttributeMatchState`
- `System.Xml.Schema.AutoValidator`
- `System.Xml.Schema.AxisElement`
- `System.Xml.Schema.AxisStack`
- `System.Xml.Schema.BaseProcessor`
- `System.Xml.Schema.BaseValidator`
- `System.Xml.Schema.BinaryFacetsChecker`
- `System.Xml.Schema.BitSet`
- `System.Xml.Schema.ChameleonKey`
- `System.Xml.Schema.ChoiceNode`
- `System.Xml.Schema.CompiledIdentityConstraint`
- `System.Xml.Schema.Compiler`
- `System.Xml.Schema.Compositor`
- `System.Xml.Schema.ConstraintStruct`
- `System.Xml.Schema.ContentValidator`
- `System.Xml.Schema.DatatypeImplementation`
- `System.Xml.Schema.Datatype_ENTITY`
- `System.Xml.Schema.Datatype_ENUMERATION`
- `System.Xml.Schema.Datatype_ID`
- `System.Xml.Schema.Datatype_IDREF`
- `System.Xml.Schema.Datatype_List`
- `System.Xml.Schema.Datatype_NCName`
- `System.Xml.Schema.Datatype_NMTOKEN`
- `System.Xml.Schema.Datatype_NOTATION`
- `System.Xml.Schema.Datatype_Name`
- `System.Xml.Schema.Datatype_QName`
- `System.Xml.Schema.Datatype_QNameXdr`
- `System.Xml.Schema.Datatype_anyAtomicType`
- `System.Xml.Schema.Datatype_anySimpleType`
- `System.Xml.Schema.Datatype_anyURI`
- `System.Xml.Schema.Datatype_base64Binary`
- `System.Xml.Schema.Datatype_boolean`
- `System.Xml.Schema.Datatype_byte`
- `System.Xml.Schema.Datatype_char`
- `System.Xml.Schema.Datatype_date`
- `System.Xml.Schema.Datatype_dateTime`
- `System.Xml.Schema.Datatype_dateTimeBase`
- `System.Xml.Schema.Datatype_dateTimeNoTimeZone`
- `System.Xml.Schema.Datatype_dateTimeTimeZone`
- `System.Xml.Schema.Datatype_day`
- `System.Xml.Schema.Datatype_dayTimeDuration`
- `System.Xml.Schema.Datatype_decimal`
- `System.Xml.Schema.Datatype_double`
- `System.Xml.Schema.Datatype_doubleXdr`
- `System.Xml.Schema.Datatype_duration`
- `System.Xml.Schema.Datatype_fixed`
- `System.Xml.Schema.Datatype_float`
- `System.Xml.Schema.Datatype_floatXdr`
- `System.Xml.Schema.Datatype_hexBinary`
- `System.Xml.Schema.Datatype_int`
- `System.Xml.Schema.Datatype_integer`
- `System.Xml.Schema.Datatype_language`
- `System.Xml.Schema.Datatype_long`
- `System.Xml.Schema.Datatype_month`
- `System.Xml.Schema.Datatype_monthDay`
- `System.Xml.Schema.Datatype_negativeInteger`
- `System.Xml.Schema.Datatype_nonNegativeInteger`
- `System.Xml.Schema.Datatype_nonPositiveInteger`
- `System.Xml.Schema.Datatype_normalizedString`
- `System.Xml.Schema.Datatype_normalizedStringV1Compat`
- `System.Xml.Schema.Datatype_positiveInteger`
- `System.Xml.Schema.Datatype_short`
- `System.Xml.Schema.Datatype_string`
- `System.Xml.Schema.Datatype_time`
- `System.Xml.Schema.Datatype_timeNoTimeZone`
- `System.Xml.Schema.Datatype_timeTimeZone`
- `System.Xml.Schema.Datatype_token`
- `System.Xml.Schema.Datatype_tokenV1Compat`
- `System.Xml.Schema.Datatype_union`
- `System.Xml.Schema.Datatype_unsignedByte`
- `System.Xml.Schema.Datatype_unsignedInt`
- `System.Xml.Schema.Datatype_unsignedLong`
- `System.Xml.Schema.Datatype_unsignedShort`
- `System.Xml.Schema.Datatype_untypedAtomicType`
- `System.Xml.Schema.Datatype_uuid`
- `System.Xml.Schema.Datatype_year`
- `System.Xml.Schema.Datatype_yearMonth`
- `System.Xml.Schema.Datatype_yearMonthDuration`
- `System.Xml.Schema.DateTimeFacetsChecker`
- `System.Xml.Schema.DfaContentValidator`
- `System.Xml.Schema.DoubleLinkAxis`
- `System.Xml.Schema.DtdValidator`
- `System.Xml.Schema.DurationFacetsChecker`
- `System.Xml.Schema.FacetType`
- `System.Xml.Schema.FacetsChecker`
- `System.Xml.Schema.ForwardAxis`
- `System.Xml.Schema.IXmlSchemaInfo`
- `System.Xml.Schema.IdRefNode`
- `System.Xml.Schema.InteriorNode`
- `System.Xml.Schema.KSStruct`
- `System.Xml.Schema.KeySequence`
- `System.Xml.Schema.LeafNode`
- `System.Xml.Schema.LeafRangeNode`
- `System.Xml.Schema.ListFacetsChecker`
- `System.Xml.Schema.LocatedActiveAxis`
- `System.Xml.Schema.MiscFacetsChecker`
- `System.Xml.Schema.NamespaceList`
- `System.Xml.Schema.NamespaceListNode`
- `System.Xml.Schema.NamespaceListV1Compat`
- `System.Xml.Schema.NfaContentValidator`
- `System.Xml.Schema.Numeric10FacetsChecker`
- `System.Xml.Schema.Numeric2FacetsChecker`
- `System.Xml.Schema.Parser`
- `System.Xml.Schema.ParticleContentValidator`
- `System.Xml.Schema.PlusNode`
- `System.Xml.Schema.Position`
- `System.Xml.Schema.Positions`
- `System.Xml.Schema.Preprocessor`
- `System.Xml.Schema.QNameFacetsChecker`
- `System.Xml.Schema.QmarkNode`
- `System.Xml.Schema.RangeContentValidator`
- `System.Xml.Schema.RangePositionInfo`
- `System.Xml.Schema.RedefineEntry`
- `System.Xml.Schema.RestrictionFacets`
- `System.Xml.Schema.RestrictionFlags`
- `System.Xml.Schema.SchemaAttDef`
- `System.Xml.Schema.SchemaBuilder`
- `System.Xml.Schema.SchemaCollectionCompiler`
- `System.Xml.Schema.SchemaCollectionPreprocessor`
- `System.Xml.Schema.SchemaDeclBase`
- `System.Xml.Schema.SchemaElementDecl`
- `System.Xml.Schema.SchemaEntity`
- `System.Xml.Schema.SchemaInfo`
- `System.Xml.Schema.SchemaNames`
- `System.Xml.Schema.SchemaNamespaceManager`
- `System.Xml.Schema.SchemaNotation`
- `System.Xml.Schema.SchemaType`
- `System.Xml.Schema.SelectorActiveAxis`
- `System.Xml.Schema.SequenceNode`
- `System.Xml.Schema.StarNode`
- `System.Xml.Schema.StateUnion`
- `System.Xml.Schema.StringFacetsChecker`
- `System.Xml.Schema.SymbolsDictionary`
- `System.Xml.Schema.SyntaxTreeNode`
- `System.Xml.Schema.TypedObject`
- `System.Xml.Schema.UnionFacetsChecker`
- `System.Xml.Schema.UpaException`
- `System.Xml.Schema.ValidationEventArgs`
- `System.Xml.Schema.ValidationEventHandler`
- `System.Xml.Schema.ValidationState`
- `System.Xml.Schema.ValidatorState`
- `System.Xml.Schema.XdrBuilder`
- `System.Xml.Schema.XdrValidator`
- `System.Xml.Schema.XmlAnyConverter`
- `System.Xml.Schema.XmlAnyListConverter`
- `System.Xml.Schema.XmlAtomicValue`
- `System.Xml.Schema.XmlBaseConverter`
- `System.Xml.Schema.XmlBooleanConverter`
- `System.Xml.Schema.XmlDateTimeConverter`
- `System.Xml.Schema.XmlListConverter`
- `System.Xml.Schema.XmlMiscConverter`
- `System.Xml.Schema.XmlNumeric10Converter`
- `System.Xml.Schema.XmlNumeric2Converter`
- `System.Xml.Schema.XmlSchema`
- `System.Xml.Schema.XmlSchemaAll`
- `System.Xml.Schema.XmlSchemaAnnotated`
- `System.Xml.Schema.XmlSchemaAnnotation`
- `System.Xml.Schema.XmlSchemaAny`
- `System.Xml.Schema.XmlSchemaAnyAttribute`
- `System.Xml.Schema.XmlSchemaAppInfo`
- `System.Xml.Schema.XmlSchemaAttribute`
- `System.Xml.Schema.XmlSchemaAttributeGroup`
- `System.Xml.Schema.XmlSchemaAttributeGroupRef`
- `System.Xml.Schema.XmlSchemaChoice`
- `System.Xml.Schema.XmlSchemaCollection`
- `System.Xml.Schema.XmlSchemaCollectionEnumerator`
- `System.Xml.Schema.XmlSchemaCollectionNode`
- `System.Xml.Schema.XmlSchemaCompilationSettings`
- `System.Xml.Schema.XmlSchemaComplexContent`
- `System.Xml.Schema.XmlSchemaComplexContentExtension`
- `System.Xml.Schema.XmlSchemaComplexContentRestriction`
- `System.Xml.Schema.XmlSchemaComplexType`
- `System.Xml.Schema.XmlSchemaContent`
- `System.Xml.Schema.XmlSchemaContentModel`
- `System.Xml.Schema.XmlSchemaContentProcessing`
- `System.Xml.Schema.XmlSchemaContentType`
- `System.Xml.Schema.XmlSchemaDatatype`
- `System.Xml.Schema.XmlSchemaDatatypeVariety`
- `System.Xml.Schema.XmlSchemaDerivationMethod`
- `System.Xml.Schema.XmlSchemaDocumentation`
- `System.Xml.Schema.XmlSchemaElement`
- `System.Xml.Schema.XmlSchemaEnumerationFacet`
- `System.Xml.Schema.XmlSchemaException`
- `System.Xml.Schema.XmlSchemaExternal`
- `System.Xml.Schema.XmlSchemaFacet`
- `System.Xml.Schema.XmlSchemaForm`
- `System.Xml.Schema.XmlSchemaFractionDigitsFacet`
- `System.Xml.Schema.XmlSchemaGroup`
- `System.Xml.Schema.XmlSchemaGroupBase`
- `System.Xml.Schema.XmlSchemaGroupRef`
- `System.Xml.Schema.XmlSchemaIdentityConstraint`
- `System.Xml.Schema.XmlSchemaImport`
- `System.Xml.Schema.XmlSchemaInclude`
- `System.Xml.Schema.XmlSchemaInference`
- `System.Xml.Schema.XmlSchemaInferenceException`
- `System.Xml.Schema.XmlSchemaInfo`
- `System.Xml.Schema.XmlSchemaKey`
- `System.Xml.Schema.XmlSchemaKeyref`
- `System.Xml.Schema.XmlSchemaLengthFacet`
- `System.Xml.Schema.XmlSchemaMaxExclusiveFacet`
- `System.Xml.Schema.XmlSchemaMaxInclusiveFacet`
- `System.Xml.Schema.XmlSchemaMaxLengthFacet`
- `System.Xml.Schema.XmlSchemaMinExclusiveFacet`
- `System.Xml.Schema.XmlSchemaMinInclusiveFacet`
- `System.Xml.Schema.XmlSchemaMinLengthFacet`
- `System.Xml.Schema.XmlSchemaNotation`
- `System.Xml.Schema.XmlSchemaNumericFacet`
- `System.Xml.Schema.XmlSchemaObject`
- `System.Xml.Schema.XmlSchemaObjectCollection`
- `System.Xml.Schema.XmlSchemaObjectEnumerator`
- `System.Xml.Schema.XmlSchemaObjectTable`
- `System.Xml.Schema.XmlSchemaParticle`
- `System.Xml.Schema.XmlSchemaPatternFacet`
- `System.Xml.Schema.XmlSchemaRedefine`
- `System.Xml.Schema.XmlSchemaSequence`
- `System.Xml.Schema.XmlSchemaSet`
- `System.Xml.Schema.XmlSchemaSimpleContent`
- `System.Xml.Schema.XmlSchemaSimpleContentExtension`
- `System.Xml.Schema.XmlSchemaSimpleContentRestriction`
- `System.Xml.Schema.XmlSchemaSimpleType`
- `System.Xml.Schema.XmlSchemaSimpleTypeContent`
- `System.Xml.Schema.XmlSchemaSimpleTypeList`
- `System.Xml.Schema.XmlSchemaSimpleTypeRestriction`
- `System.Xml.Schema.XmlSchemaSimpleTypeUnion`
- `System.Xml.Schema.XmlSchemaSubstitutionGroup`
- `System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat`
- `System.Xml.Schema.XmlSchemaTotalDigitsFacet`
- `System.Xml.Schema.XmlSchemaType`
- `System.Xml.Schema.XmlSchemaUnique`
- `System.Xml.Schema.XmlSchemaUse`
- `System.Xml.Schema.XmlSchemaValidationException`
- `System.Xml.Schema.XmlSchemaValidationFlags`
- `System.Xml.Schema.XmlSchemaValidator`
- `System.Xml.Schema.XmlSchemaValidity`
- `System.Xml.Schema.XmlSchemaWhiteSpace`
- `System.Xml.Schema.XmlSchemaWhiteSpaceFacet`
- `System.Xml.Schema.XmlSchemaXPath`
- `System.Xml.Schema.XmlSeverityType`
- `System.Xml.Schema.XmlStringConverter`
- `System.Xml.Schema.XmlTypeCode`
- `System.Xml.Schema.XmlUnionConverter`
- `System.Xml.Schema.XmlUntypedConverter`
- `System.Xml.Schema.XmlValueConverter`
- `System.Xml.Schema.XmlValueGetter`
- `System.Xml.Schema.XsdBuilder`
- `System.Xml.Schema.XsdDateTime`
- `System.Xml.Schema.XsdDateTimeFlags`
- `System.Xml.Schema.XsdDuration`
- `System.Xml.Schema.XsdSimpleValue`
- `System.Xml.Schema.XsdValidator`
- `System.Xml.SecureStringHasher`
- `System.Xml.Serialization.ClassMap`
- `System.Xml.Serialization.CodeIdentifier`
- `System.Xml.Serialization.EnumMap`
- `System.Xml.Serialization.IXmlSerializable`
- `System.Xml.Serialization.IXmlTextParser`
- `System.Xml.Serialization.KeyHelper`
- `System.Xml.Serialization.ListMap`
- `System.Xml.Serialization.ObjectMap`
- `System.Xml.Serialization.ReflectionHelper`
- `System.Xml.Serialization.SchemaTypes`
- `System.Xml.Serialization.SerializationFormat`
- `System.Xml.Serialization.SerializationSource`
- `System.Xml.Serialization.TypeData`
- `System.Xml.Serialization.TypeMember`
- `System.Xml.Serialization.TypeTranslator`
- `System.Xml.Serialization.UnreferencedObjectEventArgs`
- `System.Xml.Serialization.UnreferencedObjectEventHandler`
- `System.Xml.Serialization.XmlAnyAttributeAttribute`
- `System.Xml.Serialization.XmlAnyElementAttribute`
- `System.Xml.Serialization.XmlAnyElementAttributes`
- `System.Xml.Serialization.XmlArrayAttribute`
- `System.Xml.Serialization.XmlArrayItemAttribute`
- `System.Xml.Serialization.XmlArrayItemAttributes`
- `System.Xml.Serialization.XmlAttributeAttribute`
- `System.Xml.Serialization.XmlAttributeEventArgs`
- `System.Xml.Serialization.XmlAttributeEventHandler`
- `System.Xml.Serialization.XmlAttributeOverrides`
- `System.Xml.Serialization.XmlAttributes`
- `System.Xml.Serialization.XmlChoiceIdentifierAttribute`
- `System.Xml.Serialization.XmlCustomFormatter`
- `System.Xml.Serialization.XmlElementAttribute`
- `System.Xml.Serialization.XmlElementAttributes`
- `System.Xml.Serialization.XmlElementEventArgs`
- `System.Xml.Serialization.XmlElementEventHandler`
- `System.Xml.Serialization.XmlEnumAttribute`
- `System.Xml.Serialization.XmlIgnoreAttribute`
- `System.Xml.Serialization.XmlIncludeAttribute`
- `System.Xml.Serialization.XmlMapping`
- `System.Xml.Serialization.XmlMemberMapping`
- `System.Xml.Serialization.XmlMembersMapping`
- `System.Xml.Serialization.XmlNamespaceDeclarationsAttribute`
- `System.Xml.Serialization.XmlNodeEventArgs`
- `System.Xml.Serialization.XmlNodeEventHandler`
- `System.Xml.Serialization.XmlReflectionImporter`
- `System.Xml.Serialization.XmlReflectionMember`
- `System.Xml.Serialization.XmlRootAttribute`
- `System.Xml.Serialization.XmlSchemaProviderAttribute`
- `System.Xml.Serialization.XmlSerializableMapping`
- `System.Xml.Serialization.XmlSerializationCollectionFixupCallback`
- `System.Xml.Serialization.XmlSerializationFixupCallback`
- `System.Xml.Serialization.XmlSerializationGeneratedCode`
- `System.Xml.Serialization.XmlSerializationReadCallback`
- `System.Xml.Serialization.XmlSerializationReader`
- `System.Xml.Serialization.XmlSerializationReaderInterpreter`
- `System.Xml.Serialization.XmlSerializationWriteCallback`
- `System.Xml.Serialization.XmlSerializationWriter`
- `System.Xml.Serialization.XmlSerializationWriterInterpreter`
- `System.Xml.Serialization.XmlSerializer`
- `System.Xml.Serialization.XmlSerializerFactory`
- `System.Xml.Serialization.XmlSerializerImplementation`
- `System.Xml.Serialization.XmlSerializerNamespaces`
- `System.Xml.Serialization.XmlTextAttribute`
- `System.Xml.Serialization.XmlTypeAttribute`
- `System.Xml.Serialization.XmlTypeConvertorAttribute`
- `System.Xml.Serialization.XmlTypeMapElementInfo`
- `System.Xml.Serialization.XmlTypeMapElementInfoList`
- `System.Xml.Serialization.XmlTypeMapMember`
- `System.Xml.Serialization.XmlTypeMapMemberAnyAttribute`
- `System.Xml.Serialization.XmlTypeMapMemberAnyElement`
- `System.Xml.Serialization.XmlTypeMapMemberAttribute`
- `System.Xml.Serialization.XmlTypeMapMemberElement`
- `System.Xml.Serialization.XmlTypeMapMemberExpandable`
- `System.Xml.Serialization.XmlTypeMapMemberFlatList`
- `System.Xml.Serialization.XmlTypeMapMemberList`
- `System.Xml.Serialization.XmlTypeMapMemberNamespaces`
- `System.Xml.Serialization.XmlTypeMapping`
- `System.Xml.Serialization.XmlTypeSerializationSource`
- `System.Xml.TernaryTreeReadOnly`
- `System.Xml.TextEncodedRawTextWriter`
- `System.Xml.TextUtf8RawTextWriter`
- `System.Xml.TriState`
- `System.Xml.UTF16Decoder`
- `System.Xml.Ucs4Decoder`
- `System.Xml.Ucs4Decoder1234`
- `System.Xml.Ucs4Decoder2143`
- `System.Xml.Ucs4Decoder3412`
- `System.Xml.Ucs4Decoder4321`
- `System.Xml.Ucs4Encoding`
- `System.Xml.Ucs4Encoding1234`
- `System.Xml.Ucs4Encoding2143`
- `System.Xml.Ucs4Encoding3412`
- `System.Xml.Ucs4Encoding4321`
- `System.Xml.ValidateNames`
- `System.Xml.ValidatingReaderNodeData`
- `System.Xml.ValidationType`
- `System.Xml.WhitespaceHandling`
- `System.Xml.WriteState`
- `System.Xml.XPath.XPathDocument`
- `System.Xml.XPath.XPathException`
- `System.Xml.XPath.XPathItem`
- `System.Xml.XPath.XPathNamespaceScope`
- `System.Xml.XPath.XPathNavigator`
- `System.Xml.XPath.XPathNavigatorKeyComparer`
- `System.Xml.XPath.XPathNodeType`
- `System.Xml.XPath.XPathResultType`
- `System.Xml.XmlAsyncCheckReader`
- `System.Xml.XmlAsyncCheckReaderWithLineInfo`
- `System.Xml.XmlAsyncCheckReaderWithLineInfoNS`
- `System.Xml.XmlAsyncCheckReaderWithLineInfoNSSchema`
- `System.Xml.XmlAsyncCheckReaderWithNS`
- `System.Xml.XmlAsyncCheckWriter`
- `System.Xml.XmlAttribute`
- `System.Xml.XmlAttributeCollection`
- `System.Xml.XmlAutoDetectWriter`
- `System.Xml.XmlCDataSection`
- `System.Xml.XmlCachedStream`
- `System.Xml.XmlCharType`
- `System.Xml.XmlCharacterData`
- `System.Xml.XmlChildEnumerator`
- `System.Xml.XmlChildNodes`
- `System.Xml.XmlComment`
- `System.Xml.XmlComplianceUtil`
- `System.Xml.XmlConfiguration.XmlReaderSection`
- `System.Xml.XmlConvert`
- `System.Xml.XmlDateTimeSerializationMode`
- `System.Xml.XmlDeclaration`
- `System.Xml.XmlDocument`
- `System.Xml.XmlDocumentFragment`
- `System.Xml.XmlDocumentType`
- `System.Xml.XmlDownloadManager`
- `System.Xml.XmlElement`
- `System.Xml.XmlEncodedRawTextWriter`
- `System.Xml.XmlEncodedRawTextWriterIndent`
- `System.Xml.XmlEntity`
- `System.Xml.XmlEntityReference`
- `System.Xml.XmlEventCache`
- `System.Xml.XmlException`
- `System.Xml.XmlImplementation`
- `System.Xml.XmlLinkedNode`
- `System.Xml.XmlLoader`
- `System.Xml.XmlName`
- `System.Xml.XmlNameEx`
- `System.Xml.XmlNameTable`
- `System.Xml.XmlNamedNodeMap`
- `System.Xml.XmlNamespaceManager`
- `System.Xml.XmlNamespaceScope`
- `System.Xml.XmlNodeChangedAction`
- `System.Xml.XmlNodeChangedEventArgs`
- `System.Xml.XmlNodeChangedEventHandler`
- `System.Xml.XmlNodeList`
- `System.Xml.XmlNodeReader`
- `System.Xml.XmlNodeReaderNavigator`
- `System.Xml.XmlNodeType`
- `System.Xml.XmlNotation`
- `System.Xml.XmlOutputMethod`
- `System.Xml.XmlParserContext`
- `System.Xml.XmlProcessingInstruction`
- `System.Xml.XmlQualifiedName`
- `System.Xml.XmlRawWriter`
- `System.Xml.XmlRawWriterBase64Encoder`
- `System.Xml.XmlReaderSettings`
- `System.Xml.XmlRegisteredNonCachedStream`
- `System.Xml.XmlResolver`
- `System.Xml.XmlSignificantWhitespace`
- `System.Xml.XmlSpace`
- `System.Xml.XmlSqlBinaryReader`
- `System.Xml.XmlStandalone`
- `System.Xml.XmlText`
- `System.Xml.XmlTextEncoder`
- `System.Xml.XmlTextReader`
- `System.Xml.XmlTextReaderImpl`
- `System.Xml.XmlTextWriter`
- `System.Xml.XmlTextWriterBase64Encoder`
- `System.Xml.XmlTokenizedType`
- `System.Xml.XmlUnspecifiedAttribute`
- `System.Xml.XmlUrlResolver`
- `System.Xml.XmlUtf8RawTextWriter`
- `System.Xml.XmlUtf8RawTextWriterIndent`
- `System.Xml.XmlValidatingReader`
- `System.Xml.XmlValidatingReaderImpl`
- `System.Xml.XmlWellFormedWriter`
- `System.Xml.XmlWhitespace`
- `System.Xml.XmlWriter`
- `System.Xml.XmlWriterSettings`
- `System.Xml.XsdCachingReader`
- `System.Xml.XsdValidatingReader`
- `System.Xml.Xsl.Runtime.StringConcat`
- `TypedObject.DecimalStruct`
- `XPathParser.ParamInfo`
- `XPathScanner.LexKind`
- `XdrBuilder.AttributeContent`
- `XdrBuilder.DeclBaseInfo`
- `XdrBuilder.ElementContent`
- `XdrBuilder.GroupContent`
- `XdrBuilder.XdrAttributeEntry`
- `XdrBuilder.XdrBeginChildFunction`
- `XdrBuilder.XdrBuildFunction`
- `XdrBuilder.XdrEndChildFunction`
- `XdrBuilder.XdrEntry`
- `XdrBuilder.XdrInitFunction`
- `XmlAtomicValue.NamespacePrefixForQName`
- `XmlAtomicValue.Union`
- `XmlDownloadManager.<>c__DisplayClass4_0` (compiler-generated name)
- `XmlDownloadManager.<GetNonFileStreamAsync>d__5` (compiler-generated name)
- `XmlEventCache.XmlEvent`
- `XmlEventCache.XmlEventType`
- `XmlNamedNodeMap.SmallXmlNodeList`
- `XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator`
- `XmlNamespaceManager.NamespaceDeclaration`
- `XmlNodeReaderNavigator.VirtualAttribute`
- `XmlQualifiedName.HashCodeOfStringDelegate`
- `XmlReflectionImporter.<>c` (compiler-generated name)
- `XmlSchemaInference.InferenceOption`
- `XmlSchemaObjectTable.EnumeratorType`
- `XmlSchemaObjectTable.ValuesCollection`
- `XmlSchemaObjectTable.XSODictionaryEnumerator`
- `XmlSchemaObjectTable.XSOEnumerator`
- `XmlSchemaObjectTable.XmlSchemaObjectEntry`
- `XmlSchemaParticle.EmptyParticle`
- `XmlSchemaParticle.Occurs`
- `XmlSerializationReader.CollectionFixup`
- `XmlSerializationReader.CollectionItemFixup`
- `XmlSerializationReader.Fixup`
- `XmlSerializationReader.WriteCallbackInfo`
- `XmlSerializationReaderInterpreter.FixupCallbackInfo`
- `XmlSerializationReaderInterpreter.ReaderCallbackInfo`
- `XmlSerializationWriter.WriteCallbackInfo`
- `XmlSerializationWriterInterpreter.CallbackInfo`
- `XmlSerializer.SerializerData`
- `XmlSqlBinaryReader.AttrInfo`
- `XmlSqlBinaryReader.ElemInfo`
- `XmlSqlBinaryReader.NamespaceDecl`
- `XmlSqlBinaryReader.NestedBinXml`
- `XmlSqlBinaryReader.QName`
- `XmlSqlBinaryReader.ScanState`
- `XmlSqlBinaryReader.SymbolTables`
- `XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer`
- `XmlTextReaderImpl.DtdParserProxy`
- `XmlTextReaderImpl.EntityExpandType`
- `XmlTextReaderImpl.EntityType`
- `XmlTextReaderImpl.IncrementalReadState`
- `XmlTextReaderImpl.InitInputType`
- `XmlTextReaderImpl.LaterInitParam`
- `XmlTextReaderImpl.NoNamespaceManager`
- `XmlTextReaderImpl.NodeData`
- `XmlTextReaderImpl.OnDefaultAttributeUseDelegate`
- `XmlTextReaderImpl.ParsingFunction`
- `XmlTextReaderImpl.ParsingMode`
- `XmlTextReaderImpl.ParsingState`
- `XmlTextReaderImpl.XmlContext`
- `XmlTextWriter.Namespace`
- `XmlTextWriter.NamespaceState`
- `XmlTextWriter.SpecialAttr`
- `XmlTextWriter.State`
- `XmlTextWriter.TagInfo`
- `XmlTextWriter.Token`
- `XmlUrlResolver.<GetEntityAsync>d__15` (compiler-generated name)
- `XmlValidatingReaderImpl.ParsingFunction`
- `XmlValidatingReaderImpl.ValidationEventHandling`
- `XmlWellFormedWriter.AttrName`
- `XmlWellFormedWriter.AttributeValueCache`
- `XmlWellFormedWriter.AttributeValueCache.BufferChunk`
- `XmlWellFormedWriter.AttributeValueCache.Item`
- `XmlWellFormedWriter.AttributeValueCache.ItemType`
- `XmlWellFormedWriter.ElementScope`
- `XmlWellFormedWriter.Namespace`
- `XmlWellFormedWriter.NamespaceKind`
- `XmlWellFormedWriter.NamespaceResolverProxy`
- `XmlWellFormedWriter.SpecialAttribute`
- `XmlWellFormedWriter.State`
- `XmlWellFormedWriter.Token`
- `XsdBuilder.BuilderNamespaceManager`
- `XsdBuilder.State`
- `XsdBuilder.XsdAttributeEntry`
- `XsdBuilder.XsdBuildFunction`
- `XsdBuilder.XsdEndChildFunction`
- `XsdBuilder.XsdEntry`
- `XsdBuilder.XsdInitFunction`
- `XsdCachingReader.CachingReaderState`
- `XsdDateTime.DateTimeTypeCode`
- `XsdDateTime.Parser`
- `XsdDateTime.XsdDateTimeKind`
- `XsdDuration.DurationType`
- `XsdDuration.Parts`
- `XsdValidatingReader.ValidatingReaderState`

</details>


## System.dll

<details><summary>Matching: 124</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=128`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=44`
- `CaptureCollection.Enumerator`
- `GroupCollection.Enumerator`
- `IPAddress.ReadOnlyIPAddress`
- `Internal.Cryptography.OidLookup`
- `NameObjectCollectionBase.NameObjectEntry`
- `NameObjectCollectionBase.NameObjectKeysEnumerator`
- `OidLookup.<>c` (compiler-generated name)
- `Regex.CachedCodeEntry`
- `Regex.CachedCodeEntryKey`
- `RegexCharClass.LowerCaseMapping`
- `RegexCharClass.SingleRange`
- `RegexCharClass.SingleRangeComparer`
- `System.CodeDom.Compiler.GeneratedCodeAttribute`
- `System.Collections.Generic.DictionaryKeyCollectionDebugView<TKey, TValue>`
- `System.Collections.Generic.DictionaryValueCollectionDebugView<TKey, TValue>`
- `System.Collections.Generic.ICollectionDebugView<T>`
- `System.Collections.Generic.IDictionaryDebugView<K, V>`
- `System.Collections.Generic.ISet<T>`
- `System.Collections.HashtableExtensions`
- `System.Collections.Specialized.CompatibleComparer`
- `System.Collections.Specialized.NameObjectCollectionBase`
- `System.Collections.Specialized.NameValueCollection`
- `System.Collections.Specialized.StringCollection`
- `System.ComponentModel.ArrayConverter`
- `System.ComponentModel.BaseNumberConverter`
- `System.ComponentModel.BooleanConverter`
- `System.ComponentModel.CollectionConverter`
- `System.ComponentModel.DecimalConverter`
- `System.ComponentModel.DefaultValueAttribute`
- `System.ComponentModel.DisplayNameAttribute`
- `System.ComponentModel.DoubleConverter`
- `System.ComponentModel.EditorBrowsableAttribute`
- `System.ComponentModel.EditorBrowsableState`
- `System.ComponentModel.EnumConverter`
- `System.ComponentModel.Int16Converter`
- `System.ComponentModel.Int32Converter`
- `System.ComponentModel.Int64Converter`
- `System.ComponentModel.SingleConverter`
- `System.ComponentModel.StringConverter`
- `System.ComponentModel.TimeSpanConverter`
- `System.ComponentModel.TypeConverter`
- `System.ComponentModel.TypeConverterAttribute`
- `System.Diagnostics.Stopwatch`
- `System.DomainNameHelper`
- `System.IOAsyncCallback`
- `System.IOOperation`
- `System.IPv4AddressHelper`
- `System.IPv6AddressHelper`
- `System.IriHelper`
- `System.Net.CaseInsensitiveAscii`
- `System.Net.HeaderInfo`
- `System.Net.HeaderInfoTable`
- `System.Net.HeaderParser`
- `System.Net.IPAddressParser`
- `System.Net.Sockets.AddressFamily`
- `System.Net.ValidationHelper`
- `System.Net.WebHeaderCollection`
- `System.Net.WebHeaderCollectionType`
- `System.NotImplemented`
- `System.ParsingError`
- `System.Security.Cryptography.AsnDecodeStatus`
- `System.Security.Cryptography.AsnEncodedData`
- `System.Security.Cryptography.Oid`
- `System.Security.Cryptography.OidCollection`
- `System.Security.Cryptography.OidEnumerator`
- `System.Security.Cryptography.OidGroup`
- `System.Security.Cryptography.X509Certificates.PublicKey`
- `System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension`
- `System.Security.Cryptography.X509Certificates.X509Extension`
- `System.Security.Cryptography.X509Certificates.X509KeyUsageFlags`
- `System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm`
- `System.Text.RegularExpressions.Capture`
- `System.Text.RegularExpressions.CaptureCollection`
- `System.Text.RegularExpressions.CollectionDebuggerProxy<T>`
- `System.Text.RegularExpressions.ExclusiveReference`
- `System.Text.RegularExpressions.Group`
- `System.Text.RegularExpressions.GroupCollection`
- `System.Text.RegularExpressions.Match`
- `System.Text.RegularExpressions.MatchEvaluator`
- `System.Text.RegularExpressions.MatchSparse`
- `System.Text.RegularExpressions.Regex`
- `System.Text.RegularExpressions.RegexBoyerMoore`
- `System.Text.RegularExpressions.RegexCharClass`
- `System.Text.RegularExpressions.RegexCode`
- `System.Text.RegularExpressions.RegexFC`
- `System.Text.RegularExpressions.RegexFCD`
- `System.Text.RegularExpressions.RegexInterpreter`
- `System.Text.RegularExpressions.RegexMatchTimeoutException`
- `System.Text.RegularExpressions.RegexNode`
- `System.Text.RegularExpressions.RegexOptions`
- `System.Text.RegularExpressions.RegexParser`
- `System.Text.RegularExpressions.RegexPrefix`
- `System.Text.RegularExpressions.RegexReplacement`
- `System.Text.RegularExpressions.RegexRunner`
- `System.Text.RegularExpressions.RegexRunnerFactory`
- `System.Text.RegularExpressions.RegexTree`
- `System.Text.RegularExpressions.RegexWriter`
- `System.UncNameHelper`
- `System.UnescapeMode`
- `System.Uri`
- `System.UriComponents`
- `System.UriFormat`
- `System.UriFormatException`
- `System.UriHelper`
- `System.UriIdnScope`
- `System.UriKind`
- `System.UriParser`
- `System.UriSyntaxFlags`
- `System.UriTypeConverter`
- `Unity.ThrowStub`
- `Uri.Check`
- `Uri.Flags`
- `Uri.Offset`
- `Uri.UriInfo`
- `UriParser.BuiltInUriParser`
- `UriParser.UriQuirksVersion`
- `WebHeaderCollection.RfcChar`

</details>

<details><summary>Mismatching: 10</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A', '04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5', '063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374', '1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B', '27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811', '2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70', '3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C', '356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF', '6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885', '8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3', '9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8', '9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A', 'B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C', 'BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859', 'DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5', 'E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A'] → ['00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A', '04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5', '063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374', '1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B', '2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70', '3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C', '356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF', '8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3', '9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8', 'B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C', 'E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A']`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811`
  - `2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70: offset '0x151' → '0x148'`
  - `3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C: offset '0x178' → '0x168'`
  - `356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF: offset '0x180' → '0x170'`
  - `missing field static long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885`
  - `8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3: offset '0x198' → '0x17c'`
  - `9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8: offset '0x218' → '0x1fc'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A`
  - `B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C: offset '0x24a' → '0x228'`
  - `missing field static long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5`
  - `E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A: offset '0x2e6' → '0x2a8'`

- `System.Collections.Generic.SortedList<TKey, TValue>`

  - `field declaration order/names: ['keys', 'values', '_size', 'version', 'comparer', 'keyList', 'valueList', '_syncRoot', 'DefaultCapacity', 'MaxArrayLength'] → ['keys', 'values', '_size', 'version', 'comparer', 'keyList', 'valueList', '_syncRoot']`
  - `missing field constant int DefaultCapacity`
  - `missing field constant int MaxArrayLength`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.IOAsyncResult`

  - `bases: 'IAsyncResult' → ''`

- `System.IOSelectorJob`

  - `bases: 'IThreadPoolWorkItem' → ''`

- `System.Net.IPAddress`

  - `field declaration order/names: ['Any', 'Loopback', 'Broadcast', 'None', 'IPv6Any', 'IPv6Loopback', 'IPv6None', '_addressOrScopeId', '_numbers', '_toString', '_hashCode'] → ['Any', 'Loopback', 'Broadcast', 'None', 'LoopbackMask', 'IPv6Any', 'IPv6Loopback', 'IPv6None', '_addressOrScopeId', '_numbers', '_toString', '_hashCode', 'NumberOfLabels']`
  - `extra field constant long LoopbackMask`
  - `extra field constant int NumberOfLabels`

- `System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension`

  - `field declaration order/names: ['_certificateAuthority', '_hasPathLengthConstraint', '_pathLengthConstraint', '_status'] → ['oid', 'friendlyName', '_certificateAuthority', '_hasPathLengthConstraint', '_pathLengthConstraint', '_status']`
  - `extra field constant string oid`
  - `extra field constant string friendlyName`

- `System.Security.Cryptography.X509Certificates.X509KeyUsageExtension`

  - `field declaration order/names: ['_keyUsages', '_status'] → ['oid', 'friendlyName', 'all', '_keyUsages', '_status']`
  - `extra field constant string oid`
  - `extra field constant string friendlyName`
  - `extra field constant X509KeyUsageFlags all`

- `System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension`

  - `field declaration order/names: ['_subjectKeyIdentifier', '_ski', '_status'] → ['oid', 'friendlyName', '_subjectKeyIdentifier', '_ski', '_status']`
  - `extra field constant string oid`
  - `extra field constant string friendlyName`

- `TypeConverter.StandardValuesCollection`

  - `bases: 'ICollection, IEnumerable' → ''`
  - `field declaration order/names: ['values', 'valueArray'] → []`
  - `missing field instance ICollection values`
  - `missing field instance Array valueArray`

- `Uri.MoreInfo`

  - `field declaration order/names: ['Path', 'Query', 'Fragment', 'AbsoluteUri', 'Hash', 'RemoteUrl'] → ['AbsoluteUri', 'Hash', 'RemoteUrl']`
  - `missing field instance string Path`
  - `missing field instance string Query`
  - `missing field instance string Fragment`
  - `AbsoluteUri: offset '0x28' → '0x10'`
  - `Hash: offset '0x30' → '0x18'`
  - `RemoteUrl: offset '0x38' → '0x20'`


</details>

<details><summary>Indeterminate: 9</summary>

- `LinkedList.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortedList.Enumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortedList.KeyList<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortedList.SortedListKeyEnumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortedList.SortedListValueEnumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortedList.ValueList<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.LinkedList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.LinkedListNode<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.ValueListBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 620</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=14`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=9`
- `ArrayConverter.ArrayPropertyDescriptor`
- `AsyncProtocolRequest.<InnerRead>d__25` (compiler-generated name)
- `AsyncProtocolRequest.<ProcessOperation>d__24` (compiler-generated name)
- `AsyncProtocolRequest.<StartOperation>d__23` (compiler-generated name)
- `AttributeCollection.AttributeEntry`
- `BufferedReadStream.<ProcessReadAsync>d__2` (compiler-generated name)
- `CallbackHelpers.<>c__DisplayClass0_0` (compiler-generated name)
- `CallbackHelpers.<>c__DisplayClass6_0` (compiler-generated name)
- `CertificateData.<ReadReverseRdns>d__21` (compiler-generated name)
- `CertificateData.AlgorithmIdentifier`
- `ChainValidationHelper.<>c__DisplayClass11_0` (compiler-generated name)
- `CommandStream.PipelineEntry`
- `CommandStream.PipelineEntryFlags`
- `CommandStream.PipelineInstruction`
- `ConcurrentBag.Enumerator<T>`
- `ConcurrentBag.WorkStealingQueue<T>`
- `ContentDecodeStream.Mode`
- `ContextAwareResult.<>c` (compiler-generated name)
- `ContextAwareResult.StateFlags`
- `CookieCollection.CookieCollectionEnumerator`
- `CookieCollection.Stamp`
- `CookieTokenizer.RecognizedAttribute`
- `CultureInfoConverter.CultureComparer`
- `CultureInfoConverter.CultureInfoMapper`
- `DeflateStream.ReadMethod`
- `DeflateStream.WriteMethod`
- `DeflateStreamNative.SafeDeflateStreamHandle`
- `DeflateStreamNative.UnmanagedReadOrWrite`
- `DerSequenceReader.<>c` (compiler-generated name)
- `DerSequenceReader.DerTag`
- `DesignerOptionService.DesignerOptionCollection`
- `DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor`
- `DesignerOptionService.DesignerOptionConverter`
- `DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor`
- `Dns.GetHostAddressesCallback`
- `EventDescriptorCollection.ArraySubsetEnumerator`
- `EventHandlerList.ListEntry`
- `FixedSizeReadStream.<ProcessReadAsync>d__5` (compiler-generated name)
- `FtpControlStream.<>c__DisplayClass31_0` (compiler-generated name)
- `FtpControlStream.GetPathOption`
- `FtpWebRequest.<>c` (compiler-generated name)
- `FtpWebRequest.<CreateConnectionAsync>d__86` (compiler-generated name)
- `FtpWebRequest.RequestStage`
- `FtpWebResponse.EmptyStream`
- `HttpEncoder.<>c` (compiler-generated name)
- `HttpUtility.HttpQSCollection`
- `HttpWebRequest.<<GetRewriteHandler>b__271_0>d` (compiler-generated name)
- `HttpWebRequest.<>c__241<T>` (compiler-generated name)
- `HttpWebRequest.<GetResponseFromData>d__244` (compiler-generated name)
- `HttpWebRequest.<MyGetResponseAsync>d__243` (compiler-generated name)
- `HttpWebRequest.<RunWithTimeoutWorker>d__241<T>` (compiler-generated name)
- `HttpWebRequest.AuthorizationState`
- `HttpWebRequest.NtlmAuthState`
- `Internal.Cryptography.Pal.CertificateData`
- `Internal.Cryptography.Pal.GeneralNameType`
- `LazyAsyncResult.ThreadContext`
- `ListDictionary.DictionaryNode`
- `ListDictionary.NodeEnumerator`
- `ListDictionary.NodeKeyValueCollection`
- `ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator`
- `MatchCollection.Enumerator`
- `Microsoft.Win32.NativeMethods`
- `Microsoft.Win32.SafeHandles.SafeProcessHandle`
- `MobileAuthenticatedStream.<>c__DisplayClass66_0` (compiler-generated name)
- `MobileAuthenticatedStream.<InnerRead>d__66` (compiler-generated name)
- `MobileAuthenticatedStream.<InnerWrite>d__67` (compiler-generated name)
- `MobileAuthenticatedStream.<ProcessAuthentication>d__48` (compiler-generated name)
- `MobileAuthenticatedStream.<StartOperation>d__57` (compiler-generated name)
- `MobileAuthenticatedStream.Operation`
- `MobileAuthenticatedStream.OperationType`
- `Mono.Http.NtlmClient`
- `Mono.Http.NtlmSession`
- `Mono.Net.Security.AsyncHandshakeRequest`
- `Mono.Net.Security.AsyncOperationStatus`
- `Mono.Net.Security.AsyncProtocolRequest`
- `Mono.Net.Security.AsyncProtocolResult`
- `Mono.Net.Security.AsyncReadOrWriteRequest`
- `Mono.Net.Security.AsyncReadRequest`
- `Mono.Net.Security.AsyncWriteRequest`
- `Mono.Net.Security.BufferOffsetSize`
- `Mono.Net.Security.BufferOffsetSize2`
- `Mono.Net.Security.ChainValidationHelper`
- `Mono.Net.Security.MobileAuthenticatedStream`
- `Mono.Net.Security.MobileTlsContext`
- `Mono.Net.Security.MobileTlsProvider`
- `Mono.Net.Security.MonoSslAuthenticationOptions`
- `Mono.Net.Security.MonoSslClientAuthenticationOptions`
- `Mono.Net.Security.MonoTlsProviderFactory`
- `Mono.Net.Security.MonoTlsStream`
- `Mono.Net.Security.NoReflectionHelper`
- `Mono.Net.Security.Private.CallbackHelpers`
- `Mono.Net.Security.SystemCertificateValidator`
- `Mono.SystemCertificateProvider`
- `Mono.SystemDependencyProvider`
- `Mono.Unity.CertHelper`
- `Mono.Unity.Debug`
- `Mono.Unity.UnityTls`
- `Mono.Unity.UnityTlsContext`
- `Mono.Unity.UnityTlsConversions`
- `Mono.Unity.UnityTlsProvider`
- `Mono.Unity.UnityTlsStream`
- `Mono.Unity.X509ChainImplUnityTls`
- `Mono.Util.MonoPInvokeCallbackAttribute`
- `Mono.X509Pal`
- `Mono.X509PalImpl`
- `Mono.X509PalImplMono`
- `MonoChunkParser.Chunk`
- `MonoChunkParser.State`
- `MonoChunkStream.<FinishReading>d__8` (compiler-generated name)
- `MonoChunkStream.<ProcessReadAsync>d__7` (compiler-generated name)
- `MonoTlsStream.<CreateStream>d__18` (compiler-generated name)
- `NetEventSource.Keywords`
- `NtlmClient.<>c` (compiler-generated name)
- `ObservableCollection.SimpleMonitor<T>`
- `OrderedDictionary.OrderedDictionaryEnumerator`
- `OrderedDictionary.OrderedDictionaryKeyValueCollection`
- `PathList.PathListComparer`
- `Process.ProcInfo`
- `Process.State`
- `Process.StreamReadMode`
- `PropertyDescriptorCollection.PropertyDescriptorEnumerator`
- `ReferenceConverter.ReferenceComparer`
- `ReflectTypeDescriptionProvider.ReflectedTypeData`
- `ServerCertValidationCallback.CallbackContext`
- `ServicePointManager.SPKey`
- `ServicePointScheduler.<RunScheduler>d__32` (compiler-generated name)
- `ServicePointScheduler.<WaitAsync>d__46` (compiler-generated name)
- `ServicePointScheduler.AsyncManualResetEvent`
- `ServicePointScheduler.AsyncManualResetEvent.<>c` (compiler-generated name)
- `ServicePointScheduler.ConnectionGroup`
- `Socket.<>c` (compiler-generated name)
- `Socket.<>c__DisplayClass240_0` (compiler-generated name)
- `Socket.<>c__DisplayClass298_0` (compiler-generated name)
- `Socket.<>c__DisplayClass355_0` (compiler-generated name)
- `Socket.AwaitableSocketAsyncEventArgs`
- `Socket.AwaitableSocketAsyncEventArgs.<>c` (compiler-generated name)
- `Socket.CachedEventArgs`
- `Socket.Int32TaskSocketAsyncEventArgs`
- `Socket.TaskSocketAsyncEventArgs<TResult>`
- `Socket.WSABUF`
- `SocketAsyncResult.<>c` (compiler-generated name)
- `SortedDictionary.<>c__DisplayClass34_0<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.<>c__DisplayClass34_1<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.Enumerator<TKey, TValue>`
- `SortedDictionary.KeyCollection.<>c__DisplayClass5_0<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.KeyCollection.<>c__DisplayClass6_0<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.KeyCollection.Enumerator<TKey, TValue>`
- `SortedDictionary.KeyCollection<TKey, TValue>`
- `SortedDictionary.KeyValuePairComparer<TKey, TValue>`
- `SortedDictionary.ValueCollection.<>c__DisplayClass5_0<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.ValueCollection.<>c__DisplayClass6_0<TKey, TValue>` (compiler-generated name)
- `SortedDictionary.ValueCollection.Enumerator<TKey, TValue>`
- `SortedDictionary.ValueCollection<TKey, TValue>`
- `SortedSet.<>c__DisplayClass52_0<T>` (compiler-generated name)
- `SortedSet.<>c__DisplayClass53_0<T>` (compiler-generated name)
- `SortedSet.Enumerator<T>`
- `SortedSet.Node<T>`
- `SslStream.<>c__DisplayClass21_0` (compiler-generated name)
- `System.Collections.Concurrent.ConcurrentBag<T>`
- `System.Collections.Generic.CollectionDebugView<T>`
- `System.Collections.Generic.NodeColor`
- `System.Collections.Generic.SortedDictionary<TKey, TValue>`
- `System.Collections.Generic.SortedSet<T>`
- `System.Collections.Generic.TreeRotation`
- `System.Collections.Generic.TreeSet<T>`
- `System.Collections.Generic.TreeWalkPredicate<T>`
- `System.Collections.ObjectModel.EventArgsCache`
- `System.Collections.ObjectModel.ObservableCollection<T>`
- `System.Collections.ObjectModel.ReadOnlyObservableCollection<T>`
- `System.Collections.Specialized.BitVector32`
- `System.Collections.Specialized.CaseSensitiveStringDictionary`
- `System.Collections.Specialized.INotifyCollectionChanged`
- `System.Collections.Specialized.ListDictionary`
- `System.Collections.Specialized.NotifyCollectionChangedAction`
- `System.Collections.Specialized.NotifyCollectionChangedEventArgs`
- `System.Collections.Specialized.NotifyCollectionChangedEventHandler`
- `System.Collections.Specialized.OrderedDictionary`
- `System.Collections.Specialized.ReadOnlyList`
- `System.Collections.Specialized.StringDictionary`
- `System.ComponentModel.AmbientValueAttribute`
- `System.ComponentModel.AttributeCollection`
- `System.ComponentModel.AttributeProviderAttribute`
- `System.ComponentModel.BrowsableAttribute`
- `System.ComponentModel.ByteConverter`
- `System.ComponentModel.CharConverter`
- `System.ComponentModel.CollectionChangeAction`
- `System.ComponentModel.CollectionChangeEventArgs`
- `System.ComponentModel.CollectionChangeEventHandler`
- `System.ComponentModel.Component`
- `System.ComponentModel.ComponentCollection`
- `System.ComponentModel.ComponentConverter`
- `System.ComponentModel.CultureInfoConverter`
- `System.ComponentModel.CustomTypeDescriptor`
- `System.ComponentModel.DateTimeConverter`
- `System.ComponentModel.DateTimeOffsetConverter`
- `System.ComponentModel.DefaultEventAttribute`
- `System.ComponentModel.DefaultPropertyAttribute`
- `System.ComponentModel.DelegatingTypeDescriptionProvider`
- `System.ComponentModel.DescriptionAttribute`
- `System.ComponentModel.Design.CheckoutException`
- `System.ComponentModel.Design.DesignerOptionService`
- `System.ComponentModel.Design.IComponentChangeService`
- `System.ComponentModel.Design.IDesigner`
- `System.ComponentModel.Design.IDesignerHost`
- `System.ComponentModel.Design.IDictionaryService`
- `System.ComponentModel.Design.IExtenderListService`
- `System.ComponentModel.Design.IReferenceService`
- `System.ComponentModel.Design.ITypeDescriptorFilterService`
- `System.ComponentModel.Design.Serialization.InstanceDescriptor`
- `System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute`
- `System.ComponentModel.DesignOnlyAttribute`
- `System.ComponentModel.DesignTimeVisibleAttribute`
- `System.ComponentModel.DesignerCategoryAttribute`
- `System.ComponentModel.DesignerSerializationVisibility`
- `System.ComponentModel.DesignerSerializationVisibilityAttribute`
- `System.ComponentModel.EditorAttribute`
- `System.ComponentModel.EventDescriptor`
- `System.ComponentModel.EventDescriptorCollection`
- `System.ComponentModel.EventHandlerList`
- `System.ComponentModel.ExpandableObjectConverter`
- `System.ComponentModel.ExtendedPropertyDescriptor`
- `System.ComponentModel.ExtenderProvidedPropertyAttribute`
- `System.ComponentModel.GuidConverter`
- `System.ComponentModel.IBindingList`
- `System.ComponentModel.IChangeTracking`
- `System.ComponentModel.IComponent`
- `System.ComponentModel.IContainer`
- `System.ComponentModel.ICustomTypeDescriptor`
- `System.ComponentModel.IExtenderProvider`
- `System.ComponentModel.INotifyPropertyChanged`
- `System.ComponentModel.IRevertibleChangeTracking`
- `System.ComponentModel.ISite`
- `System.ComponentModel.ISynchronizeInvoke`
- `System.ComponentModel.ITypeDescriptorContext`
- `System.ComponentModel.InvalidEnumArgumentException`
- `System.ComponentModel.ListBindableAttribute`
- `System.ComponentModel.ListChangedEventArgs`
- `System.ComponentModel.ListChangedEventHandler`
- `System.ComponentModel.ListChangedType`
- `System.ComponentModel.MarshalByValueComponent`
- `System.ComponentModel.MemberDescriptor`
- `System.ComponentModel.MultilineStringConverter`
- `System.ComponentModel.NotifyParentPropertyAttribute`
- `System.ComponentModel.NullableConverter`
- `System.ComponentModel.PropertyChangedEventArgs`
- `System.ComponentModel.PropertyChangedEventHandler`
- `System.ComponentModel.PropertyChangingEventArgs`
- `System.ComponentModel.PropertyChangingEventHandler`
- `System.ComponentModel.PropertyDescriptor`
- `System.ComponentModel.PropertyDescriptorCollection`
- `System.ComponentModel.ProvidePropertyAttribute`
- `System.ComponentModel.ReadOnlyAttribute`
- `System.ComponentModel.ReferenceConverter`
- `System.ComponentModel.ReflectPropertyDescriptor`
- `System.ComponentModel.ReflectTypeDescriptionProvider`
- `System.ComponentModel.RefreshEventArgs`
- `System.ComponentModel.RefreshEventHandler`
- `System.ComponentModel.RefreshProperties`
- `System.ComponentModel.RefreshPropertiesAttribute`
- `System.ComponentModel.SByteConverter`
- `System.ComponentModel.SettingsBindableAttribute`
- `System.ComponentModel.ToolboxItemAttribute`
- `System.ComponentModel.TypeDescriptionProvider`
- `System.ComponentModel.TypeDescriptionProviderAttribute`
- `System.ComponentModel.TypeDescriptor`
- `System.ComponentModel.TypeListConverter`
- `System.ComponentModel.UInt16Converter`
- `System.ComponentModel.UInt32Converter`
- `System.ComponentModel.UInt64Converter`
- `System.ComponentModel.WeakHashtable`
- `System.ComponentModel.Win32Exception`
- `System.Diagnostics.AsyncStreamReader`
- `System.Diagnostics.BooleanSwitch`
- `System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute`
- `System.Diagnostics.MonitoringDescriptionAttribute`
- `System.Diagnostics.Process`
- `System.Diagnostics.ProcessInfo`
- `System.Diagnostics.ProcessModuleCollection`
- `System.Diagnostics.ProcessStartInfo`
- `System.Diagnostics.ProcessThreadCollection`
- `System.Diagnostics.ProcessWaitHandle`
- `System.Diagnostics.ProcessWindowStyle`
- `System.Diagnostics.Switch`
- `System.Diagnostics.SwitchLevelAttribute`
- `System.Diagnostics.TraceLevel`
- `System.Diagnostics.TraceSwitch`
- `System.IO.Compression.CompressionLevel`
- `System.IO.Compression.CompressionMode`
- `System.IO.Compression.DeflateStream`
- `System.IO.Compression.DeflateStreamNative`
- `System.IO.Compression.GZipStream`
- `System.IO.InvalidDataException`
- `System.IOSelector`
- `System.InvariantComparer`
- `System.LocalAppContextSwitches`
- `System.Net.AuthenticationManager`
- `System.Net.Authorization`
- `System.Net.AutoWebProxyScriptEngine`
- `System.Net.BasicClient`
- `System.Net.BindIPEndPoint`
- `System.Net.BufferOffsetSize`
- `System.Net.BufferedReadStream`
- `System.Net.Cache.RequestCache`
- `System.Net.Cache.RequestCacheBinding`
- `System.Net.Cache.RequestCacheLevel`
- `System.Net.Cache.RequestCacheManager`
- `System.Net.Cache.RequestCachePolicy`
- `System.Net.Cache.RequestCacheProtocol`
- `System.Net.Cache.RequestCacheValidator`
- `System.Net.Cache.RequestCachingSectionInternal`
- `System.Net.CloseExState`
- `System.Net.CommandStream`
- `System.Net.Comparer`
- `System.Net.Configuration.DefaultProxySectionInternal`
- `System.Net.Configuration.SettingsSectionInternal`
- `System.Net.ContentDecodeStream`
- `System.Net.ContextAwareResult`
- `System.Net.Cookie`
- `System.Net.CookieCollection`
- `System.Net.CookieContainer`
- `System.Net.CookieException`
- `System.Net.CookieParser`
- `System.Net.CookieToken`
- `System.Net.CookieTokenizer`
- `System.Net.CookieVariant`
- `System.Net.CredentialCache`
- `System.Net.DecompressionMethods`
- `System.Net.DefaultCertificatePolicy`
- `System.Net.DigestClient`
- `System.Net.DigestHeaderParser`
- `System.Net.DigestSession`
- `System.Net.Dns`
- `System.Net.EndPoint`
- `System.Net.ExceptionHelper`
- `System.Net.FileWebRequest`
- `System.Net.FileWebRequestCreator`
- `System.Net.FileWebResponse`
- `System.Net.FileWebStream`
- `System.Net.FixedSizeReadStream`
- `System.Net.FtpControlStream`
- `System.Net.FtpDataStream`
- `System.Net.FtpLoginState`
- `System.Net.FtpMethodFlags`
- `System.Net.FtpMethodInfo`
- `System.Net.FtpOperation`
- `System.Net.FtpStatusCode`
- `System.Net.FtpWebRequest`
- `System.Net.FtpWebRequestCreator`
- `System.Net.FtpWebResponse`
- `System.Net.HeaderVariantInfo`
- `System.Net.HttpContinueDelegate`
- `System.Net.HttpProtocolUtils`
- `System.Net.HttpRequestCreator`
- `System.Net.HttpRequestHeader`
- `System.Net.HttpStatusCode`
- `System.Net.HttpStatusDescription`
- `System.Net.HttpValidationHelpers`
- `System.Net.HttpVersion`
- `System.Net.HttpWebRequest`
- `System.Net.HttpWebResponse`
- `System.Net.IAuthenticationModule`
- `System.Net.ICertificatePolicy`
- `System.Net.ICloseEx`
- `System.Net.ICredentialPolicy`
- `System.Net.ICredentials`
- `System.Net.IPEndPoint`
- `System.Net.IPHostEntry`
- `System.Net.IWebProxy`
- `System.Net.IWebRequestCreate`
- `System.Net.InternalException`
- `System.Net.KnownHttpVerb`
- `System.Net.LazyAsyncResult`
- `System.Net.Logging`
- `System.Net.Mail.DomainLiteralReader`
- `System.Net.Mail.DotAtomReader`
- `System.Net.Mail.MailAddress`
- `System.Net.Mail.MailAddressParser`
- `System.Net.Mail.QuotedPairReader`
- `System.Net.Mail.QuotedStringFormatReader`
- `System.Net.Mail.WhitespaceReader`
- `System.Net.Mime.EncodedStreamFactory`
- `System.Net.Mime.MailBnfHelper`
- `System.Net.MonoChunkParser`
- `System.Net.MonoChunkStream`
- `System.Net.NclUtilities`
- `System.Net.NetEventSource`
- `System.Net.NetRes`
- `System.Net.NetworkCredential`
- `System.Net.NetworkInformation.CommonUnixIPGlobalProperties`
- `System.Net.NetworkInformation.IPGlobalProperties`
- `System.Net.NetworkInformation.IPGlobalPropertiesFactoryPal`
- `System.Net.NetworkInformation.MibIPGlobalProperties`
- `System.Net.NetworkInformation.NetworkInformationException`
- `System.Net.NetworkInformation.NetworkInterfaceComponent`
- `System.Net.NetworkInformation.UnixIPGlobalProperties`
- `System.Net.NetworkInformation.UnixIPGlobalPropertiesFactoryPal`
- `System.Net.NetworkInformation.UnixNoLibCIPGlobalProperties`
- `System.Net.NetworkStreamWrapper`
- `System.Net.NtlmClient`
- `System.Net.PathList`
- `System.Net.ProtocolViolationException`
- `System.Net.ReadState`
- `System.Net.ReceiveState`
- `System.Net.ResponseDescription`
- `System.Net.Security.AuthenticatedStream`
- `System.Net.Security.AuthenticationLevel`
- `System.Net.Security.CertificateHelper`
- `System.Net.Security.EncryptionPolicy`
- `System.Net.Security.LocalCertSelectionCallback`
- `System.Net.Security.LocalCertificateSelectionCallback`
- `System.Net.Security.RemoteCertificateValidationCallback`
- `System.Net.Security.ServerCertSelectionCallback`
- `System.Net.Security.SslClientAuthenticationOptions`
- `System.Net.Security.SslPolicyErrors`
- `System.Net.Security.SslStream`
- `System.Net.SecurityProtocolType`
- `System.Net.ServerCertValidationCallback`
- `System.Net.ServicePoint`
- `System.Net.ServicePointManager`
- `System.Net.ServicePointScheduler`
- `System.Net.SocketAddress`
- `System.Net.Sockets.IOControlCode`
- `System.Net.Sockets.IPProtectionLevel`
- `System.Net.Sockets.LingerOption`
- `System.Net.Sockets.MulticastOption`
- `System.Net.Sockets.NetworkStream`
- `System.Net.Sockets.ProtocolType`
- `System.Net.Sockets.SafeSocketHandle`
- `System.Net.Sockets.SelectMode`
- `System.Net.Sockets.Socket`
- `System.Net.Sockets.SocketAsyncEventArgs`
- `System.Net.Sockets.SocketAsyncOperation`
- `System.Net.Sockets.SocketAsyncResult`
- `System.Net.Sockets.SocketError`
- `System.Net.Sockets.SocketException`
- `System.Net.Sockets.SocketFlags`
- `System.Net.Sockets.SocketOperation`
- `System.Net.Sockets.SocketOptionLevel`
- `System.Net.Sockets.SocketOptionName`
- `System.Net.Sockets.SocketShutdown`
- `System.Net.Sockets.SocketType`
- `System.Net.Sockets.TcpClient`
- `System.Net.SystemNetworkCredential`
- `System.Net.TcpValidationHelpers`
- `System.Net.TimerThread`
- `System.Net.TlsStream`
- `System.Net.TransportContext`
- `System.Net.TriState`
- `System.Net.UnsafeNclNativeMethods`
- `System.Net.WebCompletionSource`
- `System.Net.WebCompletionSource<T>`
- `System.Net.WebConnection`
- `System.Net.WebConnectionStream`
- `System.Net.WebConnectionTunnel`
- `System.Net.WebException`
- `System.Net.WebExceptionInternalStatus`
- `System.Net.WebExceptionMapping`
- `System.Net.WebExceptionStatus`
- `System.Net.WebOperation`
- `System.Net.WebProxy`
- `System.Net.WebReadStream`
- `System.Net.WebRequest`
- `System.Net.WebRequestPrefixElement`
- `System.Net.WebRequestStream`
- `System.Net.WebResponse`
- `System.Net.WebResponseStream`
- `System.PasteArguments`
- `System.Security.Authentication.AuthenticationException`
- `System.Security.Authentication.SslProtocols`
- `System.Security.Cryptography.DerSequenceReader`
- `System.Security.Cryptography.X509Certificates.OpenFlags`
- `System.Security.Cryptography.X509Certificates.StoreLocation`
- `System.Security.Cryptography.X509Certificates.StoreName`
- `System.Security.Cryptography.X509Certificates.X500DistinguishedName`
- `System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags`
- `System.Security.Cryptography.X509Certificates.X509Certificate2`
- `System.Security.Cryptography.X509Certificates.X509Certificate2Collection`
- `System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator`
- `System.Security.Cryptography.X509Certificates.X509Certificate2Impl`
- `System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono`
- `System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix`
- `System.Security.Cryptography.X509Certificates.X509CertificateCollection`
- `System.Security.Cryptography.X509Certificates.X509CertificateImplCollection`
- `System.Security.Cryptography.X509Certificates.X509Chain`
- `System.Security.Cryptography.X509Certificates.X509ChainElement`
- `System.Security.Cryptography.X509Certificates.X509ChainElementCollection`
- `System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator`
- `System.Security.Cryptography.X509Certificates.X509ChainImpl`
- `System.Security.Cryptography.X509Certificates.X509ChainImplMono`
- `System.Security.Cryptography.X509Certificates.X509ChainPolicy`
- `System.Security.Cryptography.X509Certificates.X509ChainStatus`
- `System.Security.Cryptography.X509Certificates.X509ChainStatusFlags`
- `System.Security.Cryptography.X509Certificates.X509ExtensionCollection`
- `System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator`
- `System.Security.Cryptography.X509Certificates.X509FindType`
- `System.Security.Cryptography.X509Certificates.X509Helper2`
- `System.Security.Cryptography.X509Certificates.X509NameType`
- `System.Security.Cryptography.X509Certificates.X509RevocationFlag`
- `System.Security.Cryptography.X509Certificates.X509RevocationMode`
- `System.Security.Cryptography.X509Certificates.X509Store`
- `System.Security.Cryptography.X509Certificates.X509VerificationFlags`
- `System.SecurityUtils`
- `System.StringExtensions`
- `System.Text.RegularExpressions.MatchCollection`
- `System.UriBuilder`
- `System.UriHostNameType`
- `System.Web.HttpUtility`
- `System.Web.Util.Helpers`
- `System.Web.Util.HttpEncoder`
- `TimerThread.Callback`
- `TimerThread.InfiniteTimer`
- `TimerThread.InfiniteTimerQueue`
- `TimerThread.Queue`
- `TimerThread.Timer`
- `TimerThread.TimerNode`
- `TimerThread.TimerNode.TimerState`
- `TimerThread.TimerQueue`
- `TypeConverter.SimplePropertyDescriptor`
- `TypeDescriptionProvider.EmptyCustomTypeDescriptor`
- `TypeDescriptor.AttributeFilterCacheItem`
- `TypeDescriptor.FilterCacheItem`
- `TypeDescriptor.IUnimplemented`
- `TypeDescriptor.MemberDescriptorComparer`
- `TypeDescriptor.MergedTypeDescriptor`
- `TypeDescriptor.TypeDescriptionNode`
- `TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor`
- `TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor`
- `TypeDescriptor.TypeDescriptorComObject`
- `TypeDescriptor.TypeDescriptorInterface`
- `UnityTls.unitytls_ciphersuite`
- `UnityTls.unitytls_error_code`
- `UnityTls.unitytls_errorstate`
- `UnityTls.unitytls_interface_struct`
- `UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t`
- `UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t`
- `UnityTls.unitytls_interface_struct.unitytls_key_free_t`
- `UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t`
- `UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t`
- `UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t`
- `UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_level_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t`
- `UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_append_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_create_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_free_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t`
- `UnityTls.unitytls_interface_struct.unitytls_x509verify_result_to_string_t`
- `UnityTls.unitytls_key`
- `UnityTls.unitytls_key_ref`
- `UnityTls.unitytls_log_level`
- `UnityTls.unitytls_protocol`
- `UnityTls.unitytls_tlsctx`
- `UnityTls.unitytls_tlsctx_callbacks`
- `UnityTls.unitytls_tlsctx_certificate_callback`
- `UnityTls.unitytls_tlsctx_protocolrange`
- `UnityTls.unitytls_tlsctx_read_callback`
- `UnityTls.unitytls_tlsctx_trace_callback`
- `UnityTls.unitytls_tlsctx_write_callback`
- `UnityTls.unitytls_tlsctx_x509verify_callback`
- `UnityTls.unitytls_x509_ref`
- `UnityTls.unitytls_x509list`
- `UnityTls.unitytls_x509list_ref`
- `UnityTls.unitytls_x509name`
- `UnityTls.unitytls_x509verify_callback`
- `UnityTls.unitytls_x509verify_result`
- `UnsafeNclNativeMethods.HttpApi`
- `UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID`
- `UnsafeNclNativeMethods.SecureStringHelper`
- `WeakHashtable.WeakKeyComparer`
- `WebCompletionSource.<WaitForCompletion>d__15<T>` (compiler-generated name)
- `WebCompletionSource.Result<T>`
- `WebCompletionSource.Status<T>`
- `WebConnection.<>c` (compiler-generated name)
- `WebConnection.<Connect>d__16` (compiler-generated name)
- `WebConnection.<CreateStream>d__18` (compiler-generated name)
- `WebConnection.<InitConnection>d__19` (compiler-generated name)
- `WebConnectionTunnel.<Initialize>d__42` (compiler-generated name)
- `WebConnectionTunnel.<ReadHeaders>d__43` (compiler-generated name)
- `WebConnectionTunnel.NtlmAuthState`
- `WebOperation.<GetRequestStream>d__50` (compiler-generated name)
- `WebOperation.<Run>d__58` (compiler-generated name)
- `WebReadStream.<ReadAsync>d__28` (compiler-generated name)
- `WebRequest.<>c__DisplayClass78_0` (compiler-generated name)
- `WebRequest.<>c__DisplayClass79_0` (compiler-generated name)
- `WebRequest.DesignerWebRequestCreate`
- `WebRequestStream.<FinishWriting>d__31` (compiler-generated name)
- `WebRequestStream.<Initialize>d__36` (compiler-generated name)
- `WebRequestStream.<ProcessWrite>d__34` (compiler-generated name)
- `WebRequestStream.<SetHeadersAsync>d__37` (compiler-generated name)
- `WebRequestStream.<WriteAsyncInner>d__33` (compiler-generated name)
- `WebRequestStream.<WriteChunkTrailer>d__40` (compiler-generated name)
- `WebRequestStream.<WriteChunkTrailer_inner>d__39` (compiler-generated name)
- `WebRequestStream.<WriteRequestAsync>d__38` (compiler-generated name)
- `WebResponseStream.<>c__DisplayClass41_0` (compiler-generated name)
- `WebResponseStream.<InitReadAsync>d__52` (compiler-generated name)
- `WebResponseStream.<ReadAllAsync>d__48` (compiler-generated name)
- `WebResponseStream.<ReadAllAsyncInner>d__47` (compiler-generated name)
- `WebResponseStream.<ReadAsync>d__40` (compiler-generated name)
- `X509CertificateCollection.X509CertificateEnumerator`

</details>

<details><summary>Extra: 20</summary>

- `System.Configuration.IConfigurationSectionHandler`
- `System.Diagnostics.DiagnosticsConfigurationHandler`
- `System.Net.Configuration.BypassElement`
- `System.Net.Configuration.BypassElementCollection`
- `System.Net.Configuration.ConnectionManagementElement`
- `System.Net.Configuration.ConnectionManagementElementCollection`
- `System.Net.Configuration.ConnectionManagementSection`
- `System.Net.Configuration.DefaultProxySection`
- `System.Net.Configuration.HttpWebRequestElement`
- `System.Net.Configuration.Ipv6Element`
- `System.Net.Configuration.NetSectionGroup`
- `System.Net.Configuration.PerformanceCountersElement`
- `System.Net.Configuration.ProxyElement`
- `System.Net.Configuration.ServicePointManagerElement`
- `System.Net.Configuration.SettingsSection`
- `System.Net.Configuration.SocketElement`
- `System.Net.Configuration.WebProxyScriptElement`
- `System.Net.Configuration.WebRequestModuleElement`
- `System.Net.Configuration.WebRequestModuleElementCollection`
- `System.Net.Configuration.WebRequestModulesSection`

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

<details><summary>Matching: 154</summary>

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
- `Observable.<>c` (compiler-generated name)
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
- `Scheduler.DefaultSchedulers`
- `Scheduler.ImmediateScheduler`
- `Scheduler.MainThreadScheduler`
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
- `UniRx.ISubject<T>`
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
- `UniRx.Scheduler`
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
- `UnityUIComponentExtensions.<>c` (compiler-generated name)

</details>

<details><summary>Indeterminate: 145</summary>

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

- `UniRx.BehaviorSubject<T>`

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

- `UniRx.ReactiveCollection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReactiveDictionary<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReactiveProperty<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReadOnlyReactiveProperty<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ReplaySubject<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.ScheduledNotifier<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Stubs<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UniRx.Subject<T>`

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

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10429`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=13528`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

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

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=378`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=463`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## UniTask.dll

<details><summary>Matching: 296</summary>

- `<Module>`
- `AsyncDestroyTrigger.<>c` (compiler-generated name)
- `AsyncDestroyTrigger.AwakeMonitor`
- `AutoResetUniTaskCompletionSource.<>c` (compiler-generated name)
- `Cysharp.Threading.Tasks.AsyncLazy`
- `Cysharp.Threading.Tasks.AsyncUnit`
- `Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource`
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
- `Cysharp.Threading.Tasks.Internal.ContinuationQueue`
- `Cysharp.Threading.Tasks.Internal.Error`
- `Cysharp.Threading.Tasks.Internal.PlayerLoopRunner`
- `Cysharp.Threading.Tasks.Internal.RuntimeHelpersAbstraction`
- `Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable`
- `Cysharp.Threading.Tasks.Internal.StateTuple`
- `Cysharp.Threading.Tasks.Internal.UnityWebRequestResultExtensions`
- `Cysharp.Threading.Tasks.Internal.ValueStopwatch`
- `Cysharp.Threading.Tasks.MoveNextSource`
- `Cysharp.Threading.Tasks.PlayerLoopHelper`
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
- `Cysharp.Threading.Tasks.UniTaskCompletionSource`
- `Cysharp.Threading.Tasks.UniTaskCompletionSourceCoreShared`
- `Cysharp.Threading.Tasks.UniTaskExtensions`
- `Cysharp.Threading.Tasks.UniTaskLoopRunners`
- `Cysharp.Threading.Tasks.UniTaskObservableExtensions`
- `Cysharp.Threading.Tasks.UniTaskScheduler`
- `Cysharp.Threading.Tasks.UniTaskStatus`
- `Cysharp.Threading.Tasks.UniTaskStatusExtensions`
- `Cysharp.Threading.Tasks.UniTaskSynchronizationContext`
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
- `UniTaskExtensions.<>c` (compiler-generated name)
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

<details><summary>Indeterminate: 64</summary>

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

- `Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.ArrayPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Cysharp.Threading.Tasks.Internal.MinimumQueue<T>`

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

- `Cysharp.Threading.Tasks.UniTaskCompletionSource<T>`

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

<details><summary>Extra: 5</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=19934`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=22196`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>


## Unity.Animation.Rigging.dll

<details><summary>Matching: 44</summary>

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

<details><summary>Mismatching: 9</summary>

- `UnityEngine.Animations.Rigging.AnimationRuntimeUtils`

  - `field declaration order/names: [] → ['k_SqrEpsilon']`
  - `extra field constant float k_SqrEpsilon`

- `UnityEngine.Animations.Rigging.ConstraintProperties`

  - `field declaration order/names: ['component', 'properties'] → ['s_Weight', 'component', 'properties']`
  - `extra field static string s_Weight`

- `UnityEngine.Animations.Rigging.FloatProperty`

  - `bases: '' → 'IAnimatableProperty<float>'`

- `UnityEngine.Animations.Rigging.IntProperty`

  - `bases: '' → 'IAnimatableProperty<int>'`

- `UnityEngine.Animations.Rigging.QuaternionExt`

  - `field declaration order/names: ['zero'] → ['k_FloatMin', 'zero']`
  - `extra field constant float k_FloatMin`

- `UnityEngine.Animations.Rigging.RigProperties`

  - `field declaration order/names: ['component'] → ['s_Weight', 'component']`
  - `extra field static string s_Weight`

- `UnityEngine.Animations.Rigging.RigSyncSceneToStreamJobBinder<T>`

  - `field declaration order/names: [] → ['s_PropertyElementNames']`
  - `extra field static string[] s_PropertyElementNames`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Animations.Rigging.Vector3Property`

  - `bases: '' → 'IAnimatableProperty<Vector3>'`

- `UnityEngine.Animations.Rigging.WeightedTransform`

  - `bases: 'IEquatable<WeightedTransform>' → 'ITransformProvider, IWeightProvider, IEquatable<WeightedTransform>'`


</details>

<details><summary>Indeterminate: 1</summary>

- `UnityEngine.Animations.Rigging.RigConstraint<TJob, TData, TBinder>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 1</summary>

- `UnityEngine.Animations.Rigging.RigSyncSceneToStreamJobBinderConstants`

</details>

<details><summary>Extra: 87</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5133`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6796`
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


## Unity.Burst.Unsafe.dll

<details><summary>Matching: 3</summary>

- `<Module>`
- `System.Runtime.Versioning.NonVersionableAttribute`
- `Unity.Burst.Unsafe`

</details>

<details><summary>Extra: 1</summary>

- `System.Runtime.CompilerServices.IsReadOnlyAttribute`

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


## Unity.Collections.LowLevel.ILSupport.dll

<details><summary>Extra: 7</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=48`
- `Unity.Collections.LowLevel.Unsafe.ILSupport`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

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


## Unity.RenderPipeline.Universal.ShaderLibrary.dll

<details><summary>Matching: 14</summary>

- `<Module>`
- `UnityEngine.Rendering.Universal.DebugLightingFeatureFlags`
- `UnityEngine.Rendering.Universal.DebugLightingMode`
- `UnityEngine.Rendering.Universal.DebugMaterialMode`
- `UnityEngine.Rendering.Universal.DebugMaterialValidationMode`
- `UnityEngine.Rendering.Universal.DebugMipInfoMode`
- `UnityEngine.Rendering.Universal.DebugOverdrawMode`
- `UnityEngine.Rendering.Universal.DebugPostProcessingMode`
- `UnityEngine.Rendering.Universal.DebugSceneOverrideMode`
- `UnityEngine.Rendering.Universal.DebugValidationMode`
- `UnityEngine.Rendering.Universal.DebugVertexAttributeMode`
- `UnityEngine.Rendering.Universal.HDRDebugMode`
- `UnityEngine.Rendering.Universal.PixelValidationChannels`
- `UnityEngine.Rendering.Universal.ShaderInput`

</details>

<details><summary>Mismatching: 2</summary>

- `ShaderInput.LightData`

  - `field declaration order/names: ['position', 'color', 'attenuation', 'spotDirection', 'occlusionProbeChannels', 'layerMask', 'customLightProperty'] → ['position', 'color', 'attenuation', 'spotDirection', 'occlusionProbeChannels', 'layerMask']`
  - `missing field instance Vector4 customLightProperty`

- `UnityEngine.Rendering.Universal.DebugFullScreenMode`

  - `field declaration order/names: ['value__', 'None', 'Depth', 'AdditionalLightsShadowMap', 'MainLightShadowMap', 'ReflectionProbeAtlas', 'MotionVector'] → ['value__', 'None', 'Depth', 'AdditionalLightsShadowMap', 'MainLightShadowMap', 'ReflectionProbeAtlas']`
  - `missing field constant DebugFullScreenMode MotionVector`


</details>

<details><summary>Extra: 6</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=213`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=221`
- `ShaderInput.ShadowData`
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

  - `field declaration order/names: ['FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE'] → ['45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097', '4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A', '90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4', '9B125254C7B9599896154195DAC2A199A7ABA5E0F67A5125B458228929163B97', 'BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158', 'C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF', 'FD0E21DFA9C6B157C14279741A9DD3F67AC3DE4FE785962540E2A7E0A655BC2A', 'FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE']`
  - `FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE: offset '0x0' → '0xb671'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20349 9B125254C7B9599896154195DAC2A199A7ABA5E0F67A5125B458228929163B97`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20324 FD0E21DFA9C6B157C14279741A9DD3F67AC3DE4FE785962540E2A7E0A655BC2A`

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
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20324`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20349`
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
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=960`
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
- `UnityEngine.Rendering.Universal.ShadowResolution`
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
- `UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode`
- `UnityEngine.Rendering.Universal.WhiteBalance`
- `UnityEngine.Rendering.Universal.XROcclusionMeshPass`
- `UnityEngine.Rendering.Universal.XRPassUniversal`
- `UnityEngine.Rendering.Universal.XRSystemData`
- `UnityEngine.Rendering.Universal.XRSystemUniversal`
- `UniversalAdditionalCameraData.<>c` (compiler-generated name)
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
- `VL.Rendering.VLDecalRendererFeature`
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
- `VL.Rendering.VLSRPRenderer`
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
- `VLSRPRenderer.<>c` (compiler-generated name)
- `VLSimpleRenderer.SimpleFinalBlitPass`
- `XROcclusionMeshPass.<>c` (compiler-generated name)
- `XROcclusionMeshPass.PassData`
- `XRSystemData.ShaderResources`

</details>

<details><summary>Mismatching: 31</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['05FE3BE7BD73808C8574173B558DD5BA6DF28AC65B45EB9E65503BBB699709EF', '08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6', '0ABF8AC68111CEBD27676BF5EF5DD92A3FEE0C68C2FDAB9B259C4795F93C7A8C', '28D0A1CE6AB47E8D0C1CC0E9F836A680871AA3942D4B8194B6EC886D038A96AA', '29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E', '4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D', '582A4261FE36A5D1E7D95B57714D681D1E70C11B28807118CEAE1A8DA5F9B4DD', '6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64', '636952D3023D8CF5D8245AC30EFB93A443BD4BC23B5E331D51ECB82425FDC30A', '67F97CD57FBAB63018C13EBA31B2DF63BC71EFF185FC0E19E116C63B1954D9EA', '888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1', '8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80', '9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD', 'B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137', 'BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE', 'C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101', 'E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01', 'E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A'] → ['08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6', '18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34', '4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D', '4DA1D9A416A55C5F9483FAD6A4ADEFCB0806F8917C1868AA1CE3071258665568', '6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64', '888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1', '8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80', '9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD', 'B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137', 'BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE', 'C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101', 'D254C065C675CC6904C62DA4899F883B0A1776A5F7A834B2B02F8B9A327351AA', 'E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01']`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 05FE3BE7BD73808C8574173B558DD5BA6DF28AC65B45EB9E65503BBB699709EF`
  - `08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6: offset '0x14' → '0x0'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 0ABF8AC68111CEBD27676BF5EF5DD92A3FEE0C68C2FDAB9B259C4795F93C7A8C`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 28D0A1CE6AB47E8D0C1CC0E9F836A680871AA3942D4B8194B6EC886D038A96AA`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E`
  - `4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D: offset '0xd8' → '0x28'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 582A4261FE36A5D1E7D95B57714D681D1E70C11B28807118CEAE1A8DA5F9B4DD`
  - `6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64: offset '0xea' → '0x96e6'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 636952D3023D8CF5D8245AC30EFB93A443BD4BC23B5E331D51ECB82425FDC30A`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 67F97CD57FBAB63018C13EBA31B2DF63BC71EFF185FC0E19E116C63B1954D9EA`
  - `888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1: offset '0x4c2' → '0x9aa6'`
  - `8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80: offset '0x4d2' → '0x9ab6'`
  - `9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD: offset '0x4de' → '0x9ac2'`
  - `B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137: offset '0x4ea' → '0x9ace'`
  - `BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE: offset '0x4f6' → '0x9ada'`
  - `C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101: offset '0x506' → '0x9aea'`
  - `E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01: offset '0x516' → '0x116d5'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 E528F4309E1413E6BC35AEA5D8DB8519384D2FCC33F9DD5D1126D73F104CF92A`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38578 4DA1D9A416A55C5F9483FAD6A4ADEFCB0806F8917C1868AA1CE3071258665568`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=31707 D254C065C675CC6904C62DA4899F883B0A1776A5F7A834B2B02F8B9A327351AA`

- `AdditionalLightsShadowCasterPass.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__63_0', '<>9__63_1'] → ['<>9', '<>9__62_0', '<>9__62_1']`
  - `missing field static RenderFunc<AdditionalLightsShadowCasterPass.PassData> <>9__63_0`
  - `missing field static RenderFunc<AdditionalLightsShadowCasterPass.PassData> <>9__63_1`
  - `extra field static RenderFunc<AdditionalLightsShadowCasterPass.PassData> <>9__62_0`
  - `extra field static RenderFunc<AdditionalLightsShadowCasterPass.PassData> <>9__62_1`

- `DebugDisplaySettingsCommon.SettingsPanel`

  - `field declaration order/names: [] → ['k_GoToSectionString']`
  - `extra field constant string k_GoToSectionString`

- `DebugDisplaySettingsMaterial.Strings`

  - `field declaration order/names: ['MaterialOverride', 'VertexAttribute', 'MaterialValidationMode', 'ValidationPreset', 'AlbedoCustomColor', 'AlbedoMinLuminance', 'AlbedoMaxLuminance', 'AlbedoHueTolerance', 'AlbedoSaturationTolerance', 'MetallicMinValue', 'MetallicMaxValue'] → ['AlbedoSettingsContainerName', 'MetallicSettingsContainerName', 'MaterialOverride', 'VertexAttribute', 'MaterialValidationMode', 'ValidationPreset', 'AlbedoCustomColor', 'AlbedoMinLuminance', 'AlbedoMaxLuminance', 'AlbedoHueTolerance', 'AlbedoSaturationTolerance', 'MetallicMinValue', 'MetallicMaxValue']`
  - `extra field constant string AlbedoSettingsContainerName`
  - `extra field constant string MetallicSettingsContainerName`

- `DebugDisplaySettingsRendering.Strings`

  - `field declaration order/names: ['MapOverlays', 'MapSize', 'AdditionalWireframeModes', 'WireframeNotSupportedWarning', 'OverdrawMode', 'MaxOverdrawCount', 'PostProcessing', 'MSAA', 'HDR', 'TaaDebugMode', 'PixelValidationMode', 'Channels', 'ValueRangeMin', 'ValueRangeMax', 'GameViewOnly'] → ['RangeValidationSettingsContainerName', 'MapOverlays', 'MapSize', 'AdditionalWireframeModes', 'WireframeNotSupportedWarning', 'OverdrawMode', 'MaxOverdrawCount', 'PostProcessing', 'MSAA', 'HDR', 'TaaDebugMode', 'PixelValidationMode', 'Channels', 'ValueRangeMin', 'ValueRangeMax', 'GameViewOnly']`
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

- `UnityEngine.Rendering.Universal.DecalProjector`

  - `field declaration order/names: ['_DecalTypeName', '_DecalType', 'onDecalAdd', 'onDecalRemove', 'onDecalPropertyChange', 'onAllDecalPropertyChange', 'onDecalMaterialChange', '<defaultMaterial>k__BackingField', '<decalEntity>k__BackingField', 'm_Color', 'm_Material', 'm_DrawDistance', 'm_FadeScale', 'm_StartAngleFade', 'm_EndAngleFade', 'm_UVScale', 'm_UVBias', 'm_DecalLayerMask', 'm_DecalPriority', 'm_ScaleMode', 'm_Offset', 'm_Size', 'm_FadeFactor', 'm_OldMaterial'] → ['onDecalAdd', 'onDecalRemove', 'onDecalPropertyChange', 'onAllDecalPropertyChange', 'onDecalMaterialChange', '<defaultMaterial>k__BackingField', '<decalEntity>k__BackingField', '_DecalTypeName', '_DecalType', 'm_Color', 'm_Material', 'm_DrawDistance', 'm_FadeScale', 'm_StartAngleFade', 'm_EndAngleFade', 'm_UVScale', 'm_UVBias', 'm_DecalLayerMask', 'm_DecalPriority', 'm_ScaleMode', 'm_Offset', 'm_Size', 'm_FadeFactor', 'm_OldMaterial', 'm_OldDrawDistance', 'm_OldFadeScale', 'm_OldStartAngleFade', 'm_OldEndAngleFade', 'm_OldUVScale', 'm_OldUVBias', 'm_OldScaleMode', 'm_OldOffset', 'm_OldSize', 'm_OldFadeFactor']`
  - `_DecalTypeName: offset '0x0' → '0x30'`
  - `_DecalType: offset '0x8' → '0x38'`
  - `onDecalAdd: offset '0x10' → '0x0'`
  - `onDecalRemove: offset '0x18' → '0x8'`
  - `onDecalPropertyChange: offset '0x20' → '0x10'`
  - `onAllDecalPropertyChange: offset '0x28' → '0x18'`
  - `onDecalMaterialChange: offset '0x30' → '0x20'`
  - `<defaultMaterial>k__BackingField: offset '0x38' → '0x28'`
  - `extra field instance float m_OldDrawDistance`
  - `extra field instance float m_OldFadeScale`
  - `extra field instance float m_OldStartAngleFade`
  - `extra field instance float m_OldEndAngleFade`
  - `extra field instance Vector2 m_OldUVScale`
  - `extra field instance Vector2 m_OldUVBias`
  - `extra field instance DecalScaleMode m_OldScaleMode`
  - `extra field instance Vector3 m_OldOffset`
  - `extra field instance Vector3 m_OldSize`
  - `extra field instance float m_OldFadeFactor`

- `UnityEngine.Rendering.Universal.Internal.DeferredLights`

  - `field declaration order/names: ['k_GBufferNames', 'k_StencilDeferredPassNames', 'k_InvalidLightOffset', 'k_SetupLights', 'k_DeferredPass', 'k_DeferredStencilPass', 'k_DeferredFogPass', 'k_ClearStencilPartial', 'k_SetupLightConstants', 'kStencilShapeGuard', 'm_ProfilingSetupLights', 'm_ProfilingDeferredPass', 'm_ProfilingSetupLightConstants', '<RenderingLayerMaskSize>k__BackingField', '<UseDecalLayers>k__BackingField', '<UseRenderPass>k__BackingField', '<HasDepthPrepass>k__BackingField', '<HasNormalPrepass>k__BackingField', '<HasRenderingLayerPrepass>k__BackingField', '<IsOverlay>k__BackingField', '<AccurateGbufferNormals>k__BackingField', '<MixedLightingSetup>k__BackingField', '<UseJobSystem>k__BackingField', '<RenderWidth>k__BackingField', '<RenderHeight>k__BackingField', '<GbufferAttachments>k__BackingField', 'GbufferRTHandles', '<GbufferTextureHandles>k__BackingField', '<DeferredInputAttachments>k__BackingField', '<DeferredInputIsTransient>k__BackingField', '<DepthAttachment>k__BackingField', '<DepthCopyTexture>k__BackingField', '<GbufferFormats>k__BackingField', '<DepthAttachmentHandle>k__BackingField', 'm_stencilVisLights', 'm_stencilVisLightOffsets', 'm_AdditionalLightsShadowCasterPass', 'm_SphereMesh', 'm_HemisphereMesh', 'm_FullscreenMesh', 'm_StencilDeferredMaterial', 'm_StencilDeferredPasses', 'm_ScreenToWorld', 'm_ProfilingSamplerDeferredStencilPass', 'm_ProfilingSamplerDeferredFogPass', 'm_ProfilingSamplerClearStencilPartialPass', 'm_LightCookieManager', '_LitColorMultiplier', 'k_vlStencilDeferredPassNames', 'm_ProfilingSamplerCopyGbufferPass', 'm_ProfilingSamplerFillIndirectPass', 'm_ProfilingSamplerCopyLitColor', 'm_ProfilingActorDeferredPass', 'm_ProfilingLightingComplexity', 'm_profilingSamplerActorLightingPass', 'm_ProfilingSamplerCopyDepthPass', 'm_ProfilingSamplerPostRender', 'm_ProfilingDirectReflection', 'm_ProfilingIndirectReflection', 'm_vlStencilDeferredPasses', 'm_BoxMesh', '<storeLitColor>k__BackingField', '<renderedDirectReflection>k__BackingField', 'm_ProfilingPlanarReflection', '<sharedPlanarReflectionManager>k__BackingField', '_planarReflectionEntityManager', '_planarReflectionUpdateCachedSystem', '_planarReflectionCullingSystem', '_planarReflectionResultSystem', '_planarReflectionCount'] → ['k_GBufferNames', 'k_StencilDeferredPassNames', 'k_InvalidLightOffset', 'k_SetupLights', 'k_DeferredPass', 'k_DeferredStencilPass', 'k_DeferredFogPass', 'k_ClearStencilPartial', 'k_SetupLightConstants', 'kStencilShapeGuard', 'm_ProfilingSetupLights', 'm_ProfilingDeferredPass', 'm_ProfilingSetupLightConstants', '<RenderingLayerMaskSize>k__BackingField', '<UseDecalLayers>k__BackingField', '<UseRenderPass>k__BackingField', '<HasDepthPrepass>k__BackingField', '<HasNormalPrepass>k__BackingField', '<HasRenderingLayerPrepass>k__BackingField', '<IsOverlay>k__BackingField', '<AccurateGbufferNormals>k__BackingField', '<MixedLightingSetup>k__BackingField', '<UseJobSystem>k__BackingField', '<RenderWidth>k__BackingField', '<RenderHeight>k__BackingField', '<GbufferAttachments>k__BackingField', 'GbufferRTHandles', '<GbufferTextureHandles>k__BackingField', '<DeferredInputAttachments>k__BackingField', '<DeferredInputIsTransient>k__BackingField', '<DepthAttachment>k__BackingField', '<DepthCopyTexture>k__BackingField', '<GbufferFormats>k__BackingField', '<DepthAttachmentHandle>k__BackingField', 'm_stencilVisLights', 'm_stencilVisLightOffsets', 'm_AdditionalLightsShadowCasterPass', 'm_SphereMesh', 'm_HemisphereMesh', 'm_FullscreenMesh', 'm_StencilDeferredMaterial', 'm_StencilDeferredPasses', 'm_ScreenToWorld', 'm_ProfilingSamplerDeferredStencilPass', 'm_ProfilingSamplerDeferredFogPass', 'm_ProfilingSamplerClearStencilPartialPass', 'm_LightCookieManager', '_LitColorMultiplier', 'k_vlStencilDeferredPassNames', 'm_ProfilingSamplerCopyGbufferPass', 'm_ProfilingSamplerFillIndirectPass', 'm_ProfilingSamplerCopyLitColor', 'm_ProfilingActorDeferredPass', 'm_ProfilingLightingComplexity', 'm_profilingSamplerActorLightingPass', 'm_ProfilingSamplerCopyDepthPass', 'm_ProfilingSamplerPostRender', 'm_ProfilingDirectReflection', 'm_ProfilingIndirectReflection', 'm_vlStencilDeferredPasses', 'm_BoxMesh', '<storeLitColor>k__BackingField', '<renderedDirectReflection>k__BackingField', 'm_ProfilingPlanarReflection', '_planarReflectionEntityManager', '_planarReflectionUpdateCachedSystem', '_planarReflectionCullingSystem', '_planarReflectionResultSystem', '_planarReflectionCount']`
  - `missing field static SharedPlanarReflectionEntityManager <sharedPlanarReflectionManager>k__BackingField`

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

  - `field declaration order/names: ['k_DepthNormalsOnly', 'm_Clustering', 'm_DepthPrepass', 'm_DepthNormalPrepass', 'm_PrimedDepthCopyPass', 'm_MotionVectorPass', 'm_MainLightShadowCasterPass', 'm_AdditionalLightsShadowCasterPass', 'm_GBufferPass', 'm_GBufferCopyDepthPass', 'm_DeferredPass', 'm_RenderOpaqueForwardOnlyPass', 'm_RenderOpaqueForwardPass', 'm_RenderOpaqueForwardWithRenderingLayersPass', 'm_DrawSkyboxPass', 'm_CopyDepthPass', 'm_CopyColorPass', 'm_TransparentSettingsPass', 'm_RenderTransparentForwardPass', 'm_OnRenderObjectCallbackPass', 'm_FinalBlitPass', 'm_CapturePass', 'm_XROcclusionMeshPass', 'm_XRCopyDepthPass', 'm_DrawOffscreenUIPass', 'm_DrawOverlayUIPass', 'm_ColorBufferSystem', 'm_ActiveCameraColorAttachment', 'm_ActiveCameraDepthAttachment', 'm_CameraDepthAttachment', 'm_XRTargetHandleAlias', 'm_CameraDepthAttachment_D3d_11', 'm_DepthTexture', 'm_NormalsTexture', 'm_DecalLayersTexture', 'm_OpaqueColor', 'm_MotionVectorColor', 'm_MotionVectorDepth', 'm_ForwardLights', 'm_DeferredLights', 'm_RenderingMode', 'm_DepthPrimingMode', 'm_CopyDepthMode', 'm_DepthPrimingRecommended', 'm_DefaultStencilState', 'm_LightCookieManager', 'm_IntermediateTextureMode', 'm_VulkanEnablePreTransform', 'm_BlitMaterial', 'm_BlitHDRMaterial', 'm_CopyDepthMaterial', 'm_SamplingMaterial', 'm_StencilDeferredMaterial', 'm_CameraMotionVecMaterial', 'm_ObjectMotionVecMaterial', 'm_PostProcessPasses', 'm_RenderGraphCameraColorHandle', 'm_RenderGraphCameraDepthHandle', 'm_ActiveRenderGraphColor', 'm_ActiveRenderGraphDepth', 'm_TargetIsBackbuffer', 'frameResources', 'm_UseIntermediateTexture'] → ['k_DepthStencilFormat', 'k_DepthBufferBits', 'k_FinalBlitPassQueueOffset', 'k_AfterFinalBlitPassQueueOffset', 'k_DepthNormalsOnly', 'm_Clustering', 'm_DepthPrepass', 'm_DepthNormalPrepass', 'm_PrimedDepthCopyPass', 'm_MotionVectorPass', 'm_MainLightShadowCasterPass', 'm_AdditionalLightsShadowCasterPass', 'm_GBufferPass', 'm_GBufferCopyDepthPass', 'm_DeferredPass', 'm_RenderOpaqueForwardOnlyPass', 'm_RenderOpaqueForwardPass', 'm_RenderOpaqueForwardWithRenderingLayersPass', 'm_DrawSkyboxPass', 'm_CopyDepthPass', 'm_CopyColorPass', 'm_TransparentSettingsPass', 'm_RenderTransparentForwardPass', 'm_OnRenderObjectCallbackPass', 'm_FinalBlitPass', 'm_CapturePass', 'm_XROcclusionMeshPass', 'm_XRCopyDepthPass', 'm_DrawOffscreenUIPass', 'm_DrawOverlayUIPass', 'm_ColorBufferSystem', 'm_ActiveCameraColorAttachment', 'm_ActiveCameraDepthAttachment', 'm_CameraDepthAttachment', 'm_XRTargetHandleAlias', 'm_CameraDepthAttachment_D3d_11', 'm_DepthTexture', 'm_NormalsTexture', 'm_DecalLayersTexture', 'm_OpaqueColor', 'm_MotionVectorColor', 'm_MotionVectorDepth', 'm_ForwardLights', 'm_DeferredLights', 'm_RenderingMode', 'm_DepthPrimingMode', 'm_CopyDepthMode', 'm_DepthPrimingRecommended', 'm_DefaultStencilState', 'm_LightCookieManager', 'm_IntermediateTextureMode', 'm_VulkanEnablePreTransform', 'm_BlitMaterial', 'm_BlitHDRMaterial', 'm_CopyDepthMaterial', 'm_SamplingMaterial', 'm_StencilDeferredMaterial', 'm_CameraMotionVecMaterial', 'm_ObjectMotionVecMaterial', 'm_PostProcessPasses', 'm_RenderGraphCameraColorHandle', 'm_RenderGraphCameraDepthHandle', 'm_ActiveRenderGraphColor', 'm_ActiveRenderGraphDepth', 'm_TargetIsBackbuffer', 'frameResources', 'm_UseIntermediateTexture']`
  - `extra field constant GraphicsFormat k_DepthStencilFormat`
  - `extra field constant int k_DepthBufferBits`
  - `extra field constant int k_FinalBlitPassQueueOffset`
  - `extra field constant int k_AfterFinalBlitPassQueueOffset`

- `UnityEngine.Rendering.Universal.ZBinningJob`

  - `field declaration order/names: ['bins', 'minMaxZs', 'zBinScale', 'zBinOffset', 'binCount', 'wordsPerTile', 'lightCount', 'reflectionProbeCount', 'batchCount', 'viewCount', 'isOrthographic'] → ['batchSize', 'headerLength', 'bins', 'minMaxZs', 'zBinScale', 'zBinOffset', 'binCount', 'wordsPerTile', 'lightCount', 'reflectionProbeCount', 'batchCount', 'viewCount', 'isOrthographic']`
  - `extra field constant int batchSize`
  - `extra field constant int headerLength`

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

  - `field declaration order/names: ['<>9', '<>9__93_0', '<>9__93_1'] → ['<>9', '<>9__90_0', '<>9__90_1']`
  - `missing field static Predicate<ScriptableRenderPass> <>9__93_0`
  - `missing field static Predicate<ScriptableRenderPass> <>9__93_1`
  - `extra field static Predicate<ScriptableRenderPass> <>9__90_0`
  - `extra field static Predicate<ScriptableRenderPass> <>9__90_1`

- `UniversalRenderer.Profiling`

  - `field declaration order/names: ['createCameraRenderTarget'] → ['k_Name', 'createCameraRenderTarget']`
  - `extra field constant string k_Name`

- `UniversalRendererData.ShaderResources`

  - `field declaration order/names: ['blitPS', 'copyDepthPS', 'screenSpaceShadowPS', 'samplingPS', 'stencilDeferredPS', 'fallbackErrorPS', 'fallbackLoadingPS', 'materialErrorPS', 'coreBlitPS', 'coreBlitColorAndDepthPS', 'blitHDROverlay', 'cameraMotionVector', 'objectMotionVector', 'dataDrivenLensFlare'] → ['blitPS', 'copyDepthPS', 'screenSpaceShadowPS', 'samplingPS', 'stencilDeferredPS', 'fallbackErrorPS', 'fallbackLoadingPS', 'materialErrorPS', 'coreBlitPS', 'coreBlitColorAndDepthPS', 'blitHDROverlay', 'cameraMotionVector', 'objectMotionVector', 'dataDrivenLensFlare', 'terrainDetailLitPS', 'terrainDetailGrassPS', 'terrainDetailGrassBillboardPS']`
  - `extra field instance Shader terrainDetailLitPS`
  - `extra field instance Shader terrainDetailGrassPS`
  - `extra field instance Shader terrainDetailGrassBillboardPS`


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

<details><summary>Missing: 4</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=144`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `DebugDisplaySettingsRendering.WidgetFactory.<>c__DisplayClass14_0` (compiler-generated name)

</details>

<details><summary>Extra: 184</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=31707`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=38578`
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

<details><summary>Matching: 115</summary>

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

<details><summary>Mismatching: 11</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB'] → ['1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB', '50D8F9B758CA049E70E848EB6297B10698B9DFE1BC09A250619124C983CAC0E8', 'CE288FEE87FD0C469553BE04A1827FA38389051875CAC152A072634634D7D780']`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3772 50D8F9B758CA049E70E848EB6297B10698B9DFE1BC09A250619124C983CAC0E8`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4040 CE288FEE87FD0C469553BE04A1827FA38389051875CAC152A072634634D7D780`

- `TMP_Text.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__645_0'] → ['<>9', '<>9__648_0']`
  - `missing field static Action<TMP_TextInfo> <>9__645_0`
  - `extra field static Action<TMP_TextInfo> <>9__648_0`

- `TMPro.Compute_DT_EventArgs`

  - `field declaration order/names: [] → ['EventType', 'ProgressPercentage', 'Colors']`
  - `extra field instance Compute_DistanceTransform_EventTypes EventType`
  - `extra field instance float ProgressPercentage`
  - `extra field instance Color[] Colors`

- `TMPro.RichTextTagAttribute`

  - `field declaration order/names: ['nameHashCode', 'valueHashCode', 'valueType', 'valueStartIndex', 'valueLength', 'unitType'] → ['nameHashCode', 'valueHashCode', 'valueType', 'valueStartIndex', 'valueLength', 'unitType', 'k_Default']`
  - `extra field static RichTextTagAttribute k_Default`

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

- `TMPro.TMP_Text`

  - `field declaration order/names: ['m_text', 'm_IsTextBackingStringDirty', 'm_TextPreprocessor', 'm_isRightToLeft', 'm_fontAsset', 'm_currentFontAsset', 'm_isSDFShader', 'm_sharedMaterial', 'm_currentMaterial', 'm_materialReferences', 'm_materialReferenceIndexLookup', 'm_materialReferenceStack', 'm_currentMaterialIndex', 'm_fontSharedMaterials', 'm_fontMaterial', 'm_fontMaterials', 'm_isMaterialDirty', 'm_fontColor32', 'm_fontColor', 's_colorWhite', 'm_underlineColor', 'm_strikethroughColor', 'm_HighlightState', 'm_ConvertToLinearSpace', 'm_enableVertexGradient', 'm_colorMode', 'm_fontColorGradient', 'm_fontColorGradientPreset', 'm_spriteAsset', 'm_tintAllSprites', 'm_tintSprite', 'm_spriteColor', 'm_StyleSheet', 'm_TextStyle', 'm_TextStyleHashCode', 'm_overrideHtmlColors', 'm_faceColor', 'm_outlineColor', 'm_outlineWidth', 'm_currentEnvMapRotation', 'm_hasEnvMapProperty', 'm_fontSize', 'm_currentFontSize', 'm_fontSizeBase', 'm_sizeStack', 'm_fontWeight', 'm_FontWeightInternal', 'm_FontWeightStack', 'm_enableAutoSizing', 'm_maxFontSize', 'm_minFontSize', 'm_AutoSizeIterationCount', 'm_AutoSizeMaxIterationCount', 'm_IsAutoSizePointSizeSet', 'm_fontSizeMin', 'm_fontSizeMax', 'm_fontStyle', 'm_FontStyleInternal', 'm_fontStyleStack', 'm_isUsingBold', 'm_HorizontalAlignment', 'm_VerticalAlignment', 'm_textAlignment', 'm_lineJustification', 'm_lineJustificationStack', 'm_textContainerLocalCorners', 'm_characterSpacing', 'm_cSpacing', 'm_monoSpacing', 'm_duoSpace', 'm_wordSpacing', 'm_lineSpacing', 'm_lineSpacingDelta', 'm_lineHeight', 'm_IsDrivenLineSpacing', 'm_lineSpacingMax', 'm_paragraphSpacing', 'm_charWidthMaxAdj', 'm_charWidthAdjDelta', 'm_TextWrappingMode', 'm_isCharacterWrappingEnabled', 'm_isNonBreakingSpace', 'm_isIgnoringAlignment', 'm_wordWrappingRatios', 'm_overflowMode', 'm_firstOverflowCharacterIndex', 'm_linkedTextComponent', 'parentLinkedComponent', 'm_isTextTruncated', 'm_enableKerning', 'm_LastBaseGlyphIndex', 'm_ActiveFontFeatures', 'm_enableExtraPadding', 'checkPaddingRequired', 'm_isRichText', 'm_EmojiFallbackSupport', 'm_parseCtrlCharacters', 'm_isOverlay', 'm_isOrthographic', 'm_isCullingEnabled', 'm_isMaskingEnabled', 'isMaskUpdateRequired', 'm_ignoreCulling', 'm_horizontalMapping', 'm_verticalMapping', 'm_uvLineOffset', 'm_renderMode', 'm_geometrySortingOrder', 'm_IsTextObjectScaleStatic', 'm_VertexBufferAutoSizeReduction', 'm_firstVisibleCharacter', 'm_maxVisibleCharacters', 'm_maxVisibleWords', 'm_maxVisibleLines', 'm_useMaxVisibleDescender', 'm_pageToDisplay', 'm_isNewPage', 'm_margin', 'm_marginLeft', 'm_marginRight', 'm_marginWidth', 'm_marginHeight', 'm_width', 'm_textInfo', 'm_havePropertiesChanged', 'm_isUsingLegacyAnimationComponent', 'm_transform', 'm_rectTransform', 'm_PreviousRectTransformSize', 'm_PreviousPivotPosition', '<autoSizeTextContainer>k__BackingField', 'm_autoSizeTextContainer', 'm_mesh', 'm_isVolumetricText', 'OnFontAssetRequest', 'OnSpriteAssetRequest', 'OnMissingCharacter', 'OnPreRenderText', 'm_spriteAnimator', 'm_flexibleHeight', 'm_flexibleWidth', 'm_minWidth', 'm_minHeight', 'm_maxWidth', 'm_maxHeight', 'm_LayoutElement', 'm_preferredWidth', 'm_RenderedWidth', 'm_isPreferredWidthDirty', 'm_preferredHeight', 'm_RenderedHeight', 'm_isPreferredHeightDirty', 'm_isCalculatingPreferredValues', 'm_layoutPriority', 'm_isLayoutDirty', 'm_isAwake', 'm_isWaitingOnResourceLoad', 'm_inputSource', 'm_fontScaleMultiplier', 'm_htmlTag', 'm_xmlAttribute', 'm_attributeParameterValues', 'tag_LineIndent', 'tag_Indent', 'm_indentStack', 'tag_NoParsing', 'm_isTextLayoutPhase', 'm_FXRotation', 'm_FXScale', 'm_TextProcessingArray', 'm_InternalTextProcessingArraySize', 'm_internalCharacterInfo', 'm_totalCharacterCount', 'm_SavedWordWrapState', 'm_SavedLineState', 'm_SavedEllipsisState', 'm_SavedLastValidState', 'm_SavedSoftLineBreakState', 'm_EllipsisInsertionCandidateStack', 'm_characterCount', 'm_firstCharacterOfLine', 'm_firstVisibleCharacterOfLine', 'm_lastCharacterOfLine', 'm_lastVisibleCharacterOfLine', 'm_lineNumber', 'm_lineVisibleCharacterCount', 'm_lineVisibleSpaceCount', 'm_pageNumber', 'm_PageAscender', 'm_maxTextAscender', 'm_maxCapHeight', 'm_ElementAscender', 'm_ElementDescender', 'm_maxLineAscender', 'm_maxLineDescender', 'm_startOfLineAscender', 'm_startOfLineDescender', 'm_lineOffset', 'm_meshExtents', 'm_htmlColor', 'm_colorStack', 'm_underlineColorStack', 'm_strikethroughColorStack', 'm_HighlightStateStack', 'm_colorGradientPreset', 'm_colorGradientStack', 'm_colorGradientPresetIsTinted', 'm_tabSpacing', 'm_spacing', 'm_TextStyleStacks', 'm_TextStyleStackDepth', 'm_ItalicAngleStack', 'm_ItalicAngle', 'm_actionStack', 'm_padding', 'm_baselineOffset', 'm_baselineOffsetStack', 'm_xAdvance', 'm_textElementType', 'm_cached_TextElement', 'm_Ellipsis', 'm_Underline', 'm_defaultSpriteAsset', 'm_currentSpriteAsset', 'm_spriteCount', 'm_spriteIndex', 'm_spriteAnimationID', 'k_ParseTextMarker', 'k_InsertNewLineMarker', 'm_ignoreActiveState', 'm_TextBackingArray', 'k_Power', 'k_LargePositiveVector2', 'k_LargeNegativeVector2', 'k_LargePositiveFloat', 'k_LargeNegativeFloat', 'k_LargePositiveInt', 'k_LargeNegativeInt'] → ['m_text', 'm_IsTextBackingStringDirty', 'm_TextPreprocessor', 'm_isRightToLeft', 'm_fontAsset', 'm_currentFontAsset', 'm_isSDFShader', 'm_sharedMaterial', 'm_currentMaterial', 'm_materialReferences', 'm_materialReferenceIndexLookup', 'm_materialReferenceStack', 'm_currentMaterialIndex', 'm_fontSharedMaterials', 'm_fontMaterial', 'm_fontMaterials', 'm_isMaterialDirty', 'm_fontColor32', 'm_fontColor', 's_colorWhite', 'm_underlineColor', 'm_strikethroughColor', 'm_HighlightState', 'm_ConvertToLinearSpace', 'm_enableVertexGradient', 'm_colorMode', 'm_fontColorGradient', 'm_fontColorGradientPreset', 'm_spriteAsset', 'm_tintAllSprites', 'm_tintSprite', 'm_spriteColor', 'm_StyleSheet', 'm_TextStyle', 'm_TextStyleHashCode', 'm_overrideHtmlColors', 'm_faceColor', 'm_outlineColor', 'm_outlineWidth', 'm_currentEnvMapRotation', 'm_hasEnvMapProperty', 'm_fontSize', 'm_currentFontSize', 'm_fontSizeBase', 'm_sizeStack', 'm_fontWeight', 'm_FontWeightInternal', 'm_FontWeightStack', 'm_enableAutoSizing', 'm_maxFontSize', 'm_minFontSize', 'm_AutoSizeIterationCount', 'm_AutoSizeMaxIterationCount', 'm_IsAutoSizePointSizeSet', 'm_fontSizeMin', 'm_fontSizeMax', 'm_fontStyle', 'm_FontStyleInternal', 'm_fontStyleStack', 'm_isUsingBold', 'm_HorizontalAlignment', 'm_VerticalAlignment', 'm_textAlignment', 'm_lineJustification', 'm_lineJustificationStack', 'm_textContainerLocalCorners', 'm_characterSpacing', 'm_cSpacing', 'm_monoSpacing', 'm_duoSpace', 'm_characterHorizontalScale', 'm_wordSpacing', 'm_lineSpacing', 'm_lineSpacingDelta', 'm_lineHeight', 'm_IsDrivenLineSpacing', 'm_lineSpacingMax', 'm_paragraphSpacing', 'm_charWidthMaxAdj', 'm_charWidthAdjDelta', 'm_TextWrappingMode', 'm_isCharacterWrappingEnabled', 'm_isNonBreakingSpace', 'm_isIgnoringAlignment', 'm_wordWrappingRatios', 'm_overflowMode', 'm_firstOverflowCharacterIndex', 'm_linkedTextComponent', 'parentLinkedComponent', 'm_isTextTruncated', 'm_enableKerning', 'm_LastBaseGlyphIndex', 'm_ActiveFontFeatures', 'm_enableExtraPadding', 'checkPaddingRequired', 'm_isRichText', 'm_EmojiFallbackSupport', 'm_parseCtrlCharacters', 'm_isOverlay', 'm_isOrthographic', 'm_isCullingEnabled', 'm_isMaskingEnabled', 'isMaskUpdateRequired', 'm_ignoreCulling', 'm_horizontalMapping', 'm_verticalMapping', 'm_uvLineOffset', 'm_renderMode', 'm_geometrySortingOrder', 'm_IsTextObjectScaleStatic', 'm_VertexBufferAutoSizeReduction', 'm_firstVisibleCharacter', 'm_maxVisibleCharacters', 'm_maxVisibleWords', 'm_maxVisibleLines', 'm_useMaxVisibleDescender', 'm_pageToDisplay', 'm_isNewPage', 'm_margin', 'm_marginLeft', 'm_marginRight', 'm_marginWidth', 'm_marginHeight', 'm_width', 'm_textInfo', 'm_havePropertiesChanged', 'm_isUsingLegacyAnimationComponent', 'm_transform', 'm_rectTransform', 'm_PreviousRectTransformSize', 'm_PreviousPivotPosition', '<autoSizeTextContainer>k__BackingField', 'm_autoSizeTextContainer', 'm_mesh', 'm_isVolumetricText', 'OnFontAssetRequest', 'OnSpriteAssetRequest', 'OnMissingCharacter', 'OnPreRenderText', 'm_spriteAnimator', 'm_flexibleHeight', 'm_flexibleWidth', 'm_minWidth', 'm_minHeight', 'm_maxWidth', 'm_maxHeight', 'm_LayoutElement', 'm_preferredWidth', 'm_RenderedWidth', 'm_isPreferredWidthDirty', 'm_preferredHeight', 'm_RenderedHeight', 'm_isPreferredHeightDirty', 'm_isCalculatingPreferredValues', 'm_layoutPriority', 'm_isLayoutDirty', 'm_isAwake', 'm_isWaitingOnResourceLoad', 'm_inputSource', 'm_fontScaleMultiplier', 'm_htmlTag', 'm_xmlAttribute', 'm_attributeParameterValues', 'tag_LineIndent', 'tag_Indent', 'm_indentStack', 'tag_NoParsing', 'm_isTextLayoutPhase', 'm_FXRotation', 'm_FXScale', 'm_TextProcessingArray', 'm_InternalTextProcessingArraySize', 'm_internalCharacterInfo', 'm_totalCharacterCount', 'm_SavedWordWrapState', 'm_SavedLineState', 'm_SavedEllipsisState', 'm_SavedLastValidState', 'm_SavedSoftLineBreakState', 'm_EllipsisInsertionCandidateStack', 'm_characterCount', 'm_firstCharacterOfLine', 'm_firstVisibleCharacterOfLine', 'm_lastCharacterOfLine', 'm_lastVisibleCharacterOfLine', 'm_lineNumber', 'm_lineVisibleCharacterCount', 'm_lineVisibleSpaceCount', 'm_pageNumber', 'm_PageAscender', 'm_maxTextAscender', 'm_maxCapHeight', 'm_ElementAscender', 'm_ElementDescender', 'm_maxLineAscender', 'm_maxLineDescender', 'm_startOfLineAscender', 'm_startOfLineDescender', 'm_lineOffset', 'm_meshExtents', 'm_htmlColor', 'm_colorStack', 'm_underlineColorStack', 'm_strikethroughColorStack', 'm_HighlightStateStack', 'm_colorGradientPreset', 'm_colorGradientStack', 'm_colorGradientPresetIsTinted', 'm_tabSpacing', 'm_spacing', 'm_TextStyleStacks', 'm_TextStyleStackDepth', 'm_ItalicAngleStack', 'm_ItalicAngle', 'm_actionStack', 'm_padding', 'm_baselineOffset', 'm_baselineOffsetStack', 'm_xAdvance', 'm_textElementType', 'm_cached_TextElement', 'm_Ellipsis', 'm_Underline', 'm_defaultSpriteAsset', 'm_currentSpriteAsset', 'm_spriteCount', 'm_spriteIndex', 'm_spriteAnimationID', 'k_ParseTextMarker', 'k_InsertNewLineMarker', 'm_ignoreActiveState', 'm_TextBackingArray', 'k_Power', 'k_LargePositiveVector2', 'k_LargeNegativeVector2', 'k_LargePositiveFloat', 'k_LargeNegativeFloat', 'k_LargePositiveInt', 'k_LargeNegativeInt']`
  - `m_wordSpacing: offset '0x2e8' → '0x2ec'`
  - `m_lineSpacing: offset '0x2ec' → '0x2f0'`
  - `m_lineSpacingDelta: offset '0x2f0' → '0x2f4'`
  - `m_lineHeight: offset '0x2f4' → '0x2f8'`
  - `m_IsDrivenLineSpacing: offset '0x2f8' → '0x2fc'`
  - `m_lineSpacingMax: offset '0x2fc' → '0x300'`
  - `m_paragraphSpacing: offset '0x300' → '0x304'`
  - `m_charWidthMaxAdj: offset '0x304' → '0x308'`
  - `m_charWidthAdjDelta: offset '0x308' → '0x30c'`
  - `m_TextWrappingMode: offset '0x30c' → '0x310'`
  - `m_isCharacterWrappingEnabled: offset '0x310' → '0x314'`
  - `m_isNonBreakingSpace: offset '0x311' → '0x315'`
  - `m_isIgnoringAlignment: offset '0x312' → '0x316'`
  - `m_wordWrappingRatios: offset '0x314' → '0x318'`
  - `m_overflowMode: offset '0x318' → '0x31c'`
  - `m_firstOverflowCharacterIndex: offset '0x31c' → '0x320'`
  - `m_linkedTextComponent: offset '0x320' → '0x328'`
  - `parentLinkedComponent: offset '0x328' → '0x330'`
  - `m_isTextTruncated: offset '0x330' → '0x338'`
  - `m_enableKerning: offset '0x331' → '0x339'`
  - `m_LastBaseGlyphIndex: offset '0x334' → '0x33c'`
  - `m_ActiveFontFeatures: offset '0x338' → '0x340'`
  - `m_enableExtraPadding: offset '0x340' → '0x348'`
  - `checkPaddingRequired: offset '0x341' → '0x349'`
  - `m_isRichText: offset '0x342' → '0x34a'`
  - `m_EmojiFallbackSupport: offset '0x343' → '0x34b'`
  - `m_parseCtrlCharacters: offset '0x344' → '0x34c'`
  - `m_isOverlay: offset '0x345' → '0x34d'`
  - `m_isOrthographic: offset '0x346' → '0x34e'`
  - `m_isCullingEnabled: offset '0x347' → '0x34f'`
  - `m_isMaskingEnabled: offset '0x348' → '0x350'`
  - `isMaskUpdateRequired: offset '0x349' → '0x351'`
  - `m_ignoreCulling: offset '0x34a' → '0x352'`
  - `m_horizontalMapping: offset '0x34c' → '0x354'`
  - `m_verticalMapping: offset '0x350' → '0x358'`
  - `m_uvLineOffset: offset '0x354' → '0x35c'`
  - `m_renderMode: offset '0x358' → '0x360'`
  - `m_geometrySortingOrder: offset '0x35c' → '0x364'`
  - `m_IsTextObjectScaleStatic: offset '0x360' → '0x368'`
  - `m_VertexBufferAutoSizeReduction: offset '0x361' → '0x369'`
  - `m_firstVisibleCharacter: offset '0x364' → '0x36c'`
  - `m_maxVisibleCharacters: offset '0x368' → '0x370'`
  - `m_maxVisibleWords: offset '0x36c' → '0x374'`
  - `m_maxVisibleLines: offset '0x370' → '0x378'`
  - `m_useMaxVisibleDescender: offset '0x374' → '0x37c'`
  - `m_pageToDisplay: offset '0x378' → '0x380'`
  - `m_isNewPage: offset '0x37c' → '0x384'`
  - `m_margin: offset '0x380' → '0x388'`
  - `m_marginLeft: offset '0x390' → '0x398'`
  - `m_marginRight: offset '0x394' → '0x39c'`
  - `m_marginWidth: offset '0x398' → '0x3a0'`
  - `m_marginHeight: offset '0x39c' → '0x3a4'`
  - `m_width: offset '0x3a0' → '0x3a8'`
  - `m_textInfo: offset '0x3a8' → '0x3b0'`
  - `m_havePropertiesChanged: offset '0x3b0' → '0x3b8'`
  - `m_isUsingLegacyAnimationComponent: offset '0x3b1' → '0x3b9'`
  - `m_transform: offset '0x3b8' → '0x3c0'`
  - `m_rectTransform: offset '0x3c0' → '0x3c8'`
  - `m_PreviousRectTransformSize: offset '0x3c8' → '0x3d0'`
  - `m_PreviousPivotPosition: offset '0x3d0' → '0x3d8'`
  - `<autoSizeTextContainer>k__BackingField: offset '0x3d8' → '0x3e0'`
  - `m_autoSizeTextContainer: offset '0x3d9' → '0x3e1'`
  - `m_mesh: offset '0x3e0' → '0x3e8'`
  - `m_isVolumetricText: offset '0x3e8' → '0x3f0'`
  - `OnPreRenderText: offset '0x3f0' → '0x3f8'`
  - `m_spriteAnimator: offset '0x3f8' → '0x400'`
  - `m_flexibleHeight: offset '0x400' → '0x408'`
  - `m_flexibleWidth: offset '0x404' → '0x40c'`
  - `m_minWidth: offset '0x408' → '0x410'`
  - `m_minHeight: offset '0x40c' → '0x414'`
  - `m_maxWidth: offset '0x410' → '0x418'`
  - `m_maxHeight: offset '0x414' → '0x41c'`
  - `m_LayoutElement: offset '0x418' → '0x420'`
  - `m_preferredWidth: offset '0x420' → '0x428'`
  - `m_RenderedWidth: offset '0x424' → '0x42c'`
  - `m_isPreferredWidthDirty: offset '0x428' → '0x430'`
  - `m_preferredHeight: offset '0x42c' → '0x434'`
  - `m_RenderedHeight: offset '0x430' → '0x438'`
  - `m_isPreferredHeightDirty: offset '0x434' → '0x43c'`
  - `m_isCalculatingPreferredValues: offset '0x435' → '0x43d'`
  - `m_layoutPriority: offset '0x438' → '0x440'`
  - `m_isLayoutDirty: offset '0x43c' → '0x444'`
  - `m_isAwake: offset '0x43d' → '0x445'`
  - `m_isWaitingOnResourceLoad: offset '0x43e' → '0x446'`
  - `m_inputSource: offset '0x440' → '0x448'`
  - `m_fontScaleMultiplier: offset '0x444' → '0x44c'`
  - `tag_LineIndent: offset '0x448' → '0x450'`
  - `tag_Indent: offset '0x44c' → '0x454'`
  - `m_indentStack: offset '0x450' → '0x458'`
  - `tag_NoParsing: offset '0x470' → '0x478'`
  - `m_isTextLayoutPhase: offset '0x471' → '0x479'`
  - `m_FXRotation: offset '0x474' → '0x47c'`
  - `m_FXScale: offset '0x484' → '0x48c'`
  - `m_TextProcessingArray: offset '0x490' → '0x498'`
  - `m_InternalTextProcessingArraySize: offset '0x498' → '0x4a0'`
  - `m_internalCharacterInfo: offset '0x4a0' → '0x4a8'`
  - `m_totalCharacterCount: offset '0x4a8' → '0x4b0'`
  - `m_characterCount: offset '0x4ac' → '0x4b4'`
  - `m_firstCharacterOfLine: offset '0x4b0' → '0x4b8'`
  - `m_firstVisibleCharacterOfLine: offset '0x4b4' → '0x4bc'`
  - `m_lastCharacterOfLine: offset '0x4b8' → '0x4c0'`
  - `m_lastVisibleCharacterOfLine: offset '0x4bc' → '0x4c4'`
  - `m_lineNumber: offset '0x4c0' → '0x4c8'`
  - `m_lineVisibleCharacterCount: offset '0x4c4' → '0x4cc'`
  - `m_lineVisibleSpaceCount: offset '0x4c8' → '0x4d0'`
  - `m_pageNumber: offset '0x4cc' → '0x4d4'`
  - `m_PageAscender: offset '0x4d0' → '0x4d8'`
  - `m_maxTextAscender: offset '0x4d4' → '0x4dc'`
  - `m_maxCapHeight: offset '0x4d8' → '0x4e0'`
  - `m_ElementAscender: offset '0x4dc' → '0x4e4'`
  - `m_ElementDescender: offset '0x4e0' → '0x4e8'`
  - `m_maxLineAscender: offset '0x4e4' → '0x4ec'`
  - `m_maxLineDescender: offset '0x4e8' → '0x4f0'`
  - `m_startOfLineAscender: offset '0x4ec' → '0x4f4'`
  - `m_startOfLineDescender: offset '0x4f0' → '0x4f8'`
  - `m_lineOffset: offset '0x4f4' → '0x4fc'`
  - `m_meshExtents: offset '0x4f8' → '0x500'`
  - `m_htmlColor: offset '0x508' → '0x510'`
  - `m_colorStack: offset '0x510' → '0x518'`
  - `m_underlineColorStack: offset '0x530' → '0x538'`
  - `m_strikethroughColorStack: offset '0x550' → '0x558'`
  - `m_HighlightStateStack: offset '0x570' → '0x578'`
  - `m_colorGradientPreset: offset '0x5a0' → '0x5a8'`
  - `m_colorGradientStack: offset '0x5a8' → '0x5b0'`
  - `m_colorGradientPresetIsTinted: offset '0x5d0' → '0x5d8'`
  - `m_tabSpacing: offset '0x5d4' → '0x5dc'`
  - `m_spacing: offset '0x5d8' → '0x5e0'`
  - `m_TextStyleStacks: offset '0x5e0' → '0x5e8'`
  - `m_TextStyleStackDepth: offset '0x5e8' → '0x5f0'`
  - `m_ItalicAngleStack: offset '0x5f0' → '0x5f8'`
  - `m_ItalicAngle: offset '0x610' → '0x618'`
  - `m_actionStack: offset '0x618' → '0x620'`
  - `m_padding: offset '0x638' → '0x640'`
  - `m_baselineOffset: offset '0x63c' → '0x644'`
  - `m_baselineOffsetStack: offset '0x640' → '0x648'`
  - `m_xAdvance: offset '0x660' → '0x668'`
  - `m_textElementType: offset '0x664' → '0x66c'`
  - `m_cached_TextElement: offset '0x668' → '0x670'`
  - `m_Ellipsis: offset '0x670' → '0x678'`
  - `m_Underline: offset '0x690' → '0x698'`
  - `m_defaultSpriteAsset: offset '0x6b0' → '0x6b8'`
  - `m_currentSpriteAsset: offset '0x6b8' → '0x6c0'`
  - `m_spriteCount: offset '0x6c0' → '0x6c8'`
  - `m_spriteIndex: offset '0x6c4' → '0x6cc'`
  - `m_spriteAnimationID: offset '0x6c8' → '0x6d0'`
  - `m_ignoreActiveState: offset '0x6cc' → '0x6d4'`
  - `m_TextBackingArray: offset '0x6d0' → '0x6d8'`
  - `k_Power: offset '0x6e0' → '0x6e8'`
  - `extra field instance float m_characterHorizontalScale`

- `TMPro.TMP_TextParsingUtilities`

  - `field declaration order/names: ['s_Instance', 'k_EmojiLookup', 'k_EmojiPresentationFormLookup'] → ['s_Instance', 'k_LookupStringL', 'k_LookupStringU', 'k_EmojiLookup', 'k_EmojiPresentationFormLookup']`
  - `extra field constant string k_LookupStringL`
  - `extra field constant string k_LookupStringU`

- `TMPro.TMP_TextUtilities`

  - `field declaration order/names: ['m_rectWorldCorners'] → ['m_rectWorldCorners', 'k_lookupStringL', 'k_lookupStringU']`
  - `extra field constant string k_lookupStringL`
  - `extra field constant string k_lookupStringU`

- `TMPro.TextMeshPro`

  - `_SortingLayer: offset '0x6e8' → '0x6f0'`
  - `_SortingLayerID: offset '0x6ec' → '0x6f4'`
  - `_SortingOrder: offset '0x6f0' → '0x6f8'`
  - `OnPreRenderText: offset '0x6f8' → '0x700'`
  - `m_hasFontAssetChanged: offset '0x700' → '0x708'`
  - `m_previousLossyScaleY: offset '0x704' → '0x70c'`
  - `m_renderer: offset '0x708' → '0x710'`
  - `m_meshFilter: offset '0x710' → '0x718'`
  - `m_isFirstAllocation: offset '0x718' → '0x720'`
  - `m_max_characters: offset '0x71c' → '0x724'`
  - `m_max_numberOfLines: offset '0x720' → '0x728'`
  - `m_subTextObjects: offset '0x728' → '0x730'`
  - `m_maskType: offset '0x730' → '0x738'`
  - `m_EnvMapMatrix: offset '0x734' → '0x73c'`
  - `m_RectTransformCorners: offset '0x778' → '0x780'`
  - `m_isRegisteredForEvents: offset '0x780' → '0x788'`
  - `materialIndexPairs: offset '0x788' → '0x790'`

- `TMPro.TextMeshProUGUI`

  - `m_isRebuildingLayout: offset '0x6e8' → '0x6f0'`
  - `m_DelayedGraphicRebuild: offset '0x6f0' → '0x6f8'`
  - `m_DelayedMaterialRebuild: offset '0x6f8' → '0x700'`
  - `m_ShouldUpdateCulling: offset '0x700' → '0x708'`
  - `m_ClipRect: offset '0x704' → '0x70c'`
  - `m_ValidRect: offset '0x714' → '0x71c'`
  - `OnPreRenderText: offset '0x718' → '0x720'`
  - `m_hasFontAssetChanged: offset '0x720' → '0x728'`
  - `m_subTextObjects: offset '0x728' → '0x730'`
  - `m_previousLossyScaleY: offset '0x730' → '0x738'`
  - `m_RectTransformCorners: offset '0x738' → '0x740'`
  - `m_canvasRenderer: offset '0x740' → '0x748'`
  - `m_canvas: offset '0x748' → '0x750'`
  - `m_CanvasScaleFactor: offset '0x750' → '0x758'`
  - `m_isFirstAllocation: offset '0x754' → '0x75c'`
  - `m_max_characters: offset '0x758' → '0x760'`
  - `m_baseMaterial: offset '0x760' → '0x768'`
  - `m_isScrollRegionSet: offset '0x768' → '0x770'`
  - `m_maskOffset: offset '0x76c' → '0x774'`
  - `m_EnvMapMatrix: offset '0x77c' → '0x784'`
  - `m_isRegisteredForEvents: offset '0x7bc' → '0x7c4'`
  - `materialIndexPairs: offset '0x7c0' → '0x7c8'`


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


## UnityEngine.AIModule.dll

<details><summary>Matching: 3</summary>

- `<Module>`
- `NavMesh.OnNavMeshPreUpdate`
- `UnityEngine.AI.NavMesh`

</details>


## UnityEngine.AndroidJNIModule.dll

<details><summary>Matching: 44</summary>

- `<Module>`
- `AndroidAssetPacks.AssetPackManagerDownloadStatusCallback`
- `AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<>c` (compiler-generated name)
- `AndroidAssetPacks.AssetPackManagerMobileDataConfirmationCallback`
- `AndroidAssetPacks.AssetPackManagerStatusQueryCallback`
- `AndroidJNI.JStringBinding`
- `UnityEngine.Android.AndroidAssetPackError`
- `UnityEngine.Android.AndroidAssetPackInfo`
- `UnityEngine.Android.AndroidAssetPackState`
- `UnityEngine.Android.AndroidAssetPackStatus`
- `UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult`
- `UnityEngine.Android.AndroidAssetPacks`
- `UnityEngine.Android.AndroidColorModeHdr`
- `UnityEngine.Android.AndroidColorModeWideColorGamut`
- `UnityEngine.Android.AndroidConfiguration`
- `UnityEngine.Android.AndroidGame`
- `UnityEngine.Android.AndroidHardwareKeyboardHidden`
- `UnityEngine.Android.AndroidKeyboard`
- `UnityEngine.Android.AndroidKeyboardHidden`
- `UnityEngine.Android.AndroidLocale`
- `UnityEngine.Android.AndroidNavigation`
- `UnityEngine.Android.AndroidNavigationHidden`
- `UnityEngine.Android.AndroidOrientation`
- `UnityEngine.Android.AndroidScreenLayoutDirection`
- `UnityEngine.Android.AndroidScreenLayoutLong`
- `UnityEngine.Android.AndroidScreenLayoutRound`
- `UnityEngine.Android.AndroidScreenLayoutSize`
- `UnityEngine.Android.AndroidTouchScreen`
- `UnityEngine.Android.AndroidUIModeNight`
- `UnityEngine.Android.AndroidUIModeType`
- `UnityEngine.AndroidJNI`
- `UnityEngine.AndroidJNIHelper`
- `UnityEngine.AndroidJNISafe`
- `UnityEngine.AndroidJavaClass`
- `UnityEngine.AndroidJavaException`
- `UnityEngine.AndroidJavaObject`
- `UnityEngine.AndroidJavaProxy`
- `UnityEngine.AndroidJavaRunnable`
- `UnityEngine.AndroidJavaRunnableProxy`
- `UnityEngine.AndroidReflection`
- `UnityEngine.GlobalJavaObjectRef`
- `UnityEngine.JNINativeMethod`
- `UnityEngine._AndroidJNIHelper`
- `UnityEngine.jvalue`

</details>

<details><summary>Mismatching: 1</summary>

- `UnityEngine.Android.AndroidApplication`

  - `field declaration order/names: ['m_MainThreadSynchronizationContext', 'm_Context', 'm_Activity', 'm_CurrentConfiguration', 'onConfigurationChanged'] → ['m_MainThreadSynchronizationContext', 'm_CurrentConfiguration', 'onConfigurationChanged']`
  - `missing field static AndroidJavaObjectUnityOwned m_Context`
  - `missing field static AndroidJavaObjectUnityOwned m_Activity`
  - `m_CurrentConfiguration: offset '0x18' → '0x8'`
  - `onConfigurationChanged: offset '0x20' → '0x10'`


</details>

<details><summary>Missing: 4</summary>

- `PermissionCallbacks.Result`
- `UnityEngine.Android.Permission`
- `UnityEngine.Android.PermissionCallbacks`
- `UnityEngine.AndroidJavaObjectUnityOwned`

</details>


## UnityEngine.AnimationModule.dll

<details><summary>Matching: 67</summary>

- `<Module>`
- `Animation.Enumerator`
- `AnimatorOverrideController.OnOverrideControllerDirtyCallback`
- `ProcessAnimationJobStruct.ExecuteJobFunction<T>`
- `UnityEngine.Animation`
- `UnityEngine.AnimationClip`
- `UnityEngine.AnimationEvent`
- `UnityEngine.AnimationEventSource`
- `UnityEngine.AnimationState`
- `UnityEngine.Animations.AnimationClipPlayable`
- `UnityEngine.Animations.AnimationHumanStream`
- `UnityEngine.Animations.AnimationLayerMixerPlayable`
- `UnityEngine.Animations.AnimationMixerPlayable`
- `UnityEngine.Animations.AnimationMotionXToDeltaPlayable`
- `UnityEngine.Animations.AnimationOffsetPlayable`
- `UnityEngine.Animations.AnimationPlayableBinding`
- `UnityEngine.Animations.AnimationPlayableExtensions`
- `UnityEngine.Animations.AnimationPlayableGraphExtensions`
- `UnityEngine.Animations.AnimationPlayableOutput`
- `UnityEngine.Animations.AnimationPosePlayable`
- `UnityEngine.Animations.AnimationRemoveScalePlayable`
- `UnityEngine.Animations.AnimationSceneHandleUtility`
- `UnityEngine.Animations.AnimationScriptPlayable`
- `UnityEngine.Animations.AnimationStream`
- `UnityEngine.Animations.AnimationStreamHandleUtility`
- `UnityEngine.Animations.AnimatorControllerPlayable`
- `UnityEngine.Animations.AnimatorJobExtensions`
- `UnityEngine.Animations.CustomStreamPropertyType`
- `UnityEngine.Animations.DiscreteEvaluationAttribute`
- `UnityEngine.Animations.IAnimationJob`
- `UnityEngine.Animations.IAnimationWindowPreview`
- `UnityEngine.Animations.JobMethodIndex`
- `UnityEngine.Animations.MuscleHandle`
- `UnityEngine.Animations.NotKeyableAttribute`
- `UnityEngine.Animations.PropertySceneHandle`
- `UnityEngine.Animations.PropertyStreamHandle`
- `UnityEngine.Animations.TransformSceneHandle`
- `UnityEngine.Animations.TransformStreamHandle`
- `UnityEngine.Animator`
- `UnityEngine.AnimatorClipInfo`
- `UnityEngine.AnimatorOverrideController`
- `UnityEngine.AnimatorStateInfo`
- `UnityEngine.AnimatorTransitionInfo`
- `UnityEngine.ArmDof`
- `UnityEngine.Avatar`
- `UnityEngine.AvatarIKGoal`
- `UnityEngine.AvatarIKHint`
- `UnityEngine.AvatarMask`
- `UnityEngine.AvatarMaskBodyPart`
- `UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions`
- `UnityEngine.Experimental.Animations.AnimationStreamSource`
- `UnityEngine.GCHandlePool`
- `UnityEngine.HumanBodyBones`
- `UnityEngine.HumanBone`
- `UnityEngine.HumanDescription`
- `UnityEngine.HumanLimit`
- `UnityEngine.HumanPartDof`
- `UnityEngine.HumanPose`
- `UnityEngine.HumanPoseHandler`
- `UnityEngine.LegDof`
- `UnityEngine.Motion`
- `UnityEngine.PlayMode`
- `UnityEngine.RuntimeAnimatorController`
- `UnityEngine.SharedBetweenAnimatorsAttribute`
- `UnityEngine.SkeletonBone`
- `UnityEngine.StateInfoIndex`
- `UnityEngine.StateMachineBehaviour`

</details>

<details><summary>Mismatching: 1</summary>

- `UnityEngine.Animations.ParentConstraint`

  - `bases: 'Behaviour, IConstraint, IConstraintInternal' → 'Behaviour'`


</details>

<details><summary>Indeterminate: 2</summary>

- `UnityEngine.AnimationEventBlittable`

  - Limitation: s_handlePool: no comparable storage offset

- `UnityEngine.Animations.ProcessAnimationJobStruct<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 28</summary>

- `AimConstraint.WorldUpType`
- `AnimationState.BindingsMarshaller`
- `HumanPoseHandler.BindingsMarshaller`
- `UnityEngine.AnimationCullingType`
- `UnityEngine.AnimationPlayMode`
- `UnityEngine.AnimationUpdateMode`
- `UnityEngine.Animations.AimConstraint`
- `UnityEngine.Animations.Axis`
- `UnityEngine.Animations.ConstraintSource`
- `UnityEngine.Animations.IConstraint`
- `UnityEngine.Animations.IConstraintInternal`
- `UnityEngine.Animations.LookAtConstraint`
- `UnityEngine.Animations.PositionConstraint`
- `UnityEngine.Animations.RotationConstraint`
- `UnityEngine.Animations.ScaleConstraint`
- `UnityEngine.AnimatorControllerParameter`
- `UnityEngine.AnimatorControllerParameterType`
- `UnityEngine.AnimatorCullingMode`
- `UnityEngine.AnimatorRecorderMode`
- `UnityEngine.AnimatorUpdateMode`
- `UnityEngine.AnimatorUtility`
- `UnityEngine.AvatarBuilder`
- `UnityEngine.AvatarTarget`
- `UnityEngine.BodyDof`
- `UnityEngine.HeadDof`
- `UnityEngine.HumanTrait`
- `UnityEngine.MatchTargetWeightMask`
- `UnityEngine.QueueMode`

</details>


## UnityEngine.AssetBundleModule.dll

<details><summary>Matching: 6</summary>

- `<Module>`
- `UnityEngine.AssetBundle`
- `UnityEngine.AssetBundleCreateRequest`
- `UnityEngine.AssetBundleRecompressOperation`
- `UnityEngine.AssetBundleRequest`
- `UnityEngine.AssetBundleUnloadOperation`

</details>

<details><summary>Missing: 2</summary>

- `AssetBundleCreateRequest.BindingsMarshaller`
- `AssetBundleRequest.BindingsMarshaller`

</details>


## UnityEngine.AudioModule.dll

<details><summary>Matching: 19</summary>

- `<Module>`
- `AudioClip.PCMReaderCallback`
- `AudioClip.PCMSetPositionCallback`
- `AudioSampleProvider.SampleFramesHandler`
- `AudioSettings.AudioConfigurationChangeHandler`
- `AudioSettings.Mobile`
- `UnityEngine.Audio.AudioClipPlayable`
- `UnityEngine.Audio.AudioMixerPlayable`
- `UnityEngine.Audio.AudioPlayableBinding`
- `UnityEngine.Audio.AudioPlayableGraphExtensions`
- `UnityEngine.Audio.AudioPlayableOutput`
- `UnityEngine.Audio.AudioResource`
- `UnityEngine.AudioBehaviour`
- `UnityEngine.AudioClip`
- `UnityEngine.AudioListener`
- `UnityEngine.AudioSettings`
- `UnityEngine.AudioSource`
- `UnityEngine.Experimental.Audio.AudioSampleProvider`
- `UnityEngine.FFTWindow`

</details>

<details><summary>Missing: 15</summary>

- `UnityEngine.ActivePlayable`
- `UnityEngine.Audio.AudioContainerElement`
- `UnityEngine.Audio.AudioMixer`
- `UnityEngine.Audio.AudioMixerGroup`
- `UnityEngine.Audio.AudioMixerSnapshot`
- `UnityEngine.AudioClipLoadType`
- `UnityEngine.AudioDataLoadState`
- `UnityEngine.AudioRolloffMode`
- `UnityEngine.AudioSourceCurveType`
- `UnityEngine.AudioSpeakerMode`
- `UnityEngine.AudioVelocityUpdateMode`
- `UnityEngine.PlayableSettings`
- `UnityEngine.WebCamDevice`
- `UnityEngine.WebCamKind`
- `UnityEngine.WebCamTexture`

</details>


## UnityEngine.CoreModule.dll

<details><summary>Matching: 852</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `AOT.MonoPInvokeCallbackAttribute`
- `AnimationCurve.BindingsMarshaller`
- `Application.LogCallback`
- `Application.LowMemoryCallback`
- `Application.MemoryUsageChangedCallback`
- `Awaitable.AwaitableAndFrameIndex`
- `Awaitable.AwaitableAsyncMethodBuilder`
- `Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox`
- `Awaitable.AwaitableHandle`
- `Awaitable.Awaiter`
- `Awaitable.AwaiterCompletionThreadAffinity`
- `Awaitable.DoubleBufferedAwaitableList`
- `BatchRendererGroup.OnFinishedCulling`
- `BatchRendererGroup.OnPerformCulling`
- `BeforeRenderHelper.OrderBlock`
- `BindingsAllocator.NativeOwnedMemory`
- `BlittableArrayWrapper.UpdateFlags`
- `BurstCompilerService.BurstLogType`
- `BurstLike.SharedStatic`
- `Camera.CameraCallback`
- `Camera.MonoOrStereoscopicEye`
- `Camera.SceneViewFilterMode`
- `Camera.StereoscopicEye`
- `CameraProperties.<layerCullDistances>e__FixedBuffer` (compiler-generated name)
- `CameraProperties.<m_CameraCullPlanes>e__FixedBuffer` (compiler-generated name)
- `CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer` (compiler-generated name)
- `CommandBuffer.BindingsMarshaller`
- `ComputeBuffer.BindingsMarshaller`
- `Coroutine.BindingsMarshaller`
- `CullingGroup.BindingsMarshaller`
- `CullingGroup.StateChanged`
- `Display.DisplaysUpdatedDelegate`
- `DrawingSettings.<shaderPassNames>e__FixedBuffer` (compiler-generated name)
- `EarlyUpdate.ARCoreUpdate`
- `EarlyUpdate.AnalyticsCoreStatsUpdate`
- `EarlyUpdate.ClearIntermediateRenderers`
- `EarlyUpdate.ClearLines`
- `EarlyUpdate.DeliverIosPlatformEvents`
- `EarlyUpdate.DispatchEventQueueEvents`
- `EarlyUpdate.ExecuteMainThreadJobs`
- `EarlyUpdate.GpuTimestamp`
- `EarlyUpdate.InsightsUpdate`
- `EarlyUpdate.PerformanceAnalyticsUpdate`
- `EarlyUpdate.Physics2DEarlyUpdate`
- `EarlyUpdate.PhysicsResetInterpolatedTransformPosition`
- `EarlyUpdate.PlayerCleanupCachedData`
- `EarlyUpdate.PollHtcsPlayerConnection`
- `EarlyUpdate.PollPlayerConnection`
- `EarlyUpdate.PresentBeforeUpdate`
- `EarlyUpdate.ProcessMouseInWindow`
- `EarlyUpdate.ProcessRemoteInput`
- `EarlyUpdate.RendererNotifyInvisible`
- `EarlyUpdate.ResetFrameStatsAfterPresent`
- `EarlyUpdate.ScriptRunDelayedStartupFrame`
- `EarlyUpdate.SpriteAtlasManagerUpdate`
- `EarlyUpdate.TangoUpdate`
- `EarlyUpdate.TilemapRendererEarlyUpdate`
- `EarlyUpdate.UnityWebRequestUpdate`
- `EarlyUpdate.UpdateAsyncInstantiate`
- `EarlyUpdate.UpdateAsyncReadbackManager`
- `EarlyUpdate.UpdateCanvasRectTransform`
- `EarlyUpdate.UpdateContentLoading`
- `EarlyUpdate.UpdateInputManager`
- `EarlyUpdate.UpdateKinect`
- `EarlyUpdate.UpdateMainGameViewRect`
- `EarlyUpdate.UpdatePreloading`
- `EarlyUpdate.UpdateStreamingManager`
- `EarlyUpdate.UpdateTextureStreamingManager`
- `EarlyUpdate.XRUpdate`
- `EnumDataUtility.<>c` (compiler-generated name)
- `EnumDataUtility.<>c__DisplayClass2_0` (compiler-generated name)
- `EnumDataUtility.<>c__DisplayClass8_0` (compiler-generated name)
- `EnumDataUtility.CachedType`
- `ExpressionEvaluator.<>c` (compiler-generated name)
- `ExpressionEvaluator.Associativity`
- `ExpressionEvaluator.Expression`
- `ExpressionEvaluator.Op`
- `ExpressionEvaluator.Operator`
- `ExpressionEvaluator.PcgRandom`
- `FixedUpdate.AudioFixedUpdate`
- `FixedUpdate.ClearLines`
- `FixedUpdate.DirectorFixedSampleTime`
- `FixedUpdate.DirectorFixedUpdate`
- `FixedUpdate.DirectorFixedUpdatePostPhysics`
- `FixedUpdate.LegacyFixedAnimationUpdate`
- `FixedUpdate.NewInputFixedUpdate`
- `FixedUpdate.Physics2DFixedUpdate`
- `FixedUpdate.PhysicsClothFixedUpdate`
- `FixedUpdate.PhysicsFixedUpdate`
- `FixedUpdate.ScriptRunBehaviourFixedUpdate`
- `FixedUpdate.ScriptRunDelayedFixedFrameRate`
- `FixedUpdate.XRFixedUpdate`
- `FrameData.EvaluationType`
- `FrameData.Flags`
- `GPUDrivenProcessor.<>c` (compiler-generated name)
- `Gradient.BindingsMarshaller`
- `GraphicsBuffer.BindingsMarshaller`
- `GraphicsBuffer.Target`
- `GraphicsBuffer.UsageFlags`
- `IJobExtensions.JobStruct.ExecuteJobFunction<T>`
- `IJobForExtensions.ForJobStruct.ExecuteJobFunction<T>`
- `IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T>`
- `IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<T>`
- `Initialization.AsyncUploadTimeSlicedUpdate`
- `Initialization.DirectorSampleTime`
- `Initialization.ProfilerStartFrame`
- `Initialization.SynchronizeInputs`
- `Initialization.SynchronizeState`
- `Initialization.UpdateCameraMotionVectors`
- `Initialization.XREarlyUpdate`
- `JetBrains.Annotations.CanBeNullAttribute`
- `JetBrains.Annotations.ContractAnnotationAttribute`
- `JetBrains.Annotations.NotNullAttribute`
- `JetBrains.Annotations.PureAttribute`
- `JobsUtility.JobScheduleParameters`
- `JobsUtility.PanicFunction_`
- `Lightmapping.<>c` (compiler-generated name)
- `Lightmapping.RequestLightsDelegate`
- `MaterialPropertyBlock.BindingsMarshaller`
- `Mesh.MeshData`
- `Mesh.MeshDataArray`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `Object.MarshalledUnityObject`
- `ObjectDispatcher.<>c` (compiler-generated name)
- `PlayableBinding.CreateOutputMethod`
- `PlayerConnection.<>c__DisplayClass12_0` (compiler-generated name)
- `PlayerConnection.<>c__DisplayClass13_0` (compiler-generated name)
- `PlayerConnection.<>c__DisplayClass20_0` (compiler-generated name)
- `PlayerEditorConnectionEvents.ConnectionChangeEvent`
- `PlayerEditorConnectionEvents.MessageEvent`
- `PlayerEditorConnectionEvents.MessageTypeSubscribers`
- `PlayerLoopSystem.UpdateFunction`
- `PostLateUpdate.BatchModeUpdate`
- `PostLateUpdate.ClearImmediateRenderers`
- `PostLateUpdate.DirectorLateUpdate`
- `PostLateUpdate.DirectorRenderImage`
- `PostLateUpdate.EndGraphicsJobsAfterScriptLateUpdate`
- `PostLateUpdate.EnlightenRuntimeUpdate`
- `PostLateUpdate.ExecuteGameCenterCallbacks`
- `PostLateUpdate.FinishFrameRendering`
- `PostLateUpdate.GUIClearEvents`
- `PostLateUpdate.GraphicsWarmupPreloadedShaders`
- `PostLateUpdate.InputEndFrame`
- `PostLateUpdate.MemoryFrameMaintenance`
- `PostLateUpdate.ObjectDispatcherPostLateUpdate`
- `PostLateUpdate.ParticleSystemEndUpdateAll`
- `PostLateUpdate.PhysicsSkinnedClothBeginUpdate`
- `PostLateUpdate.PhysicsSkinnedClothFinishUpdate`
- `PostLateUpdate.PlayerEmitCanvasGeometry`
- `PostLateUpdate.PlayerSendFrameComplete`
- `PostLateUpdate.PlayerSendFramePostPresent`
- `PostLateUpdate.PlayerSendFrameStarted`
- `PostLateUpdate.PlayerUpdateCanvases`
- `PostLateUpdate.PresentAfterDraw`
- `PostLateUpdate.ProcessWebSendMessages`
- `PostLateUpdate.ProfilerEndFrame`
- `PostLateUpdate.ProfilerSynchronizeStats`
- `PostLateUpdate.ResetInputAxis`
- `PostLateUpdate.ScriptRunDelayedDynamicFrameRate`
- `PostLateUpdate.ShaderHandleErrors`
- `PostLateUpdate.SortingGroupsUpdate`
- `PostLateUpdate.ThreadedLoadingDebug`
- `PostLateUpdate.TriggerEndOfFrameCallbacks`
- `PostLateUpdate.UIElementsRenderBatchModeOffscreen`
- `PostLateUpdate.UIElementsRepaintPanels`
- `PostLateUpdate.UpdateAllRenderers`
- `PostLateUpdate.UpdateAllSkinnedMeshes`
- `PostLateUpdate.UpdateAudio`
- `PostLateUpdate.UpdateCanvasRectTransform`
- `PostLateUpdate.UpdateCaptureScreenshot`
- `PostLateUpdate.UpdateCustomRenderTextures`
- `PostLateUpdate.UpdateLightProbeProxyVolumes`
- `PostLateUpdate.UpdateRectTransform`
- `PostLateUpdate.UpdateResolution`
- `PostLateUpdate.UpdateSubstance`
- `PostLateUpdate.UpdateVideo`
- `PostLateUpdate.UpdateVideoTextures`
- `PostLateUpdate.VFXUpdate`
- `PostLateUpdate.XRPostLateUpdate`
- `PostLateUpdate.XRPostPresent`
- `PostLateUpdate.XRPreEndFrame`
- `PreLateUpdate.AIUpdatePostScript`
- `PreLateUpdate.AccessibilityUpdate`
- `PreLateUpdate.ConstraintManagerUpdate`
- `PreLateUpdate.DirectorDeferredEvaluate`
- `PreLateUpdate.DirectorUpdateAnimationBegin`
- `PreLateUpdate.DirectorUpdateAnimationEnd`
- `PreLateUpdate.EndGraphicsJobsAfterScriptUpdate`
- `PreLateUpdate.LegacyAnimationUpdate`
- `PreLateUpdate.ParticleSystemBeginUpdateAll`
- `PreLateUpdate.Physics2DLateUpdate`
- `PreLateUpdate.PhysicsLateUpdate`
- `PreLateUpdate.ScriptRunBehaviourLateUpdate`
- `PreLateUpdate.UIElementsUpdatePanels`
- `PreLateUpdate.UpdateMasterServerInterface`
- `PreLateUpdate.UpdateNetworkManager`
- `PreUpdate.AIUpdate`
- `PreUpdate.CheckTexFieldInput`
- `PreUpdate.IMGUISendQueuedEvents`
- `PreUpdate.InputForUIUpdate`
- `PreUpdate.NewInputUpdate`
- `PreUpdate.Physics2DUpdate`
- `PreUpdate.PhysicsClothUpdate`
- `PreUpdate.PhysicsUpdate`
- `PreUpdate.SendMouseEvents`
- `PreUpdate.UpdateVideo`
- `PreUpdate.WindUpdate`
- `ProfilerMarker.AutoScope`
- `ProfilerRecorder.ControlOptions`
- `Random.State`
- `RationalTime.TicksPerSecond`
- `RectOffset.BindingsMarshaller`
- `RectTransform.Axis`
- `RectTransform.ReapplyDrivenProperties`
- `ReflectionProbe.ReflectionProbeEvent`
- `RenderPipeline.StandardRequest`
- `ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer` (compiler-generated name)
- `ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer` (compiler-generated name)
- `ScriptableRenderContext.CullShadowCastersContext`
- `ScriptingUtility.TestClass`
- `ShadowSplitData.<m_CullingPlanes>e__FixedBuffer` (compiler-generated name)
- `SupportedRenderingFeatures.LightmapMixedBakeModes`
- `SupportedRenderingFeatures.ReflectionProbeModes`
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `TextAsset.CreateOptions`
- `TextAsset.EncodingUtility`
- `TimeUpdate.WaitForLastPresentationAndUpdateTime`
- `TouchScreenKeyboard.BindingsMarshaller`
- `TouchScreenKeyboard.InputFieldAppearance`
- `TouchScreenKeyboard.Status`
- `Transform.Enumerator`
- `UnhandledExceptionHandler.<>c` (compiler-generated name)
- `Unity.Burst.BurstAuthorizedExternalMethodAttribute`
- `Unity.Burst.BurstDiscardAttribute`
- `Unity.Burst.LowLevel.BurstCompilerService`
- `Unity.Collections.Allocator`
- `Unity.Collections.DeallocateOnJobCompletionAttribute`
- `Unity.Collections.LeakCategory`
- `Unity.Collections.LowLevel.Unsafe.BurstLike`
- `Unity.Collections.LowLevel.Unsafe.BurstRuntime`
- `Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerIsAtomicWriteOnlyAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerIsReadOnlyAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerNeedsThreadIndexAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeallocateOnJobCompletionAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeferredConvertListToArray`
- `Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsMinMaxWriteRestrictionAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeDisableContainerSafetyRestrictionAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeDisableUnsafePtrRestrictionAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeSetClassTypeToNullOnScheduleAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeSetThreadIndexAttribute`
- `Unity.Collections.LowLevel.Unsafe.NativeSliceUnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.UnsafeUtility`
- `Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute`
- `Unity.Collections.NativeArrayDebugView<T>`
- `Unity.Collections.NativeArrayDispose`
- `Unity.Collections.NativeArrayDisposeJob`
- `Unity.Collections.NativeArrayOptions`
- `Unity.Collections.NativeArrayReadOnlyDebugView<T>`
- `Unity.Collections.NativeDisableParallelForRestrictionAttribute`
- `Unity.Collections.NativeFixedLengthAttribute`
- `Unity.Collections.NativeMatchesParallelForLengthAttribute`
- `Unity.Collections.NativeSliceDebugView<T>`
- `Unity.Collections.NativeSliceExtensions`
- `Unity.Collections.ReadOnlyAttribute`
- `Unity.Collections.WriteOnlyAttribute`
- `Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute`
- `Unity.IO.Archive.ArchiveFileInfo`
- `Unity.IO.Archive.ArchiveFileInterface`
- `Unity.IO.Archive.ArchiveHandle`
- `Unity.IO.Archive.ArchiveStatus`
- `Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem`
- `Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters`
- `Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric`
- `Unity.IO.LowLevel.Unsafe.FileReadType`
- `Unity.IO.LowLevel.Unsafe.FileState`
- `Unity.IO.LowLevel.Unsafe.Priority`
- `Unity.IO.LowLevel.Unsafe.ProcessingState`
- `Unity.IntegerTime.DiscreteTime`
- `Unity.IntegerTime.RationalTime`
- `Unity.IntegerTime.RationalTimeExtensions`
- `Unity.Jobs.IJob`
- `Unity.Jobs.IJobExtensions`
- `Unity.Jobs.IJobFor`
- `Unity.Jobs.IJobForExtensions`
- `Unity.Jobs.IJobParallelFor`
- `Unity.Jobs.IJobParallelForExtensions`
- `Unity.Jobs.JobHandle`
- `Unity.Jobs.LowLevel.Unsafe.JobProducerTypeAttribute`
- `Unity.Jobs.LowLevel.Unsafe.JobRanges`
- `Unity.Jobs.LowLevel.Unsafe.JobsUtility`
- `Unity.Jobs.LowLevel.Unsafe.ScheduleMode`
- `Unity.Profiling.DebugScreenCapture`
- `Unity.Profiling.IgnoredByDeepProfilerAttribute`
- `Unity.Profiling.LowLevel.MarkerFlags`
- `Unity.Profiling.LowLevel.ProfilerMarkerDataType`
- `Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription`
- `Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription`
- `Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle`
- `Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility`
- `Unity.Profiling.Memory.MemoryProfiler`
- `Unity.Profiling.Memory.MemorySnapshotMetadata`
- `Unity.Profiling.ProfilerCategory`
- `Unity.Profiling.ProfilerCategoryColor`
- `Unity.Profiling.ProfilerCounterOptions`
- `Unity.Profiling.ProfilerMarker`
- `Unity.Profiling.ProfilerMarkerDataUnit`
- `Unity.Profiling.ProfilerRecorder`
- `Unity.Profiling.ProfilerRecorderDebugView`
- `Unity.Profiling.ProfilerRecorderOptions`
- `UnityEngine.AddComponentMenu`
- `UnityEngine.Analytics.AnalyticsEventBase`
- `UnityEngine.Analytics.BatchRenderGroupUsageAnalytic`
- `UnityEngine.Analytics.SendEventOptions`
- `UnityEngine.Analytics.ShaderRuntimeInfoAnalytic`
- `UnityEngine.Analytics.UaaLApplicationLaunchAnalytic`
- `UnityEngine.AnimationCurve`
- `UnityEngine.ApplicationMemoryUsage`
- `UnityEngine.ApplicationMemoryUsageChange`
- `UnityEngine.AssemblyFullName`
- `UnityEngine.AssemblyIsEditorAssembly`
- `UnityEngine.AssemblyVersion`
- `UnityEngine.Assertions.Assert`
- `UnityEngine.Assertions.AssertionException`
- `UnityEngine.Assertions.AssertionMessageUtil`
- `UnityEngine.AsyncInstantiateOperation`
- `UnityEngine.AsyncInstantiateOperationHelper`
- `UnityEngine.AsyncOperation`
- `UnityEngine.AttributeHelperEngine`
- `UnityEngine.Awaitable`
- `UnityEngine.BatchRendererGroupRuntimeAnalytic`
- `UnityEngine.BeforeRenderHelper`
- `UnityEngine.Behaviour`
- `UnityEngine.Bindings.BindingsAllocator`
- `UnityEngine.Bindings.BlittableArrayWrapper`
- `UnityEngine.Bindings.BlittableListWrapper`
- `UnityEngine.Bindings.ManagedSpanWrapper`
- `UnityEngine.Bindings.OutStringMarshaller`
- `UnityEngine.Bindings.StringMarshaller`
- `UnityEngine.Bindings.ThrowHelper`
- `UnityEngine.Bindings.Unmarshal`
- `UnityEngine.BoneWeight`
- `UnityEngine.BootConfigData`
- `UnityEngine.BoundingSphere`
- `UnityEngine.Bounds`
- `UnityEngine.BoundsInt`
- `UnityEngine.Cache`
- `UnityEngine.CachedAssetBundle`
- `UnityEngine.Camera`
- `UnityEngine.CameraClearFlags`
- `UnityEngine.CameraType`
- `UnityEngine.ClassLibraryInitializer`
- `UnityEngine.Color`
- `UnityEngine.Color32`
- `UnityEngine.ColorGamut`
- `UnityEngine.ColorGamutUtility`
- `UnityEngine.ColorPrimaries`
- `UnityEngine.ColorSpace`
- `UnityEngine.ColorUsageAttribute`
- `UnityEngine.ColorUtility`
- `UnityEngine.CombineInstance`
- `UnityEngine.Component`
- `UnityEngine.ComputeBuffer`
- `UnityEngine.ComputeBufferMode`
- `UnityEngine.ComputeBufferType`
- `UnityEngine.ComputeShader`
- `UnityEngine.ContextMenu`
- `UnityEngine.Coroutine`
- `UnityEngine.CreateAssetMenuAttribute`
- `UnityEngine.Cubemap`
- `UnityEngine.CubemapArray`
- `UnityEngine.CubemapFace`
- `UnityEngine.CullingGroup`
- `UnityEngine.CullingGroupEvent`
- `UnityEngine.CullingQueryOptions`
- `UnityEngine.Cursor`
- `UnityEngine.CursorLockMode`
- `UnityEngine.CursorMode`
- `UnityEngine.CustomRenderTexture`
- `UnityEngine.CustomRenderTextureManager`
- `UnityEngine.CustomYieldInstruction`
- `UnityEngine.Debug`
- `UnityEngine.DebugLogHandler`
- `UnityEngine.DefaultExecutionOrder`
- `UnityEngine.DelayedAttribute`
- `UnityEngine.DepthTextureMode`
- `UnityEngine.DeviceType`
- `UnityEngine.DisallowMultipleComponent`
- `UnityEngine.Display`
- `UnityEngine.DrivenRectTransformTracker`
- `UnityEngine.DrivenTransformProperties`
- `UnityEngine.EnumData`
- `UnityEngine.EnumDataUtility`
- `UnityEngine.Events.ArgumentCache`
- `UnityEngine.Events.BaseInvokableCall`
- `UnityEngine.Events.InvokableCall`
- `UnityEngine.Events.InvokableCallList`
- `UnityEngine.Events.PersistentCall`
- `UnityEngine.Events.PersistentCallGroup`
- `UnityEngine.Events.PersistentListenerMode`
- `UnityEngine.Events.UnityAction`
- `UnityEngine.Events.UnityAction<T0, T1, T2, T3>`
- `UnityEngine.Events.UnityAction<T0, T1, T2>`
- `UnityEngine.Events.UnityAction<T0, T1>`
- `UnityEngine.Events.UnityAction<T0>`
- `UnityEngine.Events.UnityEvent`
- `UnityEngine.Events.UnityEventBase`
- `UnityEngine.Events.UnityEventCallState`
- `UnityEngine.Events.UnityEventTools`
- `UnityEngine.ExcludeFromObjectFactoryAttribute`
- `UnityEngine.ExcludeFromPresetAttribute`
- `UnityEngine.ExecuteAlways`
- `UnityEngine.ExecuteInEditMode`
- `UnityEngine.Experimental.GlobalIllumination.AngularFalloffType`
- `UnityEngine.Experimental.GlobalIllumination.Cookie`
- `UnityEngine.Experimental.GlobalIllumination.DirectionalLight`
- `UnityEngine.Experimental.GlobalIllumination.DiscLight`
- `UnityEngine.Experimental.GlobalIllumination.FalloffType`
- `UnityEngine.Experimental.GlobalIllumination.LightDataGI`
- `UnityEngine.Experimental.GlobalIllumination.LightMode`
- `UnityEngine.Experimental.GlobalIllumination.LightType`
- `UnityEngine.Experimental.GlobalIllumination.LightmapperUtils`
- `UnityEngine.Experimental.GlobalIllumination.Lightmapping`
- `UnityEngine.Experimental.GlobalIllumination.LinearColor`
- `UnityEngine.Experimental.GlobalIllumination.PointLight`
- `UnityEngine.Experimental.GlobalIllumination.RectangleLight`
- `UnityEngine.Experimental.GlobalIllumination.SpotLight`
- `UnityEngine.Experimental.Playables.CameraPlayable`
- `UnityEngine.Experimental.Playables.MaterialEffectPlayable`
- `UnityEngine.Experimental.Playables.TextureMixerPlayable`
- `UnityEngine.Experimental.Playables.TexturePlayableOutput`
- `UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem`
- `UnityEngine.Experimental.Rendering.DefaultFormat`
- `UnityEngine.Experimental.Rendering.FormatUsage`
- `UnityEngine.Experimental.Rendering.GraphicsFormat`
- `UnityEngine.Experimental.Rendering.GraphicsFormatUsage`
- `UnityEngine.Experimental.Rendering.GraphicsFormatUtility`
- `UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem`
- `UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings`
- `UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper`
- `UnityEngine.Experimental.Rendering.TextureCreationFlags`
- `UnityEngine.Experimental.U2D.SpriteIntermediateRendererInfo`
- `UnityEngine.Experimental.U2D.SpriteRendererGroup`
- `UnityEngine.ExpressionEvaluator`
- `UnityEngine.ExtensionOfNativeClassAttribute`
- `UnityEngine.FailedToLoadScriptObject`
- `UnityEngine.FilterMode`
- `UnityEngine.FindObjectsInactive`
- `UnityEngine.FindObjectsSortMode`
- `UnityEngine.FrameTiming`
- `UnityEngine.FrameTimingManager`
- `UnityEngine.FrustumPlanes`
- `UnityEngine.GL`
- `UnityEngine.GameObject`
- `UnityEngine.GeometryUtility`
- `UnityEngine.Gizmos`
- `UnityEngine.Gradient`
- `UnityEngine.GradientAlphaKey`
- `UnityEngine.GradientColorKey`
- `UnityEngine.Graphics`
- `UnityEngine.GraphicsBuffer`
- `UnityEngine.GraphicsBufferHandle`
- `UnityEngine.HDRDisplaySupportFlags`
- `UnityEngine.HDROutputSettings`
- `UnityEngine.Hash128`
- `UnityEngine.HeaderAttribute`
- `UnityEngine.HelpURLAttribute`
- `UnityEngine.HideFlags`
- `UnityEngine.HideInCallstackAttribute`
- `UnityEngine.HideInInspector`
- `UnityEngine.IExposedPropertyTable`
- `UnityEngine.ILogHandler`
- `UnityEngine.ILogger`
- `UnityEngine.IPlayerEditorConnectionNative`
- `UnityEngine.ISerializationCallbackReceiver`
- `UnityEngine.ImageEffectAllowedInSceneView`
- `UnityEngine.InspectorNameAttribute`
- `UnityEngine.InspectorOrderAttribute`
- `UnityEngine.InspectorSort`
- `UnityEngine.InspectorSortDirection`
- `UnityEngine.Internal.DefaultValueAttribute`
- `UnityEngine.Internal.ExcludeFromDocsAttribute`
- `UnityEngine.Jobs.IJobParallelForTransform`
- `UnityEngine.Jobs.IJobParallelForTransformExtensions`
- `UnityEngine.Jobs.TransformAccess`
- `UnityEngine.Jobs.TransformAccessArray`
- `UnityEngine.KeyCode`
- `UnityEngine.Keyframe`
- `UnityEngine.LODFadeMode`
- `UnityEngine.LayerMask`
- `UnityEngine.Light`
- `UnityEngine.LightBakingOutput`
- `UnityEngine.LightProbeProxyVolume`
- `UnityEngine.LightProbes`
- `UnityEngine.LightShadows`
- `UnityEngine.LightShape`
- `UnityEngine.LightType`
- `UnityEngine.LightingSettings`
- `UnityEngine.LightmapBakeType`
- `UnityEngine.LightmapSettings`
- `UnityEngine.LightmapsMode`
- `UnityEngine.LineRenderer`
- `UnityEngine.LineTextureMode`
- `UnityEngine.LogOption`
- `UnityEngine.LogType`
- `UnityEngine.Logger`
- `UnityEngine.LowLevel.PlayerLoopSystem`
- `UnityEngine.LowLevel.PlayerLoopSystemInternal`
- `UnityEngine.LowerResBlitTexture`
- `UnityEngine.ManagedStreamHelpers`
- `UnityEngine.Material`
- `UnityEngine.MaterialPropertyBlock`
- `UnityEngine.Mathf`
- `UnityEngine.Matrix4x4`
- `UnityEngine.Mesh`
- `UnityEngine.MeshFilter`
- `UnityEngine.MeshRenderer`
- `UnityEngine.MeshTopology`
- `UnityEngine.MinAttribute`
- `UnityEngine.MipmapLimitDescriptor`
- `UnityEngine.MissingReferenceException`
- `UnityEngine.MixedLightingMode`
- `UnityEngine.MonoBehaviour`
- `UnityEngine.MotionVectorGenerationMode`
- `UnityEngine.MultilineAttribute`
- `UnityEngine.NameFormatter`
- `UnityEngine.Networking.PlayerConnection.MessageEventArgs`
- `UnityEngine.Networking.PlayerConnection.PlayerConnection`
- `UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents`
- `UnityEngine.NoAllocHelpers`
- `UnityEngine.NonReorderableAttribute`
- `UnityEngine.NumericFieldDraggerUtility`
- `UnityEngine.Object`
- `UnityEngine.ObjectDispatcher`
- `UnityEngine.OperatingSystemFamily`
- `UnityEngine.Plane`
- `UnityEngine.Playables.DirectorUpdateMode`
- `UnityEngine.Playables.DirectorWrapMode`
- `UnityEngine.Playables.FrameData`
- `UnityEngine.Playables.FrameRate`
- `UnityEngine.Playables.INotification`
- `UnityEngine.Playables.INotificationReceiver`
- `UnityEngine.Playables.IPlayable`
- `UnityEngine.Playables.IPlayableAsset`
- `UnityEngine.Playables.IPlayableBehaviour`
- `UnityEngine.Playables.IPlayableOutput`
- `UnityEngine.Playables.PlayState`
- `UnityEngine.Playables.Playable`
- `UnityEngine.Playables.PlayableAsset`
- `UnityEngine.Playables.PlayableBehaviour`
- `UnityEngine.Playables.PlayableBinding`
- `UnityEngine.Playables.PlayableExtensions`
- `UnityEngine.Playables.PlayableGraph`
- `UnityEngine.Playables.PlayableHandle`
- `UnityEngine.Playables.PlayableOutput`
- `UnityEngine.Playables.PlayableOutputExtensions`
- `UnityEngine.Playables.PlayableOutputHandle`
- `UnityEngine.Playables.PlayableTraversalMode`
- `UnityEngine.Playables.ScriptPlayableBinding`
- `UnityEngine.Playables.ScriptPlayableOutput`
- `UnityEngine.PlayerConnectionInternal`
- `UnityEngine.PlayerLoop.EarlyUpdate`
- `UnityEngine.PlayerLoop.FixedUpdate`
- `UnityEngine.PlayerLoop.Initialization`
- `UnityEngine.PlayerLoop.PostLateUpdate`
- `UnityEngine.PlayerLoop.PreLateUpdate`
- `UnityEngine.PlayerLoop.PreUpdate`
- `UnityEngine.PlayerLoop.TimeUpdate`
- `UnityEngine.PlayerLoop.Update`
- `UnityEngine.Pool.IObjectPool<T>`
- `UnityEngine.Pool.IPool`
- `UnityEngine.Pool.PoolManager`
- `UnityEngine.PreferBinarySerialization`
- `UnityEngine.PreloadData`
- `UnityEngine.Profiling.CustomSampler`
- `UnityEngine.Profiling.Profiler`
- `UnityEngine.Profiling.Recorder`
- `UnityEngine.Profiling.Sampler`
- `UnityEngine.PropertyAttribute`
- `UnityEngine.PropertyName`
- `UnityEngine.PropertyNameUtils`
- `UnityEngine.QualitySettings`
- `UnityEngine.Quaternion`
- `UnityEngine.Random`
- `UnityEngine.RangeAttribute`
- `UnityEngine.RangeInt`
- `UnityEngine.Ray`
- `UnityEngine.Rect`
- `UnityEngine.RectInt`
- `UnityEngine.RectOffset`
- `UnityEngine.RectTransform`
- `UnityEngine.ReflectionProbe`
- `UnityEngine.RefreshRate`
- `UnityEngine.RenderBuffer`
- `UnityEngine.RenderInstancedDataLayout`
- `UnityEngine.RenderParams`
- `UnityEngine.RenderSettings`
- `UnityEngine.RenderTexture`
- `UnityEngine.RenderTextureCreationFlags`
- `UnityEngine.RenderTextureDescriptor`
- `UnityEngine.RenderTextureFormat`
- `UnityEngine.RenderTextureMemoryless`
- `UnityEngine.RenderTextureReadWrite`
- `UnityEngine.Renderer`
- `UnityEngine.Rendering.AsyncGPUReadback`
- `UnityEngine.Rendering.AsyncGPUReadbackRequest`
- `UnityEngine.Rendering.AsyncRequestNativeArrayData`
- `UnityEngine.Rendering.AttachmentDescriptor`
- `UnityEngine.Rendering.BatchCullingContext`
- `UnityEngine.Rendering.BatchCullingFlags`
- `UnityEngine.Rendering.BatchCullingOutput`
- `UnityEngine.Rendering.BatchCullingOutputDrawCommands`
- `UnityEngine.Rendering.BatchCullingProjectionType`
- `UnityEngine.Rendering.BatchCullingViewType`
- `UnityEngine.Rendering.BatchDrawCommand`
- `UnityEngine.Rendering.BatchDrawCommandFlags`
- `UnityEngine.Rendering.BatchDrawCommandIndirect`
- `UnityEngine.Rendering.BatchDrawCommandProcedural`
- `UnityEngine.Rendering.BatchDrawCommandProceduralIndirect`
- `UnityEngine.Rendering.BatchDrawCommandType`
- `UnityEngine.Rendering.BatchDrawRange`
- `UnityEngine.Rendering.BatchFilterSettings`
- `UnityEngine.Rendering.BatchID`
- `UnityEngine.Rendering.BatchMaterialID`
- `UnityEngine.Rendering.BatchMeshID`
- `UnityEngine.Rendering.BatchPackedCullingViewID`
- `UnityEngine.Rendering.BatchRendererCullingOutput`
- `UnityEngine.Rendering.BatchRendererGroup`
- `UnityEngine.Rendering.BlendMode`
- `UnityEngine.Rendering.BlendOp`
- `UnityEngine.Rendering.BlendState`
- `UnityEngine.Rendering.BuiltinRenderTextureType`
- `UnityEngine.Rendering.BuiltinShaderDefine`
- `UnityEngine.Rendering.CameraLateLatchMatrixType`
- `UnityEngine.Rendering.CameraProperties`
- `UnityEngine.Rendering.ColorWriteMask`
- `UnityEngine.Rendering.CommandBuffer`
- `UnityEngine.Rendering.CommandBufferExecutionFlags`
- `UnityEngine.Rendering.CommandBufferExtensions`
- `UnityEngine.Rendering.CompareFunction`
- `UnityEngine.Rendering.ComputeQueueType`
- `UnityEngine.Rendering.CopyTextureSupport`
- `UnityEngine.Rendering.CoreCameraValues`
- `UnityEngine.Rendering.CullMode`
- `UnityEngine.Rendering.CullingAllocationInfo`
- `UnityEngine.Rendering.CullingOptions`
- `UnityEngine.Rendering.CullingResults`
- `UnityEngine.Rendering.CullingSplit`
- `UnityEngine.Rendering.DefaultMaterialType`
- `UnityEngine.Rendering.DefaultShaderType`
- `UnityEngine.Rendering.DepthState`
- `UnityEngine.Rendering.DistanceMetric`
- `UnityEngine.Rendering.DrawRendererFlags`
- `UnityEngine.Rendering.DrawingSettings`
- `UnityEngine.Rendering.FastMemoryFlags`
- `UnityEngine.Rendering.FilteringSettings`
- `UnityEngine.Rendering.FormatSwizzle`
- `UnityEngine.Rendering.FoveatedRenderingCaps`
- `UnityEngine.Rendering.FoveatedRenderingMode`
- `UnityEngine.Rendering.GPUDrivenCallbacks`
- `UnityEngine.Rendering.GPUDrivenLODGroupData`
- `UnityEngine.Rendering.GPUDrivenLODGroupDataCallback`
- `UnityEngine.Rendering.GPUDrivenLODGroupDataNative`
- `UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback`
- `UnityEngine.Rendering.GPUDrivenPackedMaterialData`
- `UnityEngine.Rendering.GPUDrivenPackedRendererData`
- `UnityEngine.Rendering.GPUDrivenProcessor`
- `UnityEngine.Rendering.GPUDrivenRendererDataCallback`
- `UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback`
- `UnityEngine.Rendering.GPUDrivenRendererEditorData`
- `UnityEngine.Rendering.GPUDrivenRendererGroupData`
- `UnityEngine.Rendering.GPUDrivenRendererGroupDataNative`
- `UnityEngine.Rendering.GizmoSubset`
- `UnityEngine.Rendering.GraphicsDeviceType`
- `UnityEngine.Rendering.GraphicsFence`
- `UnityEngine.Rendering.GraphicsFenceType`
- `UnityEngine.Rendering.GraphicsSettings`
- `UnityEngine.Rendering.GraphicsTier`
- `UnityEngine.Rendering.IRenderPipelineGraphicsSettings`
- `UnityEngine.Rendering.IndexFormat`
- `UnityEngine.Rendering.InvalidImportException`
- `UnityEngine.Rendering.LODParameters`
- `UnityEngine.Rendering.LightProbeUsage`
- `UnityEngine.Rendering.LightShadowCasterCullingInfo`
- `UnityEngine.Rendering.LightShadowResolution`
- `UnityEngine.Rendering.LocalKeyword`
- `UnityEngine.Rendering.LocalKeywordSpace`
- `UnityEngine.Rendering.MeshUpdateFlags`
- `UnityEngine.Rendering.OnDemandRendering`
- `UnityEngine.Rendering.OpaqueSortMode`
- `UnityEngine.Rendering.OpenGLESVersion`
- `UnityEngine.Rendering.PerObjectData`
- `UnityEngine.Rendering.RTClearFlags`
- `UnityEngine.Rendering.RasterState`
- `UnityEngine.Rendering.ReflectionProbeRefreshMode`
- `UnityEngine.Rendering.ReflectionProbeSortingCriteria`
- `UnityEngine.Rendering.ReflectionProbeUsage`
- `UnityEngine.Rendering.RenderBufferLoadAction`
- `UnityEngine.Rendering.RenderBufferStoreAction`
- `UnityEngine.Rendering.RenderPipeline`
- `UnityEngine.Rendering.RenderPipelineAsset`
- `UnityEngine.Rendering.RenderPipelineAsset<TRenderPipeline>`
- `UnityEngine.Rendering.RenderPipelineGlobalSettings`
- `UnityEngine.Rendering.RenderPipelineGraphicsSettingsCollection`
- `UnityEngine.Rendering.RenderPipelineManager`
- `UnityEngine.Rendering.RenderQueueRange`
- `UnityEngine.Rendering.RenderStateBlock`
- `UnityEngine.Rendering.RenderStateMask`
- `UnityEngine.Rendering.RenderTargetBinding`
- `UnityEngine.Rendering.RenderTargetBlendState`
- `UnityEngine.Rendering.RenderTargetFlags`
- `UnityEngine.Rendering.RenderTargetIdentifier`
- `UnityEngine.Rendering.RenderTextureSubElement`
- `UnityEngine.Rendering.RendererList`
- `UnityEngine.Rendering.RendererListParams`
- `UnityEngine.Rendering.RendererListStatus`
- `UnityEngine.Rendering.RendererUtils.RendererListDesc`
- `UnityEngine.Rendering.ScriptableCullingParameters`
- `UnityEngine.Rendering.ScriptableRenderContext`
- `UnityEngine.Rendering.ShaderKeyword`
- `UnityEngine.Rendering.ShaderPropertyFlags`
- `UnityEngine.Rendering.ShaderTagId`
- `UnityEngine.Rendering.ShadowCastingMode`
- `UnityEngine.Rendering.ShadowDrawingSettings`
- `UnityEngine.Rendering.ShadowSamplingMode`
- `UnityEngine.Rendering.ShadowSplitData`
- `UnityEngine.Rendering.SinglePassStereoMode`
- `UnityEngine.Rendering.SortingCriteria`
- `UnityEngine.Rendering.SortingGroup`
- `UnityEngine.Rendering.SortingLayerRange`
- `UnityEngine.Rendering.SortingSettings`
- `UnityEngine.Rendering.SphericalHarmonicsL2`
- `UnityEngine.Rendering.StencilOp`
- `UnityEngine.Rendering.StencilState`
- `UnityEngine.Rendering.SubMeshDescriptor`
- `UnityEngine.Rendering.SupportedRenderingFeatures`
- `UnityEngine.Rendering.SynchronisationStage`
- `UnityEngine.Rendering.SynchronisationStageFlags`
- `UnityEngine.Rendering.TextureDimension`
- `UnityEngine.Rendering.VertexAttribute`
- `UnityEngine.Rendering.VertexAttributeDescriptor`
- `UnityEngine.Rendering.VertexAttributeFormat`
- `UnityEngine.Rendering.VisibleLight`
- `UnityEngine.Rendering.VisibleLightFlags`
- `UnityEngine.Rendering.VisibleReflectionProbe`
- `UnityEngine.RequireComponent`
- `UnityEngine.Resolution`
- `UnityEngine.ResourceRequest`
- `UnityEngine.Resources`
- `UnityEngine.ResourcesAPI`
- `UnityEngine.ResourcesAPIInternal`
- `UnityEngine.RuntimeInitializeLoadType`
- `UnityEngine.RuntimeInitializeOnLoadMethodAttribute`
- `UnityEngine.RuntimePlatform`
- `UnityEngine.ScalableBufferManager`
- `UnityEngine.SceneManagement.LoadSceneMode`
- `UnityEngine.SceneManagement.LoadSceneParameters`
- `UnityEngine.SceneManagement.LocalPhysicsMode`
- `UnityEngine.SceneManagement.Scene`
- `UnityEngine.SceneManagement.SceneManager`
- `UnityEngine.SceneManagement.SceneManagerAPI`
- `UnityEngine.Screen`
- `UnityEngine.ScreenOrientation`
- `UnityEngine.ScriptableObject`
- `UnityEngine.Scripting.APIUpdating.MovedFromAttribute`
- `UnityEngine.Scripting.APIUpdating.MovedFromAttributeData`
- `UnityEngine.Scripting.PreserveAttribute`
- `UnityEngine.Scripting.RequiredMemberAttribute`
- `UnityEngine.ScriptingRuntime`
- `UnityEngine.ScriptingUtility`
- `UnityEngine.SecondarySpriteTexture`
- `UnityEngine.SelectionBaseAttribute`
- `UnityEngine.SendMessageOptions`
- `UnityEngine.Serialization.FormerlySerializedAsAttribute`
- `UnityEngine.SerializeField`
- `UnityEngine.SerializeReference`
- `UnityEngine.SetupCoroutine`
- `UnityEngine.Shader`
- `UnityEngine.ShaderVariantCollection`
- `UnityEngine.ShadowObjectsFilter`
- `UnityEngine.ShadowmaskMode`
- `UnityEngine.SkinnedMeshRenderer`
- `UnityEngine.Skybox`
- `UnityEngine.SortingLayer`
- `UnityEngine.SpaceAttribute`
- `UnityEngine.Sprite`
- `UnityEngine.SpriteMeshType`
- `UnityEngine.SpritePackingRotation`
- `UnityEngine.SpriteRenderer`
- `UnityEngine.Sprites.DataUtility`
- `UnityEngine.StackTraceUtility`
- `UnityEngine.StereoTargetEyeMask`
- `UnityEngine.SystemInfo`
- `UnityEngine.SystemLanguage`
- `UnityEngine.TextAreaAttribute`
- `UnityEngine.TextAsset`
- `UnityEngine.Texture`
- `UnityEngine.Texture2D`
- `UnityEngine.Texture2DArray`
- `UnityEngine.Texture3D`
- `UnityEngine.TextureColorSpace`
- `UnityEngine.TextureFormat`
- `UnityEngine.TextureWrapMode`
- `UnityEngine.ThreadPriority`
- `UnityEngine.Time`
- `UnityEngine.TooltipAttribute`
- `UnityEngine.TouchScreenKeyboard`
- `UnityEngine.TouchScreenKeyboardType`
- `UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments`
- `UnityEngine.TrackedReference`
- `UnityEngine.TransferFunction`
- `UnityEngine.Transform`
- `UnityEngine.TransformDispatchData`
- `UnityEngine.TransparencySortMode`
- `UnityEngine.TypeDispatchData`
- `UnityEngine.U2D.PixelPerfectRendering`
- `UnityEngine.U2D.SpriteAtlas`
- `UnityEngine.U2D.SpriteAtlasManager`
- `UnityEngine.U2D.SpriteBone`
- `UnityEngine.UINumericFieldsUtils`
- `UnityEngine.UnhandledExceptionHandler`
- `UnityEngine.UnityException`
- `UnityEngine.UnityLogWriter`
- `UnityEngine.UnitySynchronizationContext`
- `UnityEngine.VRTextureUsage`
- `UnityEngine.Vector2`
- `UnityEngine.Vector2Int`
- `UnityEngine.Vector3`
- `UnityEngine.Vector3Int`
- `UnityEngine.Vector4`
- `UnityEngine.WaitForEndOfFrame`
- `UnityEngine.WaitForFixedUpdate`
- `UnityEngine.WaitForSeconds`
- `UnityEngine.WaitForSecondsRealtime`
- `UnityEngine.WeightedMode`
- `UnityEngine.WhitePoint`
- `UnityEngine.YieldInstruction`
- `UnityEngine._Scripting.APIUpdating.APIUpdaterRuntimeHelpers`
- `UnityEngineInternal.GenericStack`
- `UnityEngineInternal.MathfInternal`
- `UnityEngineInternal.TypeInferenceRuleAttribute`
- `UnityEngineInternal.TypeInferenceRules`
- `UnitySynchronizationContext.WorkRequest`
- `Update.DirectorUpdate`
- `Update.ScriptRunBehaviourUpdate`
- `Update.ScriptRunDelayedDynamicFrameRate`
- `Update.ScriptRunDelayedTasks`

</details>

<details><summary>Mismatching: 2</summary>

- `Awaitable.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__51_0', '<>9__76_1'] → ['<>9', '<>9__76_1']`
  - `missing field static Action<object> <>9__51_0`
  - `<>9__76_1: offset '0x10' → '0x8'`

- `UnityEngine.Application`

  - `field declaration order/names: ['lowMemory', 'memoryUsageChanged', 's_LogCallbackHandler', 's_LogCallbackHandlerThreaded', 'focusChanged', 'deepLinkActivated', 'wantsToQuit', 'quitting', 'unloading', 's_currentCancellationTokenSource', 's_RegisterLogCallbackDeprecated'] → ['lowMemory', 'memoryUsageChanged', 's_LogCallbackHandler', 's_LogCallbackHandlerThreaded', 'focusChanged', 'deepLinkActivated', 'wantsToQuit', 'quitting', 'unloading', 's_currentCancellationTokenSource']`
  - `missing field static Application.LogCallback s_RegisterLogCallbackDeprecated`


</details>

<details><summary>Indeterminate: 35</summary>

- `BurstLike.SharedStatic<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BurstRuntime.HashCode64<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `CollectionPool.<>c<TCollection, TItem>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `GenericPool.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IJobExtensions.JobStruct<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IJobForExtensions.ForJobStruct<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IJobParallelForExtensions.ParallelForJobStruct<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeArray.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeArray.ReadOnly.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeArray.ReadOnly<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativeSlice.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NoAllocHelpers.ListPrivateFieldAccess<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Collections.NativeSlice<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Bindings.ExceptionMarshaller`

  - Limitation: s_pendingException: no comparable storage offset

- `UnityEngine.CastHelper<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.CachedInvokableCall<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.InvokableCall<T1, T2, T3, T4>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.InvokableCall<T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.InvokableCall<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.InvokableCall<T1>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.UnityEvent<T0, T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.UnityEvent<T0, T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.UnityEvent<T0, T1>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Events.UnityEvent<T0>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.ExposedReference<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.LazyLoadReference<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Playables.ScriptPlayable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Pool.CollectionPool<TCollection, TItem>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Pool.GenericPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Pool.ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.Pool.PooledObject<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnsafeUtility.AlignOfHelper<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 91</summary>

- `AsyncOperation.BindingsMarshaller`
- `Awaitable.DoubleBufferedAwaitableList.<>c__DisplayClass4_0` (compiler-generated name)
- `Camera.GateFitMode`
- `Camera.GateFitParameters`
- `Camera.ProjectionMatrixMode`
- `Camera.RenderRequest`
- `Camera.RenderRequestMode`
- `Camera.RenderRequestOutputSpace`
- `JetBrains.Annotations.ImplicitUseKindFlags`
- `JetBrains.Annotations.ImplicitUseTargetFlags`
- `JetBrains.Annotations.UsedImplicitlyAttribute`
- `RayTracingAccelerationStructure.BindingsMarshaller`
- `RectTransform.Edge`
- `ReflectionProbe.<>c__DisplayClass95_0` (compiler-generated name)
- `ReflectionProbe.<>c__DisplayClass98_0` (compiler-generated name)
- `ResourceRequest.BindingsMarshaller`
- `UnityEditor.Experimental.RenderSettings`
- `UnityEngine.AsyncInstantiateOperation<T>`
- `UnityEngine.AsyncOperationAwaitableExtensions`
- `UnityEngine.AudioType`
- `UnityEngine.AwaitableCompletionSource`
- `UnityEngine.BlendShape`
- `UnityEngine.BlendShapeBufferRange`
- `UnityEngine.BoneWeight1`
- `UnityEngine.Caching`
- `UnityEngine.Device.Screen`
- `UnityEngine.Diagnostics.ForcedCrashCategory`
- `UnityEngine.Diagnostics.Utils`
- `UnityEngine.DisableBatchingType`
- `UnityEngine.EnabledOrientation`
- `UnityEngine.Experimental.Rendering.GraphicsStateCollection`
- `UnityEngine.Flare`
- `UnityEngine.FlareLayer`
- `UnityEngine.FullScreenMode`
- `UnityEngine.FullScreenMovieControlMode`
- `UnityEngine.FullScreenMovieScalingMode`
- `UnityEngine.Handheld`
- `UnityEngine.InstantiateParameters`
- `UnityEngine.Internal_DrawTextureArguments`
- `UnityEngine.LOD`
- `UnityEngine.LODGroup`
- `UnityEngine.LightProbeGroup`
- `UnityEngine.LightRenderMode`
- `UnityEngine.LightShadowCasterMode`
- `UnityEngine.LightmapData`
- `UnityEngine.LightmapsModeLegacy`
- `UnityEngine.LowLevel.PlayerLoop`
- `UnityEngine.MaterialGlobalIlluminationFlags`
- `UnityEngine.MaterialPropertyType`
- `UnityEngine.NPOTSupport`
- `UnityEngine.NetworkReachability`
- `UnityEngine.OcclusionArea`
- `UnityEngine.PlayerPrefs`
- `UnityEngine.PlayerPrefsException`
- `UnityEngine.PrimitiveType`
- `UnityEngine.Rendering.BlendShapeBufferLayout`
- `UnityEngine.Rendering.CameraEvent`
- `UnityEngine.Rendering.CameraEventUtils`
- `UnityEngine.Rendering.GlobalKeyword`
- `UnityEngine.Rendering.LightEvent`
- `UnityEngine.Rendering.LightUnit`
- `UnityEngine.Rendering.ObjectIdRequest`
- `UnityEngine.Rendering.RayTracingAccelerationStructure`
- `UnityEngine.Rendering.ReflectionProbeClearFlags`
- `UnityEngine.Rendering.ReflectionProbeMode`
- `UnityEngine.Rendering.ReflectionProbeTimeSlicingMode`
- `UnityEngine.Rendering.ReflectionProbeType`
- `UnityEngine.Rendering.ScopedRenderPass`
- `UnityEngine.Rendering.ShaderHardwareTier`
- `UnityEngine.Rendering.ShaderPropertyType`
- `UnityEngine.Rendering.ShadowMapPass`
- `UnityEngine.RenderingLayerMask`
- `UnityEngine.RenderingPath`
- `UnityEngine.RotationOrder`
- `UnityEngine.SceneManagement.CreateSceneParameters`
- `UnityEngine.SceneManagement.SceneManagerAPIInternal`
- `UnityEngine.SceneManagement.UnloadSceneOptions`
- `UnityEngine.Scripting.AlwaysLinkAssemblyAttribute`
- `UnityEngine.SkinQuality`
- `UnityEngine.SkinWeights`
- `UnityEngine.Space`
- `UnityEngine.SpriteDrawMode`
- `UnityEngine.SpriteMaskInteraction`
- `UnityEngine.SpriteSortPoint`
- `UnityEngine.SpriteTileMode`
- `UnityEngine.StackTraceLogType`
- `UnityEngine.SystemClock`
- `UnityEngine.TagHandle`
- `UnityEngine.WaitTimeoutMode`
- `UnityEngine.WaitWhile`
- `UnityEngine.WrapMode`

</details>

<details><summary>Extra: 17</summary>

- `CustomSampler.BindingsMarshaller`
- `JetBrains.Annotations.CollectionAccessAttribute`
- `JetBrains.Annotations.CollectionAccessType`
- `JetBrains.Annotations.MustUseReturnValueAttribute`
- `ProfilerRecorder.CountOptions`
- `SpookyHash.U`
- `Unity.Profiling.LowLevel.Unsafe.ProfilerMarkerData`
- `Unity.Profiling.ProfilerRecorderSample`
- `UnityEngine.HashUnsafeUtilities`
- `UnityEngine.HashUtilities`
- `UnityEngine.Rendering.ShaderKeywordSet`
- `UnityEngine.Scripting.RequireAttributeUsagesAttribute`
- `UnityEngine.SpookyHash`
- `UnityEngine.U2D.Light2DBase`
- `UnityEngine.U2D.SpriteChannelInfo`
- `UnityEngine.U2D.SpriteDataAccessExtensions`
- `UnsafeUtility.TypeFlagsCache<T>`

</details>


## UnityEngine.DirectorModule.dll

<details><summary>Matching: 9</summary>

- `<Module>`
- `PlayableSystems.DataPlayableOutputList`
- `PlayableSystems.DataPlayableOutputList.DataPlayableOutputEnumerator`
- `PlayableSystems.PlayableSystemDelegate`
- `PlayableSystems.PlayableSystemStage`
- `UnityEngine.Playables.DataPlayableOutput`
- `UnityEngine.Playables.IDataPlayer`
- `UnityEngine.Playables.PlayableDirector`
- `UnityEngine.Playables.PlayableSystems`

</details>


## UnityEngine.GridModule.dll

<details><summary>Matching: 2</summary>

- `<Module>`
- `UnityEngine.GridLayout`

</details>


## UnityEngine.HierarchyCoreModule.dll

<details><summary>Matching: 42</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `Hierarchy.BindingsMarshaller`
- `HierarchyCommandList.BindingsMarshaller`
- `HierarchyFlattened.BindingsMarshaller`
- `HierarchyFlattened.Enumerator`
- `HierarchyFlattenedNodeChildren.Enumerator`
- `HierarchyNodeChildren.Enumerator`
- `HierarchyNodeChildrenAlloc.<Reserved>e__FixedBuffer` (compiler-generated name)
- `HierarchyNodeTypeHandlerBase.BindingsMarshaller`
- `HierarchyNodeTypeHandlerBaseEnumerable.Enumerator`
- `HierarchySearchQueryDescriptor.<>c` (compiler-generated name)
- `HierarchyViewModel.BindingsMarshaller`
- `HierarchyViewModel.Enumerator`
- `HierarchyViewNodesEnumerable.Enumerator`
- `HierarchyViewNodesEnumerable.Predicate`
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `Unity.Hierarchy.DefaultHierarchySearchQueryParser`
- `Unity.Hierarchy.Hierarchy`
- `Unity.Hierarchy.HierarchyCommandList`
- `Unity.Hierarchy.HierarchyFlattened`
- `Unity.Hierarchy.HierarchyFlattenedNode`
- `Unity.Hierarchy.HierarchyFlattenedNodeChildren`
- `Unity.Hierarchy.HierarchyNode`
- `Unity.Hierarchy.HierarchyNodeChildren`
- `Unity.Hierarchy.HierarchyNodeChildrenAlloc`
- `Unity.Hierarchy.HierarchyNodeFlags`
- `Unity.Hierarchy.HierarchyNodeType`
- `Unity.Hierarchy.HierarchyNodeTypeHandlerBase`
- `Unity.Hierarchy.HierarchyNodeTypeHandlerBaseEnumerable`
- `Unity.Hierarchy.HierarchyPropertyDescriptor`
- `Unity.Hierarchy.HierarchyPropertyId`
- `Unity.Hierarchy.HierarchyPropertyStorageType`
- `Unity.Hierarchy.HierarchySearchFilter`
- `Unity.Hierarchy.HierarchySearchFilterOperator`
- `Unity.Hierarchy.HierarchySearchQueryDescriptor`
- `Unity.Hierarchy.HierarchyViewModel`
- `Unity.Hierarchy.HierarchyViewNodesEnumerable`
- `Unity.Hierarchy.IHierarchyProperty<T>`
- `Unity.Hierarchy.IHierarchySearchQueryParser`

</details>

<details><summary>Indeterminate: 2</summary>

- `HierarchyNodeTypeHandlerBase.ConstructorScope`

  - Limitation: m_Ptr: no comparable storage offset
  - Limitation: m_Hierarchy: no comparable storage offset
  - Limitation: m_CommandList: no comparable storage offset

- `Unity.Hierarchy.HierarchyPropertyUnmanaged<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>


## UnityEngine.IMGUIModule.dll

<details><summary>Matching: 46</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `Event.BindingsMarshaller`
- `GUI.WindowFunction`
- `GUIClip.ParentClipScope`
- `GUILayoutOption.Type`
- `GUILayoutUtility.LayoutCache`
- `GUISkin.SkinChangedDelegate`
- `GUIStyle.BindingsMarshaller`
- `GUIStyleState.BindingsMarshaller`
- `IMGUITextHandle.TextHandleTuple`
- `ObjectGUIState.BindingsMarshaller`
- `TextEditor.DblClickSnapping`
- `TextSelectingUtilities.CharacterType`
- `TextSelectingUtilities.Direction`
- `UnityEngine.Event`
- `UnityEngine.EventInterests`
- `UnityEngine.EventModifiers`
- `UnityEngine.EventType`
- `UnityEngine.ExitGUIException`
- `UnityEngine.FocusType`
- `UnityEngine.GUIClip`
- `UnityEngine.GUIContent`
- `UnityEngine.GUILayout`
- `UnityEngine.GUILayoutEntry`
- `UnityEngine.GUILayoutGroup`
- `UnityEngine.GUILayoutOption`
- `UnityEngine.GUIScrollGroup`
- `UnityEngine.GUISettings`
- `UnityEngine.GUISkin`
- `UnityEngine.GUIStyle`
- `UnityEngine.GUIStyleState`
- `UnityEngine.GUITargetAttribute`
- `UnityEngine.GUIUtility`
- `UnityEngine.IMGUITextHandle`
- `UnityEngine.ImagePosition`
- `UnityEngine.ObjectGUIState`
- `UnityEngine.PointerType`
- `UnityEngine.RuntimeTextSettings`
- `UnityEngine.ScaleMode`
- `UnityEngine.TextClipping`
- `UnityEngine.TextEditOp`
- `UnityEngine.TextEditingUtilities`
- `UnityEngine.TextEditor`
- `UnityEngine.TextSelectOp`
- `UnityEngine.TextSelectingUtilities`

</details>

<details><summary>Mismatching: 4</summary>

- `UnityEngine.GUI`

  - `field declaration order/names: ['s_ScrollControlId', 's_HotTextField', 's_BoxHash', 's_ButonHash', 's_RepeatButtonHash', 's_ToggleHash', 's_ButtonGridHash', 's_SliderHash', 's_BeginGroupHash', 's_ScrollviewHash', '<scrollTroughSide>k__BackingField', '<nextScrollStepTime>k__BackingField', 's_Skin', 's_ToolTipRect', '<scrollViewStates>k__BackingField'] → ['s_HotTextField', 's_BoxHash', 's_ButonHash', 's_RepeatButtonHash', 's_ToggleHash', 's_ButtonGridHash', 's_SliderHash', 's_BeginGroupHash', 's_ScrollviewHash', '<nextScrollStepTime>k__BackingField', 's_Skin', 's_ToolTipRect', '<scrollViewStates>k__BackingField']`
  - `missing field static int s_ScrollControlId`
  - `s_HotTextField: offset '0x4' → '0x0'`
  - `s_BoxHash: offset '0x8' → '0x4'`
  - `s_ButonHash: offset '0xc' → '0x8'`
  - `s_RepeatButtonHash: offset '0x10' → '0xc'`
  - `s_ToggleHash: offset '0x14' → '0x10'`
  - `s_ButtonGridHash: offset '0x18' → '0x14'`
  - `s_SliderHash: offset '0x1c' → '0x18'`
  - `s_BeginGroupHash: offset '0x20' → '0x1c'`
  - `s_ScrollviewHash: offset '0x24' → '0x20'`
  - `missing field static int <scrollTroughSide>k__BackingField`
  - `<nextScrollStepTime>k__BackingField: offset '0x30' → '0x28'`
  - `s_Skin: offset '0x38' → '0x30'`
  - `s_ToolTipRect: offset '0x40' → '0x38'`
  - `<scrollViewStates>k__BackingField: offset '0x50' → '0x48'`

- `UnityEngine.GUILayoutUtility`

  - `field declaration order/names: ['s_StoredLayouts', 's_StoredWindows', 'current', 'kDummyRect', '<unbalancedgroupscount>k__BackingField'] → ['s_StoredLayouts', 's_StoredWindows', 'current', 'kDummyRect']`
  - `missing field static int <unbalancedgroupscount>k__BackingField`

- `UnityEngine.ScrollViewState`

  - `field declaration order/names: ['position', 'visibleRect', 'viewRect', 'scrollPosition', 'apply', 'isDuringTouchScroll', 'touchScrollStartMousePosition', 'touchScrollStartPosition', 'velocity', 'previousTimeSinceStartup'] → []`
  - `missing field instance Rect position`
  - `missing field instance Rect visibleRect`
  - `missing field instance Rect viewRect`
  - `missing field instance Vector2 scrollPosition`
  - `missing field instance bool apply`
  - `missing field instance bool isDuringTouchScroll`
  - `missing field instance Vector2 touchScrollStartMousePosition`
  - `missing field instance Vector2 touchScrollStartPosition`
  - `missing field instance Vector2 velocity`
  - `missing field instance float previousTimeSinceStartup`

- `UnityEngine.SliderState`

  - `field declaration order/names: ['dragStartPos', 'dragStartValue', 'isDragging'] → []`
  - `missing field instance float dragStartPos`
  - `missing field instance float dragStartValue`
  - `missing field instance bool isDragging`


</details>

<details><summary>Missing: 3</summary>

- `UnityEngine.GUIStateObjects`
- `UnityEngine.GUIWordWrapSizer`
- `UnityEngine.SliderHandler`

</details>


## UnityEngine.InputForUIModule.dll

<details><summary>Matching: 48</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `CommandEvent.Command`
- `CommandEvent.Type`
- `Event.IMapFn<TOutputType>`
- `Event.MapAsEventModifiers`
- `Event.MapAsEventSource`
- `Event.MapAsObject`
- `Event.Type`
- `EventModifiers.Modifiers`
- `EventProvider.<>c` (compiler-generated name)
- `EventProvider.<>c__DisplayClass6_0` (compiler-generated name)
- `EventProvider.Registration`
- `EventSanitizer.IEventSanitizer`
- `InputManagerProvider.ButtonEventsIterator`
- `InputManagerProvider.Configuration`
- `InputManagerProvider.IInput`
- `InputManagerProvider.ITime`
- `InputManagerProvider.Input`
- `InputManagerProvider.Time`
- `KeyEvent.ButtonsState`
- `KeyEvent.ButtonsState.<GetAllPressed>d__8` (compiler-generated name)
- `KeyEvent.ButtonsState.<buttons>e__FixedBuffer` (compiler-generated name)
- `KeyEvent.Type`
- `NavigationEvent.Direction`
- `NavigationEvent.Type`
- `PointerEvent.Button`
- `PointerEvent.ButtonsState`
- `PointerEvent.Type`
- `UnityEngine.InputForUI.CommandEvent`
- `UnityEngine.InputForUI.Event`
- `UnityEngine.InputForUI.EventConsumer`
- `UnityEngine.InputForUI.EventModifiers`
- `UnityEngine.InputForUI.EventProvider`
- `UnityEngine.InputForUI.EventSanitizer`
- `UnityEngine.InputForUI.EventSource`
- `UnityEngine.InputForUI.IEventProperties`
- `UnityEngine.InputForUI.IEventProviderImpl`
- `UnityEngine.InputForUI.IMECompositionEvent`
- `UnityEngine.InputForUI.InputEventPartialProvider`
- `UnityEngine.InputForUI.InputManagerProvider`
- `UnityEngine.InputForUI.KeyEvent`
- `UnityEngine.InputForUI.NavigationEvent`
- `UnityEngine.InputForUI.NavigationEventRepeatHelper`
- `UnityEngine.InputForUI.PointerEvent`
- `UnityEngine.InputForUI.PointerState`
- `UnityEngine.InputForUI.TextInputEvent`

</details>


## UnityEngine.InputLegacyModule.dll

<details><summary>Matching: 13</summary>

- `<Module>`
- `SendMouseEvents.HitInfo`
- `UnityEngine.CameraRaycastHelper`
- `UnityEngine.DeviceOrientation`
- `UnityEngine.IMECompositionMode`
- `UnityEngine.Internal.InputUnsafeUtility`
- `UnityEngine.PenData`
- `UnityEngine.PenEventType`
- `UnityEngine.PenStatus`
- `UnityEngine.SendMouseEvents`
- `UnityEngine.Touch`
- `UnityEngine.TouchPhase`
- `UnityEngine.TouchType`

</details>

<details><summary>Mismatching: 1</summary>

- `UnityEngine.Input`

  - `field declaration order/names: ['<simulateTouchEnabled>k__BackingField', 's_MainGyro'] → ['<simulateTouchEnabled>k__BackingField']`
  - `missing field static Gyroscope s_MainGyro`


</details>

<details><summary>Missing: 1</summary>

- `UnityEngine.Gyroscope`

</details>


## UnityEngine.InputModule.dll

<details><summary>Matching: 5</summary>

- `<Module>`
- `UnityEngineInternal.Input.NativeInputEventBuffer`
- `UnityEngineInternal.Input.NativeInputSystem`
- `UnityEngineInternal.Input.NativeInputUpdateType`
- `UnityEngineInternal.Input.NativeUpdateCallback`

</details>


## UnityEngine.ParticleSystemModule.dll

<details><summary>Matching: 17</summary>

- `<Module>`
- `ParticleSystem.EmitParams`
- `ParticleSystem.MainModule`
- `ParticleSystem.MinMaxCurveBlittable`
- `ParticleSystem.MinMaxGradient`
- `ParticleSystem.MinMaxGradientBlittable`
- `ParticleSystem.Particle`
- `ParticleSystem.SubEmittersModule`
- `UnityEngine.ParticleSystem`
- `UnityEngine.ParticleSystemCurveMode`
- `UnityEngine.ParticleSystemGradientMode`
- `UnityEngine.ParticleSystemJobs.ParticleSystemJobData`
- `UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3`
- `UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4`
- `UnityEngine.ParticleSystemRenderer`
- `UnityEngine.ParticleSystemScalingMode`
- `UnityEngine.ParticleSystemStopBehavior`

</details>

<details><summary>Missing: 51</summary>

- `NativeParticleData.Array3`
- `NativeParticleData.Array4`
- `ParticleSystem.CollisionModule`
- `ParticleSystem.ColorBySpeedModule`
- `ParticleSystem.ColorOverLifetimeModule`
- `ParticleSystem.CustomDataModule`
- `ParticleSystem.EmissionModule`
- `ParticleSystem.ExternalForcesModule`
- `ParticleSystem.ForceOverLifetimeModule`
- `ParticleSystem.InheritVelocityModule`
- `ParticleSystem.LifetimeByEmitterSpeedModule`
- `ParticleSystem.LightsModule`
- `ParticleSystem.LimitVelocityOverLifetimeModule`
- `ParticleSystem.MinMaxCurve`
- `ParticleSystem.NoiseModule`
- `ParticleSystem.PlaybackState`
- `ParticleSystem.PlaybackState.Collision`
- `ParticleSystem.PlaybackState.Emission`
- `ParticleSystem.PlaybackState.Force`
- `ParticleSystem.PlaybackState.Initial`
- `ParticleSystem.PlaybackState.Lights`
- `ParticleSystem.PlaybackState.Noise`
- `ParticleSystem.PlaybackState.Seed`
- `ParticleSystem.PlaybackState.Seed4`
- `ParticleSystem.PlaybackState.Shape`
- `ParticleSystem.PlaybackState.Trail`
- `ParticleSystem.RotationBySpeedModule`
- `ParticleSystem.RotationOverLifetimeModule`
- `ParticleSystem.ShapeModule`
- `ParticleSystem.SizeBySpeedModule`
- `ParticleSystem.SizeOverLifetimeModule`
- `ParticleSystem.TextureSheetAnimationModule`
- `ParticleSystem.TrailModule`
- `ParticleSystem.Trails`
- `ParticleSystem.TriggerModule`
- `ParticleSystem.VelocityOverLifetimeModule`
- `ParticleSystemRenderer.BakeTextureOutput`
- `UnityEngine.ParticleSystemAnimationMode`
- `UnityEngine.ParticleSystemBakeMeshOptions`
- `UnityEngine.ParticleSystemBakeTextureOptions`
- `UnityEngine.ParticleSystemCustomData`
- `UnityEngine.ParticleSystemJobs.NativeParticleData`
- `UnityEngine.ParticleSystemMeshDistribution`
- `UnityEngine.ParticleSystemRenderMode`
- `UnityEngine.ParticleSystemRenderSpace`
- `UnityEngine.ParticleSystemShapeType`
- `UnityEngine.ParticleSystemSimulationSpace`
- `UnityEngine.ParticleSystemSortMode`
- `UnityEngine.ParticleSystemVertexStream`
- `UnityEngine.ParticleSystemVertexStreams`
- `UnityEngine.Rendering.UVChannelFlags`

</details>


## UnityEngine.Physics2DModule.dll

<details><summary>Matching: 12</summary>

- `<Module>`
- `UnityEngine.Collider2D`
- `UnityEngine.Collision2D`
- `UnityEngine.CompositeCollider2D`
- `UnityEngine.ContactFilter2D`
- `UnityEngine.ContactPoint2D`
- `UnityEngine.Joint2D`
- `UnityEngine.Physics2D`
- `UnityEngine.PhysicsScene2D`
- `UnityEngine.PolygonCollider2D`
- `UnityEngine.RaycastHit2D`
- `UnityEngine.Rigidbody2D`

</details>


## UnityEngine.PhysicsModule.dll

<details><summary>Matching: 24</summary>

- `<Module>`
- `Physics.ContactEventDelegate`
- `UnityEngine.BoxCollider`
- `UnityEngine.CapsuleCollider`
- `UnityEngine.CharacterController`
- `UnityEngine.Collider`
- `UnityEngine.Collision`
- `UnityEngine.CollisionPairEventFlags`
- `UnityEngine.CollisionPairFlags`
- `UnityEngine.CollisionPairHeaderFlags`
- `UnityEngine.ContactPair`
- `UnityEngine.ContactPairHeader`
- `UnityEngine.ContactPairPoint`
- `UnityEngine.ContactPoint`
- `UnityEngine.ControllerColliderHit`
- `UnityEngine.MeshCollider`
- `UnityEngine.ModifiableContactPair`
- `UnityEngine.Physics`
- `UnityEngine.PhysicsScene`
- `UnityEngine.QueryTriggerInteraction`
- `UnityEngine.RaycastHit`
- `UnityEngine.Rigidbody`
- `UnityEngine.SimulationMode`
- `UnityEngine.SphereCollider`

</details>

<details><summary>Missing: 8</summary>

- `UnityEngine.CollisionDetectionMode`
- `UnityEngine.CollisionFlags`
- `UnityEngine.ForceMode`
- `UnityEngine.MeshColliderCookingOptions`
- `UnityEngine.RigidbodyConstraints`
- `UnityEngine.RigidbodyInterpolation`
- `UnityEngine.SimulationOption`
- `UnityEngine.SimulationStage`

</details>


## UnityEngine.PropertiesModule.dll

<details><summary>Matching: 137</summary>

- `<Module>`
- `BoundsIntPropertyBag.PositionProperty`
- `BoundsIntPropertyBag.SizeProperty`
- `BoundsPropertyBag.CenterProperty`
- `BoundsPropertyBag.ExtentsProperty`
- `ColorPropertyBag.AProperty`
- `ColorPropertyBag.BProperty`
- `ColorPropertyBag.GProperty`
- `ColorPropertyBag.RProperty`
- `ConversionRegistry.ConverterKey`
- `ConversionRegistry.ConverterKeyComparer`
- `PathVisitor.PropertyScope`
- `PropertyContainer.GetPropertyVisitor`
- `PropertyContainer.GetPropertyVisitor.<>c` (compiler-generated name)
- `PropertyPath.<>c__DisplayClass36_0` (compiler-generated name)
- `RectIntPropertyBag.HeightProperty`
- `RectIntPropertyBag.WidthProperty`
- `RectIntPropertyBag.XProperty`
- `RectIntPropertyBag.YProperty`
- `RectPropertyBag.HeightProperty`
- `RectPropertyBag.WidthProperty`
- `RectPropertyBag.XProperty`
- `RectPropertyBag.YProperty`
- `ReflectedMemberProperty.GetClassValueAction<TContainer, TValue>`
- `ReflectedMemberProperty.GetStructValueAction<TContainer, TValue>`
- `ReflectedMemberProperty.SetClassValueAction<TContainer, TValue>`
- `ReflectedMemberProperty.SetStructValueAction<TContainer, TValue>`
- `ReflectedPropertyBagProvider.<>c` (compiler-generated name)
- `ReflectedPropertyBagProvider.<GetPropertyMembers>d__22` (compiler-generated name)
- `SystemVersionPropertyBag.BuildProperty`
- `SystemVersionPropertyBag.MajorProperty`
- `SystemVersionPropertyBag.MinorProperty`
- `SystemVersionPropertyBag.RevisionProperty`
- `TypeConversion.PrimitiveConverters`
- `TypeConversion.PrimitiveConverters.<>c` (compiler-generated name)
- `TypeUtility.<>c` (compiler-generated name)
- `TypeUtility.ITypeConstructor`
- `TypeUtility.ITypeConstructor<T>`
- `TypeUtility.NonConstructable`
- `TypeUtility.TypeConstructorVisitor`
- `Unity.Properties.ArrayPropertyBag<TElement>`
- `Unity.Properties.AttributesScope`
- `Unity.Properties.ConcreteTypeVisitor`
- `Unity.Properties.ConversionRegistry`
- `Unity.Properties.CreatePropertyAttribute`
- `Unity.Properties.DictionaryPropertyBag<TKey, TValue>`
- `Unity.Properties.DontCreatePropertyAttribute`
- `Unity.Properties.FieldMember`
- `Unity.Properties.GeneratePropertyBagsForTypesQualifiedWithAttribute`
- `Unity.Properties.HashSetPropertyBag<TElement>`
- `Unity.Properties.ICollectionPropertyBag<TCollection, TElement>`
- `Unity.Properties.ICollectionPropertyBagAccept<TContainer>`
- `Unity.Properties.ICollectionPropertyBagVisitor`
- `Unity.Properties.IConstructor`
- `Unity.Properties.IConstructor<T>`
- `Unity.Properties.IConstructorWithCount<T>`
- `Unity.Properties.IDictionaryElementProperty`
- `Unity.Properties.IDictionaryPropertyBag<TDictionary, TKey, TValue>`
- `Unity.Properties.IDictionaryPropertyBagAccept<TContainer>`
- `Unity.Properties.IDictionaryPropertyBagVisitor`
- `Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer>`
- `Unity.Properties.IIndexedProperties<TContainer>`
- `Unity.Properties.IKeyedProperties<TContainer, TKey>`
- `Unity.Properties.IListElementProperty`
- `Unity.Properties.IListPropertyAccept<TList>`
- `Unity.Properties.IListPropertyBag<TList, TElement>`
- `Unity.Properties.IListPropertyBagAccept<TContainer>`
- `Unity.Properties.IListPropertyBagVisitor`
- `Unity.Properties.IListPropertyVisitor`
- `Unity.Properties.IMemberInfo`
- `Unity.Properties.INamedProperties<TContainer>`
- `Unity.Properties.IProperty`
- `Unity.Properties.IProperty<TContainer>`
- `Unity.Properties.IPropertyAccept<TContainer>`
- `Unity.Properties.IPropertyBag`
- `Unity.Properties.IPropertyBag<TContainer>`
- `Unity.Properties.IPropertyBagVisitor`
- `Unity.Properties.IPropertyVisitor`
- `Unity.Properties.ISetElementProperty`
- `Unity.Properties.ISetPropertyBag<TSet, TElement>`
- `Unity.Properties.ISetPropertyBagAccept<TContainer>`
- `Unity.Properties.ISetPropertyBagVisitor`
- `Unity.Properties.ITypeVisitor`
- `Unity.Properties.IndexedCollectionSharedPropertyState`
- `Unity.Properties.InstantiationKind`
- `Unity.Properties.Internal.BoundsIntPropertyBag`
- `Unity.Properties.Internal.BoundsPropertyBag`
- `Unity.Properties.Internal.ColorPropertyBag`
- `Unity.Properties.Internal.IAttributes`
- `Unity.Properties.Internal.IPropertyBagRegister`
- `Unity.Properties.Internal.PropertiesInitialization`
- `Unity.Properties.Internal.PropertyBagStore`
- `Unity.Properties.Internal.RectIntPropertyBag`
- `Unity.Properties.Internal.RectPropertyBag`
- `Unity.Properties.Internal.ReflectedPropertyBag<TContainer>`
- `Unity.Properties.Internal.ReflectedPropertyBagAttribute`
- `Unity.Properties.Internal.ReflectedPropertyBagProvider`
- `Unity.Properties.Internal.ReflectionUtilities`
- `Unity.Properties.Internal.SystemVersionPropertyBag`
- `Unity.Properties.Internal.Vector2IntPropertyBag`
- `Unity.Properties.Internal.Vector2PropertyBag`
- `Unity.Properties.Internal.Vector3IntPropertyBag`
- `Unity.Properties.Internal.Vector3PropertyBag`
- `Unity.Properties.Internal.Vector4PropertyBag`
- `Unity.Properties.ListPropertyBag<TElement>`
- `Unity.Properties.MissingPropertyBagException`
- `Unity.Properties.PathVisitor`
- `Unity.Properties.PropertyBag`
- `Unity.Properties.PropertyContainer`
- `Unity.Properties.PropertyGetter<TContainer, TValue>`
- `Unity.Properties.PropertyMember`
- `Unity.Properties.PropertyPath`
- `Unity.Properties.PropertyPathPart`
- `Unity.Properties.PropertyPathPartKind`
- `Unity.Properties.PropertySetter<TContainer, TValue>`
- `Unity.Properties.TypeConversion`
- `Unity.Properties.TypeConverter<TSource, TDestination>`
- `Unity.Properties.TypeGenerationOptions`
- `Unity.Properties.TypeTraits`
- `Unity.Properties.TypeUtility`
- `Unity.Properties.VisitExceptionKind`
- `Unity.Properties.VisitParameters`
- `Unity.Properties.VisitReturnCode`
- `Vector2IntPropertyBag.XProperty`
- `Vector2IntPropertyBag.YProperty`
- `Vector2PropertyBag.XProperty`
- `Vector2PropertyBag.YProperty`
- `Vector3IntPropertyBag.XProperty`
- `Vector3IntPropertyBag.YProperty`
- `Vector3IntPropertyBag.ZProperty`
- `Vector3PropertyBag.XProperty`
- `Vector3PropertyBag.YProperty`
- `Vector3PropertyBag.ZProperty`
- `Vector4PropertyBag.WProperty`
- `Vector4PropertyBag.XProperty`
- `Vector4PropertyBag.YProperty`
- `Vector4PropertyBag.ZProperty`

</details>

<details><summary>Indeterminate: 28</summary>

- `IndexedCollectionPropertyBag.ListElementProperty<TList, TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `KeyValueCollectionPropertyBag.Enumerable.Enumerator<TDictionary, TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `KeyValueCollectionPropertyBag.Enumerable<TDictionary, TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `KeyValuePairPropertyBag.<>c<TKey, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `KeyValuePairPropertyBag.<GetPropertiesEnumerable>d__4<TKey, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PropertyBagStore.TypedStore<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PropertyCollection.Enumerator<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PropertyCollection.EnumeratorType<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PropertyContainer.GetValueVisitor.<>c<TSrcValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PropertyContainer.GetValueVisitor<TSrcValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SetPropertyBagBase.<GetPropertiesEnumerable>d__4<TSet, TElement>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SetPropertyBagBase.SetElementProperty<TSet, TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TypeUtility.Cache<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TypeUtility.TypeConstructor<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.ContainerPropertyBag<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.DelegateProperty<TContainer, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.IndexedCollectionPropertyBag<TList, TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.IndexedCollectionPropertyBagEnumerable<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.KeyValuePairPropertyBag<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.Property<TContainer, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.PropertyBag<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.PropertyCollection<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.ReflectedMemberProperty<TContainer, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.SetPropertyBagBase<TSet, TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Unity.Properties.TypeTraits<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>


## UnityEngine.SharedInternalsModule.dll

<details><summary>Matching: 29</summary>

- `<Module>`
- `UnityEngine.AssetFileNameExtensionAttribute`
- `UnityEngine.Bindings.CodegenOptions`
- `UnityEngine.Bindings.FreeFunctionAttribute`
- `UnityEngine.Bindings.IgnoreAttribute`
- `UnityEngine.Bindings.NativeAsStructAttribute`
- `UnityEngine.Bindings.NativeConditionalAttribute`
- `UnityEngine.Bindings.NativeHeaderAttribute`
- `UnityEngine.Bindings.NativeMethodAttribute`
- `UnityEngine.Bindings.NativeNameAttribute`
- `UnityEngine.Bindings.NativePropertyAttribute`
- `UnityEngine.Bindings.NativeThrowsAttribute`
- `UnityEngine.Bindings.NativeTypeAttribute`
- `UnityEngine.Bindings.NotNullAttribute`
- `UnityEngine.Bindings.PreventReadOnlyInstanceModificationAttribute`
- `UnityEngine.Bindings.StaticAccessorAttribute`
- `UnityEngine.Bindings.StaticAccessorType`
- `UnityEngine.Bindings.TargetType`
- `UnityEngine.Bindings.ThreadSafeAttribute`
- `UnityEngine.Bindings.UnmarshalledAttribute`
- `UnityEngine.Bindings.VisibleToOtherModulesAttribute`
- `UnityEngine.NativeClassAttribute`
- `UnityEngine.RejectDragAndDropMaterial`
- `UnityEngine.Scripting.RequiredByNativeCodeAttribute`
- `UnityEngine.Scripting.UsedByNativeCodeAttribute`
- `UnityEngine.ThreadAndSerializationSafeAttribute`
- `UnityEngine.UnityEngineModuleAssembly`
- `UnityEngine.UnityString`
- `UnityEngine.WritableAttribute`

</details>


## UnityEngine.SpriteShapeModule.dll

<details><summary>Matching: 2</summary>

- `<Module>`
- `UnityEngine.U2D.SpriteShapeRenderer`

</details>


## UnityEngine.SubsystemsModule.dll

<details><summary>Matching: 16</summary>

- `<Module>`
- `IntegratedSubsystem.BindingsMarshaller`
- `UnityEngine.ISubsystem`
- `UnityEngine.ISubsystemDescriptor`
- `UnityEngine.IntegratedSubsystem`
- `UnityEngine.IntegratedSubsystem<TSubsystemDescriptor>`
- `UnityEngine.IntegratedSubsystemDescriptor`
- `UnityEngine.IntegratedSubsystemDescriptor<TSubsystem>`
- `UnityEngine.Internal_SubsystemDescriptors`
- `UnityEngine.Subsystem`
- `UnityEngine.SubsystemDescriptor`
- `UnityEngine.SubsystemDescriptorBindings`
- `UnityEngine.SubsystemManager`
- `UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore`
- `UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider`
- `UnityEngine.SubsystemsImplementation.SubsystemWithProvider`

</details>


## UnityEngine.TerrainModule.dll

<details><summary>Extra: 14</summary>

- `<Module>`
- `TerrainCallbacks.HeightmapChangedCallback`
- `TerrainCallbacks.TextureChangedCallback`
- `TerrainData.BoundaryValueType`
- `TerrainMap.<>c__DisplayClass3_0` (compiler-generated name)
- `TerrainUtility.<>c__DisplayClass2_0` (compiler-generated name)
- `TerrainUtility.<>c__DisplayClass2_1` (compiler-generated name)
- `UnityEngine.Terrain`
- `UnityEngine.TerrainCallbacks`
- `UnityEngine.TerrainData`
- `UnityEngine.TerrainUtils.TerrainMap`
- `UnityEngine.TerrainUtils.TerrainMapStatusCode`
- `UnityEngine.TerrainUtils.TerrainTileCoord`
- `UnityEngine.TerrainUtils.TerrainUtility`

</details>


## UnityEngine.TextCoreFontEngineModule.dll

<details><summary>Matching: 25</summary>

- `<Module>`
- `UnityEngine.TextCore.FaceInfo`
- `UnityEngine.TextCore.Glyph`
- `UnityEngine.TextCore.GlyphClassDefinitionType`
- `UnityEngine.TextCore.GlyphMetrics`
- `UnityEngine.TextCore.GlyphRect`
- `UnityEngine.TextCore.LowLevel.FontEngine`
- `UnityEngine.TextCore.LowLevel.FontEngineError`
- `UnityEngine.TextCore.LowLevel.FontEngineUtilities`
- `UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags`
- `UnityEngine.TextCore.LowLevel.FontReference`
- `UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord`
- `UnityEngine.TextCore.LowLevel.GlyphAnchorPoint`
- `UnityEngine.TextCore.LowLevel.GlyphLoadFlags`
- `UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct`
- `UnityEngine.TextCore.LowLevel.GlyphPackingMode`
- `UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord`
- `UnityEngine.TextCore.LowLevel.GlyphRasterModes`
- `UnityEngine.TextCore.LowLevel.GlyphRenderMode`
- `UnityEngine.TextCore.LowLevel.GlyphValueRecord`
- `UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord`
- `UnityEngine.TextCore.LowLevel.MarkPositionAdjustment`
- `UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord`
- `UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord`
- `UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord`

</details>


## UnityEngine.TextCoreTextEngineModule.dll

<details><summary>Matching: 105</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4848`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5724`
- `FontAsset.<>c` (compiler-generated name)
- `FontFeatureTable.<>c` (compiler-generated name)
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `NativeTextGenerationSettings.<>c` (compiler-generated name)
- `RenderedText.Enumerator`
- `RichTextTagParser.ParseError`
- `RichTextTagParser.Segment`
- `RichTextTagParser.Tag`
- `RichTextTagParser.TagType`
- `RichTextTagParser.TagTypeInfo`
- `RichTextTagParser.TagUnitType`
- `RichTextTagParser.TagValue`
- `RichTextTagParser.TagValueType`
- `SpriteAsset.<>c` (compiler-generated name)
- `System.Runtime.CompilerServices.NullableAttribute` (compiler-generated name)
- `System.Runtime.CompilerServices.NullableContextAttribute` (compiler-generated name)
- `TextGenerator.MissingCharacterEventCallback`
- `TextGenerator.SpecialCharacter`
- `TextHandle.<>c` (compiler-generated name)
- `TextLib.BindingsMarshaller`
- `TextResourceManager.FontAssetRef`
- `TextSettings.<>c__DisplayClass96_0` (compiler-generated name)
- `TextSettings.FontReferenceMap`
- `UnityEngine.TextCore.HorizontalAlignment`
- `UnityEngine.TextCore.LanguageDirection`
- `UnityEngine.TextCore.NativeTextGenerationSettings`
- `UnityEngine.TextCore.RichTextTagParser`
- `UnityEngine.TextCore.Text.ATGMeshInfo`
- `UnityEngine.TextCore.Text.AtlasPopulationMode`
- `UnityEngine.TextCore.Text.Character`
- `UnityEngine.TextCore.Text.CharacterSubstitution`
- `UnityEngine.TextCore.Text.ColorGradientMode`
- `UnityEngine.TextCore.Text.ColorUtilities`
- `UnityEngine.TextCore.Text.Extents`
- `UnityEngine.TextCore.Text.FastAction`
- `UnityEngine.TextCore.Text.FontAsset`
- `UnityEngine.TextCore.Text.FontAssetCreationEditorSettings`
- `UnityEngine.TextCore.Text.FontAssetFactory`
- `UnityEngine.TextCore.Text.FontAssetUtilities`
- `UnityEngine.TextCore.Text.FontFeatureTable`
- `UnityEngine.TextCore.Text.FontStyleStack`
- `UnityEngine.TextCore.Text.FontStyles`
- `UnityEngine.TextCore.Text.FontWeightPair`
- `UnityEngine.TextCore.Text.HighlightState`
- `UnityEngine.TextCore.Text.LineInfo`
- `UnityEngine.TextCore.Text.LinkInfo`
- `UnityEngine.TextCore.Text.MarkupTag`
- `UnityEngine.TextCore.Text.MaterialManager`
- `UnityEngine.TextCore.Text.MaterialReference`
- `UnityEngine.TextCore.Text.MaterialReferenceManager`
- `UnityEngine.TextCore.Text.MeshInfo`
- `UnityEngine.TextCore.Text.MeshInfoBindings`
- `UnityEngine.TextCore.Text.NativeTextElementInfo`
- `UnityEngine.TextCore.Text.NativeTextInfo`
- `UnityEngine.TextCore.Text.OTL_FeatureTag`
- `UnityEngine.TextCore.Text.Offset`
- `UnityEngine.TextCore.Text.RenderedText`
- `UnityEngine.TextCore.Text.RichTextTagAttribute`
- `UnityEngine.TextCore.Text.SpriteAsset`
- `UnityEngine.TextCore.Text.SpriteCharacter`
- `UnityEngine.TextCore.Text.SpriteGlyph`
- `UnityEngine.TextCore.Text.TagUnitType`
- `UnityEngine.TextCore.Text.TagValueType`
- `UnityEngine.TextCore.Text.TextAlignment`
- `UnityEngine.TextCore.Text.TextAsset`
- `UnityEngine.TextCore.Text.TextBackingContainer`
- `UnityEngine.TextCore.Text.TextColorGradient`
- `UnityEngine.TextCore.Text.TextCoreVertex`
- `UnityEngine.TextCore.Text.TextElement`
- `UnityEngine.TextCore.Text.TextElementInfo`
- `UnityEngine.TextCore.Text.TextElementType`
- `UnityEngine.TextCore.Text.TextEventManager`
- `UnityEngine.TextCore.Text.TextFontWeight`
- `UnityEngine.TextCore.Text.TextGenerationInfo`
- `UnityEngine.TextCore.Text.TextGenerationSettings`
- `UnityEngine.TextCore.Text.TextGenerator`
- `UnityEngine.TextCore.Text.TextGeneratorUtilities`
- `UnityEngine.TextCore.Text.TextHandle`
- `UnityEngine.TextCore.Text.TextHandlePermanentCache`
- `UnityEngine.TextCore.Text.TextHandleTemporaryCache`
- `UnityEngine.TextCore.Text.TextInfo`
- `UnityEngine.TextCore.Text.TextLib`
- `UnityEngine.TextCore.Text.TextOverflowMode`
- `UnityEngine.TextCore.Text.TextProcessingElement`
- `UnityEngine.TextCore.Text.TextProcessingElementType`
- `UnityEngine.TextCore.Text.TextResourceManager`
- `UnityEngine.TextCore.Text.TextSelectionService`
- `UnityEngine.TextCore.Text.TextSettings`
- `UnityEngine.TextCore.Text.TextShaderUtilities`
- `UnityEngine.TextCore.Text.TextStyle`
- `UnityEngine.TextCore.Text.TextStyleSheet`
- `UnityEngine.TextCore.Text.TextUtilities`
- `UnityEngine.TextCore.Text.TextVertex`
- `UnityEngine.TextCore.Text.TextWrappingMode`
- `UnityEngine.TextCore.Text.UnicodeLineBreakingRules`
- `UnityEngine.TextCore.Text.WordInfo`
- `UnityEngine.TextCore.Text.WordWrapState`
- `UnityEngine.TextCore.TextOverflow`
- `UnityEngine.TextCore.TextSpan`
- `UnityEngine.TextCore.VerticalAlignment`
- `UnityEngine.TextCore.WhiteSpace`

</details>

<details><summary>Indeterminate: 4</summary>

- `UnityEngine.TextCore.Text.FastAction<A, B, C>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.TextCore.Text.FastAction<A, B>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.TextCore.Text.FastAction<A>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.TextCore.Text.TextProcessingStack<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>


## UnityEngine.TextRenderingModule.dll

<details><summary>Matching: 15</summary>

- `<Module>`
- `Font.FontTextureRebuildCallback`
- `TextGenerator.BindingsMarshaller`
- `UnityEngine.Font`
- `UnityEngine.FontStyle`
- `UnityEngine.HorizontalWrapMode`
- `UnityEngine.TextAnchor`
- `UnityEngine.TextGenerationError`
- `UnityEngine.TextGenerationSettings`
- `UnityEngine.TextGenerator`
- `UnityEngine.TextGeneratorType`
- `UnityEngine.UICharInfo`
- `UnityEngine.UILineInfo`
- `UnityEngine.UIVertex`
- `UnityEngine.VerticalWrapMode`

</details>

<details><summary>Missing: 1</summary>

- `UnityEngine.CharacterInfo`

</details>


## UnityEngine.TilemapModule.dll

<details><summary>Matching: 3</summary>

- `<Module>`
- `UnityEngine.Tilemaps.Tilemap`
- `UnityEngine.Tilemaps.TilemapRenderer`

</details>


## UnityEngine.UI.dll

<details><summary>Matching: 182</summary>

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

<details><summary>Missing: 1</summary>

- `LayoutGroup.<DelayedSetDirty>d__56` (compiler-generated name)

</details>

<details><summary>Extra: 21</summary>

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
- `LayoutGroup.<DelayedSetDirty>d__57` (compiler-generated name)
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


## UnityEngine.UIElementsModule.dll

<details><summary>Matching: 1440</summary>

- `<Module>`
- `<PrivateImplementationDetails>` (compiler-generated name)
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10`
- `ATGTextJobSystem.<>c` (compiler-generated name)
- `ATGTextJobSystem.GenerateTextJobData`
- `ATGTextJobSystem.ManagedJobData`
- `AbstractProgressBar.UxmlTraits`
- `Allocator2D.Alloc2D`
- `Allocator2D.Area`
- `Allocator2D.Row`
- `Angle.PropertyBag`
- `Angle.PropertyBag.UnitProperty`
- `Angle.PropertyBag.ValueProperty`
- `Angle.Unit`
- `AttachToPanelEvent.<>c` (compiler-generated name)
- `AutoCompletePathVisitor.VisitContext`
- `AutoCompletePathVisitor.VisitedPropertyScope`
- `Background.PropertyBag`
- `Background.PropertyBag.RenderTextureProperty`
- `Background.PropertyBag.SpriteProperty`
- `Background.PropertyBag.TextureProperty`
- `Background.PropertyBag.VectorImageProperty`
- `BackgroundPosition.PropertyBag`
- `BackgroundPosition.PropertyBag.KeywordProperty`
- `BackgroundPosition.PropertyBag.OffsetProperty`
- `BackgroundRepeat.PropertyBag`
- `BackgroundRepeat.PropertyBag.XProperty`
- `BackgroundRepeat.PropertyBag.YProperty`
- `BackgroundSize.PropertyBag`
- `BackgroundSize.PropertyBag.SizeTypeProperty`
- `BackgroundSize.PropertyBag.XProperty`
- `BackgroundSize.PropertyBag.YProperty`
- `BaseCompositeField.FieldDescription.WriteDelegate<TValueType, TField, TFieldValue>`
- `BaseListView.<>c__DisplayClass82_0` (compiler-generated name)
- `BaseListView.UxmlTraits`
- `BasePopupField.PopupTextElement<TValueType, TValueChoice>`
- `BaseRuntimePanel.<>c` (compiler-generated name)
- `BaseSlider.UxmlTraits<TValueType, TValueUxmlAttributeType>`
- `BaseStyleMatcher.MatchContext`
- `BaseTreeView.UxmlTraits`
- `BaseTreeViewController.<GetAllItemIds>d__23` (compiler-generated name)
- `BaseTreeViewController.<GetChildrenIds>d__25` (compiler-generated name)
- `BaseTreeViewController.<GetChildrenIdsByIndex>d__41` (compiler-generated name)
- `BaseVerticalCollectionView.<>c` (compiler-generated name)
- `BaseVerticalCollectionView.<>c__DisplayClass182_0` (compiler-generated name)
- `BaseVerticalCollectionView.<>c__DisplayClass193_0` (compiler-generated name)
- `BaseVerticalCollectionView.<>c__DisplayClass204_0` (compiler-generated name)
- `BaseVerticalCollectionView.<get_selectedItems>d__88` (compiler-generated name)
- `BaseVerticalCollectionView.Selection`
- `BaseVerticalCollectionView.UxmlTraits`
- `BaseVisualTreeHierarchyTrackerUpdater.State`
- `BestFitAllocator.Block`
- `BestFitAllocator.BlockPool`
- `BindableElement.UxmlFactory`
- `BindableElement.UxmlTraits`
- `BindingUpdater.CastDataSourceVisitor`
- `BindingUpdater.UIPathVisitor`
- `BitmapAllocator32.Page`
- `BlurEvent.<>c` (compiler-generated name)
- `BoundsField.UxmlFactory`
- `BoundsField.UxmlTraits`
- `BoundsIntField.UxmlFactory`
- `BoundsIntField.UxmlTraits`
- `Box.UxmlFactory`
- `Button.UxmlFactory`
- `Button.UxmlTraits`
- `ButtonStripField.UxmlFactory`
- `ButtonStripField.UxmlTraits`
- `ClickDetector.ButtonClickStatus`
- `ClickEvent.<>c` (compiler-generated name)
- `Column.UxmlObjectFactory`
- `Column.UxmlObjectFactory<T>`
- `ColumnLayout.<>c__DisplayClass54_0` (compiler-generated name)
- `ColumnLayout.<>c__DisplayClass55_0` (compiler-generated name)
- `Columns.<>c` (compiler-generated name)
- `Columns.StretchMode`
- `Columns.UxmlObjectFactory`
- `Columns.UxmlObjectFactory<T>`
- `ComputedTransitionUtils.<>c` (compiler-generated name)
- `ContextClickEvent.<>c` (compiler-generated name)
- `ContextualMenuPopulateEvent.<>c` (compiler-generated name)
- `ConverterGroups.<>c` (compiler-generated name)
- `CountingBloomFilter.<m_Counters>e__FixedBuffer` (compiler-generated name)
- `CreationContext.AttributeOverrideRange`
- `CreationContext.SerializedDataOverrideRange`
- `Cursor.PropertyBag`
- `Cursor.PropertyBag.DefaultCursorIdProperty`
- `Cursor.PropertyBag.HotspotProperty`
- `Cursor.PropertyBag.TextureProperty`
- `CustomStyleResolvedEvent.<>c` (compiler-generated name)
- `DataBindingManager.BindingData`
- `DataBindingManager.BindingDataCollection`
- `DataBindingManager.BindingRequest`
- `DataBindingManager.ChangesFromUI`
- `DataBindingManager.HierarchyBindingTracker`
- `DataBindingManager.HierarchyBindingTracker.HierarchicalBindingsSorter`
- `DataBindingManager.HierarchyDataSourceTracker`
- `DataBindingManager.HierarchyDataSourceTracker.InvalidateDataSourcesTraversal`
- `DataBindingManager.HierarchyDataSourceTracker.ObjectComparer`
- `DataBindingManager.HierarchyDataSourceTracker.SourceInfo`
- `DataBindingManager.IgnoreUIChangesData`
- `DataBindingManager.IgnoreUIChangesScope`
- `DataBindingUtility.<>c` (compiler-generated name)
- `DefaultEventSystem.<>c` (compiler-generated name)
- `DefaultEventSystem.FocusBasedEventSequenceContext`
- `DefaultEventSystem.InputForUIProcessor`
- `DefaultEventSystem.InputForUIProcessor.<>c` (compiler-generated name)
- `DefaultEventSystem.InputForUIProcessor.<>c__DisplayClass14_0` (compiler-generated name)
- `DefaultEventSystem.LegacyInputProcessor`
- `DefaultEventSystem.LegacyInputProcessor.<>c` (compiler-generated name)
- `DefaultEventSystem.LegacyInputProcessor.IInput`
- `DefaultEventSystem.LegacyInputProcessor.Input`
- `DefaultEventSystem.LegacyInputProcessor.NoInput`
- `DefaultEventSystem.UpdateMode`
- `DetachFromPanelEvent.<>c` (compiler-generated name)
- `Dimension.Unit`
- `DoubleField.DoubleInput`
- `DoubleField.UxmlFactory`
- `DoubleField.UxmlTraits`
- `DragEventsProcessor.DragState`
- `DropdownField.UxmlFactory`
- `DropdownField.UxmlTraits`
- `DropdownMenu.<>c__DisplayClass10_0` (compiler-generated name)
- `DropdownMenu.<>c__DisplayClass13_0` (compiler-generated name)
- `DropdownMenuAction.Status`
- `DynamicAtlas.TextureInfo`
- `EasingFunction.PropertyBag`
- `EasingFunction.PropertyBag.ModeProperty`
- `EntryPool.<>c` (compiler-generated name)
- `EntryPreProcessor.AllocSize`
- `EntryProcessor.MaskMesh`
- `EnumField.<>c` (compiler-generated name)
- `EnumField.UxmlFactory`
- `EnumField.UxmlTraits`
- `EventBase.EventPropagation`
- `EventBase.LifeCycleStatus`
- `EventCallbackRegistry.DynamicCallbackList`
- `EventDispatcher.<>c` (compiler-generated name)
- `EventDispatcher.DispatchContext`
- `EventDispatcher.EventRecord`
- `EventInterestReflectionUtils.DefaultEventInterests`
- `ExecuteCommandEvent.<>c` (compiler-generated name)
- `FloatField.FloatInput`
- `FloatField.UxmlFactory`
- `FloatField.UxmlTraits`
- `FocusController.FocusedElement`
- `FocusEvent.<>c` (compiler-generated name)
- `FocusInEvent.<>c` (compiler-generated name)
- `FocusOutEvent.<>c` (compiler-generated name)
- `Foldout.UxmlFactory`
- `Foldout.UxmlTraits`
- `FontDefinition.PropertyBag`
- `FontDefinition.PropertyBag.FontAssetProperty`
- `FontDefinition.PropertyBag.FontProperty`
- `GenericDropdownMenu.<>c__DisplayClass48_0` (compiler-generated name)
- `GenericDropdownMenu.MenuItem`
- `GeometryChangedEvent.<>c` (compiler-generated name)
- `GradientRemapPool.<>c` (compiler-generated name)
- `GradientSettingsAtlas.RawTexture`
- `GroupBox.UxmlFactory`
- `GroupBox.UxmlTraits`
- `Hash128Field.Hash128Input`
- `Hash128Field.UxmlFactory`
- `Hash128Field.UxmlTraits`
- `Hashes.<hashes>e__FixedBuffer` (compiler-generated name)
- `HelpBox.UxmlFactory`
- `HelpBox.UxmlTraits`
- `IMEEvent.<>c` (compiler-generated name)
- `IMGUIContainer.GUIGlobals`
- `IMGUIContainer.UxmlFactory`
- `IMGUIContainer.UxmlTraits`
- `IMGUIEvent.<>c` (compiler-generated name)
- `Image.UxmlFactory`
- `Image.UxmlTraits`
- `InlineStyleAccess.InlineRule`
- `InlineStyleAccessPropertyBag.AlignContentProperty`
- `InlineStyleAccessPropertyBag.AlignItemsProperty`
- `InlineStyleAccessPropertyBag.AlignSelfProperty`
- `InlineStyleAccessPropertyBag.BackgroundColorProperty`
- `InlineStyleAccessPropertyBag.BackgroundImageProperty`
- `InlineStyleAccessPropertyBag.BackgroundPositionXProperty`
- `InlineStyleAccessPropertyBag.BackgroundPositionYProperty`
- `InlineStyleAccessPropertyBag.BackgroundRepeatProperty`
- `InlineStyleAccessPropertyBag.BackgroundSizeProperty`
- `InlineStyleAccessPropertyBag.BorderBottomColorProperty`
- `InlineStyleAccessPropertyBag.BorderBottomLeftRadiusProperty`
- `InlineStyleAccessPropertyBag.BorderBottomRightRadiusProperty`
- `InlineStyleAccessPropertyBag.BorderBottomWidthProperty`
- `InlineStyleAccessPropertyBag.BorderLeftColorProperty`
- `InlineStyleAccessPropertyBag.BorderLeftWidthProperty`
- `InlineStyleAccessPropertyBag.BorderRightColorProperty`
- `InlineStyleAccessPropertyBag.BorderRightWidthProperty`
- `InlineStyleAccessPropertyBag.BorderTopColorProperty`
- `InlineStyleAccessPropertyBag.BorderTopLeftRadiusProperty`
- `InlineStyleAccessPropertyBag.BorderTopRightRadiusProperty`
- `InlineStyleAccessPropertyBag.BorderTopWidthProperty`
- `InlineStyleAccessPropertyBag.BottomProperty`
- `InlineStyleAccessPropertyBag.ColorProperty`
- `InlineStyleAccessPropertyBag.CursorProperty`
- `InlineStyleAccessPropertyBag.DisplayProperty`
- `InlineStyleAccessPropertyBag.FlexBasisProperty`
- `InlineStyleAccessPropertyBag.FlexDirectionProperty`
- `InlineStyleAccessPropertyBag.FlexGrowProperty`
- `InlineStyleAccessPropertyBag.FlexShrinkProperty`
- `InlineStyleAccessPropertyBag.FlexWrapProperty`
- `InlineStyleAccessPropertyBag.FontSizeProperty`
- `InlineStyleAccessPropertyBag.HeightProperty`
- `InlineStyleAccessPropertyBag.InlineStyleBackgroundPositionProperty`
- `InlineStyleAccessPropertyBag.InlineStyleBackgroundProperty`
- `InlineStyleAccessPropertyBag.InlineStyleBackgroundProperty.<>c` (compiler-generated name)
- `InlineStyleAccessPropertyBag.InlineStyleBackgroundRepeatProperty`
- `InlineStyleAccessPropertyBag.InlineStyleBackgroundSizeProperty`
- `InlineStyleAccessPropertyBag.InlineStyleColorProperty`
- `InlineStyleAccessPropertyBag.InlineStyleColorProperty.<>c` (compiler-generated name)
- `InlineStyleAccessPropertyBag.InlineStyleCursorProperty`
- `InlineStyleAccessPropertyBag.InlineStyleEnumProperty<TValue>`
- `InlineStyleAccessPropertyBag.InlineStyleFloatProperty`
- `InlineStyleAccessPropertyBag.InlineStyleFloatProperty.<>c` (compiler-generated name)
- `InlineStyleAccessPropertyBag.InlineStyleFontDefinitionProperty`
- `InlineStyleAccessPropertyBag.InlineStyleFontDefinitionProperty.<>c` (compiler-generated name)
- `InlineStyleAccessPropertyBag.InlineStyleFontProperty`
- `InlineStyleAccessPropertyBag.InlineStyleIntProperty`
- `InlineStyleAccessPropertyBag.InlineStyleLengthProperty`
- `InlineStyleAccessPropertyBag.InlineStyleLengthProperty.<>c` (compiler-generated name)
- `InlineStyleAccessPropertyBag.InlineStyleListProperty<T>`
- `InlineStyleAccessPropertyBag.InlineStyleProperty<TStyleValue, TValue>`
- `InlineStyleAccessPropertyBag.InlineStyleRotateProperty`
- `InlineStyleAccessPropertyBag.InlineStyleScaleProperty`
- `InlineStyleAccessPropertyBag.InlineStyleTextShadowProperty`
- `InlineStyleAccessPropertyBag.InlineStyleTransformOriginProperty`
- `InlineStyleAccessPropertyBag.InlineStyleTranslateProperty`
- `InlineStyleAccessPropertyBag.JustifyContentProperty`
- `InlineStyleAccessPropertyBag.LeftProperty`
- `InlineStyleAccessPropertyBag.LetterSpacingProperty`
- `InlineStyleAccessPropertyBag.MarginBottomProperty`
- `InlineStyleAccessPropertyBag.MarginLeftProperty`
- `InlineStyleAccessPropertyBag.MarginRightProperty`
- `InlineStyleAccessPropertyBag.MarginTopProperty`
- `InlineStyleAccessPropertyBag.MaxHeightProperty`
- `InlineStyleAccessPropertyBag.MaxWidthProperty`
- `InlineStyleAccessPropertyBag.MinHeightProperty`
- `InlineStyleAccessPropertyBag.MinWidthProperty`
- `InlineStyleAccessPropertyBag.OpacityProperty`
- `InlineStyleAccessPropertyBag.OverflowProperty`
- `InlineStyleAccessPropertyBag.PaddingBottomProperty`
- `InlineStyleAccessPropertyBag.PaddingLeftProperty`
- `InlineStyleAccessPropertyBag.PaddingRightProperty`
- `InlineStyleAccessPropertyBag.PaddingTopProperty`
- `InlineStyleAccessPropertyBag.PositionProperty`
- `InlineStyleAccessPropertyBag.RightProperty`
- `InlineStyleAccessPropertyBag.RotateProperty`
- `InlineStyleAccessPropertyBag.ScaleProperty`
- `InlineStyleAccessPropertyBag.TextOverflowProperty`
- `InlineStyleAccessPropertyBag.TextShadowProperty`
- `InlineStyleAccessPropertyBag.TopProperty`
- `InlineStyleAccessPropertyBag.TransformOriginProperty`
- `InlineStyleAccessPropertyBag.TransitionDelayProperty`
- `InlineStyleAccessPropertyBag.TransitionDurationProperty`
- `InlineStyleAccessPropertyBag.TransitionPropertyProperty`
- `InlineStyleAccessPropertyBag.TransitionTimingFunctionProperty`
- `InlineStyleAccessPropertyBag.TranslateProperty`
- `InlineStyleAccessPropertyBag.UnityBackgroundImageTintColorProperty`
- `InlineStyleAccessPropertyBag.UnityEditorTextRenderingModeProperty`
- `InlineStyleAccessPropertyBag.UnityFontDefinitionProperty`
- `InlineStyleAccessPropertyBag.UnityFontProperty`
- `InlineStyleAccessPropertyBag.UnityFontStyleAndWeightProperty`
- `InlineStyleAccessPropertyBag.UnityOverflowClipBoxProperty`
- `InlineStyleAccessPropertyBag.UnityParagraphSpacingProperty`
- `InlineStyleAccessPropertyBag.UnitySliceBottomProperty`
- `InlineStyleAccessPropertyBag.UnitySliceLeftProperty`
- `InlineStyleAccessPropertyBag.UnitySliceRightProperty`
- `InlineStyleAccessPropertyBag.UnitySliceScaleProperty`
- `InlineStyleAccessPropertyBag.UnitySliceTopProperty`
- `InlineStyleAccessPropertyBag.UnitySliceTypeProperty`
- `InlineStyleAccessPropertyBag.UnityTextAlignProperty`
- `InlineStyleAccessPropertyBag.UnityTextGeneratorProperty`
- `InlineStyleAccessPropertyBag.UnityTextOutlineColorProperty`
- `InlineStyleAccessPropertyBag.UnityTextOutlineWidthProperty`
- `InlineStyleAccessPropertyBag.UnityTextOverflowPositionProperty`
- `InlineStyleAccessPropertyBag.VisibilityProperty`
- `InlineStyleAccessPropertyBag.WhiteSpaceProperty`
- `InlineStyleAccessPropertyBag.WidthProperty`
- `InlineStyleAccessPropertyBag.WordSpacingProperty`
- `InputEvent.<>c` (compiler-generated name)
- `IntegerField.IntegerInput`
- `IntegerField.UxmlFactory`
- `IntegerField.UxmlTraits`
- `KeyDownEvent.<>c` (compiler-generated name)
- `KeyUpEvent.<>c` (compiler-generated name)
- `KeyboardNavigationManipulator.<>c__DisplayClass4_0` (compiler-generated name)
- `Label.UxmlFactory`
- `Label.UxmlTraits`
- `LayoutComputedData.<Border>e__FixedBuffer` (compiler-generated name)
- `LayoutComputedData.<Dimensions>e__FixedBuffer` (compiler-generated name)
- `LayoutComputedData.<Margin>e__FixedBuffer` (compiler-generated name)
- `LayoutComputedData.<MeasuredDimensions>e__FixedBuffer` (compiler-generated name)
- `LayoutComputedData.<Padding>e__FixedBuffer` (compiler-generated name)
- `LayoutComputedData.<Position>e__FixedBuffer` (compiler-generated name)
- `LayoutDataStore.Chunk`
- `LayoutDataStore.ComponentDataStore`
- `LayoutDataStore.Data`
- `LayoutManager.<>c` (compiler-generated name)
- `LayoutNative.LayoutLogData`
- `LayoutNative.LayoutLogEventType`
- `LayoutNodeData.FlexStatus`
- `Length.PropertyBag`
- `Length.PropertyBag.UnitProperty`
- `Length.PropertyBag.ValueProperty`
- `Length.Unit`
- `ListView.UxmlFactory`
- `ListView.UxmlTraits`
- `ListViewDragger.DragPosition`
- `LongField.LongInput`
- `LongField.UxmlFactory`
- `LongField.UxmlTraits`
- `MeshBuilderNative.NativeBorderParams`
- `MeshBuilderNative.NativeColorPage`
- `MeshBuilderNative.NativeRectParams`
- `MeshGenerationContext.MeshFlags`
- `MeshGenerationDeferrer.CallbackInfo`
- `MeshGenerator.BackgroundRepeatInstance`
- `MeshGenerator.BorderParams`
- `MeshGenerator.RectangleParams`
- `MeshGenerator.RepeatRectUV`
- `MeshGenerator.TessellationJob`
- `MeshGenerator.TessellationJobParameters`
- `MeshWriteDataPool.<>c` (compiler-generated name)
- `Microsoft.CodeAnalysis.EmbeddedAttribute` (compiler-generated name)
- `MinMaxSlider.DragState`
- `MinMaxSlider.UxmlFactory`
- `MinMaxSlider.UxmlTraits`
- `MouseCaptureEvent.<>c` (compiler-generated name)
- `MouseCaptureOutEvent.<>c` (compiler-generated name)
- `MouseDownEvent.<>c` (compiler-generated name)
- `MouseEnterEvent.<>c` (compiler-generated name)
- `MouseEnterWindowEvent.<>c` (compiler-generated name)
- `MouseLeaveEvent.<>c` (compiler-generated name)
- `MouseLeaveWindowEvent.<>c` (compiler-generated name)
- `MouseMoveEvent.<>c` (compiler-generated name)
- `MouseOutEvent.<>c` (compiler-generated name)
- `MouseOverEvent.<>c` (compiler-generated name)
- `MouseUpEvent.<>c` (compiler-generated name)
- `MultiColumnCollectionHeader.<>c__DisplayClass67_0` (compiler-generated name)
- `MultiColumnCollectionHeader.<>c__DisplayClass73_0` (compiler-generated name)
- `MultiColumnCollectionHeader.ColumnData`
- `MultiColumnCollectionHeader.SortedColumnState`
- `MultiColumnCollectionHeader.ViewState`
- `MultiColumnCollectionHeader.ViewState.ColumnState`
- `MultiColumnListView.UxmlFactory`
- `MultiColumnListView.UxmlTraits`
- `MultiColumnTreeView.UxmlFactory`
- `MultiColumnTreeView.UxmlTraits`
- `NavigateFocusRing.ChangeDirection`
- `NavigateFocusRing.FocusableHierarchyTraversal`
- `NavigationCancelEvent.<>c` (compiler-generated name)
- `NavigationMoveEvent.<>c` (compiler-generated name)
- `NavigationMoveEvent.Direction`
- `NavigationSubmitEvent.<>c` (compiler-generated name)
- `OpacityIdAccelerator.OpacityIdUpdateJob`
- `Painter2D.Painter2DJob`
- `Painter2D.Painter2DJobData`
- `PanelSettings.RuntimePanelAccess`
- `PointerCancelEvent.<>c` (compiler-generated name)
- `PointerCaptureEvent.<>c` (compiler-generated name)
- `PointerCaptureOutEvent.<>c` (compiler-generated name)
- `PointerDeviceState.LocationFlag`
- `PointerDeviceState.PointerLocation`
- `PointerDownEvent.<>c` (compiler-generated name)
- `PointerDownLinkTagEvent.<>c` (compiler-generated name)
- `PointerEnterEvent.<>c` (compiler-generated name)
- `PointerLeaveEvent.<>c` (compiler-generated name)
- `PointerMoveEvent.<>c` (compiler-generated name)
- `PointerMoveLinkTagEvent.<>c` (compiler-generated name)
- `PointerOutEvent.<>c` (compiler-generated name)
- `PointerOutLinkTagEvent.<>c` (compiler-generated name)
- `PointerOverEvent.<>c` (compiler-generated name)
- `PointerOverLinkTagEvent.<>c` (compiler-generated name)
- `PointerUpEvent.<>c` (compiler-generated name)
- `PointerUpLinkTagEvent.<>c` (compiler-generated name)
- `PopupWindow.UxmlFactory`
- `PopupWindow.UxmlTraits`
- `ProgressBar.UxmlFactory`
- `PropagationPaths.<>c` (compiler-generated name)
- `PropertyChangedEvent.<>c` (compiler-generated name)
- `RadioButton.UxmlFactory`
- `RadioButton.UxmlTraits`
- `RadioButtonGroup.<get_choices>d__17` (compiler-generated name)
- `RadioButtonGroup.UxmlFactory`
- `RadioButtonGroup.UxmlTraits`
- `ReadOnlyHierarchyViewModelList.Enumerator`
- `RectField.<>c` (compiler-generated name)
- `RectField.UxmlFactory`
- `RectField.UxmlTraits`
- `RectIntField.<>c` (compiler-generated name)
- `RectIntField.UxmlFactory`
- `RectIntField.UxmlTraits`
- `RenderChain.<>c` (compiler-generated name)
- `RenderChain.DepthOrderedDirtyTracking`
- `RenderChain.VisualChangesProcessor`
- `RenderChain.VisualChangesProcessor.EntryProcessingInfo`
- `RenderChain.VisualChangesProcessor.VisualsProcessingType`
- `RepeatButton.UxmlFactory`
- `RepeatButton.UxmlTraits`
- `ResolvedStyleAccessPropertyBag.AlignContentProperty`
- `ResolvedStyleAccessPropertyBag.AlignItemsProperty`
- `ResolvedStyleAccessPropertyBag.AlignSelfProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundColorProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundImageProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundPositionXProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundPositionYProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundRepeatProperty`
- `ResolvedStyleAccessPropertyBag.BackgroundSizeProperty`
- `ResolvedStyleAccessPropertyBag.BorderBottomColorProperty`
- `ResolvedStyleAccessPropertyBag.BorderBottomLeftRadiusProperty`
- `ResolvedStyleAccessPropertyBag.BorderBottomRightRadiusProperty`
- `ResolvedStyleAccessPropertyBag.BorderBottomWidthProperty`
- `ResolvedStyleAccessPropertyBag.BorderLeftColorProperty`
- `ResolvedStyleAccessPropertyBag.BorderLeftWidthProperty`
- `ResolvedStyleAccessPropertyBag.BorderRightColorProperty`
- `ResolvedStyleAccessPropertyBag.BorderRightWidthProperty`
- `ResolvedStyleAccessPropertyBag.BorderTopColorProperty`
- `ResolvedStyleAccessPropertyBag.BorderTopLeftRadiusProperty`
- `ResolvedStyleAccessPropertyBag.BorderTopRightRadiusProperty`
- `ResolvedStyleAccessPropertyBag.BorderTopWidthProperty`
- `ResolvedStyleAccessPropertyBag.BottomProperty`
- `ResolvedStyleAccessPropertyBag.ColorProperty`
- `ResolvedStyleAccessPropertyBag.DisplayProperty`
- `ResolvedStyleAccessPropertyBag.FlexBasisProperty`
- `ResolvedStyleAccessPropertyBag.FlexDirectionProperty`
- `ResolvedStyleAccessPropertyBag.FlexGrowProperty`
- `ResolvedStyleAccessPropertyBag.FlexShrinkProperty`
- `ResolvedStyleAccessPropertyBag.FlexWrapProperty`
- `ResolvedStyleAccessPropertyBag.FontSizeProperty`
- `ResolvedStyleAccessPropertyBag.HeightProperty`
- `ResolvedStyleAccessPropertyBag.JustifyContentProperty`
- `ResolvedStyleAccessPropertyBag.LeftProperty`
- `ResolvedStyleAccessPropertyBag.LetterSpacingProperty`
- `ResolvedStyleAccessPropertyBag.MarginBottomProperty`
- `ResolvedStyleAccessPropertyBag.MarginLeftProperty`
- `ResolvedStyleAccessPropertyBag.MarginRightProperty`
- `ResolvedStyleAccessPropertyBag.MarginTopProperty`
- `ResolvedStyleAccessPropertyBag.MaxHeightProperty`
- `ResolvedStyleAccessPropertyBag.MaxWidthProperty`
- `ResolvedStyleAccessPropertyBag.MinHeightProperty`
- `ResolvedStyleAccessPropertyBag.MinWidthProperty`
- `ResolvedStyleAccessPropertyBag.OpacityProperty`
- `ResolvedStyleAccessPropertyBag.PaddingBottomProperty`
- `ResolvedStyleAccessPropertyBag.PaddingLeftProperty`
- `ResolvedStyleAccessPropertyBag.PaddingRightProperty`
- `ResolvedStyleAccessPropertyBag.PaddingTopProperty`
- `ResolvedStyleAccessPropertyBag.PositionProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedBackgroundPositionProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedBackgroundProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedBackgroundRepeatProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedBackgroundSizeProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedColorProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedEnumProperty<TValue>`
- `ResolvedStyleAccessPropertyBag.ResolvedFloatProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedFontDefinitionProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedFontProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedIntProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedListProperty<T>`
- `ResolvedStyleAccessPropertyBag.ResolvedRotateProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedScaleProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedStyleFloatProperty`
- `ResolvedStyleAccessPropertyBag.ResolvedStyleProperty<TValue>`
- `ResolvedStyleAccessPropertyBag.ResolvedVector3Property`
- `ResolvedStyleAccessPropertyBag.RightProperty`
- `ResolvedStyleAccessPropertyBag.RotateProperty`
- `ResolvedStyleAccessPropertyBag.ScaleProperty`
- `ResolvedStyleAccessPropertyBag.TextOverflowProperty`
- `ResolvedStyleAccessPropertyBag.TopProperty`
- `ResolvedStyleAccessPropertyBag.TransformOriginProperty`
- `ResolvedStyleAccessPropertyBag.TransitionDelayProperty`
- `ResolvedStyleAccessPropertyBag.TransitionDurationProperty`
- `ResolvedStyleAccessPropertyBag.TransitionPropertyProperty`
- `ResolvedStyleAccessPropertyBag.TransitionTimingFunctionProperty`
- `ResolvedStyleAccessPropertyBag.TranslateProperty`
- `ResolvedStyleAccessPropertyBag.UnityBackgroundImageTintColorProperty`
- `ResolvedStyleAccessPropertyBag.UnityEditorTextRenderingModeProperty`
- `ResolvedStyleAccessPropertyBag.UnityFontDefinitionProperty`
- `ResolvedStyleAccessPropertyBag.UnityFontProperty`
- `ResolvedStyleAccessPropertyBag.UnityFontStyleAndWeightProperty`
- `ResolvedStyleAccessPropertyBag.UnityParagraphSpacingProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceBottomProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceLeftProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceRightProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceScaleProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceTopProperty`
- `ResolvedStyleAccessPropertyBag.UnitySliceTypeProperty`
- `ResolvedStyleAccessPropertyBag.UnityTextAlignProperty`
- `ResolvedStyleAccessPropertyBag.UnityTextGeneratorProperty`
- `ResolvedStyleAccessPropertyBag.UnityTextOutlineColorProperty`
- `ResolvedStyleAccessPropertyBag.UnityTextOutlineWidthProperty`
- `ResolvedStyleAccessPropertyBag.UnityTextOverflowPositionProperty`
- `ResolvedStyleAccessPropertyBag.VisibilityProperty`
- `ResolvedStyleAccessPropertyBag.WhiteSpaceProperty`
- `ResolvedStyleAccessPropertyBag.WidthProperty`
- `ResolvedStyleAccessPropertyBag.WordSpacingProperty`
- `Rotate.PropertyBag`
- `Rotate.PropertyBag.AngleProperty`
- `Rotate.PropertyBag.AxisProperty`
- `RuntimePanel.<>c` (compiler-generated name)
- `Scale.PropertyBag`
- `Scale.PropertyBag.ValueProperty`
- `ScheduledItem.<>c` (compiler-generated name)
- `ScrollView.<>c` (compiler-generated name)
- `ScrollView.NestedInteractionKind`
- `ScrollView.TouchScrollBehavior`
- `ScrollView.TouchScrollingResult`
- `ScrollView.UxmlFactory`
- `ScrollView.UxmlTraits`
- `Scroller.ScrollerSlider`
- `Scroller.UxmlFactory`
- `Scroller.UxmlTraits`
- `ShaderInfoStorageRGBAFloat.<>c` (compiler-generated name)
- `Slider.UxmlFactory`
- `Slider.UxmlTraits`
- `SliderInt.UxmlFactory`
- `SliderInt.UxmlTraits`
- `SortColumnDescription.UxmlObjectFactory`
- `SortColumnDescription.UxmlObjectFactory<T>`
- `SortColumnDescriptions.UxmlObjectFactory`
- `SortColumnDescriptions.UxmlObjectFactory<T>`
- `StyleComplexSelector.<>c` (compiler-generated name)
- `StyleComplexSelector.PseudoStateData`
- `StylePropertyAnimationSystem.ElementPropertyPair`
- `StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer`
- `StylePropertyAnimationSystem.TransitionState`
- `StylePropertyAnimationSystem.Values`
- `StylePropertyAnimationSystem.ValuesBackground`
- `StylePropertyAnimationSystem.ValuesBackgroundPosition`
- `StylePropertyAnimationSystem.ValuesBackgroundRepeat`
- `StylePropertyAnimationSystem.ValuesBackgroundSize`
- `StylePropertyAnimationSystem.ValuesColor`
- `StylePropertyAnimationSystem.ValuesEnum`
- `StylePropertyAnimationSystem.ValuesFloat`
- `StylePropertyAnimationSystem.ValuesFont`
- `StylePropertyAnimationSystem.ValuesFontDefinition`
- `StylePropertyAnimationSystem.ValuesInt`
- `StylePropertyAnimationSystem.ValuesLength`
- `StylePropertyAnimationSystem.ValuesRotate`
- `StylePropertyAnimationSystem.ValuesScale`
- `StylePropertyAnimationSystem.ValuesTextShadow`
- `StylePropertyAnimationSystem.ValuesTransformOrigin`
- `StylePropertyAnimationSystem.ValuesTranslate`
- `StylePropertyName.PropertyBag`
- `StylePropertyName.PropertyBag.IdProperty`
- `StylePropertyName.PropertyBag.NameProperty`
- `StylePropertyNameCollection.Enumerator`
- `StylePropertyReader.GetCursorIdFunction`
- `StyleSelector.<>c` (compiler-generated name)
- `StyleSelectorHelper.SelectorWorkItem`
- `StyleSheet.ImportStruct`
- `StyleSheet.OrderedSelectorType`
- `StyleSheetCache.SheetHandleKey`
- `StyleSheetCache.SheetHandleKeyComparer`
- `StyleVariableContext.<>c__DisplayClass7_0` (compiler-generated name)
- `StyleVariableResolver.ResolveContext`
- `StyleVariableResolver.Result`
- `System.Runtime.CompilerServices.IsUnmanagedAttribute` (compiler-generated name)
- `Tab.<>c` (compiler-generated name)
- `Tab.UxmlFactory`
- `Tab.UxmlTraits`
- `TabView.<>c__DisplayClass56_0` (compiler-generated name)
- `TabView.UxmlFactory`
- `TabView.UxmlTraits`
- `TabView.ViewState`
- `TempMeshAllocatorImpl.ThreadData`
- `TemplateAsset.AttributeOverride`
- `TemplateAsset.UxmlSerializedDataOverride`
- `TemplateContainer.UxmlFactory`
- `TemplateContainer.UxmlTraits`
- `TextElement.UxmlFactory`
- `TextElement.UxmlTraits`
- `TextField.TextInput`
- `TextField.UxmlFactory`
- `TextField.UxmlTraits`
- `TextShadow.PropertyBag`
- `TextShadow.PropertyBag.BlurRadiusProperty`
- `TextShadow.PropertyBag.ColorProperty`
- `TextShadow.PropertyBag.OffsetProperty`
- `TextureBlitter.BlitInfo`
- `TextureRegistry.TextureInfo`
- `TimeValue.PropertyBag`
- `TimeValue.PropertyBag.UnitProperty`
- `TimeValue.PropertyBag.ValueProperty`
- `Toggle.UxmlFactory`
- `Toggle.UxmlTraits`
- `ToggleButtonGroup.UxmlFactory`
- `ToggleButtonGroup.UxmlTraits`
- `TooltipEvent.<>c` (compiler-generated name)
- `TransformOrigin.PropertyBag`
- `TransformOrigin.PropertyBag.XProperty`
- `TransformOrigin.PropertyBag.YProperty`
- `TransformOrigin.PropertyBag.ZProperty`
- `TransitionCancelEvent.<>c` (compiler-generated name)
- `TransitionEndEvent.<>c` (compiler-generated name)
- `TransitionRunEvent.<>c` (compiler-generated name)
- `TransitionStartEvent.<>c` (compiler-generated name)
- `Translate.PropertyBag`
- `Translate.PropertyBag.XProperty`
- `Translate.PropertyBag.YProperty`
- `Translate.PropertyBag.ZProperty`
- `TreeView.UxmlFactory`
- `TreeView.UxmlTraits`
- `TreeViewReorderableDragAndDropController.DropData`
- `TwoPaneSplitView.UxmlFactory`
- `TwoPaneSplitView.UxmlTraits`
- `TypeConverterRegistry.ConverterKey`
- `TypeConverterRegistry.ConverterKeyComparer`
- `UIDocument.WorldSpaceSizeMode`
- `UIElementsRuntimeUtility.<>c` (compiler-generated name)
- `UIElementsRuntimeUtility.CreateRuntimePanelDelegate`
- `UIEventRegistration.<>c` (compiler-generated name)
- `UIRAtlasAllocator.AreaNode`
- `UIRAtlasAllocator.AreaNode.<>c` (compiler-generated name)
- `UIRAtlasAllocator.Row`
- `UIRAtlasAllocator.Row.<>c` (compiler-generated name)
- `UIRenderDevice.<>c` (compiler-generated name)
- `UIRenderDevice.AllocToFree`
- `UIRenderDevice.AllocToUpdate`
- `UIRenderDevice.DeviceToFree`
- `UIRenderDevice.DrawStatistics`
- `UIRenderDevice.EvaluationState`
- `UITKTextJobSystem.<>c` (compiler-generated name)
- `UITKTextJobSystem.GenerateTextJobData`
- `UITKTextJobSystem.ManagedJobData`
- `UITKTextJobSystem.PrepareTextJobData`
- `UQuery.FirstQueryMatcher`
- `UQuery.IVisualPredicateWrapper`
- `UQuery.SingleQueryMatcher`
- `UQuery.UQueryMatcher`
- `UQuery.UQueryMatcher.<>c` (compiler-generated name)
- `UnityEngine.UIElements.ATGTextEventHandler`
- `UnityEngine.UIElements.ATGTextJobSystem`
- `UnityEngine.UIElements.AbstractProgressBar`
- `UnityEngine.UIElements.AddressMode`
- `UnityEngine.UIElements.Align`
- `UnityEngine.UIElements.AlignmentUtils`
- `UnityEngine.UIElements.AlternatingRowBackground`
- `UnityEngine.UIElements.AncestorFilter`
- `UnityEngine.UIElements.Angle`
- `UnityEngine.UIElements.AngleUnit`
- `UnityEngine.UIElements.AtlasBase`
- `UnityEngine.UIElements.AttachToPanelEvent`
- `UnityEngine.UIElements.Axis`
- `UnityEngine.UIElements.Background`
- `UnityEngine.UIElements.BackgroundPosition`
- `UnityEngine.UIElements.BackgroundPositionKeyword`
- `UnityEngine.UIElements.BackgroundPropertyHelper`
- `UnityEngine.UIElements.BackgroundRepeat`
- `UnityEngine.UIElements.BackgroundSize`
- `UnityEngine.UIElements.BackgroundSizeType`
- `UnityEngine.UIElements.BaseBoolField`
- `UnityEngine.UIElements.BaseFieldMouseDragger`
- `UnityEngine.UIElements.BaseListView`
- `UnityEngine.UIElements.BaseListViewController`
- `UnityEngine.UIElements.BaseReorderableDragAndDropController`
- `UnityEngine.UIElements.BaseRuntimePanel`
- `UnityEngine.UIElements.BaseTreeView`
- `UnityEngine.UIElements.BaseTreeViewController`
- `UnityEngine.UIElements.BaseUxmlTraits`
- `UnityEngine.UIElements.BaseVerticalCollectionView`
- `UnityEngine.UIElements.BaseVisualElementPanel`
- `UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater`
- `UnityEngine.UIElements.BaseVisualTreeUpdater`
- `UnityEngine.UIElements.BindableElement`
- `UnityEngine.UIElements.BindablePropertyChangedEventArgs`
- `UnityEngine.UIElements.Binding`
- `UnityEngine.UIElements.BindingActivationContext`
- `UnityEngine.UIElements.BindingContext`
- `UnityEngine.UIElements.BindingId`
- `UnityEngine.UIElements.BindingInfo`
- `UnityEngine.UIElements.BindingLogLevel`
- `UnityEngine.UIElements.BindingMode`
- `UnityEngine.UIElements.BindingResult`
- `UnityEngine.UIElements.BindingSourceSelectionMode`
- `UnityEngine.UIElements.BindingStatus`
- `UnityEngine.UIElements.BindingTarget`
- `UnityEngine.UIElements.BindingUpdateStage`
- `UnityEngine.UIElements.BindingUpdateTrigger`
- `UnityEngine.UIElements.BindingUpdater`
- `UnityEngine.UIElements.BlurEvent`
- `UnityEngine.UIElements.BoundsField`
- `UnityEngine.UIElements.BoundsIntField`
- `UnityEngine.UIElements.Box`
- `UnityEngine.UIElements.Button`
- `UnityEngine.UIElements.ButtonStripField`
- `UnityEngine.UIElements.CallbackEventHandler`
- `UnityEngine.UIElements.CanStartDragArgs`
- `UnityEngine.UIElements.ClickDetector`
- `UnityEngine.UIElements.ClickEvent`
- `UnityEngine.UIElements.Clickable`
- `UnityEngine.UIElements.CollectionViewController`
- `UnityEngine.UIElements.CollectionVirtualizationController`
- `UnityEngine.UIElements.CollectionVirtualizationMethod`
- `UnityEngine.UIElements.ColorPage`
- `UnityEngine.UIElements.Column`
- `UnityEngine.UIElements.ColumnDataType`
- `UnityEngine.UIElements.ColumnLayout`
- `UnityEngine.UIElements.ColumnSortingMode`
- `UnityEngine.UIElements.Columns`
- `UnityEngine.UIElements.ColumnsDataType`
- `UnityEngine.UIElements.ComputedStyle`
- `UnityEngine.UIElements.ComputedTransitionProperty`
- `UnityEngine.UIElements.ComputedTransitionUtils`
- `UnityEngine.UIElements.ContextClickEvent`
- `UnityEngine.UIElements.ContextType`
- `UnityEngine.UIElements.ContextualMenuManager`
- `UnityEngine.UIElements.ContextualMenuManipulator`
- `UnityEngine.UIElements.ContextualMenuPopulateEvent`
- `UnityEngine.UIElements.ConverterGroup`
- `UnityEngine.UIElements.ConverterGroups`
- `UnityEngine.UIElements.CountingBloomFilter`
- `UnityEngine.UIElements.CreationContext`
- `UnityEngine.UIElements.Cursor`
- `UnityEngine.UIElements.CursorManager`
- `UnityEngine.UIElements.CustomBinding`
- `UnityEngine.UIElements.CustomStyleResolvedEvent`
- `UnityEngine.UIElements.DataBinding`
- `UnityEngine.UIElements.DataBindingManager`
- `UnityEngine.UIElements.DataBindingUtility`
- `UnityEngine.UIElements.DataSourceContext`
- `UnityEngine.UIElements.DataSourceContextChanged`
- `UnityEngine.UIElements.DefaultDragAndDropClient`
- `UnityEngine.UIElements.DefaultEventSystem`
- `UnityEngine.UIElements.DefaultGroupManager`
- `UnityEngine.UIElements.DeltaSpeed`
- `UnityEngine.UIElements.DetachFromPanelEvent`
- `UnityEngine.UIElements.DispatchMode`
- `UnityEngine.UIElements.DisplayStyle`
- `UnityEngine.UIElements.DisposeHelper`
- `UnityEngine.UIElements.DoubleField`
- `UnityEngine.UIElements.DragAndDropArgs`
- `UnityEngine.UIElements.DragAndDropData`
- `UnityEngine.UIElements.DragAndDropPosition`
- `UnityEngine.UIElements.DragAndDropUtility`
- `UnityEngine.UIElements.DragEventsProcessor`
- `UnityEngine.UIElements.DragVisualMode`
- `UnityEngine.UIElements.DropdownField`
- `UnityEngine.UIElements.DropdownMenu`
- `UnityEngine.UIElements.DropdownMenuAction`
- `UnityEngine.UIElements.DropdownMenuEventInfo`
- `UnityEngine.UIElements.DropdownMenuItem`
- `UnityEngine.UIElements.DropdownMenuSeparator`
- `UnityEngine.UIElements.DropdownUtility`
- `UnityEngine.UIElements.DynamicAtlas`
- `UnityEngine.UIElements.DynamicAtlasCustomFilter`
- `UnityEngine.UIElements.DynamicAtlasFilters`
- `UnityEngine.UIElements.DynamicAtlasPage`
- `UnityEngine.UIElements.DynamicAtlasSettings`
- `UnityEngine.UIElements.EasingFunction`
- `UnityEngine.UIElements.EasingMode`
- `UnityEngine.UIElements.EditorPanelRootElement`
- `UnityEngine.UIElements.EditorTextRenderingMode`
- `UnityEngine.UIElements.ElementUnderPointer`
- `UnityEngine.UIElements.EnumField`
- `UnityEngine.UIElements.EnumFieldHelpers`
- `UnityEngine.UIElements.EventBase`
- `UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs>`
- `UnityEngine.UIElements.EventCallback<TEventType>`
- `UnityEngine.UIElements.EventCallbackFunctorBase`
- `UnityEngine.UIElements.EventCallbackList`
- `UnityEngine.UIElements.EventCallbackListPool`
- `UnityEngine.UIElements.EventCallbackRegistry`
- `UnityEngine.UIElements.EventCategory`
- `UnityEngine.UIElements.EventCategoryAttribute`
- `UnityEngine.UIElements.EventCategoryFlags`
- `UnityEngine.UIElements.EventDispatchUtilities`
- `UnityEngine.UIElements.EventDispatcher`
- `UnityEngine.UIElements.EventDispatcherGate`
- `UnityEngine.UIElements.EventInterestAttribute`
- `UnityEngine.UIElements.EventInterestOptions`
- `UnityEngine.UIElements.EventInterestOptionsInternal`
- `UnityEngine.UIElements.EventInterestReflectionUtils`
- `UnityEngine.UIElements.ExecuteCommandEvent`
- `UnityEngine.UIElements.Experimental.Easing`
- `UnityEngine.UIElements.Experimental.EventDebuggerLogCall`
- `UnityEngine.UIElements.Experimental.EventDebuggerLogExecuteDefaultAction`
- `UnityEngine.UIElements.Experimental.EventDebuggerLogIMGUICall`
- `UnityEngine.UIElements.Experimental.ITransitionAnimations`
- `UnityEngine.UIElements.Experimental.IValueAnimationUpdate`
- `UnityEngine.UIElements.Experimental.Lerp`
- `UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent`
- `UnityEngine.UIElements.Experimental.PointerMoveLinkTagEvent`
- `UnityEngine.UIElements.Experimental.PointerOutLinkTagEvent`
- `UnityEngine.UIElements.Experimental.PointerOverLinkTagEvent`
- `UnityEngine.UIElements.Experimental.PointerUpLinkTagEvent`
- `UnityEngine.UIElements.Experimental.StyleValues`
- `UnityEngine.UIElements.FlexDirection`
- `UnityEngine.UIElements.FloatField`
- `UnityEngine.UIElements.FocusChangeDirection`
- `UnityEngine.UIElements.FocusController`
- `UnityEngine.UIElements.FocusEvent`
- `UnityEngine.UIElements.FocusInEvent`
- `UnityEngine.UIElements.FocusOutEvent`
- `UnityEngine.UIElements.Focusable`
- `UnityEngine.UIElements.Foldout`
- `UnityEngine.UIElements.FontDefinition`
- `UnityEngine.UIElements.GenericDropdownMenu`
- `UnityEngine.UIElements.GeometryChangedEvent`
- `UnityEngine.UIElements.GetViewDataDictionary`
- `UnityEngine.UIElements.GradientSettings`
- `UnityEngine.UIElements.GradientType`
- `UnityEngine.UIElements.GroupBox`
- `UnityEngine.UIElements.GroupBoxUtility`
- `UnityEngine.UIElements.HandleDragAndDropArgs`
- `UnityEngine.UIElements.Hash128Field`
- `UnityEngine.UIElements.Hashes`
- `UnityEngine.UIElements.HelpBox`
- `UnityEngine.UIElements.HelpBoxMessageType`
- `UnityEngine.UIElements.HierarchyChangeType`
- `UnityEngine.UIElements.HierarchyEvent`
- `UnityEngine.UIElements.IBaseUxmlFactory`
- `UnityEngine.UIElements.IBaseUxmlObjectFactory`
- `UnityEngine.UIElements.IBindable`
- `UnityEngine.UIElements.IBinding`
- `UnityEngine.UIElements.IBindingRequest`
- `UnityEngine.UIElements.ICollectionDragAndDropController`
- `UnityEngine.UIElements.ICursorManager`
- `UnityEngine.UIElements.ICustomStyle`
- `UnityEngine.UIElements.IDataSourceProvider`
- `UnityEngine.UIElements.IDataSourceViewHashProvider`
- `UnityEngine.UIElements.IDebugPanelChangeReceiver`
- `UnityEngine.UIElements.IDelayedField`
- `UnityEngine.UIElements.IDragAndDrop`
- `UnityEngine.UIElements.IDragAndDropController<TArgs>`
- `UnityEngine.UIElements.IEditableElement`
- `UnityEngine.UIElements.IEventHandler`
- `UnityEngine.UIElements.IExperimentalFeatures`
- `UnityEngine.UIElements.IFocusRing`
- `UnityEngine.UIElements.IGenericMenu`
- `UnityEngine.UIElements.IGroupBox`
- `UnityEngine.UIElements.IGroupBox<T>`
- `UnityEngine.UIElements.IGroupBoxOption`
- `UnityEngine.UIElements.IGroupManager`
- `UnityEngine.UIElements.IKeyboardEvent`
- `UnityEngine.UIElements.IListDragAndDropArgs`
- `UnityEngine.UIElements.IMEEvent`
- `UnityEngine.UIElements.IMGUIContainer`
- `UnityEngine.UIElements.IMGUIEvent`
- `UnityEngine.UIElements.IManipulator`
- `UnityEngine.UIElements.IMouseEvent`
- `UnityEngine.UIElements.IMouseEventInternal`
- `UnityEngine.UIElements.INavigationEvent`
- `UnityEngine.UIElements.INotifyBindablePropertyChanged`
- `UnityEngine.UIElements.INotifyValueChanged<T>`
- `UnityEngine.UIElements.INotifyValueChangedExtensions`
- `UnityEngine.UIElements.IPanel`
- `UnityEngine.UIElements.IPanelRenderer`
- `UnityEngine.UIElements.IPointerEvent`
- `UnityEngine.UIElements.IPointerEventInternal`
- `UnityEngine.UIElements.IPointerOrMouseEvent`
- `UnityEngine.UIElements.IReorderable`
- `UnityEngine.UIElements.IResolvedStyle`
- `UnityEngine.UIElements.IRuntimePanel`
- `UnityEngine.UIElements.IRuntimePanelComponent`
- `UnityEngine.UIElements.IScheduler`
- `UnityEngine.UIElements.ISerializableJsonDictionary`
- `UnityEngine.UIElements.IStyle`
- `UnityEngine.UIElements.IStyleDataGroup<T>`
- `UnityEngine.UIElements.IStylePropertyAnimationSystem`
- `UnityEngine.UIElements.IStylePropertyAnimations`
- `UnityEngine.UIElements.IStyleValue<T>`
- `UnityEngine.UIElements.ITextEdition`
- `UnityEngine.UIElements.ITextSelection`
- `UnityEngine.UIElements.ITransform`
- `UnityEngine.UIElements.IUIElementsUtility`
- `UnityEngine.UIElements.IUxmlAttributes`
- `UnityEngine.UIElements.IUxmlFactory`
- `UnityEngine.UIElements.IUxmlObjectFactory<T>`
- `UnityEngine.UIElements.IValueField<T>`
- `UnityEngine.UIElements.IVisualElementScheduledItem`
- `UnityEngine.UIElements.IVisualElementScheduler`
- `UnityEngine.UIElements.IVisualTreeUpdater`
- `UnityEngine.UIElements.Image`
- `UnityEngine.UIElements.ImmediateModeException`
- `UnityEngine.UIElements.InheritedData`
- `UnityEngine.UIElements.InlineStyleAccess`
- `UnityEngine.UIElements.InlineStyleAccessPropertyBag`
- `UnityEngine.UIElements.InputEvent`
- `UnityEngine.UIElements.IntegerField`
- `UnityEngine.UIElements.Internal.AutoCompletePathVisitor`
- `UnityEngine.UIElements.Internal.ColumnMover`
- `UnityEngine.UIElements.Internal.ColumnResizer`
- `UnityEngine.UIElements.Internal.MultiColumnCollectionHeader`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumn`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnIcon`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreview`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMovePreview`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizePreview`
- `UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicator`
- `UnityEngine.UIElements.Internal.TypePathVisitor`
- `UnityEngine.UIElements.InvokePolicy`
- `UnityEngine.UIElements.Justify`
- `UnityEngine.UIElements.KeyDownEvent`
- `UnityEngine.UIElements.KeyUpEvent`
- `UnityEngine.UIElements.KeyboardEventExtensions`
- `UnityEngine.UIElements.KeyboardNavigationManipulator`
- `UnityEngine.UIElements.KeyboardNavigationOperation`
- `UnityEngine.UIElements.KeyboardTextEditorEventHandler`
- `UnityEngine.UIElements.Label`
- `UnityEngine.UIElements.LanguageDirection`
- `UnityEngine.UIElements.LanguageDirectionExtensions`
- `UnityEngine.UIElements.Layout.ComponentType`
- `UnityEngine.UIElements.Layout.ILayoutProcessor`
- `UnityEngine.UIElements.Layout.InvokeBaselineFunctionDelegate`
- `UnityEngine.UIElements.Layout.InvokeMeasureFunctionDelegate`
- `UnityEngine.UIElements.Layout.LayoutAlign`
- `UnityEngine.UIElements.Layout.LayoutBaselineFunction`
- `UnityEngine.UIElements.Layout.LayoutCacheData`
- `UnityEngine.UIElements.Layout.LayoutCachedMeasurement`
- `UnityEngine.UIElements.Layout.LayoutComputedData`
- `UnityEngine.UIElements.Layout.LayoutConfig`
- `UnityEngine.UIElements.Layout.LayoutConfigData`
- `UnityEngine.UIElements.Layout.LayoutConfigDataType`
- `UnityEngine.UIElements.Layout.LayoutDataAccess`
- `UnityEngine.UIElements.Layout.LayoutDataStore`
- `UnityEngine.UIElements.Layout.LayoutDefaults`
- `UnityEngine.UIElements.Layout.LayoutDelegates`
- `UnityEngine.UIElements.Layout.LayoutDirection`
- `UnityEngine.UIElements.Layout.LayoutDisplay`
- `UnityEngine.UIElements.Layout.LayoutEdge`
- `UnityEngine.UIElements.Layout.LayoutFlexDirection`
- `UnityEngine.UIElements.Layout.LayoutHandle`
- `UnityEngine.UIElements.Layout.LayoutJustify`
- `UnityEngine.UIElements.Layout.LayoutManager`
- `UnityEngine.UIElements.Layout.LayoutMeasureFunction`
- `UnityEngine.UIElements.Layout.LayoutMeasureMode`
- `UnityEngine.UIElements.Layout.LayoutNative`
- `UnityEngine.UIElements.Layout.LayoutNode`
- `UnityEngine.UIElements.Layout.LayoutNodeData`
- `UnityEngine.UIElements.Layout.LayoutNodeDataType`
- `UnityEngine.UIElements.Layout.LayoutOverflow`
- `UnityEngine.UIElements.Layout.LayoutPositionType`
- `UnityEngine.UIElements.Layout.LayoutProcessor`
- `UnityEngine.UIElements.Layout.LayoutProcessorNative`
- `UnityEngine.UIElements.Layout.LayoutSize`
- `UnityEngine.UIElements.Layout.LayoutState`
- `UnityEngine.UIElements.Layout.LayoutStyleData`
- `UnityEngine.UIElements.Layout.LayoutUnit`
- `UnityEngine.UIElements.Layout.LayoutValue`
- `UnityEngine.UIElements.Layout.LayoutWrap`
- `UnityEngine.UIElements.LayoutData`
- `UnityEngine.UIElements.Length`
- `UnityEngine.UIElements.LengthUnit`
- `UnityEngine.UIElements.LibraryVisibility`
- `UnityEngine.UIElements.ListView`
- `UnityEngine.UIElements.ListViewController`
- `UnityEngine.UIElements.ListViewDragger`
- `UnityEngine.UIElements.ListViewDraggerAnimated`
- `UnityEngine.UIElements.ListViewDraggerExtension`
- `UnityEngine.UIElements.ListViewReorderMode`
- `UnityEngine.UIElements.ListViewReorderableDragAndDropController`
- `UnityEngine.UIElements.LoadResourceFunction`
- `UnityEngine.UIElements.LongField`
- `UnityEngine.UIElements.ManagedJobExtension`
- `UnityEngine.UIElements.Manipulator`
- `UnityEngine.UIElements.ManipulatorActivationFilter`
- `UnityEngine.UIElements.MeshBuilderNative`
- `UnityEngine.UIElements.MeshGenerationCallbackType`
- `UnityEngine.UIElements.MeshGenerationContext`
- `UnityEngine.UIElements.MeshGenerationNode`
- `UnityEngine.UIElements.MeshGenerationNodeImpl`
- `UnityEngine.UIElements.MeshGenerationNodeManager`
- `UnityEngine.UIElements.MeshWriteData`
- `UnityEngine.UIElements.MeshWriteDataInterface`
- `UnityEngine.UIElements.MinMaxSlider`
- `UnityEngine.UIElements.MouseButton`
- `UnityEngine.UIElements.MouseCaptureController`
- `UnityEngine.UIElements.MouseCaptureEvent`
- `UnityEngine.UIElements.MouseCaptureEventBase<T>`
- `UnityEngine.UIElements.MouseCaptureOutEvent`
- `UnityEngine.UIElements.MouseDownEvent`
- `UnityEngine.UIElements.MouseEnterEvent`
- `UnityEngine.UIElements.MouseEnterWindowEvent`
- `UnityEngine.UIElements.MouseEventsHelper`
- `UnityEngine.UIElements.MouseLeaveEvent`
- `UnityEngine.UIElements.MouseLeaveWindowEvent`
- `UnityEngine.UIElements.MouseManipulator`
- `UnityEngine.UIElements.MouseMoveEvent`
- `UnityEngine.UIElements.MouseOutEvent`
- `UnityEngine.UIElements.MouseOverEvent`
- `UnityEngine.UIElements.MouseUpEvent`
- `UnityEngine.UIElements.MultiColumnController`
- `UnityEngine.UIElements.MultiColumnListView`
- `UnityEngine.UIElements.MultiColumnListViewController`
- `UnityEngine.UIElements.MultiColumnTreeView`
- `UnityEngine.UIElements.MultiColumnTreeViewController`
- `UnityEngine.UIElements.NavigateFocusRing`
- `UnityEngine.UIElements.NavigationCancelEvent`
- `UnityEngine.UIElements.NavigationDeviceType`
- `UnityEngine.UIElements.NavigationMoveEvent`
- `UnityEngine.UIElements.NavigationSubmitEvent`
- `UnityEngine.UIElements.Overflow`
- `UnityEngine.UIElements.OverflowClipBox`
- `UnityEngine.UIElements.OverflowInternal`
- `UnityEngine.UIElements.Painter2D`
- `UnityEngine.UIElements.Panel`
- `UnityEngine.UIElements.PanelClearSettings`
- `UnityEngine.UIElements.PanelRenderMode`
- `UnityEngine.UIElements.PanelRootElement`
- `UnityEngine.UIElements.PanelScaleMode`
- `UnityEngine.UIElements.PanelScreenMatchMode`
- `UnityEngine.UIElements.PanelSettings`
- `UnityEngine.UIElements.PanelTextSettings`
- `UnityEngine.UIElements.PickingMode`
- `UnityEngine.UIElements.PointerCancelEvent`
- `UnityEngine.UIElements.PointerCaptureEvent`
- `UnityEngine.UIElements.PointerCaptureHelper`
- `UnityEngine.UIElements.PointerCaptureOutEvent`
- `UnityEngine.UIElements.PointerDeviceState`
- `UnityEngine.UIElements.PointerDispatchState`
- `UnityEngine.UIElements.PointerDownEvent`
- `UnityEngine.UIElements.PointerEnterEvent`
- `UnityEngine.UIElements.PointerEventHelper`
- `UnityEngine.UIElements.PointerEventsHelper`
- `UnityEngine.UIElements.PointerId`
- `UnityEngine.UIElements.PointerLeaveEvent`
- `UnityEngine.UIElements.PointerManipulator`
- `UnityEngine.UIElements.PointerMoveEvent`
- `UnityEngine.UIElements.PointerOutEvent`
- `UnityEngine.UIElements.PointerOverEvent`
- `UnityEngine.UIElements.PointerType`
- `UnityEngine.UIElements.PointerUpEvent`
- `UnityEngine.UIElements.PopupWindow`
- `UnityEngine.UIElements.Position`
- `UnityEngine.UIElements.ProgressBar`
- `UnityEngine.UIElements.ProjectionUtils`
- `UnityEngine.UIElements.PropagationPaths`
- `UnityEngine.UIElements.PropagationPhase`
- `UnityEngine.UIElements.PropertyChangedEvent`
- `UnityEngine.UIElements.PropertyPathInfo`
- `UnityEngine.UIElements.PseudoStates`
- `UnityEngine.UIElements.RadioButton`
- `UnityEngine.UIElements.RadioButtonGroup`
- `UnityEngine.UIElements.RareData`
- `UnityEngine.UIElements.ReadOnlyHierarchyViewModelList`
- `UnityEngine.UIElements.RectField`
- `UnityEngine.UIElements.RectIntField`
- `UnityEngine.UIElements.RenderHints`
- `UnityEngine.UIElements.RepaintData`
- `UnityEngine.UIElements.Repeat`
- `UnityEngine.UIElements.RepeatButton`
- `UnityEngine.UIElements.ResolvedStyleAccess`
- `UnityEngine.UIElements.ResolvedStyleAccessPropertyBag`
- `UnityEngine.UIElements.ReusableCollectionItem`
- `UnityEngine.UIElements.ReusableListViewItem`
- `UnityEngine.UIElements.ReusableMultiColumnListViewItem`
- `UnityEngine.UIElements.ReusableMultiColumnTreeViewItem`
- `UnityEngine.UIElements.ReusableTreeViewItem`
- `UnityEngine.UIElements.Rotate`
- `UnityEngine.UIElements.RuleMatcher`
- `UnityEngine.UIElements.RuntimeEventDispatcher`
- `UnityEngine.UIElements.RuntimePanel`
- `UnityEngine.UIElements.RuntimeUIElementsBridge`
- `UnityEngine.UIElements.SafeHandleAccess`
- `UnityEngine.UIElements.Salt`
- `UnityEngine.UIElements.SavePersistentViewData`
- `UnityEngine.UIElements.Scale`
- `UnityEngine.UIElements.ScheduledItem`
- `UnityEngine.UIElements.ScrollView`
- `UnityEngine.UIElements.ScrollViewMode`
- `UnityEngine.UIElements.Scroller`
- `UnityEngine.UIElements.ScrollerVisibility`
- `UnityEngine.UIElements.SelectionType`
- `UnityEngine.UIElements.SerializedVirtualizationData`
- `UnityEngine.UIElements.SetupDragAndDropArgs`
- `UnityEngine.UIElements.SliceType`
- `UnityEngine.UIElements.Slider`
- `UnityEngine.UIElements.SliderDirection`
- `UnityEngine.UIElements.SliderInt`
- `UnityEngine.UIElements.SortColumnDescription`
- `UnityEngine.UIElements.SortColumnDescriptions`
- `UnityEngine.UIElements.SortDirection`
- `UnityEngine.UIElements.Spacing`
- `UnityEngine.UIElements.StartDragArgs`
- `UnityEngine.UIElements.StyleBackground`
- `UnityEngine.UIElements.StyleBackgroundPosition`
- `UnityEngine.UIElements.StyleBackgroundRepeat`
- `UnityEngine.UIElements.StyleBackgroundSize`
- `UnityEngine.UIElements.StyleCache`
- `UnityEngine.UIElements.StyleColor`
- `UnityEngine.UIElements.StyleComplexSelector`
- `UnityEngine.UIElements.StyleCursor`
- `UnityEngine.UIElements.StyleFloat`
- `UnityEngine.UIElements.StyleFont`
- `UnityEngine.UIElements.StyleFontDefinition`
- `UnityEngine.UIElements.StyleInt`
- `UnityEngine.UIElements.StyleKeyword`
- `UnityEngine.UIElements.StyleLength`
- `UnityEngine.UIElements.StyleMatchingContext`
- `UnityEngine.UIElements.StyleProperty`
- `UnityEngine.UIElements.StylePropertyAnimationSystem`
- `UnityEngine.UIElements.StylePropertyName`
- `UnityEngine.UIElements.StylePropertyNameCollection`
- `UnityEngine.UIElements.StyleRotate`
- `UnityEngine.UIElements.StyleRule`
- `UnityEngine.UIElements.StyleScale`
- `UnityEngine.UIElements.StyleSelector`
- `UnityEngine.UIElements.StyleSelectorPart`
- `UnityEngine.UIElements.StyleSelectorRelationship`
- `UnityEngine.UIElements.StyleSelectorType`
- `UnityEngine.UIElements.StyleSheet`
- `UnityEngine.UIElements.StyleSheets.BaseStyleMatcher`
- `UnityEngine.UIElements.StyleSheets.Dimension`
- `UnityEngine.UIElements.StyleSheets.HierarchyTraversal`
- `UnityEngine.UIElements.StyleSheets.ImageSource`
- `UnityEngine.UIElements.StyleSheets.InitialStyle`
- `UnityEngine.UIElements.StyleSheets.MatchResult`
- `UnityEngine.UIElements.StyleSheets.MatchResultErrorCode`
- `UnityEngine.UIElements.StyleSheets.MatchResultInfo`
- `UnityEngine.UIElements.StyleSheets.ScalableImage`
- `UnityEngine.UIElements.StyleSheets.SelectorMatchRecord`
- `UnityEngine.UIElements.StyleSheets.ShorthandApplicator`
- `UnityEngine.UIElements.StyleSheets.StyleEnumType`
- `UnityEngine.UIElements.StyleSheets.StylePropertyCache`
- `UnityEngine.UIElements.StyleSheets.StylePropertyId`
- `UnityEngine.UIElements.StyleSheets.StylePropertyReader`
- `UnityEngine.UIElements.StyleSheets.StylePropertyUtil`
- `UnityEngine.UIElements.StyleSheets.StylePropertyValue`
- `UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher`
- `UnityEngine.UIElements.StyleSheets.StyleSelectorHelper`
- `UnityEngine.UIElements.StyleSheets.StyleSheetCache`
- `UnityEngine.UIElements.StyleSheets.StyleSheetColor`
- `UnityEngine.UIElements.StyleSheets.StyleSheetExtensions`
- `UnityEngine.UIElements.StyleSheets.StyleValue`
- `UnityEngine.UIElements.StyleSheets.StyleValueManaged`
- `UnityEngine.UIElements.StyleSheets.Syntax.DataType`
- `UnityEngine.UIElements.StyleSheets.Syntax.Expression`
- `UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator`
- `UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier`
- `UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType`
- `UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType`
- `UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser`
- `UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken`
- `UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType`
- `UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer`
- `UnityEngine.UIElements.StyleTextShadow`
- `UnityEngine.UIElements.StyleTransformOrigin`
- `UnityEngine.UIElements.StyleTranslate`
- `UnityEngine.UIElements.StyleValueCollection`
- `UnityEngine.UIElements.StyleValueExtensions`
- `UnityEngine.UIElements.StyleValueFunction`
- `UnityEngine.UIElements.StyleValueFunctionExtension`
- `UnityEngine.UIElements.StyleValueHandle`
- `UnityEngine.UIElements.StyleValueKeyword`
- `UnityEngine.UIElements.StyleValueKeywordExtension`
- `UnityEngine.UIElements.StyleValuePropertyBag<TContainer, TValue>`
- `UnityEngine.UIElements.StyleValueType`
- `UnityEngine.UIElements.StyleVariable`
- `UnityEngine.UIElements.StyleVariableContext`
- `UnityEngine.UIElements.StyleVariableResolver`
- `UnityEngine.UIElements.Tab`
- `UnityEngine.UIElements.TabDragLocationPreview`
- `UnityEngine.UIElements.TabDragPreview`
- `UnityEngine.UIElements.TabDragger`
- `UnityEngine.UIElements.TabLayout`
- `UnityEngine.UIElements.TabView`
- `UnityEngine.UIElements.TempMeshAllocator`
- `UnityEngine.UIElements.TemplateAsset`
- `UnityEngine.UIElements.TemplateContainer`
- `UnityEngine.UIElements.TextEditingManipulator`
- `UnityEngine.UIElements.TextEditorEventHandler`
- `UnityEngine.UIElements.TextElement`
- `UnityEngine.UIElements.TextEventHandler`
- `UnityEngine.UIElements.TextField`
- `UnityEngine.UIElements.TextJobSystem`
- `UnityEngine.UIElements.TextOverflow`
- `UnityEngine.UIElements.TextOverflowPosition`
- `UnityEngine.UIElements.TextSelectingManipulator`
- `UnityEngine.UIElements.TextShadow`
- `UnityEngine.UIElements.TextUtilities`
- `UnityEngine.UIElements.TextureId`
- `UnityEngine.UIElements.TextureRegistry`
- `UnityEngine.UIElements.ThemeStyleSheet`
- `UnityEngine.UIElements.TimeMsFunction`
- `UnityEngine.UIElements.TimeUnit`
- `UnityEngine.UIElements.TimeValue`
- `UnityEngine.UIElements.TimerEventScheduler`
- `UnityEngine.UIElements.TimerState`
- `UnityEngine.UIElements.Toggle`
- `UnityEngine.UIElements.ToggleButtonGroup`
- `UnityEngine.UIElements.ToggleButtonGroupState`
- `UnityEngine.UIElements.TooltipEvent`
- `UnityEngine.UIElements.TouchScreenTextEditorEventHandler`
- `UnityEngine.UIElements.TransformData`
- `UnityEngine.UIElements.TransformOrigin`
- `UnityEngine.UIElements.TransformOriginOffset`
- `UnityEngine.UIElements.TransitionCancelEvent`
- `UnityEngine.UIElements.TransitionData`
- `UnityEngine.UIElements.TransitionEndEvent`
- `UnityEngine.UIElements.TransitionRunEvent`
- `UnityEngine.UIElements.TransitionStartEvent`
- `UnityEngine.UIElements.Translate`
- `UnityEngine.UIElements.TreeView`
- `UnityEngine.UIElements.TreeViewController`
- `UnityEngine.UIElements.TreeViewExpansionChangedArgs`
- `UnityEngine.UIElements.TreeViewReorderableDragAndDropController`
- `UnityEngine.UIElements.TrickleDown`
- `UnityEngine.UIElements.TwoPaneSplitView`
- `UnityEngine.UIElements.TwoPaneSplitViewOrientation`
- `UnityEngine.UIElements.TwoPaneSplitViewResizer`
- `UnityEngine.UIElements.TypeConverterRegistry`
- `UnityEngine.UIElements.UIDocument`
- `UnityEngine.UIElements.UIDocumentList`
- `UnityEngine.UIElements.UIElementsBridge`
- `UnityEngine.UIElements.UIElementsInitialization`
- `UnityEngine.UIElements.UIElementsRuntimeUtility`
- `UnityEngine.UIElements.UIElementsRuntimeUtilityNative`
- `UnityEngine.UIElements.UIElementsUtility`
- `UnityEngine.UIElements.UIEventRegistration`
- `UnityEngine.UIElements.UIPainter2D`
- `UnityEngine.UIElements.UIR.Alloc`
- `UnityEngine.UIElements.UIR.Allocator2D`
- `UnityEngine.UIElements.UIR.BMPAlloc`
- `UnityEngine.UIElements.UIR.BaseElementBuilder`
- `UnityEngine.UIElements.UIR.BaseShaderInfoStorage`
- `UnityEngine.UIElements.UIR.BasicNodePool<T>`
- `UnityEngine.UIElements.UIR.BestFitAllocator`
- `UnityEngine.UIElements.UIR.BitmapAllocator32`
- `UnityEngine.UIElements.UIR.ChainBuilderStats`
- `UnityEngine.UIElements.UIR.ClipMethod`
- `UnityEngine.UIElements.UIR.CommandList`
- `UnityEngine.UIElements.UIR.CommandManipulator`
- `UnityEngine.UIElements.UIR.CommandType`
- `UnityEngine.UIElements.UIR.ConvertMeshJobData`
- `UnityEngine.UIElements.UIR.CopyMeshJobData`
- `UnityEngine.UIElements.UIR.DefaultElementBuilder`
- `UnityEngine.UIElements.UIR.DetachedAllocator`
- `UnityEngine.UIElements.UIR.DrawBufferRange`
- `UnityEngine.UIElements.UIR.DrawParams`
- `UnityEngine.UIElements.UIR.Entry`
- `UnityEngine.UIElements.UIR.EntryFlags`
- `UnityEngine.UIElements.UIR.EntryPool`
- `UnityEngine.UIElements.UIR.EntryPreProcessor`
- `UnityEngine.UIElements.UIR.EntryProcessor`
- `UnityEngine.UIElements.UIR.EntryRecorder`
- `UnityEngine.UIElements.UIR.EntryType`
- `UnityEngine.UIElements.UIR.ExtraRenderChainVEData`
- `UnityEngine.UIElements.UIR.GCHandlePool`
- `UnityEngine.UIElements.UIR.GPUBufferAllocator`
- `UnityEngine.UIElements.UIR.GfxUpdateBufferRange`
- `UnityEngine.UIElements.UIR.GradientRemap`
- `UnityEngine.UIElements.UIR.GradientRemapPool`
- `UnityEngine.UIElements.UIR.GradientSettingsAtlas`
- `UnityEngine.UIElements.UIR.IMeshGenerator`
- `UnityEngine.UIElements.UIR.JobManager`
- `UnityEngine.UIElements.UIR.JobMerger`
- `UnityEngine.UIElements.UIR.JobProcessor`
- `UnityEngine.UIElements.UIR.MeshGenerationCallback`
- `UnityEngine.UIElements.UIR.MeshGenerationDeferrer`
- `UnityEngine.UIElements.UIR.MeshGenerator`
- `UnityEngine.UIElements.UIR.MeshHandle`
- `UnityEngine.UIElements.UIR.MeshWriteDataPool`
- `UnityEngine.UIElements.UIR.NudgeJobData`
- `UnityEngine.UIElements.UIR.OpacityIdAccelerator`
- `UnityEngine.UIElements.UIR.OwnedState`
- `UnityEngine.UIElements.UIR.Page`
- `UnityEngine.UIElements.UIR.RenderChain`
- `UnityEngine.UIElements.UIR.RenderChainCommand`
- `UnityEngine.UIElements.UIR.RenderChainVEData`
- `UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses`
- `UnityEngine.UIElements.UIR.RenderDataDirtyTypes`
- `UnityEngine.UIElements.UIR.RenderDataFlags`
- `UnityEngine.UIElements.UIR.RenderEvents`
- `UnityEngine.UIElements.UIR.SerializedCommand`
- `UnityEngine.UIElements.UIR.SerializedCommandType`
- `UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat`
- `UnityEngine.UIElements.UIR.Shaders`
- `UnityEngine.UIElements.UIR.State`
- `UnityEngine.UIElements.UIR.TempMeshAllocatorImpl`
- `UnityEngine.UIElements.UIR.TextCoreSettings`
- `UnityEngine.UIElements.UIR.TextureBlitter`
- `UnityEngine.UIElements.UIR.TextureEntry`
- `UnityEngine.UIElements.UIR.TextureSlotManager`
- `UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator`
- `UnityEngine.UIElements.UIR.UIRenderDevice`
- `UnityEngine.UIElements.UIR.Utility`
- `UnityEngine.UIElements.UIR.VectorImageManager`
- `UnityEngine.UIElements.UIR.VectorImageRenderInfo`
- `UnityEngine.UIElements.UIR.VectorImageRenderInfoPool`
- `UnityEngine.UIElements.UIR.VertexFlags`
- `UnityEngine.UIElements.UIRAtlasAllocator`
- `UnityEngine.UIElements.UIRLayoutUpdater`
- `UnityEngine.UIElements.UIRRepaintUpdater`
- `UnityEngine.UIElements.UIRenderer`
- `UnityEngine.UIElements.UITKTextHandle`
- `UnityEngine.UIElements.UITKTextJobSystem`
- `UnityEngine.UIElements.UQuery`
- `UnityEngine.UIElements.UQueryExtensions`
- `UnityEngine.UIElements.UnsafeMeshGenerationNode`
- `UnityEngine.UIElements.UnsignedIntegerField`
- `UnityEngine.UIElements.UnsignedLongField`
- `UnityEngine.UIElements.UsageHints`
- `UnityEngine.UIElements.UxmlAsset`
- `UnityEngine.UIElements.UxmlAssetAttributeDescription<T>`
- `UnityEngine.UIElements.UxmlAttributeDescription`
- `UnityEngine.UIElements.UxmlAttributeOverridesFactory`
- `UnityEngine.UIElements.UxmlAttributeOverridesTraits`
- `UnityEngine.UIElements.UxmlBoolAttributeDescription`
- `UnityEngine.UIElements.UxmlDoubleAttributeDescription`
- `UnityEngine.UIElements.UxmlElementAttribute`
- `UnityEngine.UIElements.UxmlEnumAttributeDescription<T>`
- `UnityEngine.UIElements.UxmlEnumeration`
- `UnityEngine.UIElements.UxmlFactory<TCreatedType, TTraits>`
- `UnityEngine.UIElements.UxmlFactory<TCreatedType>`
- `UnityEngine.UIElements.UxmlFloatAttributeDescription`
- `UnityEngine.UIElements.UxmlHash128AttributeDescription`
- `UnityEngine.UIElements.UxmlIgnoreAttribute`
- `UnityEngine.UIElements.UxmlImageAttributeDescription`
- `UnityEngine.UIElements.UxmlIntAttributeDescription`
- `UnityEngine.UIElements.UxmlLongAttributeDescription`
- `UnityEngine.UIElements.UxmlNamespaceDefinition`
- `UnityEngine.UIElements.UxmlObjectAsset`
- `UnityEngine.UIElements.UxmlObjectAttribute`
- `UnityEngine.UIElements.UxmlObjectFactory<TCreatedType, TTraits>`
- `UnityEngine.UIElements.UxmlObjectFactoryRegistry`
- `UnityEngine.UIElements.UxmlObjectListAttributeDescription<T>`
- `UnityEngine.UIElements.UxmlObjectTraits<T>`
- `UnityEngine.UIElements.UxmlRootElementFactory`
- `UnityEngine.UIElements.UxmlRootElementTraits`
- `UnityEngine.UIElements.UxmlSerializedData`
- `UnityEngine.UIElements.UxmlStringAttributeDescription`
- `UnityEngine.UIElements.UxmlStyleFactory`
- `UnityEngine.UIElements.UxmlStyleTraits`
- `UnityEngine.UIElements.UxmlTemplateFactory`
- `UnityEngine.UIElements.UxmlTemplateTraits`
- `UnityEngine.UIElements.UxmlTraits`
- `UnityEngine.UIElements.UxmlTypeAttributeDescription<TBase>`
- `UnityEngine.UIElements.UxmlTypeRestriction`
- `UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription`
- `UnityEngine.UIElements.UxmlUnsignedLongAttributeDescription`
- `UnityEngine.UIElements.UxmlUtility`
- `UnityEngine.UIElements.ValidateCommandEvent`
- `UnityEngine.UIElements.Vector2Field`
- `UnityEngine.UIElements.Vector2IntField`
- `UnityEngine.UIElements.Vector3Field`
- `UnityEngine.UIElements.Vector3IntField`
- `UnityEngine.UIElements.Vector4Field`
- `UnityEngine.UIElements.VectorImage`
- `UnityEngine.UIElements.VectorImageVertex`
- `UnityEngine.UIElements.VersionChangeType`
- `UnityEngine.UIElements.Vertex`
- `UnityEngine.UIElements.Visibility`
- `UnityEngine.UIElements.VisualData`
- `UnityEngine.UIElements.VisualElement`
- `UnityEngine.UIElements.VisualElementAnimationSystem`
- `UnityEngine.UIElements.VisualElementAsset`
- `UnityEngine.UIElements.VisualElementExtensions`
- `UnityEngine.UIElements.VisualElementFactoryRegistry`
- `UnityEngine.UIElements.VisualElementFlags`
- `UnityEngine.UIElements.VisualElementFocusChangeDirection`
- `UnityEngine.UIElements.VisualElementFocusChangeTarget`
- `UnityEngine.UIElements.VisualElementFocusRing`
- `UnityEngine.UIElements.VisualElementListPool`
- `UnityEngine.UIElements.VisualElementStyleSheetSet`
- `UnityEngine.UIElements.VisualElementUtils`
- `UnityEngine.UIElements.VisualTreeAsset`
- `UnityEngine.UIElements.VisualTreeBindingsUpdater`
- `UnityEngine.UIElements.VisualTreeDataBindingsUpdater`
- `UnityEngine.UIElements.VisualTreeHierarchyFlagsUpdater`
- `UnityEngine.UIElements.VisualTreeStyleUpdater`
- `UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal`
- `UnityEngine.UIElements.VisualTreeUpdatePhase`
- `UnityEngine.UIElements.VisualTreeUpdater`
- `UnityEngine.UIElements.VisualTreeWorldSpaceHierarchyFlagsUpdater`
- `UnityEngine.UIElements.WheelEvent`
- `UnityEngine.UIElements.WhiteSpace`
- `UnityEngine.UIElements.WorldSpaceData`
- `UnityEngine.UIElements.WorldSpaceDataStore`
- `UnityEngine.UIElements.Wrap`
- `UnsignedIntegerField.UnsignedIntegerInput`
- `UnsignedIntegerField.UxmlFactory`
- `UnsignedIntegerField.UxmlTraits`
- `UnsignedLongField.UnsignedLongInput`
- `UnsignedLongField.UxmlFactory`
- `UnsignedLongField.UxmlTraits`
- `Utility.GPUBufferType`
- `UxmlAttributeDescription.Use`
- `UxmlBoolAttributeDescription.<>c` (compiler-generated name)
- `UxmlDoubleAttributeDescription.<>c` (compiler-generated name)
- `UxmlFloatAttributeDescription.<>c` (compiler-generated name)
- `UxmlHash128AttributeDescription.<>c` (compiler-generated name)
- `UxmlIntAttributeDescription.<>c` (compiler-generated name)
- `UxmlLongAttributeDescription.<>c` (compiler-generated name)
- `UxmlSerializedData.UxmlAttributeFlags`
- `UxmlStringAttributeDescription.<>c` (compiler-generated name)
- `UxmlUnsignedIntAttributeDescription.<>c` (compiler-generated name)
- `UxmlUnsignedLongAttributeDescription.<>c` (compiler-generated name)
- `ValidateCommandEvent.<>c` (compiler-generated name)
- `Vector2Field.<>c` (compiler-generated name)
- `Vector2Field.UxmlFactory`
- `Vector2Field.UxmlTraits`
- `Vector2IntField.<>c` (compiler-generated name)
- `Vector2IntField.UxmlFactory`
- `Vector2IntField.UxmlTraits`
- `Vector3Field.<>c` (compiler-generated name)
- `Vector3Field.UxmlFactory`
- `Vector3Field.UxmlTraits`
- `Vector3IntField.<>c` (compiler-generated name)
- `Vector3IntField.UxmlFactory`
- `Vector3IntField.UxmlTraits`
- `Vector4Field.<>c` (compiler-generated name)
- `Vector4Field.UxmlFactory`
- `Vector4Field.UxmlTraits`
- `VectorImageRenderInfoPool.<>c` (compiler-generated name)
- `VisualElement.<>c__DisplayClass524_0` (compiler-generated name)
- `VisualElement.BaseVisualElementScheduledItem`
- `VisualElement.CustomStyleAccess`
- `VisualElement.Hierarchy`
- `VisualElement.MeasureMode`
- `VisualElement.RenderTargetMode`
- `VisualElement.SimpleScheduledItem`
- `VisualElement.TimerStateScheduledItem`
- `VisualElement.TypeData`
- `VisualElement.UxmlFactory`
- `VisualElement.UxmlTraits`
- `VisualElementFocusChangeTarget.<>c` (compiler-generated name)
- `VisualElementFocusRing.DefaultFocusOrder`
- `VisualElementFocusRing.FocusRingRecord`
- `VisualElementListPool.<>c` (compiler-generated name)
- `VisualElementUtils.<>c` (compiler-generated name)
- `VisualTreeAsset.<>c__DisplayClass76_0` (compiler-generated name)
- `VisualTreeAsset.<>c__DisplayClass82_0` (compiler-generated name)
- `VisualTreeAsset.<get_stylesheets>d__31` (compiler-generated name)
- `VisualTreeAsset.<get_templateDependencies>d__27` (compiler-generated name)
- `VisualTreeAsset.AssetEntry`
- `VisualTreeAsset.SlotDefinition`
- `VisualTreeAsset.SlotUsageEntry`
- `VisualTreeAsset.UsingEntry`
- `VisualTreeAsset.UsingEntryComparer`
- `VisualTreeAsset.UxmlObjectEntry`
- `VisualTreeDataBindingsUpdater.<>c` (compiler-generated name)
- `VisualTreeDataBindingsUpdater.VersionInfo`
- `VisualTreeStyleUpdaterTraversal.<>c` (compiler-generated name)
- `VisualTreeUpdater.UpdaterArray`
- `WheelEvent.<>c` (compiler-generated name)

</details>

<details><summary>Indeterminate: 109</summary>

- `AutoCompletePathVisitor.InspectedTypeScope<TContainer>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseCompositeField.<>c__DisplayClass18_0<TValueType, TField, TFieldValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseCompositeField.FieldDescription<TValueType, TField, TFieldValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseField.UxmlTraits<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BasePopupField.<>c<TValueType, TValueChoice>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `BaseSlider.SliderKey<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ChangeEvent.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ClampedDragger.DragDirection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Column.UxmlObjectTraits.<>c__DisplayClass14_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Column.UxmlObjectTraits.<>c__DisplayClass14_1<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Column.UxmlObjectTraits<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Columns.UxmlObjectTraits<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicHeightVirtualizationController.<>c__DisplayClass67_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicHeightVirtualizationController.ScrollDirection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `DynamicHeightVirtualizationController.VirtualizationChange<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `EventBase.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `InlineStyleAccessPropertyBag.InlineStyleProperty.<>c<TStyleValue, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LayoutList.Data<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `NativePagedList.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObjectListPool.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ObjectPool.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Page.DataSet<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `PopupField.<>c__DisplayClass27_0<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SetValueVisitor.<>c<TSrcValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortColumnDescription.UxmlObjectTraits<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `SortColumnDescriptions.UxmlObjectTraits<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StyleDataRef.RefCounted<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values.EmptyData<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values.StyleData<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values.TimingData<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.Values<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StylePropertyAnimationSystem.ValuesDiscrete<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StyleValuePropertyBag.KeywordProperty<TContainer, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `StyleValuePropertyBag.ValueProperty<TContainer, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TempAllocator.Page<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TextInputBaseField.TextInputBase<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TextInputBaseField.UxmlTraits<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TextValueField.TextValueInput<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UQuery.IsOfType<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UQueryState.ActionQueryMatcher<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UQueryState.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UQueryState.ListQueryMatcher<T, TElement>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BaseCompositeField<TValueType, TField, TFieldValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BaseField<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BaseFieldTraits<TValueType, TValueUxmlAttributeType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BasePopupField<TValueType, TValueChoice>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BaseSlider<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.BaseUxmlFactory<TCreatedType, TTraits>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.ChangeEvent<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.ClampedDragger<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.CommandEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.CustomStyleProperty<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.DefaultMultiColumnTreeViewController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.DefaultTreeViewController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.DynamicHeightVirtualizationController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.EventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.EventCallbackFunctor<TEventType, TCallbackArgs>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.EventCallbackFunctor<TEventType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Experimental.ValueAnimation<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.FieldMouseDragger<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.FixedHeightVirtualizationController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.FocusEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.KeyboardEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Layout.FixedBuffer16<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Layout.FixedBuffer2<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Layout.FixedBuffer9<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Layout.LayoutList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.Layout.ManagedObjectStore<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.MouseEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.NavigationEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.ObjectListPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.ObjectPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.PanelChangedEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.PointerCaptureEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.PointerEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.PopupField<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.SetValueVisitor<TSrcValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.StyleDataRef<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.StyleEnum<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.StyleList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TextInputBaseField<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TextValueField<TValueType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TextValueFieldTraits<TValueType, TValueUxmlAttributeType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TransitionEventBase<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TreeDataController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TreeViewItemData<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.TypedUxmlAttributeDescription<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.BasicNode<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.ImplicitPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.LinkedPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.LinkedPoolItem<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.NativeList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.NativePagedList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.ShaderInfoStorage<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIR.TempAllocator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UIRUtility`

  - Limitation: s_ThreadIndex: no comparable storage offset

- `UnityEngine.UIElements.UQueryBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UQueryState<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.UxmlObjectAttributeDescription<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UnityEngine.UIElements.VerticalVirtualizationController<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Utility.GPUBuffer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `UxmlEnumAttributeDescription.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ValueAnimation.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VerticalVirtualizationController.<>c<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `VisualElement.VisualElementScheduledItem<ActionType>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>


## UnityEngine.UIModule.dll

<details><summary>Matching: 11</summary>

- `<Module>`
- `Canvas.WillRenderCanvases`
- `UISystemProfilerApi.SampleType`
- `UnityEngine.AdditionalCanvasShaderChannels`
- `UnityEngine.Canvas`
- `UnityEngine.CanvasGroup`
- `UnityEngine.CanvasRenderer`
- `UnityEngine.ICanvasRaycastFilter`
- `UnityEngine.RectTransformUtility`
- `UnityEngine.RenderMode`
- `UnityEngine.UISystemProfilerApi`

</details>

<details><summary>Missing: 1</summary>

- `UnityEngine.StandaloneRenderResize`

</details>


## UnityEngine.UnityAnalyticsCommonModule.dll

<details><summary>Matching: 35</summary>

- `<Module>`
- `UnityEditor.Analytics.AssetDatabaseRefreshAnalytic`
- `UnityEditor.Analytics.AssetExportAnalytic`
- `UnityEditor.Analytics.AssetImportAnalytic`
- `UnityEditor.Analytics.AssetImportStatusAnalytic`
- `UnityEditor.Analytics.BuildAssetBundleAnalytic`
- `UnityEditor.Analytics.CollabOperationAnalytic`
- `UnityEditor.Analytics.LicensingErrorAnalytic`
- `UnityEditor.Analytics.LicensingInitAnalytic`
- `UnityEditor.Analytics.MetalPatchShaderComputeBufferAnalytic`
- `UnityEditor.Analytics.NavmeshBakingAnalytic`
- `UnityEditor.Analytics.PackageManagerAddPackageAnalytic`
- `UnityEditor.Analytics.PackageManagerBaseAnalytic`
- `UnityEditor.Analytics.PackageManagerEmbedPackageAnalytic`
- `UnityEditor.Analytics.PackageManagerRemovePackageAnalytic`
- `UnityEditor.Analytics.PackageManagerResetPackageAnalytic`
- `UnityEditor.Analytics.PackageManagerResolveErrorPackageAnalytic`
- `UnityEditor.Analytics.PackageManagerResolvePackageAnalytic`
- `UnityEditor.Analytics.PackageManagerStartServerPackageAnalytic`
- `UnityEditor.Analytics.PackageManagerTestAnalytic`
- `UnityEditor.Analytics.ProjectSettingsInformationAnalytic`
- `UnityEditor.Analytics.SendGameBuildAnalytic`
- `UnityEditor.Analytics.StallMarkerAnalytic`
- `UnityEditor.Analytics.StallSummaryAnalytic`
- `UnityEditor.Analytics.TestAnalytic`
- `UnityEditor.Analytics.VCProviderAnalytics`
- `UnityEngine.Analytics.SubsystemsAnalyticBase`
- `UnityEngine.Analytics.SubsystemsAnalyticInfo`
- `UnityEngine.Analytics.SubsystemsAnalyticStart`
- `UnityEngine.Analytics.SubsystemsAnalyticStop`
- `UnityEngine.Analytics.VRDeviceActiveControllersAnalytic`
- `UnityEngine.Analytics.VRDeviceAnalyticAspect`
- `UnityEngine.Analytics.VRDeviceAnalyticBase`
- `UnityEngine.Analytics.VRDeviceMirrorAnalytic`
- `UnityEngine.Analytics.VRDeviceUserAnalytic`

</details>


## UnityEngine.UnityWebRequestAssetBundleModule.dll

<details><summary>Matching: 2</summary>

- `<Module>`
- `UnityEngine.Networking.DownloadHandlerAssetBundle`

</details>

<details><summary>Missing: 2</summary>

- `DownloadHandlerAssetBundle.BindingsMarshaller`
- `UnityEngine.Networking.UnityWebRequestAssetBundle`

</details>


## UnityEngine.UnityWebRequestModule.dll

<details><summary>Matching: 14</summary>

- `<Module>`
- `CertificateHandler.BindingsMarshaller`
- `DownloadHandler.BindingsMarshaller`
- `UnityEngine.Networking.CertificateHandler`
- `UnityEngine.Networking.DownloadHandler`
- `UnityEngine.Networking.DownloadHandlerBuffer`
- `UnityEngine.Networking.DownloadHandlerScript`
- `UnityEngine.Networking.UnityWebRequest`
- `UnityEngine.Networking.UnityWebRequestAsyncOperation`
- `UnityEngine.Networking.UploadHandler`
- `UnityEngineInternal.WebRequestUtils`
- `UnityWebRequest.BindingsMarshaller`
- `UnityWebRequest.Result`
- `UploadHandler.BindingsMarshaller`

</details>

<details><summary>Missing: 9</summary>

- `DownloadHandlerFile.BindingsMarshaller`
- `UnityEngine.Networking.DownloadHandlerFile`
- `UnityEngine.Networking.UploadHandlerFile`
- `UnityEngine.Networking.UploadHandlerRaw`
- `UnityEngine.WWWForm`
- `UnityEngine.WWWTranscoder`
- `UnityWebRequest.UnityWebRequestError`
- `UnityWebRequest.UnityWebRequestMethod`
- `UnityWebRequestAsyncOperation.BindingsMarshaller`

</details>


## UnityEngine.VFXModule.dll

<details><summary>Matching: 14</summary>

- `<Module>`
- `UnityEngine.VFX.VFXBatchInfo`
- `UnityEngine.VFX.VFXBatchedEffectInfo`
- `UnityEngine.VFX.VFXCameraXRSettings`
- `UnityEngine.VFX.VFXEventAttribute`
- `UnityEngine.VFX.VFXExpressionValues`
- `UnityEngine.VFX.VFXManager`
- `UnityEngine.VFX.VFXOutputEventArgs`
- `UnityEngine.VFX.VFXRenderer`
- `UnityEngine.VFX.VFXSpawnerCallbacks`
- `UnityEngine.VFX.VFXSpawnerState`
- `UnityEngine.VFX.VisualEffect`
- `UnityEngine.VFX.VisualEffectObject`
- `VFXEventAttribute.BindingsMarshaller`

</details>

<details><summary>Mismatching: 1</summary>

- `UnityEngine.VFX.VisualEffectAsset`

  - `field declaration order/names: ['PlayEventID', 'StopEventID'] → ['PlayEventName', 'StopEventName', 'PlayEventID', 'StopEventID']`
  - `extra field constant string PlayEventName`
  - `extra field constant string StopEventName`


</details>

<details><summary>Extra: 4</summary>

- `UnityEngine.VFX.VFXSpace`
- `UnityEngine.VFX.VFXSpawnerLoopState`
- `VFXExpressionValues.BindingsMarshaller`
- `VFXSpawnerState.BindingsMarshaller`

</details>


## UnityEngine.VRModule.dll

<details><summary>Matching: 3</summary>

- `<Module>`
- `UnityEngine.XR.XRDevice`
- `UnityEngine.XR.XRSettings`

</details>

<details><summary>Extra: 1</summary>

- `XRSettings.StereoRenderingMode`

</details>


## UnityEngine.VideoModule.dll

<details><summary>Matching: 16</summary>

- `<Module>`
- `UnityEngine.Experimental.Video.VideoClipPlayable`
- `UnityEngine.Video.Video3DLayout`
- `UnityEngine.Video.VideoAspectRatio`
- `UnityEngine.Video.VideoAudioOutputMode`
- `UnityEngine.Video.VideoClip`
- `UnityEngine.Video.VideoPlayer`
- `UnityEngine.Video.VideoRenderMode`
- `UnityEngine.Video.VideoSource`
- `UnityEngine.Video.VideoTimeReference`
- `UnityEngine.Video.VideoTimeSource`
- `UnityEngine.Video.VideoTimeUpdateMode`
- `VideoPlayer.ErrorEventHandler`
- `VideoPlayer.EventHandler`
- `VideoPlayer.FrameReadyEventHandler`
- `VideoPlayer.TimeEventHandler`

</details>


## UnityEngine.XRModule.dll

<details><summary>Matching: 32</summary>

- `<Module>`
- `InputTracking.TrackingStateEventType`
- `UnityEngine.XR.AvailableTrackingData`
- `UnityEngine.XR.Bone`
- `UnityEngine.XR.ConnectionChangeType`
- `UnityEngine.XR.Eyes`
- `UnityEngine.XR.Hand`
- `UnityEngine.XR.HashCodeHelper`
- `UnityEngine.XR.InputDevice`
- `UnityEngine.XR.InputDevices`
- `UnityEngine.XR.InputFeatureType`
- `UnityEngine.XR.InputFeatureUsage`
- `UnityEngine.XR.InputTracking`
- `UnityEngine.XR.MeshGenerationResult`
- `UnityEngine.XR.MeshGenerationStatus`
- `UnityEngine.XR.MeshId`
- `UnityEngine.XR.MeshVertexAttributes`
- `UnityEngine.XR.XRDisplaySubsystem`
- `UnityEngine.XR.XRDisplaySubsystemDescriptor`
- `UnityEngine.XR.XRInputSubsystem`
- `UnityEngine.XR.XRInputSubsystemDescriptor`
- `UnityEngine.XR.XRMeshSubsystem`
- `UnityEngine.XR.XRMeshSubsystemDescriptor`
- `UnityEngine.XR.XRNode`
- `UnityEngine.XR.XRNodeState`
- `XRDisplaySubsystem.BindingsMarshaller`
- `XRDisplaySubsystem.TextureLayout`
- `XRDisplaySubsystem.XRBlitParams`
- `XRDisplaySubsystem.XRMirrorViewBlitDesc`
- `XRDisplaySubsystem.XRRenderParameter`
- `XRDisplaySubsystem.XRRenderPass`
- `XRMeshSubsystem.MeshTransformList`

</details>

<details><summary>Missing: 3</summary>

- `UnityEngine.XR.CommonUsages`
- `UnityEngine.XR.InputFeatureUsage<T>`
- `UnityEngine.XR.InputTrackingState`

</details>


## UnityEngine.dll

<details><summary>Matching: 1</summary>

- `<Module>`

</details>


## __Generated

<details><summary>Matching: 5</summary>

- `IActivationFactory`
- `System.__Il2CppComDelegate`
- `System.__Il2CppComObject`
- `Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType`
- `Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType`

</details>


## campus-submodule.Runtime.dll

<details><summary>Matching: 1089</summary>

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
- `Campus.Common.Sound.CampusSoundPlayer`
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
- `Campus.Timeline.CampusTimelineCriVideoPlayer`
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

<details><summary>Mismatching: 1</summary>

- `Campus.Common.CampusText`

  - `_styleType: offset '0x7e8' → '0x7f0'`
  - `_ignoreLineSpacing: offset '0x7f0' → '0x7f8'`
  - `_ignoreCharacterSpacing: offset '0x7f1' → '0x7f9'`
  - `_isOutlineEnabled: offset '0x7f2' → '0x7fa'`
  - `_outlineColor: offset '0x7f4' → '0x7fc'`
  - `_outlineCustomCategory: offset '0x7f8' → '0x800'`
  - `_localizeKey: offset '0x800' → '0x808'`
  - `_autoKerningEnabled: offset '0x808' → '0x810'`
  - `_autoKerningThreshold: offset '0x80c' → '0x814'`
  - `_autoKerningRatio: offset '0x810' → '0x818'`
  - `onFontSharedMaterialSet: offset '0x818' → '0x820'`


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


## mscorlib.dll

<details><summary>Matching: 1284</summary>

- `<Module>`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10800`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=120`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=128`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=130`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1472`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=15`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=152`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=16`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=170`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=172`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=174`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=212`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2176`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=24`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=240`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=256`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=262`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=28`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=288`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=336`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=36`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=360`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=38`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=40`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=42`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=44`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=52`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=5952`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=64`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=648`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=72`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=76`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=84`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=94`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=998`
- `ASCIIEncoding.ASCIIEncodingSealed`
- `Array.ArrayEnumerator`
- `Array.RawData`
- `Array.SorterGenericArray`
- `Array.SorterObjectArray`
- `ArrayList.ArrayListDebugView`
- `ArrayList.ArrayListEnumeratorSimple`
- `ArrayPoolEventSource.BufferAllocatedReason`
- `Assembly.ResolveEventHolder`
- `AsyncMethodBuilderCore.<>c` (compiler-generated name)
- `AsyncMethodBuilderCore.<>c__DisplayClass5_0` (compiler-generated name)
- `AsyncMethodBuilderCore.ContinuationWrapper`
- `AsyncMethodBuilderCore.MoveNextRunner`
- `BitArray.BitArrayEnumeratorSimple`
- `BitConverter.<>c` (compiler-generated name)
- `CancellationCallbackInfo.WithSyncContext`
- `CancellationToken.<>c` (compiler-generated name)
- `CancellationTokenSource.Linked1CancellationTokenSource`
- `CancellationTokenSource.Linked2CancellationTokenSource`
- `CancellationTokenSource.LinkedNCancellationTokenSource.<>c` (compiler-generated name)
- `CodePointIndexer.TableRange`
- `ConditionalWeakTable.CreateValueCallback<TKey, TValue>`
- `Console.WindowsConsole`
- `Console.WindowsConsole.WindowsCancelHandler`
- `CrossAppDomainSink.ProcessMessageRes`
- `CrossContextChannel.ContextRestoreSink`
- `CultureData.NumberFormatEntryManaged`
- `CultureInfo.Data`
- `CultureInfo.OnCultureInfoChangedDelegate`
- `CustomAttributeData.LazyCAttrData`
- `DateTimeFormatInfo.TokenHashValue`
- `DateTimeFormatInfoScanner.FoundDatePattern`
- `DateTimeParse.DS`
- `DateTimeParse.DTT`
- `DateTimeParse.TM`
- `DebuggableAttribute.DebuggingModes`
- `Decimal.DecCalc`
- `Decimal.DecCalc.Buf24`
- `Decimal.DecCalc.PowerOvfl`
- `Decimal.DecCalc.RoundingMode`
- `DefaultBinder.<>c` (compiler-generated name)
- `DefaultBinder.BinderState`
- `DefaultBinder.Primitives`
- `DelegateSerializationHolder.DelegateEntry`
- `Encoding.DefaultDecoder`
- `Encoding.DefaultEncoder`
- `Encoding.EncodingByteBuffer`
- `Encoding.EncodingCharBuffer`
- `Enum.EnumResult`
- `Enum.ParseFailureKind`
- `Enum.ValuesAndNames`
- `EventInfo.AddEventAdapter`
- `EventSource.EventData`
- `Evidence.EvidenceEnumerator`
- `Exception.ExceptionMessageKind`
- `ExecutionContext.CaptureOptions`
- `ExecutionContext.Flags`
- `ExecutionContext.Reader`
- `FileStream.ReadDelegate`
- `FileStream.WriteDelegate`
- `FormatterServices.<>c__DisplayClass9_0` (compiler-generated name)
- `Guid.GuidParseThrowStyle`
- `Guid.GuidResult`
- `Guid.GuidStyles`
- `Guid.ParseFailureKind`
- `Hashtable.HashtableDebugView`
- `Hashtable.HashtableEnumerator`
- `Hashtable.KeyCollection`
- `Hashtable.ValueCollection`
- `Hashtable.bucket`
- `HebrewNumber.HS`
- `HebrewNumber.HebrewToken`
- `HebrewNumber.HebrewValue`
- `Internal.Runtime.Augments.AsyncStatus`
- `Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks`
- `Internal.Runtime.Augments.RuntimeAugments`
- `Internal.Runtime.Augments.RuntimeThread`
- `Internal.Runtime.Augments.TaskTraceCallbacks`
- `Internal.Threading.Tasks.Tracing.TaskTrace`
- `Interop`
- `Interop.Error`
- `Interop.ErrorInfo`
- `Interop.Sys`
- `Interop.Sys.DirectoryEntry`
- `Interop.Sys.FileStatus`
- `Interop.Sys.FileStatusFlags`
- `Interop.Sys.NodeType`
- `Lease.RenewalDelegate`
- `Locale`
- `LogicalCallContext.Reader`
- `LowLevelDictionary.DefaultComparer<TKey, TValue, T>`
- `MSCompatUnicodeTable.<>c` (compiler-generated name)
- `Marshal.<>c` (compiler-generated name)
- `Marshal.MarshalerInstanceKeyComparer`
- `MessageDictionary.DictionaryEnumerator`
- `Microsoft.Win32.SafeHandles.SafeFileHandle`
- `Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid`
- `Microsoft.Win32.SafeHandles.SafeWaitHandle`
- `Microsoft.Win32.Win32Native`
- `Mono.Globalization.Unicode.CodePointIndexer`
- `Mono.Globalization.Unicode.Contraction`
- `Mono.Globalization.Unicode.ContractionComparer`
- `Mono.Globalization.Unicode.Level2Map`
- `Mono.Globalization.Unicode.MSCompatUnicodeTable`
- `Mono.Globalization.Unicode.MSCompatUnicodeTableUtil`
- `Mono.Globalization.Unicode.NormalizationTableUtil`
- `Mono.Globalization.Unicode.SimpleCollator`
- `Mono.Globalization.Unicode.SortKeyBuffer`
- `Mono.Globalization.Unicode.TailoringInfo`
- `Mono.Interop.MonoPInvokeCallbackAttribute`
- `Mono.MonoAssemblyName`
- `Mono.Runtime`
- `Mono.RuntimeClassHandle`
- `Mono.RuntimeEventHandle`
- `Mono.RuntimeGPtrArrayHandle`
- `Mono.RuntimeGenericParamInfoHandle`
- `Mono.RuntimeMarshal`
- `Mono.RuntimePropertyHandle`
- `Mono.RuntimeRemoteClassHandle`
- `Mono.RuntimeStructs`
- `Mono.SafeGPtrArrayHandle`
- `Mono.SafeStringMarshal`
- `Mono.Security.BitConverterLE`
- `Mono.ValueTuple`
- `Mono.Xml.SmallXmlParser`
- `Mono.Xml.SmallXmlParserException`
- `MonoAssemblyName.<public_key_token>e__FixedBuffer` (compiler-generated name)
- `MonoCustomAttrs.AttributeInfo`
- `Number.NumberBuffer`
- `Number.NumberBuffer.DigitsAndNullTerminator`
- `OSSpecificSynchronizationContext.<>c` (compiler-generated name)
- `OSSpecificSynchronizationContext.InvocationContext`
- `OSSpecificSynchronizationContext.InvocationEntryDelegate`
- `ObjectReader.TopLevelAssemblyTypeResolver`
- `ObjectReader.TypeNAssembly`
- `ParameterizedStrings.FormatParam`
- `ParameterizedStrings.LowLevelStack`
- `Queue.QueueDebugView`
- `Queue.QueueEnumerator`
- `RemotingServices.CACD`
- `ResourceManager.ResourceManagerMediator`
- `ResourceReader.ResourceEnumerator`
- `RuntimePropertyInfo.Getter<T, R>`
- `RuntimePropertyInfo.GetterAdapter`
- `RuntimePropertyInfo.StaticGetter<R>`
- `RuntimeStructs.GPtrArray`
- `RuntimeStructs.GenericParamInfo`
- `RuntimeStructs.MonoClass`
- `RuntimeStructs.RemoteClass`
- `RuntimeType.MemberListType`
- `SR`
- `SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32` (compiler-generated name)
- `SemaphoreSlim.TaskNode`
- `SerializationEventsCache.<>c` (compiler-generated name)
- `SimpleCollator.Context`
- `SimpleCollator.Escape`
- `SimpleCollator.ExtenderType`
- `SimpleCollator.PreviousInfo`
- `SmallXmlParser.AttrListImpl`
- `SmallXmlParser.IAttrList`
- `SmallXmlParser.IContentHandler`
- `SoapServices.TypeInfo`
- `SpinLock.SystemThreading_SpinLockDebugView`
- `Stack.StackDebugView`
- `Stack.StackEnumerator`
- `StackTrace.TraceFormat`
- `Stream.<>c` (compiler-generated name)
- `Stream.NullStream`
- `Stream.ReadWriteParameters`
- `Stream.ReadWriteTask`
- `Stream.SynchronousAsyncResult`
- `Stream.SynchronousAsyncResult.<>c` (compiler-generated name)
- `StreamReader.NullStreamReader`
- `SynchronizationContextAwaitTaskContinuation.<>c` (compiler-generated name)
- `System.Action`
- `System.Action<T1, T2, T3, T4, T5, T6, T7, T8>`
- `System.Action<T1, T2, T3, T4, T5, T6>`
- `System.Action<T1, T2, T3, T4>`
- `System.Action<T1, T2, T3>`
- `System.Action<T1, T2>`
- `System.Action<T>`
- `System.Activator`
- `System.AggregateException`
- `System.AppDomainSetup`
- `System.AppDomainUnloadedException`
- `System.ApplicationException`
- `System.ArgIterator`
- `System.ArgumentException`
- `System.ArgumentNullException`
- `System.ArgumentOutOfRangeException`
- `System.ArithmeticException`
- `System.Array`
- `System.ArraySpec`
- `System.ArrayTypeMismatchException`
- `System.AssemblyLoadEventArgs`
- `System.AssemblyLoadEventHandler`
- `System.AsyncCallback`
- `System.Attribute`
- `System.AttributeTargets`
- `System.AttributeUsageAttribute`
- `System.BRECORD`
- `System.BadImageFormatException`
- `System.BitConverter`
- `System.Boolean`
- `System.Buffer`
- `System.Buffers.ArrayMemoryPool<T>`
- `System.Buffers.ArrayPoolEventSource`
- `System.Buffers.Binary.BinaryPrimitives`
- `System.Buffers.IMemoryOwner<T>`
- `System.Buffers.MemoryManager<T>`
- `System.Buffers.SpanAction<T, TArg>`
- `System.Buffers.Text.FormattingHelpers`
- `System.Buffers.Utilities`
- `System.Byte`
- `System.ByteEnum`
- `System.ByteMatcher`
- `System.CLSCompliantAttribute`
- `System.CannotUnloadAppDomainException`
- `System.Char`
- `System.CharEnumerator`
- `System.Collections.ArrayList`
- `System.Collections.BitArray`
- `System.Collections.CaseInsensitiveComparer`
- `System.Collections.CaseInsensitiveHashCodeProvider`
- `System.Collections.Comparer`
- `System.Collections.CompatibleComparer`
- `System.Collections.Concurrent.CDSCollectionETWBCLProvider`
- `System.Collections.Concurrent.IDictionaryDebugView<K, V>`
- `System.Collections.Concurrent.IProducerConsumerCollectionDebugView<T>`
- `System.Collections.Concurrent.PaddedHeadAndTail`
- `System.Collections.DictionaryEntry`
- `System.Collections.Generic.ByteEqualityComparer`
- `System.Collections.Generic.CollectionExtensions`
- `System.Collections.Generic.DictionaryKeyCollectionDebugView<TKey, TValue>`
- `System.Collections.Generic.DictionaryValueCollectionDebugView<TKey, TValue>`
- `System.Collections.Generic.EnumEqualityComparer<T>`
- `System.Collections.Generic.GenericComparer<T>`
- `System.Collections.Generic.GenericEqualityComparer<T>`
- `System.Collections.Generic.ICollection<T>`
- `System.Collections.Generic.ICollectionDebugView<T>`
- `System.Collections.Generic.IComparer<T>`
- `System.Collections.Generic.IDictionary<TKey, TValue>`
- `System.Collections.Generic.IDictionaryDebugView<K, V>`
- `System.Collections.Generic.IEnumerable<T>`
- `System.Collections.Generic.IEnumerator<T>`
- `System.Collections.Generic.IEqualityComparer<T>`
- `System.Collections.Generic.IList<T>`
- `System.Collections.Generic.IReadOnlyCollection<T>`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>`
- `System.Collections.Generic.IReadOnlyList<T>`
- `System.Collections.Generic.InsertionBehavior`
- `System.Collections.Generic.InternalStringComparer`
- `System.Collections.Generic.IntrospectiveSortUtilities`
- `System.Collections.Generic.KeyNotFoundException`
- `System.Collections.Generic.KeyValuePair`
- `System.Collections.Generic.LongEnumEqualityComparer<T>`
- `System.Collections.Generic.LowLevelListWithIList<T>`
- `System.Collections.Generic.NullableComparer<T>`
- `System.Collections.Generic.NullableEqualityComparer<T>`
- `System.Collections.Generic.ObjectComparer<T>`
- `System.Collections.Generic.ObjectEqualityComparer<T>`
- `System.Collections.Generic.QueueDebugView<T>`
- `System.Collections.Generic.SByteEnumEqualityComparer<T>`
- `System.Collections.Generic.ShortEnumEqualityComparer<T>`
- `System.Collections.Generic.StackDebugView<T>`
- `System.Collections.HashHelpers`
- `System.Collections.Hashtable`
- `System.Collections.ICollection`
- `System.Collections.IComparer`
- `System.Collections.IDictionary`
- `System.Collections.IDictionaryEnumerator`
- `System.Collections.IEnumerable`
- `System.Collections.IEnumerator`
- `System.Collections.IEqualityComparer`
- `System.Collections.IHashCodeProvider`
- `System.Collections.IList`
- `System.Collections.IStructuralComparable`
- `System.Collections.IStructuralEquatable`
- `System.Collections.Queue`
- `System.Collections.Stack`
- `System.Comparison<T>`
- `System.CompatibilitySwitches`
- `System.Configuration.Assemblies.AssemblyHashAlgorithm`
- `System.Configuration.Assemblies.AssemblyVersionCompatibility`
- `System.Console`
- `System.ConsoleCancelEventArgs`
- `System.ConsoleCancelEventHandler`
- `System.ConsoleColor`
- `System.ConsoleDriver`
- `System.ConsoleKey`
- `System.ConsoleKeyInfo`
- `System.ConsoleModifiers`
- `System.ConsoleScreenBufferInfo`
- `System.ConsoleSpecialKey`
- `System.ContextBoundObject`
- `System.ContextStaticAttribute`
- `System.Convert`
- `System.Converter<TInput, TOutput>`
- `System.Coord`
- `System.CultureAwareComparer`
- `System.CurrentSystemTimeZone`
- `System.DBNull`
- `System.DTSubString`
- `System.DTSubStringType`
- `System.DateTime`
- `System.DateTimeFormat`
- `System.DateTimeKind`
- `System.DateTimeOffset`
- `System.DateTimeRawInfo`
- `System.DateTimeResult`
- `System.DateTimeToken`
- `System.DayOfWeek`
- `System.Decimal`
- `System.DefaultBinder`
- `System.Delegate`
- `System.DelegateData`
- `System.DelegateSerializationHolder`
- `System.Diagnostics.CodeAnalysis.AllowNullAttribute`
- `System.Diagnostics.CodeAnalysis.DisallowNullAttribute`
- `System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute`
- `System.Diagnostics.CodeAnalysis.MaybeNullAttribute`
- `System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute`
- `System.Diagnostics.CodeAnalysis.NotNullAttribute`
- `System.Diagnostics.CodeAnalysis.NotNullWhenAttribute`
- `System.Diagnostics.ConditionalAttribute`
- `System.Diagnostics.Contracts.Contract`
- `System.Diagnostics.DebuggableAttribute`
- `System.Diagnostics.Debugger`
- `System.Diagnostics.DebuggerBrowsableAttribute`
- `System.Diagnostics.DebuggerBrowsableState`
- `System.Diagnostics.DebuggerDisplayAttribute`
- `System.Diagnostics.DebuggerHiddenAttribute`
- `System.Diagnostics.DebuggerNonUserCodeAttribute`
- `System.Diagnostics.DebuggerStepThroughAttribute`
- `System.Diagnostics.DebuggerTypeProxyAttribute`
- `System.Diagnostics.StackFrame`
- `System.Diagnostics.StackTrace`
- `System.Diagnostics.StackTraceHiddenAttribute`
- `System.Diagnostics.Tracing.EventKeywords`
- `System.Diagnostics.Tracing.EventLevel`
- `System.Diagnostics.Tracing.EventSourceAttribute`
- `System.DivideByZeroException`
- `System.DllNotFoundException`
- `System.Double`
- `System.Empty`
- `System.EntryPointNotFoundException`
- `System.Enum`
- `System.EventArgs`
- `System.EventHandler`
- `System.EventHandler<TEventArgs>`
- `System.Exception`
- `System.ExceptionArgument`
- `System.ExceptionResource`
- `System.ExecutionEngineException`
- `System.FieldAccessException`
- `System.FlagsAttribute`
- `System.FormatException`
- `System.Func<T, TResult>`
- `System.Func<T1, T2, T3, T4, T5, TResult>`
- `System.Func<T1, T2, T3, T4, TResult>`
- `System.Func<T1, T2, T3, TResult>`
- `System.Func<T1, T2, TResult>`
- `System.Func<TResult>`
- `System.GC`
- `System.Gen2GcCallback`
- `System.Globalization.Bootstring`
- `System.Globalization.Calendar`
- `System.Globalization.CalendarId`
- `System.Globalization.CharUnicodeInfo`
- `System.Globalization.CompareInfo`
- `System.Globalization.CompareOptions`
- `System.Globalization.CultureData`
- `System.Globalization.CultureInfo`
- `System.Globalization.CultureNotFoundException`
- `System.Globalization.DateTimeFormatFlags`
- `System.Globalization.DateTimeFormatInfo`
- `System.Globalization.DateTimeFormatInfoScanner`
- `System.Globalization.DateTimeStyles`
- `System.Globalization.DaylightTimeStruct`
- `System.Globalization.EncodingTable`
- `System.Globalization.EraInfo`
- `System.Globalization.FORMATFLAGS`
- `System.Globalization.GlobalizationMode`
- `System.Globalization.GregorianCalendar`
- `System.Globalization.GregorianCalendarHelper`
- `System.Globalization.GregorianCalendarTypes`
- `System.Globalization.HebrewNumber`
- `System.Globalization.HebrewNumberParsingContext`
- `System.Globalization.HebrewNumberParsingState`
- `System.Globalization.HijriCalendar`
- `System.Globalization.ISimpleCollator`
- `System.Globalization.IdnMapping`
- `System.Globalization.InternalCodePageDataItem`
- `System.Globalization.InternalEncodingDataItem`
- `System.Globalization.JapaneseCalendar`
- `System.Globalization.MonthNameStyles`
- `System.Globalization.NumberFormatInfo`
- `System.Globalization.NumberStyles`
- `System.Globalization.Punycode`
- `System.Globalization.RegionInfo`
- `System.Globalization.SortKey`
- `System.Globalization.SortVersion`
- `System.Globalization.StringInfo`
- `System.Globalization.TaiwanCalendar`
- `System.Globalization.TextInfo`
- `System.Globalization.TextInfoToLowerData`
- `System.Globalization.TextInfoToUpperData`
- `System.Globalization.ThaiBuddhistCalendar`
- `System.Globalization.TimeSpanFormat`
- `System.Globalization.TimeSpanParse`
- `System.Globalization.TimeSpanStyles`
- `System.Globalization.UmAlQuraCalendar`
- `System.Globalization.UnicodeCategory`
- `System.Guid`
- `System.Handles`
- `System.HashCode`
- `System.IAsyncResult`
- `System.ICloneable`
- `System.IComparable`
- `System.IComparable<T>`
- `System.IConsoleDriver`
- `System.IConvertible`
- `System.ICustomFormatter`
- `System.IDisposable`
- `System.IEquatable<T>`
- `System.IFormatProvider`
- `System.IFormattable`
- `System.IO.BinaryReader`
- `System.IO.CStreamReader`
- `System.IO.CStreamWriter`
- `System.IO.Directory`
- `System.IO.DirectoryInfo`
- `System.IO.DirectoryNotFoundException`
- `System.IO.DriveNotFoundException`
- `System.IO.EndOfStreamException`
- `System.IO.Error`
- `System.IO.File`
- `System.IO.FileAccess`
- `System.IO.FileAttributes`
- `System.IO.FileInfo`
- `System.IO.FileLoadException`
- `System.IO.FileMode`
- `System.IO.FileNotFoundException`
- `System.IO.FileOptions`
- `System.IO.FileShare`
- `System.IO.FileStatus`
- `System.IO.FileStream`
- `System.IO.FileSystem`
- `System.IO.FileSystemInfo`
- `System.IO.IOException`
- `System.IO.MemoryStream`
- `System.IO.MonoFileType`
- `System.IO.MonoIO`
- `System.IO.MonoIOError`
- `System.IO.MonoIOStat`
- `System.IO.Path`
- `System.IO.PathInternal`
- `System.IO.PathTooLongException`
- `System.IO.PinnedBufferMemoryStream`
- `System.IO.SeekOrigin`
- `System.IO.StreamReader`
- `System.IO.StreamWriter`
- `System.IO.TextReader`
- `System.IO.UnexceptionalStreamReader`
- `System.IO.UnexceptionalStreamWriter`
- `System.IO.UnmanagedMemoryStream`
- `System.IO.__Error`
- `System.IObservable<T>`
- `System.IObserver<T>`
- `System.IProgress<T>`
- `System.ISpanFormattable`
- `System.IndexOutOfRangeException`
- `System.InputRecord`
- `System.InsufficientExecutionStackException`
- `System.Int16`
- `System.Int16Enum`
- `System.Int32`
- `System.Int32Enum`
- `System.Int64`
- `System.Int64Enum`
- `System.IntPtr`
- `System.InvalidCastException`
- `System.InvalidOperationException`
- `System.InvalidProgramException`
- `System.InvalidTimeZoneException`
- `System.KnownTerminals`
- `System.LazyDebugView<T>`
- `System.LazyHelper`
- `System.LazyState`
- `System.MarshalByRefObject`
- `System.Marvin`
- `System.Math`
- `System.MemberAccessException`
- `System.MemoryDebugView<T>`
- `System.MemoryExtensions`
- `System.MethodAccessException`
- `System.MidpointRounding`
- `System.MissingFieldException`
- `System.MissingMemberException`
- `System.MissingMethodException`
- `System.ModifierSpec`
- `System.MonoAsyncCall`
- `System.MonoListItem`
- `System.MonoTODOAttribute`
- `System.MonoType`
- `System.MonoTypeInfo`
- `System.MulticastDelegate`
- `System.MulticastNotSupportedException`
- `System.NonSerializedAttribute`
- `System.NotImplemented`
- `System.NotImplementedException`
- `System.NotSupportedException`
- `System.NullConsoleDriver`
- `System.NullReferenceException`
- `System.Nullable`
- `System.Number`
- `System.Numerics.ConstantHelper`
- `System.Numerics.Hashing.HashHelpers`
- `System.Numerics.Register`
- `System.Numerics.Vector`
- `System.Object`
- `System.ObjectDisposedException`
- `System.ObsoleteAttribute`
- `System.OperationCanceledException`
- `System.OrdinalCaseSensitiveComparer`
- `System.OrdinalComparer`
- `System.OrdinalIgnoreCaseComparer`
- `System.OutOfMemoryException`
- `System.OverflowException`
- `System.ParamArrayAttribute`
- `System.ParamsArray`
- `System.ParseFailureKind`
- `System.ParseFlags`
- `System.ParseNumbers`
- `System.PlatformID`
- `System.PlatformNotSupportedException`
- `System.PointerSpec`
- `System.Predicate<T>`
- `System.RankException`
- `System.Reflection.AmbiguousMatchException`
- `System.Reflection.Assembly`
- `System.Reflection.AssemblyCompanyAttribute`
- `System.Reflection.AssemblyConfigurationAttribute`
- `System.Reflection.AssemblyContentType`
- `System.Reflection.AssemblyCopyrightAttribute`
- `System.Reflection.AssemblyDefaultAliasAttribute`
- `System.Reflection.AssemblyDelaySignAttribute`
- `System.Reflection.AssemblyDescriptionAttribute`
- `System.Reflection.AssemblyFileVersionAttribute`
- `System.Reflection.AssemblyInformationalVersionAttribute`
- `System.Reflection.AssemblyKeyFileAttribute`
- `System.Reflection.AssemblyMetadataAttribute`
- `System.Reflection.AssemblyName`
- `System.Reflection.AssemblyNameFlags`
- `System.Reflection.AssemblyProductAttribute`
- `System.Reflection.AssemblyTitleAttribute`
- `System.Reflection.AssemblyTrademarkAttribute`
- `System.Reflection.Binder`
- `System.Reflection.BindingFlags`
- `System.Reflection.CallingConventions`
- `System.Reflection.ConstructorInfo`
- `System.Reflection.CorElementType`
- `System.Reflection.CustomAttributeData`
- `System.Reflection.CustomAttributeExtensions`
- `System.Reflection.CustomAttributeFormatException`
- `System.Reflection.CustomAttributeNamedArgument`
- `System.Reflection.CustomAttributeTypedArgument`
- `System.Reflection.DefaultMemberAttribute`
- `System.Reflection.Emit.AssemblyBuilder`
- `System.Reflection.Emit.ConstructorBuilder`
- `System.Reflection.Emit.DynamicMethod`
- `System.Reflection.Emit.EnumBuilder`
- `System.Reflection.Emit.EventBuilder`
- `System.Reflection.Emit.FieldBuilder`
- `System.Reflection.Emit.GenericTypeParameterBuilder`
- `System.Reflection.Emit.ILGenerator`
- `System.Reflection.Emit.LocalBuilder`
- `System.Reflection.Emit.MethodBuilder`
- `System.Reflection.Emit.ModuleBuilder`
- `System.Reflection.Emit.ParameterBuilder`
- `System.Reflection.Emit.PropertyBuilder`
- `System.Reflection.Emit.SignatureHelper`
- `System.Reflection.Emit.TypeBuilder`
- `System.Reflection.EventAttributes`
- `System.Reflection.EventInfo`
- `System.Reflection.ExceptionHandlingClause`
- `System.Reflection.ExceptionHandlingClauseOptions`
- `System.Reflection.FieldAttributes`
- `System.Reflection.FieldInfo`
- `System.Reflection.GenericParameterAttributes`
- `System.Reflection.ICustomAttributeProvider`
- `System.Reflection.InvalidFilterCriteriaException`
- `System.Reflection.LocalVariableInfo`
- `System.Reflection.MemberFilter`
- `System.Reflection.MemberInfoSerializationHolder`
- `System.Reflection.MemberTypes`
- `System.Reflection.MethodAttributes`
- `System.Reflection.MethodBase`
- `System.Reflection.MethodImplAttributes`
- `System.Reflection.MethodInfo`
- `System.Reflection.Missing`
- `System.Reflection.MissingMetadataException`
- `System.Reflection.Module`
- `System.Reflection.MonoEventInfo`
- `System.Reflection.MonoMethodInfo`
- `System.Reflection.MonoPropertyInfo`
- `System.Reflection.PInfo`
- `System.Reflection.PInvokeAttributes`
- `System.Reflection.ParameterAttributes`
- `System.Reflection.ParameterInfo`
- `System.Reflection.ParameterModifier`
- `System.Reflection.Pointer`
- `System.Reflection.ProcessorArchitecture`
- `System.Reflection.PropertyAttributes`
- `System.Reflection.PropertyInfo`
- `System.Reflection.ReflectionTypeLoadException`
- `System.Reflection.RtFieldInfo`
- `System.Reflection.RuntimeAssembly`
- `System.Reflection.RuntimeConstructorInfo`
- `System.Reflection.RuntimeEventInfo`
- `System.Reflection.RuntimeFieldInfo`
- `System.Reflection.RuntimeMethodInfo`
- `System.Reflection.RuntimeModule`
- `System.Reflection.RuntimeParameterInfo`
- `System.Reflection.RuntimePropertyInfo`
- `System.Reflection.SignatureArrayType`
- `System.Reflection.SignatureByRefType`
- `System.Reflection.SignatureConstructedGenericType`
- `System.Reflection.SignatureHasElementType`
- `System.Reflection.SignaturePointerType`
- `System.Reflection.SignatureType`
- `System.Reflection.SignatureTypeExtensions`
- `System.Reflection.StrongNameKeyPair`
- `System.Reflection.TargetException`
- `System.Reflection.TargetInvocationException`
- `System.Reflection.TargetParameterCountException`
- `System.Reflection.TypeAttributes`
- `System.Reflection.TypeFilter`
- `System.ReflectionOnlyType`
- `System.ResolveEventArgs`
- `System.ResolveEventHandler`
- `System.Resources.FastResourceComparer`
- `System.Resources.FileBasedResourceGroveler`
- `System.Resources.IResourceGroveler`
- `System.Resources.IResourceReader`
- `System.Resources.ManifestBasedResourceGroveler`
- `System.Resources.NeutralResourcesLanguageAttribute`
- `System.Resources.ResourceLocator`
- `System.Resources.ResourceReader`
- `System.Resources.ResourceSet`
- `System.Resources.ResourceTypeCode`
- `System.Resources.SatelliteContractVersionAttribute`
- `System.Resources.UltimateResourceFallbackLocation`
- `System.Runtime.AmbiguousImplementationException`
- `System.Runtime.CompilerServices.AsyncMethodBuilderAttribute`
- `System.Runtime.CompilerServices.AsyncMethodBuilderCore`
- `System.Runtime.CompilerServices.AsyncStateMachineAttribute`
- `System.Runtime.CompilerServices.AsyncTaskCache`
- `System.Runtime.CompilerServices.AsyncTaskMethodBuilder`
- `System.Runtime.CompilerServices.AsyncVoidMethodBuilder`
- `System.Runtime.CompilerServices.CallerFilePathAttribute`
- `System.Runtime.CompilerServices.CompilationRelaxations`
- `System.Runtime.CompilerServices.CompilationRelaxationsAttribute`
- `System.Runtime.CompilerServices.CompilerGeneratedAttribute`
- `System.Runtime.CompilerServices.CustomConstantAttribute`
- `System.Runtime.CompilerServices.DateTimeConstantAttribute`
- `System.Runtime.CompilerServices.DecimalConstantAttribute`
- `System.Runtime.CompilerServices.DefaultDependencyAttribute`
- `System.Runtime.CompilerServices.Ephemeron`
- `System.Runtime.CompilerServices.ExtensionAttribute`
- `System.Runtime.CompilerServices.FixedBufferAttribute`
- `System.Runtime.CompilerServices.FriendAccessAllowedAttribute`
- `System.Runtime.CompilerServices.IAsyncStateMachine`
- `System.Runtime.CompilerServices.ICriticalNotifyCompletion`
- `System.Runtime.CompilerServices.INotifyCompletion`
- `System.Runtime.CompilerServices.InternalsVisibleToAttribute`
- `System.Runtime.CompilerServices.IntrinsicAttribute`
- `System.Runtime.CompilerServices.IsByRefLikeAttribute`
- `System.Runtime.CompilerServices.IsReadOnlyAttribute`
- `System.Runtime.CompilerServices.IsVolatile`
- `System.Runtime.CompilerServices.IteratorStateMachineAttribute`
- `System.Runtime.CompilerServices.JitHelpers`
- `System.Runtime.CompilerServices.LoadHint`
- `System.Runtime.CompilerServices.ReflectionBlockedAttribute`
- `System.Runtime.CompilerServices.RuntimeCompatibilityAttribute`
- `System.Runtime.CompilerServices.RuntimeFeature`
- `System.Runtime.CompilerServices.RuntimeHelpers`
- `System.Runtime.CompilerServices.RuntimeWrappedException`
- `System.Runtime.CompilerServices.StateMachineAttribute`
- `System.Runtime.CompilerServices.StringFreezingAttribute`
- `System.Runtime.CompilerServices.TaskAwaiter`
- `System.Runtime.CompilerServices.TupleElementNamesAttribute`
- `System.Runtime.CompilerServices.TypeDependencyAttribute`
- `System.Runtime.CompilerServices.TypeForwardedFromAttribute`
- `System.Runtime.CompilerServices.Unsafe`
- `System.Runtime.CompilerServices.UnsafeValueTypeAttribute`
- `System.Runtime.ConstrainedExecution.Cer`
- `System.Runtime.ConstrainedExecution.Consistency`
- `System.Runtime.ConstrainedExecution.CriticalFinalizerObject`
- `System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute`
- `System.Runtime.ConstrainedExecution.ReliabilityContractAttribute`
- `System.Runtime.ExceptionServices.ExceptionDispatchInfo`
- `System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs`
- `System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute`
- `System.Runtime.InteropServices.CallingConvention`
- `System.Runtime.InteropServices.CharSet`
- `System.Runtime.InteropServices.ClassInterfaceAttribute`
- `System.Runtime.InteropServices.ClassInterfaceType`
- `System.Runtime.InteropServices.ComCompatibleVersionAttribute`
- `System.Runtime.InteropServices.ComDefaultInterfaceAttribute`
- `System.Runtime.InteropServices.ComImportAttribute`
- `System.Runtime.InteropServices.ComInterfaceType`
- `System.Runtime.InteropServices.ComVisibleAttribute`
- `System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute`
- `System.Runtime.InteropServices.DllImportAttribute`
- `System.Runtime.InteropServices.DllImportSearchPath`
- `System.Runtime.InteropServices.ExternalException`
- `System.Runtime.InteropServices.FieldOffsetAttribute`
- `System.Runtime.InteropServices.GCHandle`
- `System.Runtime.InteropServices.GCHandleType`
- `System.Runtime.InteropServices.GuidAttribute`
- `System.Runtime.InteropServices.ICustomMarshaler`
- `System.Runtime.InteropServices.InAttribute`
- `System.Runtime.InteropServices.InterfaceTypeAttribute`
- `System.Runtime.InteropServices.Marshal`
- `System.Runtime.InteropServices.MarshalAsAttribute`
- `System.Runtime.InteropServices.MarshalDirectiveException`
- `System.Runtime.InteropServices.MemoryMarshal`
- `System.Runtime.InteropServices.OptionalAttribute`
- `System.Runtime.InteropServices.OutAttribute`
- `System.Runtime.InteropServices.PreserveSigAttribute`
- `System.Runtime.InteropServices.SafeBuffer`
- `System.Runtime.InteropServices.SafeHandle`
- `System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute`
- `System.Runtime.InteropServices.UnmanagedType`
- `System.Runtime.InteropServices.VarEnum`
- `System.Runtime.InteropServices._Activator`
- `System.Runtime.InteropServices._Assembly`
- `System.Runtime.InteropServices._AssemblyName`
- `System.Runtime.InteropServices._Module`
- `System.Runtime.InteropServices._ParameterInfo`
- `System.Runtime.Remoting.ActivatedClientTypeEntry`
- `System.Runtime.Remoting.ActivatedServiceTypeEntry`
- `System.Runtime.Remoting.Activation.ActivationServices`
- `System.Runtime.Remoting.Activation.AppDomainLevelActivator`
- `System.Runtime.Remoting.Activation.ConstructionLevelActivator`
- `System.Runtime.Remoting.Activation.ContextLevelActivator`
- `System.Runtime.Remoting.Activation.IActivator`
- `System.Runtime.Remoting.Activation.IConstructionCallMessage`
- `System.Runtime.Remoting.Activation.IConstructionReturnMessage`
- `System.Runtime.Remoting.Activation.RemoteActivationAttribute`
- `System.Runtime.Remoting.Activation.RemoteActivator`
- `System.Runtime.Remoting.ChannelData`
- `System.Runtime.Remoting.ChannelInfo`
- `System.Runtime.Remoting.Channels.AsyncRequest`
- `System.Runtime.Remoting.Channels.CADSerializer`
- `System.Runtime.Remoting.Channels.ChannelServices`
- `System.Runtime.Remoting.Channels.CrossAppDomainChannel`
- `System.Runtime.Remoting.Channels.CrossAppDomainData`
- `System.Runtime.Remoting.Channels.CrossAppDomainSink`
- `System.Runtime.Remoting.Channels.IChannel`
- `System.Runtime.Remoting.Channels.IChannelDataStore`
- `System.Runtime.Remoting.Channels.IChannelReceiver`
- `System.Runtime.Remoting.Channels.IChannelSender`
- `System.Runtime.Remoting.Channels.IClientChannelSinkProvider`
- `System.Runtime.Remoting.Channels.ISecurableChannel`
- `System.Runtime.Remoting.Channels.IServerChannelSinkProvider`
- `System.Runtime.Remoting.Channels.SinkProviderData`
- `System.Runtime.Remoting.ClientActivatedIdentity`
- `System.Runtime.Remoting.ClientIdentity`
- `System.Runtime.Remoting.ConfigHandler`
- `System.Runtime.Remoting.Contexts.Context`
- `System.Runtime.Remoting.Contexts.ContextCallbackObject`
- `System.Runtime.Remoting.Contexts.CrossContextChannel`
- `System.Runtime.Remoting.Contexts.DynamicPropertyCollection`
- `System.Runtime.Remoting.Contexts.IContextAttribute`
- `System.Runtime.Remoting.Contexts.IContextProperty`
- `System.Runtime.Remoting.Contexts.IContributeClientContextSink`
- `System.Runtime.Remoting.Contexts.IContributeEnvoySink`
- `System.Runtime.Remoting.Contexts.IContributeObjectSink`
- `System.Runtime.Remoting.Contexts.IContributeServerContextSink`
- `System.Runtime.Remoting.Contexts.IDynamicMessageSink`
- `System.Runtime.Remoting.CustomErrorsModes`
- `System.Runtime.Remoting.DisposerReplySink`
- `System.Runtime.Remoting.EnvoyInfo`
- `System.Runtime.Remoting.FormatterData`
- `System.Runtime.Remoting.IChannelInfo`
- `System.Runtime.Remoting.IEnvoyInfo`
- `System.Runtime.Remoting.IRemotingTypeInfo`
- `System.Runtime.Remoting.Identity`
- `System.Runtime.Remoting.InternalRemotingServices`
- `System.Runtime.Remoting.Lifetime.ILease`
- `System.Runtime.Remoting.Lifetime.ISponsor`
- `System.Runtime.Remoting.Lifetime.Lease`
- `System.Runtime.Remoting.Lifetime.LeaseManager`
- `System.Runtime.Remoting.Lifetime.LeaseSink`
- `System.Runtime.Remoting.Lifetime.LeaseState`
- `System.Runtime.Remoting.Lifetime.LifetimeServices`
- `System.Runtime.Remoting.Messaging.ArgInfo`
- `System.Runtime.Remoting.Messaging.ArgInfoType`
- `System.Runtime.Remoting.Messaging.AsyncResult`
- `System.Runtime.Remoting.Messaging.CADArgHolder`
- `System.Runtime.Remoting.Messaging.CADMessageBase`
- `System.Runtime.Remoting.Messaging.CADMethodCallMessage`
- `System.Runtime.Remoting.Messaging.CADMethodRef`
- `System.Runtime.Remoting.Messaging.CADMethodReturnMessage`
- `System.Runtime.Remoting.Messaging.CADObjRef`
- `System.Runtime.Remoting.Messaging.CallContext`
- `System.Runtime.Remoting.Messaging.CallContextRemotingData`
- `System.Runtime.Remoting.Messaging.CallContextSecurityData`
- `System.Runtime.Remoting.Messaging.CallType`
- `System.Runtime.Remoting.Messaging.ClientContextReplySink`
- `System.Runtime.Remoting.Messaging.ClientContextTerminatorSink`
- `System.Runtime.Remoting.Messaging.ConstructionCall`
- `System.Runtime.Remoting.Messaging.ConstructionCallDictionary`
- `System.Runtime.Remoting.Messaging.ConstructionResponse`
- `System.Runtime.Remoting.Messaging.EnvoyTerminatorSink`
- `System.Runtime.Remoting.Messaging.ErrorMessage`
- `System.Runtime.Remoting.Messaging.Header`
- `System.Runtime.Remoting.Messaging.HeaderHandler`
- `System.Runtime.Remoting.Messaging.IInternalMessage`
- `System.Runtime.Remoting.Messaging.IMessage`
- `System.Runtime.Remoting.Messaging.IMessageCtrl`
- `System.Runtime.Remoting.Messaging.IMessageSink`
- `System.Runtime.Remoting.Messaging.IMethodCallMessage`
- `System.Runtime.Remoting.Messaging.IMethodMessage`
- `System.Runtime.Remoting.Messaging.IMethodReturnMessage`
- `System.Runtime.Remoting.Messaging.IllogicalCallContext`
- `System.Runtime.Remoting.Messaging.LogicalCallContext`
- `System.Runtime.Remoting.Messaging.MCMDictionary`
- `System.Runtime.Remoting.Messaging.MessageDictionary`
- `System.Runtime.Remoting.Messaging.MethodCall`
- `System.Runtime.Remoting.Messaging.MethodResponse`
- `System.Runtime.Remoting.Messaging.MethodReturnDictionary`
- `System.Runtime.Remoting.Messaging.MonoMethodMessage`
- `System.Runtime.Remoting.Messaging.ObjRefSurrogate`
- `System.Runtime.Remoting.Messaging.OneWayAttribute`
- `System.Runtime.Remoting.Messaging.RemotingSurrogate`
- `System.Runtime.Remoting.Messaging.RemotingSurrogateSelector`
- `System.Runtime.Remoting.Messaging.ReturnMessage`
- `System.Runtime.Remoting.Messaging.ServerContextTerminatorSink`
- `System.Runtime.Remoting.Messaging.ServerObjectReplySink`
- `System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink`
- `System.Runtime.Remoting.Messaging.StackBuilderSink`
- `System.Runtime.Remoting.Metadata.SoapAttribute`
- `System.Runtime.Remoting.Metadata.SoapFieldAttribute`
- `System.Runtime.Remoting.Metadata.SoapMethodAttribute`
- `System.Runtime.Remoting.Metadata.SoapParameterAttribute`
- `System.Runtime.Remoting.Metadata.SoapTypeAttribute`
- `System.Runtime.Remoting.ObjRef`
- `System.Runtime.Remoting.ProviderData`
- `System.Runtime.Remoting.Proxies.ProxyAttribute`
- `System.Runtime.Remoting.Proxies.RealProxy`
- `System.Runtime.Remoting.Proxies.RemotingProxy`
- `System.Runtime.Remoting.Proxies.TransparentProxy`
- `System.Runtime.Remoting.RemotingConfiguration`
- `System.Runtime.Remoting.RemotingException`
- `System.Runtime.Remoting.RemotingServices`
- `System.Runtime.Remoting.ServerIdentity`
- `System.Runtime.Remoting.Services.ITrackingHandler`
- `System.Runtime.Remoting.Services.TrackingServices`
- `System.Runtime.Remoting.SingleCallIdentity`
- `System.Runtime.Remoting.SingletonIdentity`
- `System.Runtime.Remoting.SoapServices`
- `System.Runtime.Remoting.TypeEntry`
- `System.Runtime.Remoting.TypeInfo`
- `System.Runtime.Remoting.WellKnownClientTypeEntry`
- `System.Runtime.Remoting.WellKnownObjectMode`
- `System.Runtime.Remoting.WellKnownServiceTypeEntry`
- `System.Runtime.RuntimeImports`
- `System.Runtime.Serialization.DeserializationEventHandler`
- `System.Runtime.Serialization.FixupHolder`
- `System.Runtime.Serialization.FixupHolderList`
- `System.Runtime.Serialization.FormatterConverter`
- `System.Runtime.Serialization.FormatterServices`
- `System.Runtime.Serialization.Formatters.Binary.BinaryArray`
- `System.Runtime.Serialization.Formatters.Binary.BinaryArrayTypeEnum`
- `System.Runtime.Serialization.Formatters.Binary.BinaryAssembly`
- `System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo`
- `System.Runtime.Serialization.Formatters.Binary.BinaryConverter`
- `System.Runtime.Serialization.Formatters.Binary.BinaryCrossAppDomainAssembly`
- `System.Runtime.Serialization.Formatters.Binary.BinaryCrossAppDomainMap`
- `System.Runtime.Serialization.Formatters.Binary.BinaryCrossAppDomainString`
- `System.Runtime.Serialization.Formatters.Binary.BinaryFormatter`
- `System.Runtime.Serialization.Formatters.Binary.BinaryHeaderEnum`
- `System.Runtime.Serialization.Formatters.Binary.BinaryMethodCall`
- `System.Runtime.Serialization.Formatters.Binary.BinaryMethodReturn`
- `System.Runtime.Serialization.Formatters.Binary.BinaryObject`
- `System.Runtime.Serialization.Formatters.Binary.BinaryObjectString`
- `System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMap`
- `System.Runtime.Serialization.Formatters.Binary.BinaryObjectWithMapTyped`
- `System.Runtime.Serialization.Formatters.Binary.BinaryTypeEnum`
- `System.Runtime.Serialization.Formatters.Binary.Converter`
- `System.Runtime.Serialization.Formatters.Binary.IOUtil`
- `System.Runtime.Serialization.Formatters.Binary.IntSizedArray`
- `System.Runtime.Serialization.Formatters.Binary.InternalArrayTypeE`
- `System.Runtime.Serialization.Formatters.Binary.InternalFE`
- `System.Runtime.Serialization.Formatters.Binary.InternalMemberTypeE`
- `System.Runtime.Serialization.Formatters.Binary.InternalMemberValueE`
- `System.Runtime.Serialization.Formatters.Binary.InternalObjectPositionE`
- `System.Runtime.Serialization.Formatters.Binary.InternalObjectTypeE`
- `System.Runtime.Serialization.Formatters.Binary.InternalParseTypeE`
- `System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE`
- `System.Runtime.Serialization.Formatters.Binary.InternalSerializerTypeE`
- `System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveTyped`
- `System.Runtime.Serialization.Formatters.Binary.MemberPrimitiveUnTyped`
- `System.Runtime.Serialization.Formatters.Binary.MemberReference`
- `System.Runtime.Serialization.Formatters.Binary.MessageEnd`
- `System.Runtime.Serialization.Formatters.Binary.MessageEnum`
- `System.Runtime.Serialization.Formatters.Binary.NameCache`
- `System.Runtime.Serialization.Formatters.Binary.NameInfo`
- `System.Runtime.Serialization.Formatters.Binary.ObjectMap`
- `System.Runtime.Serialization.Formatters.Binary.ObjectMapInfo`
- `System.Runtime.Serialization.Formatters.Binary.ObjectNull`
- `System.Runtime.Serialization.Formatters.Binary.ObjectProgress`
- `System.Runtime.Serialization.Formatters.Binary.ObjectReader`
- `System.Runtime.Serialization.Formatters.Binary.ObjectWriter`
- `System.Runtime.Serialization.Formatters.Binary.ParseRecord`
- `System.Runtime.Serialization.Formatters.Binary.PrimitiveArray`
- `System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo`
- `System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache`
- `System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit`
- `System.Runtime.Serialization.Formatters.Binary.SerStack`
- `System.Runtime.Serialization.Formatters.Binary.SerializationHeaderRecord`
- `System.Runtime.Serialization.Formatters.Binary.SizedArray`
- `System.Runtime.Serialization.Formatters.Binary.TypeInformation`
- `System.Runtime.Serialization.Formatters.Binary.ValueFixup`
- `System.Runtime.Serialization.Formatters.Binary.ValueFixupEnum`
- `System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo`
- `System.Runtime.Serialization.Formatters.Binary.__BinaryParser`
- `System.Runtime.Serialization.Formatters.Binary.__BinaryWriter`
- `System.Runtime.Serialization.Formatters.FormatterAssemblyStyle`
- `System.Runtime.Serialization.Formatters.FormatterTypeStyle`
- `System.Runtime.Serialization.Formatters.TypeFilterLevel`
- `System.Runtime.Serialization.IDeserializationCallback`
- `System.Runtime.Serialization.IFormatterConverter`
- `System.Runtime.Serialization.IObjectReference`
- `System.Runtime.Serialization.ISafeSerializationData`
- `System.Runtime.Serialization.ISerializable`
- `System.Runtime.Serialization.ISerializationSurrogate`
- `System.Runtime.Serialization.ISurrogateSelector`
- `System.Runtime.Serialization.LongList`
- `System.Runtime.Serialization.MemberHolder`
- `System.Runtime.Serialization.ObjectHolder`
- `System.Runtime.Serialization.ObjectHolderList`
- `System.Runtime.Serialization.ObjectHolderListEnumerator`
- `System.Runtime.Serialization.ObjectIDGenerator`
- `System.Runtime.Serialization.ObjectManager`
- `System.Runtime.Serialization.OnDeserializedAttribute`
- `System.Runtime.Serialization.OnDeserializingAttribute`
- `System.Runtime.Serialization.OnSerializedAttribute`
- `System.Runtime.Serialization.OnSerializingAttribute`
- `System.Runtime.Serialization.OptionalFieldAttribute`
- `System.Runtime.Serialization.SafeSerializationEventArgs`
- `System.Runtime.Serialization.SafeSerializationManager`
- `System.Runtime.Serialization.SerializationBinder`
- `System.Runtime.Serialization.SerializationEntry`
- `System.Runtime.Serialization.SerializationEventHandler`
- `System.Runtime.Serialization.SerializationEvents`
- `System.Runtime.Serialization.SerializationEventsCache`
- `System.Runtime.Serialization.SerializationException`
- `System.Runtime.Serialization.SerializationFieldInfo`
- `System.Runtime.Serialization.SerializationInfo`
- `System.Runtime.Serialization.SerializationInfoEnumerator`
- `System.Runtime.Serialization.SerializationObjectManager`
- `System.Runtime.Serialization.StreamingContext`
- `System.Runtime.Serialization.StreamingContextStates`
- `System.Runtime.Serialization.SurrogateForCyclicalReference`
- `System.Runtime.Serialization.TypeLoadExceptionHolder`
- `System.Runtime.Serialization.ValueTypeFixupInfo`
- `System.Runtime.Versioning.BinaryCompatibility`
- `System.Runtime.Versioning.NonVersionableAttribute`
- `System.RuntimeArgumentHandle`
- `System.RuntimeFieldHandle`
- `System.RuntimeMethodHandle`
- `System.RuntimeType`
- `System.RuntimeTypeHandle`
- `System.SByte`
- `System.SByteEnum`
- `System.STAThreadAttribute`
- `System.Security.Cryptography.CipherMode`
- `System.Security.Cryptography.CryptographicException`
- `System.Security.Cryptography.CryptographicUnexpectedOperationException`
- `System.Security.Cryptography.KeySizes`
- `System.Security.Cryptography.MD5`
- `System.Security.Cryptography.MD5CryptoServiceProvider`
- `System.Security.Cryptography.PaddingMode`
- `System.Security.Cryptography.RNGCryptoServiceProvider`
- `System.Security.Cryptography.RandomNumberGenerator`
- `System.Security.Cryptography.Rijndael`
- `System.Security.Cryptography.RijndaelManaged`
- `System.Security.Cryptography.SHA1`
- `System.Security.Cryptography.SHA1CryptoServiceProvider`
- `System.Security.Cryptography.SHA1Internal`
- `System.Security.Policy.Evidence`
- `System.Security.Principal.IPrincipal`
- `System.Security.SecurityException`
- `System.Security.SecurityManager`
- `System.SerializableAttribute`
- `System.Single`
- `System.SmallRect`
- `System.SpanDebugView<T>`
- `System.SpanHelpers`
- `System.StackOverflowException`
- `System.String`
- `System.StringComparer`
- `System.StringComparison`
- `System.StringSplitOptions`
- `System.SystemException`
- `System.TermInfoDriver`
- `System.TermInfoNumbers`
- `System.TermInfoReader`
- `System.TermInfoStrings`
- `System.Text.ASCIIEncoding`
- `System.Text.Decoder`
- `System.Text.DecoderExceptionFallback`
- `System.Text.DecoderExceptionFallbackBuffer`
- `System.Text.DecoderFallback`
- `System.Text.DecoderFallbackBuffer`
- `System.Text.DecoderFallbackException`
- `System.Text.DecoderNLS`
- `System.Text.DecoderReplacementFallback`
- `System.Text.DecoderReplacementFallbackBuffer`
- `System.Text.Encoder`
- `System.Text.EncoderExceptionFallback`
- `System.Text.EncoderExceptionFallbackBuffer`
- `System.Text.EncoderFallback`
- `System.Text.EncoderFallbackBuffer`
- `System.Text.EncoderFallbackException`
- `System.Text.EncoderNLS`
- `System.Text.EncoderReplacementFallback`
- `System.Text.EncoderReplacementFallbackBuffer`
- `System.Text.Encoding`
- `System.Text.EncodingHelper`
- `System.Text.EncodingNLS`
- `System.Text.EncodingProvider`
- `System.Text.InternalDecoderBestFitFallback`
- `System.Text.InternalDecoderBestFitFallbackBuffer`
- `System.Text.InternalEncoderBestFitFallback`
- `System.Text.InternalEncoderBestFitFallbackBuffer`
- `System.Text.Latin1Encoding`
- `System.Text.Normalization`
- `System.Text.NormalizationCheck`
- `System.Text.NormalizationForm`
- `System.Text.StringBuilder`
- `System.Text.UTF32Encoding`
- `System.Text.UTF7Encoding`
- `System.Text.UTF8Encoding`
- `System.Text.UnicodeEncoding`
- `System.Text.ValueStringBuilder`
- `System.Text.ValueUtf8Converter`
- `System.ThreadStaticAttribute`
- `System.Threading.AbandonedMutexException`
- `System.Threading.AutoResetEvent`
- `System.Threading.CancellationCallbackCoreWorkArguments`
- `System.Threading.CancellationCallbackInfo`
- `System.Threading.CancellationToken`
- `System.Threading.CancellationTokenSource`
- `System.Threading.ContextCallback`
- `System.Threading.EventResetMode`
- `System.Threading.EventWaitHandle`
- `System.Threading.ExecutionContext`
- `System.Threading.ExecutionContextSwitcher`
- `System.Threading.IAsyncLocal`
- `System.Threading.IThreadPoolWorkItem`
- `System.Threading.Interlocked`
- `System.Threading.InternalThread`
- `System.Threading.LazyInitializer`
- `System.Threading.LazyThreadSafetyMode`
- `System.Threading.Lock`
- `System.Threading.LockHolder`
- `System.Threading.LockRecursionException`
- `System.Threading.ManualResetEvent`
- `System.Threading.ManualResetEventSlim`
- `System.Threading.Monitor`
- `System.Threading.Mutex`
- `System.Threading.NativeEventCalls`
- `System.Threading.OSSpecificSynchronizationContext`
- `System.Threading.ParameterizedThreadStart`
- `System.Threading.PlatformHelper`
- `System.Threading.QueueUserWorkItemCallback`
- `System.Threading.RegisteredWaitHandle`
- `System.Threading.SemaphoreFullException`
- `System.Threading.SemaphoreSlim`
- `System.Threading.SendOrPostCallback`
- `System.Threading.SpinLock`
- `System.Threading.SpinWait`
- `System.Threading.StackCrawlMark`
- `System.Threading.SynchronizationContext`
- `System.Threading.SynchronizationContextProperties`
- `System.Threading.SynchronizationLockException`
- `System.Threading.SystemThreading_ThreadLocalDebugView<T>`
- `System.Threading.Tasks.AsyncCausalityStatus`
- `System.Threading.Tasks.AsyncCausalityTracer`
- `System.Threading.Tasks.AwaitTaskContinuation`
- `System.Threading.Tasks.CausalityRelation`
- `System.Threading.Tasks.CausalitySynchronousWork`
- `System.Threading.Tasks.CausalityTraceLevel`
- `System.Threading.Tasks.CompletionActionInvoker`
- `System.Threading.Tasks.ContinuationTaskFromTask`
- `System.Threading.Tasks.DebuggerSupport`
- `System.Threading.Tasks.ITaskCompletionAction`
- `System.Threading.Tasks.InternalTaskOptions`
- `System.Threading.Tasks.Sources.IValueTaskSource`
- `System.Threading.Tasks.Sources.IValueTaskSource<TResult>`
- `System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags`
- `System.Threading.Tasks.Sources.ValueTaskSourceStatus`
- `System.Threading.Tasks.StackGuard`
- `System.Threading.Tasks.StandardTaskContinuation`
- `System.Threading.Tasks.SynchronizationContextAwaitTaskContinuation`
- `System.Threading.Tasks.SystemThreadingTasks_FutureDebugView<TResult>`
- `System.Threading.Tasks.SystemThreadingTasks_TaskDebugView`
- `System.Threading.Tasks.TaskCanceledException`
- `System.Threading.Tasks.TaskContinuation`
- `System.Threading.Tasks.TaskContinuationOptions`
- `System.Threading.Tasks.TaskCreationOptions`
- `System.Threading.Tasks.TaskExceptionHolder`
- `System.Threading.Tasks.TaskFactory`
- `System.Threading.Tasks.TaskScheduler`
- `System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation`
- `System.Threading.Tasks.TaskSchedulerException`
- `System.Threading.Tasks.TaskStatus`
- `System.Threading.Tasks.ThreadPoolTaskScheduler`
- `System.Threading.Tasks.UnobservedTaskExceptionEventArgs`
- `System.Threading.Tasks.VoidTaskResult`
- `System.Threading.ThreadAbortException`
- `System.Threading.ThreadHelper`
- `System.Threading.ThreadInterruptedException`
- `System.Threading.ThreadPool`
- `System.Threading.ThreadPoolGlobals`
- `System.Threading.ThreadPoolWorkQueue`
- `System.Threading.ThreadStart`
- `System.Threading.ThreadState`
- `System.Threading.ThreadStateException`
- `System.Threading.Timeout`
- `System.Threading.TimeoutHelper`
- `System.Threading.TimerCallback`
- `System.Threading.Volatile`
- `System.Threading.WaitCallback`
- `System.Threading.WaitHandle`
- `System.Threading.WaitHandleCannotBeOpenedException`
- `System.Threading.WaitOrTimerCallback`
- `System.Threading._ThreadPoolWaitCallback`
- `System.ThrowHelper`
- `System.TimeSpan`
- `System.TimeZone`
- `System.TimeZoneInfo`
- `System.TimeZoneInfoOptions`
- `System.TimeoutException`
- `System.TokenType`
- `System.Tuple`
- `System.Type`
- `System.TypeAccessException`
- `System.TypeCode`
- `System.TypeIdentifier`
- `System.TypeIdentifiers`
- `System.TypeInitializationException`
- `System.TypeLoadException`
- `System.TypeName`
- `System.TypeNameFormatFlags`
- `System.TypeNameKind`
- `System.TypeNameParser`
- `System.TypeNames`
- `System.TypeSpec`
- `System.TypedReference`
- `System.UInt16`
- `System.UInt16Enum`
- `System.UInt32`
- `System.UInt32Enum`
- `System.UInt64`
- `System.UInt64Enum`
- `System.UIntPtr`
- `System.UnauthorizedAccessException`
- `System.UnhandledExceptionEventArgs`
- `System.UnhandledExceptionEventHandler`
- `System.UnitySerializationHolder`
- `System.ValueType`
- `System.Variant`
- `System.Version`
- `System.Void`
- `System.WeakReference`
- `System.WindowsConsoleDriver`
- `System.__ComObject`
- `System.__DTString`
- `Task.<>c` (compiler-generated name)
- `Task.ContingentProperties`
- `Task.DelayPromise`
- `Task.SetOnInvokeMres`
- `TaskAwaiter.<>c__DisplayClass11_0` (compiler-generated name)
- `TaskFactory.CompleteOnInvokePromise`
- `TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView`
- `TaskSchedulerAwaitTaskContinuation.<>c` (compiler-generated name)
- `TextReader.NullTextReader`
- `TextReader.SyncTextReader`
- `TextWriter.NullTextWriter`
- `TextWriter.SyncTextWriter`
- `ThreadPoolTaskScheduler.<>c` (compiler-generated name)
- `ThreadPoolWorkQueue.QueueSegment`
- `ThreadPoolWorkQueue.WorkStealingQueue`
- `TimeSpanFormat.FormatLiterals`
- `TimeSpanFormat.Pattern`
- `TimeSpanParse.ParseFailureKind`
- `TimeSpanParse.StringParser`
- `TimeSpanParse.TTT`
- `TimeSpanParse.TimeSpanRawInfo`
- `TimeSpanParse.TimeSpanResult`
- `TimeSpanParse.TimeSpanStandardStyles`
- `TimeSpanParse.TimeSpanToken`
- `TimeSpanParse.TimeSpanTokenizer`
- `TimeZoneInfo.<>c` (compiler-generated name)
- `TimeZoneInfo.<>c__DisplayClass16_0` (compiler-generated name)
- `TimeZoneInfo.AdjustmentRule`
- `TimeZoneInfo.CachedData`
- `TimeZoneInfo.TZVersion`
- `TimeZoneInfo.TZifHead`
- `TimeZoneInfo.TZifType`
- `TimeZoneInfo.TransitionTime`
- `Timer.Scheduler`
- `Timer.TimerComparer`
- `TypeIdentifiers.Display`
- `TypeNames.ATypeName`
- `TypeSpec.DisplayNameFormat`
- `UTF32Encoding.UTF32Decoder`
- `UTF7Encoding.Decoder`
- `UTF7Encoding.DecoderUTF7Fallback`
- `UTF7Encoding.DecoderUTF7FallbackBuffer`
- `UTF7Encoding.Encoder`
- `UTF8Encoding.UTF8Decoder`
- `UTF8Encoding.UTF8Encoder`
- `UTF8Encoding.UTF8EncodingSealed`
- `UmAlQuraCalendar.DateMapping`
- `UnicodeEncoding.Decoder`
- `Unity.ThrowStub`
- `Volatile.VolatileInt32`
- `Volatile.VolatileObject`
- `string.ProbabilisticMap`
- `string.TrimType`

</details>

<details><summary>Mismatching: 42</summary>

- `<PrivateImplementationDetails>` (compiler-generated name)

  - `field declaration order/names: ['001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2', '021022D5891F99B3B525763EB77BAEC69B107268F560721F5060FCDBD4D5AAE8', '042957A0DB5FF2D38A343AC5AE5F8635B88F10C32EB87A238B1DFB4756468476', '07FA6E88C946B2528C09C16C2FB8E9CDA49AFFAFC601774C437FD9F2DF3ECE01', '0C496C9AE05419BD25256D0EF4F31AFD291119F14B8BD683BF1774F91E08659D', '0E499E7743BCDFF289B85890E4DFDD635594DB16246DC094C3C19556B6C1262C', '0F9E3C7E66CDEF5C44FA29E65CA676C480F7A2A4A067F70107FDC292C68D38B0', '1199C3B39A2FA058EFF5B3829616AE81EE2B59A51D89C107A5FA4B6FEF95DD16', '125CF2084D7EEC18DC9795BE4BAA221655C0EABAB89E90A74FB0370378A60293', '12D518BA10F3DD1A331E65FBD4C330930C0A0BD9F50F37BE0BDF596E964B9A78', '195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D8703446', '1A07BC77B9912D8D87E9B28E0167F53A9B09BB017B35A35F3913989C9440A60B', '1B9CC34A0CF8DBCC350E200673FAC4124DDAD581F1FC2C16FF9A1C0154691687', '1C4B3A80ED7AEC83916479BCE280E1258D5785D07F0EA22A5E27592ACCAE692B', '1F38DEB3F70291588D06D3830D0D4241CE0570C9F4EE8B00F606C4753EB016E2', '20CD2802EDA4ADAD1D749ABFE753256D8754EB845C973830A5556ECCAF1ADD6E', '215E3E0B11A214B3198654E87B3D953AC8FB1ABC7045AF841A7C4892624BDE49', '2403FBEA85D0741C5727760E97EF16C9BF23294F21C0F1265A4BAF7F22202A64', '24CB9F17C8326D8BB8EC908716519DF7F265AE825F0DD13BB04E03A90B07D90E', '25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A', '25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5', '2CCF4119215BDAD102DA7AD5B57E0E6CA19CC8FF5524856FC58907E824213E1F', '3444EB31231B2CCC1B05C7A44EBD1B2A009C1D9977A99B453F52E2F81DD6C32F', '3D95E4501B1964D7FCE16E3F5682A038752B462357D87343880B1E819F6163FE', '3F62692E2AD5078353EC4471A13421A61EE493294CF59DC66626A6EF9CCCD2C4', '42E1421FC2A5A6A33E964D7EB9603EB101818D858DDA09B2BC9B5A888C1C351C', '44D066BAE9848B4A4B2C31F1854666526A32D0588635569423BDA1DA303C97DF', '4623CA5867960AA898AA1F65E720CD5ECD3552542E0C6F6FB65B21D14DD1CBC2', '4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6', '493402F3E4397B2945B16273E795816C0BDF80F76F42FCAA75F3DF2E215ABC1B', '494C32E1A18F6E8AD8ED5FAB0A5AF07F801BE7AF3C936942B020918CE2953046', '4E0B9E024FA510B6F03C92D95BB204E78CDC6E3FD2EC8D35787B7BC76F0655A0', '508085E0DDEEA9CE48BFAE98CEC779F8D06301AE973555D37680D08190CAFA70', '510FDFA4743E58DD45DCDD7CB4F8509BF6294CC1D1D4958CA30A9E7604973006', '5292FD0A8E62FCCBE41F34EFE7575D097990A66FE23B3507971C5BF272A4362E', '533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA', '543172FF9822CE5240DF89FF3AD8C7FD9824F97D0EED9B1432E60345FBBDE9A9', '55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329', '56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854', '5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA', '5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456', '5EC4E50DA95A113769D73E5F7F8221A876185CEE6498ABB16FBB9F0563C15BBF', '61D639BE11384EE21CDE2B40357F4F9D80A106C97C592D18A9F4CAA442CA5D31', '62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9', '668BB69E184E0C32DC3BC488001C506C87EE5A95C7E7B6B87D24C3A6DC779956', '6708B572BDBE5D5E79701DBB9744AF74B50FED7608218F2D7BF1B5D87E5A53ED', '67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D2955', '6DC92D3617F0357376502FBA4CDD465B5423818DABE8B2CA1A06E1351F2F1C85', '71F7F6B226CBC11C8B26D506869FAE022928427389882579DB316F36FF34A096', '71F993C1E0FB950AAACBC0B9A2B0975B213EF14C8AA693F413336D46E9EAB8E9', '73F5D95C401726B2C92EC96A696BA15F0E5A5C6DD9AC6BEB3736A81772A11531', '74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B20', '74EF7306E7452D6859B6463CE496B8DF30925F69E1B2969E1F3F34BBC9C6AF04', '7543B37FA53FDE2C84F07FD39F368555966AA1C0EB2F2FD26B294D79966E290E', '78AD7906208AA1E531D0C1100062DE3D252210B1E4214061294A0BB7C94762B8', '7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D0696', '7F777906B0704EB248888E491577584D5BEBE71B375BD595A06444390B471915', '801494072CDD59E61F9AA9345A80D045378705DFDCE94902C22EAEAE049BE780', '805796429D6E812E01657F32029A8103B7C27B5203C2EFC9C0001E3EBAD7F24C', '819B40F8CF7DC49B4275955A17C10239F1BBBB3BF96E26E25ED844B96B645D7F', '8259E3EBA4D41CA02AE5322BBD280034A9C9860D9CD0D2038139FC9EBE6B6C77', '82B100804CE219CD73E155C7C6457FCF04EA539DE5B19F4736E800098714EB21', '861FD05B0EAD3D0AA9418B140CC37846BBC5F195214D90CEF42919D1E36EED10', '86BDA34D2165AC08F2DE4918B302E44205CDEA674FCA7F2C7F56D4F12D8B0C73', '8BFD94DEAAC0F168DC8B50A00AC120A113B550B68FEF344F807D503D1A6E5DED', '8C7DD76CF6FAC1893ED057E9FC91B995F9379B69E0796CAB7DE38ADAE3D2C568', '8CCE27079B32C13BB310169A6AD26AE419CDC98B7E2EFD3CC9997257F4BC1DEF', '9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115', '93B42898102ACB2421875C45676880B8A07390D8DF0E1EE85C5D1AA26964B0C6', '93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B6', '95BDE712712F10D07813AE3DEEA40D1F38E3FCF1A92CC435F17A326CC22242EB', '964889A5283FD0A3DFC8AE256721E6F67B8212FD6841AB1C821DE3134DE79B07', '96E3FDE919EC36694EFBEC22FEF80F84EE640CC5E46CED07C3E65AC04607C7D6', '9960C7FC60CDD325C8A2A00995BE7064EAC3F6295C6A5C4E797D2281846131E4', '99E66DACA3EFF94776AF1258E0E5B2F4DF2900E4EA32351B0DF37A87F2426B1F', 'A252A93D042C5E2453990C2829A425C6DD749CCDCDF13DB58C11BBC78E8D3CE9', 'A2DFDF9C2CED8BB1C0B9B06064345ACC9C22DFE5FEC9976FF061F0994451519B', 'A2EC7CB9B0FE89F9A9BEA547D773225AFE6E4535DF28325A0D6CD7A5E2D20376', 'A30E1152CFB528AE968FAC58E83BBEB3611BFDE2E6CF60B4FA9535A7D0A9B8EA', 'A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A2', 'AAF4528994DD7C464F43C131F6CD44DF41ACC18462C95877252FFC7EAC0164EF', 'B215DD70A77190680641703C6DF73729B4583E285AF8B51ACF9086655FB2D0F3', 'B21802DE889E5F4F5344C8E0D366F59B68F886F88EFE45EA5CE01534A3F5C0E5', 'B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838', 'BABD01C34E7E65E57E4C431281E782B4101CE0644A8090AD6E501F1C6CF2C9DF', 'BB425A9B43E10C921902A25D07A4317DEFF9F606A788672E1B21633C143407F0', 'C250CAD28060A4EB63B4C4A643DDA196CCD35FD2FC67FB749ADF4BAC6D62E1A0', 'C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2', 'C5733A1245383FBF067B4A9BDB41E3FB8E3A6BDEF37B3D5418F389422875783F', 'C8EC70AC5A448C3A45CF1DFCC1375BE4E80DC6793E97D5E89BD97A0DC232B2E3', 'C95D810E738DB5F591EE691CE884EED2F110D9F82B1F7A8BE6ED257FDF4CDBEB', 'C9830DF6956357ACE51CE1F82298578B36EB45A0CFDB8AEC5B9FDA7DB17E8063', 'CAF8A46B3A07E26F84FE849B57A877051A0D06194B1C057985446B64BCC6E016', 'CAFFFC9D15E4037EE8FBDB1A45DFE456F0936BDC7310F1882EAF14B706A76658', 'CE11D6DEAFFC6D6EF6030E30E7444C933E6261F32AA737064EF0446C219ECE22', 'D1A99909A2923269BB67E72C1AED693F74961BDA58360FCC133007740CEBF5F1', 'D3B16F8D71CB719B941527D5A1ADA7ED83F4EB967FEE117DDA2FE4021E1D283F', 'D503954AE2C3616EA32CEB0D66F5B2E119D03CE722773E5D7E1A8BC8F1803631', 'D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15', 'D870074914025E855AA5985A2D6778F1E277036BF9C9F03DEC61F3C496FEC35C', 'D896D464C3726A21162F271ACB711464AD07EA9C9CE78E0297FD0DE934471FA6', 'D8A29F3D197FBB54CF9F4B105AFBA6B1257ADF6449F0184F843380AAAA24639C', 'DCDCF594464B904F763D4CE53B1DBE08A47E551AE86FD5D61F63FD0C3313FDC3', 'DCE88EE5233B9D0FD0D7A6222C82BC3AEE83B15E9992F939B17AB40530DB555C', 'DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D', 'DF29A050CD2EBD9DFDC783DB1CC74D3D716DAEC1630A337EE31B9E2E03D34D2D', 'E148B2057CF0C1595155635E761FB66AAE634C40D8FABC4CE79A2DB8886525D4', 'E2C673A3A737B04369A63F1FB1A30F6E742B066E2CCCD9B1838793CBB5590598', 'E32C465157D21F39B3DBF186A98FB02185C63B0260B47247A7A5FDF2B061EAA8', 'E5F4F6214036DF103321A8A0CE30C2EF935694B4199D52BC538E7EF3F045CB92', 'E768EDCAE10BAB68BB5DF102FDBB8CF4F31B9D60159B44DA3F33ABC36388308B', 'E8588351183F6F6A7DAD54DC28357628F3C4D4B358AB92A18AE7D08B0D9B0092', 'EBE07C3718876777F609CD22058F4C3A6CCCC695F5BDE90998DC1E12E0CBE63D', 'EE415D5C3ECC6C8C19F71BCD4E03847F5A15931374A7F5BF88C24B722F04B8FE', 'EF39C5A882F9477B2A250BA257247825CEB07FC53C3C984385F2C2E5F8222431', 'EF82B163CA8252A793A6E73F57775D843C9A21F65586926EB11893FA8BB603E9', 'F0CF66F9B123DCEBB39C38C5D8E4821D4E94DB593889C506BCA0827036F1B7EB', 'F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5', 'F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8', 'F4BD8144313C3B67E191C6F3CD8B00540FF1809837C5BCA5C2FDA0D518681563', 'F7D381AF73D85950E0B064CF1AA8F14938A1F38084B46CE36AAEFE81BEF739F3', 'FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315', 'FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD', 'FD68700E95459C5E7A49C5830F8BD0A9BA4BD171252663D8066B09E7768C5C5D', 'FEC387BA57A54BB6066E4CA8A4F9C0FF9C36B9CBD6600C3683F6FB1BDB5077EB'] → ['021022D5891F99B3B525763EB77BAEC69B107268F560721F5060FCDBD4D5AAE8', '042957A0DB5FF2D38A343AC5AE5F8635B88F10C32EB87A238B1DFB4756468476', '0C496C9AE05419BD25256D0EF4F31AFD291119F14B8BD683BF1774F91E08659D', '0E499E7743BCDFF289B85890E4DFDD635594DB16246DC094C3C19556B6C1262C', '0F9E3C7E66CDEF5C44FA29E65CA676C480F7A2A4A067F70107FDC292C68D38B0', '1199C3B39A2FA058EFF5B3829616AE81EE2B59A51D89C107A5FA4B6FEF95DD16', '12D518BA10F3DD1A331E65FBD4C330930C0A0BD9F50F37BE0BDF596E964B9A78', '195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D8703446', '1B9CC34A0CF8DBCC350E200673FAC4124DDAD581F1FC2C16FF9A1C0154691687', '1C4B3A80ED7AEC83916479BCE280E1258D5785D07F0EA22A5E27592ACCAE692B', '1F38DEB3F70291588D06D3830D0D4241CE0570C9F4EE8B00F606C4753EB016E2', '2403FBEA85D0741C5727760E97EF16C9BF23294F21C0F1265A4BAF7F22202A64', '25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A', '2CCF4119215BDAD102DA7AD5B57E0E6CA19CC8FF5524856FC58907E824213E1F', '3444EB31231B2CCC1B05C7A44EBD1B2A009C1D9977A99B453F52E2F81DD6C32F', '3D95E4501B1964D7FCE16E3F5682A038752B462357D87343880B1E819F6163FE', '3F62692E2AD5078353EC4471A13421A61EE493294CF59DC66626A6EF9CCCD2C4', '42E1421FC2A5A6A33E964D7EB9603EB101818D858DDA09B2BC9B5A888C1C351C', '4623CA5867960AA898AA1F65E720CD5ECD3552542E0C6F6FB65B21D14DD1CBC2', '494C32E1A18F6E8AD8ED5FAB0A5AF07F801BE7AF3C936942B020918CE2953046', '4E0B9E024FA510B6F03C92D95BB204E78CDC6E3FD2EC8D35787B7BC76F0655A0', '508085E0DDEEA9CE48BFAE98CEC779F8D06301AE973555D37680D08190CAFA70', '510FDFA4743E58DD45DCDD7CB4F8509BF6294CC1D1D4958CA30A9E7604973006', '5292FD0A8E62FCCBE41F34EFE7575D097990A66FE23B3507971C5BF272A4362E', '543172FF9822CE5240DF89FF3AD8C7FD9824F97D0EED9B1432E60345FBBDE9A9', '56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854', '5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA', '5EC4E50DA95A113769D73E5F7F8221A876185CEE6498ABB16FBB9F0563C15BBF', '61D639BE11384EE21CDE2B40357F4F9D80A106C97C592D18A9F4CAA442CA5D31', '62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9', '64A0AD5A7BF0B569FABE66AF3006423DA81FF79CD282E8D781CD013B1FD7D5CE', '67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D2955', '6DC92D3617F0357376502FBA4CDD465B5423818DABE8B2CA1A06E1351F2F1C85', '71F7F6B226CBC11C8B26D506869FAE022928427389882579DB316F36FF34A096', '74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B20', '7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D0696', '7F777906B0704EB248888E491577584D5BEBE71B375BD595A06444390B471915', '801494072CDD59E61F9AA9345A80D045378705DFDCE94902C22EAEAE049BE780', '819B40F8CF7DC49B4275955A17C10239F1BBBB3BF96E26E25ED844B96B645D7F', '8259E3EBA4D41CA02AE5322BBD280034A9C9860D9CD0D2038139FC9EBE6B6C77', '82B100804CE219CD73E155C7C6457FCF04EA539DE5B19F4736E800098714EB21', '861FD05B0EAD3D0AA9418B140CC37846BBC5F195214D90CEF42919D1E36EED10', '86BDA34D2165AC08F2DE4918B302E44205CDEA674FCA7F2C7F56D4F12D8B0C73', '8CCE27079B32C13BB310169A6AD26AE419CDC98B7E2EFD3CC9997257F4BC1DEF', '9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115', '93B42898102ACB2421875C45676880B8A07390D8DF0E1EE85C5D1AA26964B0C6', '93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B6', '95BDE712712F10D07813AE3DEEA40D1F38E3FCF1A92CC435F17A326CC22242EB', '964889A5283FD0A3DFC8AE256721E6F67B8212FD6841AB1C821DE3134DE79B07', '96E3FDE919EC36694EFBEC22FEF80F84EE640CC5E46CED07C3E65AC04607C7D6', '9960C7FC60CDD325C8A2A00995BE7064EAC3F6295C6A5C4E797D2281846131E4', '99E66DACA3EFF94776AF1258E0E5B2F4DF2900E4EA32351B0DF37A87F2426B1F', 'A252A93D042C5E2453990C2829A425C6DD749CCDCDF13DB58C11BBC78E8D3CE9', 'A2DFDF9C2CED8BB1C0B9B06064345ACC9C22DFE5FEC9976FF061F0994451519B', 'A2EC7CB9B0FE89F9A9BEA547D773225AFE6E4535DF28325A0D6CD7A5E2D20376', 'A30E1152CFB528AE968FAC58E83BBEB3611BFDE2E6CF60B4FA9535A7D0A9B8EA', 'A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A2', 'AAF4528994DD7C464F43C131F6CD44DF41ACC18462C95877252FFC7EAC0164EF', 'B21802DE889E5F4F5344C8E0D366F59B68F886F88EFE45EA5CE01534A3F5C0E5', 'B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838', 'BABD01C34E7E65E57E4C431281E782B4101CE0644A8090AD6E501F1C6CF2C9DF', 'BB425A9B43E10C921902A25D07A4317DEFF9F606A788672E1B21633C143407F0', 'C250CAD28060A4EB63B4C4A643DDA196CCD35FD2FC67FB749ADF4BAC6D62E1A0', 'C5733A1245383FBF067B4A9BDB41E3FB8E3A6BDEF37B3D5418F389422875783F', 'C8EC70AC5A448C3A45CF1DFCC1375BE4E80DC6793E97D5E89BD97A0DC232B2E3', 'C95D810E738DB5F591EE691CE884EED2F110D9F82B1F7A8BE6ED257FDF4CDBEB', 'C9830DF6956357ACE51CE1F82298578B36EB45A0CFDB8AEC5B9FDA7DB17E8063', 'CAF8A46B3A07E26F84FE849B57A877051A0D06194B1C057985446B64BCC6E016', 'CAFFFC9D15E4037EE8FBDB1A45DFE456F0936BDC7310F1882EAF14B706A76658', 'D1A99909A2923269BB67E72C1AED693F74961BDA58360FCC133007740CEBF5F1', 'D503954AE2C3616EA32CEB0D66F5B2E119D03CE722773E5D7E1A8BC8F1803631', 'D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15', 'D896D464C3726A21162F271ACB711464AD07EA9C9CE78E0297FD0DE934471FA6', 'D8A29F3D197FBB54CF9F4B105AFBA6B1257ADF6449F0184F843380AAAA24639C', 'DCDCF594464B904F763D4CE53B1DBE08A47E551AE86FD5D61F63FD0C3313FDC3', 'DCE88EE5233B9D0FD0D7A6222C82BC3AEE83B15E9992F939B17AB40530DB555C', 'DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D', 'DF29A050CD2EBD9DFDC783DB1CC74D3D716DAEC1630A337EE31B9E2E03D34D2D', 'E2C673A3A737B04369A63F1FB1A30F6E742B066E2CCCD9B1838793CBB5590598', 'E32C465157D21F39B3DBF186A98FB02185C63B0260B47247A7A5FDF2B061EAA8', 'E5F4F6214036DF103321A8A0CE30C2EF935694B4199D52BC538E7EF3F045CB92', 'E768EDCAE10BAB68BB5DF102FDBB8CF4F31B9D60159B44DA3F33ABC36388308B', 'E8588351183F6F6A7DAD54DC28357628F3C4D4B358AB92A18AE7D08B0D9B0092', 'EBE07C3718876777F609CD22058F4C3A6CCCC695F5BDE90998DC1E12E0CBE63D', 'EE415D5C3ECC6C8C19F71BCD4E03847F5A15931374A7F5BF88C24B722F04B8FE', 'EF82B163CA8252A793A6E73F57775D843C9A21F65586926EB11893FA8BB603E9', 'F0CF66F9B123DCEBB39C38C5D8E4821D4E94DB593889C506BCA0827036F1B7EB', 'F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5', 'F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8', 'F4BD8144313C3B67E191C6F3CD8B00540FF1809837C5BCA5C2FDA0D518681563', 'F7D381AF73D85950E0B064CF1AA8F14938A1F38084B46CE36AAEFE81BEF739F3', 'FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315', 'FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD', 'FD68700E95459C5E7A49C5830F8BD0A9BA4BD171252663D8066B09E7768C5C5D', 'FEC387BA57A54BB6066E4CA8A4F9C0FF9C36B9CBD6600C3683F6FB1BDB5077EB']`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2`
  - `021022D5891F99B3B525763EB77BAEC69B107268F560721F5060FCDBD4D5AAE8: offset '0x40' → '0x0'`
  - `042957A0DB5FF2D38A343AC5AE5F8635B88F10C32EB87A238B1DFB4756468476: offset '0xea' → '0xaa'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 07FA6E88C946B2528C09C16C2FB8E9CDA49AFFAFC601774C437FD9F2DF3ECE01`
  - `0C496C9AE05419BD25256D0EF4F31AFD291119F14B8BD683BF1774F91E08659D: offset '0x12e' → '0xb6'`
  - `0E499E7743BCDFF289B85890E4DFDD635594DB16246DC094C3C19556B6C1262C: offset '0x182' → '0x10a'`
  - `0F9E3C7E66CDEF5C44FA29E65CA676C480F7A2A4A067F70107FDC292C68D38B0: offset '0x1ca' → '0x152'`
  - `1199C3B39A2FA058EFF5B3829616AE81EE2B59A51D89C107A5FA4B6FEF95DD16: offset '0x1d6' → '0x15e'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 125CF2084D7EEC18DC9795BE4BAA221655C0EABAB89E90A74FB0370378A60293`
  - `12D518BA10F3DD1A331E65FBD4C330930C0A0BD9F50F37BE0BDF596E964B9A78: offset '0x4a2' → '0x1aa'`
  - `195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D8703446: offset '0xcd6' → '0x9de'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 1A07BC77B9912D8D87E9B28E0167F53A9B09BB017B35A35F3913989C9440A60B`
  - `1B9CC34A0CF8DBCC350E200673FAC4124DDAD581F1FC2C16FF9A1C0154691687: offset '0xd60' → '0xa5e'`
  - `1C4B3A80ED7AEC83916479BCE280E1258D5785D07F0EA22A5E27592ACCAE692B: offset '0x130a' → '0x1008'`
  - `1F38DEB3F70291588D06D3830D0D4241CE0570C9F4EE8B00F606C4753EB016E2: offset '0x1472' → '0x1170'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 20CD2802EDA4ADAD1D749ABFE753256D8754EB845C973830A5556ECCAF1ADD6E`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 215E3E0B11A214B3198654E87B3D953AC8FB1ABC7045AF841A7C4892624BDE49`
  - `2403FBEA85D0741C5727760E97EF16C9BF23294F21C0F1265A4BAF7F22202A64: offset '0x14c2' → '0x119a'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 24CB9F17C8326D8BB8EC908716519DF7F265AE825F0DD13BB04E03A90B07D90E`
  - `25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A: offset '0x14de' → '0x11a6'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5`
  - `2CCF4119215BDAD102DA7AD5B57E0E6CA19CC8FF5524856FC58907E824213E1F: offset '0x2166' → '0x11f2'`
  - `3444EB31231B2CCC1B05C7A44EBD1B2A009C1D9977A99B453F52E2F81DD6C32F: offset '0x21ae' → '0x123a'`
  - `3D95E4501B1964D7FCE16E3F5682A038752B462357D87343880B1E819F6163FE: offset '0x21f6' → '0x1282'`
  - `3F62692E2AD5078353EC4471A13421A61EE493294CF59DC66626A6EF9CCCD2C4: offset '0x2206' → '0x1292'`
  - `42E1421FC2A5A6A33E964D7EB9603EB101818D858DDA09B2BC9B5A888C1C351C: offset '0x224e' → '0x12da'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 44D066BAE9848B4A4B2C31F1854666526A32D0588635569423BDA1DA303C97DF`
  - `4623CA5867960AA898AA1F65E720CD5ECD3552542E0C6F6FB65B21D14DD1CBC2: offset '0x2260' → '0x12e6'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 493402F3E4397B2945B16273E795816C0BDF80F76F42FCAA75F3DF2E215ABC1B`
  - `494C32E1A18F6E8AD8ED5FAB0A5AF07F801BE7AF3C936942B020918CE2953046: offset '0x3308' → '0x135e'`
  - `4E0B9E024FA510B6F03C92D95BB204E78CDC6E3FD2EC8D35787B7BC76F0655A0: offset '0x33b6' → '0x140c'`
  - `508085E0DDEEA9CE48BFAE98CEC779F8D06301AE973555D37680D08190CAFA70: offset '0x3d04' → '0x1d5a'`
  - `510FDFA4743E58DD45DCDD7CB4F8509BF6294CC1D1D4958CA30A9E7604973006: offset '0x3d30' → '0x1d86'`
  - `5292FD0A8E62FCCBE41F34EFE7575D097990A66FE23B3507971C5BF272A4362E: offset '0x3d78' → '0x1dce'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA`
  - `543172FF9822CE5240DF89FF3AD8C7FD9824F97D0EED9B1432E60345FBBDE9A9: offset '0x3db6' → '0x1df8'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329`
  - `56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854: offset '0x3eea' → '0x1e2c'`
  - `5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA: offset '0x691a' → '0x485c'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456`
  - `5EC4E50DA95A113769D73E5F7F8221A876185CEE6498ABB16FBB9F0563C15BBF: offset '0x696e' → '0x4890'`
  - `61D639BE11384EE21CDE2B40357F4F9D80A106C97C592D18A9F4CAA442CA5D31: offset '0x69b6' → '0x48d8'`
  - `62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9: offset '0x6a14' → '0x4936'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 668BB69E184E0C32DC3BC488001C506C87EE5A95C7E7B6B87D24C3A6DC779956`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 6708B572BDBE5D5E79701DBB9744AF74B50FED7608218F2D7BF1B5D87E5A53ED`
  - `67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D2955: offset '0x7344' → '0x4a52'`
  - `6DC92D3617F0357376502FBA4CDD465B5423818DABE8B2CA1A06E1351F2F1C85: offset '0x75cc' → '0x4cda'`
  - `71F7F6B226CBC11C8B26D506869FAE022928427389882579DB316F36FF34A096: offset '0x7614' → '0x4d22'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 71F993C1E0FB950AAACBC0B9A2B0975B213EF14C8AA693F413336D46E9EAB8E9`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 73F5D95C401726B2C92EC96A696BA15F0E5A5C6DD9AC6BEB3736A81772A11531`
  - `74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B20: offset '0x7f18' → '0x4df6'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 74EF7306E7452D6859B6463CE496B8DF30925F69E1B2969E1F3F34BBC9C6AF04`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 7543B37FA53FDE2C84F07FD39F368555966AA1C0EB2F2FD26B294D79966E290E`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 78AD7906208AA1E531D0C1100062DE3D252210B1E4214061294A0BB7C94762B8`
  - `7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D0696: offset '0x81f0' → '0x4f16'`
  - `7F777906B0704EB248888E491577584D5BEBE71B375BD595A06444390B471915: offset '0x87b0' → '0x54d6'`
  - `801494072CDD59E61F9AA9345A80D045378705DFDCE94902C22EAEAE049BE780: offset '0x87f8' → '0x551e'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 805796429D6E812E01657F32029A8103B7C27B5203C2EFC9C0001E3EBAD7F24C`
  - `819B40F8CF7DC49B4275955A17C10239F1BBBB3BF96E26E25ED844B96B645D7F: offset '0x8918' → '0x5620'`
  - `8259E3EBA4D41CA02AE5322BBD280034A9C9860D9CD0D2038139FC9EBE6B6C77: offset '0x8920' → '0x5628'`
  - `82B100804CE219CD73E155C7C6457FCF04EA539DE5B19F4736E800098714EB21: offset '0x8968' → '0x5670'`
  - `861FD05B0EAD3D0AA9418B140CC37846BBC5F195214D90CEF42919D1E36EED10: offset '0x8970' → '0x5678'`
  - `86BDA34D2165AC08F2DE4918B302E44205CDEA674FCA7F2C7F56D4F12D8B0C73: offset '0x89b8' → '0x56c0'`
  - `missing field static long 8BFD94DEAAC0F168DC8B50A00AC120A113B550B68FEF344F807D503D1A6E5DED`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 8C7DD76CF6FAC1893ED057E9FC91B995F9379B69E0796CAB7DE38ADAE3D2C568`
  - `8CCE27079B32C13BB310169A6AD26AE419CDC98B7E2EFD3CC9997257F4BC1DEF: offset '0x8dd8' → '0x5aa6'`
  - `9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115: offset '0x9459' → '0x6127'`
  - `93B42898102ACB2421875C45676880B8A07390D8DF0E1EE85C5D1AA26964B0C6: offset '0xab99' → '0x7867'`
  - `93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B6: offset '0xace9' → '0x79b7'`
  - `95BDE712712F10D07813AE3DEEA40D1F38E3FCF1A92CC435F17A326CC22242EB: offset '0xad1d' → '0x79eb'`
  - `964889A5283FD0A3DFC8AE256721E6F67B8212FD6841AB1C821DE3134DE79B07: offset '0xadcb' → '0x7a99'`
  - `96E3FDE919EC36694EFBEC22FEF80F84EE640CC5E46CED07C3E65AC04607C7D6: offset '0xaed1' → '0x7b9f'`
  - `9960C7FC60CDD325C8A2A00995BE7064EAC3F6295C6A5C4E797D2281846131E4: offset '0xaee0' → '0x7bae'`
  - `99E66DACA3EFF94776AF1258E0E5B2F4DF2900E4EA32351B0DF37A87F2426B1F: offset '0xaf04' → '0x7bd2'`
  - `A252A93D042C5E2453990C2829A425C6DD749CCDCDF13DB58C11BBC78E8D3CE9: offset '0xaf30' → '0x7bfe'`
  - `A2DFDF9C2CED8BB1C0B9B06064345ACC9C22DFE5FEC9976FF061F0994451519B: offset '0xaf78' → '0x7c46'`
  - `A2EC7CB9B0FE89F9A9BEA547D773225AFE6E4535DF28325A0D6CD7A5E2D20376: offset '0xaff0' → '0x7cbe'`
  - `A30E1152CFB528AE968FAC58E83BBEB3611BFDE2E6CF60B4FA9535A7D0A9B8EA: offset '0xb03c' → '0x7d0a'`
  - `A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A2: offset '0xb084' → '0x7d52'`
  - `AAF4528994DD7C464F43C131F6CD44DF41ACC18462C95877252FFC7EAC0164EF: offset '0xb0ac' → '0x7d7a'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B215DD70A77190680641703C6DF73729B4583E285AF8B51ACF9086655FB2D0F3`
  - `B21802DE889E5F4F5344C8E0D366F59B68F886F88EFE45EA5CE01534A3F5C0E5: offset '0xc0f4' → '0x7dc2'`
  - `B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838: offset '0xc128' → '0x7df6'`
  - `BABD01C34E7E65E57E4C431281E782B4101CE0644A8090AD6E501F1C6CF2C9DF: offset '0xc9a8' → '0x8676'`
  - `BB425A9B43E10C921902A25D07A4317DEFF9F606A788672E1B21633C143407F0: offset '0xc9cc' → '0x869a'`
  - `C250CAD28060A4EB63B4C4A643DDA196CCD35FD2FC67FB749ADF4BAC6D62E1A0: offset '0xc9dc' → '0x86aa'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2`
  - `C5733A1245383FBF067B4A9BDB41E3FB8E3A6BDEF37B3D5418F389422875783F: offset '0xcb00' → '0x86ce'`
  - `C8EC70AC5A448C3A45CF1DFCC1375BE4E80DC6793E97D5E89BD97A0DC232B2E3: offset '0xcb48' → '0x8716'`
  - `C95D810E738DB5F591EE691CE884EED2F110D9F82B1F7A8BE6ED257FDF4CDBEB: offset '0xcf48' → '0x8b16'`
  - `C9830DF6956357ACE51CE1F82298578B36EB45A0CFDB8AEC5B9FDA7DB17E8063: offset '0xcf58' → '0x8b26'`
  - `CAF8A46B3A07E26F84FE849B57A877051A0D06194B1C057985446B64BCC6E016: offset '0xcfda' → '0x8ba8'`
  - `CAFFFC9D15E4037EE8FBDB1A45DFE456F0936BDC7310F1882EAF14B706A76658: offset '0xd022' → '0x8bf0'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 CE11D6DEAFFC6D6EF6030E30E7444C933E6261F32AA737064EF0446C219ECE22`
  - `D1A99909A2923269BB67E72C1AED693F74961BDA58360FCC133007740CEBF5F1: offset '0xe046' → '0x8c14'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 D3B16F8D71CB719B941527D5A1ADA7ED83F4EB967FEE117DDA2FE4021E1D283F`
  - `D503954AE2C3616EA32CEB0D66F5B2E119D03CE722773E5D7E1A8BC8F1803631: offset '0xe094' → '0x8c5c'`
  - `D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15: offset '0xe0dc' → '0x8ca4'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 D870074914025E855AA5985A2D6778F1E277036BF9C9F03DEC61F3C496FEC35C`
  - `D896D464C3726A21162F271ACB711464AD07EA9C9CE78E0297FD0DE934471FA6: offset '0xe988' → '0x8d50'`
  - `D8A29F3D197FBB54CF9F4B105AFBA6B1257ADF6449F0184F843380AAAA24639C: offset '0xe994' → '0x8d5c'`
  - `DCDCF594464B904F763D4CE53B1DBE08A47E551AE86FD5D61F63FD0C3313FDC3: offset '0xe9dc' → '0x8da4'`
  - `DCE88EE5233B9D0FD0D7A6222C82BC3AEE83B15E9992F939B17AB40530DB555C: offset '0xea24' → '0x8dec'`
  - `DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D: offset '0xf352' → '0x971a'`
  - `DF29A050CD2EBD9DFDC783DB1CC74D3D716DAEC1630A337EE31B9E2E03D34D2D: offset '0xf3ea' → '0x97b2'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 E148B2057CF0C1595155635E761FB66AAE634C40D8FABC4CE79A2DB8886525D4`
  - `E2C673A3A737B04369A63F1FB1A30F6E742B066E2CCCD9B1838793CBB5590598: offset '0x10432' → '0x97fa'`
  - `E32C465157D21F39B3DBF186A98FB02185C63B0260B47247A7A5FDF2B061EAA8: offset '0x10458' → '0x9820'`
  - `E5F4F6214036DF103321A8A0CE30C2EF935694B4199D52BC538E7EF3F045CB92: offset '0x10464' → '0x982c'`
  - `E768EDCAE10BAB68BB5DF102FDBB8CF4F31B9D60159B44DA3F33ABC36388308B: offset '0x1047c' → '0x9844'`
  - `E8588351183F6F6A7DAD54DC28357628F3C4D4B358AB92A18AE7D08B0D9B0092: offset '0x104bc' → '0x9884'`
  - `EBE07C3718876777F609CD22058F4C3A6CCCC695F5BDE90998DC1E12E0CBE63D: offset '0x108b6' → '0x9c7e'`
  - `EE415D5C3ECC6C8C19F71BCD4E03847F5A15931374A7F5BF88C24B722F04B8FE: offset '0x108c2' → '0x9c8a'`
  - `missing field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EF39C5A882F9477B2A250BA257247825CEB07FC53C3C984385F2C2E5F8222431`
  - `EF82B163CA8252A793A6E73F57775D843C9A21F65586926EB11893FA8BB603E9: offset '0x109e2' → '0x9caa'`
  - `F0CF66F9B123DCEBB39C38C5D8E4821D4E94DB593889C506BCA0827036F1B7EB: offset '0x109f2' → '0x9cba'`
  - `F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5: offset '0x10ae2' → '0x9daa'`
  - `F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8: offset '0x10ae5' → '0x9dad'`
  - `F4BD8144313C3B67E191C6F3CD8B00540FF1809837C5BCA5C2FDA0D518681563: offset '0x10be5' → '0x9ead'`
  - `F7D381AF73D85950E0B064CF1AA8F14938A1F38084B46CE36AAEFE81BEF739F3: offset '0x10c2d' → '0x9ef5'`
  - `FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315: offset '0x10d01' → '0x9fc9'`
  - `FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD: offset '0x10d35' → '0x9ffd'`
  - `FD68700E95459C5E7A49C5830F8BD0A9BA4BD171252663D8066B09E7768C5C5D: offset '0x111ed' → '0xa4b5'`
  - `FEC387BA57A54BB6066E4CA8A4F9C0FF9C36B9CBD6600C3683F6FB1BDB5077EB: offset '0x112dd' → '0xa5a5'`
  - `extra field static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 64A0AD5A7BF0B569FABE66AF3006423DA81FF79CD282E8D781CD013B1FD7D5CE`

- `CancellationTokenSource.LinkedNCancellationTokenSource`

  - `field declaration order/names: ['s_linkedTokenCancelDelegate', '_linkingRegistrations'] → ['s_linkedTokenCancelDelegate']`
  - `missing field instance CancellationTokenRegistration[] _linkingRegistrations`

- `DynamicPropertyCollection.DynamicPropertyReg`

  - `field declaration order/names: ['Sink'] → ['Property', 'Sink']`
  - `Sink: offset '0x10' → '0x18'`
  - `extra field instance IDynamicProperty Property`

- `Path.<>c` (compiler-generated name)

  - `field declaration order/names: ['<>9', '<>9__56_0', '<>9__57_0'] → ['<>9', '<>9__56_0']`
  - `missing field static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>> <>9__57_0`

- `ResourceManager.CultureNameResourceSetPair`

  - `field declaration order/names: ['lastCultureName', 'lastResourceSet'] → []`
  - `missing field instance string lastCultureName`
  - `missing field instance ResourceSet lastResourceSet`

- `System.AppContextSwitches`

  - `field declaration order/names: ['SetActorAsReferenceWhenCopyingClaimsIdentity', 'NoAsyncCurrentCulture', 'EnforceJapaneseEraYearRanges', 'FormatJapaneseFirstYearAsANumber', 'EnforceLegacyJapaneseDateParsing'] → ['EnforceJapaneseEraYearRanges', 'FormatJapaneseFirstYearAsANumber', 'EnforceLegacyJapaneseDateParsing']`
  - `missing field static bool SetActorAsReferenceWhenCopyingClaimsIdentity`
  - `missing field static bool NoAsyncCurrentCulture`
  - `EnforceJapaneseEraYearRanges: offset '0x2' → '0x0'`
  - `FormatJapaneseFirstYearAsANumber: offset '0x3' → '0x1'`
  - `EnforceLegacyJapaneseDateParsing: offset '0x4' → '0x2'`

- `System.DateTimeParse`

  - `field declaration order/names: ['m_hebrewNumberParser', 'dateParsingStates'] → ['dateParsingStates']`
  - `missing field static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser`
  - `dateParsingStates: offset '0x8' → '0x0'`

- `System.Diagnostics.Tracing.EventAttribute`

  - `field declaration order/names: ['<EventId>k__BackingField', '<Level>k__BackingField', '<Keywords>k__BackingField', '<Message>k__BackingField'] → ['<EventId>k__BackingField', '<Level>k__BackingField']`
  - `missing field instance EventKeywords <Keywords>k__BackingField`
  - `missing field instance string <Message>k__BackingField`

- `System.Diagnostics.Tracing.EventSource`

  - `field declaration order/names: ['<Name>k__BackingField', '<Settings>k__BackingField'] → ['<Name>k__BackingField']`
  - `missing field instance EventSourceSettings <Settings>k__BackingField`

- `System.Environment`

  - `field declaration order/names: ['mono_corlib_version', 'nl', 'os'] → ['mono_corlib_version', 'nl']`
  - `missing field static OperatingSystem os`

- `System.Globalization.CalendarData`

  - `field declaration order/names: ['sNativeName', 'saShortDates', 'saYearMonths', 'saLongDates', 'sMonthDay', 'saEraNames', 'saAbbrevEraNames', 'saAbbrevEnglishEraNames', 'saDayNames', 'saAbbrevDayNames', 'saSuperShortDayNames', 'saMonthNames', 'saAbbrevMonthNames', 'saMonthGenitiveNames', 'saAbbrevMonthGenitiveNames', 'saLeapYearMonthNames', 'iTwoDigitYearMax', 'iCurrentEra', 'bUseUserOverrides', 'Invariant', 'HEBREW_MONTH_NAMES', 'HEBREW_LEAP_MONTH_NAMES'] → ['MAX_CALENDARS', 'sNativeName', 'saShortDates', 'saYearMonths', 'saLongDates', 'sMonthDay', 'saEraNames', 'saAbbrevEraNames', 'saAbbrevEnglishEraNames', 'saDayNames', 'saAbbrevDayNames', 'saSuperShortDayNames', 'saMonthNames', 'saAbbrevMonthNames', 'saMonthGenitiveNames', 'saAbbrevMonthGenitiveNames', 'saLeapYearMonthNames', 'iTwoDigitYearMax', 'iCurrentEra', 'bUseUserOverrides', 'Invariant', 'HEBREW_MONTH_NAMES', 'HEBREW_LEAP_MONTH_NAMES']`
  - `extra field constant int MAX_CALENDARS`

- `System.Globalization.CodePageDataItem`

  - `field declaration order/names: ['m_dataIndex', 'm_uiFamilyCodePage', 'm_webName', 'm_headerName', 'm_flags', 'sep'] → ['m_dataIndex', 'm_uiFamilyCodePage', 'm_flags', 'sep']`
  - `missing field instance string m_webName`
  - `missing field instance string m_headerName`
  - `m_flags: offset '0x28' → '0x18'`

- `System.IO.BinaryWriter`

  - `bases: 'IDisposable, IAsyncDisposable' → 'IDisposable'`

- `System.IO.FileStreamAsyncResult`

  - `field declaration order/names: ['state', 'completed', 'wh', 'cb', 'completedSynch', 'Count', 'OriginalCount', 'BytesRead', 'realcb'] → ['state', 'wh', 'cb', 'completedSynch', 'Count', 'OriginalCount', 'BytesRead', 'realcb']`
  - `missing field instance bool completed`
  - `wh: offset '0x20' → '0x18'`
  - `cb: offset '0x28' → '0x20'`
  - `completedSynch: offset '0x30' → '0x28'`
  - `Count: offset '0x34' → '0x2c'`
  - `OriginalCount: offset '0x38' → '0x30'`
  - `BytesRead: offset '0x3c' → '0x34'`
  - `realcb: offset '0x40' → '0x38'`

- `System.IO.Stream`

  - `bases: 'MarshalByRefObject, IDisposable, IAsyncDisposable' → 'MarshalByRefObject, IDisposable'`

- `System.IO.TextWriter`

  - `bases: 'MarshalByRefObject, IDisposable, IAsyncDisposable' → 'MarshalByRefObject, IDisposable'`

- `System.ITupleInternal`

  - `bases: 'ITuple' → ''`

- `System.LocalDataStore`

  - `field declaration order/names: [] → ['m_DataTable', 'm_Manager']`
  - `extra field instance LocalDataStoreElement[] m_DataTable`
  - `extra field instance LocalDataStoreMgr m_Manager`

- `System.LocalDataStoreHolder`

  - `field declaration order/names: [] → ['m_Store']`
  - `extra field instance LocalDataStore m_Store`

- `System.LocalDataStoreMgr`

  - `field declaration order/names: ['m_SlotInfoTable', 'm_ManagedLocalDataStores', 'm_KeyToSlotMap'] → ['m_SlotInfoTable', 'm_FirstAvailableSlot', 'm_ManagedLocalDataStores', 'm_KeyToSlotMap', 'm_CookieGenerator']`
  - `m_ManagedLocalDataStores: offset '0x18' → '0x20'`
  - `m_KeyToSlotMap: offset '0x20' → '0x28'`
  - `extra field instance int m_FirstAvailableSlot`
  - `extra field instance long m_CookieGenerator`

- `System.LocalDataStoreSlot`

  - `field declaration order/names: [] → ['m_mgr', 'm_slot', 'm_cookie']`
  - `extra field instance LocalDataStoreMgr m_mgr`
  - `extra field instance int m_slot`
  - `extra field instance long m_cookie`

- `System.Reflection.MemberInfo`

  - `bases: 'ICustomAttributeProvider, _MemberInfo' → 'ICustomAttributeProvider'`

- `System.Reflection.TypeInfo`

  - `bases: 'Type, IReflectableType' → 'Type'`

- `System.Resources.ResourceManager`

  - `field declaration order/names: ['BaseNameField', 'ResourceSets', '_resourceSets', 'moduleDir', 'MainAssembly', '_locationInfo', '_userResourceSet', '_neutralResourcesCulture', '_lastUsedResourceCache', '_ignoreCase', 'UseManifest', 'UseSatelliteAssem', '_fallbackLoc', '_satelliteContractVersion', '_lookedForSatelliteContractVersion', '_callingAssembly', 'm_callingAssembly', 'resourceGroveler', 'MagicNumber', 'HeaderVersionNumber', '_minResourceSet', 'ResReaderTypeName', 'ResSetTypeName', 'MscorlibName', 'DEBUG'] → ['ResourceSets', '_resourceSets', 'MainAssembly', '_neutralResourcesCulture', '_lastUsedResourceCache', 'UseManifest', 'UseSatelliteAssem', '_fallbackLoc', '_callingAssembly', 'm_callingAssembly', 'resourceGroveler', 'MagicNumber', 'HeaderVersionNumber', '_minResourceSet', 'ResReaderTypeName', 'ResSetTypeName', 'MscorlibName', 'DEBUG']`
  - `missing field instance string BaseNameField`
  - `ResourceSets: offset '0x18' → '0x10'`
  - `_resourceSets: offset '0x20' → '0x18'`
  - `missing field instance string moduleDir`
  - `MainAssembly: offset '0x30' → '0x20'`
  - `missing field instance Type _locationInfo`
  - `missing field instance Type _userResourceSet`
  - `_neutralResourcesCulture: offset '0x48' → '0x28'`
  - `_lastUsedResourceCache: offset '0x50' → '0x30'`
  - `missing field instance bool _ignoreCase`
  - `UseManifest: offset '0x59' → '0x38'`
  - `UseSatelliteAssem: offset '0x5a' → '0x39'`
  - `_fallbackLoc: offset '0x5c' → '0x3c'`
  - `missing field instance Version _satelliteContractVersion`
  - `missing field instance bool _lookedForSatelliteContractVersion`
  - `_callingAssembly: offset '0x70' → '0x40'`
  - `m_callingAssembly: offset '0x78' → '0x48'`
  - `resourceGroveler: offset '0x80' → '0x50'`

- `System.Resources.RuntimeResourceSet`

  - `field declaration order/names: ['_resCache', '_defaultReader', '_caseInsensitiveTable', '_haveReadFromReader'] → ['Version', '_resCache', '_defaultReader', '_caseInsensitiveTable', '_haveReadFromReader']`
  - `extra field constant int Version`

- `System.Security.Cryptography.CryptoConfig`

  - `field declaration order/names: ['lockObject', 'algorithms'] → ['lockObject']`
  - `missing field static Dictionary<string, Type> algorithms`

- `System.Security.Cryptography.HashAlgorithm`

  - `bases: 'IDisposable, ICryptoTransform' → 'IDisposable'`

- `System.Security.Cryptography.SymmetricAlgorithm`

  - `bases: 'IDisposable' → ''`
  - `field declaration order/names: ['BlockSizeValue', 'FeedbackSizeValue', 'IVValue', 'KeyValue', 'LegalBlockSizesValue', 'LegalKeySizesValue', 'KeySizeValue', 'ModeValue', 'PaddingValue'] → []`
  - `missing field instance int BlockSizeValue`
  - `missing field instance int FeedbackSizeValue`
  - `missing field instance byte[] IVValue`
  - `missing field instance byte[] KeyValue`
  - `missing field instance KeySizes[] LegalBlockSizesValue`
  - `missing field instance KeySizes[] LegalKeySizesValue`
  - `missing field instance int KeySizeValue`
  - `missing field instance CipherMode ModeValue`
  - `missing field instance PaddingMode PaddingValue`

- `System.Threading.AsyncLocal<T>`

  - `bases: 'IAsyncLocal' → ''`
  - `field declaration order/names: ['m_valueChangedHandler'] → []`
  - `missing field instance Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.CancellationTokenRegistration`

  - `bases: 'IEquatable<CancellationTokenRegistration>, IDisposable, IAsyncDisposable' → 'IEquatable<CancellationTokenRegistration>, IDisposable'`

- `System.Threading.Tasks.Task<TResult>`

  - `field declaration order/names: ['m_result', 's_defaultFactory'] → ['m_result']`
  - `missing field static TaskFactory<TResult> s_defaultFactory`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.Tasks.TaskCompletionSource<TResult>`

  - `field declaration order/names: ['_task'] → []`
  - `missing field instance Task<TResult> _task`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.Tasks.TaskFactory<TResult>`

  - `field declaration order/names: ['m_defaultCancellationToken', 'm_defaultScheduler', 'm_defaultCreationOptions', 'm_defaultContinuationOptions'] → []`
  - `missing field instance CancellationToken m_defaultCancellationToken`
  - `missing field instance TaskScheduler m_defaultScheduler`
  - `missing field instance TaskCreationOptions m_defaultCreationOptions`
  - `missing field instance TaskContinuationOptions m_defaultContinuationOptions`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.Timer`

  - `bases: 'MarshalByRefObject, IDisposable, IAsyncDisposable' → 'MarshalByRefObject, IDisposable'`

- `System.Tuple<T1, T2, T3>`

  - `bases: 'IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple' → 'IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple`

  - `bases: 'IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>'`

- `System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>`

  - `bases: 'IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple<T1, T2, T3, T4, T5, T6>`

  - `bases: 'IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple<T1, T2, T3, T4, T5>`

  - `bases: 'IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple<T1, T2, T3, T4>`

  - `bases: 'IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple<T1, T2, T3>`

  - `bases: 'IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ValueTuple<T1, T2>`

  - `bases: 'IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple' → 'IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>'`
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Indeterminate: 84</summary>

- `Array.EmptyInternalEnumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Array.InternalEnumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ArrayMemoryPool.ArrayMemoryPoolBuffer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentDictionary.DictionaryEnumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentDictionary.Node<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentDictionary.Tables<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentQueue.<Enumerate>d__28<T>` (compiler-generated name)

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentQueue.Segment.Slot<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConcurrentQueue.Segment<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConditionalWeakTable.Enumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.Entry<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.Enumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.KeyCollection.Enumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.KeyCollection<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.ValueCollection.Enumerator<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Dictionary.ValueCollection<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `List.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LowLevelDictionary.Entry<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `LowLevelListWithIList.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Mono.ValueTuple<T1, T2, T3, T4, T5>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Mono.ValueTuple<T1, T2, T3, T4>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Mono.ValueTuple<T1, T2, T3>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Mono.ValueTuple<T1, T2>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Mono.ValueTuple<T1>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Queue.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `RuntimeType.ListBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Stack.Enumerator<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.AppDomain`

  - Limitation: type_resolve_in_progress: no comparable storage offset
  - Limitation: assembly_resolve_in_progress: no comparable storage offset
  - Limitation: assembly_resolve_in_progress_refonly: no comparable storage offset

- `System.Buffers.ArrayPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Buffers.MemoryPool<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Buffers.TlsOverPerCoreLockedStacksArrayPool<T>`

  - Limitation: t_tlsBuckets: no comparable storage offset
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ByReference<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Concurrent.ConcurrentQueue<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.ArraySortHelper<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.ArraySortHelper<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.Comparer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.Dictionary<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.EqualityComparer<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.KeyValuePair<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.List<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.LowLevelDictionary<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.LowLevelList<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.Queue<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.Stack<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.Generic.ValueListBuilder<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.ObjectModel.Collection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Collections.ObjectModel.ReadOnlyCollection<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.EmptyArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Lazy<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Memory<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.MonoCustomAttrs`

  - Limitation: usage_cache: no comparable storage offset

- `System.Nullable<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Numerics.Vector<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ParameterizedStrings`

  - Limitation: _cachedStack: no comparable storage offset

- `System.Random`

  - Limitation: t_threadRandom: no comparable storage offset

- `System.ReadOnlyMemory<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.ReadOnlySpan<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Runtime.CompilerServices.TaskAwaiter<TResult>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Span<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Text.StringBuilderCache`

  - Limitation: t_cachedInstance: no comparable storage offset

- `System.Threading.SparselyPopulatedArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.SparselyPopulatedArrayAddInfo<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.SparselyPopulatedArrayFragment<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.Tasks.Task`

  - Limitation: t_currentTask: no comparable storage offset
  - Limitation: t_stackGuard: no comparable storage offset

- `System.Threading.Thread`

  - Limitation: s_LocalDataStore: no comparable storage offset
  - Limitation: m_CurrentCulture: no comparable storage offset
  - Limitation: m_CurrentUICulture: no comparable storage offset
  - Limitation: current_thread: no comparable storage offset

- `System.Threading.ThreadLocal<T>`

  - Limitation: ts_slotArray: no comparable storage offset
  - Limitation: ts_finalizationHelper: no comparable storage offset
  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `System.Threading.ThreadPoolWorkQueueThreadLocals`

  - Limitation: threadLocals: no comparable storage offset

- `System.WeakReference<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TaskFactory.FromAsyncTrimPromise<TResult, TInstance>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThreadLocal.FinalizationHelper<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThreadLocal.IdManager<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThreadLocal.LinkedSlot<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThreadLocal.LinkedSlotVolatile<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `ThreadPoolWorkQueue.SparseArray<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TlsOverPerCoreLockedStacksArrayPool.LockedStack<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts

- `Vector.VectorSizeHelper<T>`

  - Limitation: generic definition offsets do not establish concrete generic-instance layouts


</details>

<details><summary>Missing: 347</summary>

- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=10`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=20`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=48`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=56`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6`
- `<PrivateImplementationDetails>.__StaticArrayInitTypeSize=640`
- `AppContext.SwitchValueState`
- `ArrayList.IListWrapper`
- `ArrayList.ReadOnlyArrayList`
- `ArraySegment.Enumerator<T>`
- `BigInteger.Kernel`
- `BigInteger.ModulusRing`
- `BigInteger.Sign`
- `ClaimsIdentity.<get_Claims>d__51` (compiler-generated name)
- `ConfiguredTaskAwaitable.ConfiguredTaskAwaiter`
- `ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter`
- `ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult>`
- `CryptoStream.<>c` (compiler-generated name)
- `CryptoStream.<ReadAsyncCore>d__42` (compiler-generated name)
- `CryptoStream.<ReadAsyncInternal>d__37` (compiler-generated name)
- `CryptoStream.<WriteAsyncCore>d__49` (compiler-generated name)
- `CryptoStream.<WriteAsyncInternal>d__46` (compiler-generated name)
- `DSAManaged.KeyGeneratedEventHandler`
- `DateTimeParse.<>c` (compiler-generated name)
- `DateTimeParse.MatchNumberDelegate`
- `Decimal.DecCalc.Buf12`
- `Decimal.DecCalc.Buf16`
- `Environment.SpecialFolder`
- `Environment.SpecialFolderOption`
- `File.<InternalWriteAllBytesAsync>d__74` (compiler-generated name)
- `FileSystemEntry.<_fileNameBuffer>e__FixedBuffer` (compiler-generated name)
- `FileSystemEnumerable.DelegateEnumerator<TResult>`
- `FileSystemEnumerable.FindPredicate<TResult>`
- `FileSystemEnumerable.FindTransform<TResult>`
- `FileSystemEnumerableFactory.<>c` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass3_0` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass4_0` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass5_0` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass6_0` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass7_0` (compiler-generated name)
- `FileSystemEnumerableFactory.<>c__DisplayClass8_0` (compiler-generated name)
- `FormattableStringFactory.ConcreteFormattableString`
- `FormattingHelpers.HexCasing`
- `Hashtable.SyncHashtable`
- `Internal.Cryptography.Helpers`
- `Interop.Sys.Permissions`
- `InteropErrorExtensions`
- `ListDictionaryInternal.DictionaryNode`
- `ListDictionaryInternal.NodeEnumerator`
- `ListDictionaryInternal.NodeKeyValueCollection`
- `ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator`
- `Marshal.SecureStringAllocator`
- `MemoryMarshal.<ToEnumerable>d__14<T>` (compiler-generated name)
- `Microsoft.Win32.SafeHandles.SafeHandleCache<T>`
- `Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid`
- `Microsoft.Win32.SafeHandles.SafePasswordHandle`
- `Mono.CertificateImportFlags`
- `Mono.DependencyInjector`
- `Mono.ISystemCertificateProvider`
- `Mono.ISystemDependencyProvider`
- `Mono.Math.BigInteger`
- `Mono.Math.Prime.ConfidenceFactor`
- `Mono.Math.Prime.Generator.PrimeGeneratorBase`
- `Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase`
- `Mono.Math.Prime.PrimalityTest`
- `Mono.Math.Prime.PrimalityTests`
- `Mono.Security.ASN1`
- `Mono.Security.Cryptography.DSAManaged`
- `Mono.Security.Cryptography.KeyBuilder`
- `Mono.Security.Cryptography.KeyPairPersistence`
- `Mono.Security.Cryptography.MD2`
- `Mono.Security.Cryptography.MD2Managed`
- `Mono.Security.Cryptography.MD4`
- `Mono.Security.Cryptography.MD4Managed`
- `Mono.Security.Cryptography.PKCS1`
- `Mono.Security.Cryptography.RSAManaged`
- `Mono.Security.Cryptography.SymmetricTransform`
- `Mono.Xml.SecurityParser`
- `RSAManaged.KeyGeneratedEventHandler`
- `ReadOnlyDictionary.DictionaryEnumerator<TKey, TValue>`
- `ReadOnlyDictionary.KeyCollection<TKey, TValue>`
- `ReadOnlyDictionary.ValueCollection<TKey, TValue>`
- `ReadOnlySequence.<>c<T>` (compiler-generated name)
- `ReadOnlySequence.Enumerator<T>`
- `ReadOnlySequence.SequenceType<T>`
- `ResourceFallbackManager.<GetEnumerator>d__5` (compiler-generated name)
- `RuntimeAssembly.UnmanagedMemoryStreamForModule`
- `SecurityElement.SecurityAttribute`
- `SortedList.KeyList`
- `SortedList.SortedListDebugView`
- `SortedList.SortedListEnumerator`
- `SortedList.SyncSortedList`
- `SortedList.ValueList`
- `Stream.<<ReadAsync>g__FinishReadAsync&#124;44_0>d` (compiler-generated name)
- `Stream.<CopyToAsyncInternal>d__28` (compiler-generated name)
- `Stream.<FinishWriteAsync>d__57` (compiler-generated name)
- `StreamReader.<ReadAsyncInternal>d__66` (compiler-generated name)
- `StreamReader.<ReadBufferAsync>d__69` (compiler-generated name)
- `StreamReader.<ReadToEndAsyncInternal>d__63` (compiler-generated name)
- `StreamWriter.<DisposeAsyncCore>d__33` (compiler-generated name)
- `StreamWriter.<FlushAsyncInternal>d__74` (compiler-generated name)
- `StreamWriter.<WriteAsyncInternal>d__59` (compiler-generated name)
- `SynchronizationContextTaskScheduler.<>c` (compiler-generated name)
- `System.AccessViolationException`
- `System.Action<T1, T2, T3, T4, T5, T6, T7>`
- `System.Action<T1, T2, T3, T4, T5>`
- `System.AppContext`
- `System.AppContextDefaultValues`
- `System.ArraySegment<T>`
- `System.Base64FormattingOptions`
- `System.Buffers.ArrayBufferWriter<T>`
- `System.Buffers.BuffersExtensions`
- `System.Buffers.IBufferWriter<T>`
- `System.Buffers.IPinnable`
- `System.Buffers.MemoryHandle`
- `System.Buffers.OperationStatus`
- `System.Buffers.ReadOnlySequence`
- `System.Buffers.ReadOnlySequence<T>`
- `System.Buffers.ReadOnlySequenceDebugView<T>`
- `System.Buffers.ReadOnlySequenceSegment<T>`
- `System.Buffers.StandardFormat`
- `System.Buffers.Text.Base64`
- `System.Buffers.Text.Number`
- `System.Buffers.Text.NumberBuffer`
- `System.Buffers.Text.Utf8Constants`
- `System.Buffers.Text.Utf8Formatter`
- `System.Collections.CollectionBase`
- `System.Collections.Generic.ArrayBuilder<T>`
- `System.Collections.Generic.CollectionDebugView<T>`
- `System.Collections.Generic.DictionaryDebugView<K, V>`
- `System.Collections.Generic.EnumerableHelpers`
- `System.Collections.Generic.LargeArrayBuilder<T>`
- `System.Collections.ListDictionaryInternal`
- `System.Collections.ObjectModel.KeyedCollection<TKey, TItem>`
- `System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>`
- `System.Collections.ObjectModel.ReadOnlyDictionaryHelpers`
- `System.Collections.ReadOnlyCollectionBase`
- `System.Collections.SortedList`
- `System.Collections.StructuralComparisons`
- `System.Collections.StructuralEqualityComparer`
- `System.DecimalDecCalc`
- `System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute`
- `System.Diagnostics.Tracing.EventSourceSettings`
- `System.Diagnostics.Tracing.NonEventAttribute`
- `System.FormattableString`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, T7, TResult>`
- `System.Func<T1, T2, T3, T4, T5, T6, TResult>`
- `System.Globalization.CalendarWeekRule`
- `System.Globalization.CultureTypes`
- `System.IAsyncDisposable`
- `System.IO.Enumeration.FileSystemEntry`
- `System.IO.Enumeration.FileSystemEnumerable<TResult>`
- `System.IO.Enumeration.FileSystemEnumerableFactory`
- `System.IO.Enumeration.FileSystemEnumerator<TResult>`
- `System.IO.Enumeration.FileSystemName`
- `System.IO.EnumerationOptions`
- `System.IO.MatchCasing`
- `System.IO.MatchType`
- `System.IO.MonoLinqHelper`
- `System.IO.SearchOption`
- `System.IO.SearchTarget`
- `System.IO.StreamHelpers`
- `System.IO.StringReader`
- `System.IO.StringWriter`
- `System.IServiceProvider`
- `System.IValueTupleInternal`
- `System.Index`
- `System.MonoLimitationAttribute`
- `System.MutableDecimal`
- `System.OperatingSystem`
- `System.ParsingInfo`
- `System.Range`
- `System.Reflection.IReflectableType`
- `System.Reflection.IntrospectionExtensions`
- `System.Reflection.ManifestResourceInfo`
- `System.Reflection.ResourceLocation`
- `System.Reflection.RuntimeReflectionExtensions`
- `System.Reflection.TypeDelegator`
- `System.Resources.MissingManifestResourceException`
- `System.Resources.MissingSatelliteAssemblyException`
- `System.Resources.ResourceFallbackManager`
- `System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder`
- `System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<TResult>`
- `System.Runtime.CompilerServices.CallerMemberNameAttribute`
- `System.Runtime.CompilerServices.ConfiguredTaskAwaitable`
- `System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable`
- `System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>`
- `System.Runtime.CompilerServices.DependencyAttribute`
- `System.Runtime.CompilerServices.FormattableStringFactory`
- `System.Runtime.CompilerServices.ITuple`
- `System.Runtime.CompilerServices.ValueTaskAwaiter`
- `System.Runtime.CompilerServices.ValueTaskAwaiter<TResult>`
- `System.Runtime.CompilerServices.YieldAwaitable`
- `System.Runtime.InteropServices.Architecture`
- `System.Runtime.InteropServices.HandleRef`
- `System.Runtime.InteropServices.OSPlatform`
- `System.Runtime.InteropServices.RuntimeInformation`
- `System.Runtime.InteropServices.SequenceMarshal`
- `System.Runtime.InteropServices._MemberInfo`
- `System.Runtime.Versioning.TargetFrameworkAttribute`
- `System.Security.Claims.Claim`
- `System.Security.Claims.ClaimsIdentity`
- `System.Security.CodeAccessPermission`
- `System.Security.Cryptography.Aes`
- `System.Security.Cryptography.AsymmetricAlgorithm`
- `System.Security.Cryptography.AsymmetricKeyExchangeFormatter`
- `System.Security.Cryptography.AsymmetricSignatureDeformatter`
- `System.Security.Cryptography.AsymmetricSignatureFormatter`
- `System.Security.Cryptography.CryptoConfigForwarder`
- `System.Security.Cryptography.CryptoStream`
- `System.Security.Cryptography.CryptoStreamMode`
- `System.Security.Cryptography.CryptographicOperations`
- `System.Security.Cryptography.CspParameters`
- `System.Security.Cryptography.CspProviderFlags`
- `System.Security.Cryptography.DES`
- `System.Security.Cryptography.DESCryptoServiceProvider`
- `System.Security.Cryptography.DESTransform`
- `System.Security.Cryptography.DSA`
- `System.Security.Cryptography.DSACryptoServiceProvider`
- `System.Security.Cryptography.DSAParameters`
- `System.Security.Cryptography.DSASignatureDeformatter`
- `System.Security.Cryptography.DSASignatureDescription`
- `System.Security.Cryptography.DSASignatureFormatter`
- `System.Security.Cryptography.DeriveBytes`
- `System.Security.Cryptography.HMAC`
- `System.Security.Cryptography.HMACMD5`
- `System.Security.Cryptography.HMACRIPEMD160`
- `System.Security.Cryptography.HMACSHA1`
- `System.Security.Cryptography.HMACSHA256`
- `System.Security.Cryptography.HMACSHA384`
- `System.Security.Cryptography.HMACSHA512`
- `System.Security.Cryptography.HashAlgorithmName`
- `System.Security.Cryptography.ICryptoTransform`
- `System.Security.Cryptography.KeyedHashAlgorithm`
- `System.Security.Cryptography.MACTripleDES`
- `System.Security.Cryptography.MaskGenerationMethod`
- `System.Security.Cryptography.PKCS1MaskGenerationMethod`
- `System.Security.Cryptography.RC2`
- `System.Security.Cryptography.RC2CryptoServiceProvider`
- `System.Security.Cryptography.RC2Transform`
- `System.Security.Cryptography.RIPEMD160`
- `System.Security.Cryptography.RIPEMD160Managed`
- `System.Security.Cryptography.RSA`
- `System.Security.Cryptography.RSACryptoServiceProvider`
- `System.Security.Cryptography.RSAEncryptionPadding`
- `System.Security.Cryptography.RSAEncryptionPaddingMode`
- `System.Security.Cryptography.RSAOAEPKeyExchangeFormatter`
- `System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter`
- `System.Security.Cryptography.RSAPKCS1SHA1SignatureDescription`
- `System.Security.Cryptography.RSAPKCS1SHA256SignatureDescription`
- `System.Security.Cryptography.RSAPKCS1SHA384SignatureDescription`
- `System.Security.Cryptography.RSAPKCS1SHA512SignatureDescription`
- `System.Security.Cryptography.RSAPKCS1SignatureDeformatter`
- `System.Security.Cryptography.RSAPKCS1SignatureDescription`
- `System.Security.Cryptography.RSAPKCS1SignatureFormatter`
- `System.Security.Cryptography.RSAParameters`
- `System.Security.Cryptography.Rfc2898DeriveBytes`
- `System.Security.Cryptography.RijndaelManagedTransform`
- `System.Security.Cryptography.RijndaelManagedTransformMode`
- `System.Security.Cryptography.SHA1Managed`
- `System.Security.Cryptography.SHA256`
- `System.Security.Cryptography.SHA256Managed`
- `System.Security.Cryptography.SHA384`
- `System.Security.Cryptography.SHA384Managed`
- `System.Security.Cryptography.SHA512`
- `System.Security.Cryptography.SHA512Managed`
- `System.Security.Cryptography.SignatureDescription`
- `System.Security.Cryptography.TailStream`
- `System.Security.Cryptography.TripleDES`
- `System.Security.Cryptography.TripleDESCryptoServiceProvider`
- `System.Security.Cryptography.TripleDESTransform`
- `System.Security.Cryptography.Utils`
- `System.Security.Cryptography.X509Certificates.X509Certificate`
- `System.Security.Cryptography.X509Certificates.X509CertificateImpl`
- `System.Security.Cryptography.X509Certificates.X509ContentType`
- `System.Security.Cryptography.X509Certificates.X509Helper`
- `System.Security.Cryptography.X509Certificates.X509KeyStorageFlags`
- `System.Security.IPermission`
- `System.Security.ISecurityEncodable`
- `System.Security.NamedPermissionSet`
- `System.Security.PermissionSet`
- `System.Security.Permissions.PermissionState`
- `System.Security.Permissions.SecurityAction`
- `System.Security.Principal.IIdentity`
- `System.Security.Principal.TokenImpersonationLevel`
- `System.Security.Principal.WindowsAccountType`
- `System.Security.Principal.WindowsIdentity`
- `System.Security.Principal.WindowsImpersonationContext`
- `System.Security.SecureString`
- `System.Security.SecurityDocument`
- `System.Security.SecurityElement`
- `System.Security.SecurityElementType`
- `System.Security.Util.Parser`
- `System.Security.Util.Tokenizer`
- `System.Security.Util.TokenizerShortBlock`
- `System.Security.Util.TokenizerStream`
- `System.Security.Util.TokenizerStringBlock`
- `System.Security.XmlSyntaxException`
- `System.SequencePosition`
- `System.SharedStatics`
- `System.Threading.AsyncFlowControl`
- `System.Threading.AsyncLocalValueChangedArgs<T>`
- `System.Threading.LockQueue`
- `System.Threading.ReaderWriterLock`
- `System.Threading.Tasks.ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>`
- `System.Threading.Tasks.ContinuationResultTaskFromTask<TResult>`
- `System.Threading.Tasks.ContinuationTaskFromResultTask<TAntecedentResult>`
- `System.Threading.Tasks.ForceAsyncAwaiter`
- `System.Threading.Tasks.SynchronizationContextTaskScheduler`
- `System.Threading.Tasks.TaskAwaiters`
- `System.Threading.Tasks.TaskToApm`
- `System.Threading.Tasks.UnwrapPromise<TResult>`
- `System.Threading.Tasks.ValueTask`
- `System.Threading.Tasks.ValueTask<TResult>`
- `System.Threading.ThreadPriority`
- `System.Tuple<T1, T2, T3, T4>`
- `System.Tuple<T1, T2>`
- `System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>`
- `System.ValueTuple<T1>`
- `Task.WhenAllPromise`
- `Task.WhenAllPromise<T>`
- `TaskFactory.<>c__DisplayClass35_0<TResult>` (compiler-generated name)
- `TaskFactory.<>c__DisplayClass38_0<TResult, TArg1>` (compiler-generated name)
- `TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2>` (compiler-generated name)
- `TaskToApm.<>c__DisplayClass3_0` (compiler-generated name)
- `TaskToApm.TaskWrapperAsyncResult`
- `TextReader.<>c` (compiler-generated name)
- `TextReader.<ReadToEndAsync>d__14` (compiler-generated name)
- `TextWriter.<>c` (compiler-generated name)
- `ThreadPool.<>c__DisplayClass17_0<TState>` (compiler-generated name)
- `Tokenizer.ITokenReader`
- `Tokenizer.StreamTokenReader`
- `Tokenizer.StringMaker`
- `Tokenizer.TokenSource`
- `UnwrapPromise.<>c<TResult>` (compiler-generated name)
- `Utf8Formatter.DecomposedGuid`
- `ValueTask.ValueTaskSourceAsTask`
- `ValueTask.ValueTaskSourceAsTask.<>c` (compiler-generated name)
- `ValueTask.ValueTaskSourceAsTask.<>c<TResult>` (compiler-generated name)
- `ValueTask.ValueTaskSourceAsTask<TResult>`
- `ValueTaskAwaiter.<>c` (compiler-generated name)
- `Volatile.VolatileBoolean`
- `YieldAwaitable.YieldAwaiter`

</details>

<details><summary>Extra: 9</summary>

- `System.LocalDataStoreElement`
- `System.MathF`
- `System.Reflection.Emit.UnmanagedMarshal`
- `System.Runtime.InteropServices.COMException`
- `System.Runtime.InteropServices.ErrorWrapper`
- `System.Runtime.Remoting.Contexts.CrossContextDelegate`
- `System.Runtime.Remoting.Contexts.IContributeDynamicSink`
- `System.Runtime.Remoting.Contexts.IDynamicProperty`
- `System.Threading.NativeOverlapped`

</details>


## netstandard.dll

<details><summary>Extra: 12</summary>

- `<Module>`
- `DialogManagerBase._003C_003Ec__DisplayClass14_0._003C_003COpenDialogAsync_003Eb__1_003Ed` (compiler-generated name)
- `DialogManagerBase._003C_003Ec__DisplayClass14_0<!0>` (compiler-generated name)
- `DialogManagerBase._003C_003Ec__DisplayClass16_0` (compiler-generated name)
- `DialogManagerBase._003C_003Ec__DisplayClass16_0._003C_003CCloseAllDialogAsync_003Eb__0_003Ed` (compiler-generated name)
- `DynamicTabBase._003C_003Ec__DisplayClass2_0` (compiler-generated name)
- `DynamicTabBase._003C_003Ec__DisplayClass2_0._003C_003CBuildTabsAsync_003Eb__0_003Ed` (compiler-generated name)
- `GridListPresenterBase._003C_003Ec__DisplayClass2_0` (compiler-generated name)
- `GridListPresenterBase._003C_003Ec__DisplayClass2_0._003C_003CGetSortedTargetCellTable_003Eg__GetOtherCells_007C0_003Ed` (compiler-generated name)
- `Qua.UI.DialogManagerBase<!0>`
- `Qua.UI.DynamicTabBase<!0, !1, !2>`
- `Qua.UI.GridListPresenterBase<!0, !1, !2>`

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

<details><summary>Matching: 14</summary>

- `<Module>`
- `Qua.Global.IFontLoader`
- `Qua.Global.QuaGlobalManager`
- `Qua.Global.QuaGlobalSetting`
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

<details><summary>Mismatching: 1</summary>

- `Qua.Global.QuaGlobalTextMeshProUGUI`

  - `_fontId: offset '0x7c8' → '0x7d0'`
  - `_loadedFontId: offset '0x7d0' → '0x7d8'`
  - `_loadedFont: offset '0x7d8' → '0x7e0'`
  - `_isSetupFont: offset '0x7e0' → '0x7e8'`


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

<details><summary>Extra: 5</summary>

- `<QAReconstructionImplementationDetails>` (compiler-generated name)
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=11306`
- `<QAReconstructionImplementationDetails>.__StaticArrayInitTypeSize=16364`
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1` (compiler-generated name)
- `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData`

</details>

