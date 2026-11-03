namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTriggerExitTrigger : AsyncTriggerBase<Collider>
    {
        private void OnTriggerExit(Collider other)
        {
        }

        public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collider> OnTriggerExitAsync()
        {
            return default(UniTask<Collider>);
        }

        public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collider>);
        }

        public AsyncTriggerExitTrigger()
        {
        }
    }
}
