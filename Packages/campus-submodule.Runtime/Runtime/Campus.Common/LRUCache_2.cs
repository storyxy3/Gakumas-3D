namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;

    public class LRUCache<TKey, TValue>
    {
        protected class Node
        {
            public Node next;
            public Node previous;
            public TKey key;
            public TValue value;
            public Node()
            {
            }
        }

        protected Dictionary<TKey, Node> _entries;
        protected int _capacity;
        protected Node _head;
        protected Node _tail;
        protected List<Node> _recycleNode;
        private Action<TValue> _onRemoveCache;
        public IEnumerable<TValue> Values
        {
            get
            {
                return null;
            }
        }

        public LRUCache()
        {
        }

        public LRUCache(int capacity, Action<TValue> onRemoveCache, [Optional] IEqualityComparer<TKey> comparer)
        {
        }

        protected virtual void Initialize(int capacity, Action<TValue> onRemoveCache, IEqualityComparer<TKey> comparer)
        {
        }

        public virtual void Add(TKey key, TValue value)
        {
        }

        public virtual bool TryGetValue(TKey key, out TValue value)
        {
            throw null;
        }

        public bool Remove(TKey key)
        {
            return default(bool);
        }

        public virtual void Clear()
        {
        }

        public virtual bool IsCapacityFull()
        {
            return default(bool);
        }

        private void MoveToHead(Node entry)
        {
        }

        private void RemoveTail()
        {
        }

        private Node CreateNode()
        {
            return null;
        }

        private void ReleaseNode(Node node)
        {
        }
    }
}
