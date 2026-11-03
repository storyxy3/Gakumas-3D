namespace Cysharp.Threading.Tasks.Linq
{
    using global::System;
    using global::System.Threading;

    internal sealed class CancellationTokenDisposable : IDisposable
    {
        private readonly CancellationTokenSource cts;
        public CancellationToken Token
        {
            get
            {
                return default(CancellationToken);
            }
        }

        public void Dispose()
        {
        }

        public CancellationTokenDisposable()
        {
        }
    }
}
