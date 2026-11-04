namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(LiveEquipmentDirectionalLightClip))]
    [TrackColor(0.5f, 0.3f, 0.05f)]
    public class LiveEquipmentDirectionalLightTrack : LiveEquipmentTrackBase
    {
        public override LiveEquipmentStreamJobType JobType
        {
            get
            {
                return (LiveEquipmentStreamJobType)13;
            }
        }

        public LiveEquipmentDirectionalLightTrack()
        {
        }
    }
}
