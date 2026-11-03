namespace Octo
{
    using global::System.Collections.Generic;

    public interface IAssetBundleManager
    {
        bool HaveUnloadableAssetBundles();
        IEnumerable<string> GetUnloadableAssetBundles();
        void UnloadAssetBundle(string assetBundleName, bool isUnloadAllLoadedAsset);
    }
}
