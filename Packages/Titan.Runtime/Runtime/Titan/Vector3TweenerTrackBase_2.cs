namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector3TweenerTrackBase<TClipAsset, TComponent> : Vector3TweenerTrackBase<TClipAsset, TComponent, Vector3Parameter> where TClipAsset : TweenerClipBase<Vector3, Vector3Parameter> where TComponent : Component
    {
        protected Vector3TweenerTrackBase()
        {
        }
    }
}
