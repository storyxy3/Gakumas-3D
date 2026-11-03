namespace Octo.Network
{
    using global::Octo.Loader;

    internal interface IDownloadRequest : IRequest
    {
        void SetName(string name);
    }
}
