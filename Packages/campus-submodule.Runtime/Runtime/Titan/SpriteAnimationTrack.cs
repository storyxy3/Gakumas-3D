namespace Titan
{
    using global::System.ComponentModel;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(SpriteAnimationClip))]
    [DisplayName("Titan/Image/SpriteAnimation")]
    public class SpriteAnimationTrack : SequentialTrackBase<SpriteAnimationClip, Image, Sprite>
    {
        protected override Sprite GetValue(Image component)
        {
            return null;
        }

        protected override void SetValue(Sprite value, Image component)
        {
        }

        public SpriteAnimationTrack()
        {
        }
    }
}
