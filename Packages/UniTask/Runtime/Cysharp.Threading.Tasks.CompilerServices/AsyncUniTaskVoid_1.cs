namespace Cysharp.Threading.Tasks.CompilerServices
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    internal sealed class AsyncUniTaskVoid<TStateMachine> : IStateMachineRunner, ITaskPoolNode<AsyncUniTaskVoid<TStateMachine>>, IUniTaskSource, IValueTaskSource where TStateMachine : IAsyncStateMachine
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ecctor_003Eb__10_0()
            {
                return default(int);
            }
        }

        private static TaskPool<AsyncUniTaskVoid<TStateMachine>> pool;
        [CompilerGenerated]
        private readonly Action _003CReturnAction_003Ek__BackingField;
        private TStateMachine stateMachine;
        [CompilerGenerated]
        private readonly Action _003CMoveNext_003Ek__BackingField;
        private AsyncUniTaskVoid<TStateMachine> nextNode;
        public Action ReturnAction
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public Action MoveNext
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public unsafe ref AsyncUniTaskVoid<TStateMachine> NextNode
        {
            get
            {
                throw null;
            }
        }

        public AsyncUniTaskVoid()
        {
        }

        public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunner runnerFieldRef)
        {
        }

        static AsyncUniTaskVoid()
        {
        }

        public void Return()
        {
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        private void Run()
        {
        }

        UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token)
        {
            return default(UniTaskStatus);
        }

        UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus()
        {
            return default(UniTaskStatus);
        }

        void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<object> continuation, object state, short token)
        {
        }

        void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
        {
        }
    }
}
