namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTriggerEnter2DTrigger : AsyncTriggerBase<Collider2D>
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
        }

        public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collider2D> OnTriggerEnter2DAsync()
        {
            return default(UniTask<Collider2D>);
        }

        public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collider2D>);
        }

        public AsyncTriggerEnter2DTrigger()
        {
        }
    }
}
