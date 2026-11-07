namespace Octo
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::Octo;
    using global::Octo.Asset;
    using global::Octo.Data;
    using global::Octo.Loader;
    using global::Octo.Util;
    using global::UnityEngine;

    public static class OctoManager
    {
        internal static class Internal
        {
            public static OctoAPI _octoAPI;
            public static DataManager _dataManager;
            public static Downloader _downloader;
            public static LoadExecutor _loadExecutor;
            public static Octo.Util.Timer _timer;
            public static ICachingInternal _caching;
            public static AssetBundleManager _assetBundleManager;
            public static bool IsReady
            {
                get
                {
                    return default(bool);
                }
            }

            public static GameObject OctoGameObject
            {
                get
                {
                    return null;
                }
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass127_0
        {
            public TaskCompletionSource<DownloadError> tcs;
            public _003C_003Ec__DisplayClass127_0()
            {
            }

            internal void _003CStartDbUpdateAsync_003Eb__0(DownloadError err)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass128_0
        {
            public TaskCompletionSource<AsyncLoadResult<IAssetOperator>> tcs;
            public int id;
            public _003C_003Ec__DisplayClass128_0()
            {
            }

            internal void _003CLoadAssetBundleAsync_003Eb__0(IAssetOperator assetOperator, LoadError error)
            {
            }

            internal void _003CLoadAssetBundleAsync_003Eb__1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass97_0
        {
            public DataManager dataManager;
            public int revision;
            public Action<DownloadError> onComplete;
            public _003C_003Ec__DisplayClass97_0()
            {
            }

            internal void _003CStartDbUpdate_003Eb__0(byte[] data, Error err)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass98_0
        {
            public Action<bool, int, DownloadError> onComplete;
            public _003C_003Ec__DisplayClass98_0()
            {
            }

            internal void _003CIsLatestDb_003Eb__0(int serverRevision, Error err)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetBundleAsync_003Ed__128 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<IAssetOperator> _003C_003Et__builder;
            public Func<string, Action<IAssetOperator, LoadError>, OnDownloadProgress, int> loadMethod;
            public string name;
            public OnDownloadProgress onProgress;
            public CancellationToken cancellationToken;
            private _003C_003Ec__DisplayClass128_0 _003C_003E8__1;
            private TaskAwaiter<AsyncLoadResult<IAssetOperator>> _003C_003Eu__1;
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
        private struct _003CLoadAssetBundleAsync_003Ed__130 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder<IAssetOperator> _003C_003Et__builder;
            public string name;
            public OnDownloadProgress onProgress;
            public CancellationToken cancellationToken;
            private TaskAwaiter<IAssetOperator> _003C_003Eu__1;
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
        private struct _003CStartDbUpdateAsync_003Ed__127 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncTaskMethodBuilder _003C_003Et__builder;
            public bool reset;
            private _003C_003Ec__DisplayClass127_0 _003C_003E8__1;
            public CancellationToken cancellationToken;
            private TaskAwaiter<DownloadError> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public static readonly string Version;
        private static readonly int SaveVersion;
        private static readonly string Tag;
        [CompilerGenerated]
        private static ILogger _003CLogger_003Ek__BackingField;
        [CompilerGenerated]
        private static IAssetBundleLoader _003CAssetBundleLoader_003Ek__BackingField;
        [CompilerGenerated]
        private static IResourceLoader _003CResourceLoader_003Ek__BackingField;
        [CompilerGenerated]
        private static IDatabase _003CDatabase_003Ek__BackingField;
        [CompilerGenerated]
        private static IExecutor _003CDownloadExecutor_003Ek__BackingField;
        [CompilerGenerated]
        private static IExecutor _003CLoadExecutor_003Ek__BackingField;
        [CompilerGenerated]
        private static DateTime _003CDbUpdateTimeAfterStartup_003Ek__BackingField;
        [CompilerGenerated]
        private static bool _003CIsSetupped_003Ek__BackingField;
        [CompilerGenerated]
        private static bool _003CAllowDeleted_003Ek__BackingField;
        [CompilerGenerated]
        private static DownloadErrorHandler _003CDownloadErrorInteceptor_003Ek__BackingField;
        [CompilerGenerated]
        private static LoadErrorHandler _003CLoadErrorInterceptor_003Ek__BackingField;
        [CompilerGenerated]
        private static AssetBundleLoadHandler _003CAssetBundleLoadInterceptor_003Ek__BackingField;
        [CompilerGenerated]
        private static ImplicitDownloadHandler _003CAssetBundleImplicitDownloadInterceptor_003Ek__BackingField;
        [CompilerGenerated]
        private static ImplicitDownloadHandler _003CResourceImplicitDownloadInterceptor_003Ek__BackingField;
        [CompilerGenerated]
        private static AssetBundleUnloadHandler _003COnAssetBundleUnloadCompleted_003Ek__BackingField;
        [CompilerGenerated]
        private static GetResourceExtensionHandler _003CGetResourceExtensionOverrider_003Ek__BackingField;
        [CompilerGenerated]
        private static Action<DatabaseError> _003COnDatabaseNameNotFoundError_003Ek__BackingField;
        [CompilerGenerated]
        private static AssetLoader.LoadPriority _003CAssetLoaderPriority_003Ek__BackingField;
        [CompilerGenerated]
        private static float _003CDownloadStallTimeout_003Ek__BackingField;
        private static readonly string GameObjectName;
        private static GameObject _octoGameObject;
        private static IOctoSettings _settings;
        private static readonly string[] _sharedSingleString;
        public static ICaching Caching
        {
            get
            {
                return null;
            }
        }

        public static ILogger Logger
        {
            [CompilerGenerated]
            get
            {
                return _003CLogger_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CLogger_003Ek__BackingField = value;
            }
        }

        public static IAssetBundleLoader AssetBundleLoader
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetBundleLoader_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CAssetBundleLoader_003Ek__BackingField = value;
            }
        }

        public static IResourceLoader ResourceLoader
        {
            [CompilerGenerated]
            get
            {
                return _003CResourceLoader_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CResourceLoader_003Ek__BackingField = value;
            }
        }

        public static IDatabase Database
        {
            [CompilerGenerated]
            get
            {
                return _003CDatabase_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDatabase_003Ek__BackingField = value;
            }
        }

        public static IExecutor DownloadExecutor
        {
            [CompilerGenerated]
            get
            {
                return _003CDownloadExecutor_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDownloadExecutor_003Ek__BackingField = value;
            }
        }

        private static IExecutor LoadExecutor
        {
            [CompilerGenerated]
            set
            {
                _003CLoadExecutor_003Ek__BackingField = value;
            }
        }

        private static DateTime DbUpdateTimeAfterStartup
        {
            [CompilerGenerated]
            set
            {
                _003CDbUpdateTimeAfterStartup_003Ek__BackingField = value;
            }
        }

        public static int DbRevision
        {
            get
            {
                return default(int);
            }
        }

        public static bool IsSetupped
        {
            [CompilerGenerated]
            get
            {
                return _003CIsSetupped_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsSetupped_003Ek__BackingField = value;
            }
        }

        public static bool AllowDeleted
        {
            [CompilerGenerated]
            get
            {
                return _003CAllowDeleted_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAllowDeleted_003Ek__BackingField = value;
            }
        }

        public static DownloadErrorHandler DownloadErrorInteceptor
        {
            [CompilerGenerated]
            get
            {
                return _003CDownloadErrorInteceptor_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CDownloadErrorInteceptor_003Ek__BackingField = value;
            }
        }

        public static LoadErrorHandler LoadErrorInterceptor
        {
            [CompilerGenerated]
            set
            {
                _003CLoadErrorInterceptor_003Ek__BackingField = value;
            }
        }

        public static AssetBundleLoadHandler AssetBundleLoadInterceptor
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetBundleLoadInterceptor_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAssetBundleLoadInterceptor_003Ek__BackingField = value;
            }
        }

        public static ImplicitDownloadHandler AssetBundleImplicitDownloadInterceptor
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetBundleImplicitDownloadInterceptor_003Ek__BackingField;
            }
        }

        public static ImplicitDownloadHandler ResourceImplicitDownloadInterceptor
        {
            [CompilerGenerated]
            get
            {
                return _003CResourceImplicitDownloadInterceptor_003Ek__BackingField;
            }
        }

        public static AssetBundleUnloadHandler OnAssetBundleUnloadCompleted
        {
            [CompilerGenerated]
            get
            {
                return _003COnAssetBundleUnloadCompleted_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnAssetBundleUnloadCompleted_003Ek__BackingField = value;
            }
        }

        public static GetResourceExtensionHandler GetResourceExtensionOverrider
        {
            [CompilerGenerated]
            get
            {
                return _003CGetResourceExtensionOverrider_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CGetResourceExtensionOverrider_003Ek__BackingField = value;
            }
        }

        public static Action<DatabaseError> OnDatabaseNameNotFoundError
        {
            [CompilerGenerated]
            get
            {
                return _003COnDatabaseNameNotFoundError_003Ek__BackingField;
            }
        }

        public static AssetLoader.LoadPriority AssetLoaderPriority
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetLoaderPriority_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAssetLoaderPriority_003Ek__BackingField = value;
            }
        }

        public static float DownloadStallTimeout
        {
            [CompilerGenerated]
            get
            {
                return _003CDownloadStallTimeout_003Ek__BackingField;
            }
        }

        static OctoManager()
        {
        }

        private static void SetDefault()
        {
        }

        public static bool Setup(OctoFullSettings settings, bool reset = false)
        {
            return default(bool);
        }

        private static bool _Setup(IOctoSettings settings, bool reset = false)
        {
            return default(bool);
        }

        public static void StartDbUpdate(Action<DownloadError> onComplete, bool reset = false)
        {
        }

        public static void IsLatestDb(Action<bool, int, DownloadError> onComplete)
        {
        }

        internal static int LoadAssetBundle(string name, Action<IAssetOperator, LoadError> onComplete, OnDownloadProgress onProgress, bool isNonCache)
        {
            return default(int);
        }

        public static int LoadAssetBundle(string name, Action<IAssetOperator, LoadError> onComplete, [Optional] OnDownloadProgress onProgress)
        {
            return default(int);
        }

        public static bool CancelLoadingAssetBundle(int loadRequestID)
        {
            return default(bool);
        }

        public static bool SetTopPriorityLoadingAssetBundle(int loadRequestID, bool immediateExecute = false)
        {
            return default(bool);
        }

        public static bool UnloadAssetBundle(string name, bool force = false)
        {
            return default(bool);
        }

        public static bool DeleteResourceCache(string name)
        {
            return default(bool);
        }

        public static bool IsAssetBundleExists(string assetBundleName)
        {
            return default(bool);
        }

        public static bool IsResourceExists(string resourceName)
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003CStartDbUpdateAsync_003Ed__127))]
        public static Task StartDbUpdateAsync([global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool reset, [Optional] CancellationToken cancellationToken)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadAssetBundleAsync_003Ed__128))]
        private static Task<IAssetOperator> LoadAssetBundleAsync(string name, Func<string, Action<IAssetOperator, LoadError>, OnDownloadProgress, int> loadMethod, [Optional] OnDownloadProgress onProgress, [Optional] CancellationToken cancellationToken)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CLoadAssetBundleAsync_003Ed__130))]
        public static Task<IAssetOperator> LoadAssetBundleAsync(string name, [Optional] OnDownloadProgress onProgress, [Optional] CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
