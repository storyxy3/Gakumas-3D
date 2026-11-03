namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector4TweenerTrackBase<TClipAsset, TComponent> : Vector4TweenerTrackBase<TClipAsset, TComponent, Vector4Parameter> where TClipAsset : TweenerClipBase<Vector4, Vector4Parameter> where TComponent : Component
    {
        protected Vector4TweenerTrackBase()
        {
        }
    }
}
