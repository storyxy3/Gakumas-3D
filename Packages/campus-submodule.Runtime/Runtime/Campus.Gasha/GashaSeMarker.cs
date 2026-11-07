namespace Campus.Gasha
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("ガシャ/GashaSeMarker")]
    public class GashaSeMarker : Marker, INotification, INotificationOptionProvider
    {
        [CompilerGenerated]
        private readonly PropertyName _003Cid_003Ek__BackingField;
        public string assetName;
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

        public GashaSeMarker()
        {
        }
    }
}
