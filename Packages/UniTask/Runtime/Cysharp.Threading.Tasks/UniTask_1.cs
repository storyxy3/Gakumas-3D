namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    [StructLayout((LayoutKind)3)]
    [AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder<>))]
    public readonly struct UniTask<T>
    {
        private sealed class IsCanceledSource : IUniTaskSource<(bool, T)>, IUniTaskSource, IValueTaskSource, IValueTaskSource<(bool, T)>
        {
            private readonly IUniTaskSource<T> source;
            [MethodImpl(256)]
            [DebuggerHidden]
            public IsCanceledSource(IUniTaskSource<T> source)
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public (bool, T) GetResult(short token)
            {
                return default((bool, T));
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
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
            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }
        }

        public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
        {
            private readonly UniTask<T> task;
            public bool IsCompleted
            {
                [MethodImpl(256)]
                [DebuggerHidden]
                get
                {
                    return default(bool);
                }
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public Awaiter(in UniTask<T> task)
            {
                this = default;
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public T GetResult()
            {
                return default(T);
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void OnCompleted(Action continuation)
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void UnsafeOnCompleted(Action continuation)
            {
            }

            [MethodImpl(256)]
            [DebuggerHidden]
            public void SourceOnCompleted(Action<object> continuation, object state)
            {
            }
        }

        private readonly IUniTaskSource<T> source;
        private readonly T result;
        private readonly short token;
        public UniTaskStatus Status
        {
            [MethodImpl(256)]
            [DebuggerHidden]
            get
            {
                return default(UniTaskStatus);
            }
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public UniTask(T result)
        {
            this = default;
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public UniTask(IUniTaskSource<T> source, short token)
        {
            this = default;
        }

        [MethodImpl(256)]
        [DebuggerHidden]
        public Awaiter GetAwaiter()
        {
            return default(Awaiter);
        }

        public UniTask AsUniTask()
        {
            return default(UniTask);
        }

        public static implicit operator UniTask(UniTask<T> self)
        {
            return default(UniTask);
        }

        public UniTask<(bool, T)> SuppressCancellationThrow()
        {
            return default(UniTask<(bool, T)>);
        }

        public override string ToString()
        {
            return null;
        }
    }
}
