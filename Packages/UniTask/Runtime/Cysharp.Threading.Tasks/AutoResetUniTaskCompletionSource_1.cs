namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public class AutoResetUniTaskCompletionSource<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, ITaskPoolNode<AutoResetUniTaskCompletionSource<T>>
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ecctor_003Eb__4_0()
            {
                return default(int);
            }
        }

        private static TaskPool<AutoResetUniTaskCompletionSource<T>> pool;
        private AutoResetUniTaskCompletionSource<T> nextNode;
        private UniTaskCompletionSourceCore<T> core;
        private short version;
        public unsafe ref AutoResetUniTaskCompletionSource<T> NextNode
        {
            get
            {
                throw null;
            }
        }

        static AutoResetUniTaskCompletionSource()
        {
        }

        private AutoResetUniTaskCompletionSource()
        {
        }

        [DebuggerHidden]
        public static AutoResetUniTaskCompletionSource<T> Create()
        {
            return null;
        }

        [DebuggerHidden]
        public static AutoResetUniTaskCompletionSource<T> CreateFromCanceled(CancellationToken cancellationToken, out short token)
        {
            throw null;
        }

        [DebuggerHidden]
        public bool TrySetCanceled([Optional] CancellationToken cancellationToken)
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
        private bool TryReturn()
        {
            return default(bool);
        }
    }
}
