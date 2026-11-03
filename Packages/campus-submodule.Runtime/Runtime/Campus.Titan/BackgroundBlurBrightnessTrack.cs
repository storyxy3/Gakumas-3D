namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(BackgroundBlur))]
    [TrackClipType(typeof(BackgroundBlurBrightnessClip))]
    [DisplayName("Titan/BackgroundBlur/Brightness")]
    public class BackgroundBlurBrightnessTrack : IntTweenerTrackBase<BackgroundBlurBrightnessClip, BackgroundBlur>
    {
        protected override int GetValue(BackgroundBlur component)
        {
            return default(int);
        }

        protected override void SetValue(int value, BackgroundBlur component)
        {
        }

        public BackgroundBlurBrightnessTrack()
        {
        }
    }
}
