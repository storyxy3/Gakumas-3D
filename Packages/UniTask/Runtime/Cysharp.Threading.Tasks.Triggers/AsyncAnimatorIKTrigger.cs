namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncAnimatorIKTrigger : AsyncTriggerBase<int>
    {
        private void OnAnimatorIK(int layerIndex)
        {
        }

        public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler()
        {
            return null;
        }

        public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<int> OnAnimatorIKAsync()
        {
            return default(UniTask<int>);
        }

        public UniTask<int> OnAnimatorIKAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<int>);
        }

        public AsyncAnimatorIKTrigger()
        {
        }
    }
}
