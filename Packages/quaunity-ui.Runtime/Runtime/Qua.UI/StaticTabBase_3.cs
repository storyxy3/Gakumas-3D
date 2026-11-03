namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::Qua.UI.Internal;
    using global::UnityEngine;

    public class StaticTabBase<T, TTabButton, TTabPage> : TabBase<TTabButton, TTabPage> where TTabButton : GenericTabButtonBase<T> where TTabPage : GenericTabPageBase<T>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public int index;
            public StaticTabBase<T, TTabButton, TTabPage> _003C_003E4__this;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal void _003CBindTabButtonCallback_003Eb__0()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public StaticTabBase<T, TTabButton, TTabPage> _003C_003E4__this;
            public CancellationToken ct;
            public Dictionary<int, T> tabParams;
            private CancellationTokenSource _003CchildCts_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        protected List<TabPageButtonPair> _prepareTabs;
        [AsyncStateMachine(typeof(StaticTabBase<,, >._003CInitializeAsync_003Ed__1))]
        public virtual UniTask InitializeAsync(Dictionary<int, T> tabParams, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void BindTabButtonCallback()
        {
        }

        public StaticTabBase()
        {
        }
    }
}
