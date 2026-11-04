namespace Campus.Live.Equipment.Timeline
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public abstract class LiveEquipmentClipBase : PlayableAsset, ITimelineClipAsset
    {
        [SerializeField]
        private AnimationPlayableAsset.LoopMode m_Loop;
        [SerializeField]
        protected FireType _fireType;
        [SerializeField]
        protected float _delayInterval;
        [SerializeField]
        protected float _delayOffset;
        [SerializeField]
        protected bool _useBpm = true;
        [SerializeField]
        protected FloatCurve rotateSpeed;
        [SerializeField]
        protected FloatCurve rotateAngle;
        [SerializeField]
        protected int _beat = 1;
        [SerializeField]
        protected int _beatOffset;
        [SerializeField]
        private EquipmentValueFlags _ignoreReverseFlags;
        [SerializeField]
        protected ExposedReference<Transform> _lookAtTarget;
        [SerializeField]
        protected MovingMode _movingMode;
        protected EquipmentValueFactor _valueFactor = new EquipmentValueFactor { v0 = 1f, v1 = 1f, v2 = 1f, v3 = 1f };
        [HideInInspector]
        public LiveEquipmentTrackBase track;
        public LiveEquipmentAnimationCurve curves;
        public bool isSubTrack;
        protected LiveEquipmentController controller;
        [CompilerGenerated]
        private CampusBpmInfo _003CBpmInfo_003Ek__BackingField;
        public bool UseBpm
        {
            get
            {
                return _useBpm;
            }
        }

        protected EquipmentValueFlags IgnoreReverseFlags
        {
            get
            {
                return _ignoreReverseFlags;
            }
        }

        public AnimationPlayableAsset.LoopMode LoopMode
        {
            get
            {
                return m_Loop;
            }

            set
            {
                m_Loop = value;
            }
        }

        public FireType FireType
        {
            get
            {
                return _fireType;
            }

            set
            {
                _fireType = value;
            }
        }

        public float DelayInterval
        {
            get
            {
                return _delayInterval;
            }

            set
            {
                _delayInterval = value;
            }
        }

        public float DelayOffset
        {
            get
            {
                return _delayOffset;
            }

            set
            {
                _delayOffset = value;
            }
        }

        public int BeatOffset
        {
            get
            {
                return _beatOffset;
            }
        }

        public CampusBpmInfo BpmInfo
        {
            [CompilerGenerated]
            get
            {
                return _003CBpmInfo_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CBpmInfo_003Ek__BackingField = value;
            }
        }

        public int Beat
        {
            get
            {
                return _beat;
            }
        }

        public virtual ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.Extrapolation | ClipCaps.Blending;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return Playable.Create(graph);
        }

        public void UpdateReverseFlags(EquipmentValueFlags reverseFlags)
        {
            _valueFactor.v0 = reverseFlags.v0 && !_ignoreReverseFlags.v0 ? -1f : 1f;
            _valueFactor.v1 = reverseFlags.v1 && !_ignoreReverseFlags.v1 ? -1f : 1f;
            _valueFactor.v2 = reverseFlags.v2 && !_ignoreReverseFlags.v2 ? -1f : 1f;
            _valueFactor.v3 = reverseFlags.v3 && !_ignoreReverseFlags.v3 ? -1f : 1f;
        }

        public abstract void UpdateBehaviour();
        public abstract void UpdateBehaviour(LiveEquipmentController controller);
        protected LiveEquipmentClipBase()
        {
        }
    }
}
