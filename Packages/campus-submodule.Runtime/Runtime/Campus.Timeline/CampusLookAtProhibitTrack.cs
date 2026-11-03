namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusLookAtProhibitClip))]
    [TrackColor(0.25f, 0.35f, 0.7f)]
    public class CampusLookAtProhibitTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        internal static ILookAtProhibitController FindController(GameObject directorGo)
        {
            return null;
        }

        public CampusLookAtProhibitTrack()
        {
        }
    }
}
