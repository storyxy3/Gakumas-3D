namespace Campus.Timeline
{
    using global::UnityEngine.Playables;
    using global::UnityEngine.UI;

    public sealed class CampusTargetImageTrackBehaviour : PlayableBehaviour
    {
        private RawImage _rawImage;
        private bool _rawImageInitialStateEnabled;
        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public CampusTargetImageTrackBehaviour()
        {
        }
    }
}
