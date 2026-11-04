namespace Campus.Timeline
{
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class CampusDirectorControlAsset : PlayableAsset
    {
        public ExposedReference<PlayableDirector> directorReference;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var director = directorReference.Resolve(graph.GetResolver());
            return director == null ? Playable.Null : global::UnityEngine.Timeline.DirectorControlPlayable.Create(graph, director);
        }

        public CampusDirectorControlAsset()
        {
        }
    }
}
