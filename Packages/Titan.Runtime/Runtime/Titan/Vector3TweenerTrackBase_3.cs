namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector3TweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, Vector3, TParameter> where TClipAsset : TweenerClipBase<Vector3, TParameter> where TComponent : Component where TParameter : Vector3Parameter, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public Vector3TweenerTrackBase<TClipAsset, TComponent, TParameter> _003C_003E4__this;
            public TClipAsset clipAsset;
            public TComponent component;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CGetTween_003Eb__0(Vector3 x)
            {
            }

            internal Vector3 _003CGetTween_003Eb__1()
            {
                return default(Vector3);
            }
        }

        protected override Vector3 GetInitialValue(TComponent component)
        {
            return default(Vector3);
        }

        protected override Tween GetTween(TComponent component, Vector3 endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Vector3 AddValue(Vector3 a, Vector3 b)
        {
            return default(Vector3);
        }

        [MethodImpl(256)]
        private Vector3 GetIgnoredValue(Vector3 value, Vector3Parameter parameter, TComponent component)
        {
            return default(Vector3);
        }

        protected Vector3TweenerTrackBase()
        {
        }
    }
}
