namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine.EventSystems;

    public interface IAsyncOnEndDragHandler
    {
        UniTask<PointerEventData> OnEndDragAsync();
    }
}
