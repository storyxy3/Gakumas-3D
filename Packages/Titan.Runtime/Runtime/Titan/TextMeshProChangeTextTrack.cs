namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextMeshProChangeTextClip))]
    [DisplayName("Titan/TextMeshPro/ChangeText")]
    public class TextMeshProChangeTextTrack : StringTweenerTrackBase<TextMeshProChangeTextClip, TextMeshProUGUI>
    {
        protected override string GetValue(TextMeshProUGUI component)
        {
            return null;
        }

        protected override void SetValue(string value, TextMeshProUGUI component)
        {
        }

        public TextMeshProChangeTextTrack()
        {
        }
    }
}
