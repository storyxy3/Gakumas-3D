namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(OffsetMinClip))]
    [DisplayName("Titan/Transform/OffsetMin")]
    public class OffsetMinTrack : Vector2TweenerTrackBase<OffsetMinClip, RectTransform>
    {
        protected override Vector2 GetValue(RectTransform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectTransform component)
        {
        }

        public OffsetMinTrack()
        {
        }
    }
}
