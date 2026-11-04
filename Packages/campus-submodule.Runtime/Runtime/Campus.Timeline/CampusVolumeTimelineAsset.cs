namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Timeline;

    [Serializable]
    public class CampusVolumeTimelineAsset : PlayableAsset, IPropertyPreview
    {
        public ExposedReference<Volume> volume;
        [HideInInspector]
        public float initialVolumePriority;
        [HideInInspector]
        public double startTime;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var target = volume.Resolve(graph.GetResolver());
            if (target == null) return default;
            var behaviour = new CampusVolumeTimelineBehaviour
            {
                gameObject = target.gameObject,
                postPlayback = global::UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState.Inactive,
                volume = target,
                initialVolumePriority = initialVolumePriority,
                startTime = startTime
            };
            return ScriptPlayable<CampusVolumeTimelineBehaviour>.Create(graph, behaviour);
        }

        public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusVolumeTimelineAsset()
        {
        }
    }
}
