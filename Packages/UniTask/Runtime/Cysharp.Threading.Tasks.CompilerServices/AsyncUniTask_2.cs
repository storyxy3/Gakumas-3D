namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    internal sealed class AsyncUniTask<TStateMachine, T> : IStateMachineRunnerPromise<T>, IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>, ITaskPoolNode<AsyncUniTask<TStateMachine, T>> where TStateMachine : IAsyncStateMachine
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ecctor_003Eb__12_0()
            {
                return default(int);
            }
        }

        private static TaskPool<AsyncUniTask<TStateMachine, T>> pool;
        private readonly Action returnDelegate;
        [CompilerGenerated]
        private readonly Action _003CMoveNext_003Ek__BackingField;
        private TStateMachine stateMachine;
        private UniTaskCompletionSourceCore<T> core;
        private AsyncUniTask<TStateMachine, T> nextNode;
        public Action MoveNext
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public unsafe ref AsyncUniTask<TStateMachine, T> NextNode
        {
            get
            {
                throw null;
            }
        }

        public UniTask<T> Task
        {
            [DebuggerHidden]
            get
            {
                return default(UniTask<T>);
            }
        }

        private AsyncUniTask()
        {
        }

        public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise<T> runnerPromiseFieldRef)
        {
        }

        static AsyncUniTask()
        {
        }

        private void Return()
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        private void Run()
        {
        }

        [DebuggerHidden]
        public void SetResult(T result)
        {
        }

        [DebuggerHidden]
        public void SetException(Exception exception)
        {
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
    }
}
