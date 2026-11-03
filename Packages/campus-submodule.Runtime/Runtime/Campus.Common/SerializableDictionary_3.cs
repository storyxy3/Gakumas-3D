namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public abstract class SerializableDictionary<TKey, TValue, Type>
        where Type : SerializableKeyAndValue<TKey, TValue>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<Type, TKey> _003C_003E9__5_0;
            public static Func<Type, TValue> _003C_003E9__5_1;
            public _003C_003Ec()
            {
            }

            internal TKey _003CConvertListToDictionary_003Eb__5_0(Type pair)
            {
                return default(TKey);
            }

            internal TValue _003CConvertListToDictionary_003Eb__5_1(Type pair)
            {
                return default(TValue);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass11_0
        {
            public TKey key;
            public _003C_003Ec__DisplayClass11_0()
            {
            }

            internal bool _003CRemove_003Eb__0(Type x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass9_0
        {
            public TKey key;
            public _003C_003Ec__DisplayClass9_0()
            {
            }

            internal bool _003CAdd_003Eb__0(Type x)
            {
                return default(bool);
            }
        }

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
