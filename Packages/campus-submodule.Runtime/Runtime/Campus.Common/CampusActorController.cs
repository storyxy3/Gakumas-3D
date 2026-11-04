namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::VL.FaceSystem;
    using global::Unity.Mathematics;
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
            internal static readonly int _BaseMap = Shader.PropertyToID("_BaseMap");
            internal static readonly int _ShadeMap = Shader.PropertyToID("_ShadeMap");
            internal static readonly int _DefMap = Shader.PropertyToID("_DefMap");
            internal static readonly int _LayerWeight = Shader.PropertyToID("_LayerWeight");
            internal static readonly int _BaseMap_ST = Shader.PropertyToID("_BaseMap_ST");
            internal static readonly int _UseLastFramePositions = Shader.PropertyToID("_UseLastFramePositions");
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
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
                return x.expressionBones;
            }

            internal IEnumerable<ActorAnimationConstraintTransformBone> _003CInitializeActorAnimation_003Eb__81_0(CampusActorModelParts x)
            {
                return x.constraintTransformBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverRotationBone> _003CInitializeActorAnimation_003Eb__81_1(CampusActorModelParts x)
            {
                return x.quartzDriverRotationBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverFrillBone> _003CInitializeActorAnimation_003Eb__81_2(CampusActorModelParts x)
            {
                return x.quartzDriverFrillBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverSkirtBone> _003CInitializeActorAnimation_003Eb__81_3(CampusActorModelParts x)
            {
                return x.quartzDriverSkirtBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHairBone> _003CInitializeActorAnimation_003Eb__81_4(CampusActorModelParts x)
            {
                return x.quartzDriverHairBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidHandBone> _003CInitializeActorAnimation_003Eb__81_5(CampusActorModelParts x)
            {
                return x.quartzDriverHumanoidHandBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidSleeveBone> _003CInitializeActorAnimation_003Eb__81_6(CampusActorModelParts x)
            {
                return x.quartzDriverHumanoidSleeveBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidUpLegBone> _003CInitializeActorAnimation_003Eb__81_7(CampusActorModelParts x)
            {
                return x.quartzDriverHumanoidUpLegBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverHumanoidArmBone> _003CInitializeActorAnimation_003Eb__81_8(CampusActorModelParts x)
            {
                return x.quartzDriverHumanoidArmBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverWaistBone> _003CInitializeActorAnimation_003Eb__81_9(CampusActorModelParts x)
            {
                return x.quartzDriverWaistBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverFurisodeBone> _003CInitializeActorAnimation_003Eb__81_10(CampusActorModelParts x)
            {
                return x.quartzDriverFurisodeBones;
            }

            internal IEnumerable<ActorAnimationQuartzDriverPonchoBone> _003CInitializeActorAnimation_003Eb__81_11(CampusActorModelParts x)
            {
                return x.quartzDriverPonchoBones;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_12(CampusActorModelParts x)
            {
                return x.initialTransforms;
            }

            internal IEnumerable<ActorSwingDynamicBone> _003CInitializeActorAnimation_003Eb__81_13(CampusActorModelParts x)
            {
                return x.dynamicBones;
            }

            internal IEnumerable<ActorSwingStaticBone> _003CInitializeActorAnimation_003Eb__81_14(CampusActorModelParts x)
            {
                return x.staticBones;
            }

            internal IEnumerable<ActorSwingBreastBone> _003CInitializeActorAnimation_003Eb__81_15(CampusActorModelParts x)
            {
                return x.breastBones;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_16(CampusActorModelParts x)
            {
                return x.initialLeftBreastTransforms;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_17(CampusActorModelParts x)
            {
                return x.initialRightBreastTransforms;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_18(CampusActorModelParts x)
            {
                return x.initialLeftBreastEndTransforms;
            }

            internal IEnumerable<InitialTransform> _003CInitializeActorAnimation_003Eb__81_19(CampusActorModelParts x)
            {
                return x.initialRightBreastEndTransforms;
            }

            internal IEnumerable<ActorSwingChain> _003CInitializeActorAnimation_003Eb__81_20(CampusActorModelParts x)
            {
                return x.chains;
            }

            internal IEnumerable<ActorAnimationIKCorrectionCollider> _003CInitializeActorAnimation_003Eb__81_21(CampusActorModelParts x)
            {
                return x.iKCorrectionColliders;
            }

            internal (string, int) _003CSetupPropConstraintAnimation_003Eb__98_0(string propName, int partsIndex)
            {
                return (propName, partsIndex);
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
                return x.prop == propLocator.name;
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

        private static readonly ProfilingSampler UpdateDecalProfilingSampler = new ProfilingSampler("UpdateDecal");
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
        private List<EffectorBase> _effectors = new List<EffectorBase>(12);
        [SerializeField]
        [HideInInspector]
        private List<EffectorBase> _originalEffectors = new List<EffectorBase>(12);
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
        private float _talkAnimationSpeed = 0.8f;
        [SerializeField]
        [Range(0f, 1f)]
        private float _sweatWeight;
        [SerializeField]
        [Range(0f, 2f)]
        private float _highlightWeight = 1f;
        [SerializeField]
        [Range(0f, 1f)]
        private float _targetCorrectionWeight = 1f;
        [SerializeField]
        private CampusActorAnimationJointLimitSetting jointLimitSetting;
        public static readonly float HeightCoefficient = 0.8981165289878845f;
        public static readonly float CmmnHipsHeight = 0.9008222222328186f;
        public static readonly float BaseHeight = 155.0f;
        public static readonly float MinHeight = 140.0f;
        public static readonly float MaxHeight = 170.0f;
        [SerializeField]
        private CustomGraphAnimationPlayer _customGraphAnimationPlayer;
        [SerializeField]
        [HideInInspector]
        private Transform _rootBody;
        [SerializeField]
        [Range(0f, 1f)]
        private float _lookAtEyeSideCorrectionWeight = 1f;
        private int _renderActiveCount;
        private CampusActorEffectController _effectController;
        private CampusActorModelParts _faceParts;
        private CampusActorFaceCorrection _faceCorrection;
        private VLActorAO _actorAO;
        private Dictionary<string, List<MaterialInfo>> _materialInfoTable = new Dictionary<string, List<MaterialInfo>>(16);
        private Dictionary<string, OverrideActorMaterialPropertyData> _overrideActorMaterialProperties;
        private List<MaterialInfo> _vlSkinningMaterialInfos = new List<MaterialInfo>(16);
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
                return 0.25f;
            }
        }

        public Matrix4x4 worldToLocalMatrix
        {
            get
            {
                return _rootBody.worldToLocalMatrix;
            }
        }

        public Matrix4x4 localToWorldMatrix
        {
            get
            {
                return _rootBody.localToWorldMatrix;
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
            base.OnEnable();
            if (_children != null) UpdateMaterialInfos();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if (_animationPlayer != null) _animationPlayer.onPlayEvent -= OnClipPlay;
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
            if (!descriptor.correctSkeletonToCmmnHeight || partsId != VLActorDefine.PARTS_BODY_NAME) return;
            var hips = instance.transform.Find("Reference/Hips");
            if (hips != null)
            {
                float scale = CmmnHipsHeight / hips.localPosition.y;
                hips.localPosition *= scale;
                hips.localScale = new Vector3(scale, scale, scale);
            }
        }

        private void InitializeRenderer()
        {
            if (_children == null) return;
            var anchor = GetHumanBodyBoneTransform(HumanBodyBones.Head);
            foreach (var parts in _children)
            {
                if (parts.TryGetComponent<CampusActorLitModel>(out _)) continue;
                uint layer = parts.partsId == "face" ? 8708u : parts.partsId == "hair" ? 17412u : 4356u;
                uint actorLayer = _index <= 9 ? 0x400000u << _index : 0;
                foreach (var renderer in parts.renderers)
                {
                    if (renderer != null)
                    {
                        renderer.renderingLayerMask &= 0xfffffffeu;
                        renderer.renderingLayerMask |= actorLayer | layer;
                        renderer.reflectionProbeUsage = ReflectionProbeUsage.Off;
                        renderer.probeAnchor = anchor;
                    }
                }
            }
        }

        private void SetFaceParts(CampusActorModelParts faceParts)
        {
        }

        private void TryInitializeTalk(bool isCri)
        {
            if (isCri)
            {
                if (_talk != null) DisposeTalk(ref _talk);
                if (_criTalk == null) InitializeTalk(ref _criTalk, _faceParts);
            }
            else
            {
                if (_criTalk != null) DisposeTalk(ref _criTalk);
                if (_talk == null) InitializeTalk(ref _talk, _faceParts);
            }
        }

        private void InitializeTalk<T>(ref T talk, CampusActorModelParts faceParts)
            where T : VLActorExtension, IVLActorTalk
        {
            talk = RegisterExtension<T>();
            var data = Resources.Load<VLActorTalkData>("VLActorTalkData");
            if (faceParts.TryGetComponent<CampusActorTalkModel>(out _))
            {
                var renderers = new List<SkinnedMeshRenderer>();
                if (!faceParts.TryGetComponent<VLActorFaceModel>(out var faceModel))
                {
                    foreach (var renderer in faceParts.skinRenderers)
                    {
                        if (renderer.name == "Geo_Mouth") renderers.Add(renderer);
                    }
                }
                bool success = talk.Setup(data, faceModel, renderers);
                talk.AdditiveScale = 2f;
                if (descriptor.useADVSettings) talk.AutoAdditiveDisabled = true;
                if (success) return;
            }
            DisposeTalk(ref talk);
        }

        private void DisposeTalk<T>(ref T talk)
            where T : VLActorExtension, IVLActorTalk
        {
            UnRegisterExtension<T>();
            talk = null;
        }

        private void InitializeFacial(CampusActorModelParts faceParts)
        {
            var blinkData = Resources.Load<VLActorEyeBlinkData>("VLActorEyeBlinkData");
            _facial = RegisterExtension<VLActorFacialSystem>();
            faceParts.TryGetComponent<VLActorFaceModel>(out var faceModel);
            _facial.SetupEyeBlink(blinkData, faceModel);
            _facial.autoBlinkDisabled = descriptor.autoBlinkDisabled || descriptor.useADVSettings;
            var limitData = Resources.Load<VLActorFacialLimitData>("VLActorFacialLimitData");
            _facial.SetupFacialParts(limitData, faceModel);
            faceParts.TryGetComponent(out _eyeHighlight);
            faceParts.TryGetComponent(out _faceCorrection);
        }

        private void InitializeBodyAdditive()
        {
            if (descriptor.useADVSettings) return;
            var motions = new[]
            {
                Resources.Load<MotionDefine>("mot_all_chr_cmn_idle-001-add_lp_b"),
                Resources.Load<MotionDefine>("mot_all_chr_cmn_idle-002-add_lp_b")
            };
            RegisterExtension<VLActorBodyAdditiveAnimation>().SetAdditiveAnimation(motions);
        }

        private void InitializeExpression()
        {
            _expression = RegisterExtension<VLActorExpression>();
            if (!_expression.Setup(_children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__80_0 ?? (_003C_003Ec._003C_003E9__80_0 = _003C_003Ec._003C_003E9._003CInitializeExpression_003Eb__80_0)).ToArray()))
            {
                UnRegisterExtension<VLActorExpression>();
                _expression = null;
            }
        }

        private void InitializeActorAnimation(Transform bodyTransform, [Optional] Transform rootReference)
        {
            _effectors.Clear();
            _originalEffectors.Clear();
            for (int i = 0; i < bodyTransform.childCount; i++)
            {
                if (bodyTransform.GetChild(i).TryGetComponent<EffectorBase>(out var effector))
                {
                    _effectors.Add(effector);
                    _originalEffectors.Add(effector);
                }
            }
            var moveReference = GetBoneTransformByName(VLActorDefine.MOVE_BONE_NAME);
            var hips = GetHumanBodyBoneTransform(HumanBodyBones.Hips);
            var head = GetHumanBodyBoneTransform(HumanBodyBones.Head);
            GetHumanBodyBoneTransform(HumanBodyBones.RightHand).TryGetComponent<ActorAnimationIKCorrectionGoal>(out var rightHandGoal);
            GetHumanBodyBoneTransform(HumanBodyBones.LeftHand).TryGetComponent<ActorAnimationIKCorrectionGoal>(out var leftHandGoal);
            _actorAnimation = RegisterExtension<CampusActorAnimation>();
            _actorAnimation.Setup(_rootBody, new CampusActorAnimationInitializeData(
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_0 ?? (_003C_003Ec._003C_003E9__81_0 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_0)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_1 ?? (_003C_003Ec._003C_003E9__81_1 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_1)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_2 ?? (_003C_003Ec._003C_003E9__81_2 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_2)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_3 ?? (_003C_003Ec._003C_003E9__81_3 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_3)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_4 ?? (_003C_003Ec._003C_003E9__81_4 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_4)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_5 ?? (_003C_003Ec._003C_003E9__81_5 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_5)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_6 ?? (_003C_003Ec._003C_003E9__81_6 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_6)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_7 ?? (_003C_003Ec._003C_003E9__81_7 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_7)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_8 ?? (_003C_003Ec._003C_003E9__81_8 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_8)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_9 ?? (_003C_003Ec._003C_003E9__81_9 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_9)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_10 ?? (_003C_003Ec._003C_003E9__81_10 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_10)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_11 ?? (_003C_003Ec._003C_003E9__81_11 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_11)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_12 ?? (_003C_003Ec._003C_003E9__81_12 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_12)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_13 ?? (_003C_003Ec._003C_003E9__81_13 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_13)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_14 ?? (_003C_003Ec._003C_003E9__81_14 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_14)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_15 ?? (_003C_003Ec._003C_003E9__81_15 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_15)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_16 ?? (_003C_003Ec._003C_003E9__81_16 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_16)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_17 ?? (_003C_003Ec._003C_003E9__81_17 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_17)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_18 ?? (_003C_003Ec._003C_003E9__81_18 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_18)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_19 ?? (_003C_003Ec._003C_003E9__81_19 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_19)).ToList(),
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_20 ?? (_003C_003Ec._003C_003E9__81_20 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_20)).ToList(),
                GetHumanBodyBoneTransform(HumanBodyBones.LeftUpperLeg),
                GetHumanBodyBoneTransform(HumanBodyBones.LeftLowerLeg),
                GetHumanBodyBoneTransform(HumanBodyBones.LeftFoot),
                GetHumanBodyBoneTransform(HumanBodyBones.RightUpperLeg),
                GetHumanBodyBoneTransform(HumanBodyBones.RightLowerLeg),
                GetHumanBodyBoneTransform(HumanBodyBones.RightFoot),
                _effectors,
                moveReference,
                hips,
                head,
                _children.OfType<CampusActorModelParts>().SelectMany(_003C_003Ec._003C_003E9__81_21 ?? (_003C_003Ec._003C_003E9__81_21 = _003C_003Ec._003C_003E9._003CInitializeActorAnimation_003Eb__81_21)).ToList(),
                rightHandGoal,
                leftHandGoal,
                bodyTransform,
                rootReference));
            _actorAnimation.ApplyActorSwingCmmnHeightCorrection(descriptor.correctSkeletonToCmmnHeight);
        }

        protected void InitializeActorAO()
        {
            _actorAO = RegisterExtension<VLActorAO>();
            var capsules = new VLActorAO.CapsuleData[2];
            float scale = GetHumanScale() / HeightCoefficient;
            capsules[0] = new VLActorAO.CapsuleData
            {
                radius = scale * 0.08f,
                offsetA = new float4(0f, -1f, 0f, scale * 0.03f),
                offsetB = new float4(0f, 1f, 0f, scale * 0.03f)
            };
            capsules[1] = new VLActorAO.CapsuleData
            {
                radius = scale * 0.08f,
                offsetA = new float4(0f, 1f, 0f, scale * 0.03f),
                offsetB = new float4(0f, -1f, 0f, scale * 0.03f)
            };
            _actorAO.Setup(_humanBodyBoneMap, capsules);
        }

        protected override void OnBuildModelSuccess()
        {
            InitializeCollider();
            InitializeRenderer();
            SetupMoveConstraint();
            if (!TryGetPartsFromPartsId("body", out var bodyParts))
            {
                UnityEngine.Debug.LogError("bodyパーツが存在しないためActor生成出来ません");
                return;
            }
            _rootBody = bodyParts.transform;
            if (TryGetPartsFromPartsId(VLActorDefine.PARTS_FACE_NAME, out var faceParts))
            {
                _faceParts = faceParts;
                TryInitializeTalk(true);
                InitializeFacial(faceParts);
            }
            InitializeBodyAdditive();
            InitializeExpression();
            InitializeActorAnimation(_rootBody);
            InitializeActorAO();
            UpdateMaterialInfos();
            _effectController = new CampusActorEffectController();
            _effectController.Initialize();
            SetupTimelineEventReceiver();
        }

        [AsyncStateMachine(typeof(_003COnBuildModelSuccessAsync_003Ed__84))]
        protected UniTask OnBuildModelSuccessAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void SetupTimelineEventReceiver()
        {
            _timelineEventReceiver = RegisterExtension<CampusTimelineEventReceiver>();
        }

        protected override void SetupAnimation()
        {
            if (!TryGetComponent(out _animator)) _animator = gameObject.AddComponent<Animator>();
            if (!TryGetComponent(out _animationEventHandler)) _animationEventHandler = gameObject.AddComponent<AnimationEventHandler>();
            _animator.avatar = _avatar;
            if (descriptor.useADVSettings)
            {
                _customGraphAnimationPlayer = gameObject.AddComponent<CustomGraphAnimationPlayer>();
                _customGraphAnimationPlayer.Setup();
                return;
            }
            if (!TryGetComponent<MotionDefinePlayer>(out var player)) player = gameObject.AddComponent<MotionDefinePlayer>();
            player.Setup();
            player.onPlayEvent -= OnClipPlay;
            player.onPlayEvent += OnClipPlay;
            _animationPlayer = player;
            _defaultAnimationData = Resources.Load<DefaultAnimationData>("DefaultActorAnimationData");
        }

        protected override HumanDescription GetHumanDescription(HumanBone[] human, SkeletonBone[] skeleton)
        {
            return new HumanDescription { human = human, skeleton = skeleton, lowerArmTwist = 0f, upperArmTwist = 1f, lowerLegTwist = 0f, upperLegTwist = 1f, armStretch = 0.05f, legStretch = 0.05f, feetSpacing = 0f, hasTranslationDoF = false };
        }

        protected override void LateUpdate()
        {
            if (this == null) return;
            base.LateUpdate();
            if (_children == null) return;
            using (new ProfilingScope(null, UpdateDecalProfilingSampler))
            {
                for (int i = 0; i < _children.Count; i++)
                {
                    if (_children[i] is CampusActorModelParts parts) parts.UpdateDecalProperty();
                }
            }
            if (_faceCorrection != null) _faceCorrection.globalWeight = _targetCorrectionWeight;
            UpdateNodAdditive();
            UpdateLookAtEyePitchCorrection();
        }

        protected override void OnUpdateMaterial()
        {
            if (_materialInfoTable.TryGetValue("m_fce", out var faceMaterials))
            {
                foreach (var material in faceMaterials) material.SetFloat(ShaderIDs._LayerWeight, _sweatWeight);
            }
            foreach (var material in _vlSkinningMaterialInfos) material.SetFloat(ShaderIDs._UseLastFramePositions, 1f);
            UpdateHighLightMaterial();
            if (_overrideActorMaterialProperties == null) return;
            foreach (var entry in _overrideActorMaterialProperties)
            {
                if (_materialInfoTable.TryGetValue(entry.Key, out var materials) && entry.Value.property != null)
                {
                    for (int i = 0; i < materials.Count; i++) OverrideActorMaterialProperty(materials[i], entry.Value);
                }
            }
        }

        public void SetOverrideMaterialProperty(string materialName, CampusActorMaterialProperty property)
        {
            if (string.IsNullOrEmpty(materialName)) return;
            if (_overrideActorMaterialProperties == null)
                _overrideActorMaterialProperties = new Dictionary<string, OverrideActorMaterialPropertyData>(16);
            if (_overrideActorMaterialProperties.TryGetValue(materialName, out var data))
                data.property = property;
            else
            {
                data = new OverrideActorMaterialPropertyData { property = property, defaultProperty = null };
                _overrideActorMaterialProperties.Add(materialName, data);
            }
        }

        public void RemoveOverrideMaterialProperty(string materialName)
        {
            if (_overrideActorMaterialProperties == null || string.IsNullOrEmpty(materialName)) return;
            if (!_overrideActorMaterialProperties.TryGetValue(materialName, out var data)) return;
            if (Application.isPlaying && _materialInfoTable.TryGetValue(materialName, out var materials))
            {
                foreach (var material in materials) ResetActorMaterialProperty(material, data);
            }
            data.property = null;
        }

        private void OverrideActorMaterialProperty(MaterialInfo materialInfo, OverrideActorMaterialPropertyData overrideProperty)
        {
            if (materialInfo == null) return;
            if (overrideProperty.defaultProperty == null)
            {
                overrideProperty.defaultProperty = new CampusActorMaterialProperty
                {
                    col = materialInfo.GetTexture(ShaderIDs._BaseMap),
                    def = materialInfo.GetTexture(ShaderIDs._DefMap),
                    sdw = materialInfo.GetTexture(ShaderIDs._ShadeMap)
                };
            }
            bool changed = false;
            if (overrideProperty.property.col != null)
            {
                materialInfo.SetTexture(ShaderIDs._BaseMap, overrideProperty.property.col);
                changed = true;
            }
            if (overrideProperty.property.sdw != null)
            {
                materialInfo.SetTexture(ShaderIDs._ShadeMap, overrideProperty.property.sdw);
                changed = true;
            }
            if (overrideProperty.property.def != null)
            {
                materialInfo.SetTexture(ShaderIDs._DefMap, overrideProperty.property.def);
                changed = true;
            }
            if (!changed) return;
            var property = overrideProperty.property;
            int tileX = property.tileX;
            int tileY = property.tileY;
            if (tileX > 1 || tileY > 1)
            {
                int frame = (int)(property.CurrentTime * property.tileFPS) % (tileX * tileY);
                float scaleX = 1f / tileX;
                float scaleY = 1f / tileY;
                materialInfo.SetVector(ShaderIDs._BaseMap_ST, new Vector4(scaleX, scaleY,
                    scaleX * (frame % tileX), 1f - scaleY * (frame / tileX + 1)));
            }
        }

        private void ResetActorMaterialProperty(MaterialInfo materialInfo, OverrideActorMaterialPropertyData overrideProperty)
        {
            if (materialInfo == null) return;
            if (overrideProperty.defaultProperty == null)
            {
                UnityEngine.Debug.LogError("OverrideActorMaterialPropertyが呼ばれていません");
                return;
            }
            materialInfo.SetTexture(ShaderIDs._BaseMap, overrideProperty.defaultProperty.col);
            materialInfo.SetTexture(ShaderIDs._ShadeMap, overrideProperty.defaultProperty.sdw);
            materialInfo.SetTexture(ShaderIDs._DefMap, overrideProperty.defaultProperty.def);
            materialInfo.SetVector(ShaderIDs._BaseMap_ST, new Vector4(1f, 1f, 0f, 0f));
        }

        private void UpdateHighLightMaterial()
        {
            if (!_materialInfoTable.TryGetValue("m_ehl", out var materials)) return;
            if (materials.Count != 1 || _eyeHighlight == null) return;
            float offset = _eyeHighlight != null ? _eyeHighlight.GetHighlightOffset() : 0f;
            materials[0].SetVector(ShaderIDs._BaseMap_ST, new Vector4(1f, 1f, 0f, offset));
        }

        private void UpdateMaterialInfos()
        {
            _materialInfoTable.Clear();
            _vlSkinningMaterialInfos.Clear();
            foreach (var entry in _partsIdMap)
            {
                bool hasSkinning = entry.Value.TryGetComponent<VL.Rendering.Skinning.VLSkinningModel>(out _);
                foreach (var material in entry.Value.materials)
                {
                    if (!_materialInfoTable.TryGetValue(material.name, out var materials))
                    {
                        materials = new List<MaterialInfo>(8);
                        _materialInfoTable.Add(material.name, materials);
                    }
                    materials.Add(material);
                    if (hasSkinning) _vlSkinningMaterialInfos.Add(material);
                }
            }
        }

        public void EnableBakedSwingBone(MotionDefine motionDefine)
        {
            var inactiveBones = ListPool<int>.Get();
            if (motionDefine != null && motionDefine.baseAnimation != null)
            {
                var animation = motionDefine.baseAnimation;
                for (int i = 0; i < animation.bindings.Count; i++)
                {
                    var binding = animation.bindings[i];
                    string name = binding.name;
                    if (name[name.Length - 1] == 'S' && name[name.Length - 2] == '_' &&
                        binding.type == "UnityEngine.Transform" && binding.properties != null && binding.properties.Count > 0)
                    {
                        var bone = GetBoneTransformByName(name.Substring(name.LastIndexOf('/') + 1));
                        if (bone != null) inactiveBones.Add(bone.GetInstanceID());
                    }
                }
            }
            if (_actorAnimation != null) _actorAnimation.SetInactiveBones(inactiveBones);
            ListPool<int>.Release(inactiveBones);
        }

        public void ResetBakeSwingBone()
        {
            if (_actorAnimation != null) _actorAnimation.SetInactiveBones(new List<int>());
        }

        public void SetupPropConstraintAnimation(MotionDefine motionDefine)
        {
            var actorMotion = motionDefine as ActorMotionDefine;
            if (actorMotion && !actorMotion.isAdditive)
            {
                foreach (var item in _childMap.Keys.Select(_003C_003Ec._003C_003E9__98_0 ?? (_003C_003Ec._003C_003E9__98_0 = _003C_003Ec._003C_003E9._003CSetupPropConstraintAnimation_003Eb__98_0)))
                {
                    if (descriptor.propIndexList == null || !descriptor.propIndexList.Contains(item.partsIndex)) continue;
                    if (!TryGetPartsFromAssetName(item.propName, out var parts))
                    {
                        UnityEngine.Debug.LogError("アニメーション対象のPropが見つかりませんでした");
                        continue;
                    }
                    if (!global::Qua.Extensions.IDictionaryExtensions.IsNullOrEmpty(descriptor.propFixConstraintDict)
                        && descriptor.propFixConstraintDict.TryGetValue(item.propName, out var fixedConstraint))
                    {
                        for (int i = 0; i < parts.transform.childCount; i++)
                        {
                            var child = parts.transform.GetChild(i);
                            if (child.name != null && child.name.StartsWith("Geo", StringComparison.Ordinal)) continue;
                            if (child.TryGetComponent<ActorAnimationConstraintTransformBone>(out var constraint))
                                SetupPropConstraintSource(constraint, new[] { fixedConstraint.constraintTargetJointName }, fixedConstraint.isAdaptScale);
                            else UnityEngine.Debug.LogError("コンストコンポーネントが見つかりませんでした。");
                        }
                    }
                    else if (!global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(actorMotion.propConstraints))
                    {
                        if (descriptor.autoPropVisible) parts.gameObject.SetActive(true);
                        for (int i = 0; i < parts.transform.childCount; i++)
                        {
                            var closure = new _003C_003Ec__DisplayClass98_0 { propLocator = parts.transform.GetChild(i) };
                            if (closure.propLocator.name != null && closure.propLocator.name.StartsWith("Geo", StringComparison.Ordinal)) continue;
                            var data = actorMotion.propConstraints.FirstOrDefault(closure._003CSetupPropConstraintAnimation_003Eb__1);
                            if (data != null)
                            {
                                if (closure.propLocator.TryGetComponent<ActorAnimationConstraintTransformBone>(out var constraint))
                                {
                                    SetupPropExecuteType(constraint, data.executeType);
                                    SetupPropConstraintSource(constraint, data.constraintTargets, data.isAdaptScale);
                                }
                                else UnityEngine.Debug.LogError("コンストコンポーネントが見つかりませんでした。");
                            }
                            else if (descriptor.autoPropVisible) parts.gameObject.SetActive(false);
                        }
                    }
                    else if (descriptor.autoPropVisible) parts.gameObject.SetActive(false);
                }
            }
            _actorAnimation.OnUpdate();
        }

        private void SetupPropExecuteType(ActorAnimationConstraintTransformBone transformConstraint, ActorAnimationConstraintExecuteType executeType)
        {
            transformConstraint.executeType = executeType;
        }

        private void SetupPropConstraintSource(ActorAnimationConstraintTransformBone transformConstraint, string[] constraintTargets, bool isAdaptScale)
        {
            transformConstraint.ClearCharacterSource();
            transformConstraint.ClearOffset();
            foreach (var target in constraintTargets)
            {
                if (TryGetBoneTransformByName(target, out var bone)) transformConstraint.AddSource(bone);
                else UnityEngine.Debug.LogError("コンストレイント先が見つかりませんでした");
                float scale = isAdaptScale ? GetHumanScale() / HeightCoefficient : 1f;
                transformConstraint.offsetScale = new float3(scale);
                transformConstraint.constraintWeight0 = new float3(1f);
            }
            transformConstraint.SetDirty();
        }

        public void SetPropFieldConstraintTarget(string propName, GameObject fieldConstraintTarget)
        {
            if (!TryGetPartsFromAssetName(propName, out var parts))
            {
                UnityEngine.Debug.LogError("アニメーション対象のPropが見つかりませんでした");
                return;
            }
            for (int i = 0; i < parts.transform.childCount; i++)
            {
                if (parts.transform.GetChild(i).TryGetComponent<ActorAnimationConstraintTransformBone>(out var constraint))
                {
                    constraint.fieldConstraintSource0 = fieldConstraintTarget.transform;
                    constraint.SetDirty();
                }
            }
        }

        public void ClearPropFieldConstraintTarget(string propName)
        {
            if (!TryGetPartsFromAssetName(propName, out var parts))
            {
                UnityEngine.Debug.LogError("アニメーション対象のPropが見つかりませんでした");
                return;
            }
            for (int i = 0; i < parts.transform.childCount; i++)
            {
                if (parts.transform.GetChild(i).TryGetComponent<ActorAnimationConstraintTransformBone>(out var constraint))
                {
                    constraint.ClearFieldSource();
                    constraint.SetDirty();
                }
            }
        }

        public void SetupSeatedDynamicCorrection(MotionDefine motionDefine)
        {
            var actorMotion = motionDefine as ActorMotionDefine;
            if (actorMotion && !actorMotion.isAdditive)
                _actorAnimation.SetEnableSeatedDynamicCorrection(actorMotion.enableSeatedDynamicCorrection);
        }

        [ContextMenu("SetupAllIKGoalToOverrideTarget")]
        public void SetupAllIKGoalToOverrideTarget()
        {
            for (int i = 0; i < _children.Count; i++)
            {
                if (_children[i].TryGetComponent<CampusActorAnimationFullBodyIKOverrideSettingHolder>(out var holder))
                {
                    _effectors = holder.OverrideEffectorBases(_effectors);
                    foreach (var effector in _effectors)
                    {
                        if (effector is IKGoalEffector goal)
                        {
                            _actorAnimation.DisableIKGoalForOverride(goal.goal);
                            _actorAnimation.SetupIKGoalForOverride(_animator, goal.transform, goal.goal, goal.HandleType);
                        }
                    }
                }
            }
        }

        [ContextMenu("ResetAllIKGoalToOriginalTarget")]
        public void ResetAllIKGoalToOriginalTarget()
        {
            ResetIKGoalToOriginalTarget(AvatarIKGoal.LeftHand);
            ResetIKGoalToOriginalTarget(AvatarIKGoal.RightHand);
            ResetIKGoalToOriginalTarget(AvatarIKGoal.LeftFoot);
            ResetIKGoalToOriginalTarget(AvatarIKGoal.RightFoot);
        }

        public void ResetIKGoalToOriginalTarget(AvatarIKGoal ikGoal)
        {
            foreach (var effector in _originalEffectors)
            {
                if (effector is IKGoalEffector goal && goal.goal == ikGoal)
                {
                    _actorAnimation.DisableIKGoalForOverride(ikGoal);
                    _actorAnimation.SetupIKGoalForOverride(_animator, goal.transform, goal.goal, goal.HandleType);
                }
            }
        }

        private void OnClipPlay(LayerParam layerParam, ClipParam clipParam, in FrameData info)
        {
            if (!_animationEventHandler.IsInitialized) _animationEventHandler.Initialize(this);
            if (clipParam == null) ResetBakeSwingBone();
            else
            {
                EnableBakedSwingBone(clipParam.motionDefine);
                SetupPropConstraintAnimation(clipParam.motionDefine);
                SetupSeatedDynamicCorrection(clipParam.motionDefine);
                if (Mathf.Approximately((float)clipParam.transitionTime, 0f))
                {
                    if (string.IsNullOrEmpty(layerParam.layerName)) ResetModel();
                    if (_facial != null) _facial.ResetEyeBlink();
                }
            }
            onClipPlay?.Invoke(this, layerParam, clipParam);
        }

        public void SetTalkActive(bool active)
        {
            if (_talk != null) _talk.TalkEnabled = active;
            if (_criTalk != null) _criTalk.TalkEnabled = active;
        }

        public void PlayTalk()
        {
            PlayTalk((CriAtomSource)null, GetHumanBodyBoneTransform(HumanBodyBones.Head), true, false, null);
        }

        public void PlayTalk(AudioSource source, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
            PlayTalk(source, GetHumanBodyBoneTransform(HumanBodyBones.Head), lipSyncEnabled, skipPlayState, selector);
        }

        public void PlayTalk(AudioSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
            TryInitializeTalk(false);
            if (_talk == null)
            {
                UnityEngine.Debug.LogError("Talk機能の生成に失敗しています");
                return;
            }
            _talk.TalkSpeed = _talkAnimationSpeed;
            if (source != null) _talk.PlayTalk(source, sourceTarget, lipSyncEnabled, skipPlayState, selector);
            else _talk.PlayTalk(selector);
        }

        public void PlayTalk(CriAtomSource source, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
            PlayTalk(source, GetHumanBodyBoneTransform(HumanBodyBones.Head), lipSyncEnabled, skipPlayState, selector);
        }

        public void PlayTalk(CriAtomSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
            TryInitializeTalk(true);
            if (_criTalk == null)
            {
                UnityEngine.Debug.LogError("CriTalk機能の生成に失敗しています");
                return;
            }
            _criTalk.TalkSpeed = _talkAnimationSpeed;
            if (source != null) _criTalk.PlayTalk(source, sourceTarget, lipSyncEnabled, skipPlayState, selector);
            else _criTalk.PlayTalk(selector);
        }

        public void StopTalk()
        {
            if (_talk != null) _talk.StopTalk();
            if (_criTalk != null) _criTalk.StopTalk();
        }

        public void UpdateTalkAdditive(float time, float weight)
        {
            if (_talk != null) _talk.UpdateAdditive(time, weight);
            if (_criTalk != null) _criTalk.UpdateAdditive(time, weight);
        }

        private void UpdateNodAdditive()
        {
            if (_criTalk == null || isOverrideNodAdditiveManual) return;
            _actorAnimation.nodAdditiveNeckFrontBackWeight = _criTalk.currentNodAdditiveNeckFrontBackRot / -40f;
            _actorAnimation.nodAdditiveNeckLeftRightWeight = _criTalk.currentNodAdditiveNeckLeftRightRot / -40f;
            _actorAnimation.nodAdditiveHeadFrontBackWeight = _criTalk.currentNodAdditiveHeadFrontBackRot / -40f;
            _actorAnimation.nodAdditiveHeadLeftRightWeight = _criTalk.currentNodAdditiveHeadLeftRightRot / -40f;
        }

        private void UpdateLookAtEyePitchCorrection()
        {
            if (_actorAnimation == null || _actorAnimation.CustomLookAtEffector == null) return;
            var effector = _actorAnimation.CustomLookAtEffector;
            if (effector.weight == 0f || _lookAtEyeSideCorrectionWeight == 1f) return;
            float weight = _lookAtEyeSideCorrectionWeight;
            if (effector is CampusCustomLookAtEffector campusEffector)
            {
                switch (campusEffector.customLookAtEyeCorrectionType)
                {
                    case CampusCustomLookAtEyeCorrectionType.AlwaysSideCorrection: break;
                    case CampusCustomLookAtEyeCorrectionType.ReferEyeWeightSideCorrection:
                        float eyeWeight = 0f;
                        foreach (var pose in campusEffector.poseSettings) eyeWeight += pose.setting.eyeEnableWeight * pose.weight;
                        weight = (_lookAtEyeSideCorrectionWeight - 1f) * (effector.eyesWeight / eyeWeight) + 1f;
                        break;
                    default: weight = 1f; break;
                }
            }
            foreach (var bone in new[] { HumanBodyBones.LeftEye, HumanBodyBones.RightEye })
            {
                var eye = GetHumanBodyBoneTransform(bone);
                var euler = ActorAnimationMathUtility.ToUnityEuler(eye.localRotation);
                var bendRoll = ActorAnimationMathUtility.EulerToBendrollZRoll(euler);
                float pitch = weight * bendRoll[1] * 0.017453292f;
                float yaw = bendRoll[2] * 0.017453292f;
                float roll = bendRoll[0] * 0.017453292f;
                eye.localRotation = ActorAnimationMathUtility.AxisrotationToQuaternionWithBendRoll(yaw, pitch, roll);
            }
        }

        public void ExecuteEyeBlink(bool forceBlink = false)
        {
            if (_facial == null) return;
            if (forceBlink)
            {
                if (_facial.IsEyeLimit()) return;
                _facial.NextBlinkTime = -1f;
            }
            else _facial.NextBlinkTime = 0f;
        }

        public void SetEyeBlinkWeight(float weight)
        {
            if (_facial != null) _facial.SetEyeBlinkWeight(weight);
        }

        public void SetEyeBlinkEnable(bool enable)
        {
            if (_facial != null) _facial.useBlink = enable;
        }

        public bool CanEyeBlink()
        {
            if (_facial == null) return false;
            return _facial.CanEyeBlink();
        }

        public void SetRendererActiveByReference(bool isActive, bool isReset = false)
        {
            if (isActive) _renderActiveCount = isReset ? 1 : _renderActiveCount + 1;
            else _renderActiveCount = isReset ? 0 : System.Math.Max(_renderActiveCount - 1, 0);
            SetRendererAndCollidersActive(_renderActiveCount > 0);
        }

        public void SetRendererAndCollidersActive(bool isActive)
        {
            SetRendererActive(isActive);
            SetEnableColliders(isActive);
        }

        private void SetEnableColliders(bool isActive)
        {
            if (_collider != null) _collider.SetEnableColliders(isActive);
        }

        protected override void OnActorDestroy()
        {
            base.OnActorDestroy();
            onActorDestroy?.Invoke(_index);
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
            if (_actorAnimation == null) return;
            _actorAnimation.Reset();
        }

        public override void ResetTime()
        {
            if (_actorAnimation != null) _actorAnimation.ResetTime();
        }

        public override void ApplyActorAnimationManagePropertyData(ActorAnimationManagePropertyData propertyData)
        {
            var camera = Camera.main;
            if (camera != null && camera.TryGetComponent<ActorAnimationManageData>(out var data))
            {
                var commonProperty = new ActorAnimationManagePropertyData
                {
                    weight = propertyData.weight,
                    swingPowerWeight = propertyData.swingPowerWeight,
                    swingBreastPowerWeight = propertyData.swingBreastPowerWeight,
                    swingBreastCorrectionPowerWeight = propertyData.swingBreastCorrectionPowerWeight,
                    rootWeight = propertyData.rootWeight,
                    rootHorizontalWeight = propertyData.rootHorizontalWeight,
                    rootVerticalWeight = propertyData.rootVerticalWeight,
                    prewarmCount = propertyData.prewarmCount
                };
                data.SetCommonPropertyData(ref commonProperty);
            }
        }

        public void ResetDynamicSkin()
        {
            if (_actorAnimation != null) _actorAnimation.ResetDynamicSkin();
        }

        private void SetupMoveConstraint()
        {
            var corrector = RegisterExtension<CampusActorHipCorrector>();
            corrector.Setup(GetBoneTransformByName(VLActorDefine.MOVE_BONE_NAME), GetHumanBodyBoneTransform(HumanBodyBones.Hips));
        }

        public float GetHumanScale()
        {
            return _animator != null ? _animator.humanScale : 1f;
        }

        public void SampleAnimation(AnimationClip clip, float time)
        {
            clip.SampleAnimation(gameObject, time);
        }

        public CustomGraphAnimationPlayer GetCustomGraphAnimationPlayer()
        {
            return _customGraphAnimationPlayer;
        }

        public void SetAnimationEventActive(bool active)
        {
            _animationEventHandler.SetAnimationEventActive(active);
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
            return _animationPlayer;
        }

        public IAnimationController PlayMotion(MotionDefine motion)
        {
            return _animationPlayer != null ? _animationPlayer.Play(new LayerParam(motion)) : null;
        }

        public IAnimationController PlayMotion(IEnumerable<MotionDefine> motions)
        {
            return _animationPlayer != null ? _animationPlayer.Play(new LayerParam(motions)) : null;
        }

        public IAnimationController GetAnimationController(LayerParam param)
        {
            if (_animationPlayer == null) return null;
            param.SetDefaultAnimations(_defaultAnimationData);
            return _animationPlayer.CreateLayerController(param);
        }

        public IAnimationController GetAnimationController(LayerParam param, OutputType outputType)
        {
            if (_animationPlayer == null) return null;
            param.SetDefaultAnimations(_defaultAnimationData);
            return _animationPlayer.CreateLayerController(outputType, param);
        }

        public IAnimationController GetPlayingAnimationController()
        {
            return _animationPlayer != null ? _animationPlayer.GetPlayingBaseController() as ILayerAnimationController : null;
        }

        public void PlayEffect(HumanBodyBones targetBone, ParticleSystem effect)
        {
            _effectController.PlayEffect(GetHumanBodyBoneTransform(targetBone), effect);
        }

        public void StopEffects()
        {
            _effectController.StopEffects();
        }

        private void StopEffect(ParticleSystem effect)
        {
            _effectController.StopEffect(effect);
        }

        public CampusActorController()
        {
        }

        bool Campus.Common.ICampusActorController.isDestroyed
        {
            get
            {
                return _isDestroyed;
            }
        }
    }
}
