namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(IntervalClip))]
    [DisplayName("Titan/Interval")]
    public class IntervalTrack : TweenTrackBase
    {
        protected override void InsertTween(TweenCreationContext context)
        {
        }

        public IntervalTrack()
        {
        }
    }
}
