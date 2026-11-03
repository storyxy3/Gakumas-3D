namespace Qua.UI
{
    using global::Qua.UI;

    public interface IDefaultStateProvider
    {
        IWindowNodeState GetDefaultChildState(IWindowNodeState state);
    }
}
