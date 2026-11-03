namespace UniRx
{
    using global::System;
    using global::UniRx;

    public sealed class SerialDisposable : IDisposable, ICancelable
    {
        private readonly object gate;
        private IDisposable current;
        private bool disposed;
        public bool IsDisposed
        {
            get
            {
                return default(bool);
            }
        }

        public IDisposable Disposable
        {
            set
            {
            }
        }

        public void Dispose()
        {
        }

        public SerialDisposable()
        {
        }
    }
}
