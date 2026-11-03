namespace CriWare.CriTimeline.Atom
{
    using global::CriWare;
    using global::CriWare.CriTimeline.Atom;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [TrackColor(0.3317462f, 0.6611561f, 105f / 106f)]
    [TrackClipType(typeof(CriAtomClipBase))]
    [TrackBindingType(typeof(CriAtomSourceBase))]
    public class CriAtomTrack : TrackAsset
    {
        public string m_AisacControls;
        public bool m_StopOnWrapping;
        public bool m_StopAtGraphEnd;
        public bool m_ApplyPlayableSpeed;
        public bool m_CheckPosWithinClip;
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount)
        {
            return default(Playable);
        }

        public CriAtomTrack()
        {
        }
    }
}
