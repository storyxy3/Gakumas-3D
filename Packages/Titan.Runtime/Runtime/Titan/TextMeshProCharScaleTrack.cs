namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharScaleClip))]
    [DisplayName("Titan/TextMeshPro/CharScale")]
    public class TextMeshProCharScaleTrack : TextMeshProCharTrackBase<TextMeshProCharScaleClip, Vector2, Vector2Parameter>
    {
        protected override Tween CharTween(TextMeshProCharMeshModifier component, int index, Vector2 endValue, TextMeshProCharScaleClip clipAsset, float duration)
        {
            return null;
        }

        protected override void SetCharValue(TextMeshProCharMeshModifier component, int index, Vector2 value)
        {
        }

        protected override Vector2 GetCharValue(TextMeshProCharMeshModifier component, int index)
        {
            return default(Vector2);
        }

        protected override Vector2 AddValue(Vector2 a, Vector2 b)
        {
            return default(Vector2);
        }

        public TextMeshProCharScaleTrack()
        {
        }
    }
}
