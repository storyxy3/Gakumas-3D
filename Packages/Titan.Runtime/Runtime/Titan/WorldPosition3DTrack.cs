namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(WorldPosition3DClip))]
    [DisplayName("Titan/Transform/3D/WorldPosition3D")]
    public class WorldPosition3DTrack : Vector3TweenerTrackBase<WorldPosition3DClip, Transform>
    {
        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        protected override void SetValue(Vector3 value, Transform component)
        {
        }

        public WorldPosition3DTrack()
        {
        }
    }
}
