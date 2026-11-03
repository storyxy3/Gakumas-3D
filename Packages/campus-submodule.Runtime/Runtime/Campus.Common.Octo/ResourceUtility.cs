namespace Campus.Common.Octo
{
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Octo;

    public static class ResourceUtility
    {
        public static UniTask<string> DownloadResourceFileAsync(string resourceName, OnDownloadProgress onDownloadProgress, CancellationToken ct)
        {
            return default(UniTask<string>);
        }
    }
}
