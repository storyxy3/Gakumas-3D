namespace Qua.UI
{
    using global::Qua.UI;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class UIPartsManager : Singleton<UIPartsManager>, IBlockingProvider
    {
        [SerializeField]
        private BlockingPresenterBase _blockingPrefab;
        public IBlockingPresenter CreateBlocking<TBlockingType>(TBlockingType type, Transform parent, int depth)
        {
            return null;
        }

        public IBlockingPresenter CreateBlocking(Transform parent, int depth)
        {
            return null;
        }

        public UIPartsManager()
        {
        }
    }
}
