namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(PlayableDirector))]
    [TrackClipType(typeof(NormalTimelineClip))]
    [DisplayName("Titan/Nest/NormalTimeline")]
    public class NormalTimelineTrack : TweenTrackBase<NormalTimelineClip, PlayableDirector>
    {
        protected override Tween GetTween(PlayableDirector component, NormalTimelineClip clipAsset, float duration)
        {
            return null;
        }

        public NormalTimelineTrack()
        {
        }
    }
}
