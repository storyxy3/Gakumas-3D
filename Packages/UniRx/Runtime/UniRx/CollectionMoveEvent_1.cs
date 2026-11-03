namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public struct CollectionMoveEvent<T> : IEquatable<CollectionMoveEvent<T>>
    {
        [CompilerGenerated]
        private int _003COldIndex_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CNewIndex_003Ek__BackingField;
        [CompilerGenerated]
        private T _003CValue_003Ek__BackingField;
        public readonly int OldIndex
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }
        }

        public readonly int NewIndex
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }
        }

        public readonly T Value
        {
            [CompilerGenerated]
            get
            {
                return default(T);
            }
        }

        public override string ToString()
        {
            return null;
        }

        public override int GetHashCode()
        {
            return default(int);
        }

        public bool Equals(CollectionMoveEvent<T> other)
        {
            return default(bool);
        }
    }
}
