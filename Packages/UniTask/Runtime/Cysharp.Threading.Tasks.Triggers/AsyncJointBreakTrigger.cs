namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncJointBreakTrigger : AsyncTriggerBase<float>
    {
        private void OnJointBreak(float breakForce)
        {
        }

        public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler()
        {
            return null;
        }

        public IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<float> OnJointBreakAsync()
        {
            return default(UniTask<float>);
        }

        public UniTask<float> OnJointBreakAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<float>);
        }

        public AsyncJointBreakTrigger()
        {
        }
    }
}
