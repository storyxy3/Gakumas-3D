namespace CriWare.CriTimeline.Atom
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::CriWare;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CriAtomMixerBehaviour : PlayableBehaviour
    {
        internal PlayableDirector m_Director;
        internal TimelineClip[] m_Clips;
        internal CriAtomSourceBase m_Bind;
        internal string m_AisacControls;
        internal bool m_StopOnWrapping;
        internal bool m_StopAtGraphEnd;
        internal bool m_ApplyPlayableSpeed;
        internal bool m_CheckPosWithinClip;
        [CompilerGenerated]
        private Guid _003Cm_Guid_003Ek__BackingField;
        private const int cScratchTimeIntervalMs = 200;
        private const double cFrameSkipTolerance = 5E-324;
        private DateTime m_lastScrubTime;
        private double m_lastDirectorTime;
        private CriAtomListener previewSelectedListenerObj;
        public Guid m_Guid
        {
            [CompilerGenerated]
            get
            {
                return _003Cm_Guid_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003Cm_Guid_003Ek__BackingField = value;
            }
        }

        private static bool IsEditor
        {
            get
            {
                return default(bool);
            }
        }

        public override void OnPlayableCreate(Playable playable)
        {
        }

        public override void OnPlayableDestroy(Playable playable)
        {
        }

        public override void OnGraphStop(Playable playable)
        {
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
        }

        public CriAtomMixerBehaviour()
        {
        }
    }
}
