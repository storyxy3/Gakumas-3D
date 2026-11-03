namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class FloatTweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, float, TParameter> where TClipAsset : TweenerClipBase<float, TParameter> where TComponent : Component where TParameter : ParameterBase<float>, new()
    {
        protected override Tween GetTween(TComponent component, float endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        protected FloatTweenerTrackBase()
        {
        }
    }
}
