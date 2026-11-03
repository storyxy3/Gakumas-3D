namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class ColorTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, Color, ColorParameter> where TClipAsset : TweenerClipBase<Color, ColorParameter> where TComponent : Component
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public ColorTweenerTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Color _003CGetTween_003Eb__0()
            {
                return default(Color);
            }

            internal void _003CGetTween_003Eb__1(Color x)
            {
            }
        }

        protected override Tween GetTween(TComponent component, Color endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Color AddValue(Color a, Color b)
        {
            return default(Color);
        }

        protected ColorTweenerTrackBase()
        {
        }
    }
}
