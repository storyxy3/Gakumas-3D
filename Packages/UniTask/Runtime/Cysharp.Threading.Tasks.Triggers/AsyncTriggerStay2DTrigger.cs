namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTriggerStay2DTrigger : AsyncTriggerBase<Collider2D>
    {
        private void OnTriggerStay2D(Collider2D other)
        {
        }

        public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collider2D> OnTriggerStay2DAsync()
        {
            return default(UniTask<Collider2D>);
        }

        public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collider2D>);
        }

        public AsyncTriggerStay2DTrigger()
        {
        }
    }
}
