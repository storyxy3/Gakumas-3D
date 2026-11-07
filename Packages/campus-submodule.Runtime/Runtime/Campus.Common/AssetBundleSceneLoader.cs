namespace Campus.Common
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Octo;
    using global::UnityEngine;
    using global::UnityEngine.SceneManagement;

    public class AssetBundleSceneLoader : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass14_0
        {
            public AssetLoaderError error;
            public bool loading;
            public _003C_003Ec__DisplayClass14_0()
            {
            }

            internal void _003CLoadAssetBundleAsync_003Eb__0(AssetLoader loader, AssetLoaderError err)
            {
            }

            internal bool _003CLoadAssetBundleAsync_003Eb__1()
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass18_0
        {
            public bool loadEnd;
            public _003C_003Ec__DisplayClass18_0()
            {
            }

            internal bool _003CUnloadSceneAsync_003Eb__0()
            {
                return default(bool);
            }

            internal bool _003CUnloadSceneAsync_003Eb__1()
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public Scene scene;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal bool _003CUnloadSceneAsync_003Eb__0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetBundleAsync_003Ed__14 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public AssetBundleSceneLoader _003C_003E4__this;
            public string assetBundleName;
            private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__13 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AssetBundleSceneLoader _003C_003E4__this;
            public string assetBundleName;
            public CancellationToken ct;
            public string sceneName;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneFromLoadedAssetBundleAsync_003Ed__16 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AssetBundleSceneLoader _003C_003E4__this;
            public string sceneName;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003CUnloadAssetBundleAsync_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AssetBundleSceneLoader _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
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
        private struct _003CUnloadSceneAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public AssetBundleSceneLoader _003C_003E4__this;
            private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;
            public CancellationToken ct;
            private UniTask<bool>.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
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
        private struct _003CUnloadSceneAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Scene scene;
            private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            private Awaitable.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private bool _quit;
        [CompilerGenerated]
        private string _003CSceneName_003Ek__BackingField;
        private GameObject[] _rootObjects;
        private AssetLoader _loader;
        private Scene _currentScene;
        private CancellationTokenSource _loadAssetBundleCts;
        private CancellationTokenSource _loadSceneCts;
        public string SceneName
        {
            [CompilerGenerated]
            get
            {
                return _003CSceneName_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CSceneName_003Ek__BackingField = value;
            }
        }

        public GameObject[] RootObjects
        {
            get
            {
                return null;
            }
        }

        public UniTask LoadSceneAsync(string sceneName, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__13))]
        public UniTask LoadSceneAsync(string sceneName, string assetBundleName, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadAssetBundleAsync_003Ed__14))]
        public UniTask LoadAssetBundleAsync(string assetBundleName, CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask LoadSceneFromLoadedAssetBundleAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneFromLoadedAssetBundleAsync_003Ed__16))]
        public UniTask LoadSceneFromLoadedAssetBundleAsync(string sceneName, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void TrySetRootObjectsActive(bool isActive)
        {
        }

        [AsyncStateMachine(typeof(_003CUnloadSceneAsync_003Ed__18))]
        public UniTask UnloadSceneAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CUnloadSceneAsync_003Ed__19))]
        private static UniTask UnloadSceneAsync(Scene scene, [Optional] CancellationToken ct)
        {
            return default(UniTask);
        }

        private static void TryUnloadUnusedAssets()
        {
        }

        [AsyncStateMachine(typeof(_003CUnloadAssetBundleAsync_003Ed__21))]
        public UniTask UnloadAssetBundleAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void CancelLoad()
        {
        }

        public void SetActiveCurrentScene()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnApplicationQuit()
        {
        }

        private static string ErrorString(AssetLoaderError error)
        {
            return null;
        }

        public AssetBundleSceneLoader()
        {
        }

        [CompilerGenerated]
        private bool _003CLoadSceneFromLoadedAssetBundleAsync_003Eb__16_0()
        {
            return default(bool);
        }

        [CompilerGenerated]
        private void _003COnDestroy_003Eb__24_0()
        {
        }
    }
}
