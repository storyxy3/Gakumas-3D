namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RoundBorder))]
    [TrackClipType(typeof(RoundBorderBorderSizeClip))]
    [DisplayName("Titan/RoundBorder/BorderSize")]
    public class RoundBorderBorderSizeTrack : FloatTweenerTrackBase<RoundBorderBorderSizeClip, RoundBorder>
    {
        protected override float GetValue(RoundBorder component)
        {
            return default(float);
        }

        protected override void SetValue(float value, RoundBorder component)
        {
        }

        public RoundBorderBorderSizeTrack()
        {
        }
    }
}
