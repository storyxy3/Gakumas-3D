namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector2ArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, Vector2> where TClipAsset : ArrayTweenerClipBase<Vector2> where TComponent : Component
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public Vector2ArrayTweenerTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal Vector2 _003CGetSingleTween_003Eb__0()
            {
                return default(Vector2);
            }

            internal void _003CGetSingleTween_003Eb__1(Vector2 x)
            {
            }
        }

        protected override Tween GetSingleTween(TComponent component, int index, Vector2 endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Vector2 AddValue(Vector2 a, Vector2 b)
        {
            return default(Vector2);
        }

        protected Vector2ArrayTweenerTrackBase()
        {
        }
    }
}
