namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    [TitanTrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(SpriteRendererAnimationClip))]
    [DisplayName("Titan/SpriteRenderer/SpriteAnimation")]
    public class SpriteRendererAnimationTrack : SequentialTrackBase<SpriteRendererAnimationClip, SpriteRenderer, Sprite>
    {
        protected override Sprite GetValue(SpriteRenderer component)
        {
            return null;
        }

        protected override void SetValue(Sprite value, SpriteRenderer component)
        {
        }

        public SpriteRendererAnimationTrack()
        {
        }
    }
}
