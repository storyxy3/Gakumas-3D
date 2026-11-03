namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalPathClip3D))]
    [DisplayName("Titan/Transform/3D/LocalPath3D")]
    public class LocalPathTrack3D : PathTrack3DBase<LocalPathClip3D>
    {
        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        public override void SetValue(Vector3 value, Transform component)
        {
        }

        public LocalPathTrack3D()
        {
        }
    }
}
