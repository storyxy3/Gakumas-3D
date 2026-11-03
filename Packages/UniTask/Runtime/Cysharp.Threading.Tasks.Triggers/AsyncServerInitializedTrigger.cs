namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncServerInitializedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnServerInitialized()
        {
        }

        public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnServerInitializedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnServerInitializedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncServerInitializedTrigger()
        {
        }
    }
}
