namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Triggers;
    using global::UnityEngine;

    [DisallowMultipleComponent]
    public sealed class AsyncDestroyTrigger : MonoBehaviour
    {
        private class AwakeMonitor : IPlayerLoopItem
        {
            private readonly AsyncDestroyTrigger trigger;
            public AwakeMonitor(AsyncDestroyTrigger trigger)
            {
            }

            public bool MoveNext()
            {
                return default(bool);
            }
        }

        private bool awakeCalled;
        private bool called;
        private CancellationTokenSource cancellationTokenSource;
        public CancellationToken CancellationToken
        {
            get
            {
                return default(CancellationToken);
            }
        }

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public UniTask OnDestroyAsync()
        {
            return default(UniTask);
        }

        public AsyncDestroyTrigger()
        {
        }
    }
}
