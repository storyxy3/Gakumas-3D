namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;

    public class AutoResetUniTaskCompletionSource : IUniTaskSource, IValueTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>
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

        private static TaskPool<AutoResetUniTaskCompletionSource> pool;
        private AutoResetUniTaskCompletionSource nextNode;
        private UniTaskCompletionSourceCore<AsyncUnit> core;
        private short version;
        public unsafe ref AutoResetUniTaskCompletionSource NextNode
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
        public static AutoResetUniTaskCompletionSource Create()
        {
            return null;
        }

        [DebuggerHidden]
        public static AutoResetUniTaskCompletionSource CreateFromCanceled(CancellationToken cancellationToken, out short token)
        {
            throw null;
        }

        [DebuggerHidden]
        public bool TrySetCanceled([Optional] CancellationToken cancellationToken)
        {
            return default(bool);
        }

        [DebuggerHidden]
        public void GetResult(short token)
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
