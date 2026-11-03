namespace Campus.Timeline
{
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    public class CampusCriMixerBehaviour : PlayableBehaviour
    {
        public CampusTimelineCriVideoPlayer player;
        private bool _wasActiveClipLastFrame;
        private int _lastActiveInputIndex;
        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        private bool TryGetActiveClip(Playable playable, out Playable clipPlayable)
        {
            throw null;
        }

        public CampusCriMixerBehaviour()
        {
        }
    }
}
