namespace Campus.Titan
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common.Octo;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Titan;
    using global::UnityEngine;

    public class TitanAssetBundleLoader : MonoBehaviour
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAndInstantiateAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TitanPlayer> _003C_003Et__builder;
            public TitanAssetBundleLoader _003C_003E4__this;
            public string name;
            public CancellationToken ct;
            private UniTask<TitanPlayer>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadAndPlayAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<ITimelineTween> _003C_003Et__builder;
            public TitanAssetBundleLoader _003C_003E4__this;
            public string name;
            public CancellationToken ct;
            private UniTask<TitanPlayer>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TitanPlayer> _003C_003Et__builder;
            public TitanAssetBundleLoader _003C_003E4__this;
            public string name;
            public CancellationToken ct;
            private TaskAwaiter<GameObject> _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        private Transform _parent;
        private SimpleAssetKeeper _prefabKeeper;
        [AsyncStateMachine(typeof(_003CLoadAndPlayAsync_003Ed__2))]
        public UniTask<ITimelineTween> LoadAndPlayAsync(string name, CancellationToken ct)
        {
            return default(UniTask<ITimelineTween>);
        }

        [AsyncStateMachine(typeof(_003CLoadAndInstantiateAsync_003Ed__3))]
        public UniTask<TitanPlayer> LoadAndInstantiateAsync(string name, CancellationToken ct)
        {
            return default(UniTask<TitanPlayer>);
        }

        [AsyncStateMachine(typeof(_003CLoadAsync_003Ed__4))]
        public UniTask<TitanPlayer> LoadAsync(string name, CancellationToken ct)
        {
            return default(UniTask<TitanPlayer>);
        }

        public TitanAssetBundleLoader()
        {
        }
    }
}
