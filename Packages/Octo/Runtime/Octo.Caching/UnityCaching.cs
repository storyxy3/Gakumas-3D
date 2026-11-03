namespace Octo.Caching
{
    using global::Octo;
    using global::Octo.Data;
    using global::UnityEngine;

    internal sealed class UnityCaching : ICachingInternal, ICaching
    {
        private static Cache UnityCache;
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

        public bool CleanCache()
        {
            return default(bool);
        }

        public string GetResourceStoragePath(string name)
        {
            return null;
        }

        public bool UnlockAssetBundle(Item name)
        {
            return default(bool);
        }

        public bool InterceptDownload(string bucket, string localPath, Item item)
        {
            return default(bool);
        }

        public void StartAutoDelete()
        {
        }

        public UnityCaching()
        {
        }
    }
}
