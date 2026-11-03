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
    using global::UnityEngine;

    public abstract class DynamicTabBase<TTabElement, TTabButton, TTabPage> : TabBase<TTabButton, TTabPage> where TTabButton : GenericTabButtonBase<TTabElement> where TTabPage : GenericTabPageBase<TTabElement>
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CAddTabAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TTabElement item;
            public DynamicTabBase<TTabElement, TTabButton, TTabPage> _003C_003E4__this;
            public CancellationToken ct;
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
        private struct _003CBuildTabsAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public DynamicTabBase<TTabElement, TTabButton, TTabPage> _003C_003E4__this;
            public CancellationToken ct;
            public IEnumerable<TTabElement> tabItems;
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
        protected Transform _pageContainer;
        [SerializeField]
        protected Transform _buttonContainer;
        [AsyncStateMachine(typeof(DynamicTabBase<,, >._003CBuildTabsAsync_003Ed__2))]
        public UniTask BuildTabsAsync(IEnumerable<TTabElement> tabItems, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(DynamicTabBase<,, >._003CAddTabAsync_003Ed__3))]
        private UniTask AddTabAsync(TTabElement item, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void DestroyTabs()
        {
        }

        protected abstract TTabButton CreateButton(TTabElement item);
        protected abstract TTabPage CreatePage(TTabElement item, GenericTabButtonBase<TTabElement> button);
        protected virtual void AddButtonToHierarchy(GenericTabButtonBase<TTabElement> button)
        {
        }

        protected virtual void AddPageToHierarchy(GenericTabPageBase<TTabElement> page)
        {
        }

        protected virtual void OnBeforeBuildTabs()
        {
        }

        protected virtual void OnAfterBuildTabs()
        {
        }

        protected virtual void OnCleanup()
        {
        }

        protected sealed override void Cleanup()
        {
        }

        private void SetParent(Component child, Transform parent)
        {
        }

        protected DynamicTabBase()
        {
        }
    }
}
