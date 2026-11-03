namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(LocalPositionClip))]
    [DisplayName("Titan/Transform/LocalPosition")]
    public class LocalPositionTrack : Vector2TweenerTrackBase<LocalPositionClip, Transform>
    {
        protected override Vector2 GetValue(Transform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, Transform component)
        {
        }

        public LocalPositionTrack()
        {
        }
    }
}
