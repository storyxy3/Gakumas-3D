namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;
    using global::UnityEngine;

    public abstract class StateTrackBase<TClipAsset, TComponent> : TweenTrackBase<TClipAsset, TComponent> where TClipAsset : StateClipBase where TComponent : Object
    {
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
