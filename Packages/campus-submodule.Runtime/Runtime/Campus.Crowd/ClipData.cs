namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;

    internal class ClipData : IDisposable
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass5_0
        {
            public double skipDuration;
            public float min;
            public float max;
            public _003C_003Ec__DisplayClass5_0()
            {
            }

            internal double _003COffsetTimes_003Eb__0(int _)
            {
                return default(double);
            }
        }

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
