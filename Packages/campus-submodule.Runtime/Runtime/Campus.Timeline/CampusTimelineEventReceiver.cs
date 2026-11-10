namespace Campus.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;

    [ExecuteAlways]
    public class CampusTimelineEventReceiver : VLActorExtension, INotificationReceiver
    {
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            if (notification is CampusActorResetMarker) controller.ResetModel();
        }

        public CampusTimelineEventReceiver()
        {
        }
    }
}
