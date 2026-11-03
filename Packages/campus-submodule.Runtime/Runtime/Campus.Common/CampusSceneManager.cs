namespace Campus.Common
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::UnityEngine;
    using global::UnityEngine.SceneManagement;

    public class CampusSceneManager : Singleton<CampusSceneManager>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass26_0
        {
            public AsyncOperation ope;
            public CampusSceneManager _003C_003E4__this;
            public CampusLoadAsyncSceneParam param;
            public CancellationToken ct;
            public Action<Exception> _003C_003E9__2;
            public _003C_003Ec__DisplayClass26_0()
            {
            }

            internal bool _003CLoadSceneAsync_003Eb__0()
            {
                return default(bool);
            }

            internal void _003CLoadSceneAsync_003Eb__1(AsyncOperation operation)
            {
            }

            internal void _003CLoadSceneAsync_003Eb__2(Exception ex)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInvokeTaskAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<CancellationToken, UniTask> task;
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
        private struct _003CLoadSceneAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public CampusSceneManager _003C_003E4__this;
            public string sceneName;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public CampusSceneManager _003C_003E4__this;
            public int sceneBuildIndex;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__20 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public CampusSceneManager _003C_003E4__this;
            public string sceneName;
            public LoadSceneMode mode;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__21 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public CampusSceneManager _003C_003E4__this;
            public int sceneBuildIndex;
            public LoadSceneMode mode;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public string sceneName;
            public LoadSceneMode mode;
            public bool allowSceneActivation;
            public Func<CancellationToken, UniTask> onActivation;
            public CampusSceneManager _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__23 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public string sceneName;
            public LoadSceneMode mode;
            public bool allowSceneActivation;
            public Action onActivation;
            public CampusSceneManager _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public int sceneBuildIndex;
            public LoadSceneMode mode;
            public bool allowSceneActivation;
            public Func<CancellationToken, UniTask> onActivation;
            public CampusSceneManager _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__25 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public int sceneBuildIndex;
            public LoadSceneMode mode;
            public bool allowSceneActivation;
            public Action onActivation;
            public CampusSceneManager _003C_003E4__this;
            public CancellationToken ct;
            private UniTask<AsyncOperation>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadSceneAsync_003Ed__26 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<AsyncOperation> _003C_003Et__builder;
            public CampusSceneManager _003C_003E4__this;
            public CampusLoadAsyncSceneParam param;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;
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
        private struct _003COnCompleteActivationAsync_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public CampusSceneManager _003C_003E4__this;
            public CampusLoadAsyncSceneParam param;
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
        private struct _003CUnloadSceneAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string sceneName;
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
        private struct _003CUnloadSceneAsync_003Ed__33 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public int sceneBuildIndex;
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

        [CompilerGenerated]
        private ILogger _003CLogger_003Ek__BackingField;
        [CompilerGenerated]
        private object _003CTransitionData_003Ek__BackingField;
        public Action<object> onLoadSceneCallback;
        public ILogger Logger
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public object TransitionData
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        public Scene GetActiveScene()
        {
            return default(Scene);
        }

        protected override void OnInitialize()
        {
        }

        protected override void OnFinalize()
        {
        }

        private void SetEvent()
        {
        }

        private void OnNeedsRetetrahedralization()
        {
        }

        public void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
        {
        }

        public void LoadScene(int sceneBuildIndex, LoadSceneMode mode = LoadSceneMode.Single)
        {
        }

        public void LoadScene(CampusLoadSceneParam param)
        {
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__18))]
        public UniTask<AsyncOperation> LoadSceneAsync(string sceneName, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__19))]
        public UniTask<AsyncOperation> LoadSceneAsync(int sceneBuildIndex, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__20))]
        public UniTask<AsyncOperation> LoadSceneAsync(string sceneName, LoadSceneMode mode, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__21))]
        public UniTask<AsyncOperation> LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__22))]
        public UniTask<AsyncOperation> LoadSceneAsync(string sceneName, LoadSceneMode mode, bool allowSceneActivation, Func<CancellationToken, UniTask> onActivation, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__23))]
        public UniTask<AsyncOperation> LoadSceneAsync(string sceneName, LoadSceneMode mode, bool allowSceneActivation, Action onActivation, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__24))]
        public UniTask<AsyncOperation> LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode, bool allowSceneActivation, Func<CancellationToken, UniTask> onActivation, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__25))]
        public UniTask<AsyncOperation> LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode, bool allowSceneActivation, Action onActivation, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__26))]
        public UniTask<AsyncOperation> LoadSceneAsync(CampusLoadAsyncSceneParam param, CancellationToken ct)
        {
            return default(UniTask<AsyncOperation>);
        }

        [AsyncStateMachine(typeof(_003COnCompleteActivationAsync_003Ed__27))]
        private UniTask OnCompleteActivationAsync(CampusLoadAsyncSceneParam param, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void Log(string text)
        {
        }

        private void LogError(string err)
        {
        }

        private void LogException(Exception err)
        {
        }

        [AsyncStateMachine(typeof(_003CInvokeTaskAsync_003Ed__31))]
        private static UniTask InvokeTaskAsync(Func<CancellationToken, UniTask> task, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CUnloadSceneAsync_003Ed__32))]
        public UniTask UnloadSceneAsync(string sceneName, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CUnloadSceneAsync_003Ed__33))]
        public UniTask UnloadSceneAsync(int sceneBuildIndex, CancellationToken ct)
        {
            return default(UniTask);
        }

        public CampusSceneManager()
        {
        }
    }
}
