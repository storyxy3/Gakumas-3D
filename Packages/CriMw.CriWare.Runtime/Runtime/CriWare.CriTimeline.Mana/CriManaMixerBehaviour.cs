namespace CriWare.CriTimeline.Mana
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::CriWare;
    using global::CriWare.CriMana;
    using global::CriWare.CriTimeline.Mana;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CriManaMixerBehaviour : PlayableBehaviour
    {
        private enum MovieMixerState
        {
            Preloading,
            Ready,
            Playing,
            Stopping,
            Stopped
        }

        private enum ClipState
        {
            Idle,
            Prepare,
            Play,
            Seek
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CProcessFrameOnSeeking_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncVoidMethodBuilder _003C_003Et__builder;
            public CriManaMixerBehaviour _003C_003E4__this;
            public TimelineClip activeClip;
            public CriManaClipBase clip;
            public double frameTime;
            private bool _003CmovieInfoReplaced_003E5__2;
            private bool _003CwhileBreaker_003E5__3;
            private TaskAwaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        internal PlayableDirector m_PlayableDirector;
        internal TimelineClip[] m_clips;
        internal CriManaMovieMaterialBase m_boundMovieMaterial;
        internal Dictionary<int, GCHandle> m_gcHandleList;
        internal bool m_frameSync;
        internal bool m_CheckPosWithinClip;
        private static double cPreloadTimeSec;
        private static float cFrameSkipTolerance;
        private Guid? m_lastClipId;
        private double lastPlayedTime;
        private double m_currentSeekingFrameTime;
        private float m_originalAudioVolume;
        private float m_originalSubAudioVolume;
        private float m_originalExtraAudioVolume;
        private bool enableTimelineScrubPlayback;
        private double m_lastDirectorTime;
        private MovieMixerState m_movieMixerState;
        private static bool IsEditMode
        {
            get
            {
                return default(bool);
            }
        }

        private void KeepAudioVolume(bool fadeAudio)
        {
        }

        private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime)
        {
            return default(bool);
        }

        private bool PrepareMovie(CriManaClipBase clipAsset)
        {
            return default(bool);
        }

        private bool StopMovie(bool keepLastFrame = false)
        {
            return default(bool);
        }

        private bool StopForSeekMovie()
        {
            return default(bool);
        }

        private static bool IsPlayerStopped(Player player)
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003CProcessFrameOnSeeking_003Ed__27))]
        private void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime)
        {
        }

        private void ForceSyncedStop(bool keepLastFrame = false)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        private bool IsIntermediateState()
        {
            return default(bool);
        }

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
        }

        private void PausePlayer(bool pause)
        {
        }

        public override void OnGraphStart(Playable playable)
        {
        }

        public override void OnGraphStop(Playable playable)
        {
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public CriManaMixerBehaviour()
        {
        }
    }
}
