namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncResetTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void Reset()
        {
        }

        public IAsyncResetHandler GetResetAsyncHandler()
        {
            return null;
        }

        public IAsyncResetHandler GetResetAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask ResetAsync()
        {
            return default(UniTask);
        }

        public UniTask ResetAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncResetTrigger()
        {
        }
    }
}
