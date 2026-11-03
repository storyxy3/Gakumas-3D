namespace Octo
{
    using global::Octo;

    public interface AssetLoaderError : LoadError, DownloadError, DatabaseError
    {
    }
}
