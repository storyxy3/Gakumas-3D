namespace Cysharp.Threading.Tasks
{
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Cysharp.Threading.Tasks;

    [StructLayout((LayoutKind)3)]
    public struct TaskPool<T>
        where T : class, ITaskPoolNode<T>
    {
        private int gate;
        private int size;
        private T root;
        public int Size
        {
            get
            {
                return default(int);
            }
        }

        [MethodImpl(256)]
        public bool TryPop(out T result)
        {
            throw null;
        }

        [MethodImpl(256)]
        public bool TryPush(T item)
        {
            return default(bool);
        }
    }
}
