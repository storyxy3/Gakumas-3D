namespace Octo
{
    public interface ICaching
    {
        bool IsReady { get; }

        int ExpirationDelay { set; }

        long MaximumAvailableDiskSpace { get; set; }

        long SpaceOccupied { get; }

        bool IsLatestAssetBundleCached(string name);
        bool IsLatestResourceCached(string name);
        bool CleanCache();
        string GetResourceStoragePath(string name);
        void StartAutoDelete();
    }
}
