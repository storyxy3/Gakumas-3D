namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusBpmTimelineAsset))]
    public class CampusBpmTimelineTrack : PlayableTrack
    {
        private void AddKey(AnimationCurve curve, float time, float value)
        {
        }

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return default(Playable);
        }

        private void InjectBpmBehaviour(PlayableDirector playableDirector, CampusBpmInfo bpmInfo)
        {
        }

        public CampusBpmTimelineTrack()
        {
        }
    }
}
