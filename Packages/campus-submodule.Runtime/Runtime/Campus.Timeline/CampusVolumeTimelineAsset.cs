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
            return default(Playable);
        }

        public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
        }

        public CampusVolumeTimelineAsset()
        {
        }
    }
}
