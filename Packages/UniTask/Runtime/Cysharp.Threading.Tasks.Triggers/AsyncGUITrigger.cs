namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncGUITrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnGUI()
        {
        }

        public IAsyncOnGUIHandler GetOnGUIAsyncHandler()
        {
            return null;
        }

        public IAsyncOnGUIHandler GetOnGUIAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnGUIAsync()
        {
            return default(UniTask);
        }

        public UniTask OnGUIAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncGUITrigger()
        {
        }
    }
}
