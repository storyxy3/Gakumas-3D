namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class IntTweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, int, TParameter> where TClipAsset : TweenerClipBase<int, TParameter> where TComponent : Component where TParameter : IntParameter, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public int startValue;
            public IntTweenerTrackBase<TClipAsset, TComponent, TParameter> _003C_003E4__this;
            public TComponent component;
            public TClipAsset clipAsset;
            public int endValue;
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

        protected override Tween GetTween(TComponent component, int endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override int AddValue(int a, int b)
        {
            return default(int);
        }

        protected IntTweenerTrackBase()
        {
        }
    }
}
