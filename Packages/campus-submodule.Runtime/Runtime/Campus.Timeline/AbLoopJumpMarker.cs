namespace Campus.Timeline
{
    using global::System.ComponentModel;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [DisplayName("Live/AB Loop Jump Marker")]
    [CustomStyle("ABLoopJumpMarker")]
    public class AbLoopJumpMarker : Marker, INotification, INotificationOptionProvider
    {
        [HideInInspector]
        public AbLoopDestinationMarker startMarker;
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

        public AbLoopJumpMarker()
        {
        }
    }
}
