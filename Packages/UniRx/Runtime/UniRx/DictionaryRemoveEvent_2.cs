namespace UniRx
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UniRx;

    public struct DictionaryRemoveEvent<TKey, TValue> : IEquatable<DictionaryRemoveEvent<TKey, TValue>>
    {
        [CompilerGenerated]
        private TKey _003CKey_003Ek__BackingField;
        [CompilerGenerated]
        private TValue _003CValue_003Ek__BackingField;
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

        public TValue Value
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

        public DictionaryRemoveEvent(TKey key, TValue value)
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

        public bool Equals(DictionaryRemoveEvent<TKey, TValue> other)
        {
            return default(bool);
        }
    }
}
