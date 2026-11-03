namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::TMPro;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextMeshProCountClip))]
    [DisplayName("Titan/TextMeshPro/Count")]
    public class TextMeshProCountTrack : LongTweenerTrackBase<TextMeshProCountClip, TextMeshProUGUI>
    {
        private static char[] _charBuffer;
        protected override long GetValue(TextMeshProUGUI component)
        {
            return default(long);
        }

        protected override void SetValue(long value, TextMeshProUGUI component)
        {
        }

        public TextMeshProCountTrack()
        {
        }
    }
}
