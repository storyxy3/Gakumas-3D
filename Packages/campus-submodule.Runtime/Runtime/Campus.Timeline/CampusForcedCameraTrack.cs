namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusForcedCameraClip))]
    [TrackColor(0.7f, 0.5f, 0.1f)]
    public class CampusForcedCameraTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        internal static IPanoramaCameraController FindController(GameObject directorGo)
        {
            return null;
        }

        public CampusForcedCameraTrack()
        {
        }
    }
}
