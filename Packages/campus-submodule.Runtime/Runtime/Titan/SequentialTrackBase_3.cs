namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class SequentialTrackBase<TClipAsset, TComponent, TValue> : TweenTrackBase<TClipAsset, TComponent> where TClipAsset : SequentialClipBase<TValue> where TComponent : Object
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass3_0
        {
            public TValue initialValue;
            public SequentialTrackBase<TClipAsset, TComponent, TValue> _003C_003E4__this;
            public TComponent component;
            public Tween tween;
            public TValue[] values;
            public _003C_003Ec__DisplayClass3_0()
            {
            }

            internal float _003CGetTween_003Eb__0()
            {
                return default(float);
            }

            internal void _003CGetTween_003Eb__1(float x)
            {
            }
        }

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
