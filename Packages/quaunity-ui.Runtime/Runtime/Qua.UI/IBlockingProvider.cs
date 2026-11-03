namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public interface IBlockingProvider
    {
        IBlockingPresenter CreateBlocking<TBlockingType>(TBlockingType type, Transform parent, int depth);
    }
}
