namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector2ArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, Vector2> where TClipAsset : ArrayTweenerClipBase<Vector2> where TComponent : Component
    {
        protected override Tween GetSingleTween(TComponent component, int index, Vector2 endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Vector2 AddValue(Vector2 a, Vector2 b)
        {
            return default(Vector2);
        }

        protected Vector2ArrayTweenerTrackBase()
        {
        }
    }
}
