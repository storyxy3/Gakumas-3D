namespace Campus.Common.Octo
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.IO;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Text.RegularExpressions;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Octo;
    using global::UnityEngine;

    [DefaultExecutionOrder(-500)]
    public static class CampusOctoSetupper
    {
        public enum OctoEnvType
        {
            Prd,
            Rev,
            Stg,
            Dev,
            Sbx,
            ImpPrd,
            ImpStg,
            ImpDev,
            BneDev,
            BneDev2,
            TempDev
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Action<Stream> _003C_003E9__1_0;
            public static GetResourceExtensionHandler _003C_003E9__33_0;
            public _003C_003Ec()
            {
            }

            internal void _003COnInitialize_003Eb__1_0(Stream stream)
            {
                stream.Dispose();
            }

            internal string _003CSetupAsync_003Eb__33_0(string name, string extension)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass33_0
        {
            public UniTaskCompletionSource<DownloadError> promise;
            public CancellationToken ct;
            public _003C_003Ec__DisplayClass33_0()
            {
            }

            internal void _003CSetupAsync_003Eb__1(DownloadError error)
            {
            }

            internal void _003CSetupAsync_003Eb__2()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetupAsync_003Ed__33 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<DownloadError> _003C_003Et__builder;
            public CancellationToken ct;
            public OctoEnvType env;
            public int version;
            public bool reset;
            public ILogger logger;
            public OctoFullSettings settings;
            public bool setupOnly;
            private CancellationTokenRegistration _003C_003E7__wrap1;
            private UniTask<DownloadError>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private static readonly Regex PushImageRegex = new Regex("img_chr_.+?_00-thumb-push");
        private static readonly Dictionary<string, Stream> Streams = new Dictionary<string, Stream>();
        [CompilerGenerated]
        private static Action<string> onAssetBundleLoadInterceptor;
        private static bool _isDbUpdating;
        private static bool _isSetup;
        [CompilerGenerated]
        private static Action<OctoEnvType, int, bool> onSetup;
        [CompilerGenerated]
        private static Action<long> onChangeMaximumAvailableDiskSpace;
        public static long MaximumAvailableDiskSpace
        {
            set
            {
            }
        }

        public static long InfiniteAvailableDiskSpaced
        {
            get
            {
                return default(long);
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void OnInitialize()
        {
            _isDbUpdating = false;
            _isSetup = false;
            global::Campus.Common.Extensions.EnumerableExtensions.ForEach(Streams.Values, _003C_003Ec._003C_003E9__1_0 ??
                (_003C_003Ec._003C_003E9__1_0 = _003C_003Ec._003C_003E9._003COnInitialize_003Eb__1_0));
            Streams.Clear();
            onSetup = null;
        }

        private static int GetA(OctoEnvType env)
        {
            return default(int);
        }

        private static string GetB(OctoEnvType env)
        {
            return null;
        }

        private static string GetC(OctoEnvType env)
        {
            return null;
        }

        private static int GetD(OctoEnvType env, int version, [Optional] RuntimePlatform? platform)
        {
            return default(int);
        }

        private static string GetE(OctoEnvType env)
        {
            return null;
        }

        private static string GetF(OctoEnvType env)
        {
            return null;
        }

        private static AssetBundleCreateRequest AssetBundleLoadInterceptor(string abName, string path)
        {
            return null;
        }

        private static void OnAssetBundleUnloadCompleted(string abName)
        {
        }

        [AsyncStateMachine(typeof(_003CSetupAsync_003Ed__33))]
        public static UniTask<DownloadError> SetupAsync(OctoFullSettings settings, OctoEnvType env, int version, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool reset, [Optional] ILogger logger, bool setupOnly = false)
        {
            return default(UniTask<DownloadError>);
        }

        public static OctoFullSettings CreateSetting(OctoEnvType env, int version, [Optional] RuntimePlatform? platform)
        {
            return null;
        }
    }
}
