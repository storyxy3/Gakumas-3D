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

    public abstract class TabBase<TTabButton, TTabPage> : QuaUIBehaviour where TTabButton : TabButtonBase where TTabPage : TabPageBase
    {
        public class TabData
        {
            [SerializeField]
            private TTabButton _button;
            [SerializeField]
            private TTabPage _page;
            public TTabButton Button
            {
                get
                {
                    return null;
                }
            }

            public TTabPage Page
            {
                get
                {
                    return null;
                }
            }

            public bool IsOpen
            {
                get
                {
                    return default(bool);
                }
            }

            public TabData(TTabButton button, TTabPage page)
            {
            }

            public TabData()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003COpenByIndexAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabBase<TTabButton, TTabPage> _003C_003E4__this;
            public CancellationToken ct;
            public int index;
            private TabData _003CtargetTabData_003E5__2;
            private List<TabPageBase> _003CcloseTargets_003E5__3;
            private CancellationTokenSource _003CchildCts_003E5__4;
            private CancellationToken _003CchildCt_003E5__5;
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
        private struct _003COpenTabInternalAsync_003Ed__13 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TabData targetTabData;
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

        protected readonly List<TabData> _tabs;
        protected bool _isOpenPhase;
        private CancellationTokenSource _innerCts;
        [AsyncStateMachine(typeof(TabBase<, >._003COpenByIndexAsync_003Ed__4))]
        public virtual UniTask OpenByIndexAsync(int index, CancellationToken ct)
        {
            return default(UniTask);
        }

        public TTabPage GetPage(int index)
        {
            return null;
        }

        public TTabButton GetButton(int index)
        {
            return null;
        }

        protected virtual void AfterEnabled()
        {
        }

        protected virtual void AfterDisabled()
        {
        }

        protected virtual void Cleanup()
        {
        }

        protected CancellationTokenSource CreateLinkedCts(CancellationToken ct)
        {
            return null;
        }

        protected void CancelManagedTasks()
        {
        }

        protected void ResetPhaseFlags()
        {
        }

        [AsyncStateMachine(typeof(TabBase<, >._003COpenTabInternalAsync_003Ed__13))]
        protected UniTask OpenTabInternalAsync(TabData targetTabData, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected TabBase()
        {
        }
    }
}
