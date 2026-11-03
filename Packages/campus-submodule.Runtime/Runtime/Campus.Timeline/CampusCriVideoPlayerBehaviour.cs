namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusCriVideoPlayerBehaviour : PlayableBehaviour
    {
        [NonSerialized]
        public CampusTimelineCriVideoPlayer videoPlayer;
        [NonSerialized]
        public double[] syncMarkerTimes;
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        private void ProcessResetMarker(Playable playable, FrameData info)
        {
        }

        private bool CrossedResetMarker(double previousTime, double currentTime)
        {
            return default(bool);
        }

        public CampusCriVideoPlayerBehaviour()
        {
        }
    }
}
