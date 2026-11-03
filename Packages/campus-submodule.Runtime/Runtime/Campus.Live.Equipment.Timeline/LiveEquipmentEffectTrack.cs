namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(LiveEquipmentEffectClip))]
    [TrackColor(0.1f, 0f, 0.5f)]
    public class LiveEquipmentEffectTrack : LiveEquipmentTrackBase
    {
        public override LiveEquipmentStreamJobType JobType
        {
            get
            {
                return default(LiveEquipmentStreamJobType);
            }
        }

        public LiveEquipmentEffectTrack()
        {
        }
    }
}
