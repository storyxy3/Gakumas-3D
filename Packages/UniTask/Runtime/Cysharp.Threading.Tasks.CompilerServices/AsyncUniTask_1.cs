namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    internal sealed class AsyncUniTask<TStateMachine> : IStateMachineRunnerPromise, IUniTaskSource, IValueTaskSource, ITaskPoolNode<AsyncUniTask<TStateMachine>> where TStateMachine : IAsyncStateMachine
    {
        private static TaskPool<AsyncUniTask<TStateMachine>> pool;
        private readonly Action returnDelegate;
        [CompilerGenerated]
        private readonly Action _003CMoveNext_003Ek__BackingField;
        private TStateMachine stateMachine;
        private UniTaskCompletionSourceCore<AsyncUnit> core;
        private AsyncUniTask<TStateMachine> nextNode;
        public Action MoveNext
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public unsafe ref AsyncUniTask<TStateMachine> NextNode
        {
            get
            {
                throw null;
            }
        }

        public UniTask Task
        {
            [DebuggerHidden]
            get
            {
                return default(UniTask);
            }
        }

        private AsyncUniTask()
        {
        }

        public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise runnerPromiseFieldRef)
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
        public void SetResult()
        {
        }

        [DebuggerHidden]
        public void SetException(Exception exception)
        {
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
    }
}
