namespace Octo.Caching
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Data;

    internal class OctoHybridCaching : IOctoCaching, ICachingInternal, ICaching
    {
        private static readonly string Tag;
        private IOctoCaching _caching;
        private OctoAppCaching _appCaching;
        private bool _isNotOctoDefaultCache;
        [CompilerGenerated]
        private OctoCaching _003CStorageCaching_003Ek__BackingField;
        public OctoCaching StorageCaching
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsReady
        {
            get
            {
                return default(bool);
            }
        }

        public int ExpirationDelay
        {
            set
            {
            }
        }

        public long MaximumAvailableDiskSpace
        {
            get
            {
                return default(long);
            }

            set
            {
            }
        }

        public long SpaceOccupied
        {
            get
            {
                return default(long);
            }
        }

        private OctoHybridCaching(OctoCaching octoCaching)
        {
        }

        private OctoHybridCaching()
        {
        }

        public static IOctoCaching WrapIfNeeded(IOctoCaching caching)
        {
            return null;
        }

        public bool IsLatestAssetBundleCached(string name)
        {
            return default(bool);
        }

        public bool IsLatestResourceCached(string name)
        {
            return default(bool);
        }

        public bool CleanCache()
        {
            return default(bool);
        }

        public string GetResourceStoragePath(string name)
        {
            return null;
        }

        public void StartAutoDelete()
        {
        }

        public bool IsLatestAssetBundleCached(Item data, bool canAutoDelete = false)
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

        public bool UnlockAssetBundle(Item data)
        {
            return default(bool);
        }

        private bool IsAssetBundleExists(Item item)
        {
            return default(bool);
        }

        private bool IsResourceExists(Item item)
        {
            return default(bool);
        }

        private bool IsInApp(string bucket, Item item)
        {
            return default(bool);
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
