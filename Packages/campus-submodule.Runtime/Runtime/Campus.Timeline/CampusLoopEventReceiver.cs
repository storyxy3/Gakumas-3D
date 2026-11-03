namespace Campus.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [ExecuteAlways]
    [RequireComponent(typeof(PlayableDirector))]
    public class CampusLoopEventReceiver : MonoBehaviour, INotificationReceiver
    {
        public PlayableDirector director;
        private void OnValidate()
        {
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
        }

        public CampusLoopEventReceiver()
        {
        }
    }
}
