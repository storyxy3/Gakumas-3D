namespace CriWare.CriTimeline.Atom
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::CriWare.CriTimeline.Atom;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CriAtomBehaviour : PlayableBehaviour
    {
        [Range(0f, 1f)]
        public float volume;
        [Range(-1200f, 1200f)]
        public float pitch;
        [Range(0f, 1f)]
        public float AISACValue;
        private static int cPreviewStopTimeMs;
        private CriAtomExAcb m_acb;
        private string m_lastCueSheetPath;
        [CompilerGenerated]
        private CriAtomExPlayback _003Cplayback_003Ek__BackingField;
        private bool _IsClipPlaying;
        private double _CueLength;
        public CriAtomExPlayback playback
        {
            [CompilerGenerated]
            get
            {
                return _003Cplayback_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Cplayback_003Ek__BackingField = value;
            }
        }

        public bool IsClipPlaying
        {
            get
            {
                return default(bool);
            }

            private set
            {
            }
        }

        public double CueLength
        {
            get
            {
                return default(double);
            }

            private set
            {
            }
        }

        public override void OnGraphStop(Playable playable)
        {
        }

        public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config)
        {
        }

        public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config)
        {
        }

        private void WaitAndStop()
        {
        }

        public void Stop(bool noReleaseTime = false)
        {
        }

        private double GetCueLengthSec(CriAtomExAcb acb, string cueName)
        {
            return default(double);
        }

        public CriAtomBehaviour()
        {
        }

        [CompilerGenerated]
        private void _003CWaitAndStop_003Eb__21_0()
        {
        }
    }
}
