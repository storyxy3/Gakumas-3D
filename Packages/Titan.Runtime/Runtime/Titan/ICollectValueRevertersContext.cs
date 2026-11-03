namespace Titan
{
    using global::Titan;
    using global::UnityEngine.Playables;

    public interface ICollectValueRevertersContext
    {
        PlayableDirector Director { get; }

        IValueResolver ValueResolver { get; }

        void Add(IValueReverter reverter);
    }
}
