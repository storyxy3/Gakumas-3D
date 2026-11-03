namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaSupportVoiceMarker")]
    public class GashaSupportVoiceMarker : Marker, INotification, INotificationOptionProvider
    {
        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public int voiceIndex;
        public PropertyName id
        {
            [CompilerGenerated]
            get
            {
                return default(PropertyName);
            }
        }

        public NotificationFlags flags
        {
            get
            {
                return default(NotificationFlags);
            }
        }

        public GashaSupportVoiceMarker()
        {
        }
    }
}
