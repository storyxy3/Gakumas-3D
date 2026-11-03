namespace Titan
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening.Core;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(IntervalClip))]
    [DisplayName("Titan/Interval")]
    public class IntervalTrack : TweenTrackBase
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static DOGetter<float> _003C_003E9__0_0;
            public static DOSetter<float> _003C_003E9__0_1;
            public _003C_003Ec()
            {
            }

            internal float _003CInsertTween_003Eb__0_0()
            {
                return default(float);
            }

            internal void _003CInsertTween_003Eb__0_1(float x)
            {
            }
        }

        protected override void InsertTween(TweenCreationContext context)
        {
        }

        public IntervalTrack()
        {
        }
    }
}
