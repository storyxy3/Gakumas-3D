namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    [StructLayout((LayoutKind)3)]
    public struct AsyncUniTaskMethodBuilder<T>
    {
        private IStateMachineRunnerPromise<T> runnerPromise;
        private Exception ex;
        private T result;
        public UniTask<T> Task
        {
            [MethodImpl(256)]
            [DebuggerHidden]
            get
            {
                return default(UniTask<T>);
            }
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public static AsyncUniTaskMethodBuilder<T> Create()
        {
            return default(AsyncUniTaskMethodBuilder<T>);
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public void SetException(Exception exception)
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public void SetResult(T result)
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public void Start<TStateMachine>(ref TStateMachine stateMachine)
            where TStateMachine : IAsyncStateMachine
        {
        }

        [DebuggerHidden]
        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }
    }
}
