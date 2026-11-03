namespace Octo.Caching
{
    using global::Octo.Caching;
    using global::Octo.Data;

    internal class OctoAndroidAppCaching : OctoAppCaching
    {
        private static readonly string AppOctoAssetsPath;
        private static bool _isPack;
        public static OctoAndroidAppCaching Create()
        {
            return null;
        }

        public static bool ExistsListAsset()
        {
            return default(bool);
        }

        protected override void PreConstruct(string listFilePath)
        {
        }

        public override bool InterceptDownload(string bucket, string localPath, Item item)
        {
            return default(bool);
        }

        public override bool IsCacheToOctoDefault()
        {
            return default(bool);
        }

        public override string GetFilePath(string bucket, Item item)
        {
            return null;
        }

        private string GetAppFilePath(string bucket, Item item)
        {
            return null;
        }

        protected virtual bool MoveAsset(string src, string dest)
        {
            return default(bool);
        }

        public OctoAndroidAppCaching()
        {
        }
    }
}
