namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncValidateTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnValidate()
        {
        }

        public IAsyncOnValidateHandler GetOnValidateAsyncHandler()
        {
            return null;
        }

        public IAsyncOnValidateHandler GetOnValidateAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnValidateAsync()
        {
            return default(UniTask);
        }

        public UniTask OnValidateAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncValidateTrigger()
        {
        }
    }
}
