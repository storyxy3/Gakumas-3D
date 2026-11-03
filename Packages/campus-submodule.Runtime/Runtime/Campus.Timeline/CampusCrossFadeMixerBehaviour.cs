namespace Campus.Timeline
{
    using global::Campus.Common.Live;
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;

    public class CampusCrossFadeMixerBehaviour : PlayableBehaviour
    {
        public CampusCrossFadeImage target;
        private int _lastProcessHash;
        private int _lastCapturedPlayableHash;
        private double _lastCapturedTime;
        private RTHandle _cachedCapturedRTHandle;
        private void ReleaseCapturedTexture()
        {
        }

        private RTHandle GetCapturedTexture()
        {
            return null;
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void PrepareFrame(Playable playable, FrameData info)
        {
        }

        private void OnClipPlay(ScriptPlayable<CampusCrossFadeBehaviour> playable, double time)
        {
        }

        public CampusCrossFadeMixerBehaviour()
        {
        }
    }
}
