namespace Octo.Caching
{
    using global::System.Collections.Generic;
    using global::Octo.Caching;
    using global::Octo.Data;
    using global::Octo.Util;

    internal class OctoAppCaching
    {
        protected struct EmbeddedInfo
        {
            public MD5Value md5;
        }

        protected static readonly string Tag;
        protected static readonly string OctoDir;
        protected static readonly string ListFileName;
        protected readonly Dictionary<string, EmbeddedInfo> _embeddedDictionary;
        private readonly string _rootDir;
        public OctoAppCaching()
        {
        }

        protected virtual void PreConstruct(string listFilePath)
        {
        }

        public static bool HasInAppCache()
        {
            return default(bool);
        }

        public bool IsInApp(string bucket, MD5Value md5)
        {
            return default(bool);
        }

        public virtual bool IsCacheToOctoDefault()
        {
            return default(bool);
        }

        public virtual string GetFilePath(string bucket, Item item)
        {
            return null;
        }

        public virtual bool InterceptDownload(string bucket, string localPath, Item item)
        {
            return default(bool);
        }
    }
}
