namespace Cysharp.Threading.Tasks.Internal
{
    using global::System;

    internal sealed class SingleAssignmentDisposable : IDisposable
    {
        private readonly object gate;
        private IDisposable current;
        private bool disposed;
        public IDisposable Disposable
        {
            set
            {
            }
        }

        public void Dispose()
        {
        }

        public SingleAssignmentDisposable()
        {
        }
    }
}
