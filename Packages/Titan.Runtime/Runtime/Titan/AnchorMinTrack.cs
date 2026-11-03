namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(AnchorMinClip))]
    [DisplayName("Titan/Transform/AnchorMin")]
    public class AnchorMinTrack : Vector2TweenerTrackBase<AnchorMinClip, RectTransform>
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

        public AnchorMinTrack()
        {
        }
    }
}
