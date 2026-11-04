namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(LiveEquipmentLightClip))]
    [TrackColor(0.5f, 0.5f, 0.05f)]
    public class LiveEquipmentLightTrack : LiveEquipmentTrackBase
    {
        public override LiveEquipmentStreamJobType JobType
        {
            get
            {
                return (LiveEquipmentStreamJobType)10;
            }
        }

        public LiveEquipmentLightTrack()
        {
        }
    }
}
