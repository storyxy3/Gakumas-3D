namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncApplicationQuitTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnApplicationQuit()
        {
        }

        public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnApplicationQuitAsync()
        {
            return default(UniTask);
        }

        public UniTask OnApplicationQuitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncApplicationQuitTrigger()
        {
        }
    }
}
