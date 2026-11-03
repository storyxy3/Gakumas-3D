namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RotateRing))]
    [TrackClipType(typeof(RotateRingClip))]
    [DisplayName("Titan/RotateRing")]
    public class RotateRingTrack : TweenerTrackBase<RotateRingClip, RotateRing, RotateRingValue, RotateRingValueParameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public RotateRing component;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Vector2 _003CGetTween_003Eb__0()
            {
                return default(Vector2);
            }

            internal void _003CGetTween_003Eb__1(Vector2 x)
            {
            }
        }

        protected override Tween GetTween(RotateRing component, RotateRingValue endValue, RotateRingClip clipAsset, float duration)
        {
            return null;
        }

        protected override RotateRingValue AddValue(RotateRingValue a, RotateRingValue b)
        {
            return null;
        }

        protected override RotateRingValue GetValue(RotateRing component)
        {
            return null;
        }

        protected override void SetValue(RotateRingValue value, RotateRing component)
        {
        }

        public RotateRingTrack()
        {
        }
    }
}
