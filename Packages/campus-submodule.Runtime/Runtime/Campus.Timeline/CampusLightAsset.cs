namespace Campus.Timeline
{
    using global::System;
    using global::Campus.Timeline;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    [Serializable]
    public class CampusLightAsset : PlayableAsset
    {
        public CampusLightBehaviour behaviour;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CampusLightAsset()
        {
        }
    }
}
