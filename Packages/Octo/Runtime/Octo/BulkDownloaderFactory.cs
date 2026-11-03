namespace Octo
{
    using global::Octo;

    public static class BulkDownloaderFactory
    {
        public static IBulkDownloader CreateAssetBundle(bool canAutoDelete = false)
        {
            return null;
        }

        public static IBulkDownloader CreateResource(bool canAutoDelete = false)
        {
            return null;
        }

        public static MixBulkDownloader CreateMix(bool canAutoDelete = false)
        {
            return null;
        }
    }
}
