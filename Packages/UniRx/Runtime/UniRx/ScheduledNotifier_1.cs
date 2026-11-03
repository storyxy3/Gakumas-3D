namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public class ScheduledNotifier<T> : IObservable<T>, IProgress<T>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass4_0
        {
            public ScheduledNotifier<T> _003C_003E4__this;
            public T value;
            public _003C_003Ec__DisplayClass4_0()
            {
            }

            internal void _003CReport_003Eb__0()
            {
            }
        }

        private readonly IScheduler scheduler;
        private readonly Subject<T> trigger;
        public ScheduledNotifier()
        {
        }

        public void Report(T value)
        {
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return null;
        }
    }
}
