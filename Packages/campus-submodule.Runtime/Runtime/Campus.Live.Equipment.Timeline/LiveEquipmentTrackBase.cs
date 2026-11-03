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
                return null;
            }
        }

        public EquipmentValueFlags ReverseFlags
        {
            get
            {
                return default(EquipmentValueFlags);
            }

            set
            {
            }
        }

        public abstract LiveEquipmentStreamJobType JobType { get; }

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

        private void UpdateBaseParameter(LiveEquipmentController controller)
        {
        }

        public virtual void UpdateTrack(LiveEquipmentController controller)
        {
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            return default(Playable);
        }

        public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        protected LiveEquipmentTrackBase()
        {
        }
    }
}
