namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharPivotClip))]
    [DisplayName("Titan/TextMeshPro/CharPivot")]
    public class TextMeshProCharPivotTrack : TextMeshProCharTrackBase<TextMeshProCharPivotClip, Vector2, Vector2Parameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TextMeshProCharPivotTrack _003C_003E4__this;
            public TextMeshProCharMeshModifier component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Vector2 _003CCharTween_003Eb__0()
            {
                return default(Vector2);
            }

            internal void _003CCharTween_003Eb__1(Vector2 x)
            {
            }
        }

        protected override Tween CharTween(TextMeshProCharMeshModifier component, int index, Vector2 endValue, TextMeshProCharPivotClip clipAsset, float duration)
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

        public TextMeshProCharPivotTrack()
        {
        }
    }
}
