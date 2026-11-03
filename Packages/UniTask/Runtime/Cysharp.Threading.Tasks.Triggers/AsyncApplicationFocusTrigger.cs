namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncApplicationFocusTrigger : AsyncTriggerBase<bool>
    {
        private void OnApplicationFocus(bool hasFocus)
        {
        }

        public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler()
        {
            return null;
        }

        public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<bool> OnApplicationFocusAsync()
        {
            return default(UniTask<bool>);
        }

        public UniTask<bool> OnApplicationFocusAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<bool>);
        }

        public AsyncApplicationFocusTrigger()
        {
        }
    }
}
