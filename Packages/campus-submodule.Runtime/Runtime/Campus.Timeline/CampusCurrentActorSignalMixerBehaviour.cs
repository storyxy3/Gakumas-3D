namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    public class CampusCurrentActorSignalMixerBehaviour : PlayableBehaviour
    {
        internal ICurrentActorSignalNotifier notifier;
        internal int slotIndex;
        internal int defaultActorIndex;
        private bool _hasNotifiedActorIndex;
        private int _lastNotifiedActorIndex;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public CampusCurrentActorSignalMixerBehaviour()
        {
        }
    }
}
