namespace Octo.Loader
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Data;
    using global::Octo.Loader;

    internal abstract class OctoBaseLoader
    {
        private static readonly string Tag;
        protected IOctoCaching _octoCaching;
        protected OctoCaching _storageCaching;
        protected Dictionary<string, Common.CallbackEvents<DownloadError>> _callbackPool;
        public bool CanDownloadWithoutLoad
        {
            get
            {
                return default(bool);
            }
        }

        public OctoBaseLoader(IOctoCaching caching)
        {
        }

        protected abstract Item GetItemByName(string name);
        protected abstract void Download(Item item, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress);
        protected abstract string GetStorageBucket(Item data);
        protected abstract string GetStorageFileName(Item data);
        public void PreDownload(string name, Action<DownloadError> onComplete, [Optional] OnDownloadProgress onProgress, bool canAutoDelete = false)
        {
        }

        private void OnDownloadCompleted(Error err, string name, string bucket, string fileName, Item data, bool canAutoDelete, Common.CallbackEvents<DownloadError> events)
        {
        }
    }
}
