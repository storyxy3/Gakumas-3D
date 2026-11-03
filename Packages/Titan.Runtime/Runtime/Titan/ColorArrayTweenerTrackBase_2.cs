namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class ColorArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, Color> where TClipAsset : ArrayTweenerClipBase<Color> where TComponent : Component
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public ColorArrayTweenerTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Color _003CGetSingleTween_003Eb__0()
            {
                return default(Color);
            }

            internal void _003CGetSingleTween_003Eb__1(Color x)
            {
            }
        }

        protected override Tween GetSingleTween(TComponent component, int index, Color endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Color AddValue(Color a, Color b)
        {
            return default(Color);
        }

        protected ColorArrayTweenerTrackBase()
        {
        }
    }
}
