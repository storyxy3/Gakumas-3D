namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RotateRing))]
    [TrackClipType(typeof(RotateRingClip))]
    [DisplayName("Titan/RotateRing")]
    public class RotateRingTrack : TweenerTrackBase<RotateRingClip, RotateRing, RotateRingValue, RotateRingValueParameter>
    {
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
