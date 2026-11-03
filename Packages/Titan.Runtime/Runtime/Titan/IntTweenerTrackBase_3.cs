namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class IntTweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, int, TParameter> where TClipAsset : TweenerClipBase<int, TParameter> where TComponent : Component where TParameter : IntParameter, new()
    {
        protected override Tween GetTween(TComponent component, int endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override int AddValue(int a, int b)
        {
            return default(int);
        }

        protected IntTweenerTrackBase()
        {
        }
    }
}
