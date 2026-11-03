namespace Campus.Timeline
{
    using global::System.ComponentModel;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("Live/Campus Actor Reset Marker")]
    public class CampusActorResetMarker : Marker, INotification, INotificationOptionProvider
    {
        public PropertyName id
        {
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

        public CampusActorResetMarker()
        {
        }
    }
}
