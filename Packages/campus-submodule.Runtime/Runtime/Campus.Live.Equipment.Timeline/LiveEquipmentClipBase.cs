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
        protected bool _useBpm;
        [SerializeField]
        protected FloatCurve rotateSpeed;
        [SerializeField]
        protected FloatCurve rotateAngle;
        [SerializeField]
        protected int _beat;
        [SerializeField]
        protected int _beatOffset;
        [SerializeField]
        private EquipmentValueFlags _ignoreReverseFlags;
        [SerializeField]
        protected ExposedReference<Transform> _lookAtTarget;
        [SerializeField]
        protected MovingMode _movingMode;
        protected EquipmentValueFactor _valueFactor;
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
                return default(bool);
            }
        }

        protected EquipmentValueFlags IgnoreReverseFlags
        {
            get
            {
                return default(EquipmentValueFlags);
            }
        }

        public AnimationPlayableAsset.LoopMode LoopMode
        {
            get
            {
                return default(AnimationPlayableAsset.LoopMode);
            }

            set
            {
            }
        }

        public FireType FireType
        {
            get
            {
                return default(FireType);
            }

            set
            {
            }
        }

        public float DelayInterval
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public float DelayOffset
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public int BeatOffset
        {
            get
            {
                return default(int);
            }
        }

        public CampusBpmInfo BpmInfo
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int Beat
        {
            get
            {
                return default(int);
            }
        }

        public virtual ClipCaps clipCaps
        {
            get
            {
                return default(ClipCaps);
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            return default(Playable);
        }

        public void UpdateReverseFlags(EquipmentValueFlags reverseFlags)
        {
        }

        public abstract void UpdateBehaviour();
        public abstract void UpdateBehaviour(LiveEquipmentController controller);
        protected LiveEquipmentClipBase()
        {
        }
    }
}
