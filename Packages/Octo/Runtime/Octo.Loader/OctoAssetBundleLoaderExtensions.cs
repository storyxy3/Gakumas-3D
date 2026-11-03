namespace Octo.Loader
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Loader;
    using global::UnityEngine;

    internal static class OctoAssetBundleLoaderExtensions
    {
        [CompilerGenerated]
        private sealed class _003CLoadAssetBundleFromBytesAsyncCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public Action<AssetBundle, LoadError> onComplete;
            public byte[] bytes;
            public string assetBundleName;
            private Action<AssetBundle, LoadError> _003CsafeOnComplete_003E5__2;
            private AssetBundleCreateRequest _003Creq_003E5__3;
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
            public _003CLoadAssetBundleFromBytesAsyncCoroutine_003Ed__2(int _003C_003E1__state)
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

        public static void Download(this IAssetBundleLoader loader, string name, Common.CallbackEvents<Common.Result<byte[]>> events)
        {
        }

        public static void LoadAssetBundleFromBytesAsync(this IAssetBundleLoader loader, string assetBundleName, byte[] bytes, Action<AssetBundle, LoadError> onComplete)
        {
        }

        [IteratorStateMachine(typeof(_003CLoadAssetBundleFromBytesAsyncCoroutine_003Ed__2))]
        private static IEnumerator LoadAssetBundleFromBytesAsyncCoroutine(string assetBundleName, byte[] bytes, Action<AssetBundle, LoadError> onComplete)
        {
            return null;
        }
    }
}
