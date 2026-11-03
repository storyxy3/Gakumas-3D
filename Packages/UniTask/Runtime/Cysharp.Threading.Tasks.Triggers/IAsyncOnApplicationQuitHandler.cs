namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnApplicationQuitHandler
    {
        UniTask OnApplicationQuitAsync();
    }
}
