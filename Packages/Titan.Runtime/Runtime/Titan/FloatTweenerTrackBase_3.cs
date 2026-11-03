namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class FloatTweenerTrackBase<TClipAsset, TComponent, TParameter> : TweenerTrackBase<TClipAsset, TComponent, float, TParameter> where TClipAsset : TweenerClipBase<float, TParameter> where TComponent : Component where TParameter : ParameterBase<float>, new()
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public FloatTweenerTrackBase<TClipAsset, TComponent, TParameter> _003C_003E4__this;
            public TComponent component;
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

        protected override Tween GetTween(TComponent component, float endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        protected FloatTweenerTrackBase()
        {
        }
    }
}
