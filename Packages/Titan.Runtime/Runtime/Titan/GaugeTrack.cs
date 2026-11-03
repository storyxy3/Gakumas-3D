namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(GaugeClip))]
    [DisplayName("Titan/Image/Gauge")]
    public class GaugeTrack : TweenerTrackBase<GaugeClip, Image, float, FloatParameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public Image component;
            public TweenCallback _003C_003E9__0;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal void _003CGetTween_003Eb__0()
            {
            }
        }

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
