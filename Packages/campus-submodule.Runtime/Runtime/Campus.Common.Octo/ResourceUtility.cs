namespace Campus.Common.Octo
{
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Octo;

    public static class ResourceUtility
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass0_0
        {
            public UniTaskCompletionSource<string> utcs;
            public CancellationToken ct;
            public CancellationTokenRegistration onCancel;
            public string resourceName;
            public _003C_003Ec__DisplayClass0_0()
            {
            }

            internal void _003CDownloadResourceFileAsync_003Eb__0()
            {
            }

            internal void _003CDownloadResourceFileAsync_003Eb__1(DownloadError error)
            {
            }
        }

        public static UniTask<string> DownloadResourceFileAsync(string resourceName, OnDownloadProgress onDownloadProgress, CancellationToken ct)
        {
            return default(UniTask<string>);
        }
    }
}
