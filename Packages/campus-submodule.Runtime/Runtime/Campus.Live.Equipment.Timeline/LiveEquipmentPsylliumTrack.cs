namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Campus.Live.Equipment.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(LiveEquipmentPsylliumClip))]
    [TrackColor(0.5f, 0.25f, 0.05f)]
    public class LiveEquipmentPsylliumTrack : LiveEquipmentTrackBase
    {
        [SerializeField]
        private int _psylliumPackedColor;
        public int PsylliumPackedColor
        {
            get
            {
                return default(int);
            }
        }

        public override LiveEquipmentStreamJobType JobType
        {
            get
            {
                return default(LiveEquipmentStreamJobType);
            }
        }

        public LiveEquipmentPsylliumTrack()
        {
        }
    }
}
