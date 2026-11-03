namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextMeshProFadeClip))]
    [DisplayName("Titan/TextMeshPro/Fade")]
    public class TextMeshProFadeTrack : FloatTweenerTrackBase<TextMeshProFadeClip, TextMeshProUGUI>
    {
        protected override float DefaultInitialValue
        {
            get
            {
                return default(float);
            }
        }

        protected override float GetValue(TextMeshProUGUI component)
        {
            return default(float);
        }

        protected override void SetValue(float value, TextMeshProUGUI component)
        {
        }

        public TextMeshProFadeTrack()
        {
        }
    }
}
