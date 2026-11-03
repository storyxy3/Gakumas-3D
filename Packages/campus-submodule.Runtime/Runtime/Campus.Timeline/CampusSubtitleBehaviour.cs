namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Live;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusSubtitleBehaviour : PlayableBehaviour
    {
        public SRTSubtitle subtitle;
        private string _lastSubtitle;
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        private string GetSubtitle(float time, SRTSubtitle block)
        {
            return null;
        }

        public CampusSubtitleBehaviour()
        {
        }
    }
}
