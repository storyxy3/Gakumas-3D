namespace Qua.UI
{
    using global::Qua.UI;

    public interface IQuaScreenPresenter
    {
        void RecursiveBack();
        ScreenPresenterBase GetBehindScreen();
    }
}
