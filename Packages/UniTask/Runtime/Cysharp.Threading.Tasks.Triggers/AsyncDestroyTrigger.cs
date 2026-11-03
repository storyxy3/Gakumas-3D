namespace Cysharp.Threading.Tasks.Triggers
{
    using global::System;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Action<object> _003C_003E9__7_0;
            public _003C_003Ec()
            {
            }

            internal void _003COnDestroyAsync_003Eb__7_0(object state)
            {
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
