namespace Titan.Legacy
{
    using global::System.ComponentModel;
    using global::DG.Tweening;
    using global::Titan;
    using global::Titan.Legacy;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(Titan.Legacy.SpriteAnimationClip))]
    [DisplayName("Titan/Legacy/Image/SpriteAnimation")]
    public class SpriteAnimationTrack : TweenTrackBase<Titan.Legacy.SpriteAnimationClip, Image>
    {
        protected override Tween GetTween(Image component, Titan.Legacy.SpriteAnimationClip clipAsset, float duration)
        {
            return null;
        }

        public SpriteAnimationTrack()
        {
        }
    }
}
