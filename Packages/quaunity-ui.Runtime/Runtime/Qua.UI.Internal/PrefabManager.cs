namespace Qua.UI.Internal
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI.Internal;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class PrefabManager : Singleton<PrefabManager>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadPrefabAsync_003Ed__1<T> : IAsyncStateMachine where T : Object
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public string name;
            public PrefabManager _003C_003E4__this;
            public string category;
            public string categoryPath;
            public CancellationToken ct;
            private string _003CloadPath_003E5__2;
            private UniTask<T>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private Dictionary<string, Dictionary<string, Object>> _loadedCategoryObjects;
        [AsyncStateMachine(typeof(_003CLoadPrefabAsync_003Ed__1<>))]
        public UniTask<T> LoadPrefabAsync<T>(string category, string categoryPath, string name, CancellationToken ct)
            where T : Object
        {
            return default(UniTask<T>);
        }

        public T GetPrefab<T>(string category, [Optional] string name)
            where T : Object
        {
            return null;
        }

        public List<Object> GetCategoryPrefabs(string category)
        {
            return null;
        }

        public int GetCategoryPrefabsCount(string category)
        {
            return default(int);
        }

        public void UnloadCategory(string category)
        {
        }

        protected override void OnInitialize()
        {
        }

        protected override void OnFinalize()
        {
        }

        public PrefabManager()
        {
        }
    }
}
