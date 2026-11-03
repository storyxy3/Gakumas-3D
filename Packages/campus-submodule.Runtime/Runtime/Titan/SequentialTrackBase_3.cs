namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class SequentialTrackBase<TClipAsset, TComponent, TValue> : TweenTrackBase<TClipAsset, TComponent> where TClipAsset : SequentialClipBase<TValue> where TComponent : Object
    {
        [SerializeField]
        protected bool _enableInitialValue;
        [SerializeField]
        protected TValue _initialValue;
        protected override void SetInitialValue(TweenCreationContext context, TComponent component)
        {
        }

        protected override Tween GetTween(TComponent component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected abstract TValue GetValue(TComponent component);
        protected abstract void SetValue(TValue value, TComponent component);
        protected SequentialTrackBase()
        {
        }
    }
}
