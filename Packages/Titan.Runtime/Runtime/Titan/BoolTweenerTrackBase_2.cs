namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class BoolTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, bool, BoolParameter> where TClipAsset : TweenerClipBase<bool, BoolParameter> where TComponent : Object
    {
        protected override Tween GetTween(TComponent component, bool endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override bool AddValue(bool a, bool b)
        {
            return default(bool);
        }

        protected BoolTweenerTrackBase()
        {
        }
    }
}
