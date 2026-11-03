namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncCollisionExit2DTrigger : AsyncTriggerBase<Collision2D>
    {
        private void OnCollisionExit2D(Collision2D coll)
        {
        }

        public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collision2D> OnCollisionExit2DAsync()
        {
            return default(UniTask<Collision2D>);
        }

        public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collision2D>);
        }

        public AsyncCollisionExit2DTrigger()
        {
        }
    }
}
