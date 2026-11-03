namespace Octo
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::UnityEngine;
    using global::UnityEngine.Events;

    public sealed class AssetLoader : MonoBehaviour
    {
        public enum LoadPriority : byte
        {
            AssetBundle,
            AssetBundleOnly,
            Resources,
            ResourcesOnly
        }

        [Serializable]
        public enum LoadState : byte
        {
            BeforeLoad,
            Loading,
            Loaded,
            Fail,
            Cancel
        }

        [Serializable]
        private sealed class AssetData
        {
            public LoadState state;
            public UnityEngine.Object asset;
            public AssetLoaderError error;
            public void Success(UnityEngine.Object asset)
            {
            }

            public void Fail(AssetLoaderError error, [Optional] UnityEngine.Object asset)
            {
            }

            public void Set(LoadState state, UnityEngine.Object asset, AssetLoaderError error)
            {
            }

            public AssetData()
            {
            }
        }

        [Serializable]
        private sealed class LoadAssetCompleteEvent : UnityEvent<UnityEngine.Object, AssetLoaderError>
        {
            public LoadAssetCompleteEvent()
            {
            }
        }

        [Serializable]
        private sealed class RequestAssetData
        {
            public string name;
            public LoadAssetCompleteEvent onCompleteEvent;
            public RequestAssetData()
            {
            }
        }

        [Serializable]
        private sealed class LoadAssetBundleCompleteEvent : UnityEvent<IAssetOperator, LoadError>
        {
            public LoadAssetBundleCompleteEvent()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_0<T>
            where T : UnityEngine.Object
        {
            public AssetLoader _003C_003E4__this;
            public string assetName;
            public Action<T, AssetLoaderError> onComplete;
            public _003C_003Ec__DisplayClass29_0()
            {
            }

            internal void _003C_LoadAsset_003Eb__0(T obj, AssetLoaderError error)
            {
            }

            internal void _003C_LoadAsset_003Eb__1(T obj, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_1<T>
            where T : UnityEngine.Object
        {
            public AssetLoaderError error;
            public _003C_003Ec__DisplayClass29_0<T> CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass29_1()
            {
            }

            internal void _003C_LoadAsset_003Eb__2(T fallbackObj, AssetLoaderError fallbackError)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_2<T>
            where T : UnityEngine.Object
        {
            public AssetLoaderError error;
            public _003C_003Ec__DisplayClass29_0<T> CS_0024_003C_003E8__locals2;
            public _003C_003Ec__DisplayClass29_2()
            {
            }

            internal void _003C_LoadAsset_003Eb__3(T fallbackObj, AssetLoaderError fallbackError)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass31_0
        {
            public AssetLoader _003C_003E4__this;
            public Action<AssetLoader, AssetLoaderError> onComplete;
            public _003C_003Ec__DisplayClass31_0()
            {
            }

            internal void _003CLoadAssetBundle_003Eb__0(IAssetOperator opr, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass32_0<T>
            where T : UnityEngine.Object
        {
            public AssetLoader _003C_003E4__this;
            public KeyValuePair<string, Delegate> kv;
            public Action<T, AssetLoaderError> onComplete;
            public string assetName;
            public Action<T, AssetLoaderError> callBack;
            public _003C_003Ec__DisplayClass32_0()
            {
            }

            internal void _003C_LoadAssetFromAssetBundle_003Eb__0(T obj, AssetLoaderError error)
            {
            }

            internal void _003C_LoadAssetFromAssetBundle_003Eb__1(IAssetOperator opr, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass33_0<T>
            where T : UnityEngine.Object
        {
            public AssetLoader _003C_003E4__this;
            public KeyValuePair<string, Delegate> kv;
            public Action<T, AssetLoaderError> onComplete;
            public _003C_003Ec__DisplayClass33_0()
            {
            }

            internal void _003C_LoadAssetFromResources_003Eb__0(T obj, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass41_0
        {
            public int currentResetCount;
            public AssetLoader _003C_003E4__this;
            public Action<IAssetOperator, AssetLoaderError> onComplete;
            public _003C_003Ec__DisplayClass41_0()
            {
            }

            internal void _003C_StartLoadAssetBundle_003Eb__0(IAssetOperator opr, LoadError err)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass43_0<T>
            where T : UnityEngine.Object
        {
            public int index;
            public AssetLoader _003C_003E4__this;
            public _003C_003Ec__DisplayClass43_0()
            {
            }

            internal void _003C_LoadAssetAsyncIncludeOtherRequest_003Eb__0(UnityEngine.Object obj, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_LoadAssetAsyncFromAssetBundle_003Ed__46<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public string assetName;
            public Action<T, AssetLoaderError> onComplete;
            public AssetLoader _003C_003E4__this;
            private AssetData _003Cdata_003E5__2;
            private LoadRequest<T> _003Creq_003E5__3;
            private int _003CcurrentResetCount_003E5__4;
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
            public _003C_LoadAssetAsyncFromAssetBundle_003Ed__46(int _003C_003E1__state)
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
        private sealed class _003C_LoadAssetAsyncFromResources_003Ed__47<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public string assetName;
            public Action<T, AssetLoaderError> onComplete;
            public AssetLoader _003C_003E4__this;
            private AssetData _003Cdata_003E5__2;
            private ResourceRequest _003Creq_003E5__3;
            private int _003CcurrentResetCount_003E5__4;
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
            public _003C_LoadAssetAsyncFromResources_003Ed__47(int _003C_003E1__state)
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
        private sealed class _003C_LoadAssetAsyncIncludeOtherRequest_003Ed__43<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetLoader _003C_003E4__this;
            private int _003Ci_003E5__2;
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
            public _003C_LoadAssetAsyncIncludeOtherRequest_003Ed__43(int _003C_003E1__state)
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
        private sealed class _003C_LoadAssetBundle_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetLoader _003C_003E4__this;
            public Action<IAssetOperator, AssetLoaderError> onComplete;
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
            public _003C_LoadAssetBundle_003Ed__42(int _003C_003E1__state)
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
        private sealed class _003C_StartLoadAssetBundle_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetLoader _003C_003E4__this;
            public Action<IAssetOperator, AssetLoaderError> onComplete;
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
            public _003C_StartLoadAssetBundle_003Ed__41(int _003C_003E1__state)
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
        private sealed class _003C_WaitLoadAsset_003Ed__45<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetData data;
            public string assetName;
            public Action<T, AssetLoaderError> onComplete;
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
            public _003C_WaitLoadAsset_003Ed__45(int _003C_003E1__state)
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

        private static readonly string Tag;
        private static readonly string ImplicitMainAssetName;
        [SerializeField]
        private string _assetBundleName;
        [SerializeField]
        [Header("AssetBudle load when Start Methods. If defined AssetBundle Name.")]
        private bool _autoLoad;
        [SerializeField]
        private bool _isNonCache;
        private Dictionary<string, AssetData> _assetDictionary;
        [SerializeField]
        private RequestAssetData[] _requestAssetData;
        private LoadState _assetBundleLoadStatus;
        private int _requestId;
        private IAssetOperator _operator;
        private int resetCounter;
        [SerializeField]
        [Header("[Low Level] LoadAssetBundle complete.")]
        private LoadAssetBundleCompleteEvent _onCompleteLoadAssetBundle;
        private List<KeyValuePair<string, Delegate>> _onLoadCompleteDelegates;
        public string AssetBundleName
        {
            get
            {
                return null;
            }
        }

        public bool IsNonCache
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsStreamedSceneAssetBundle
        {
            get
            {
                return default(bool);
            }
        }

        public bool Setup(string assetBundleName, bool isNonCache = false)
        {
            return default(bool);
        }

        public void SetCompleteLoadAssetBundle(UnityAction<IAssetOperator, LoadError> onComplete)
        {
        }

        public void LoadAsset<T>(Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public void LoadAsset<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        private void _LoadAsset<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        private void OnFallbackCompleted<T>(AssetLoaderError error, T fallbackObj, AssetLoaderError fallbackError, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public void LoadAssetBundle(Action<AssetLoader, AssetLoaderError> onComplete)
        {
        }

        private void _LoadAssetFromAssetBundle<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        private void _LoadAssetFromResources<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public T GetAsset<T>()
            where T : UnityEngine.Object
        {
            return null;
        }

        public T GetAsset<T>(string assetName)
            where T : UnityEngine.Object
        {
            return null;
        }

        public bool SetLoadingTopPriority()
        {
            return default(bool);
        }

        public void ResetLoad()
        {
        }

        private void OnLoadAssetComplete<T>(KeyValuePair<string, Delegate> kv, Action<T, AssetLoaderError> onComplete, T obj, AssetLoaderError error)
        {
        }

        private bool CancelLoadingAssetBundle()
        {
            return default(bool);
        }

        private void Unload()
        {
        }

        [IteratorStateMachine(typeof(_003C_StartLoadAssetBundle_003Ed__41))]
        private IEnumerator _StartLoadAssetBundle(Action<IAssetOperator, AssetLoaderError> onComplete)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003C_LoadAssetBundle_003Ed__42))]
        private IEnumerator _LoadAssetBundle(Action<IAssetOperator, AssetLoaderError> onComplete)
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003C_LoadAssetAsyncIncludeOtherRequest_003Ed__43<>))]
        private IEnumerator _LoadAssetAsyncIncludeOtherRequest<T>(Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
            return null;
        }

        private static AssetLoaderError CreateTypeDifferedError<T>(string name, UnityEngine.Object obj)
            where T : UnityEngine.Object
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003C_WaitLoadAsset_003Ed__45<>))]
        private IEnumerator _WaitLoadAsset<T>(AssetData data, string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003C_LoadAssetAsyncFromAssetBundle_003Ed__46<>))]
        private IEnumerator _LoadAssetAsyncFromAssetBundle<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
            return null;
        }

        [IteratorStateMachine(typeof(_003C_LoadAssetAsyncFromResources_003Ed__47<>))]
        private IEnumerator _LoadAssetAsyncFromResources<T>(string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
            return null;
        }

        private void _OnLoadAsset<T>(string assetName, T asset, Action<T, AssetLoaderError> onComplete, AssetData data, int currentResetCount, string methodName)
            where T : UnityEngine.Object
        {
        }

        private void AutoStart()
        {
        }

        private void Start()
        {
        }

        private void OnDestroy()
        {
        }

        public new void StartCoroutine(IEnumerator coroutine)
        {
        }

        public new void StopCoroutine(IEnumerator coroutine)
        {
        }

        public AssetLoader()
        {
        }
    }
}
