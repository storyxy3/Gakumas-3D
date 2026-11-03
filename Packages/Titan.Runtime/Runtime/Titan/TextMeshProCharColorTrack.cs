namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharColorClip))]
    [DisplayName("Titan/TextMeshPro/CharColor")]
    public class TextMeshProCharColorTrack : TextMeshProCharTrackBase<TextMeshProCharColorClip, Color, ColorParameter>
    {
        protected override Tween CharTween(TextMeshProCharMeshModifier component, int index, Color endValue, TextMeshProCharColorClip clipAsset, float duration)
        {
            return null;
        }

        protected override void SetCharValue(TextMeshProCharMeshModifier component, int index, Color value)
        {
        }

        protected override Color GetCharValue(TextMeshProCharMeshModifier component, int index)
        {
            return default(Color);
        }

        protected override Color AddValue(Color a, Color b)
        {
            return default(Color);
        }

        public TextMeshProCharColorTrack()
        {
        }
    }
}
