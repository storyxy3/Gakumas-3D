namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(SizeDeltaClip))]
    [DisplayName("Titan/Transform/SizeDelta")]
    public class SizeDeltaTrack : Vector2TweenerTrackBase<SizeDeltaClip, RectTransform>
    {
        protected override Vector2 DefaultInitialValue
        {
            get
            {
                return default(Vector2);
            }
        }

        protected override Vector2 GetValue(RectTransform component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectTransform component)
        {
        }

        public SizeDeltaTrack()
        {
        }
    }
}
