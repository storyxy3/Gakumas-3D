namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncApplicationPauseTrigger : AsyncTriggerBase<bool>
    {
        private void OnApplicationPause(bool pauseStatus)
        {
        }

        public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler()
        {
            return null;
        }

        public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<bool> OnApplicationPauseAsync()
        {
            return default(UniTask<bool>);
        }

        public UniTask<bool> OnApplicationPauseAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<bool>);
        }

        public AsyncApplicationPauseTrigger()
        {
        }
    }
}
