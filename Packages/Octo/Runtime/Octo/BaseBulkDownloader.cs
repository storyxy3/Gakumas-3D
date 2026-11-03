namespace Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Data;

    internal abstract class BaseBulkDownloader : IBulkDownloader
    {
        protected static readonly string Tag;
        protected readonly DataManager _db;
        protected readonly ICachingInternal _caching;
        public int fixedCount;
        public long fixedTotalBytes;
        protected readonly HashSet<Item> _itemSet;
        protected HashSet<Item> _errorItemSet;
        protected readonly ILoader _loader;
        protected long _downloadedBytes;
        protected Dictionary<string, long> _downloadingItems;
        [CompilerGenerated]
        private int _003CTaskCompletedCount_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CDownloadedCount_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CCanAutoDelete_003Ek__BackingField;
        [CompilerGenerated]
        private DownloadError _003CLastError_003Ek__BackingField;
        [CompilerGenerated]
        private Action m_OnCompleteAllDownloadTask;
        [CompilerGenerated]
        private Action<string, DownloadError> m_OnCompleteDownloadTask;
        public int Count
        {
            get
            {
                return default(int);
            }
        }

        public int TaskCompletedCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public int DownloadedCount
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public long DownloadedBytes
        {
            get
            {
                return default(long);
            }
        }

        public float ProgressBytes
        {
            get
            {
                return default(float);
            }
        }

        public bool IsTaskCompleted
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsError
        {
            get
            {
                return default(bool);
            }
        }

        public bool CanAutoDelete
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public DownloadError LastError
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public event Action OnCompleteAllDownloadTask
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public event Action<string, DownloadError> OnCompleteDownloadTask
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public BaseBulkDownloader(ILoader loader, bool canAutoDelete)
        {
        }

        public void Add(IList<string> names, bool withDeps = true)
        {
        }

        protected void AddDependencies(Item item)
        {
        }

        public abstract bool Add(string name, bool withDeps = true);
        public void RemoveWhere(Predicate<string> match)
        {
        }

        public abstract void RemoveLatestCached();
        public long GetTotalBytes()
        {
            return default(long);
        }

        public void DownloadAll()
        {
        }

        private void PreDownload(Item item)
        {
        }
    }
}
