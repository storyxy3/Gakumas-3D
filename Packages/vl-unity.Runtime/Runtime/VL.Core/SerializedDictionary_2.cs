namespace VL.Core
{
    using global::System;
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL.Core;

    [Serializable]
    public class SerializedDictionary<TKey, TValue> : ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<TKey> _keys;
        [SerializeField]
        private List<TValue> _values;
        private Dictionary<TKey, TValue> _dictionary;
        public TKey this[TKey key]
        {
            set
            {
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                return null;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                return null;
            }
        }

        public SerializedDictionary()
        {
        }

        public SerializedDictionary(int capacity)
        {
        }

        public void Clear()
        {
        }

        public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
        {
            return default(Dictionary<TKey, TValue>.Enumerator);
        }

        public void Add(TKey key, TValue value)
        {
        }

        public bool Remove(TKey key)
        {
            return default(bool);
        }

        public bool ContainsKey(TKey key)
        {
            return default(bool);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw null;
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        public static implicit operator Dictionary<TKey, TValue>(SerializedDictionary<TKey, TValue> d)
        {
            return null;
        }
    }
}
