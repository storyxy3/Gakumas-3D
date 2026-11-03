namespace Qua.Utility
{
    using global::System;
    using global::System.Collections.Generic;

    public abstract class ObjectPool<T> : IDisposable
    {
        private bool _isDisposed;
        private Stack<T> _pool;
        protected virtual int InitialCapacity
        {
            get
            {
                return default(int);
            }
        }

        protected int MaxPoolCount
        {
            get
            {
                return default(int);
            }
        }

        protected abstract T CreateInstance();
        protected virtual void OnBeforeRent(T instance)
        {
        }

        protected virtual void OnBeforeReturn(T instance)
        {
        }

        protected virtual void OnClear(T instance)
        {
        }

        public T Rent()
        {
            return default(T);
        }

        public void Return(T instance)
        {
        }

        public void Clear(bool callOnBeforeRent = false)
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
        }

        protected ObjectPool()
        {
        }
    }
}
