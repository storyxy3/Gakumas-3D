namespace Octo
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::Octo;
    using global::UnityEngine;

    public class AssetKeeper : MonoBehaviour
    {
        internal class AssetBundleLoadState
        {
            private const int InitialRequestId = -1;
            public int RequestId;
            public string LoadName;
            [CompilerGenerated]
            private Action<IAssetOperator, LoadError> m_CompleteEvent;
            public event Action<IAssetOperator, LoadError> CompleteEvent
            {
                [CompilerGenerated]
                add
                {
                }

                [CompilerGenerated]
                remove
                {
                }
            }

            public void OnLoadComplete(IAssetOperator assetOperator, LoadError error)
            {
            }

            public AssetBundleLoadState()
            {
            }
        }

        private struct AssetLoadState
        {
            private uint _counter;
            public uint Start()
            {
                return default(uint);
            }

            public bool Check(uint count)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass16_0<T>
            where T : UnityEngine.Object
        {
            public Action<T, AssetLoaderError> onComplete;
            public AssetKeeper _003C_003E4__this;
            public string assetBundleName;
            public string assetName;
            public _003C_003Ec__DisplayClass16_0()
            {
            }

            internal void _003CLoadAssetInternal_003Eb__0(IAssetOperator assetOperator, LoadError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_0<T>
            where T : UnityEngine.Object
        {
            public bool isCompleted;
            public TaskCompletionSource<AsyncLoadResult<T>> tcs;
            public AssetKeeper _003C_003E4__this;
            public _003C_003Ec__DisplayClass29_0()
            {
            }

            internal void _003CLoadAssetAsyncInternal_003Eb__0(T asset, AssetLoaderError error)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass29_1<T>
            where T : UnityEngine.Object
        {
            public int requestId;
            public _003C_003Ec__DisplayClass29_0<T> CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass29_1()
            {
            }

            internal void _003CLoadAssetAsyncInternal_003Eb__1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003CDoLoadAsset_003Ed__18<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public AssetKeeper _003C_003E4__this;
            public string assetName;
            public Action<T, AssetLoaderError> onComplete;
            private uint _003CstartNumber_003E5__2;
            private LoadRequest<T> _003CloadRequest_003E5__3;
            private IAssetOperator _003CloadingAssetOperator_003E5__4;
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
            public _003CDoLoadAsset_003Ed__18(int _003C_003E1__state)
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetAsync_003Ed__30<T> : IAsyncStateMachine where T : UnityEngine.Object
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<T> _003C_003Et__builder;
            public AssetKeeper _003C_003E4__this;
            public string assetBundleAndAssetName;
            public CancellationToken cancellationToken;
            private TaskAwaiter<T> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetAsync_003Ed__32<T> : IAsyncStateMachine where T : UnityEngine.Object
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<T> _003C_003Et__builder;
            public string assetName;
            public AssetKeeper _003C_003E4__this;
            public string assetBundleName;
            public CancellationToken cancellationToken;
            private TaskAwaiter<T> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetAsyncInternal_003Ed__29<T> : IAsyncStateMachine where T : UnityEngine.Object
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<T> _003C_003Et__builder;
            public AssetKeeper _003C_003E4__this;
            public string assetBundleName;
            public string assetName;
            public CancellationToken cancellationToken;
            private _003C_003Ec__DisplayClass29_0<T> _003C_003E8__1;
            private TaskAwaiter<AsyncLoadResult<T>> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadMainAssetAsync_003Ed__31<T> : IAsyncStateMachine where T : UnityEngine.Object
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<T> _003C_003Et__builder;
            public AssetKeeper _003C_003E4__this;
            public string assetBundleName;
            public CancellationToken cancellationToken;
            private TaskAwaiter<T> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private AssetLoadState _assetLoadState;
        internal AssetBundleLoadState _assetBundleLoadState;
        internal IAssetOperator _currentAssetOperator;
        internal IAssetOperator _usingAssetOperator;
        private bool _isAddUnloadCheck;
        private void Awake()
        {
        }

        protected virtual void OnAwake()
        {
        }

        private void OnDestroy()
        {
        }

        public void LoadAsset<T>(string assetBundleAndAssetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public void LoadMainAsset<T>(string assetBundleName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public void LoadAsset<T>(string assetBundleName, string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        public void Unload()
        {
        }

        public void CancelLoadingAssetBundle()
        {
        }

        public void SetTopPriorityLoadingAssetBundle(bool immediateExecute = false)
        {
        }

        private void LoadAssetInternal<T>(string assetBundleName, string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        private void StartLoadAsset<T>(string assetBundleName, string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
        }

        [IteratorStateMachine(typeof(_003CDoLoadAsset_003Ed__18<>))]
        private IEnumerator DoLoadAsset<T>(string assetBundleName, string assetName, Action<T, AssetLoaderError> onComplete)
            where T : UnityEngine.Object
        {
            return null;
        }

        private void LoadAssetBundle(string assetBundleName, Action<IAssetOperator, LoadError> onComplete)
        {
        }

        private void SetCurrentAssetOperator(IAssetOperator assetOperator)
        {
        }

        private void SetUsingAssetOperator(IAssetOperator assetOperator)
        {
        }

        private bool CompareAssetOperator(IAssetOperator assetOperator, IAssetOperator assetOperator2)
        {
            return default(bool);
        }

        private void Unload(ref IAssetOperator assetOperator)
        {
        }

        private AssetLoaderError CreateAssetLoadError(string assetName, Type loadType)
        {
            return null;
        }

        private AssetLoaderError CreateAssetLoadCancelError(string assetName)
        {
            return null;
        }

        private bool CheckLoadingAssetBundle()
        {
            return default(bool);
        }

        internal void Dispose()
        {
        }

        protected virtual void OnDisposed()
        {
        }

        [AsyncStateMachine(typeof(_003CLoadAssetAsyncInternal_003Ed__29<>))]
        private Task<T> LoadAssetAsyncInternal<T>(string assetBundleName, string assetName, [Optional] CancellationToken cancellationToken)
            where T : UnityEngine.Object
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadAssetAsync_003Ed__30<>))]
        public Task<T> LoadAssetAsync<T>(string assetBundleAndAssetName, CancellationToken cancellationToken)
            where T : UnityEngine.Object
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadMainAssetAsync_003Ed__31<>))]
        public Task<T> LoadMainAssetAsync<T>(string assetBundleName, CancellationToken cancellationToken)
            where T : UnityEngine.Object
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadAssetAsync_003Ed__32<>))]
        public Task<T> LoadAssetAsync<T>(string assetBundleName, string assetName, CancellationToken cancellationToken)
            where T : UnityEngine.Object
        {
            return null;
        }

        public AssetKeeper()
        {
        }
    }
}
