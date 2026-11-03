namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(AnchorPositionClip))]
    [DisplayName("Titan/Transform/AnchorPosition")]
    public class AnchorPositionTrack : Vector2TweenerTrackBase<AnchorPositionClip, RectTransform>
    {
        protected override Vector2 GetValue(RectTransform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectTransform component)
        {
        }

        public AnchorPositionTrack()
        {
        }
    }
}
