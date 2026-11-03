namespace UniRx
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::UniRx;

    public sealed class CompositeDisposable : ICollection<IDisposable>, IEnumerable<IDisposable>, IEnumerable, IDisposable, ICancelable
    {
        private readonly object _gate;
        private bool _disposed;
        private List<IDisposable> _disposables;
        private int _count;
        private const int SHRINK_THRESHOLD = 64;
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsDisposed
        {
            get
            {
                return default(bool);
            }
        }

        public CompositeDisposable()
        {
        }

        public CompositeDisposable(int capacity)
        {
        }

        public void Add(IDisposable item)
        {
        }

        public bool Remove(IDisposable item)
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        public void Clear()
        {
        }

        public bool Contains(IDisposable item)
        {
            return default(bool);
        }

        public void CopyTo(IDisposable[] array, int arrayIndex)
        {
        }

        public IEnumerator<IDisposable> GetEnumerator()
        {
            return null;
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
