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

    internal sealed class OctoAssetBundleLoader : OctoBaseLoader, IAssetBundleLoader, ILoader<AssetBundle>, ILoader
    {
        [CompilerGenerated]
        private sealed class _003CLoadFromFileAsync_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public OctoAssetBundleLoader _003C_003E4__this;
            public string assetBundleName;
            public Action<AssetBundle, LoadError> onComplete;
            private string _003Cbucket_003E5__2;
            private bool _003CisCachedInApp_003E5__3;
            private AssetBundleCreateRequest _003Creq_003E5__4;
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
            public _003CLoadFromFileAsync_003Ed__9(int _003C_003E1__state)
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

        private Dictionary<string, Common.CallbackEvents<Common.Result<byte[]>>> _nonCacheCallbackPool;
        // TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior.
        public OctoAssetBundleLoader(IOctoCaching caching) : base(default)
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

        public void LoadFromCacheOrDownload(string assetBundleName, Action<AssetBundle, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void DownloadToMemory(string assetBundleName, Action<byte[], LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadFromFileAsync_003Ed__9))]
        private IEnumerator LoadFromFileAsync(string assetBundleName, Action<AssetBundle, LoadError> onComplete)
        {
            return null;
        }
    }
}
