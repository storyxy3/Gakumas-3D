namespace Titan
{
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    public abstract class PathTrackBase<TClipAsset> : TweenTrackBase<TClipAsset, Transform>, IComponentValueSetter<Transform, Vector3> where TClipAsset : LoopableTweenClip
    {
        protected override void CollectValueReverters(ICollectValueRevertersContext context, Transform component)
        {
        }

        protected abstract Vector3 GetValue(Transform component);
        public abstract void SetValue(Vector3 value, Transform component);
        protected override void OnCreateClip(TimelineClip clip)
        {
        }

        protected PathTrackBase()
        {
        }
    }
}
