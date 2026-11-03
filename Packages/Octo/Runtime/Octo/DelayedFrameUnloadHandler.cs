namespace Octo
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    public class DelayedFrameUnloadHandler : SimpleUnloadHandler
    {
        [CompilerGenerated]
        private sealed class _003CFrameLoop_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public DelayedFrameUnloadHandler _003C_003E4__this;
            private int _003Ci_003E5__2;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CFrameLoop_003Ed__2(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        protected int _delayedFrame;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public DelayedFrameUnloadHandler(bool isUnloadAll, int delayedFrame) : base(default)
        {
        }

        [IteratorStateMachine(typeof(_003CFrameLoop_003Ed__2))]
        public override IEnumerator FrameLoop()
        {
            return null;
        }
    }
}
