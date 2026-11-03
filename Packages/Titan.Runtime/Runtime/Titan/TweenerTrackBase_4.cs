namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    public abstract class TweenerTrackBase<TClipAsset, TComponent, TValue, TParameter> : TweenTrackBase<TClipAsset, TComponent>, IComponentValueSetter<TComponent, TValue> where TClipAsset : TweenerClipBase<TValue, TParameter> where TComponent : Object where TParameter : ParameterBase<TValue>, new()
    {
        [SerializeField]
        protected bool _enableInitialValue;
        [SerializeField]
        protected TParameter _initialParameter;
        protected virtual TValue DefaultInitialValue
        {
            get
            {
                return default(TValue);
            }
        }

        protected override void OnCreateClip(TimelineClip clip)
        {
        }

        protected virtual TValue GetInitialValue(TComponent component)
        {
            return default(TValue);
        }

        protected override void SetInitialValue(TweenCreationContext context, TComponent component)
        {
        }

        protected virtual TValue GetClipTarget(TComponent component, TClipAsset clipAsset)
        {
            return default(TValue);
        }

        protected override void InsertClipTween(TweenCreationContext context, TComponent component, TClipAsset clipAsset, float clipStart, float clipDuration)
        {
        }

        protected override Tween GetTween(TComponent component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected abstract Tween GetTween(TComponent component, TValue endValue, TClipAsset clipAsset, float duration);
        protected abstract TValue AddValue(TValue a, TValue b);
        protected abstract TValue GetValue(TComponent component);
        protected abstract void SetValue(TValue value, TComponent component);
        void Titan.IComponentValueSetter<TComponent, TValue>.SetValue(TValue value, TComponent component)
        {
        }

        protected override void CollectValueReverters(ICollectValueRevertersContext context, TComponent component)
        {
        }

        protected TweenerTrackBase()
        {
        }
    }
}
