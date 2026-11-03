namespace UniRx
{
    using global::System;
    using global::System.Threading;
    using global::UniRx;

    public sealed class CancellationDisposable : ICancelable, IDisposable
    {
        private readonly CancellationTokenSource _cts;
        public CancellationToken Token
        {
            get
            {
                return default(CancellationToken);
            }
        }

        public bool IsDisposed
        {
            get
            {
                return default(bool);
            }
        }

        public CancellationDisposable(CancellationTokenSource cts)
        {
        }

        public CancellationDisposable()
        {
        }

        public void Dispose()
        {
        }
    }
}
