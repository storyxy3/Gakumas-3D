namespace UniRx.Operators
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Operators;

    internal class TimerObservable : OperatorObservableBase<long>
    {
        private class Timer : OperatorObserverBase<long, long>
        {
            private long index;
            // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
            public Timer(IObserver<long> observer, IDisposable cancel) : base(default, default)
            {
            }

            public void OnNext()
            {
            }

            public override void OnNext(long value)
            {
            }

            public override void OnError(Exception error)
            {
            }

            public override void OnCompleted()
            {
            }
        }

        private readonly DateTimeOffset? dueTimeA;
        private readonly TimeSpan? dueTimeB;
        private readonly TimeSpan? period;
        private readonly IScheduler scheduler;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public TimerObservable(TimeSpan dueTime, TimeSpan? period, IScheduler scheduler) : base(default)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<long> observer, IDisposable cancel)
        {
            return null;
        }
    }
}
