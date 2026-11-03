namespace Qua.Extensions
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Extensions;

    public static class UniTaskExtension
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CRunAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public UniTask task;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [CompilerGenerated]
        private static IUniTaskExceptionHandler _003CExceptionHandler_003Ek__BackingField;
        public static IUniTaskExceptionHandler ExceptionHandler
        {
            [CompilerGenerated]
            private get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public static void Run<T>(this UniTask<T> task)
        {
        }

        public static void Run(this UniTask task)
        {
        }

        [AsyncStateMachine(typeof(_003CRunAsync_003Ed__6))]
        private static UniTask RunAsync(UniTask task)
        {
            return default(UniTask);
        }
    }
}
