namespace Campus.Common.Octo
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Octo;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;

    public class ReusableAssetKeeper : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass5_0<T>
            where T : Object
        {
            public SimpleAssetKeeper keeper;
            public _003C_003Ec__DisplayClass5_0()
            {
            }

            internal bool _003CLoadAssetAsync_003Eb__0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetAsync_003Ed__5<T> : IAsyncStateMachine where T : Object
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public string exAssetName;
            public ReusableAssetKeeper _003C_003E4__this;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass5_0<T> _003C_003E8__1;
            private UniTask.Awaiter _003C_003Eu__1;
            private UniTask<Object>.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private Dictionary<string, SimpleAssetKeeper> _assetTable;
        private LRUCache<string, SimpleAssetKeeper> _lruCache;
        private Queue<SimpleAssetKeeper> _reusableKeeperQueue;
        private bool _hasCapacity;
        public void Initialize(int capacity = 0)
        {
        }

        [AsyncStateMachine(typeof(_003CLoadAssetAsync_003Ed__5<>))]
        public UniTask<T> LoadAssetAsync<T>(string exAssetName, CancellationToken ct)
            where T : Object
        {
            return default(UniTask<T>);
        }

        public T GetAsset<T>(string exAssetName)
            where T : Object
        {
            return null;
        }

        public bool IsLoadEnd()
        {
            return default(bool);
        }

        public void Clear(IEnumerable<string> exAssetNames)
        {
        }

        public void Clear(string exAssetName)
        {
        }

        public void AllClear()
        {
        }

        private SimpleAssetKeeper GetAssetKeeper(string exAssetName)
        {
            return null;
        }

        private SimpleAssetKeeper CreateAssetKeeper(string exAssetName)
        {
            return null;
        }

        private void CacheAssetKeeper(string exAssetName, SimpleAssetKeeper keeper)
        {
        }

        public ReusableAssetKeeper()
        {
        }

        [CompilerGenerated]
        private void _003CInitialize_003Eb__4_0(SimpleAssetKeeper keeper)
        {
        }
    }
}
