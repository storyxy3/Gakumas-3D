namespace Qua.Utility
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;

    public static class UniTaskUtility
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public UniTaskCompletionSource utcs;
            public Action<Action> removeHandler;
            public Action onExecute;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal void _003CFromEventAsync_003Eb__0()
            {
            }

            internal void _003CFromEventAsync_003Eb__1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0<T>
        {
            public UniTaskCompletionSource<T> utcs;
            public Action<Action<T>> removeHandler;
            public Action<T> onExecute;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal void _003CFromEventAsync_003Eb__0(T args)
            {
            }

            internal void _003CFromEventAsync_003Eb__1()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CFromEventAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Action<Action> removeHandler;
            public CancellationToken ct;
            public Action<Action> addHandler;
            private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;
            private CancellationTokenRegistration _003ConCancel_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CFromEventAsync_003Ed__1<T> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public Action<Action<T>> removeHandler;
            public CancellationToken ct;
            public Action<Action<T>> addHandler;
            private _003C_003Ec__DisplayClass1_0<T> _003C_003E8__1;
            private CancellationTokenRegistration _003ConCancel_003E5__2;
            private UniTask<T>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CFromEventAsync_003Ed__0))]
        public static UniTask FromEventAsync(Action<Action> addHandler, Action<Action> removeHandler, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CFromEventAsync_003Ed__1<>))]
        public static UniTask<T> FromEventAsync<T>(Action<Action<T>> addHandler, Action<Action<T>> removeHandler, CancellationToken ct)
        {
            return default(UniTask<T>);
        }
    }
}
