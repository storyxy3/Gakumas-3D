namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnBecameVisibleHandler
    {
        UniTask OnBecameVisibleAsync();
    }
}
