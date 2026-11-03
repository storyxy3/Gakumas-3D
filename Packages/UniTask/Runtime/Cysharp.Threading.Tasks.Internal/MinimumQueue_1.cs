namespace Cysharp.Threading.Tasks.Internal
{
    using global::System.Runtime.CompilerServices;

    internal class MinimumQueue<T>
    {
        private T[] array;
        private int head;
        private int tail;
        private int size;
        public int Count
        {
            [MethodImpl(256)]
            get
            {
                return default(int);
            }
        }

        public MinimumQueue(int capacity)
        {
        }

        [MethodImpl(256)]
        public void Enqueue(T item)
        {
        }

        [MethodImpl(256)]
        public T Dequeue()
        {
            return default(T);
        }

        private void Grow()
        {
        }

        private void SetCapacity(int capacity)
        {
        }

        [MethodImpl(256)]
        private void MoveNext(ref int index)
        {
        }

        private void ThrowForEmptyQueue()
        {
        }
    }
}
