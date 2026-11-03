namespace Campus.Timeline
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusCurrentActorSignalClip))]
    [TrackColor(0.45f, 0.65f, 0.9f)]
    public class CampusCurrentActorSignalTrack : PlayableTrack
    {
        public int slotIndex;
        public int defaultActorIndex;
        public int[] switchTargetIndices;
        public HashSet<int> GetAllUsedIndices()
        {
            return null;
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        internal static ICurrentActorSignalNotifier FindNotifier(GameObject directorGo)
        {
            return null;
        }

        public CampusCurrentActorSignalTrack()
        {
        }
    }
}
