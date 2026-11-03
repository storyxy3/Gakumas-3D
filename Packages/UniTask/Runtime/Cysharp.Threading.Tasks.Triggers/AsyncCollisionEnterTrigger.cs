namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncCollisionEnterTrigger : AsyncTriggerBase<Collision>
    {
        private void OnCollisionEnter(Collision coll)
        {
        }

        public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collision> OnCollisionEnterAsync()
        {
            return default(UniTask<Collision>);
        }

        public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collision>);
        }

        public AsyncCollisionEnterTrigger()
        {
        }
    }
}
