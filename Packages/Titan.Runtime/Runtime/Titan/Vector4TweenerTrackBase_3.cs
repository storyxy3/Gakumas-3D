namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector4TweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, Vector4, TParameter> where TClipAsset : TweenerClipBase<Vector4, TParameter> where TComponent : Component where TParameter : Vector4Parameter, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public Vector4TweenerTrackBase<TClipAsset, TComponent, TParameter> _003C_003E4__this;
            public TClipAsset clipAsset;
            public TComponent component;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CGetTween_003Eb__0(Vector4 x)
            {
            }

            internal Vector4 _003CGetTween_003Eb__1()
            {
                return default(Vector4);
            }
        }

        protected override Vector4 GetInitialValue(TComponent component)
        {
            return default(Vector4);
        }

        protected override Tween GetTween(TComponent component, Vector4 endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Vector4 AddValue(Vector4 a, Vector4 b)
        {
            return default(Vector4);
        }

        [MethodImpl(256)]
        private Vector4 GetIgnoredValue(Vector4 value, Vector4Parameter parameter, TComponent component)
        {
            return default(Vector4);
        }

        protected Vector4TweenerTrackBase()
        {
        }
    }
}
