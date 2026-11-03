namespace Titan
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalRotateClip))]
    [DisplayName("Titan/Transform/LocalRotate")]
    public class LocalRotateTrack : Vector3TweenerTrackBase<LocalRotateClip, Transform>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public LocalRotateTrack _003C_003E4__this;
            public Transform component;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Quaternion _003CGetTween_003Eb__0()
            {
                return default(Quaternion);
            }

            internal void _003CGetTween_003Eb__1(Quaternion x)
            {
            }
        }

        protected override Tween GetTween(Transform component, Vector3 endValue, LocalRotateClip clipAsset, float duration)
        {
            return null;
        }

        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        protected override void SetValue(Vector3 value, Transform component)
        {
        }

        public LocalRotateTrack()
        {
        }
    }
}
