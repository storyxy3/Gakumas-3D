namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(WorldPathClip))]
    [DisplayName("Titan/Transform/WorldPath")]
    public class WorldPathTrack : PathTrackBase<WorldPathClip>
    {
        protected override Tween GetTween(Transform component, WorldPathClip clipAsset, float duration)
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

        public WorldPathTrack()
        {
        }
    }
}
