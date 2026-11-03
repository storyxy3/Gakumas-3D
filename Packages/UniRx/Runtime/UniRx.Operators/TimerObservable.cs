namespace UniRx.Operators
{
    using global::System;
    using global::System.Runtime.CompilerServices;
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

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public Timer timerObserver;
            public TimerObservable _003C_003E4__this;
            public _003C_003Ec__DisplayClass6_0()
            {
            }

            internal void _003CSubscribeCore_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_1
        {
            public ISchedulerPeriodic periodicScheduler;
            public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass6_1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_2
        {
            public SerialDisposable disposable;
            public _003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals2;
            public _003C_003Ec__DisplayClass6_2()
            {
            }

            internal void _003CSubscribeCore_003Eb__1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_3
        {
            public TimeSpan timeP;
            public _003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals3;
            public _003C_003Ec__DisplayClass6_3()
            {
            }

            internal void _003CSubscribeCore_003Eb__2(Action<TimeSpan> self)
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
