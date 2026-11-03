namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncOnCanvasGroupChangedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnCanvasGroupChanged()
        {
        }

        public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnCanvasGroupChangedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncOnCanvasGroupChangedTrigger()
        {
        }
    }
}
