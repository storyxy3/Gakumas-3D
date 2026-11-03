namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncAnimatorMoveTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnAnimatorMove()
        {
        }

        public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler()
        {
            return null;
        }

        public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnAnimatorMoveAsync()
        {
            return default(UniTask);
        }

        public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncAnimatorMoveTrigger()
        {
        }
    }
}
