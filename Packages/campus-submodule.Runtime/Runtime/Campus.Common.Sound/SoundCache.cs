namespace Campus.Common.Sound
{
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Sound;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Octo;

    public class SoundCache
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass16_0
        {
            public UniTaskCompletionSource<string> utcs;
            public CancellationToken ct;
            public CancellationTokenRegistration onCancel;
            public string resourceName;
            public _003C_003Ec__DisplayClass16_0()
            {
            }

            internal void _003CDownloadAsync_003Eb__0()
            {
            }

            internal void _003CDownloadAsync_003Eb__1(DownloadError error)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDownloadCueSheetAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<(string acbPath, string awbPath)> _003C_003Et__builder;
            public SoundInfo info;
            public CancellationToken ct;
            private UniTask<(string, string)>.Awaiter _003C_003Eu__1;
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
        private struct _003CInitializeAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SoundCache _003C_003E4__this;
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
        private struct _003CLoadAcfAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            private UniTask<string>.Awaiter _003C_003Eu__1;
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
        private struct _003CLoadCueSheetAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SoundCache _003C_003E4__this;
            public SoundInfo info;
            public CancellationToken ct;
            private UniTask<(string acbPath, string awbPath)>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private Dictionary<string, int> _refMap;
        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__1))]
        public UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadAcfAsync_003Ed__2))]
        private UniTask LoadAcfAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CLoadCueSheetAsync_003Ed__3))]
        public UniTask LoadCueSheetAsync(SoundInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public bool LoadCueSheet(SoundInfo info)
        {
            return default(bool);
        }

        private static (string, string) GetSoundPath(SoundInfo info)
        {
            return default((string, string));
        }

        [AsyncStateMachine(typeof(_003CDownloadCueSheetAsync_003Ed__6))]
        public UniTask<(string, string)> DownloadCueSheetAsync(SoundInfo info, CancellationToken ct)
        {
            return default(UniTask<(string, string)>);
        }

        public bool IsDownloaded(SoundInfo info)
        {
            return default(bool);
        }

        public void UnloadCueSheet(SoundInfo info)
        {
        }

        public void UnloadEmptyRef()
        {
        }

        private int IncreaseRefCount(string cueSheetName)
        {
            return default(int);
        }

        private int DecreaseRefCount(string cueSheetName)
        {
            return default(int);
        }

        private bool ExistsCueSheet(string cueSheetName)
        {
            return default(bool);
        }

        public bool ExistsCue(SoundInfo info)
        {
            return default(bool);
        }

        private static bool HasAwb(string awbName)
        {
            return default(bool);
        }

        private static UniTask<string> DownloadAsync(string resourceName, CancellationToken ct)
        {
            return default(UniTask<string>);
        }

        public SoundCache()
        {
        }
    }
}
