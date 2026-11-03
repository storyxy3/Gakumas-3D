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

            internal void _003CActorLoadAsync_003Eb__4(CampusActorAnimationJointLimitSetting settingAsset, AssetLoaderError error)
            {
            }

            internal bool _003CActorLoadAsync_003Eb__1()
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
                return default(float);
            }

            set
            {
            }
        }

        public float SweatWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float HighlightWeight
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float TargetCorrectionWeight
        {
            get
            {
                return default(float);
            }

            set
            {
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
                return default(float);
            }

            set
            {
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
                return default(bool);
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
            return default(HumanDescription);
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
            return null;
        }

        public void SetCustomLookAt(Transform t)
        {
        }

        public void SetCustomLookAt(Vector3 pos)
        {
        }

        public void SetCustomLookAtEffector(CustomLookAtEffector effector)
        {
        }

        public void SetCampusCustomLookAtEffector(CampusCustomLookAtEffector effector)
        {
        }

        public bool IsLookAtLimitedPoseEnable()
        {
            return default(bool);
        }

        public void ResetCustomLookAt()
        {
        }

        public Vector3 GetFullBodyIkHeadOriginalPosition()
        {
            return default(Vector3);
        }

        public Quaternion GetFullBodyIkHeadOriginalRotation()
        {
            return default(Quaternion);
        }

        public Vector3 GetFullBodyIkHeadOriginalForward()
        {
            return default(Vector3);
        }

        public void SetActorLayout(Transform actorLayout)
        {
        }

        public override void ResetModel()
        {
        }

        public override void ResetTime()
        {
        }

        public override void ApplyActorAnimationManagePropertyData(ActorAnimationManagePropertyData propertyData)
        {
        }

        public void ResetDynamicSkin()
        {
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
        }

        public void DisableJointLimitSetting()
        {
        }

        public bool IsJointLimitNowLimited()
        {
            return default(bool);
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
