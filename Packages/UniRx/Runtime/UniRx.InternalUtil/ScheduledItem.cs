namespace UniRx.InternalUtil
{
    using global::System;
    using global::UniRx;
    using global::UniRx.InternalUtil;

    internal class ScheduledItem : IComparable<ScheduledItem>
    {
        private readonly BooleanDisposable _disposable;
        private readonly TimeSpan _dueTime;
        private readonly Action _action;
        public TimeSpan DueTime
        {
            get
            {
                return default(TimeSpan);
            }
        }

        public IDisposable Cancellation
        {
            get
            {
                return null;
            }
        }

        public bool IsCanceled
        {
            get
            {
                return default(bool);
            }
        }

        public ScheduledItem(Action action, TimeSpan dueTime)
        {
        }

        public void Invoke()
        {
        }

        public int CompareTo(ScheduledItem other)
        {
            return default(int);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return default(int);
        }
    }
}
