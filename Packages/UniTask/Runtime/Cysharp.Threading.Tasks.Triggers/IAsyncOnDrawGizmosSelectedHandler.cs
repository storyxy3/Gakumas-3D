namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnDrawGizmosSelectedHandler
    {
        UniTask OnDrawGizmosSelectedAsync();
    }
}
