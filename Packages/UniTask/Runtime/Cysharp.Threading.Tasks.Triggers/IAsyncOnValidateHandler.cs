namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnValidateHandler
    {
        UniTask OnValidateAsync();
    }
}
