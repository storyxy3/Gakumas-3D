namespace Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Octo;

    public interface IBulkDownloader
    {
        int Count { get; }

        long DownloadedBytes { get; }

        float ProgressBytes { get; }

        bool IsTaskCompleted { get; }

        bool IsError { get; }

        DownloadError LastError { get; }

        event Action OnCompleteAllDownloadTask;
        event Action<string, DownloadError> OnCompleteDownloadTask;
        void Add(IList<string> names, bool withDeps = true);
        bool Add(string name, bool withDeps = true);
        void RemoveWhere(Predicate<string> match);
        void RemoveLatestCached();
        long GetTotalBytes();
        void DownloadAll();
    }
}
