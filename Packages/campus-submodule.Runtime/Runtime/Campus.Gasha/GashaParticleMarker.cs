namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaParticleMarker")]
    public class GashaParticleMarker : Marker, INotification, INotificationOptionProvider
    {
        public enum PlayState
        {
            Play,
            Stop
        }

        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public PlayState playState;
        public string particleId;
        public bool playOnSkipped;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return _003Cid_003Ek__BackingField;
            }
        }

        public NotificationFlags flags
        {
            get
            {
                return default(NotificationFlags);
            }
        }

        public GashaParticleMarker()
        {
        }
    }
}
