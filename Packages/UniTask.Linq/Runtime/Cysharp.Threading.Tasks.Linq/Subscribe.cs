namespace Cysharp.Threading.Tasks.Linq
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Cysharp.Threading.Tasks.Linq;

    internal static class Subscribe
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSubscribeAwaitCore_003Ed__6<TSource> : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;
            public IUniTaskAsyncEnumerable<TSource> source;
            public CancellationToken cancellationToken;
            public Func<TSource, UniTask> onNext;
            public Action onCompleted;
            public Action<Exception> onError;
            private IUniTaskAsyncEnumerator<TSource> _003Ce_003E5__2;
            private object _003C_003E7__wrap2;
            private int _003C_003E7__wrap3;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<bool>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public static readonly Action<Exception> NopError;
        public static readonly Action NopCompleted;
        [AsyncStateMachine(typeof(_003CSubscribeAwaitCore_003Ed__6<>))]
        public static UniTaskVoid SubscribeAwaitCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
        {
            return default(UniTaskVoid);
        }
    }
}
