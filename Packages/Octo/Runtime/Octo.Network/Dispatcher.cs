namespace Octo.Network
{
    using global::System;
    using global::System.Net;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Network;
    using global::UnityEngine.Networking;

    internal static class Dispatcher
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<DownloadHandlerBuffer> _003C_003E9__3_0;
            public _003C_003Ec()
            {
            }

            internal DownloadHandlerBuffer _003CDownloadHanderBufferFactory_003Eb__3_0()
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass1_0<T>
            where T : DownloadHandler
        {
            public byte[] requestData;
            public _003C_003Ec__DisplayClass1_0()
            {
            }

            internal UploadHandler _003CCreateRequest_003Eb__0()
            {
                return null;
            }
        }

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
