namespace Campus.Crowd
{
    using global::System;
    using global::System.Linq;
    using global::UnityEngine;
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
                return skipDuration - UnityEngine.Random.Range(min, max);
            }
        }

        private readonly Playable[] _playables;
        private readonly double[] _offsetTimes;
        public ClipData(AnimationMixerPlayable[] mixerPlayables, int index, CrowdMotionDefine motionDefine, double skipDuration, float maxDelay, int seed, bool isOverride = false)
        {
            _playables = new Playable[isOverride ? 4 : 8];
            int count = motionDefine.count;
            skipDuration = Math.Max(0d, skipDuration);
            for (int i = 0; i < _playables.Length; i++)
            {
                var animationData = motionDefine[i % count];
                if (animationData != null)
                {
                    _playables[i] = animationData.CreateAnimationClipPlayable(mixerPlayables[i].GetGraph());
                    _playables[i].SetDuration(animationData.animationLength);
                    mixerPlayables[i].ConnectInput(index, _playables[i], 0, 1f);
                }
            }
            _offsetTimes = OffsetTimes(skipDuration, maxDelay, seed);
        }

        public void Dispose()
        {
            for (int i = 0; i < _playables.Length; i++) _playables[i].Destroy();
        }

        public void SetTime(double time)
        {
            for (int i = 0; i < _playables.Length; i++)
            {
                var playable = _playables[i];
                if (playable.IsValid())
                {
                    double duration = playable.GetDuration();
                    playable.SetTime((duration + _offsetTimes[i] + time) % duration);
                }
            }
        }

        private double[] OffsetTimes(double skipDuration, float maxDelay, int seed = 0)
        {
            var closure = new _003C_003Ec__DisplayClass5_0 { skipDuration = skipDuration };
            var state = UnityEngine.Random.state;
            UnityEngine.Random.InitState(seed);
            closure.min = Mathf.Min(0f, maxDelay);
            closure.max = Mathf.Max(0f, maxDelay);
            var times = Enumerable.Range(0, 8).Select(closure._003COffsetTimes_003Eb__0).ToArray();
            UnityEngine.Random.state = state;
            return times;
        }
    }
}
