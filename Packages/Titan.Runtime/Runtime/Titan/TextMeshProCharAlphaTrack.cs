namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharAlphaClip))]
    [DisplayName("Titan/TextMeshPro/CharAlpha")]
    public class TextMeshProCharAlphaTrack : TextMeshProCharTrackBase<TextMeshProCharAlphaClip, float, AlphaParameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TextMeshProCharAlphaTrack _003C_003E4__this;
            public TextMeshProCharMeshModifier component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal float _003CCharTween_003Eb__0()
            {
                return default(float);
            }

            internal void _003CCharTween_003Eb__1(float x)
            {
            }
        }

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
