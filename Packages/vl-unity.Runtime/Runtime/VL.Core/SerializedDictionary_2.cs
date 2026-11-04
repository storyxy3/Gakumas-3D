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
                return _dictionary.Keys;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                return _dictionary.Values;
            }
        }

        public SerializedDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public SerializedDictionary(int capacity)
        {
            _keys = new List<TKey>(capacity);
            _values = new List<TValue>(capacity);
            _dictionary = new Dictionary<TKey, TValue>(capacity);
        }

        public void Clear()
        {
            _dictionary.Clear();
        }

        public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public bool Remove(TKey key)
        {
            return _dictionary.Remove(key);
        }

        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return _dictionary.TryGetValue(key, out value);
        }

        public void OnBeforeSerialize()
        {
            _keys.Clear();
            _values.Clear();
            foreach (var pair in _dictionary)
            {
                _keys.Add(pair.Key);
                _values.Add(pair.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            if (_dictionary == null)
                _dictionary = new Dictionary<TKey, TValue>();
            else
                _dictionary.Clear();
            for (int i = 0; i < _keys.Count; ++i)
                _dictionary.Add(_keys[i], _values[i]);
        }

        public static implicit operator Dictionary<TKey, TValue>(SerializedDictionary<TKey, TValue> d)
        {
            return d?._dictionary;
        }
    }
}
