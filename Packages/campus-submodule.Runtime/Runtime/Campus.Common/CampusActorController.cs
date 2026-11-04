// TODO(qa-recon): Selected APK bodies still need reconstruction: .cctor, .ctor, ApplyActorAnimationManagePropertyData, Campus.Common.ICampusActorController.get_isDestroyed, CanEyeBlink, CorrectSkeleton, DisposeTalk<object>, EnableBakedSwingBone, ExecuteEyeBlink, GetAnimationController, GetCustomGraphAnimationPlayer, GetHumanScale, GetPlayingAnimationController, InitializeActorAO, InitializeActorAnimation, InitializeBodyAdditive, InitializeExpression, InitializeFacial, InitializeRenderer, InitializeTalk<object>, LateUpdate, OnActorDestroy, OnBuildModelSuccess, OnClipPlay, OnDisable, OnEnable, OnUpdateMaterial, OverrideActorMaterialProperty, PlayEffect, PlayMotion, PlayTalk, RemoveOverrideMaterialProperty, ResetActorMaterialProperty, ResetAllIKGoalToOriginalTarget, ResetBakeSwingBone, ResetIKGoalToOriginalTarget, ResetModel, SampleAnimation, SetAnimationEventActive, SetEnableColliders, SetEyeBlinkEnable, SetEyeBlinkWeight, SetOverrideMaterialProperty, SetRendererActiveByReference, SetRendererAndCollidersActive, SetTalkActive, SetupAllIKGoalToOverrideTarget, SetupAnimation, SetupMoveConstraint, SetupPropConstraintAnimation, SetupPropConstraintSource, SetupSeatedDynamicCorrection, SetupTimelineEventReceiver, StopEffects, StopTalk, TryInitializeTalk, UpdateHighLightMaterial, UpdateLookAtEyePitchCorrection, UpdateMaterialInfos, UpdateNodAdditive, UpdateTalkAdditive, get_LookAtEyeSideCorrectionDeFactoWeight, get_localToWorldMatrix, get_worldToLocalMatrix.
namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::Campus.Common.Animation;
    using global::Campus.Timeline;
    using global::CriWare;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Octo;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Core;
    using global::VL.IK;

    public class CampusActorController : VLDefaultActorController<CampusActorModelParts, CampusActorDescriptor, ICampusActorDescriptor>, ICampusActorController, IVLDefaultActorController<ICampusActorDescriptor>, IVLActorController<ICampusActorDescriptor>, IVLActorController, IVLTransform
    {
        private static class ShaderIDs
        {
            internal static readonly int _BaseMap;
            internal static readonly int _ShadeMap;
            internal static readonly int _DefMap;
            internal static readonly int _LayerWeight;
            internal static readonly int _BaseMap_ST;
            internal static readonly int _UseLastFramePositions;
        }

        [Serializable]
        private class OverrideActorMaterialPropertyData
        {
            public CampusActorMaterialProperty property;
            public CampusActorMaterialProperty defaultProperty;
            public OverrideActorMaterialPropertyData()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<GameObject, bool> _003C_003E9__71_2;
            public static Func<GameObject, int, (GameObject value, int partsIndex, bool)> _003C_003E9__71_5;
            public static Func<(GameObject value, int partsIndex, bool), bool> _003C_003E9__71_6;
            public static Func<(GameObject value, int partsIndex, bool), int> _003C_003E9__71_7;
            public static Func<CampusActorModelParts, IEnumerable<VLActorExpressionBone>> _003C_003E9__80_0;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationConstraintTransformBone>> _003C_003E9__81_0;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverRotationBone>> _003C_003E9__81_1;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverFrillBone>> _003C_003E9__81_2;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverSkirtBone>> _003C_003E9__81_3;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverHairBone>> _003C_003E9__81_4;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverHumanoidHandBone>> _003C_003E9__81_5;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverHumanoidSleeveBone>> _003C_003E9__81_6;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverHumanoidUpLegBone>> _003C_003E9__81_7;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverHumanoidArmBone>> _003C_003E9__81_8;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverWaistBone>> _003C_003E9__81_9;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverFurisodeBone>> _003C_003E9__81_10;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationQuartzDriverPonchoBone>> _003C_003E9__81_11;
            public static Func<CampusActorModelParts, IEnumerable<InitialTransform>> _003C_003E9__81_12;
            public static Func<CampusActorModelParts, IEnumerable<ActorSwingDynamicBone>> _003C_003E9__81_13;
            public static Func<CampusActorModelParts, IEnumerable<ActorSwingStaticBone>> _003C_003E9__81_14;
            public static Func<CampusActorModelParts, IEnumerable<ActorSwingBreastBone>> _003C_003E9__81_15;
            public static Func<CampusActorModelParts, IEnumerable<InitialTransform>> _003C_003E9__81_16;
            public static Func<CampusActorModelParts, IEnumerable<InitialTransform>> _003C_003E9__81_17;
            public static Func<CampusActorModelParts, IEnumerable<InitialTransform>> _003C_003E9__81_18;
            public static Func<CampusActorModelParts, IEnumerable<InitialTransform>> _003C_003E9__81_19;
            public static Func<CampusActorModelParts, IEnumerable<ActorSwingChain>> _003C_003E9__81_20;
            public static Func<CampusActorModelParts, IEnumerable<ActorAnimationIKCorrectionCollider>> _003C_003E9__81_21;
            public static Func<string, int, (string propName, int partsIndex)> _003C_003E9__98_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CActorLoadAsync_003Eb__71_2(GameObject prefab)
            {
                return default(bool);
            }

            internal (GameObject, int, bool) _003CActorLoadAsync_003Eb__71_5(GameObject value, int partsIndex)
            {
                return default((GameObject, int, bool));
            }

            internal bool _003CActorLoadAsync_003Eb__71_6((GameObject value, int partsIndex, bool) x)
            {
                return default(bool);
            }

            internal int _003CActorLoadAsync_003Eb__71_7((GameObject value, int partsIndex, bool) x)
            {
                return default(int);
            }

            internal IEnumerable<VLActorExpressionBone> _003CInitializeExpression_003Eb__80_0(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationConstraintTransformBone> _003CInitializeActorAnimation_003Eb__81_0(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverRotationBone> _003CInitializeActorAnimation_003Eb__81_1(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverFrillBone> _003CInitializeActorAnimation_003Eb__81_2(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverSkirtBone> _003CInitializeActorAnimation_003Eb__81_3(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHairBone> _003CInitializeActorAnimation_003Eb__81_4(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidHandBone> _003CInitializeActorAnimation_003Eb__81_5(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidSleeveBone> _003CInitializeActorAnimation_003Eb__81_6(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidUpLegBone> _003CInitializeActorAnimation_003Eb__81_7(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidArmBone> _003CInitializeActorAnimation_003Eb__81_8(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverWaistBone> _003CInitializeActorAnimation_003Eb__81_9(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverFurisodeBone> _003CInitializeActorAnimation_003Eb__81_10(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationQuartzDriverPonchoBone> _003CInitializeActorAnimation_003Eb__81_11(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_12(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorSwingDynamicBone> _003CInitializeActorAnimation_003Eb__81_13(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorSwingStaticBone> _003CInitializeActorAnimation_003Eb__81_14(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorSwingBreastBone> _003CInitializeActorAnimation_003Eb__81_15(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_16(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_17(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_18(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_19(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorSwingChain> _003CInitializeActorAnimation_003Eb__81_20(CampusActorModelParts x)
            {
                return null;
            }

            internal IEnumerable<ActorAnimationIKCorrectionCollider> _003CInitializeActorAnimation_003Eb__81_21(CampusActorModelParts x)
            {
                return null;
            }

            internal (string, int) _003CSetupPropConstraintAnimation_003Eb__98_0(string propName, int partsIndex)
            {
                return default((string, int));
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass70_0
        {
            public bool fail;
            public _003C_003Ec__DisplayClass70_0()
            {
            }

            internal void _003C_BuildAsync_003Eb__0(string asset)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass71_0
        {
            public List<AssetKeeper> keeperList;
            public GameObject actorObject;
            public int loadCount;
            public Action<string> onFail;
            public GameObject[] prefabs;
            public CampusActorAnimationJointLimitSetting jointLimitSetting;
            public _003C_003Ec__DisplayClass71_0()
            {
            }

            internal AssetKeeper _003CActorLoadAsync_003Eg__GetAssetKeeper_007C0()
            {
                return null;
            }

            internal void _003CActorLoadAsync_003Eb__4(CampusActorAnimationJointLimitSetting settingAsset, AssetLoaderError error)
            {
            }

            internal bool _003CActorLoadAsync_003Eb__1()
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass71_1
        {
            public int index;
            public _003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass71_1()
            {
            }

            internal void _003CActorLoadAsync_003Eb__3(GameObject prefab, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass98_0
        {
            public Transform propLocator;
            public _003C_003Ec__DisplayClass98_0()
            {
            }

            internal bool _003CSetupPropConstraintAnimation_003Eb__1(PropConstraintData x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CActorLoadAsync_003Ed__71 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Action<string> onFail;
            public CampusActorController _003C_003E4__this;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass71_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CBuildAsync_003Ed__69 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(bool isSuccess, ICampusActorController controller)> _003C_003Et__builder;
            public CampusActorController _003C_003E4__this;
            public VLActorSettings actorSettings;
            public CampusActorDescriptor actorDescriptor;
            public CancellationToken ct;
            private UniTask<(bool isSuccess, ICampusActorController controller)>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COnBuildModelSuccessAsync_003Ed__84 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusActorController _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_BuildAsync_003Ed__70 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(bool isSuccess, ICampusActorController controller)> _003C_003Et__builder;
            public VLActorSettings actorSettings;
            public CampusActorController _003C_003E4__this;
            public CampusActorDescriptor actorDescriptor;
            private _003C_003Ec__DisplayClass70_0 _003C_003E8__1;
            private CancellationToken _003CactorCt_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private static readonly ProfilingSampler UpdateDecalProfilingSampler;
        [SerializeField]
        [HideInInspector]
        private MotionDefinePlayer _animationPlayer;
        [SerializeField]
        [HideInInspector]
        private DefaultAnimationData _defaultAnimationData;
        [SerializeField]
        [HideInInspector]
        private VLActorExpression _expression;
        [SerializeField]
        [HideInInspector]
        private VLActorTalk _talk;
        [SerializeField]
        [HideInInspector]
        private CampusCriActorTalk _criTalk;
        [SerializeField]
        [HideInInspector]
        private VLActorFacialSystem _facial;
        [SerializeField]
        [HideInInspector]
        private List<EffectorBase> _effectors;
        [SerializeField]
        [HideInInspector]
        private List<EffectorBase> _originalEffectors;
        [SerializeField]
        [HideInInspector]
        private CampusActorAnimation _actorAnimation;
        [SerializeField]
        [HideInInspector]
        private CampusActorEyeHighlight _eyeHighlight;
        [SerializeField]
        [HideInInspector]
        private AnimationEventHandler _animationEventHandler;
        [SerializeField]
        private float _talkAnimationSpeed;
        [SerializeField]
        [Range(0f, 1f)]
        private float _sweatWeight;
        [SerializeField]
        [Range(0f, 2f)]
        private float _highlightWeight;
        [SerializeField]
        [Range(0f, 1f)]
        private float _targetCorrectionWeight;
        [SerializeField]
        private CampusActorAnimationJointLimitSetting jointLimitSetting;
        public static readonly float HeightCoefficient;
        public static readonly float CmmnHipsHeight;
        public static readonly float BaseHeight;
        public static readonly float MinHeight;
        public static readonly float MaxHeight;
        [SerializeField]
        private CustomGraphAnimationPlayer _customGraphAnimationPlayer;
        [SerializeField]
        [HideInInspector]
        private Transform _rootBody;
        [SerializeField]
        [Range(0f, 1f)]
        private float _lookAtEyeSideCorrectionWeight;
        private int _renderActiveCount;
        private CampusActorEffectController _effectController;
        private CampusActorModelParts _faceParts;
        private CampusActorFaceCorrection _faceCorrection;
        private VLActorAO _actorAO;
        private Dictionary<string, List<MaterialInfo>> _materialInfoTable;
        private Dictionary<string, OverrideActorMaterialPropertyData> _overrideActorMaterialProperties;
        private List<MaterialInfo> _vlSkinningMaterialInfos;
        private CampusTimelineEventReceiver _timelineEventReceiver;
        [CompilerGenerated]
        private bool _003CIsBuildSuccess_003Ek__BackingField;
        public Action<ICampusActorController, LayerParam, ClipParam> onClipPlay;
        public Action<int> onActorDestroy;
        public bool isOverrideNodAdditiveManual;
        public float TalkAnimationSpeed
        {
            get
            {
                return _talkAnimationSpeed;
            }

            set
            {
                _talkAnimationSpeed = value;
            }
        }

        public float SweatWeight
        {
            get
            {
                return _sweatWeight;
            }

            set
            {
                _sweatWeight = value;
            }
        }

        public float HighlightWeight
        {
            get
            {
                return _highlightWeight;
            }

            set
            {
                _highlightWeight = value;
            }
        }

        public float TargetCorrectionWeight
        {
            get
            {
                return _targetCorrectionWeight;
            }

            set
            {
                _targetCorrectionWeight = value;
            }
        }

        public CampusActorAnimationJointLimitSetting JointLimitSetting
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float LookAtEyeSideCorrectionWeight
        {
            get
            {
                return _lookAtEyeSideCorrectionWeight;
            }

            set
            {
                _lookAtEyeSideCorrectionWeight = value;
            }
        }

        public float LookAtEyeSideCorrectionDeFactoWeight
        {
            get
            {
                return default(float);
            }
        }

        public Matrix4x4 worldToLocalMatrix
        {
            get
            {
                return default(Matrix4x4);
            }
        }

        public Matrix4x4 localToWorldMatrix
        {
            get
            {
                return default(Matrix4x4);
            }
        }

        public bool IsBuildSuccess
        {
            [CompilerGenerated]
            get
            {
                return _003CIsBuildSuccess_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        [AsyncStateMachine(typeof(_003CBuildAsync_003Ed__69))]
        public UniTask<(bool, ICampusActorController)> BuildAsync(VLActorSettings actorSettings, CampusActorDescriptor actorDescriptor, CancellationToken ct)
        {
            return default(UniTask<(bool, ICampusActorController)>);
        }

        [AsyncStateMachine(typeof(_003C_BuildAsync_003Ed__70))]
        private UniTask<(bool, ICampusActorController)> _BuildAsync(VLActorSettings actorSettings, CampusActorDescriptor actorDescriptor)
        {
            return default(UniTask<(bool, ICampusActorController)>);
        }

        [AsyncStateMachine(typeof(_003CActorLoadAsync_003Ed__71))]
        public UniTask ActorLoadAsync(Action<string> onFail, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void CorrectSkeleton(string partsId, GameObject instance)
        {
        }

        private void InitializeRenderer()
        {
        }

        private void SetFaceParts(CampusActorModelParts faceParts)
        {
        }

        private void TryInitializeTalk(bool isCri)
        {
        }

        private void InitializeTalk<T>(ref T talk, CampusActorModelParts faceParts)
            where T : VLActorExtension, IVLActorTalk
        {
        }

        private void DisposeTalk<T>(ref T talk)
            where T : VLActorExtension, IVLActorTalk
        {
        }

        private void InitializeFacial(CampusActorModelParts faceParts)
        {
        }

        private void InitializeBodyAdditive()
        {
        }

        private void InitializeExpression()
        {
        }

        private void InitializeActorAnimation(Transform bodyTransform, [Optional] Transform rootReference)
        {
        }

        protected void InitializeActorAO()
        {
        }

        protected override void OnBuildModelSuccess()
        {
        }

        [AsyncStateMachine(typeof(_003COnBuildModelSuccessAsync_003Ed__84))]
        protected UniTask OnBuildModelSuccessAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void SetupTimelineEventReceiver()
        {
        }

        protected override void SetupAnimation()
        {
        }

        protected override HumanDescription GetHumanDescription(HumanBone[] human, SkeletonBone[] skeleton)
        {
            return new HumanDescription { human = human, skeleton = skeleton, lowerArmTwist = 0f, upperArmTwist = 1f, lowerLegTwist = 0f, upperLegTwist = 1f, armStretch = 0.05f, legStretch = 0.05f, feetSpacing = 0f, hasTranslationDoF = false };
        }

        protected override void LateUpdate()
        {
        }

        protected override void OnUpdateMaterial()
        {
        }

        public void SetOverrideMaterialProperty(string materialName, CampusActorMaterialProperty property)
        {
        }

        public void RemoveOverrideMaterialProperty(string materialName)
        {
        }

        private void OverrideActorMaterialProperty(MaterialInfo materialInfo, OverrideActorMaterialPropertyData overrideProperty)
        {
        }

        private void ResetActorMaterialProperty(MaterialInfo materialInfo, OverrideActorMaterialPropertyData overrideProperty)
        {
        }

        private void UpdateHighLightMaterial()
        {
        }

        private void UpdateMaterialInfos()
        {
        }

        public void EnableBakedSwingBone(MotionDefine motionDefine)
        {
        }

        public void ResetBakeSwingBone()
        {
        }

        public void SetupPropConstraintAnimation(MotionDefine motionDefine)
        {
        }

        private void SetupPropExecuteType(ActorAnimationConstraintTransformBone transformConstraint, ActorAnimationConstraintExecuteType executeType)
        {
        }

        private void SetupPropConstraintSource(ActorAnimationConstraintTransformBone transformConstraint, string[] constraintTargets, bool isAdaptScale)
        {
        }

        public void SetPropFieldConstraintTarget(string propName, GameObject fieldConstraintTarget)
        {
        }

        public void ClearPropFieldConstraintTarget(string propName)
        {
        }

        public void SetupSeatedDynamicCorrection(MotionDefine motionDefine)
        {
        }

        [ContextMenu("SetupAllIKGoalToOverrideTarget")]
        public void SetupAllIKGoalToOverrideTarget()
        {
        }

        [ContextMenu("ResetAllIKGoalToOriginalTarget")]
        public void ResetAllIKGoalToOriginalTarget()
        {
        }

        public void ResetIKGoalToOriginalTarget(AvatarIKGoal ikGoal)
        {
        }

        private void OnClipPlay(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
        }

        public void SetTalkActive(bool active)
        {
        }

        public void PlayTalk()
        {
        }

        public void PlayTalk(AudioSource source, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
        }

        public void PlayTalk(AudioSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
        }

        public void PlayTalk(CriAtomSource source, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
        }

        public void PlayTalk(CriAtomSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
        }

        public void StopTalk()
        {
        }

        public void UpdateTalkAdditive(float time, float weight)
        {
        }

        private void UpdateNodAdditive()
        {
        }

        private void UpdateLookAtEyePitchCorrection()
        {
        }

        public void ExecuteEyeBlink(bool forceBlink = false)
        {
        }

        public void SetEyeBlinkWeight(float weight)
        {
        }

        public void SetEyeBlinkEnable(bool enable)
        {
        }

        public bool CanEyeBlink()
        {
            return default(bool);
        }

        public void SetRendererActiveByReference(bool isActive, bool isReset = false)
        {
        }

        public void SetRendererAndCollidersActive(bool isActive)
        {
        }

        private void SetEnableColliders(bool isActive)
        {
        }

        protected override void OnActorDestroy()
        {
        }

        public CustomLookAtEffector GetCurrentCustomLookAtEffector()
        {
            return _actorAnimation != null ? _actorAnimation.CustomLookAtEffector : null;
        }

        public void SetCustomLookAt(Transform t)
        {
            if (_actorAnimation != null) _actorAnimation.SetCustomLookAt(t);
        }

        public void SetCustomLookAt(Vector3 pos)
        {
            if (_actorAnimation != null) _actorAnimation.SetCustomLookAt(pos);
        }

        public void SetCustomLookAtEffector(CustomLookAtEffector effector)
        {
            if (_actorAnimation != null) _actorAnimation.SetCustomLookAtEffector(effector);
        }

        public void SetCampusCustomLookAtEffector(CampusCustomLookAtEffector effector)
        {
            if (_actorAnimation != null) _actorAnimation.SetCampusCustomLookAtEffector(effector);
        }

        public bool IsLookAtLimitedPoseEnable()
        {
            return _actorAnimation != null && _actorAnimation.isCustomLookAtLimitEnablePose;
        }

        public void ResetCustomLookAt()
        {
            if (_actorAnimation != null) _actorAnimation.ResetCustomLookAt();
        }

        public Vector3 GetFullBodyIkHeadOriginalPosition()
        {
            return _actorAnimation != null ? _actorAnimation.FullBodyIkHeadOriginalPosition : Vector3.zero;
        }

        public Quaternion GetFullBodyIkHeadOriginalRotation()
        {
            return _actorAnimation != null ? _actorAnimation.FullBodyIkHeadOriginalRotation : Quaternion.identity;
        }

        public Vector3 GetFullBodyIkHeadOriginalForward()
        {
            return _actorAnimation != null ? _actorAnimation.FullBodyIkHeadOriginalForward : Vector3.zero;
        }

        public void SetActorLayout(Transform actorLayout)
        {
            if (_actorAnimation != null) _actorAnimation.SetActorLayout(actorLayout);
        }

        public override void ResetModel()
        {
        }

        public override void ResetTime()
        {
            if (_actorAnimation != null) _actorAnimation.ResetTime();
        }

        public override void ApplyActorAnimationManagePropertyData(ActorAnimationManagePropertyData propertyData)
        {
        }

        public void ResetDynamicSkin()
        {
            if (_actorAnimation != null) _actorAnimation.ResetDynamicSkin();
        }

        private void SetupMoveConstraint()
        {
        }

        public float GetHumanScale()
        {
            return default(float);
        }

        public void SampleAnimation(AnimationClip clip, float time)
        {
        }

        public CustomGraphAnimationPlayer GetCustomGraphAnimationPlayer()
        {
            return null;
        }

        public void SetAnimationEventActive(bool active)
        {
        }

        public void SetAndEnableJointLimitSetting(CampusActorAnimationJointLimitSetting setting)
        {
            jointLimitSetting = setting;
            if (_actorAnimation != null) _actorAnimation.SetAndEnableJointLimitSetting(setting);
        }

        public void DisableJointLimitSetting()
        {
            if (_actorAnimation != null)
            {
                jointLimitSetting = null;
                _actorAnimation.DisableJointLimitSetting();
            }
        }

        public bool IsJointLimitNowLimited()
        {
            return _actorAnimation != null && _actorAnimation.jointLimitNowLimited;
        }

        public UnityEngine.Object GetAnimationPlayerObject()
        {
            return null;
        }

        public IAnimationController PlayMotion(MotionDefine motion)
        {
            return null;
        }

        public IAnimationController PlayMotion(IEnumerable<MotionDefine> motions)
        {
            return null;
        }

        public IAnimationController GetAnimationController(LayerParam param)
        {
            return null;
        }

        public IAnimationController GetAnimationController(LayerParam param, OutputType outputType)
        {
            return null;
        }

        public IAnimationController GetPlayingAnimationController()
        {
            return null;
        }

        public void PlayEffect(HumanBodyBones targetBone, ParticleSystem effect)
        {
        }

        public void StopEffects()
        {
        }

        private void StopEffect(ParticleSystem effect)
        {
        }

        public CampusActorController()
        {
        }

        bool Campus.Common.ICampusActorController.isDestroyed
        {
            get
            {
                return default(bool);
            }
        }
    }
}
