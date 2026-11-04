namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Timeline;

    [Serializable]
    [TrackClipType(typeof(CampusVolumeTimelineAsset), false)]
    public class CampusVolumeTimelineTrack : PlayableTrack
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<CampusVolumeTimelineMixerBehaviour>.Create(graph, inputCount);
        }

        protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
        {
            var asset = clip.asset as CampusVolumeTimelineAsset;
            if (asset == null) return Playable.Null;
            asset.startTime = clip.start;
            var volume = asset.volume.Resolve(graph.GetResolver());
            if (volume != null) asset.initialVolumePriority = volume.priority;
            return base.CreatePlayable(graph, gameObject, clip);
        }

        public CampusVolumeTimelineTrack()
        {
        }
    }
}
