namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine.EventSystems;

    public interface IAsyncOnUpdateSelectedHandler
    {
        UniTask<BaseEventData> OnUpdateSelectedAsync();
    }
}
