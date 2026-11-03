namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class FloatArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, float> where TClipAsset : ArrayTweenerClipBase<float> where TComponent : Component
    {
        protected override Tween GetSingleTween(TComponent component, int index, float endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        protected FloatArrayTweenerTrackBase()
        {
        }
    }
}
