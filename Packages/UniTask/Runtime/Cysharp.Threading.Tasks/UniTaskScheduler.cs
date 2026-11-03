namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::UnityEngine;

    public static class UniTaskScheduler
    {
        [CompilerGenerated]
        private static Action<Exception> UnobservedTaskException;
        public static bool PropagateOperationCanceledException;
        public static LogType UnobservedExceptionWriteLogType;
        public static bool DispatchUnityMainThread;
        private static readonly SendOrPostCallback handleExceptionInvoke;
        private static void InvokeUnobservedTaskException(object state)
        {
        }

        internal static void PublishUnobservedTaskException(Exception ex)
        {
        }
    }
}
