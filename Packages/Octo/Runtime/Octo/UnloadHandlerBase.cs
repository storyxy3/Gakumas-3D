namespace Octo
{
    using global::System.Collections;
    using global::Octo;

    public abstract class UnloadHandlerBase : IUnloadHandler
    {
        protected IAssetBundleManager _assetBundleManager;
        public void Init(IAssetBundleManager assetBundleManager)
        {
        }

        public abstract IEnumerator FrameLoop();
        protected UnloadHandlerBase()
        {
        }
    }
}
