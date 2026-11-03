namespace Campus.Common
{
    using global::System;

    [Serializable]
    public class SerializableKeyAndValue<TKey, TValue>
    {
        public TKey key;
        public TValue value;
        public SerializableKeyAndValue(TKey key, TValue value)
        {
        }
    }
}
