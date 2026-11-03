namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;
    using global::UnityEngine.Timeline;

    public abstract class TweenerTrackBase<TClipAsset, TComponent, TValue, TParameter> : TweenTrackBase<TClipAsset, TComponent>, IComponentValueSetter<TComponent, TValue> where TClipAsset : TweenerClipBase<TValue, TParameter> where TComponent : Object where TParameter : ParameterBase<TValue>, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass8_0
        {
            public TValue previousValue;
            public TweenerTrackBase<TClipAsset, TComponent, TValue, TParameter> _003C_003E4__this;
            public TComponent component;
            public TValue endValue;
            public TClipAsset clipAsset;
            public _003C_003Ec__DisplayClass8_0()
            {
            }

            internal void _003CInsertClipTween_003Eb__0()
            {
            }

            internal void _003CInsertClipTween_003Eb__1()
            {
            }
        }

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
