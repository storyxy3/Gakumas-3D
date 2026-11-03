namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(Scale3DClip))]
    [DisplayName("Titan/Transform/3D/Scale3D")]
    public class Scale3DTrack : Vector3TweenerTrackBase<Scale3DClip, Transform>
    {
        protected override Vector3 GetValue(Transform component)
        {
            return default(Vector3);
        }

        protected override void SetValue(Vector3 value, Transform component)
        {
        }

        public Scale3DTrack()
        {
        }
    }
}
