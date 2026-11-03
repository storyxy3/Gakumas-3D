namespace Octo.Network
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Net;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Network;
    using global::UnityEngine.Networking;

    internal sealed class UnityDownloadRequest<T> : BaseDownloadRequest<T> where T : DownloadHandler
    {
        [CompilerGenerated]
        private sealed class _003CExecute_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public UnityDownloadRequest<T> _003C_003E4__this;
            private UnityWebRequest _003Creq_003E5__2;
            private T _003CdownloadHandler_003E5__3;
            private Octo.Network.DownloadHandlerFile _003CfileHandler_003E5__4;
            private DownloadHandlerAssetBundle _003CabHandler_003E5__5;
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
            public _003CExecute_003Ed__6(int _003C_003E1__state)
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

            private void _003C_003Em__Finally2()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        private static readonly string ContentLength;
        private UnityWebRequest _req;
        private Func<T> _downloadHandlerFactory;
        private Func<UploadHandler> _uploadHandlerFactory;
        private Func<UnityWebRequest, ulong, ulong> _getDownloadedBytes;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public UnityDownloadRequest(string url, WebHeaderCollection header, Func<T> downloadHandlerFactory, Func<UploadHandler> uploadHandlerFactory, Action<T, Error> onComplete, Action<ulong, ulong> onProgress) : base(default, default, default, default)
        {
        }

        [IteratorStateMachine(typeof(UnityDownloadRequest<>._003CExecute_003Ed__6))]
        public override IEnumerator Execute()
        {
            return null;
        }

        protected override void CalculateProgress()
        {
        }

        public override void Abort(Error err)
        {
        }
    }
}
