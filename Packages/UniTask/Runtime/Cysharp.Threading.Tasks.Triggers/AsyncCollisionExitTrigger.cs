namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncCollisionExitTrigger : AsyncTriggerBase<Collision>
    {
        private void OnCollisionExit(Collision coll)
        {
        }

        public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collision> OnCollisionExitAsync()
        {
            return default(UniTask<Collision>);
        }

        public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collision>);
        }

        public AsyncCollisionExitTrigger()
        {
        }
    }
}
