namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal class PriorityHeap<TValue>
        where TValue : class
    {
        public delegate bool LessOrEqual(TValue lhs, TValue rhs);
        internal class HandleElem
        {
            internal TValue _key;
            internal int _node;
            public HandleElem()
            {
            }
        }

        private LessOrEqual _leq;
        private int[] _nodes;
        private HandleElem[] _handles;
        private int _size;
        private int _max;
        private int _freeList;
        private bool _initialized;
        public bool Empty
        {
            get
            {
                return default(bool);
            }
        }

        public PriorityHeap(int initialSize, LessOrEqual leq)
        {
        }

        private void FloatDown(int curr)
        {
        }

        private void FloatUp(int curr)
        {
        }

        public void Init()
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
