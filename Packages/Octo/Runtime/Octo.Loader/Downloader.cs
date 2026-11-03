namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Net;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Loader;
    using global::Octo.Network;
    using global::UnityEngine.Networking;

    internal sealed class Downloader : BaseExecutor
    {
        [CompilerGenerated]
        private sealed class _003CRequestAfterCachingIsReady_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public Downloader _003C_003E4__this;
            public IRequest req;
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
            public _003CRequestAfterCachingIsReady_003Ed__9(int _003C_003E1__state)
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

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private static readonly string LocalTag;
        private static readonly int LocalDefaultParallel;
        private List<IEnumerator> coroutineList;
        protected override string Tag
        {
            get
            {
                return null;
            }
        }

        protected override int DefaultParallel
        {
            get
            {
                return default(int);
            }
        }

        public override void AbortAll()
        {
        }

        public void RequestAfterCachingIsReady<T>(string url, WebHeaderCollection header, Func<T> factory, Action<T, Error> onComplete, Action<ulong, ulong> onProgress)
            where T : DownloadHandler
        {
        }

        [IteratorStateMachine(typeof(_003CRequestAfterCachingIsReady_003Ed__9))]
        private IEnumerator RequestAfterCachingIsReady(IRequest req)
        {
            return null;
        }

        public IDownloadRequest Request(string url, WebHeaderCollection header, byte[] requestData, Action<byte[], Error> onComplete, Action<ulong, ulong> onProgress, bool immediate = false)
        {
            return null;
        }

        public IDownloadRequest Request(string url, WebHeaderCollection header, Action<byte[], Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public IDownloadRequest Request(string url, Action<byte[], Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public IDownloadRequest RequestAndSave(string url, WebHeaderCollection header, string path, string md5, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public IDownloadRequest RequestAndSave(string url, string path, string md5, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public IDownloadRequest RequestAndSave(string url, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
            return null;
        }

        public void AddCoroutine(IEnumerator coroutine)
        {
        }

        private void Update()
        {
        }

        public Downloader()
        {
        }
    }
}
