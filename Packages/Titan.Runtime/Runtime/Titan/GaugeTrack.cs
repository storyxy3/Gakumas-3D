namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(GaugeClip))]
    [DisplayName("Titan/Image/Gauge")]
    public class GaugeTrack : TweenerTrackBase<GaugeClip, Image, float, FloatParameter>
    {
        protected override Tween GetTween(Image component, float endValue, GaugeClip clipAsset, float duration)
        {
            return null;
        }

        protected override float GetValue(Image component)
        {
            return default(float);
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        protected override void SetValue(float value, Image component)
        {
        }

        private void SetFullGaugeTween(GaugeClip clipAsset, float position)
        {
        }

        public GaugeTrack()
        {
        }
    }
}
