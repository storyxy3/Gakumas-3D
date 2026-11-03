namespace Octo
{
    using global::Octo;

    public interface LoadError : DownloadError, DatabaseError
    {
    }
}
