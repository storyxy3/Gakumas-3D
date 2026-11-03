namespace Octo
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::UnityEngine;

    public interface IAssetBundleLoader : ILoader<AssetBundle>, ILoader
    {
        void DownloadToMemory(string assetBundleName, Action<byte[], LoadError> onComplete, [Optional] OnDownloadProgress onProgress);
    }
}
