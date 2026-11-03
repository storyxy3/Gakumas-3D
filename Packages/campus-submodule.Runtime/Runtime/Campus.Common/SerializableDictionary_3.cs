namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public abstract class SerializableDictionary<TKey, TValue, Type>
        where Type : SerializableKeyAndValue<TKey, TValue>
    {
        [SerializeField]
        private List<Type> _list;
        private Dictionary<TKey, TValue> _table;
        private Dictionary<TKey, TValue> Table
        {
            get
            {
                return null;
            }
        }

        public TKey this[TKey key]
        {
            set
            {
            }
        }

        public IReadOnlyDictionary<TKey, TValue> GetDictionary()
        {
            return null;
        }

        private static Dictionary<TKey, TValue> ConvertListToDictionary(IEnumerable<Type> list)
        {
            return null;
        }

        public void Add(TKey key, TValue value)
        {
        }

        protected abstract Type CreateType(TKey key, TValue value);
        public void Remove(TKey key)
        {
        }

        public void Clear()
        {
        }

        protected SerializableDictionary()
        {
        }
    }
}
