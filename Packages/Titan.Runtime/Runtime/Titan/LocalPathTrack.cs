namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalPathClip))]
    [DisplayName("Titan/Transform/LocalPath")]
    public class LocalPathTrack : PathTrackBase<LocalPathClip>
    {
        protected override Tween GetTween(Transform component, LocalPathClip clipAsset, float duration)
        {
            return null;
        }

        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        public override void SetValue(Vector3 value, Transform component)
        {
        }

        public LocalPathTrack()
        {
        }
    }
}
