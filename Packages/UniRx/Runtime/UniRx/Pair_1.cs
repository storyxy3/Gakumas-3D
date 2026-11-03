namespace UniRx
{
    using global::System;
    using global::UniRx;

    [Serializable]
    public struct Pair<T> : IEquatable<Pair<T>>
    {
        private readonly T previous;
        private readonly T current;
        public T Previous
        {
            get
            {
                return default(T);
            }
        }

        public T Current
        {
            get
            {
                return default(T);
            }
        }

        public Pair(T previous, T current)
        {
            this = default;
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(Pair<T> other)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
