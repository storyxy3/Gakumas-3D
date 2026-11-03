namespace Titan
{
    using global::System.Collections.Generic;
    using global::DG.Tweening;
    using global::Titan;

    public interface ITimelineTween
    {
        Tween Main { get; }

        IReadOnlyList<TweenWithDelay> InfiniteTweens { get; }

        void Revert();
    }
}
