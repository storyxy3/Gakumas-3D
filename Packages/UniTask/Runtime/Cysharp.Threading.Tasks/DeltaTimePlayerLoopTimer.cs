namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    internal sealed class DeltaTimePlayerLoopTimer : PlayerLoopTimer
    {
        private int initialFrame;
        private float elapsed;
        private float interval;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public DeltaTimePlayerLoopTimer(TimeSpan interval, bool periodic, PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken, Action<object> timerCallback, object state) : base(default, default, default, default, default)
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
