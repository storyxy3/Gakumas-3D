namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextMeshProMaxVisibleCharactersClip))]
    [DisplayName("Titan/TextMeshPro/MaxVisibleCharacters")]
    public class TextMeshProMaxVisibleCharactersTrack : IntTweenerTrackBase<TextMeshProMaxVisibleCharactersClip, TextMeshProUGUI>
    {
        protected override int DefaultInitialValue
        {
            get
            {
                return default(int);
            }
        }

        protected override int GetValue(TextMeshProUGUI component)
        {
            return default(int);
        }

        protected override void SetValue(int value, TextMeshProUGUI component)
        {
        }

        public TextMeshProMaxVisibleCharactersTrack()
        {
        }
    }
}
