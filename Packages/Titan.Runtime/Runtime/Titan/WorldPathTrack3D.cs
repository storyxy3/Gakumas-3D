namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(WorldPathClip3D))]
    [DisplayName("Titan/Transform/3D/WorldPath3D")]
    public class WorldPathTrack3D : PathTrack3DBase<WorldPathClip3D>
    {
        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        public override void SetValue(Vector3 value, Transform component)
        {
        }

        public WorldPathTrack3D()
        {
        }
    }
}
