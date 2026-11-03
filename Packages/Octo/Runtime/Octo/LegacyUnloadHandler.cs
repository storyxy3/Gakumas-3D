namespace Octo
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    [Obsolete("互換性を保つ目的以外では非推奨")]
    public class LegacyUnloadHandler : UnloadHandlerBase
    {
        [CompilerGenerated]
        private sealed class _003CFrameLoop_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public LegacyUnloadHandler _003C_003E4__this;
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

        protected readonly bool _isUnloadAll;
        public LegacyUnloadHandler(bool isUnloadAll)
        {
        }

        [IteratorStateMachine(typeof(_003CFrameLoop_003Ed__2))]
        public override IEnumerator FrameLoop()
        {
            return null;
        }
    }
}
