namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(OffsetMaxClip))]
    [DisplayName("Titan/Transform/OffsetMax")]
    public class OffsetMaxTrack : Vector2TweenerTrackBase<OffsetMaxClip, RectTransform>
    {
        protected override Vector2 GetValue(RectTransform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectTransform component)
        {
        }

        public OffsetMaxTrack()
        {
        }
    }
}
