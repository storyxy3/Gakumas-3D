namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class StringTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, string, StringParameter> where TClipAsset : TweenerClipBase<string, StringParameter> where TComponent : Object
    {
        protected override Tween GetTween(TComponent component, string endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override string AddValue(string a, string b)
        {
            return null;
        }

        protected StringTweenerTrackBase()
        {
        }
    }
}
