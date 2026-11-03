namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::Octo.Caching;
    using global::Octo.Data;
    using global::Octo.Loader;
    using global::UnityEngine;

    internal sealed class UnityAssetBundleLoader : IAssetBundleLoader, ILoader<AssetBundle>, ILoader
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public UnityAssetBundleLoader _003C_003E4__this;
            public string assetBundleName;
            public Common.CallbackEvents<Common.Result<AssetBundle>> events;
            public _003C_003Ec__DisplayClass6_0()
            {
            }

            internal void _003CLoadFromCacheOrDownload_003Eb__0(AssetBundle assetBundle, Error err)
            {
            }

            internal void _003CLoadFromCacheOrDownload_003Eb__1(ulong received, ulong contentLength)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass8_0
        {
            public UnityAssetBundleLoader _003C_003E4__this;
            public string assetBundleName;
            public Action<Common.Result<byte[]>> safeAction;
            public _003C_003Ec__DisplayClass8_0()
            {
            }

            internal void _003CDownloadToMemory_003Eb__0(Common.Result<byte[]> result)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass9_0
        {
            public Action<DownloadError> onComplete;
            public _003C_003Ec__DisplayClass9_0()
            {
            }

            internal void _003CPreDownload_003Eb__0(AssetBundle ab, LoadError err)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CLoadFromAppCachingAsync_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public UnityAssetBundleLoader _003C_003E4__this;
            public string bucket;
            public Item item;
            public Action<AssetBundle, LoadError> onComplete;
            private AssetBundleCreateRequest _003Creq_003E5__2;
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
            public _003CLoadFromAppCachingAsync_003Ed__10(int _003C_003E1__state)
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

        private Dictionary<string, Common.CallbackEvents<Common.Result<AssetBundle>>> _callbackPool;
        private Dictionary<string, Common.CallbackEvents<Common.Result<byte[]>>> _nonCacheCallbackPool;
        private readonly OctoAppCaching _appCaching;
        public bool CanDownloadWithoutLoad
        {
            get
            {
                return default(bool);
            }
        }

        public UnityAssetBundleLoader()
        {
        }

        public void LoadFromCacheOrDownload(string assetBundleName, Action<AssetBundle, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void DownloadToMemory(string assetBundleName, Action<byte[], LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
        }

        public void PreDownload(string name, Action<DownloadError> onComplete, [Optional] OnDownloadProgress onProgress, bool canAutoDelete = false)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadFromAppCachingAsync_003Ed__10))]
        private IEnumerator LoadFromAppCachingAsync(Item item, string bucket, Action<AssetBundle, LoadError> onComplete)
        {
            return null;
        }
    }
}
