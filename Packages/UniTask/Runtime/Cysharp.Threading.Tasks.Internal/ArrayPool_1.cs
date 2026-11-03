namespace Cysharp.Threading.Tasks.Internal
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks.Internal;

    internal sealed class ArrayPool<T>
    {
        private static readonly T[] EmptyArray;
        public static readonly ArrayPool<T> Shared;
        private readonly MinimumQueue<T[]>[] buckets;
        private readonly SpinLock[] locks;
        private ArrayPool()
        {
        }

        public T[] Rent(int minimumLength)
        {
            return null;
        }

        public void Return(T[] array, bool clearArray = false)
        {
        }

        private static int CalculateSize(int size)
        {
            return default(int);
        }

        private static int GetQueueIndex(int size)
        {
            return default(int);
        }
    }
}
