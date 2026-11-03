namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    public class CampusLookAtProhibitMixerBehaviour : PlayableBehaviour
    {
        internal ILookAtProhibitSource source;
        private int _sourceId;
        public override void OnGraphStart(Playable playable)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public CampusLookAtProhibitMixerBehaviour()
        {
        }
    }
}
