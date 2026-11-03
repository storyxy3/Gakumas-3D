namespace Octo
{
    using global::Octo;

    internal class ResourceBaseBulkDownloader : BaseBulkDownloader
    {
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public ResourceBaseBulkDownloader(bool canAutoDelete) : base(default, default)
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
