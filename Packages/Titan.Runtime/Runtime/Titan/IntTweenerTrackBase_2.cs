namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class IntTweenerTrackBase<TClipAsset, TComponent> : IntTweenerTrackBase<TClipAsset, TComponent, IntParameter> where TClipAsset : TweenerClipBase<int, IntParameter> where TComponent : Component
    {
        protected IntTweenerTrackBase()
        {
        }
    }
}
