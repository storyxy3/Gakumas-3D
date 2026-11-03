namespace Octo
{
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Data;

    internal interface IOctoCaching : ICachingInternal, ICaching
    {
        OctoCaching StorageCaching { get; }

        bool IsCachedInApp(string bucket, Item item);
        CacheState IsCached(string bucket, string fileName, Item item);
        string GetFilePath(string bucket, string fileName, Item item);
    }
}
