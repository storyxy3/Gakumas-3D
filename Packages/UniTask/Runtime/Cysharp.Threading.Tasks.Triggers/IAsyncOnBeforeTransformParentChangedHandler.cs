namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;

    public interface IAsyncOnBeforeTransformParentChangedHandler
    {
        UniTask OnBeforeTransformParentChangedAsync();
    }
}
