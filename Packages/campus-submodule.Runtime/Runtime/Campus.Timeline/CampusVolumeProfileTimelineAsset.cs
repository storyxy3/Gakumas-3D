namespace Campus.Timeline
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;

    [Serializable]
    public class CampusVolumeProfileTimelineAsset : PlayableAsset
    {
        [HideInInspector]
        public VolumeProfile volumeProfile;
        [HideInInspector]
        public double startTime;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CampusVolumeProfileTimelineAsset()
        {
        }
    }
}
