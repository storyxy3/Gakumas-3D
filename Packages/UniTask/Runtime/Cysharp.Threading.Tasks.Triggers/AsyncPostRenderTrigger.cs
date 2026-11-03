namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncPostRenderTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnPostRender()
        {
        }

        public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler()
        {
            return null;
        }

        public IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnPostRenderAsync()
        {
            return default(UniTask);
        }

        public UniTask OnPostRenderAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncPostRenderTrigger()
        {
        }
    }
}
