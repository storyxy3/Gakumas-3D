namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextMeshProColorClip))]
    [DisplayName("Titan/TextMeshPro/Color")]
    public class TextMeshProColorTrack : ColorTweenerTrackBase<TextMeshProColorClip, TextMeshProUGUI>
    {
        protected override Color DefaultInitialValue
        {
            get
            {
                return default(Color);
            }
        }

        protected override Color GetValue(TextMeshProUGUI component)
        {
            return default(Color);
        }

        protected override void SetValue(Color value, TextMeshProUGUI component)
        {
        }

        public TextMeshProColorTrack()
        {
        }
    }
}
