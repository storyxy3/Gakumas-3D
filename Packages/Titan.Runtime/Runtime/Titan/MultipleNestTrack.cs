namespace Titan
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(PlayableDirectorGroup))]
    [TrackClipType(typeof(MultipleNestClip))]
    [DisplayName("Titan/Nest/MultipleNest")]
    public class MultipleNestTrack : TweenTrackBase<MultipleNestClip, PlayableDirectorGroup>
    {
        protected override void InsertTween(TweenCreationContext context, PlayableDirectorGroup component)
        {
        }

        protected override Tween GetTween(PlayableDirectorGroup component, MultipleNestClip clipAsset, float duration)
        {
            return null;
        }

        public MultipleNestTrack()
        {
        }
    }
}
