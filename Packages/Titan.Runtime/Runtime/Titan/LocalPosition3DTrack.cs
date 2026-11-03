namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalPosition3DClip))]
    [DisplayName("Titan/Transform/3D/LocalPosition3D")]
    public class LocalPosition3DTrack : Vector3TweenerTrackBase<LocalPosition3DClip, Transform>
    {
        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        protected override void SetValue(Vector3 value, Transform component)
        {
        }

        public LocalPosition3DTrack()
        {
        }
    }
}
