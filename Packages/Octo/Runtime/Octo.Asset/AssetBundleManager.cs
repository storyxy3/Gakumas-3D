namespace Octo.Asset
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::Octo.Asset;
    using global::Octo.Data;
    using global::UnityEngine;

    internal sealed class AssetBundleManager : MonoBehaviour, IAssetBundleManager
    {
        private sealed class DeleteQueueIterator : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
        {
            [CompilerGenerated]
            private string _003CCurrent_003Ek__BackingField;
            private Queue<AssetBundleData> _assetBundleDeleteQueue;
            private IDictionary<string, AssetBundleData> _assetList;
            private int _counter;
            private AssetBundleData _currentData;
            public string Current
            {
                [CompilerGenerated]
                get
                {
                    return _003CCurrent_003Ek__BackingField;
                }

                [CompilerGenerated]
                private set
                {
                    _003CCurrent_003Ek__BackingField = value;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return null;
                }
            }

            public DeleteQueueIterator(Queue<AssetBundleData> assetBundleDeleteQueue, IDictionary<string, AssetBundleData> assetList)
            {
            }

            public IEnumerator<string> GetEnumerator()
            {
                return null;
            }

            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }

            public bool MoveNext()
            {
                return default(bool);
            }

            private void CheckCurrentData()
            {
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }

        private sealed class RequestRollBack
        {
            [CompilerGenerated]
            private sealed class _003CRollBack_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
            {
                private int _003C_003E1__state;
                private object _003C_003E2__current;
                public RequestRollBack _003C_003E4__this;
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
                public _003CRollBack_003Ed__6(int _003C_003E1__state)
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

            private bool _isCanceled;
            private AssetBundleData _assetBundleData;
            private List<AssetBundleLoadRequest> _requestList;
            private Action<IAssetOperator, LoadError> _onComplete;
            private Action _onUnload;
            public RequestRollBack(AssetBundleData assetBundleData, List<AssetBundleLoadRequest> requestList, Action<IAssetOperator, LoadError> onComplete, Action onUnload)
            {
            }

            [IteratorStateMachine(typeof(_003CRollBack_003Ed__6))]
            public IEnumerator RollBack()
            {
                return null;
            }

            public void Cancel()
            {
            }

            private void Call(IAssetOperator opr, LoadError err)
            {
            }

            public void SetTopPriority(bool immediateExecute = false)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public AssetBundleManager _003C_003E4__this;
            public int loadRequestID;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal void _003CCancelLoadingAssetBundle_003Eb__0(RequestRollBack rBack)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass20_0
        {
            public bool immediateExecute;
            public _003C_003Ec__DisplayClass20_0()
            {
            }

            internal void _003CSetRequestTopPriority_003Eb__0(RequestRollBack rBack)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass28_0
        {
            public AssetBundleManager _003C_003E4__this;
            public AssetBundleData peekData;
            public _003C_003Ec__DisplayClass28_0()
            {
            }

            internal void _003C_LoadAssetBundle_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_CheckUnloadAssetKeeper_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetBundleManager _003C_003E4__this;
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
            public _003C_CheckUnloadAssetKeeper_003Ed__31(int _003C_003E1__state)
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
        private sealed class _003C_LoadAssetBundle_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetBundleManager _003C_003E4__this;
            public Item item;
            private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;
            public Action<IAssetOperator, LoadError> onComplete;
            public OnDownloadProgress onProgress;
            public bool isNonCache;
            public int loadRequestID;
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
            public _003C_LoadAssetBundle_003Ed__28(int _003C_003E1__state)
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
        private const int InitialDeleteQueueCapacity = 100;
        private const int RollbackInitialCount = 100;
        private IDictionary<string, AssetBundleData> _assetList;
        private Queue<AssetBundleData> _assetBundleDeleteQueue;
        private DeleteQueueIterator _deleteQueueIterator;
        private int _loadRequestID;
        private List<AssetKeeper> _unloadCheckAssetKeeperList;
        private List<AssetKeeper> _cacheUnloadCheckAssetKeeperList;
        private Dictionary<int, RequestRollBack> _requestRollBack;
        private Coroutine _unloadLoop;
        private IUnloadHandler _unloadHandler;
        private bool _isShuttingDown;
        public IUnloadHandler UnloadHandler
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        internal AssetBundleManager()
        {
        }

        public int LoadAssetBundle(Item item, Action<IAssetOperator, LoadError> onComplete, OnDownloadProgress onProgres, bool isNonCache)
        {
            return default(int);
        }

        public bool CancelLoadingAssetBundle(int loadRequestID)
        {
            return default(bool);
        }

        public bool SetRequestTopPriority(int loadRequestID, bool immediateExecute = false)
        {
            return default(bool);
        }

        public bool UnloadAssetBundle(string name, bool force)
        {
            return default(bool);
        }

        public bool UnloadAssetBundle(Item item, bool force)
        {
            return default(bool);
        }

        private void _UnloadAssetBundle(Item item, bool force)
        {
        }

        public bool IsLoaded(string abName)
        {
            return default(bool);
        }

        public AssetBundleData GetLoadedAsstBundleData(string assetBundleName)
        {
            return null;
        }

        internal void AddUnloadCheckAssetKeeper(AssetKeeper assetKeeper)
        {
        }

        internal void RemoveUnloadCheckAssetKeeper(AssetKeeper assetKeeper)
        {
        }

        [IteratorStateMachine(typeof(_003C_LoadAssetBundle_003Ed__28))]
        private IEnumerator _LoadAssetBundle(Item item, Action<IAssetOperator, LoadError> onComplete, OnDownloadProgress onProgress, int loadRequestID, bool isNonCache)
        {
            return null;
        }

        private AssetBundleData AddReferenceCount(Item item)
        {
            return null;
        }

        private bool OperateRollBack(int loadRequestID, Action<RequestRollBack> action)
        {
            return default(bool);
        }

        [IteratorStateMachine(typeof(_003C_CheckUnloadAssetKeeper_003Ed__31))]
        private IEnumerator _CheckUnloadAssetKeeper()
        {
            return null;
        }

        public bool HaveUnloadableAssetBundles()
        {
            return default(bool);
        }

        public IEnumerable<string> GetUnloadableAssetBundles()
        {
            return null;
        }

        void Octo.IAssetBundleManager.UnloadAssetBundle(string assetBundleName, bool unloadAll)
        {
        }

        private void OnApplicationQuit()
        {
        }

        private void OnDestroy()
        {
        }
    }
}
