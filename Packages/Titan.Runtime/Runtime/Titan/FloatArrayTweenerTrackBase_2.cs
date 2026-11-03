namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class FloatArrayTweenerTrackBase<TClipAsset, TComponent> : ArrayTweenerTrackBase<TClipAsset, TComponent, float> where TClipAsset : ArrayTweenerClipBase<float> where TComponent : Component
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public FloatArrayTweenerTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public int index;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal float _003CGetSingleTween_003Eb__0()
            {
                return default(float);
            }

            internal void _003CGetSingleTween_003Eb__1(float x)
            {
            }
        }

        protected override Tween GetSingleTween(TComponent component, int index, float endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override float AddValue(float a, float b)
        {
            return default(float);
        }

        protected FloatArrayTweenerTrackBase()
        {
        }
    }
}
