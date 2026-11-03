namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.Serialization;
    using global::UniRx;
    using global::UnityEngine;

    [Serializable]
    public class ReactiveDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IDisposable, ISerializable, IDeserializationCallback
    {
        [NonSerialized]
        private bool isDisposed;
        [SerializeField]
        private readonly Dictionary<TKey, TValue> inner;
        private bool disposedValue;
        [NonSerialized]
        private Subject<int> countChanged;
        [NonSerialized]
        private Subject<Unit> collectionReset;
        [NonSerialized]
        private Subject<DictionaryAddEvent<TKey, TValue>> dictionaryAdd;
        [NonSerialized]
        private Subject<DictionaryRemoveEvent<TKey, TValue>> dictionaryRemove;
        [NonSerialized]
        private Subject<DictionaryReplaceEvent<TKey, TValue>> dictionaryReplace;
        public TValue this[TKey key]
        {
            get
            {
                return default(TValue);
            }

            set
            {
            }
        }

        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public Dictionary<TKey, TValue>.ValueCollection Values
        {
            get
            {
                return null;
            }
        }

        object System.Collections.IDictionary.this[object key]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        bool System.Collections.IDictionary.IsFixedSize
        {
            get
            {
                return default(bool);
            }
        }

        bool System.Collections.IDictionary.IsReadOnly
        {
            get
            {
                return default(bool);
            }
        }

        bool System.Collections.ICollection.IsSynchronized
        {
            get
            {
                return default(bool);
            }
        }

        ICollection System.Collections.IDictionary.Keys
        {
            get
            {
                return null;
            }
        }

        object System.Collections.ICollection.SyncRoot
        {
            get
            {
                return null;
            }
        }

        ICollection System.Collections.IDictionary.Values
        {
            get
            {
                return null;
            }
        }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get
            {
                return default(bool);
            }
        }

        ICollection<TKey> System.Collections.Generic.IDictionary<TKey, TValue>.Keys
        {
            get
            {
                return null;
            }
        }

        ICollection<TValue> System.Collections.Generic.IDictionary<TKey, TValue>.Values
        {
            get
            {
                return null;
            }
        }

        public ReactiveDictionary()
        {
        }

        public ReactiveDictionary(Dictionary<TKey, TValue> innerDictionary)
        {
        }

        public void Add(TKey key, TValue value)
        {
        }

        public void Clear()
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

        private void DisposeSubject<TSubject>(ref Subject<TSubject> subject)
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
        }

        public IObservable<int> ObserveCountChanged(bool notifyCurrentCount = false)
        {
            return null;
        }

        public IObservable<DictionaryAddEvent<TKey, TValue>> ObserveAdd()
        {
            return null;
        }

        public IObservable<DictionaryRemoveEvent<TKey, TValue>> ObserveRemove()
        {
            return null;
        }

        public IObservable<DictionaryReplaceEvent<TKey, TValue>> ObserveReplace()
        {
            return null;
        }

        void System.Collections.IDictionary.Add(object key, object value)
        {
        }

        bool System.Collections.IDictionary.Contains(object key)
        {
            return default(bool);
        }

        void System.Collections.ICollection.CopyTo(Array array, int index)
        {
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        public void OnDeserialization(object sender)
        {
        }

        void System.Collections.IDictionary.Remove(object key)
        {
        }

        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
        }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
        {
            return default(bool);
        }

        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
        }

        IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.GetEnumerator()
        {
            return null;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
        {
            return default(bool);
        }

        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
        {
            return null;
        }

        [CompilerGenerated]
        private int _003CObserveCountChanged_003Eb__25_0()
        {
            return default(int);
        }
    }
}
