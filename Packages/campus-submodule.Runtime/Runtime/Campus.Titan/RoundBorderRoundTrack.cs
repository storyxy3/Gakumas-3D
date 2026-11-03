namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RoundBorder))]
    [TrackClipType(typeof(RoundBorderRoundClip))]
    [DisplayName("Titan/RoundBorder/Round")]
    public class RoundBorderRoundTrack : Vector4TweenerTrackBase<RoundBorderRoundClip, RoundBorder, RoundParameter>
    {
        protected override Vector4 GetValue(RoundBorder component)
        {
            return default(Vector4);
        }

        protected override void SetValue(Vector4 value, RoundBorder component)
        {
        }

        public RoundBorderRoundTrack()
        {
        }
    }
}
