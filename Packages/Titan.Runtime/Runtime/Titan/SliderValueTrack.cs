namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Slider))]
    [TrackClipType(typeof(SliderValueClip))]
    [DisplayName("Titan/Slider/Value")]
    public class SliderValueTrack : FloatTweenerTrackBase<SliderValueClip, Slider>
    {
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override float GetValue(Slider component)
        {
            return default(float);
        }

        protected override void SetValue(float value, Slider component)
        {
        }

        public SliderValueTrack()
        {
        }
    }
}
