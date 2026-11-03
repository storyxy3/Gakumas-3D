namespace Octo
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Octo;

    public interface ILoader
    {
        bool CanDownloadWithoutLoad { get; }

        void PreDownload(string name, Action<DownloadError> onComplete, [Optional] OnDownloadProgress onProgress, bool canAutoDelete = false);
    }
}
