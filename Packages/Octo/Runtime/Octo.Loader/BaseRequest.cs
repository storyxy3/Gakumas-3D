namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Loader;

    internal abstract class BaseRequest : IRequest
    {
        [CompilerGenerated]
        private sealed class _003CFinish_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
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
            public _003CFinish_003Ed__10(int _003C_003E1__state)
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

        [CompilerGenerated]
        private sealed class _003CPrepare_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
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
            public _003CPrepare_003Ed__8(int _003C_003E1__state)
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

        [CompilerGenerated]
        private sealed class _003CTimeoutWatcher_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
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
            public _003CTimeoutWatcher_003Ed__11(int _003C_003E1__state)
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

        public abstract string Name { get; }

        public virtual bool CanExecute
        {
            get
            {
                return default(bool);
            }
        }

        public virtual bool ShouldRetry
        {
            get
            {
                return default(bool);
            }
        }

        public virtual Error PanicError
        {
            get
            {
                return null;
            }
        }

        [IteratorStateMachine(typeof(_003CPrepare_003Ed__8))]
        public virtual IEnumerator Prepare()
        {
            return null;
        }

        public abstract IEnumerator Execute();
        [IteratorStateMachine(typeof(_003CFinish_003Ed__10))]
        public virtual IEnumerator Finish()
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003CTimeoutWatcher_003Ed__11))]
        public virtual IEnumerator TimeoutWatcher()
        {
            return null;
        }

        public virtual void Abort(Error err)
        {
        }

        public virtual void Panic(Error err)
        {
        }

        protected BaseRequest()
        {
        }
    }
}
