namespace Campus.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CampusDirectorControlAsset : PlayableAsset
    {
        public ExposedReference<PlayableDirector> directorReference;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            return default(Playable);
        }

        public CampusDirectorControlAsset()
        {
        }
    }
}
