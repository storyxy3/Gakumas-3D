namespace Campus.Common.Sound
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::CriWare;
    using global::Cysharp.Threading.Tasks;
    using global::DG.Tweening;
    using global::UniRx;
    using global::UnityEngine;

    public class CampusSoundPlayer : MonoBehaviour, ICampusSoundPlayer
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass30_0
        {
            public int time;
            public _003C_003Ec__DisplayClass30_0()
            {
            }

            internal bool _003CPlayWithStartTime_003Eb__0(long x)
            {
                return default(bool);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass49_0
        {
            public int time;
            public _003C_003Ec__DisplayClass49_0()
            {
            }

            internal bool _003CPrepare_003Eb__0(long x)
            {
                return default(bool);
            }
        }

        private CriAtomSource _source;
        private SoundInfo _soundInfo;
        private CancellationTokenSource _cancelCts;
        private CompositeDisposable _controlDisposable;
        private CriAtomExPlayback _playback;
        private CriAtomEx.CueInfo _cueInfo;
        private CriUserData _userData;
        [CompilerGenerated]
        private Action<string> m_onSoundPlayed;
        private CriAtomExAcb _acb;
        private bool _isPreparePlay;
        public CriAtomSource Source
        {
            get
            {
                return null;
            }
        }

        public SoundInfo SoundInfo
        {
            get
            {
                return default(SoundInfo);
            }
        }

        public CriAtomExPlayback PlayBack
        {
            get
            {
                return default(CriAtomExPlayback);
            }
        }

        public CriAtomEx.CueInfo CueInfo
        {
            get
            {
                return default(CriAtomEx.CueInfo);
            }
        }

        public CriUserData UserData
        {
            get
            {
                return null;
            }
        }

        public CriAtomExAcb Acb
        {
            get
            {
                return null;
            }
        }

        public event Action<string> onSoundPlayed
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

        public void Initialize()
        {
        }

        public void Setup(SoundInfo info, bool loop = false)
        {
        }

        public long GetTimeMs()
        {
            return default(long);
        }

        public long GetSequencePositionMs()
        {
            return default(long);
        }

        public long GetDurationMs()
        {
            return default(long);
        }

        public void PlayWithIndex(int index)
        {
        }

        public void PlayWithStartTime(int time)
        {
        }

        public void Pause()
        {
        }

        public void Unpause()
        {
        }

        public void Stop()
        {
        }

        public void SetStartTime(int time)
        {
        }

        public void ResetState()
        {
        }

        public UniTask OnPreparedAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnEndAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnStopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public UniTask OnEndOrStopAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public bool IsPrepared()
        {
            return default(bool);
        }

        public bool IsPlaying()
        {
            return default(bool);
        }

        public bool IsPaused()
        {
            return default(bool);
        }

        public bool IsEnd()
        {
            return default(bool);
        }

        public bool IsStop()
        {
            return default(bool);
        }

        public bool IsEndOrStop()
        {
            return default(bool);
        }

        public void BindTo(Action onCancelCallback, CancellationToken baseCt, [Optional] GameObject bindTarget)
        {
        }

        private void TryBindControl(CompositeDisposable disposable, GameObject bindTarget)
        {
        }

        public Tween FadeVolume(float volume, float duration)
        {
            return null;
        }

        public void Prepare(int time = 0)
        {
        }

        public void Play()
        {
        }

        public void PlayWith(ICampusActorController actor, bool lipSyncEnabled = true)
        {
        }

        public void PauseWith(ICampusActorController actor)
        {
        }

        public void UnpauseWith(ICampusActorController actor)
        {
        }

        public void StopWith(ICampusActorController actor)
        {
        }

        public void SetNextBlockIndex(int index)
        {
        }

        public int SetNextBlock()
        {
            return default(int);
        }

        public int SetPrevBlock()
        {
            return default(int);
        }

        public int GetCurrentBlockIndex()
        {
            return default(int);
        }

        public int GetBlockCount()
        {
            return default(int);
        }

        private int GetStartTime(int time)
        {
            return default(int);
        }

        public CampusSoundPlayer()
        {
        }

        [CompilerGenerated]
        private void _003CTryBindControl_003Eb__47_0(Unit _)
        {
        }

        [CompilerGenerated]
        private void _003CTryBindControl_003Eb__47_1(Unit _)
        {
        }

        [CompilerGenerated]
        private float _003CFadeVolume_003Eb__48_0()
        {
            return default(float);
        }

        [CompilerGenerated]
        private void _003CFadeVolume_003Eb__48_1(float v)
        {
        }
    }
}
