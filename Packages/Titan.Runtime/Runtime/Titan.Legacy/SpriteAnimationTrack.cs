namespace Titan.Legacy
{
    using global::System.ComponentModel;
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::Titan.Legacy;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;
    using global::UnityEngine.UI;

    [TitanTrackBindingType(typeof(Image))]
    [TrackClipType(typeof(Titan.Legacy.SpriteAnimationClip))]
    [DisplayName("Titan/Legacy/Image/SpriteAnimation")]
    public class SpriteAnimationTrack : TweenTrackBase<Titan.Legacy.SpriteAnimationClip, Image>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public Sprite initialSprite;
            public Image component;
            public Tween tween;
            public Sprite[] sprites;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal int _003CGetTween_003Eb__0()
            {
                return default(int);
            }

            internal void _003CGetTween_003Eb__1(int x)
            {
            }
        }

        protected override Tween GetTween(Image component, Titan.Legacy.SpriteAnimationClip clipAsset, float duration)
        {
            return null;
        }

        public SpriteAnimationTrack()
        {
        }
    }
}
