namespace UniRx.InternalUtil
{
    using global::System;
    using global::UniRx.InternalUtil;

    internal class PriorityQueue<T>
        where T : IComparable<T>
    {
        private struct IndexedItem : IComparable<IndexedItem>
        {
            public T Value;
            public long Id;
            public int CompareTo(IndexedItem other)
            {
                return default(int);
            }
        }

        private static long _count;
        private IndexedItem[] _items;
        private int _size;
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public PriorityQueue(int capacity)
        {
        }

        private bool IsHigherPriority(int left, int right)
        {
            return default(bool);
        }

        private void Percolate(int index)
        {
        }

        private void Heapify()
        {
        }

        private void Heapify(int index)
        {
        }

        public T Peek()
        {
            return default(T);
        }

        private void RemoveAt(int index)
        {
        }

        public T Dequeue()
        {
            return default(T);
        }

        public void Enqueue(T item)
        {
        }
    }
}
