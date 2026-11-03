namespace Octo
{
    using global::Octo;
    using global::Octo.Data;

    internal interface ICachingInternal : ICaching
    {
        bool IsLatestAssetBundleCached(Item data, bool canAutoDelete = false);
        bool IsLatestResourceCached(Item data, bool canAutoDelete = false);
        bool DeleteResourceCached(string name);
        bool UnlockAssetBundle(Item data);
        bool InterceptDownload(string bucket, string localPath, Item item);
    }
}
