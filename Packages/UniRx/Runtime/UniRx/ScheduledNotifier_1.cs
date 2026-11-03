namespace UniRx
{
    using global::System;
    using global::UniRx;

    public class ScheduledNotifier<T> : IObservable<T>, IProgress<T>
    {
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
