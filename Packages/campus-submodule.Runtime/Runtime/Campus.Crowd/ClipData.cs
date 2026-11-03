namespace Campus.Crowd
{
    using global::System;
    using global::Campus.Crowd;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    internal class ClipData : IDisposable
    {
        private readonly Playable[] _playables;
        private readonly double[] _offsetTimes;
        public ClipData(AnimationMixerPlayable[] mixerPlayables, int index, CrowdMotionDefine motionDefine, double skipDuration, float maxDelay, int seed, bool isOverride = false)
        {
        }

        public void Dispose()
        {
        }

        public void SetTime(double time)
        {
        }

        private double[] OffsetTimes(double skipDuration, float maxDelay, int seed = 0)
        {
            return null;
        }
    }
}
