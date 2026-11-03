namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public abstract class TweenTrackBase<TClipAsset, TComponent> : TweenTrackBase where TClipAsset : LoopableTweenClip where TComponent : Object
    {
        protected sealed override void InsertTween(TweenCreationContext context)
        {
        }

        protected virtual void InsertTween(TweenCreationContext context, TComponent component)
        {
        }

        protected virtual void InsertClipTween(TweenCreationContext context, TComponent component, TClipAsset clipAsset, float clipStart, float clipDuration)
        {
        }

        protected virtual void OnBeforeCreateTween(TweenCreationContext context, TComponent component)
        {
        }

        protected virtual void SetInitialValue(TweenCreationContext context, TComponent component)
        {
        }

        protected abstract Tween GetTween(TComponent component, TClipAsset clipAsset, float duration);
        protected sealed override void CollectValueReverters(ICollectValueRevertersContext context)
        {
        }

        protected virtual void CollectValueReverters(ICollectValueRevertersContext context, TComponent component)
        {
        }

        private TComponent GetBinding(PlayableDirector director, IValueResolver resolver)
        {
            return null;
        }

        protected TweenTrackBase()
        {
        }
    }
}
