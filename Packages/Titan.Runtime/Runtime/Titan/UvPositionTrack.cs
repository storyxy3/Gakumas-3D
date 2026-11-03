namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(RawImage))]
    [TrackClipType(typeof(UvPositionClip))]
    [DisplayName("Titan/RawImage/UvPosition")]
    public class UvPositionTrack : Vector2TweenerTrackBase<UvPositionClip, RawImage>
    {
        protected override Vector2 GetValue(RawImage component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RawImage component)
        {
        }

        public UvPositionTrack()
        {
        }
    }
}
