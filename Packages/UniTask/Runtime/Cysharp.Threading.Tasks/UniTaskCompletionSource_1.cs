namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public class UniTaskCompletionSource<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
    {
        private CancellationToken cancellationToken;
        private T result;
        private ExceptionHolder exception;
        private object gate;
        private Action<object> singleContinuation;
        private object singleState;
        private List<(Action<object>, object)> secondaryContinuationList;
        private int intStatus;
        private bool handled;
        public UniTask<T> Task
        {
            [DebuggerHidden]
            get
            {
                return default(UniTask<T>);
            }
        }

        public UniTaskCompletionSource()
        {
        }

        [DebuggerHidden]
        internal void MarkHandled()
        {
        }

        [DebuggerHidden]
        public bool TrySetResult(T result)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public bool TrySetCanceled([Optional] CancellationToken cancellationToken)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public bool TrySetException(Exception exception)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public T GetResult(short token)
        {
            return default(T);
        }

        [DebuggerHidden]
        void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
        {
        }

        [DebuggerHidden]
        public UniTaskStatus GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        [DebuggerHidden]
        public UniTaskStatus UnsafeGetStatus()
        {
            return default(UniTaskStatus);
        }

        [DebuggerHidden]
        public void OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        [DebuggerHidden]
        private bool TrySignalCompletion(UniTaskStatus status)
        {
            return default(bool);
        }
    }
}
