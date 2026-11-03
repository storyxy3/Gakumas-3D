namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Loader;
    using global::UnityEngine;

    internal abstract class BaseExecutor : MonoBehaviour, IExecutor
    {
        [CompilerGenerated]
        private sealed class _003CExecuteQueue_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public BaseExecutor _003C_003E4__this;
            public IRequest request;
            private IEnumerator _003CrequestWithTimeout_003E5__2;
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
            public _003CExecuteQueue_003Ed__26(int _003C_003E1__state)
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
        private sealed class _003CRequestWithTimeout_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public IRequest request;
            public BaseExecutor _003C_003E4__this;
            private IEnumerator _003Cmain_003E5__2;
            private Coroutine _003Cwatcher_003E5__3;
            private IEnumerator _003Cfinisher_003E5__4;
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
            public _003CRequestWithTimeout_003Ed__29(int _003C_003E1__state)
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

        private const int DefaultListCapacity = 200;
        protected List<IRequest> _executingTasks;
        protected List<IRequest> _waitingTasks;
        private int _maxParallel;
        [CompilerGenerated]
        private int _003CQueuedCount_003Ek__BackingField;
        protected abstract string Tag { get; }
        protected abstract int DefaultParallel { get; }

        public virtual int MaxParallel
        {
            get
            {
                return default(int);
            }

            set
            {
            }
        }

        public int ExecutingCount
        {
            get
            {
                return default(int);
            }
        }

        public int QueuedCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        private bool CanExecute
        {
            get
            {
                return default(bool);
            }
        }

        public void Request(IRequest request)
        {
        }

        public void RequestTopPriority(IRequest request)
        {
        }

        private bool _Request(IRequest request)
        {
            return default(bool);
        }

        public bool SetTopPriority(IRequest request, bool immediateExecute = false)
        {
            return default(bool);
        }

        public bool SetTopPriority(string name, bool immediateExecute = false)
        {
            return default(bool);
        }

        private bool _SetTopPriority(int index, bool immediateExecute = false)
        {
            return default(bool);
        }

        public void Execute(IRequest request)
        {
        }

        [IteratorStateMachine(typeof(_003CExecuteQueue_003Ed__26))]
        private IEnumerator ExecuteQueue(IRequest request)
        {
            return null;
        }

        protected void PandemicPanic(Error err)
        {
        }

        public abstract void AbortAll();
        [IteratorStateMachine(typeof(_003CRequestWithTimeout_003Ed__29))]
        private IEnumerator RequestWithTimeout(IRequest request)
        {
            return null;
        }

        private void LateUpdate()
        {
        }

        protected BaseExecutor()
        {
        }
    }
}
