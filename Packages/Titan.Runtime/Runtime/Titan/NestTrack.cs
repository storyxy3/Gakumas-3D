namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(PlayableDirector))]
    [TrackColor(0f, 1f, 0f)]
    [TrackClipType(typeof(NestClip))]
    [DisplayName("Titan/Nest/Nest")]
    public class NestTrack : TweenTrackBase<NestClip, PlayableDirector>
    {
        protected override void InsertTween(TweenCreationContext context, PlayableDirector component)
        {
        }

        protected override Tween GetTween(PlayableDirector component, NestClip clipAsset, float duration)
        {
            return null;
        }

        public NestTrack()
        {
        }
    }
}
