namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusCrossFadeBehaviour : PlayableBehaviour
    {
        public enum CrossFadeType
        {
            AlphaFade
        }

        public CrossFadeType crossFadeType;
        public CampusCrossFadeBehaviour()
        {
        }
    }
}
