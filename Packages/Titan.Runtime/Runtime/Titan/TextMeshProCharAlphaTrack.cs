namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharAlphaClip))]
    [DisplayName("Titan/TextMeshPro/CharAlpha")]
    public class TextMeshProCharAlphaTrack : TextMeshProCharTrackBase<TextMeshProCharAlphaClip, float, AlphaParameter>
    {
        protected override Tween CharTween(TextMeshProCharMeshModifier component, int index, float endValue, TextMeshProCharAlphaClip clipAsset, float duration)
        {
            return null;
        }

        protected override void SetCharValue(TextMeshProCharMeshModifier component, int index, float value)
        {
        }

        protected override float GetCharValue(TextMeshProCharMeshModifier component, int index)
        {
            return default(float);
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        public TextMeshProCharAlphaTrack()
        {
        }
    }
}
