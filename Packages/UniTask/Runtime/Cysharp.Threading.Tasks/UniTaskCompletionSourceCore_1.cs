namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;

    [StructLayout((LayoutKind)3)]
    public struct UniTaskCompletionSourceCore<TResult>
    {
        private TResult result;
        private object error;
        private short version;
        private bool hasUnhandledError;
        private int completedCount;
        private Action<object> continuation;
        private object continuationState;
        [DebuggerHidden]
        public short Version
        {
            get
            {
                return default(short);
            }
        }

        [DebuggerHidden]
        public void Reset()
        {
        }

        private void ReportUnhandledError()
        {
        }

        [DebuggerHidden]
        public bool TrySetResult(TResult result)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public bool TrySetException(Exception error)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public bool TrySetCanceled([Optional] CancellationToken cancellationToken)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public UniTaskStatus GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public UniTaskStatus UnsafeGetStatus()
        {
            return default(UniTaskStatus);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public TResult GetResult(short token)
        {
            return default(TResult);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public void OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        private void ValidateToken(short token)
        {
        }
    }
}
