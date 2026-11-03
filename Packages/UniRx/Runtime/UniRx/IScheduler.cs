namespace UniRx
{
    using global::System;

    public interface IScheduler
    {
        DateTimeOffset Now { get; }

        IDisposable Schedule(Action action);
        IDisposable Schedule(TimeSpan dueTime, Action action);
    }
}
