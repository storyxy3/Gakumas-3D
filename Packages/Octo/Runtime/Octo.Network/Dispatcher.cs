namespace Octo.Network
{
    using global::System;
    using global::System.Net;
    using global::Octo;
    using global::Octo.Network;
    using global::UnityEngine.Networking;

    internal static class Dispatcher
    {
        public static IDownloadRequest CreateUnityRequest<T>(string url, WebHeaderCollection header, Func<T> downloadHandlerFactory, Func<UploadHandler> uploadHandlerFactory, Action<T, Error> onComplete, Action<ulong, ulong> onProgress)
            where T : DownloadHandler
        {
            return null;
        }

        public static IDownloadRequest CreateRequest<T>(string url, WebHeaderCollection header, Func<T> downloadHandlerFactory, byte[] requestData, Action<T, Error> onComplete, Action<ulong, ulong> onProgress)
            where T : DownloadHandler
        {
            return null;
        }

        public static IDownloadRequest CreateDownloadRequest(string url, string path, string md5, Action<IDownloadResult, Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public static Func<DownloadHandlerBuffer> DownloadHanderBufferFactory()
        {
            return null;
        }
    }
}
