namespace Qua.UI
{
    using global::Qua.UI;

    public class RemoveDialogRequest : IDialogRequest
    {
        public DialogPresenterBase removeDialog;
        public DialogRequestType RequestType
        {
            get
            {
                return default(DialogRequestType);
            }
        }

        public RemoveDialogRequest()
        {
        }
    }
}
