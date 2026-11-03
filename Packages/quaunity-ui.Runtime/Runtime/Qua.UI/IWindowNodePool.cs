namespace Qua.UI
{
    using global::Qua.UI;

    public interface IWindowNodePool
    {
        WindowNode Get(IWindowNodeState state);
        void Add(IWindowNodeState state, WindowNode windowNode);
    }
}
