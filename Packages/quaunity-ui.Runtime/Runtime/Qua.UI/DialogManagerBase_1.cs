namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;

    public abstract class DialogManagerBase<TDialogId> : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass14_0<TDialog>
            where TDialog : DialogPresenterBase
        {
            [StructLayout((LayoutKind)3)]
            private struct _003C_003COpenDialogAsync_003Eb__1_003Ed : IAsyncStateMachine
            {
                public int _003C_003E1__state;
                public AsyncUniTaskMethodBuilder _003C_003Et__builder;
                public _003C_003Ec__DisplayClass14_0<TDialog> _003C_003E4__this;
                public DialogPresenterBase dialog;
                private UniTask.Awaiter _003C_003Eu__1;
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
                {
                }

                [DebuggerHidden]
                void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
                {
                }
            }

            public Action<TDialog> setupAction;
            public Func<TDialog, UniTask> setupActionAsync;
            public OpenDialogRequest<TDialogId> openDialogReq;
            public _003C_003Ec__DisplayClass14_0()
            {
            }

            internal void _003COpenDialogAsync_003Eb__0(DialogPresenterBase presenter)
            {
            }

            [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass14_0<>._003C_003COpenDialogAsync_003Eb__1_003Ed))]
            internal UniTask _003COpenDialogAsync_003Eb__1(DialogPresenterBase dialog)
            {
                return default(UniTask);
            }

            internal void _003COpenDialogAsync_003Eb__2()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass17_0
        {
            public DialogPresenterBase dialog;
            public _003C_003Ec__DisplayClass17_0()
            {
            }

            internal bool _003CSafeCloseDialogAsync_003Eb__0()
            {
                return default(bool);
            }

            internal bool _003CSafeCloseDialogAsync_003Eb__1()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CCloseAllDialogAsync_003Ed__16 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
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
        private struct _003CExecuteRequestAsync_003Ed__23 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
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
        private struct _003CInitializeBlockingObjectAsync_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<GameObject>.Awaiter _003C_003Eu__1;
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
        private struct _003COpenDialogAsync_003Ed__14<TDialog> : IAsyncStateMachine where TDialog : DialogPresenterBase
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TDialog> _003C_003Et__builder;
            public Action<TDialog> setupAction;
            public Func<TDialog, UniTask> setupActionAsync;
            public TDialogId id;
            public object optionalData;
            public CancellationToken ct;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
            private _003C_003Ec__DisplayClass14_0<TDialog> _003C_003E8__1;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COpenDialogAsync_003Ed__15 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
            public CancellationToken ct;
            public OpenDialogRequest<TDialogId> openDialogReq;
            private DialogPresenterBase _003CfrontDialog_003E5__2;
            private DialogPresenterBase _003Cdialog_003E5__3;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<DialogPresenterBase>.Awaiter _003C_003Eu__2;
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
        private struct _003COpenNewDialogAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase newDialog;
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
        private struct _003CPrevDialogBackToFrontAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase prevDialog;
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
        private struct _003CRemoveDialogAsync_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public RemoveDialogRequest removeDialogRequest;
            public DialogManagerBase<TDialogId> _003C_003E4__this;
            public CancellationToken ct;
            private DialogPresenterBase _003CremoveDialog_003E5__2;
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
        private struct _003CSafeCloseDialogAsync_003Ed__17 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DialogPresenterBase dialog;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        protected bool _destroyClosedDialog;
        public ILogger logger;
        private bool _isInitialize;
        protected List<DialogPresenterBase> _dialogs;
        private Queue<IDialogRequest> _requestQueue;
        protected bool _isExecutingRequest;
        private GameObject _createdBlockingObj;
        public int OpenDialogCount
        {
            get
            {
                return default(int);
            }
        }

        protected virtual void Initialize()
        {
        }

        public UniTask<TDialog> OpenDialogAsync<TDialog>(TDialogId id, Action<TDialog> setupAction, CancellationToken ct)
            where TDialog : DialogPresenterBase
        {
            return default(UniTask<TDialog>);
        }

        public UniTask<TDialog> OpenDialogAsync<TDialog>(TDialogId id, Func<TDialog, UniTask> setupActionAsync, CancellationToken ct)
            where TDialog : DialogPresenterBase
        {
            return default(UniTask<TDialog>);
        }

        public UniTask<TDialog> OpenDialogAsync<TDialog>(TDialogId id, Action<TDialog> setupAction, object optionalData, CancellationToken ct)
            where TDialog : DialogPresenterBase
        {
            return default(UniTask<TDialog>);
        }

        public UniTask<TDialog> OpenDialogAsync<TDialog>(TDialogId id, Func<TDialog, UniTask> setupActionAsync, object optionalData, CancellationToken ct)
            where TDialog : DialogPresenterBase
        {
            return default(UniTask<TDialog>);
        }

        [AsyncStateMachine(typeof(_003COpenDialogAsync_003Ed__14<>))]
        public UniTask<TDialog> OpenDialogAsync<TDialog>(TDialogId id, Action<TDialog> setupAction, Func<TDialog, UniTask> setupActionAsync, object optionalData, CancellationToken ct)
            where TDialog : DialogPresenterBase
        {
            return default(UniTask<TDialog>);
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003COpenDialogAsync_003Ed__15))]
        protected virtual UniTask OpenDialogAsync(OpenDialogRequest<TDialogId> openDialogReq, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CCloseAllDialogAsync_003Ed__16))]
        public virtual UniTask CloseAllDialogAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CSafeCloseDialogAsync_003Ed__17))]
        protected UniTask SafeCloseDialogAsync(DialogPresenterBase dialog, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected DialogPresenterBase GetFrontDialog()
        {
            return null;
        }

        private void AddDialog(DialogPresenterBase dialog)
        {
        }

        private void RemoveDialog(DialogPresenterBase removeDialog)
        {
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CRemoveDialogAsync_003Ed__21))]
        protected virtual UniTask RemoveDialogAsync(RemoveDialogRequest removeDialogRequest, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void AddRequest(IDialogRequest request)
        {
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CExecuteRequestAsync_003Ed__23))]
        private UniTask ExecuteRequestAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CInitializeBlockingObjectAsync_003Ed__24))]
        private UniTask InitializeBlockingObjectAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected abstract UniTask<DialogPresenterBase> CreateDialogAsync(TDialogId id, CancellationToken ct);
        protected abstract UniTask<GameObject> CreateBlockingObjectAsync(CancellationToken ct);
        protected virtual Transform GetDialogParent()
        {
            return null;
        }

        protected virtual Transform GetBlockingObjectParent()
        {
            return null;
        }

        protected virtual void EnableBlockingObject(GameObject blocking, bool enable)
        {
        }

        protected virtual void MoveDispOrderToLast(GameObject target)
        {
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003COpenNewDialogAsync_003Ed__31))]
        protected virtual UniTask OpenNewDialogAsync(DialogPresenterBase newDialog, DialogPresenterBase currentDialog, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(DialogManagerBase<>._003CPrevDialogBackToFrontAsync_003Ed__32))]
        protected virtual UniTask PrevDialogBackToFrontAsync(DialogPresenterBase prevDialog, DialogPresenterBase currentDialog, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected DialogManagerBase()
        {
        }
    }
}
