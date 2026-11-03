namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;

    public class OpenDialogRequest<TDialogId> : IDialogRequest
    {
        [CompilerGenerated]
        private TDialogId _003CId_003Ek__BackingField;
        [CompilerGenerated]
        private object _003COptionalData_003Ek__BackingField;
        [CompilerGenerated]
        private DialogPresenterBase _003CDialog_003Ek__BackingField;
        [CompilerGenerated]
        private UniTaskCompletionSource _003CCompletionSource_003Ek__BackingField;
        [CompilerGenerated]
        private CancellationToken _003CCt_003Ek__BackingField;
        public Action<DialogPresenterBase> setupAction;
        public Func<DialogPresenterBase, UniTask> setupActionAsync;
        public DialogRequestType RequestType
        {
            get
            {
                return default(DialogRequestType);
            }
        }

        public TDialogId Id
        {
            [CompilerGenerated]
            get
            {
                return default(TDialogId);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public object OptionalData
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public DialogPresenterBase Dialog
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public UniTaskCompletionSource CompletionSource
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public CancellationToken Ct
        {
            [CompilerGenerated]
            get
            {
                return default(CancellationToken);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public OpenDialogRequest()
        {
        }
    }
}
