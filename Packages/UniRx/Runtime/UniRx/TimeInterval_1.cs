namespace UniRx
{
    using global::System;
    using global::UniRx;

    [Serializable]
    public struct TimeInterval<T> : IEquatable<TimeInterval<T>>
    {
        private readonly TimeSpan _interval;
        private readonly T _value;
        public T Value
        {
            get
            {
                return default(T);
            }
        }

        public TimeSpan Interval
        {
            get
            {
                return default(TimeSpan);
            }
        }

        public TimeInterval(T value, TimeSpan interval)
        {
            this = default;
        }

        public bool Equals(TimeInterval<T> other)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
