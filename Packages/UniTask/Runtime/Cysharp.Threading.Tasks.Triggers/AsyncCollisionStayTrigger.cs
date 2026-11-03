namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncCollisionStayTrigger : AsyncTriggerBase<Collision>
    {
        private void OnCollisionStay(Collision coll)
        {
        }

        public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler()
        {
            return null;
        }

        public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collision> OnCollisionStayAsync()
        {
            return default(UniTask<Collision>);
        }

        public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collision>);
        }

        public AsyncCollisionStayTrigger()
        {
        }
    }
}
