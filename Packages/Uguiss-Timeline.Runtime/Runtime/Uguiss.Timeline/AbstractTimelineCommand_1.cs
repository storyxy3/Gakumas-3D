namespace Uguiss.Timeline
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Uguiss;
    using global::Uguiss.Timeline;

    public abstract class AbstractTimelineCommand<T> : AbstractCommand<T> where T : TimelineEngine
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CExecuteAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AbstractTimelineCommand<T> _003C_003E4__this;
            public CancellationToken cancellationToken;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(AbstractTimelineCommand<>._003CExecuteAsync_003Ed__0))]
        public override UniTask ExecuteAsync(CancellationToken cancellationToken)
        {
            return default(UniTask);
        }

        protected virtual void OnTimelinePlay()
        {
        }

        protected AbstractTimelineCommand()
        {
        }
    }
}
