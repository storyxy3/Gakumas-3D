namespace Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    public class MixBulkDownloader : IBulkDownloader
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Action _003C_003E9__2_0;
            public static Action<string, DownloadError> _003C_003E9__2_1;
            public _003C_003Ec()
            {
            }

            internal void _003C_002Ector_003Eb__2_0()
            {
            }

            internal void _003C_002Ector_003Eb__2_1(string _003Cp0_003E, DownloadError _003Cp1_003E)
            {
            }
        }

        private readonly AssetBundleBaseBulkDownloader _assetBundleBulkDownloader;
        private readonly ResourceBaseBulkDownloader _resourceBulkDownloader;
        [CompilerGenerated]
        private Action m_OnCompleteAllDownloadTask;
        [CompilerGenerated]
        private Action<string, DownloadError> m_OnCompleteDownloadTask;
        public IBulkDownloader AssetBundle
        {
            get
            {
                return null;
            }
        }

        public IBulkDownloader Resource
        {
            get
            {
                return null;
            }
        }

        public int Count
        {
            get
            {
                return default(int);
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

        public DownloadError LastError
        {
            get
            {
                return null;
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

        internal MixBulkDownloader(bool canAutoDelete)
        {
        }

        public void Add(IList<string> names, bool withDeps = true)
        {
        }

        public bool Add(string name, bool withDeps = true)
        {
            return default(bool);
        }

        public void RemoveWhere(Predicate<string> match)
        {
        }

        public void RemoveLatestCached()
        {
        }

        public long GetTotalBytes()
        {
            return default(long);
        }

        public void DownloadAll()
        {
        }

        private void OnCompleteAllDownloadTaskHandler()
        {
        }

        private void OnCompleteDownloadTaskHandler(string name, DownloadError error)
        {
        }
    }
}
