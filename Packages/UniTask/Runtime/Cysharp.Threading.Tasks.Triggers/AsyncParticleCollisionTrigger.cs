namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncParticleCollisionTrigger : AsyncTriggerBase<GameObject>
    {
        private void OnParticleCollision(GameObject other)
        {
        }

        public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler()
        {
            return null;
        }

        public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<GameObject> OnParticleCollisionAsync()
        {
            return default(UniTask<GameObject>);
        }

        public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<GameObject>);
        }

        public AsyncParticleCollisionTrigger()
        {
        }
    }
}
