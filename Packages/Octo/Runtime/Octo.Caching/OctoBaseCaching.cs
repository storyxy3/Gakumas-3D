namespace Octo.Caching
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.IO;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Network;

    internal class OctoBaseCaching
    {
        private static readonly string Tag;
        [CompilerGenerated]
        private Action OnWarmupCompleted;
        private TimeSpan _expirationDelay;
        private long _maximumAvailableDiskSpace;
        private long _spaceOccupied;
        protected Dictionary<string, Storage> _storageDictionary;
        private readonly IStorageList _sortStorageList;
        private string _saveDirectory;
        private string _downloadDirectory;
        private bool _isAutoDelete;
        private bool _isConstructing;
        private bool _needToRetrieve;
        private List<DirectoryInfo> _initialDirectories;
        private ManualResetEvent _initialDirectoriesGetCompletedEvent;
        private CacheDeleteExecutor _deleteExecutor;
        private ManualResetEvent _warmupThreadWaitEvent;
        private bool _isNeededToPauseWarmup;
        private CancellationTokenSource _warmupCancellationTokenSource;
        protected WarmupState _warmupState;
        private object _storageModifyMutex;
        private object _initialDirectoriesMutex;
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

        public long SpaceFree
        {
            get
            {
                return default(long);
            }
        }

        public long SpaceOccupied
        {
            get
            {
                return default(long);
            }
        }

        public OctoBaseCaching(IOctoSettings settings, bool isAutoDelete)
        {
        }

        public OctoBaseCaching(bool isAutoDelete, string saveDirectory, string downloadDirectory, string deleteDirectory)
        {
        }

        private void PrepareDirectory(string deleteDirectory)
        {
        }

        private void WarmupThread(object state)
        {
        }

        private void SleepWarmupThreadIfNeeded()
        {
        }

        public void ResumeWarmupThread()
        {
        }

        private void TerminateWarmupTread()
        {
        }

        private Storage RetrieveDirectory(DirectoryInfo di)
        {
            return null;
        }

        private Storage RetrieveDirectory(string bucket)
        {
            return null;
        }

        private Storage RetrieveDirectory(DirectoryInfo di, string bucket)
        {
            return null;
        }

        private void SafeAddStorage(string bucket, Storage storage)
        {
        }

        internal bool DeleteCache(string bucket)
        {
            return default(bool);
        }

        private bool DeleteCache(Storage storage)
        {
            return default(bool);
        }

        internal CacheState IsCached(string bucket, string fileName, long size = 0L, bool canAutoDelete = false)
        {
            return default(CacheState);
        }

        public bool CleanCache()
        {
            return default(bool);
        }

        private bool CleanCacheInternal()
        {
            return default(bool);
        }

        internal bool BookOccupied(long size)
        {
            return default(bool);
        }

        internal Error DefiniteOccupied(string bucket, string fileName, int size)
        {
            return null;
        }

        internal Error DefiniteOccupiedByFilePath(string bucket, string srcPath, string filePath, int size)
        {
            return null;
        }

        internal void FreeOccupied(long size)
        {
        }

        internal bool UpdateReferenceDate(string bucket)
        {
            return default(bool);
        }

        public int DeleteExpiredCaches()
        {
            return default(int);
        }

        protected void AutoDelete(long additionalSpace = 0L)
        {
        }

        private void SendErrorReport(ErrorLevel level, string message)
        {
        }

        private void UpdateStorageData(Storage storage)
        {
        }

        internal string GetDownloadDestination(string bucket)
        {
            return null;
        }

        internal string GetDownloadDestinationFromFileName(string fileName)
        {
            return null;
        }

        private string GetDirectoryPath(string bucket)
        {
            return null;
        }

        internal virtual string GetStorageFilePath(string bucket, string fileName)
        {
            return null;
        }

        internal virtual string StringToHex(string bucket)
        {
            return null;
        }

        internal virtual string HexToString(string hex)
        {
            return null;
        }

        internal void LockStorage(string storageFileName)
        {
        }

        internal bool UnlockStorage(string storageFileName)
        {
            return default(bool);
        }

        internal bool SetCanAutoDelete(string bucket)
        {
            return default(bool);
        }
    }
}
