namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Text.RegularExpressions;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Sound;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.Utility;
    using global::UnityEngine;

    public class CampusSoundManager : Singleton<CampusSoundManager>
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass13_0
        {
            public CampusSoundPlayer player;
            public _003C_003Ec__DisplayClass13_0()
            {
            }

            internal void _003CSwitchBgmAsync_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass24_0
        {
            public CampusSoundPlayer player;
            public CampusSoundManager _003C_003E4__this;
            public Action onReturn;
            public _003C_003Ec__DisplayClass24_0()
            {
            }

            internal void _003C_PlaySingleAsync_003Eb__0()
            {
            }

            internal void _003C_PlaySingleAsync_003Eb__1()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass25_0
        {
            public CampusSoundPlayer player;
            public CampusSoundManager _003C_003E4__this;
            public _003C_003Ec__DisplayClass25_0()
            {
            }

            internal void _003C_PreloadAsync_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass26_0
        {
            public CampusSoundPlayer player;
            public CampusSoundManager _003C_003E4__this;
            public _003C_003Ec__DisplayClass26_0()
            {
            }

            internal void _003C_Preload_003Eb__0()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass65_0
        {
            public bool enableLipSync;
            public ICampusActorController actor;
            public _003C_003Ec__DisplayClass65_0()
            {
            }

            internal void _003CPlayVoiceAsync_003Eb__0(CampusSoundPlayer player)
            {
            }

            internal void _003CPlayVoiceAsync_003Eb__1()
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPauseBgmAsync_003Ed__18 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public CancellationToken ct;
            private CampusSoundPlayer _003CprevPlayer_003E5__2;
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
        private struct _003CPlayBgmOnceAsync_003Ed__46 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<CampusSoundPlayer> _003C_003Et__builder;
            public SoundInfo info;
            public CancellationToken ct;
            public long startTimeMs;
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
        private struct _003CReturnScheduleAsync_003Ed__16 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundPlayer player;
            public CancellationToken ct;
            public CampusSoundManager _003C_003E4__this;
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
        private struct _003CStopBgmAsync_003Ed__22 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public CancellationToken ct;
            private CampusSoundPlayer _003CprevPlayer_003E5__2;
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
        private struct _003CSwitchBgmAsync_003Ed__13 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundPlayer player;
            public CampusSoundManager _003C_003E4__this;
            public CancellationToken ct;
            private CampusSoundPlayer _003CprevPlayer_003E5__2;
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
        private struct _003CUnpauseBgmAsync_003Ed__20 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
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
        private struct _003C_DownloadAsync_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SoundInfo info;
            public CampusSoundManager _003C_003E4__this;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003C_InitializeAsync_003Ed__8 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
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
        private struct _003C_PlayBgmAsync_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public SoundInfo info;
            public CancellationToken ct;
            public bool loop;
            public long startTimeMs;
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
        private struct _003C_PlaySingleAsync_003Ed__24 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public Action onReturn;
            public SoundInfo info;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;
            public bool loop;
            public float volume;
            public GameObject bindTarget;
            public Action<CampusSoundPlayer> onBeforePlay;
            public bool waitPlayEnd;
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
        private struct _003C_PreloadAsync_003Ed__25 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<ICampusSoundPlayer> _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public SoundInfo info;
            public CancellationToken ct;
            private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;
            public bool loop;
            public GameObject bindTarget;
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
        private struct _003C_SetCurrentBgmPlayer_003Ed__14 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncVoidMethodBuilder _003C_003Et__builder;
            public CampusSoundManager _003C_003E4__this;
            public CampusSoundPlayer player;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private bool _isInitialized;
        private SoundCache _cache;
        private SimpleComponentPool<CampusSoundPlayer> _playerPool;
        private HashSet<int> _playerPoolHashes;
        private (SoundInfo info, CampusSoundPlayer player) _currentBgm;
        private CancellationTokenSource _bgmCts;
        private bool _isBgmStopping;
        private static readonly Regex SeRegex;
        [CompilerGenerated]
        private static Action<string> m_onSoundPlayed;
        public static SoundCache SoundCache
        {
            get
            {
                return null;
            }
        }

        public static bool IsInitialized
        {
            get
            {
                return default(bool);
            }
        }

        public static string CurrentBgm
        {
            get
            {
                return null;
            }
        }

        public static event Action<string> onSoundPlayed
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        protected override bool IsDontDestroy()
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003C_InitializeAsync_003Ed__8))]
        private UniTask _InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private bool CheckInitializeState()
        {
            return default(bool);
        }

        private void OnSoundPlayed(string cueName)
        {
        }

        [AsyncStateMachine(typeof(_003C_PlayBgmAsync_003Ed__11))]
        private UniTask _PlayBgmAsync(SoundInfo info, CancellationToken ct, bool loop = true, long startTimeMs = 0L)
        {
            return default(UniTask);
        }

        private bool CheckCurrentBgm(SoundInfo info)
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003CSwitchBgmAsync_003Ed__13))]
        private UniTask SwitchBgmAsync(CampusSoundPlayer player, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003C_SetCurrentBgmPlayer_003Ed__14))]
        private void _SetCurrentBgmPlayer(CampusSoundPlayer player)
        {
        }

        private void ReturnSchedule(CampusSoundPlayer player)
        {
        }

        [AsyncStateMachine(typeof(_003CReturnScheduleAsync_003Ed__16))]
        private UniTask ReturnScheduleAsync(CampusSoundPlayer player, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void _PauseBgm()
        {
        }

        [AsyncStateMachine(typeof(_003CPauseBgmAsync_003Ed__18))]
        private UniTask PauseBgmAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private void _UnpauseBgm()
        {
        }

        [AsyncStateMachine(typeof(_003CUnpauseBgmAsync_003Ed__20))]
        private UniTask UnpauseBgmAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private void _StopBgm()
        {
        }

        [AsyncStateMachine(typeof(_003CStopBgmAsync_003Ed__22))]
        private UniTask StopBgmAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private void _StopAll()
        {
        }

        [AsyncStateMachine(typeof(_003C_PlaySingleAsync_003Ed__24))]
        private UniTask _PlaySingleAsync(SoundInfo info, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(true)] bool waitPlayEnd, [Optional] Action<CampusSoundPlayer> onBeforePlay, [Optional] Action onReturn, float volume = 1f)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003C_PreloadAsync_003Ed__25))]
        private UniTask<ICampusSoundPlayer> _PreloadAsync(SoundInfo info, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget)
        {
            return default(UniTask<ICampusSoundPlayer>);
        }

        private ICampusSoundPlayer _Preload(SoundInfo info, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget)
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003C_DownloadAsync_003Ed__27))]
        private UniTask _DownloadAsync(SoundInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        private void _SetVolume(SoundEnum.SoundVolumeType volumeType, float volume)
        {
        }

        public static UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public static SoundInfo CreateSoundInfo(string assetName)
        {
            return default(SoundInfo);
        }

        public static void PlayBgm(string assetName)
        {
        }

        public static void PlayBgm(string assetName, bool loop, long startTimeMs)
        {
        }

        public static void PlayBgm(SoundInfo info, bool loop, long startTimeMs)
        {
        }

        public static UniTask<CampusSoundPlayer> PlayBgmOnceAsync(string assetName, CancellationToken ct, long startTimeMs = 0L)
        {
            return default(UniTask<CampusSoundPlayer>);
        }

        [AsyncStateMachine(typeof(_003CPlayBgmOnceAsync_003Ed__46))]
        public static UniTask<CampusSoundPlayer> PlayBgmOnceAsync(SoundInfo info, CancellationToken ct, long startTimeMs = 0L)
        {
            return default(UniTask<CampusSoundPlayer>);
        }

        public static void PauseBgm()
        {
        }

        public static void UnpauseBgm()
        {
        }

        public static void StopBgm()
        {
        }

        public static void SetCurrentBgmPlayer(CampusSoundPlayer soundPlayer)
        {
        }

        public static CampusSoundPlayer GetCurrentBgmPlayer()
        {
            return null;
        }

        public static void PlaySe(string assetName, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget)
        {
        }

        public static void PlaySe(string assetName, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget, float volume = 1f)
        {
        }

        public static UniTask PlaySeAsync(string assetName, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget, bool waitPlayEnd = true, float volume = 1f)
        {
            return default(UniTask);
        }

        public static UniTask PlaySeAsync(SoundInfo info, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget, bool waitPlayEnd = true, float volume = 1f)
        {
            return default(UniTask);
        }

        public static void PlaySe(SoundEnum.SoundEffectType type, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget)
        {
        }

        public static void PlaySe(SoundEnum.SoundEffectType type, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget)
        {
        }

        public static UniTask PlaySeAsync(SoundEnum.SoundEffectType type, CancellationToken ct, [global::System.Runtime.InteropServices.Optional, global::System.Runtime.InteropServices.DefaultParameterValue(false)] bool loop, [Optional] GameObject bindTarget, bool waitPlayEnd = true)
        {
            return default(UniTask);
        }

        public static void PlayVoice(string assetName, [Optional] GameObject bindTarget)
        {
        }

        public static void PlayVoice(string assetName, CancellationToken ct, [Optional] GameObject bindTarget)
        {
        }

        public static UniTask PlayVoiceAsync(string assetName, CancellationToken ct, [Optional] GameObject bindTarget, bool waitPlayEnd = true)
        {
            return default(UniTask);
        }

        public static UniTask PlayVoiceAsync(SoundInfo info, CancellationToken ct, [Optional] GameObject bindTarget, bool waitPlayEnd = true)
        {
            return default(UniTask);
        }

        public static void PlayVoice(string assetName, ICampusActorController actor, [Optional] GameObject bindTarget)
        {
        }

        public static UniTask PlayVoiceAsync(string assetName, ICampusActorController actor, CancellationToken ct, [Optional] GameObject bindTarget, bool waitPlayEnd = true, bool enableLipSync = true)
        {
            return default(UniTask);
        }

        public static UniTask PlayVoiceAsync(SoundInfo info, ICampusActorController actor, CancellationToken ct, [Optional] GameObject bindTarget, bool waitPlayEnd = true, bool enableLipSync = true)
        {
            return default(UniTask);
        }

        public static UniTask<ICampusSoundPlayer> PreloadAsync(string assetName, CancellationToken ct, [Optional] GameObject bindTarget, bool loop = false)
        {
            return default(UniTask<ICampusSoundPlayer>);
        }

        public static UniTask<ICampusSoundPlayer> PreloadAsync(SoundInfo info, CancellationToken ct, [Optional] GameObject bindTarget, bool loop = false)
        {
            return default(UniTask<ICampusSoundPlayer>);
        }

        public static ICampusSoundPlayer Preload(string assetName, CancellationToken ct, [Optional] GameObject bindTarget, bool loop = false)
        {
            return null;
        }

        public static ICampusSoundPlayer Preload(SoundInfo info, CancellationToken ct, [Optional] GameObject bindTarget, bool loop = false)
        {
            return null;
        }

        public static UniTask DownloadAsync(string assetName, CancellationToken ct)
        {
            return default(UniTask);
        }

        public static UniTask DownloadAsync(SoundInfo info, CancellationToken ct)
        {
            return default(UniTask);
        }

        public static void StopAll()
        {
        }

        private static CancellationToken GetCt()
        {
            return default(CancellationToken);
        }

        public static void SetVolume(SoundEnum.SoundVolumeType volumeType, float volume)
        {
        }

        public CampusSoundManager()
        {
        }

        [CompilerGenerated]
        private CampusSoundPlayer _003C_InitializeAsync_003Eb__8_0()
        {
            return null;
        }

        [CompilerGenerated]
        private void _003C_InitializeAsync_003Eb__8_1(CampusSoundPlayer player)
        {
        }

        [CompilerGenerated]
        private void _003C_InitializeAsync_003Eb__8_2(CampusSoundPlayer player)
        {
        }

        [CompilerGenerated]
        private bool _003C_PlayBgmAsync_003Eb__11_0()
        {
            return default(bool);
        }
    }
}
