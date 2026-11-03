namespace DG.Tweening.Core
{
    using global::DG.Tweening;

    public abstract class ABSSequentiable
    {
        internal TweenType tweenType;
        internal float sequencedPosition;
        internal float sequencedEndPosition;
        internal TweenCallback onStart;
        protected ABSSequentiable()
        {
        }
    }
}
