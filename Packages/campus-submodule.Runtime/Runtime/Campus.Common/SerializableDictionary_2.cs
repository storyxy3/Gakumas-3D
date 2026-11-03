namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;

    [Serializable]
    public class SerializableDictionary<TKey, TValue> : SerializableDictionary<TKey, TValue, SerializableKeyAndValue<TKey, TValue>>
    {
        protected override SerializableKeyAndValue<TKey, TValue> CreateType(TKey key, TValue value)
        {
            return null;
        }

        public SerializableDictionary()
        {
        }
    }
}
