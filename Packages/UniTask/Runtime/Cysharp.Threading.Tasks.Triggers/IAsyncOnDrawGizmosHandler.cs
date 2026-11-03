namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnDrawGizmosHandler
    {
        UniTask OnDrawGizmosAsync();
    }
}
