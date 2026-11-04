namespace Campus.Live.Equipment.Timeline
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TrackBindingType(typeof(EquipmentValue), TrackBindingFlags.None)]
    public abstract class LiveEquipmentTrackBase : TrackAsset, ILayerable, IBpmTrack
    {
        [SerializeField]
        private EquipmentValueFlags _reverseFlags;
        private EquipmentValue _value;
        private ScriptPlayable<LiveEquipmentTrackBehaviour> _scriptPlayable;
        [CompilerGenerated]
        private CampusBpmInfo _003CBpmInfo_003Ek__BackingField;
        public EquipmentValue EquipmentValue
        {
            get
            {
                return _value;
            }
        }

        public EquipmentValueFlags ReverseFlags
        {
            get
            {
                return _reverseFlags;
            }

            set
            {
                _reverseFlags = value;
            }
        }

        public abstract LiveEquipmentStreamJobType JobType { get; }

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

        private void UpdateBaseParameter(LiveEquipmentController controller)
        {
            if (!_scriptPlayable.IsValid()) return;
            var behaviour = _scriptPlayable.GetBehaviour();
            behaviour.jobType = JobType;
            behaviour.animationData = controller.AnimationData;
            behaviour.equipmentValue = _value;
        }

        public virtual void UpdateTrack(LiveEquipmentController controller)
        {
            UpdateBaseParameter(controller);
            foreach (var clip in GetClips())
            {
                if (clip.asset != null && clip.asset is LiveEquipmentClipBase asset)
                {
                    asset.UpdateReverseFlags(_reverseFlags);
                    asset.UpdateBehaviour(controller);
                }
            }
            foreach (var child in GetChildTracks())
                if (child is LiveEquipmentTrackBase track) track.UpdateTrack(controller);
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return Playable.Create(graph, inputCount);
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            if (isSubTrack) BpmInfo = (parent as LiveEquipmentTrackBase).BpmInfo;
            (clip.asset as LiveEquipmentClipBase).BpmInfo = BpmInfo;
            return base.CreatePlayable(graph, gameObject, clip);
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            if (!go.TryGetComponent<LiveEquipmentController>(out var controller)) return Playable.Create(graph, inputCount);
            controller.Initialize();
            _value = null;
            if (controller.TryGetComponent<PlayableDirector>(out var director))
            {
                _value = director.GetGenericBinding(this) as EquipmentValue;
                if (_value != null) _value.SetController(controller);
            }
            _scriptPlayable = ScriptPlayable<LiveEquipmentTrackBehaviour>.Create(graph, inputCount);
            UpdateTrack(controller);
            return _scriptPlayable;
        }

        protected LiveEquipmentTrackBase()
        {
        }
    }
}
