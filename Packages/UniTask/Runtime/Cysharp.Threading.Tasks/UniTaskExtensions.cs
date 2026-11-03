namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.ExceptionServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::System.Threading.Tasks.Sources;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;

    public static class UniTaskExtensions
    {
        private sealed class AttachExternalCancellationSource : IUniTaskSource, IValueTaskSource
        {
            [StructLayout((LayoutKind)3)]
            [CompilerGenerated]
            private struct _003CRunTask_003Ed__5 : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
                public UniTask task;
                public AttachExternalCancellationSource _003C_003E4__this;
                private UniTask.Awaiter _003C_003Eu__1;
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
                {
                }

                [DebuggerHidden]
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
                {
                }
            }

            private static readonly Action<object> cancellationCallbackDelegate;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration tokenRegistration;
            private UniTaskCompletionSourceCore<AsyncUnit> core;
            public AttachExternalCancellationSource(UniTask task, CancellationToken cancellationToken)
            {
            }

            [AsyncStateMachine(typeof(_003CRunTask_003Ed__5))]
            private UniTaskVoid RunTask(UniTask task)
            {
                return default(UniTaskVoid);
            }

            private static void CancellationCallback(object state)
            {
            }

            public void GetResult(short token)
            {
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }
        }

        private sealed class AttachExternalCancellationSource<T> : IUniTaskSource<T>, IUniTaskSource, IValueTaskSource, IValueTaskSource<T>
        {
            [StructLayout((LayoutKind)3)]
            [CompilerGenerated]
            private struct _003CRunTask_003Ed__5 : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
                public UniTask<T> task;
                public AttachExternalCancellationSource<T> _003C_003E4__this;
                private UniTask<T>.Awaiter _003C_003Eu__1;
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
                {
                }

                [DebuggerHidden]
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
                {
                }
            }

            private static readonly Action<object> cancellationCallbackDelegate;
            private CancellationToken cancellationToken;
            private CancellationTokenRegistration tokenRegistration;
            private UniTaskCompletionSourceCore<T> core;
            public AttachExternalCancellationSource(UniTask<T> task, CancellationToken cancellationToken)
            {
            }

            [AsyncStateMachine(typeof(AttachExternalCancellationSource<>._003CRunTask_003Ed__5))]
            private UniTaskVoid RunTask(UniTask<T> task)
            {
                return default(UniTaskVoid);
            }

            private static void CancellationCallback(object state)
            {
            }

            void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token)
            {
            }

            public T GetResult(short token)
            {
                return default(T);
            }

            public UniTaskStatus GetStatus(short token)
            {
                return default(UniTaskStatus);
            }

            public void OnCompleted(Action<object> continuation, object state, short token)
            {
            }

            public UniTaskStatus UnsafeGetStatus()
            {
                return default(UniTaskStatus);
            }
        }

        private sealed class ToCoroutineEnumerator : IEnumerator
        {
            [StructLayout((LayoutKind)3)]
            [CompilerGenerated]
            private struct _003CRunTask_003Ed__6 : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
                public UniTask task;
                public ToCoroutineEnumerator _003C_003E4__this;
                private UniTask.Awaiter _003C_003Eu__1;
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
                {
                }

                [DebuggerHidden]
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
                {
                }
            }

            private bool completed;
            private UniTask task;
            private Action<Exception> exceptionHandler;
            private bool isStarted;
            private ExceptionDispatchInfo exception;
            public object Current
            {
                get
                {
                    return null;
                }
            }

            public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler)
            {
            }

            [AsyncStateMachine(typeof(_003CRunTask_003Ed__6))]
            private UniTaskVoid RunTask(UniTask task)
            {
                return default(UniTaskVoid);
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Action<Task, object> _003C_003E9__33_0;
            public static Action<object> _003C_003E9__48_0;
            public _003C_003Ec()
            {
            }

            internal void _003CAsUniTask_003Eb__33_0(Task x, object state)
            {
            }

            internal void _003CForget_003Eb__48_0(object state)
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__32<T>
        {
            public static readonly _003C_003Ec__32<T> _003C_003E9;
            public static Action<Task<T>, object> _003C_003E9__32_0;
            public _003C_003Ec__32()
            {
            }

            internal void _003CAsUniTask_003Eb__32_0(Task<T> x, object state)
            {
            }
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec__51<T>
        {
            public static readonly _003C_003Ec__51<T> _003C_003E9;
            public static Action<object> _003C_003E9__51_0;
            public _003C_003Ec__51()
            {
            }

            internal void _003CForget_003Eb__51_0(object state)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CContinueWith_003Ed__54<T> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Action<T> continuationFunction;
            public UniTask<T> task;
            private Action<T> _003C_003E7__wrap1;
            private UniTask<T>.Awaiter _003C_003Eu__1;
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
        private struct _003CContinueWith_003Ed__56<T, TR> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TR> _003C_003Et__builder;
            public Func<T, TR> continuationFunction;
            public UniTask<T> task;
            private Func<T, TR> _003C_003E7__wrap1;
            private UniTask<T>.Awaiter _003C_003Eu__1;
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
        private struct _003CContinueWith_003Ed__58 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public UniTask task;
            public Action continuationFunction;
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
        private struct _003CContinueWith_003Ed__59 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public UniTask task;
            public Func<UniTask> continuationFunction;
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
        private struct _003CContinueWith_003Ed__60<T> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public UniTask task;
            public Func<T> continuationFunction;
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
        private struct _003CForgetCoreWithCatch_003Ed__50 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
            public UniTask task;
            public bool handleExceptionOnMainThread;
            public Action<Exception> exceptionHandler;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private UniTask.Awaiter _003C_003Eu__1;
            private Exception _003Cex_003E5__4;
            private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks)
        {
            return default(UniTask.Awaiter);
        }

        public static UniTask<T[]>.Awaiter GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks)
        {
            return default(UniTask<T[]>.Awaiter);
        }

        public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true)
        {
            return default(UniTask<T>);
        }

        public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true)
        {
            return default(UniTask);
        }

        public static UniTask AttachExternalCancellation(this UniTask task, CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        public static UniTask<T> AttachExternalCancellation<T>(this UniTask<T> task, CancellationToken cancellationToken)
        {
            return default(UniTask<T>);
        }

        public static IEnumerator ToCoroutine(this UniTask task, [Optional] Action<Exception> exceptionHandler)
        {
            return null;
        }

        public static void Forget(this UniTask task)
        {
        }

        public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true)
        {
        }

        [AsyncStateMachine(typeof(_003CForgetCoreWithCatch_003Ed__50))]
        private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread)
        {
            return default(UniTaskVoid);
        }

        public static void Forget<T>(this UniTask<T> task)
        {
        }

        [AsyncStateMachine(typeof(_003CContinueWith_003Ed__54<>))]
        public static UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CContinueWith_003Ed__56<, >))]
        public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, TR> continuationFunction)
        {
            return default(UniTask<TR>);
        }

        [AsyncStateMachine(typeof(_003CContinueWith_003Ed__58))]
        public static UniTask ContinueWith(this UniTask task, Action continuationFunction)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CContinueWith_003Ed__59))]
        public static UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CContinueWith_003Ed__60<>))]
        public static UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction)
        {
            return default(UniTask<T>);
        }
    }
}
