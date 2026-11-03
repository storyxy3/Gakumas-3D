namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public struct CollectionAddEvent<T> : IEquatable<CollectionAddEvent<T>>
    {
        [CompilerGenerated]
        private int _003CIndex_003Ek__BackingField;
        [CompilerGenerated]
        private T _003CValue_003Ek__BackingField;
        public int Index
        {
            [CompilerGenerated]
            readonly get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public T Value
        {
            [CompilerGenerated]
            readonly get
            {
                return default(T);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public CollectionAddEvent(int index, T value)
        {
            this = default;
        }

        public override string ToString()
        {
            return null;
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public bool Equals(CollectionAddEvent<T> other)
        {
            return default(bool);
        }
    }
}
