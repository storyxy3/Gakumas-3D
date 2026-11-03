namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(FillAmountClip))]
    [DisplayName("Titan/Image/FillAmount")]
    public class FillAmountTrack : FloatTweenerTrackBase<FillAmountClip, Image>
    {
        protected override float GetValue(Image component)
        {
            return default(float);
        }

        protected override void SetValue(float value, Image component)
        {
        }

        public FillAmountTrack()
        {
        }
    }
}
