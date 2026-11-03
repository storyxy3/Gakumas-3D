namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncControllerColliderHitTrigger : AsyncTriggerBase<ControllerColliderHit>
    {
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
        }

        public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler()
        {
            return null;
        }

        public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<ControllerColliderHit> OnControllerColliderHitAsync()
        {
            return default(UniTask<ControllerColliderHit>);
        }

        public UniTask<ControllerColliderHit> OnControllerColliderHitAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<ControllerColliderHit>);
        }

        public AsyncControllerColliderHitTrigger()
        {
        }
    }
}
