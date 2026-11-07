namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusSceneLayoutCollection : MonoBehaviour
    {
        [SerializeField]
        private CampusSceneLayout[] _sceneLayouts;
        [CompilerGenerated]
        private CampusSceneLayout _003CLastGetSceneLayoutCache_003Ek__BackingField;
        public CampusSceneLayout[] SceneLayouts
        {
            get
            {
                return null;
            }
        }

        public CampusSceneLayout LastGetSceneLayoutCache
        {
            [CompilerGenerated]
            get
            {
                return _003CLastGetSceneLayoutCache_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CLastGetSceneLayoutCache_003Ek__BackingField = value;
            }
        }

        public CampusSceneLayout GetSceneLayout(string id)
        {
            return null;
        }

        public CampusSceneLayoutCollection()
        {
        }
    }
}
