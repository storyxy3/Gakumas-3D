namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(RectMask2D))]
    [TrackClipType(typeof(RectMask2DPaddingClip))]
    [DisplayName("Titan/RectMask2D/Padding")]
    public class RectMask2DPaddingTrack : Vector4TweenerTrackBase<RectMask2DPaddingClip, RectMask2D, RectMask2DPaddingParameter>
    {
        protected override Vector4 GetValue(RectMask2D component)
        {
            return default(Vector4);
        }

        protected override void SetValue(Vector4 value, RectMask2D component)
        {
        }

        public RectMask2DPaddingTrack()
        {
        }
    }
}
