namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector4TweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, Vector4, TParameter> where TClipAsset : TweenerClipBase<Vector4, TParameter> where TComponent : Component where TParameter : Vector4Parameter, new()
    {
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
