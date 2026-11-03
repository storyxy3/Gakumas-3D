namespace Qua.Global
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Global;
    using global::TMPro;

    public class ResourcesFontLoader : IFontLoader
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLoadAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<TMP_FontAsset> _003C_003Et__builder;
            public CancellationToken cancellationToken;
            public string loadKey;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CLoadAsync_003Ed__0))]
        public UniTask<TMP_FontAsset> LoadAsync(string loadKey, CancellationToken cancellationToken)
        {
            return default(UniTask<TMP_FontAsset>);
        }

        public void Unload(string loadKey, TMP_FontAsset loadedFontAsset)
        {
        }

        public ResourcesFontLoader()
        {
        }
    }
}
