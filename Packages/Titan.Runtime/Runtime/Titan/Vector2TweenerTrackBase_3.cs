namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector2TweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, Vector2, TParameter> where TClipAsset : TweenerClipBase<Vector2, TParameter> where TComponent : Component where TParameter : Vector2Parameter, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public Vector2TweenerTrackBase<TClipAsset, TComponent, TParameter> _003C_003E4__this;
            public TClipAsset clipAsset;
            public TComponent component;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CGetTween_003Eb__0(Vector2 x)
            {
            }

            internal Vector2 _003CGetTween_003Eb__1()
            {
                return default(Vector2);
            }
        }

        protected override Vector2 GetInitialValue(TComponent component)
        {
            return default(Vector2);
        }

        protected override Tween GetTween(TComponent component, Vector2 endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Vector2 AddValue(Vector2 a, Vector2 b)
        {
            return default(Vector2);
        }

        [MethodImpl(256)]
        private Vector2 GetIgnoredValue(Vector2 value, Vector2Parameter parameter, TComponent component)
        {
            return default(Vector2);
        }

        protected Vector2TweenerTrackBase()
        {
        }
    }
}
