namespace Octo
{
    using global::System;
    using global::System.Runtime.InteropServices;
    using global::Octo;

    public interface ILoader<T> : ILoader
    {
        void LoadFromCacheOrDownload(string name, Action<T, LoadError> onComplete, [Optional] OnDownloadProgress onProgress);
    }
}
