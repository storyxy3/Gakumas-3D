namespace Octo.Network
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

    internal abstract class BaseDownloadRequest<T> : BaseRequest, IDownloadRequest, IRequest where T : class, IDisposable
    {
        [CompilerGenerated]
        private sealed class _003CFinish_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public BaseDownloadRequest<T> _003C_003E4__this;
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
            public _003CFinish_003Ed__28(int _003C_003E1__state)
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

        [CompilerGenerated]
        private sealed class _003CTimeoutWatcher_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public BaseDownloadRequest<T> _003C_003E4__this;
            private float _003CstallStartTime_003E5__2;
            private float _003CstallTimeout_003E5__3;
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
            public _003CTimeoutWatcher_003Ed__27(int _003C_003E1__state)
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

        protected string _url;
        protected WebHeaderCollection _header;
        protected Action<T, Error> _onComplete;
        protected Action<ulong, ulong> _onProgress;
        protected ulong _receivedLength;
        protected ulong _contentLength;
        protected ulong _lastProgressCallbackLength;
        protected bool _isAborted;
        private string _name;
        protected Error _panicError;
        protected int _retryCount;
        protected bool _shouldRetry;
        private T _downloadHandler;
        private Error _error;
        public override string Name
        {
            get
            {
                return null;
            }
        }

        public override Error PanicError
        {
            get
            {
                return null;
            }
        }

        public override bool ShouldRetry
        {
            get
            {
                return default(bool);
            }
        }

        private float SinceStartup
        {
            get
            {
                return default(float);
            }
        }

        public BaseDownloadRequest(string url, WebHeaderCollection header, Action<T, Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        protected void Init()
        {
        }

        public void SetName(string name)
        {
        }

        protected void SetResult(T downloadHandler, Error err)
        {
        }

        protected bool CanReach()
        {
            return default(bool);
        }

        [IteratorStateMachine(typeof(BaseDownloadRequest<>._003CTimeoutWatcher_003Ed__27))]
        public override IEnumerator TimeoutWatcher()
        {
            return null;
        }

        [IteratorStateMachine(typeof(BaseDownloadRequest<>._003CFinish_003Ed__28))]
        public override IEnumerator Finish()
        {
            return null;
        }

        public override void Panic(Error err)
        {
        }

        protected abstract void CalculateProgress();
        protected void CallProgressUpdate()
        {
        }

        [CompilerGenerated]
        private void _003CFinish_003Eb__28_0()
        {
        }
    }
}
