namespace Octo.Network
{
    using global::System;

    internal interface IDownloadResult : IDisposable
    {
        bool IsError { get; }

        string ErrorMessage { get; }

        bool IsHashDiffered { get; }

        string RealHash { get; }
    }
}
