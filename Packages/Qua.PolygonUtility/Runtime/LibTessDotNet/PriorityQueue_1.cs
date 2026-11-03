namespace LibTessDotNet
{
    using global::System.Collections.Generic;
    using global::LibTessDotNet;

    internal class PriorityQueue<TValue>
        where TValue : class
    {
        private struct StackItem
        {
            internal int p;
            internal int r;
        }

        private static readonly Stack<StackItem> stack;
        private PriorityHeap<TValue>.LessOrEqual _leq;
        private PriorityHeap<TValue> _heap;
        private TValue[] _keys;
        private static readonly List<int> _order;
        private int _size;
        private int _max;
        private bool _initialized;
        public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
        {
        }

        private static void Swap(List<int> source, int a, int b)
        {
        }

        public void Init()
        {
        }

        public void Reset()
        {
        }

        public PQHandle Insert(TValue value)
        {
            return default(PQHandle);
        }

        public TValue ExtractMin()
        {
            return null;
        }

        public TValue Minimum()
        {
            return null;
        }

        public void Remove(PQHandle handle)
        {
        }
    }
}
