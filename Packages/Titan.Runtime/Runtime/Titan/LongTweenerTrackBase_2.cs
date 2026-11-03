namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class LongTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, long, LongParameter> where TClipAsset : TweenerClipBase<long, LongParameter> where TComponent : Component
    {
        protected override Tween GetTween(TComponent component, long endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override long AddValue(long a, long b)
        {
            return default(long);
        }

        protected LongTweenerTrackBase()
        {
        }
    }
}
