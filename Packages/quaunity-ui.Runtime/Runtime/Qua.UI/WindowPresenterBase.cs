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

    public abstract class WindowPresenterBase : WindowNode
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CApplyTransitionAsync_003Ed__37 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
            public CancellationToken ct;
            private bool _003CwillClose_003E5__2;
            private bool _003CwillOpen_003E5__3;
            private WindowNode _003CnodeToDestroy_003E5__4;
            private int _003Ccount_003E5__5;
            private UniTask.Awaiter _003C_003Eu__1;
            private int _003Ci_003E5__6;
            private TransitionNode[] _003Cchildren_003E5__7;
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
        private struct _003CCloseChildrenAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public int count;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionOptionalData optionalData;
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
        private struct _003CCreateNodeAsync_003Ed__44 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<WindowNode> _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public IWindowNodeState state;
            public CancellationToken ct;
            public Transform parent;
            private UniTask<WindowNode>.Awaiter _003C_003Eu__1;
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
        private struct _003CGetNodePrefabFromStateAsync_003Ed__45 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<WindowNode> _003C_003Et__builder;
            public IWindowNodeState state;
            public CancellationToken ct;
            private UniTask<WindowNode>.Awaiter _003C_003Eu__1;
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
        private struct _003CInitializeBaseAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionParam param;
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
        private struct _003COnBehindCloseAsync_003Ed__23 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
            public CancellationToken ct;
            private int _003Ci_003E5__2;
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
        private struct _003COnCloseInAsync_003Ed__20 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
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
        private struct _003COnCloseOutAsync_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            private int _003Ci_003E5__2;
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
        private struct _003COnOpenOutAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
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
        private struct _003COpenChildAsync_003Ed__39 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<WindowNode> _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public IWindowNodeState state;
            public CancellationToken ct;
            public TransitionParam param;
            public TransitionInfo info;
            private WindowNode _003CtargetNode_003E5__2;
            private UniTask<WindowNode>.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
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
        private struct _003COpenNodeAsync_003Ed__38 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TransitionNode node;
            public bool isTop;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionInfo info;
            public CancellationToken ct;
            private bool _003CisLeaf_003E5__2;
            private WindowPresenterBase _003Cwindow_003E5__3;
            private TransitionNode[] _003Cchildren_003E5__4;
            private UniTask<WindowNode>.Awaiter _003C_003Eu__1;
            private int _003Ci_003E5__5;
            private UniTask.Awaiter _003C_003Eu__2;
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
        private struct _003COpenTreeAsync_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TransitionTree tree;
            public TransitionOptionalData optionalData;
            public WindowPresenterBase _003C_003E4__this;
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
        private struct _003CPreparePoolAsync_003Ed__36 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<WindowNode> _003C_003Et__builder;
            public WindowPresenterBase _003C_003E4__this;
            public IWindowNodeState state;
            public CancellationToken ct;
            private WindowNode _003Cnode_003E5__2;
            private UniTask<WindowNode>.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
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
        private struct _003CSwitchAsync_003Ed__33 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public IWindowNodeState parentState;
            public WindowPresenterBase _003C_003E4__this;
            public TransitionTree tree;
            public TransitionOptionalData optionalData;
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

        private List<WindowNode> _children;
        private bool _isBusyRoot;
        [CompilerGenerated]
        private readonly IWindowNodePool _003CWindowNodePool_003Ek__BackingField;
        public sealed override WindowNodeType NodeType
        {
            get
            {
                return default(WindowNodeType);
            }
        }

        public List<WindowNode> Children
        {
            get
            {
                return null;
            }
        }

        public int ChildCount
        {
            get
            {
                return default(int);
            }
        }

        protected bool IsBusyTree
        {
            get
            {
                return default(bool);
            }

            private set
            {
            }
        }

        public sealed override ScreenPresenterBase TopScreen
        {
            get
            {
                return null;
            }
        }

        public WindowNode TopNode
        {
            get
            {
                return null;
            }
        }

        public virtual IWindowNodePool WindowNodePool
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeBaseAsync_003Ed__18))]
        public override UniTask InitializeBaseAsync(TransitionParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COnOpenOutAsync_003Ed__19))]
        public override UniTask OnOpenOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COnCloseInAsync_003Ed__20))]
        public override UniTask OnCloseInAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public override void OnEndCloseIn(TransitionInfo info)
        {
        }

        [AsyncStateMachine(typeof(_003COnCloseOutAsync_003Ed__22))]
        public override UniTask OnCloseOutAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COnBehindCloseAsync_003Ed__23))]
        public override UniTask OnBehindCloseAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COpenTreeAsync_003Ed__24))]
        public UniTask OpenTreeAsync(TransitionTree tree, TransitionOptionalData optionalData, CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OpenTreeAsync(TransitionTree tree, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void OpenTree(TransitionTree tree, [Optional] TransitionOptionalData optionalData)
        {
        }

        public UniTask CloseChildAsync(TransitionOptionalData optionalData, CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask CloseChildAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void CloseChild([Optional] TransitionOptionalData optionalData)
        {
        }

        [AsyncStateMachine(typeof(_003CCloseChildrenAsync_003Ed__30))]
        public UniTask CloseChildrenAsync(int count, TransitionOptionalData optionalData, CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask CloseChildrenAsync(int count, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void CloseChildren(int count, [Optional] TransitionOptionalData optionalData)
        {
        }

        [AsyncStateMachine(typeof(_003CSwitchAsync_003Ed__33))]
        public UniTask SwitchAsync(TransitionTree tree, IWindowNodeState parentState, TransitionOptionalData optionalData, CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask SwitchAsync(TransitionTree tree, IWindowNodeState parentState, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Switch(TransitionTree tree, IWindowNodeState parentState, [Optional] TransitionOptionalData optionalData)
        {
        }

        [AsyncStateMachine(typeof(_003CPreparePoolAsync_003Ed__36))]
        public UniTask<WindowNode> PreparePoolAsync(IWindowNodeState state, CancellationToken ct)
        {
            return default(UniTask<WindowNode>);
        }

        [AsyncStateMachine(typeof(_003CApplyTransitionAsync_003Ed__37))]
        protected virtual UniTask ApplyTransitionAsync(TransitionInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COpenNodeAsync_003Ed__38))]
        private UniTask OpenNodeAsync(TransitionInfo info, TransitionNode node, bool isTop, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003COpenChildAsync_003Ed__39))]
        private UniTask<WindowNode> OpenChildAsync(TransitionInfo info, IWindowNodeState state, TransitionParam param, CancellationToken ct)
        {
            return default(UniTask<WindowNode>);
        }

        protected void PopChild()
        {
        }

        private void DestroyNode(WindowNode node, bool shouldDestroy = true)
        {
        }

        protected WindowNode PopChildWithoutDestroy()
        {
            return null;
        }

        protected void PushChild(WindowNode node)
        {
        }

        [AsyncStateMachine(typeof(_003CCreateNodeAsync_003Ed__44))]
        protected virtual UniTask<WindowNode> CreateNodeAsync(IWindowNodeState state, Transform parent, CancellationToken ct)
        {
            return default(UniTask<WindowNode>);
        }

        [AsyncStateMachine(typeof(_003CGetNodePrefabFromStateAsync_003Ed__45))]
        protected virtual UniTask<WindowNode> GetNodePrefabFromStateAsync(IWindowNodeState state, CancellationToken ct)
        {
            return default(UniTask<WindowNode>);
        }

        protected abstract Transform GetNodeRoot();
        protected virtual void OnNodeWillChange()
        {
        }

        protected virtual void OnNodeDidChange()
        {
        }

        protected WindowPresenterBase()
        {
        }
    }
}
