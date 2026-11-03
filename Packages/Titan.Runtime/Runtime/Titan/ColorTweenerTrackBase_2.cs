namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class ColorTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, Color, ColorParameter> where TClipAsset : TweenerClipBase<Color, ColorParameter> where TComponent : Component
    {
        protected override Tween GetTween(TComponent component, Color endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Color AddValue(Color a, Color b)
        {
            return default(Color);
        }

        protected ColorTweenerTrackBase()
        {
        }
    }
}
