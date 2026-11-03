namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.ParticleSystemJobs;

    [DisallowMultipleComponent]
    public sealed class AsyncParticleUpdateJobScheduledTrigger : AsyncTriggerBase<ParticleSystemJobData>
    {
        private void OnParticleUpdateJobScheduled(ParticleSystemJobData particles)
        {
        }

        public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler()
        {
            return null;
        }

        public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync()
        {
            return default(UniTask<ParticleSystemJobData>);
        }

        public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<ParticleSystemJobData>);
        }

        public AsyncParticleUpdateJobScheduledTrigger()
        {
        }
    }
}
