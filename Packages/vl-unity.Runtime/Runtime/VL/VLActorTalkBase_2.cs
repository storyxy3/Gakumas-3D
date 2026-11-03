namespace VL
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;
    using global::VL.FaceSystem;
    using global::VL.Unsafe.Jobs;

    [Serializable]
    public abstract class VLActorTalkBase<TActorTalkFFT, TAudioSource> : VLActorExtension, IVLActorTalk where TActorTalkFFT : IVLActorTalkFFT<TAudioSource> where TAudioSource : Component
    {
        public const int ROOT_PLAYABLE_ORDER = -50;
        public const int BlendShapeCapacity = 64;
        public const int TalkCapacity = 64;
        public float talkTransitionTime;
        [SerializeField]
        private VLActorTalkData _data;
        [SerializeField]
        private VLActorFaceModel _faceModel;
        [SerializeField]
        private List<SkinnedMeshRenderer> _renderers;
        public bool isTalk;
        public bool skipPlayStateCheck;
        [SerializeField]
        private float talkSpeed;
        [SerializeField]
        private bool _talkEnabled;
        private IAnimationPlayer _animationPlayer;
        private Transform _sourceTarget;
        private Vector3 _defaultSourcePosition;
        [SerializeField]
        protected TActorTalkFFT _fft;
        [SerializeField]
        private float additiveScale;
        [SerializeField]
        private bool autoAdditiveDisabled;
        [CompilerGenerated]
        private float _003CtalkWeight_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CdeltaTalkWeight_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CadditiveWeight_003Ek__BackingField;
        private int _additiveIndex;
        private float _additiveTime;
        private bool _isUpdateAdditive;
        private float _currentAdditiveTime;
        private float _currentAdditiveWeight;
        private int _neckJointIndex;
        private int _headJointIndex;
        [CompilerGenerated]
        private float _003CcurrentNodAdditiveNeckFrontBackRot_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CcurrentNodAdditiveNeckLeftRightRot_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CcurrentNodAdditiveHeadFrontBackRot_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CcurrentNodAdditiveHeadLeftRightRot_003Ek__BackingField;
        private Transform[] _additiveTransforms;
        private NativeList<TalkBlendShapeJobData> _talkBlendShapeData;
        private NativeList<TalkJobData> _talkData;
        private NativeArray<TalkCurveJobData> _talkCurveData;
        private NativeArray<KeyframeData> _keyframeData;
        private NativeArray<TalkTargetJobData> _talkTargetData;
        private Dictionary<string, int> _blendShapeNameToIndex;
        private AnimationScriptPlayable _scriptPlayable;
        public float TalkSpeed
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool TalkEnabled
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public TActorTalkFFT fft
        {
            get
            {
                return default(TActorTalkFFT);
            }
        }

        public float AdditiveScale
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public bool AutoAdditiveDisabled
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public float talkWeight
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int deltaTalkWeight
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float additiveWeight
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float currentNodAdditiveNeckFrontBackRot
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float currentNodAdditiveNeckLeftRightRot
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float currentNodAdditiveHeadFrontBackRot
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float currentNodAdditiveHeadLeftRightRot
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        private void InitializeBlendShape(Animator animator, string[] targetBlendShapes)
        {
        }

        private void InitializeBlendShapeLegacy(Animator animator, HashSet<string> targetBlendShapeSet)
        {
        }

        public override void Initialize()
        {
        }

        public override void Dispose()
        {
        }

        public bool Setup(VLActorTalkData data, VLActorFaceModel faceModel, List<SkinnedMeshRenderer> renderers)
        {
            return default(bool);
        }

        private RootPlayableData OnConnect(PlayableGraph graph, Playable childPlayable)
        {
            return default(RootPlayableData);
        }

        private Playable OnDisconnect(PlayableGraph graph, RootPlayableData currentData)
        {
            return default(Playable);
        }

        public override void OnUpdate()
        {
        }

        protected abstract bool ShouldReset(TAudioSource source);
        public override void OnLateUpdate()
        {
        }

        public void UpdateAdditive(float time, float weight)
        {
        }

        private void InitializeAdditive(Transform transform, int index, float scale)
        {
        }

        protected abstract void CreateVLActorTalkFFT();
        public void PlayTalk(TAudioSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
        }

        protected abstract void OnPlayTalk(TAudioSource source);
        public void PlayTalk([Optional] VLTalkMotionSelector selector)
        {
        }

        public void StopTalk()
        {
        }

        private void Reset()
        {
        }

        protected abstract void OnReset();
        public static int DefaultAdditiveClipSelector(int length)
        {
            return default(int);
        }

        public void SetTalkSpeed(float speed)
        {
        }

        protected VLActorTalkBase()
        {
        }
    }
}
