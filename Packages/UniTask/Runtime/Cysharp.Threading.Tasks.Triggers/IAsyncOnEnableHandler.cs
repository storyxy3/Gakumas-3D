namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnEnableHandler
    {
        UniTask OnEnableAsync();
    }
}
