namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(RectMask2D))]
    [TrackClipType(typeof(RectMask2DSoftnessClip))]
    [DisplayName("Titan/RectMask2D/Softness")]
    public class RectMask2DSoftnessTrack : Vector2TweenerTrackBase<RectMask2DSoftnessClip, RectMask2D>
    {
        protected override Vector2 GetValue(RectMask2D component)
        {
            return default(Vector2);
        }

        protected override void SetValue(Vector2 value, RectMask2D component)
        {
        }

        public RectMask2DSoftnessTrack()
        {
        }
    }
}
