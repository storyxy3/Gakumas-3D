namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(BackgroundBlur))]
    [TrackClipType(typeof(BackgroundBlurMixWhiteAmountClip))]
    [DisplayName("Titan/BackgroundBlur/MixWhiteAmount")]
    public class BackgroundBlurMixWhiteAmountTrack : FloatTweenerTrackBase<BackgroundBlurMixWhiteAmountClip, BackgroundBlur>
    {
        protected override float GetValue(BackgroundBlur component)
        {
            return default(float);
        }

        protected override void SetValue(float value, BackgroundBlur component)
        {
        }

        public BackgroundBlurMixWhiteAmountTrack()
        {
        }
    }
}
