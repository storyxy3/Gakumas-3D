namespace Octo.Caching
{
    using global::System;
    using global::System.IO;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Octo.Caching;

    internal sealed class Storage
    {
        public enum State : byte
        {
            Ready,
            Retrieving,
            Locked,
            Deleting
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass25_0
        {
            public Storage _003C_003E4__this;
            public string metaPath;
            public _003C_003Ec__DisplayClass25_0()
            {
            }

            internal void _003CWriteMetaAsync_003Eb__0(object state)
            {
            }
        }

        private static readonly string Tag;
        public static readonly string MetaFileName;
        private bool isEmpty;
        public int size;
        public DateTime date;
        public State state;
        public ManualResetEvent RetrieveEndEvent;
        public bool canAutoDelete;
        [CompilerGenerated]
        private string _003CBucket_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CFileName_003Ek__BackingField;
        private int isWritingMetaRequested;
        public bool IsEmpty
        {
            get
            {
                return default(bool);
            }
        }

        public string Bucket
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

        public string FileName
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

        public Storage(string bucket)
        {
        }

        public Storage(string bucket, FileInfo fi, int size, bool forceUpdateDate, bool autoDeleteExpired)
        {
        }

        public void SetData(FileInfo fi, int size = 0, bool forceUpdateDate = false, bool autoDeleteExpired = false)
        {
        }

        private void UpdateMeta(string directoryName, bool forceUpdateDate, bool autoDeleteExpired)
        {
        }

        public void UpdateDate(string metaPath)
        {
        }

        private void WriteMetaAsync(string metaPath)
        {
        }

        private void WriteMeta(string metaPath)
        {
        }

        public bool IsExpired(TimeSpan delay)
        {
            return default(bool);
        }
    }
}
