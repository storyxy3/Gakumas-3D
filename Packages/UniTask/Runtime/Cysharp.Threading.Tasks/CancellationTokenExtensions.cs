namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Threading;

    public static class CancellationTokenExtensions
    {
        private static readonly Action<object> cancellationTokenCallback;
        private static readonly Action<object> disposeCallback;
        private static void Callback(object state)
        {
        }

        public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state)
        {
            return default(CancellationTokenRegistration);
        }

        public static CancellationTokenRegistration AddTo(this IDisposable disposable, CancellationToken cancellationToken)
        {
            return default(CancellationTokenRegistration);
        }

        private static void DisposeCallback(object state)
        {
        }
    }
}
