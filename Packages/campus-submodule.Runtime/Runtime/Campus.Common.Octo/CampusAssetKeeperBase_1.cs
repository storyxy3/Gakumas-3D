namespace Campus.Common.Octo
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Octo;
    using global::UnityEngine;

    public class CampusAssetKeeperBase<T> : AssetKeeper where T : Object
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass19_0
        {
            public CancellationToken ct;
            public CampusAssetKeeperBase<T> _003C_003E4__this;
            public UniTaskCompletionSource completionSource;
            public string fallbackResourceName;
            public _003C_003Ec__DisplayClass19_0()
            {
            }

            internal void _003CDoLoadAssetAsync_003Eb__0(T asset, AssetLoaderError error)
            {
            }

            internal void _003CDoLoadAssetAsync_003Eb__1()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDoLoadAssetAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public CampusAssetKeeperBase<T> _003C_003E4__this;
            public string fallbackResourceName;
            public string assetBundleName;
            private CancellationTokenRegistration _003C_003E7__wrap1;
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
        private struct _003CLoadAssetByAssetNameAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public CampusAssetKeeperBase<T> _003C_003E4__this;
            public string assetBundleName;
            public CancellationToken ct;
            public string fallbackResourceName;
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
        private struct _003CLoadAssetByExAssetNameAsync_003Ed__17 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public string exAssetName;
            public CampusAssetKeeperBase<T> _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<T>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [CompilerGenerated]
        private bool _003CIsBusy_003Ek__BackingField;
        [CompilerGenerated]
        private T _003CAsset_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CRequestedAssetBundleName_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsSuccess_003Ek__BackingField;
        private CancellationTokenSource _cts;
        public bool IsBusy
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public T Asset
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public string RequestedAssetBundleName
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsSuccess
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        [AsyncStateMachine(typeof(CampusAssetKeeperBase<>._003CLoadAssetByExAssetNameAsync_003Ed__17))]
        public UniTask<T> LoadAssetByExAssetNameAsync(string exAssetName, CancellationToken ct)
        {
            return default(UniTask<T>);
        }

        [AsyncStateMachine(typeof(CampusAssetKeeperBase<>._003CLoadAssetByAssetNameAsync_003Ed__18))]
        public UniTask<T> LoadAssetByAssetNameAsync(string assetBundleName, string fallbackResourceName, CancellationToken ct)
        {
            return default(UniTask<T>);
        }

        [AsyncStateMachine(typeof(CampusAssetKeeperBase<>._003CDoLoadAssetAsync_003Ed__19))]
        private UniTask DoLoadAssetAsync(string assetBundleName, string fallbackResourceName, CancellationToken ct)
        {
            return default(UniTask);
        }

        public virtual void Unset()
        {
        }

        protected virtual void PreProcess()
        {
        }

        protected virtual void PostProcess(T asset, bool isCanceled)
        {
        }

        private static (string, string) GetAssetNames(string exAssetName)
        {
            return default((string, string));
        }

        private bool IsCancel(AssetLoaderError error)
        {
            return default(bool);
        }

        protected override void OnDisposed()
        {
        }

        protected virtual void Release()
        {
        }

        public CampusAssetKeeperBase()
        {
        }
    }
}
