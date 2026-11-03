namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CrowdTimelineBehaviour : PlayableBehaviour
    {
        public CrowdMotionDefine crowdMotionDefine;
        public double skipDuration;
        public float maxDelay;
        public int delayRandomSeed;
        public bool hidePenlight;
        public CrowdTimelineBehaviour()
        {
        }
    }
}
