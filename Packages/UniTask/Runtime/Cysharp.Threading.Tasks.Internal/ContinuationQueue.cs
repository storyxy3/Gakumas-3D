namespace Cysharp.Threading.Tasks.Internal
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    internal sealed class ContinuationQueue
    {
        private readonly PlayerLoopTiming timing;
        private SpinLock gate;
        private bool dequing;
        private int actionListCount;
        private Action[] actionList;
        private int waitingListCount;
        private Action[] waitingList;
        public ContinuationQueue(PlayerLoopTiming timing)
        {
        }

        public void Enqueue(Action continuation)
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
