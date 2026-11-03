namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalRotateClip))]
    [DisplayName("Titan/Transform/LocalRotate")]
    public class LocalRotateTrack : Vector3TweenerTrackBase<LocalRotateClip, Transform>
    {
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
