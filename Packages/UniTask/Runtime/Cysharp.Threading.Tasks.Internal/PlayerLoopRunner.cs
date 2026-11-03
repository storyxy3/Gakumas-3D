namespace Cysharp.Threading.Tasks.Internal
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Internal;

    internal sealed class PlayerLoopRunner
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Action<Exception> _003C_003E9__9_0;
            public _003C_003Ec()
            {
            }

            internal void _003C_002Ector_003Eb__9_0(Exception ex)
            {
            }
        }

        private readonly PlayerLoopTiming timing;
        private readonly object runningAndQueueLock;
        private readonly object arrayLock;
        private readonly Action<Exception> unhandledExceptionCallback;
        private int tail;
        private bool running;
        private IPlayerLoopItem[] loopItems;
        private MinimumQueue<IPlayerLoopItem> waitQueue;
        public PlayerLoopRunner(PlayerLoopTiming timing)
        {
        }

        public void AddAction(IPlayerLoopItem item)
        {
        }

        public void Run()
        {
        }

        [DebuggerHidden]
        private void RunCore()
        {
        }
    }
}
