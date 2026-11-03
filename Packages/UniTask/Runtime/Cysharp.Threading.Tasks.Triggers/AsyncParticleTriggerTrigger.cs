namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncParticleTriggerTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnParticleTrigger()
        {
        }

        public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler()
        {
            return null;
        }

        public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnParticleTriggerAsync()
        {
            return default(UniTask);
        }

        public UniTask OnParticleTriggerAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncParticleTriggerTrigger()
        {
        }
    }
}
