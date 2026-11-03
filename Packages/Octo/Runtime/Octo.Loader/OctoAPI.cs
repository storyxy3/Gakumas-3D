namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Net;
    using global::System.Runtime.CompilerServices;
    using global::System.Text;
    using global::Octo;
    using global::Octo.Data;
    using global::Octo.Loader;
    using global::Octo.Network;
    using global::UnityEngine;
    using global::UnityEngine.Networking;

    internal sealed class OctoAPI
    {
        [CompilerGenerated]
        private sealed class _003CDoSendErrorReport_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public OctoAPI _003C_003E4__this;
            public string message;
            public ErrorLevel level;
            public string tag;
            public long time;
            private UnityWebRequest _003Crequest_003E5__2;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CDoSendErrorReport_003Ed__30(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            private void _003C_003Em__Finally1()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private static readonly string Tag;
        private static readonly string ApiList;
        private static readonly string AesApiListFormat;
        private static readonly string ApiRevision;
        private static readonly string ApiErrorReport;
        internal static readonly string HeaderOctoKey;
        private static readonly int UrlCapacity;
        private readonly StringBuilder _urlBuilder;
        private readonly int _urlBaseLength;
        private readonly int _version;
        private readonly WebHeaderCollection _headers;
        private readonly string _errorReportUrl;
        private readonly string _aesListUrl;
        private readonly AESCrypt _crypt;
        private ErrorReport errorReport;
        public OctoAPI(IOctoSettings settings)
        {
        }

        public void GetDatabaseDiff(int revision, Action<byte[], Error> onComplete)
        {
        }

        private void GetList(int revision, Action<byte[], Error> onComplete)
        {
        }

        private bool GetListAes(int revision, Action<byte[], Error> onComplete)
        {
            return default(bool);
        }

        public byte[] DecryptAes(byte[] bytes)
        {
            return null;
        }

        public void GetLatestRevision(Action<int, Error> onComplete)
        {
        }

        public void DownloadAndLoadAssetBundle(Item item, Action<AssetBundle, Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        private void DownloadObject(Item item, string url, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        private void DownloadObject(Item item, string url, Action<byte[], Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        public void DownloadAssetBundle(Item item, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        public void DownloadResource(Item item, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        public void DownloadAssetBundleToMemory(Item item, Action<byte[], Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        public void SendErrorReport(ErrorLevel level, string tag, string message)
        {
        }

        [IteratorStateMachine(typeof(_003CDoSendErrorReport_003Ed__30))]
        private IEnumerator DoSendErrorReport(ErrorLevel level, string tag, string message, long time)
        {
            return null;
        }

        private string CreateUrl(string endpoint, params string[] args)
        {
            return null;
        }

        private UnityWebRequest CreateRequest(string url, string method = "GET")
        {
            return null;
        }

        private static IDownloadRequest ExecuteRequest(string url, WebHeaderCollection header, byte[] requestData, Action<byte[], Error> onComplete)
        {
            return null;
        }

        private static Error CreateEmptyDataError()
        {
            return null;
        }
    }
}
