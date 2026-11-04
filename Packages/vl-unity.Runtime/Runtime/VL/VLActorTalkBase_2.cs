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
                return talkSpeed;
            }

            set
            {
                talkSpeed = value;
            }
        }

        public bool TalkEnabled
        {
            get
            {
                return _talkEnabled;
            }

            set
            {
                _talkEnabled = value;
            }
        }

        public TActorTalkFFT fft
        {
            get
            {
                return _fft;
            }
        }

        public float AdditiveScale
        {
            get
            {
                return additiveScale;
            }

            set
            {
                additiveScale = value;
            }
        }

        public bool AutoAdditiveDisabled
        {
            get
            {
                return autoAdditiveDisabled;
            }

            set
            {
                autoAdditiveDisabled = value;
            }
        }

        public float talkWeight
        {
            [CompilerGenerated]
            get
            {
                return _003CtalkWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CtalkWeight_003Ek__BackingField = value;
            }
        }

        public int deltaTalkWeight
        {
            [CompilerGenerated]
            get
            {
                return _003CdeltaTalkWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CdeltaTalkWeight_003Ek__BackingField = value;
            }
        }

        public float additiveWeight
        {
            [CompilerGenerated]
            get
            {
                return _003CadditiveWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CadditiveWeight_003Ek__BackingField = value;
            }
        }

        public float currentNodAdditiveNeckFrontBackRot
        {
            [CompilerGenerated]
            get
            {
                return _003CcurrentNodAdditiveNeckFrontBackRot_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcurrentNodAdditiveNeckFrontBackRot_003Ek__BackingField = value;
            }
        }

        public float currentNodAdditiveNeckLeftRightRot
        {
            [CompilerGenerated]
            get
            {
                return _003CcurrentNodAdditiveNeckLeftRightRot_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcurrentNodAdditiveNeckLeftRightRot_003Ek__BackingField = value;
            }
        }

        public float currentNodAdditiveHeadFrontBackRot
        {
            [CompilerGenerated]
            get
            {
                return _003CcurrentNodAdditiveHeadFrontBackRot_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcurrentNodAdditiveHeadFrontBackRot_003Ek__BackingField = value;
            }
        }

        public float currentNodAdditiveHeadLeftRightRot
        {
            [CompilerGenerated]
            get
            {
                return _003CcurrentNodAdditiveHeadLeftRightRot_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcurrentNodAdditiveHeadLeftRightRot_003Ek__BackingField = value;
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
            _currentAdditiveTime = time;
            _currentAdditiveWeight = weight;
            _isUpdateAdditive = true;
        }

        private void InitializeAdditive(Transform transform, int index, float scale)
        {
            if (_animationPlayer == null || _animationPlayer.animator == null) return;
            if (_data.additiveDatas == null || _data.additiveDatas.Length <= index || _additiveIndex == index) return;
            _additiveIndex = index;
            _additiveTime = Time.time;
            additiveScale = scale;
            var data = _data.additiveDatas[index];
            if (_additiveTransforms == null || _additiveTransforms.Length != data.bindings.Length)
                _additiveTransforms = new Transform[data.bindings.Length];
            for (int i = 0; i < data.bindings.Length; ++i)
                _additiveTransforms[i] = transform.Find(data.bindings[i].path);
        }

        protected abstract void CreateVLActorTalkFFT();
        public void PlayTalk(TAudioSource source, Transform sourceTarget, bool lipSyncEnabled, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool skipPlayState, [Optional] VLTalkMotionSelector selector)
        {
            PlayTalk(selector);
            if (source != null)
            {
                _sourceTarget = sourceTarget;
                _fft.SetAudioSource(source);
                OnPlayTalk(source);
                if (_sourceTarget) _defaultSourcePosition = source.transform.position;
            }
            isTalk = lipSyncEnabled;
            skipPlayStateCheck = skipPlayState;
        }

        protected abstract void OnPlayTalk(TAudioSource source);
        public void PlayTalk([Optional] VLTalkMotionSelector selector)
        {
            if (_data == null) return;
            if (selector == null) selector = DefaultAdditiveClipSelector;
            InitializeAdditive(transform, selector(_data.additiveDatas?.Length ?? 0), additiveScale);
            isTalk = true;
            skipPlayStateCheck = true;
        }

        public void StopTalk()
        {
            Reset();
        }

        private void Reset()
        {
            if (_sourceTarget && _fft.audioSource != null)
                _fft.audioSource.transform.position = _defaultSourcePosition;
            if (_fft != null) _fft.Reset();
            isTalk = false;
            OnReset();
        }

        protected abstract void OnReset();
        public static int DefaultAdditiveClipSelector(int length)
        {
            return UnityEngine.Random.Range(0, length);
        }

        public void SetTalkSpeed(float speed)
        {
            if (!_scriptPlayable.IsValid()) return;
            for (int i = 0; i < _data.talks.Length; ++i)
            {
                var input = _scriptPlayable.GetInput(i);
                if (input.IsValid()) input.SetSpeed(speed);
            }
        }

        protected VLActorTalkBase()
        {
        }
    }
}
