namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncParticleSystemStoppedTrigger : AsyncTriggerBase<AsyncUnit>
    {
        private void OnParticleSystemStopped()
        {
        }

        public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler()
        {
            return null;
        }

        public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask OnParticleSystemStoppedAsync()
        {
            return default(UniTask);
        }

        public UniTask OnParticleSystemStoppedAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public AsyncParticleSystemStoppedTrigger()
        {
        }
    }
}
