namespace Octo
{
    using global::Octo;

    internal class AssetBundleBaseBulkDownloader : BaseBulkDownloader
    {
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public AssetBundleBaseBulkDownloader(bool canAutoDelete) : base(default, default)
        {
        }

        public override bool Add(string name, bool withDeps)
        {
            return default(bool);
        }

        public override void RemoveLatestCached()
        {
        }
    }
}
