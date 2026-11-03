namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class ColorArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, Color> where TClipAsset : ArrayTweenerClipBase<Color> where TComponent : Component
    {
        protected override Tween GetSingleTween(TComponent component, int index, Color endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Color AddValue(Color a, Color b)
        {
            return default(Color);
        }

        protected ColorArrayTweenerTrackBase()
        {
        }
    }
}
