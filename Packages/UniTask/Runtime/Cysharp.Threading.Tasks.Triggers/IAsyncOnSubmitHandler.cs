namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine.EventSystems;

    public interface IAsyncOnSubmitHandler
    {
        UniTask<BaseEventData> OnSubmitAsync();
    }
}
