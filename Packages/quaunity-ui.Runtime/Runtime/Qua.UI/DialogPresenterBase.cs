namespace Qua.UI
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public class DialogPresenterBase : MonoBehaviour
    {
        protected enum State
        {
            None,
            InitExecuting,
            OpenExecuting,
            CloseExecuting,
            FrontToBackExecuting,
            BackToFrontExecuting
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass48_0
        {
            public UniTaskCompletionSource utcs;
            public DialogPresenterBase _003C_003E4__this;
            public Action onExecute;
            public _003C_003Ec__DisplayClass48_0()
            {
            }

            internal void _003CWaitForCloseAsync_003Eb__0()
            {
            }

            internal void _003CWaitForCloseAsync_003Eb__1()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CBackToFrontAsync_003Ed__46 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003CCloseAsync_003Ed__42 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003CFrontToBackAsync_003Ed__44 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003CInitializeAsync_003Ed__37 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003COpenAsync_003Ed__39 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003CWaitForCloseAsync_003Ed__48 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase _003C_003E4__this;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;
            private CancellationTokenRegistration _003C_003E7__wrap1;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public Action OnWillOpen;
        public Action OnOpened;
        public Action OnWillClose;
        public Action OnClosed;
        [CompilerGenerated]
        private bool _003CIsInitialize_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsOpen_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsClose_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsFront_003Ek__BackingField;
        public ILogger logger;
        protected State _state;
        public bool IsInitialize
        {
            [CompilerGenerated]
            get
            {
                return _003CIsInitialize_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsInitialize_003Ek__BackingField = value;
            }
        }

        public bool IsOpen
        {
            [CompilerGenerated]
            get
            {
                return _003CIsOpen_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsOpen_003Ek__BackingField = value;
            }
        }

        public bool IsClose
        {
            [CompilerGenerated]
            get
            {
                return _003CIsClose_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsClose_003Ek__BackingField = value;
            }
        }

        public bool IsFront
        {
            [CompilerGenerated]
            get
            {
                return _003CIsFront_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsFront_003Ek__BackingField = value;
            }
        }

        public bool IsBack
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsNoneExecuting
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsInitExecuting
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsOpenExecuting
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsCloseExecuting
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsFrontToBackExecuting
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsBackToFrontExecuting
        {
            get
            {
                return default(bool);
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__37))]
        public UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnInitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COpenAsync_003Ed__39))]
        public UniTask OpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnOpenAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Close()
        {
        }

        [AsyncStateMachine(typeof(_003CCloseAsync_003Ed__42))]
        public UniTask CloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnCloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CFrontToBackAsync_003Ed__44))]
        public UniTask FrontToBackAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnFrontToBackAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CBackToFrontAsync_003Ed__46))]
        public UniTask BackToFrontAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask OnBackToFrontAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CWaitForCloseAsync_003Ed__48))]
        public UniTask WaitForCloseAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public DialogPresenterBase()
        {
        }
    }
}
