namespace Titan
{
    using global::System.Runtime.CompilerServices;
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class StateTrackBase<TClipAsset, TComponent> : TweenTrackBase<TClipAsset, TComponent> where TClipAsset : StateClipBase where TComponent : Object
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0
        {
            public bool initial;
            public StateTrackBase<TClipAsset, TComponent> _003C_003E4__this;
            public TComponent component;
            public TClipAsset clipAsset;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal float _003CGetTween_003Eb__0()
            {
                return default(float);
            }

            internal void _003CGetTween_003Eb__1(float t)
            {
            }
        }

        protected override void SetInitialValue(TweenCreationContext context, TComponent component)
        {
        }

        protected override Tween GetTween(TComponent component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        public abstract void SetState(TComponent component, bool isOn);
        public abstract bool GetState(TComponent component);
        protected StateTrackBase()
        {
        }
    }
}
