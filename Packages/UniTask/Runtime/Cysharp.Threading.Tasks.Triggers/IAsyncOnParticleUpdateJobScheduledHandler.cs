namespace Cysharp.Threading.Tasks.Triggers
{
    using global::Cysharp.Threading.Tasks;
    using global::UnityEngine.ParticleSystemJobs;

    public interface IAsyncOnParticleUpdateJobScheduledHandler
    {
        UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync();
    }
}
