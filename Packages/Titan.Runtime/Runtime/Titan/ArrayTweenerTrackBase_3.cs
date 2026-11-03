namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class ArrayTweenerTrackBase<TClipAsset, TComponent, TValue> : ArrayTweenerTrackBase<TClipAsset, TComponent, TValue, ArrayParameter<TValue>> where TClipAsset : TweenerClipBase<TValue[], ArrayParameter<TValue>> where TComponent : Object
    {
        protected ArrayTweenerTrackBase()
        {
        }
    }
}
