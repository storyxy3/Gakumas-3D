namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncTriggerStayTrigger : AsyncTriggerBase<Collider>
    {
        private void OnTriggerStay(Collider other)
        {
        }

        public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler()
        {
            return null;
        }

        public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler(CancellationToken cancellationToken)
        {
            return null;
        }

        public UniTask<Collider> OnTriggerStayAsync()
        {
            return default(UniTask<Collider>);
        }

        public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken)
        {
            return default(UniTask<Collider>);
        }

        public AsyncTriggerStayTrigger()
        {
        }
    }
}
