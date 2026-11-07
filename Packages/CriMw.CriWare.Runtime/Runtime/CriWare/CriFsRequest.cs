namespace CriWare
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine;

    public class CriFsRequest : CriDisposable
    {
        public delegate void DoneDelegate(CriFsRequest request);
        [CompilerGenerated]
        private sealed class _003CCheckDone_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public CriFsRequest _003C_003E4__this;
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
            public _003CCheckDone_003Ed__23(int _003C_003E1__state)
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
        private DoneDelegate _003CdoneDelegate_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CisDone_003Ek__BackingField;
        [CompilerGenerated]
        private string _003Cerror_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CisDisposed_003Ek__BackingField;
        public DoneDelegate doneDelegate
        {
            [CompilerGenerated]
            get
            {
                return _003CdoneDelegate_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CdoneDelegate_003Ek__BackingField = value;
            }
        }

        public bool isDone
        {
            [CompilerGenerated]
            get
            {
                return _003CisDone_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisDone_003Ek__BackingField = value;
            }
        }

        public string error
        {
            [CompilerGenerated]
            get
            {
                return _003Cerror_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003Cerror_003Ek__BackingField = value;
            }
        }

        public bool isDisposed
        {
            [CompilerGenerated]
            get
            {
                return _003CisDisposed_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CisDisposed_003Ek__BackingField = value;
            }
        }

        public override void Dispose()
        {
        }

        public virtual void Stop()
        {
        }

        public YieldInstruction WaitForDone(MonoBehaviour mb)
        {
            return null;
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public virtual void Update()
        {
        }

        protected void Done()
        {
        }

        [IteratorStateMachine(typeof(_003CCheckDone_003Ed__23))]
        private IEnumerator CheckDone()
        {
            return null;
        }

        ~CriFsRequest()
        {
        }

        public CriFsRequest()
        {
        }
    }
}
