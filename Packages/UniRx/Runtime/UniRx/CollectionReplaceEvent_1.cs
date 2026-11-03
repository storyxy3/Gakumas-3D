namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public struct CollectionReplaceEvent<T> : IEquatable<CollectionReplaceEvent<T>>
    {
        [CompilerGenerated]
        private int _003CIndex_003Ek__BackingField;
        [CompilerGenerated]
        private T _003COldValue_003Ek__BackingField;
        [CompilerGenerated]
        private T _003CNewValue_003Ek__BackingField;
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

        public T OldValue
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

        public T NewValue
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

        public CollectionReplaceEvent(int index, T oldValue, T newValue)
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

        public bool Equals(CollectionReplaceEvent<T> other)
        {
            return default(bool);
        }
    }
}
