namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class PathTrack3DBase<TClipAsset> : PathTrackBase<TClipAsset> where TClipAsset : PathClip3DBase
    {
        protected override Tween GetTween(Transform component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected PathTrack3DBase()
        {
        }
    }
}
