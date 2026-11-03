namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public struct DictionaryReplaceEvent<TKey, TValue> : IEquatable<DictionaryReplaceEvent<TKey, TValue>>
    {
        [CompilerGenerated]
        private TKey _003CKey_003Ek__BackingField;
        [CompilerGenerated]
        private TValue _003COldValue_003Ek__BackingField;
        [CompilerGenerated]
        private TValue _003CNewValue_003Ek__BackingField;
        public TKey Key
        {
            [CompilerGenerated]
            readonly get
            {
                return default(TKey);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public TValue OldValue
        {
            [CompilerGenerated]
            readonly get
            {
                return default(TValue);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public TValue NewValue
        {
            [CompilerGenerated]
            readonly get
            {
                return default(TValue);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public DictionaryReplaceEvent(TKey key, TValue oldValue, TValue newValue)
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

        public bool Equals(DictionaryReplaceEvent<TKey, TValue> other)
        {
            return default(bool);
        }
    }
}
