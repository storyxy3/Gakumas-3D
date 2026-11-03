namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class FloatTweenerTrackBase<TClipAsset, TComponent> : FloatTweenerTrackBase<TClipAsset, TComponent, FloatParameter> where TClipAsset : TweenerClipBase<float, FloatParameter> where TComponent : Component
    {
        protected FloatTweenerTrackBase()
        {
        }
    }
}
