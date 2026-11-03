namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncWillRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnWillRenderObject()
        {
        }

        public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler()
        {
            return null;
        }

        public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnWillRenderObjectAsync()
        {
            return default(UniTask);
        }

        public UniTask OnWillRenderObjectAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncWillRenderObjectTrigger()
        {
        }
    }
}
