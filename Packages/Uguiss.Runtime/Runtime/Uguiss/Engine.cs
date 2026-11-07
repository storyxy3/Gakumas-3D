namespace Uguiss
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Uguiss;
    using global::UnityEngine;
    using global::UnityEngine.Events;

    public class Engine : MonoBehaviour
    {
        public class ScriptEndEvent : UnityEvent
        {
            public ScriptEndEvent()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass41_0
        {
            public AbstractCommand command;
            public _003C_003Ec__DisplayClass41_0()
            {
            }

            internal bool _003CGetCommandIndex_003Eb__0(AbstractCommand x)
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CExecuteAsync_003Ed__46 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken token;
            public Engine _003C_003E4__this;
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
        private struct _003CGotoAsync_003Ed__47 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken token;
            public Engine _003C_003E4__this;
            public int index;
            public bool isPlay;
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
        private struct _003CLoadScriptAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Engine _003C_003E4__this;
            public string script;
            public CancellationToken token;
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
        private struct _003CPreExecuteAsync_003Ed__45 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Engine _003C_003E4__this;
            public CancellationToken token;
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
        protected CommandSetting commandSetting;
        protected Parser parser;
        protected Expression expression;
        protected ScriptEndEvent onScriptEnd;
        protected CancellationTokenSource cancellationTokenSource;
        protected List<AbstractCommand> commands;
        protected Dictionary<Type, AbstractManager> managers;
        [CompilerGenerated]
        private int _003CCurrentIndex_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsPlaying_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsSkip_003Ek__BackingField;
        public CommandSetting Setting
        {
            get
            {
                return null;
            }
        }

        public Parser Parser
        {
            get
            {
                return null;
            }
        }

        public Expression Expression
        {
            get
            {
                return null;
            }
        }

        public ScriptEndEvent OnScriptEnd
        {
            get
            {
                return null;
            }
        }

        public int CommandCount
        {
            get
            {
                return default(int);
            }
        }

        public int CurrentIndex
        {
            [CompilerGenerated]
            get
            {
                return _003CCurrentIndex_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CCurrentIndex_003Ek__BackingField = value;
            }
        }

        public bool IsPlaying
        {
            [CompilerGenerated]
            get
            {
                return _003CIsPlaying_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CIsPlaying_003Ek__BackingField = value;
            }
        }

        public bool IsSkip
        {
            [CompilerGenerated]
            get
            {
                return _003CIsSkip_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CIsSkip_003Ek__BackingField = value;
            }
        }

        public void LoadScript(string script)
        {
        }

        [AsyncStateMachine(typeof(_003CLoadScriptAsync_003Ed__31))]
        public virtual UniTask LoadScriptAsync(string script, [Optional] CancellationToken token)
        {
            return default(UniTask);
        }

        public void Play()
        {
        }

        public void Goto(int index, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool isPlay, [Optional] Action callback)
        {
        }

        public void Stop()
        {
        }

        public void Jump(int index)
        {
        }

        public void Skip(bool isSkip)
        {
        }

        public void End()
        {
        }

        public void Clear()
        {
        }

        public T GetManager<T>()
            where T : AbstractManager
        {
            return null;
        }

        public AbstractCommand GetCommand(int index)
        {
            return null;
        }

        public int GetCommandIndex(AbstractCommand command)
        {
            return default(int);
        }

        protected void RunAndForget(UniTask task, [Optional] Action callback)
        {
        }

        protected void DisposeCancellationTokenSource()
        {
        }

        protected CancellationToken RebuildCancellationTokenSource([Optional] CancellationToken baseToken)
        {
            return default(CancellationToken);
        }

        [AsyncStateMachine(typeof(_003CPreExecuteAsync_003Ed__45))]
        protected UniTask PreExecuteAsync(CancellationToken token)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__46))]
        protected UniTask ExecuteAsync(CancellationToken token)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CGotoAsync_003Ed__47))]
        protected virtual UniTask GotoAsync(int index, bool isPlay, CancellationToken token)
        {
            return default(UniTask);
        }

        protected virtual void OnLoad()
        {
        }

        protected virtual void OnPlay()
        {
        }

        protected virtual void OnStop()
        {
        }

        protected virtual void OnClear()
        {
        }

        public Engine()
        {
        }
    }
}
