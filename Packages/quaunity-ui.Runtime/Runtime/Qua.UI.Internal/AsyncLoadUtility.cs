namespace Qua.UI.Internal
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    internal static class AsyncLoadUtility
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAssetAsync_003Ed__0<T> : IAsyncStateMachine where T : Object
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;
            public string filePath;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CLoadAssetAsync_003Ed__0<>))]
        public static UniTask<T> LoadAssetAsync<T>(string filePath, CancellationToken ct)
            where T : Object
        {
            return default(UniTask<T>);
        }
    }
}
