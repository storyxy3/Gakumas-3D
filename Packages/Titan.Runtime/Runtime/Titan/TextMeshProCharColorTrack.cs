namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharColorClip))]
    [DisplayName("Titan/TextMeshPro/CharColor")]
    public class TextMeshProCharColorTrack : TextMeshProCharTrackBase<TextMeshProCharColorClip, Color, ColorParameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TextMeshProCharColorTrack _003C_003E4__this;
            public TextMeshProCharMeshModifier component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Color _003CCharTween_003Eb__0()
            {
                return default(Color);
            }

            internal void _003CCharTween_003Eb__1(Color x)
            {
            }
        }

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
