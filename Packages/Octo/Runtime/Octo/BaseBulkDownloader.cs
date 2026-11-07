namespace Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Data;

    internal abstract class BaseBulkDownloader : IBulkDownloader
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Action _003C_003E9__46_0;
            public static Action<string, DownloadError> _003C_003E9__46_1;
            public _003C_003Ec()
            {
            }

            internal void _003C_002Ector_003Eb__46_0()
            {
            }

            internal void _003C_002Ector_003Eb__46_1(string _003Cp0_003E, DownloadError _003Cp1_003E)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass52_0
        {
            public Predicate<string> match;
            public _003C_003Ec__DisplayClass52_0()
            {
            }

            internal bool _003CRemoveWhere_003Eb__0(Item item)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass54_0
        {
            public long size;
            public _003C_003Ec__DisplayClass54_0()
            {
            }

            internal void _003CGetTotalBytes_003Eb__0(Item item)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass57_0
        {
            public BaseBulkDownloader _003C_003E4__this;
            public Item item;
            public _003C_003Ec__DisplayClass57_0()
            {
            }

            internal void _003CPreDownload_003Eb__0(DownloadError error)
            {
            }

            internal void _003CPreDownload_003Eb__1(string name, ulong length, ulong contentLength)
            {
            }
        }

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
                return _003CTaskCompletedCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CTaskCompletedCount_003Ek__BackingField = value;
            }
        }

        public int DownloadedCount
        {
            [CompilerGenerated]
            get
            {
                return _003CDownloadedCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CDownloadedCount_003Ek__BackingField = value;
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
                return _003CCanAutoDelete_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CCanAutoDelete_003Ek__BackingField = value;
            }
        }

        public DownloadError LastError
        {
            [CompilerGenerated]
            get
            {
                return _003CLastError_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CLastError_003Ek__BackingField = value;
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
