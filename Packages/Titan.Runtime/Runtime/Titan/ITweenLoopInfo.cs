namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;

    public interface ITweenLoopInfo : IExpressionHolder
    {
        int LoopCount { get; }

        LoopType LoopType { get; }

        float Interval { get; }

        float LoopOffset { get; }
    }
}
