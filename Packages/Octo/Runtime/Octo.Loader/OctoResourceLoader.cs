namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::Octo.Data;
    using global::Octo.Loader;
    using global::UnityEngine;
    using global::UnityEngine.Networking;

    internal sealed class OctoResourceLoader : OctoBaseLoader, IResourceLoader, ILoader<byte[]>, ILoader, ILoader<string>, ILoader<Texture2D>, ILoader<AudioClip>
    {
        [CompilerGenerated]
        private sealed class _003CLoadLocalResource_003Ed__6<T> : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public OctoResourceLoader _003C_003E4__this;
            public Item data;
            public Action<T> onComplete;
            private Type _003Ct_003E5__2;
            private UnityWebRequest _003Cuwr_003E5__3;
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
            public _003CLoadLocalResource_003Ed__6(int _003C_003E1__state)
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

            private void _003C_003Em__Finally3()
            {
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public OctoResourceLoader(IOctoCaching caching) : base(default)
        {
        }

        protected override Item GetItemByName(string name)
        {
            return null;
        }

        protected override void Download(Item item, string path, Action<Error> onComplete, Action<ulong, ulong> onProgress)
        {
        }

        protected override string GetStorageBucket(Item data)
        {
            return null;
        }

        protected override string GetStorageFileName(Item data)
        {
            return null;
        }

        private void LoadFromCacheOrDownload<T>(string resourceName, Action<T, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadLocalResource_003Ed__6<>))]
        internal IEnumerator LoadLocalResource<T>(Item data, Action<T> onComplete)
        {
            return null;
        }

        public void LoadFromCacheOrDownload(string resourceName, Action<byte[], LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void LoadFromCacheOrDownload(string resourceName, Action<string, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void LoadFromCacheOrDownload(string resourceName, Action<Texture2D, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void LoadFromCacheOrDownload(string resourceName, Action<AudioClip, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }
    }
}
