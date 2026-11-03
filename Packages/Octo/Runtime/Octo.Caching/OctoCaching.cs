namespace Octo.Caching
{
    using global::System;
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Data;

    internal sealed class OctoCaching : OctoBaseCaching, IOctoCaching, ICachingInternal, ICaching
    {
        public OctoCaching StorageCaching
        {
            get
            {
                return null;
            }
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public OctoCaching(IOctoSettings settings, bool isAutoDelete) : base(default, default)
        {
        }

        private T DoAssetBundleFunc<T>(string name, bool allowDeleted, T defaultValue, Func<Item, T> func)
        {
            return default(T);
        }

        private T DoResourceFunc<T>(string name, bool allowDeleted, T defaultValue, Func<Item, T> func)
        {
            return default(T);
        }

        public bool IsLatestAssetBundleCached(string name)
        {
            return default(bool);
        }

        public bool IsLatestAssetBundleCached(Item data, bool canAutoDelete = false)
        {
            return default(bool);
        }

        public bool IsLatestResourceCached(string name)
        {
            return default(bool);
        }

        public bool IsLatestResourceCached(Item data, bool canAutoDelete = false)
        {
            return default(bool);
        }

        public bool DeleteResourceCached(string name)
        {
            return default(bool);
        }

        public string GetResourceStoragePath(string name)
        {
            return null;
        }

        public bool UnlockAssetBundle(Item data)
        {
            return default(bool);
        }

        public void StartAutoDelete()
        {
        }

        internal static string GetAssetBundleBucket(Item data)
        {
            return null;
        }

        internal static string GetResourceBucket(Item data)
        {
            return null;
        }

        internal static string GetAssetBundleFileName(Item data)
        {
            return null;
        }

        internal static string GetExtensionIfNeed(Item data)
        {
            return null;
        }

        internal static string GetResourceFileName(Item data)
        {
            return null;
        }

        public bool IsCachedInApp(string bucket, Item item)
        {
            return default(bool);
        }

        public CacheState IsCached(string bucket, string fileName, Item item)
        {
            return default(CacheState);
        }

        public string GetFilePath(string bucket, string fileName, Item item)
        {
            return null;
        }

        public bool InterceptDownload(string bucket, string localPath, Item item)
        {
            return default(bool);
        }
    }
}
