namespace Titan
{
    using global::System.Collections.Generic;

    internal abstract class ObjectPool<T>
    {
        private readonly Stack<T> _pool;
        protected abstract T CreateInstance();
        public T Rent()
        {
            return default(T);
        }

        public void Return(T instance)
        {
        }

        protected virtual void OnReturn(T instance)
        {
        }

        protected ObjectPool()
        {
        }
    }
}
