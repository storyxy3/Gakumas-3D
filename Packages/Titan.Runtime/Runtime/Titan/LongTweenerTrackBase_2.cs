namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class LongTweenerTrackBase<TClipAsset, TComponent> : TweenerTrackBase<TClipAsset, TComponent, long, LongParameter> where TClipAsset : TweenerClipBase<long, LongParameter> where TComponent : Component
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public long startValue;
            public LongTweenerTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public TClipAsset clipAsset;
            public long endValue;
            public _003C_003Ec__DisplayClass0_0()
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

        protected override Tween GetTween(TComponent component, long endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override long AddValue(long a, long b)
        {
            return default(long);
        }

        protected LongTweenerTrackBase()
        {
        }
    }
}
