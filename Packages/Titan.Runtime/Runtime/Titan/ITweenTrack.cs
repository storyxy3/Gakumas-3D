namespace Titan
{
    using global::Titan;

    public interface ITweenTrack
    {
        void InsertTween(TweenCreationContext context);
        void CollectValueReverters(ICollectValueRevertersContext context);
    }
}
