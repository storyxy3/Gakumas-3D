namespace Cysharp.Threading.Tasks
{
    using global::Cysharp.Threading.Tasks;

    public interface IUniTaskAsyncDisposable
    {
        UniTask DisposeAsync();
    }
}
