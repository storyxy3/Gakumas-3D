namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TrackClipType(typeof(CustomTweenClip))]
    [DisplayName("Titan/Custom/Tween")]
    public class CustomTweenTrack : TweenTrackBase
    {
        protected override void InsertTween(TweenCreationContext context)
        {
        }

        public CustomTweenTrack()
        {
        }
    }
}
