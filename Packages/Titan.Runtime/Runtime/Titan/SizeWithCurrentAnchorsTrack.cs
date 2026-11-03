namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(SizeWithCurrentAnchorsClip))]
    [DisplayName("Titan/Transform/SizeWithCurrentAnchors")]
    public class SizeWithCurrentAnchorsTrack : Vector2TweenerTrackBase<SizeWithCurrentAnchorsClip, RectTransform>
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

        public SizeWithCurrentAnchorsTrack()
        {
        }
    }
}
