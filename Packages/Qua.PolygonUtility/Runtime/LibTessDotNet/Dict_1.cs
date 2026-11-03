namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal class Dict<TValue>
        where TValue : class
    {
        public class Node : Pooled<Node>
        {
            internal TValue _key;
            internal Node _prev;
            internal Node _next;
            public TValue Key
            {
                get
                {
                    return null;
                }
            }

            public void Init(IPool pool)
            {
            }

            public void Reset(IPool pool)
            {
            }

            public Node()
            {
            }
        }

        public delegate bool LessOrEqual(TValue lhs, TValue rhs);
        private IPool _pool;
        private LessOrEqual _leq;
        private Node _head;
        public Dict(IPool pool, LessOrEqual leq)
        {
        }

        public void Init()
        {
        }

        public void Reset()
        {
        }

        public Node Insert(TValue key)
        {
            return null;
        }

        public Node InsertBefore(Node node, TValue key)
        {
            return null;
        }

        public Node Find(TValue key)
        {
            return null;
        }

        public Node Min()
        {
            return null;
        }

        public void Remove(Node node)
        {
        }
    }
}
