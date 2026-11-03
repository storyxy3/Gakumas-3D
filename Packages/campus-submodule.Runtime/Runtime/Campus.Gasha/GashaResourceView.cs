namespace Campus.Gasha
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Campus.Gasha;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(RawImage))]
    public class GashaResourceView : ImageResourceViewBase<Texture2D, RawImage>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Texture2D> _003C_003Et__builder;
            public string exAssetName;
            public GashaResourceView _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<Texture2D>.Awaiter _003C_003Eu__1;
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
        private struct _003CSetAsync_003Ed__5 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<Texture2D> _003C_003Et__builder;
            public string assetName;
            public GashaResourceView _003C_003E4__this;
            public string fallbackAssetName;
            public CancellationToken ct;
            private UniTask<Texture2D>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        private string _debugAssetName;
        protected override void OnAwake()
        {
        }

        private void OnValidate()
        {
        }

        protected override void ApplyAsset(Texture2D asset, RawImage component)
        {
        }

        [AsyncStateMachine(typeof(_003CSetAsync_003Ed__4))]
        public override UniTask<Texture2D> SetAsync(string exAssetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }

        [AsyncStateMachine(typeof(_003CSetAsync_003Ed__5))]
        public override UniTask<Texture2D> SetAsync(string assetName, string fallbackAssetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }

        public GashaResourceView()
        {
        }

        [CompilerGenerated]
        [DebuggerHidden]
        private UniTask<Texture2D> _003C_003En__0(string exAssetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }

        [CompilerGenerated]
        [DebuggerHidden]
        private UniTask<Texture2D> _003C_003En__1(string assetName, string fallbackAssetName, CancellationToken ct)
        {
            return default(UniTask<Texture2D>);
        }
    }
}
