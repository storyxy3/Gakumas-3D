namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(LiveEquipmentLaserClip))]
    [TrackColor(0.05f, 0.5f, 0.05f)]
    public class LiveEquipmentLaserTrack : LiveEquipmentTrackBase
    {
        public override LiveEquipmentStreamJobType JobType
        {
            get
            {
                return default(LiveEquipmentStreamJobType);
            }
        }

        public LiveEquipmentLaserTrack()
        {
        }
    }
}
