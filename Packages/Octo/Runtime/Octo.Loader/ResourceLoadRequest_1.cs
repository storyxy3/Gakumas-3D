namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Data;
    using global::Octo.Loader;

    internal sealed class ResourceLoadRequest<T> : BaseRequest
    {
        [CompilerGenerated]
        private sealed class _003CExecute_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public ResourceLoadRequest<T> _003C_003E4__this;
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
            public _003CExecute_003Ed__13(int _003C_003E1__state)
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
        private sealed class _003CPrepare_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public ResourceLoadRequest<T> _003C_003E4__this;
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
            public _003CPrepare_003Ed__12(int _003C_003E1__state)
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

        private static readonly string TAG;
        private OctoResourceLoader _loader;
        private Action<T, LoadError> _callback;
        private OnDownloadProgress _onProgress;
        private Item _item;
        private DownloadError _err;
        private bool _canExecute;
        public override string Name
        {
            get
            {
                return null;
            }
        }

        public override bool CanExecute
        {
            get
            {
                return default(bool);
            }
        }

        public ResourceLoadRequest(OctoResourceLoader loader, Item item, Action<T, LoadError> onComplete, OnDownloadProgress onProgress)
        {
        }

        [IteratorStateMachine(typeof(ResourceLoadRequest<>._003CPrepare_003Ed__12))]
        public override IEnumerator Prepare()
        {
            return null;
        }

        [IteratorStateMachine(typeof(ResourceLoadRequest<>._003CExecute_003Ed__13))]
        public override IEnumerator Execute()
        {
            return null;
        }

        [CompilerGenerated]
        private void _003CPrepare_003Eb__12_0(DownloadError downloadError)
        {
        }

        [CompilerGenerated]
        private void _003CExecute_003Eb__13_0(T obj)
        {
        }
    }
}
