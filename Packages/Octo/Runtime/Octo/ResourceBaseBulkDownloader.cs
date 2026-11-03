namespace Octo
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Data;

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

        [CompilerGenerated]
        private bool _003CRemoveLatestCached_003Eb__3_0(Item item)
        {
            return default(bool);
        }
    }
}
