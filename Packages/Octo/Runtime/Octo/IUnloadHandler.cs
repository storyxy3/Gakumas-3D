namespace Octo
{
    using global::System.Collections;
    using global::Octo;

    public interface IUnloadHandler
    {
        void Init(IAssetBundleManager assetBundleManager);
        IEnumerator FrameLoop();
    }
}
