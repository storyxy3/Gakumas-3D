namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class ArrayTweenerTrackBase<TClipAsset, TComponent, TValue, TParameter> : TweenerTrackBase<TClipAsset, TComponent, TValue[], TParameter> where TClipAsset : TweenerClipBase<TValue[], TParameter> where TComponent : Object where TParameter : ArrayParameter<TValue>, new()
    {
        protected abstract int GetLength(TComponent component);
        protected abstract Tween GetSingleTween(TComponent component, int index, TValue endValue, TClipAsset clipAsset, float duration);
        protected override Tween GetTween(TComponent component, TValue[] endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected abstract TValue AddValue(TValue a, TValue b);
        protected override TValue[] AddValue(TValue[] a, TValue[] b)
        {
            return null;
        }

        protected abstract TValue GetValue(TComponent component, int index);
        protected override TValue[] GetValue(TComponent component)
        {
            return null;
        }

        protected abstract void SetValue(TComponent component, int index, TValue value);
        protected override void SetValue(TValue[] value, TComponent component)
        {
        }

        protected virtual void OnSetElementValue(TComponent component)
        {
        }

        protected ArrayTweenerTrackBase()
        {
        }
    }
}
