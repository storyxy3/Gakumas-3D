namespace Titan
{
    using global::Titan;
    using global::UnityEngine;

    public abstract class Vector2TweenerTrackBase<TClipAsset, TComponent> : Vector2TweenerTrackBase<TClipAsset, TComponent, Vector2Parameter> where TClipAsset : TweenerClipBase<Vector2, Vector2Parameter> where TComponent : Component
    {
        protected Vector2TweenerTrackBase()
        {
        }
    }
}
