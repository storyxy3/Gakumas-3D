namespace Titan
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Playables;

    public class PlayableDirectorGroup : MonoBehaviour
    {
        [SerializeField]
        private List<PlayableDirector> _directors;
        public IReadOnlyList<PlayableDirector> Directors
        {
            get
            {
                return null;
            }
        }

        public void Set(IEnumerable<PlayableDirector> directors)
        {
        }

        public PlayableDirectorGroup()
        {
        }
    }
}
