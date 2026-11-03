namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharRotationClip))]
    [DisplayName("Titan/TextMeshPro/CharRotation")]
    public class TextMeshProCharRotationTrack : TextMeshProCharTrackBase<TextMeshProCharRotationClip, Vector3, Vector3Parameter>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public TextMeshProCharRotationTrack _003C_003E4__this;
            public TextMeshProCharMeshModifier component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Quaternion _003CCharTween_003Eb__0()
            {
                return default(Quaternion);
            }

            internal void _003CCharTween_003Eb__1(Quaternion x)
            {
            }
        }

        protected override Tween CharTween(TextMeshProCharMeshModifier component, int index, Vector3 endValue, TextMeshProCharRotationClip clipAsset, float duration)
        {
            return null;
        }

        protected override void SetCharValue(TextMeshProCharMeshModifier component, int index, Vector3 value)
        {
        }

        protected override Vector3 GetCharValue(TextMeshProCharMeshModifier component, int index)
        {
            return default(Vector3);
        }

        protected override Vector3 AddValue(Vector3 a, Vector3 b)
        {
            return default(Vector3);
        }

        public TextMeshProCharRotationTrack()
        {
        }
    }
}
