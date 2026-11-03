namespace Qua.UI
{
    using global::Qua.UI;

    public interface IQuaParentPresenter
    {
        void RecursiveBack();
        ScreenPresenterBase GetBehindScreen();
    }
}
