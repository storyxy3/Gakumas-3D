namespace Qua.UI
{
    using global::Qua.UI;

    public class DialogPresenterBase<TResult> : DialogPresenterBase
    {
        protected TResult _result;
        public TResult Result
        {
            get
            {
                return default(TResult);
            }
        }

        public DialogPresenterBase()
        {
        }
    }
}
