namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(TextMeshProCharRotationClip))]
    [DisplayName("Titan/TextMeshPro/CharRotation")]
    public class TextMeshProCharRotationTrack : TextMeshProCharTrackBase<TextMeshProCharRotationClip, Vector3, Vector3Parameter>
    {
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
