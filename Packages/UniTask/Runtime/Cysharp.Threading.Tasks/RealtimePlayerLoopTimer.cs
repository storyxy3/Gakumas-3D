namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.Internal;

    internal sealed class RealtimePlayerLoopTimer : PlayerLoopTimer
    {
        private ValueStopwatch stopwatch;
        private long intervalTicks;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public RealtimePlayerLoopTimer(TimeSpan interval, bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<object> timerCallback, object state) : base(default, default, default, default, default)
        {
        }

        protected override bool MoveNextCore()
        {
            return default(bool);
        }

        protected override void ResetCore(TimeSpan? interval)
        {
        }
    }
}
