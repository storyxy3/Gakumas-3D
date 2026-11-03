namespace Campus.Titan
{
    using global::System.ComponentModel;
    using global::Campus.Common;
    using global::Campus.Titan;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(RoundBorder))]
    [TrackClipType(typeof(RoundBorderCircleClip))]
    [DisplayName("Titan/RoundBorder/Circle")]
    public class RoundBorderCircleTrack : FloatTweenerTrackBase<RoundBorderCircleClip, RoundBorder>
    {
        protected override float GetValue(RoundBorder component)
        {
            return default(float);
        }

        protected override void SetValue(float value, RoundBorder component)
        {
        }

        public RoundBorderCircleTrack()
        {
        }
    }
}
