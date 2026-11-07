namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Photography;
    using global::UnityEngine;

    public class CampusPhotographySceneLayoutCollection : MonoBehaviour
    {
        [SerializeField]
        private CampusPhotographySceneLayout[] _sceneLayouts;
        [CompilerGenerated]
        private CampusPhotographySceneLayout _003CLastGetSceneLayoutCache_003Ek__BackingField;
        [SerializeField]
        private PhotographyCaptureSpotData _photographyCaptureSpotData;
        public CampusPhotographySceneLayout[] SceneLayouts
        {
            get
            {
                return null;
            }
        }

        public CampusPhotographySceneLayout LastGetSceneLayoutCache
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

        public PhotographyCaptureSpotData PhotographyCaptureSpotData
        {
            get
            {
                return null;
            }
        }

        public CampusPhotographySceneLayout GetSceneLayout(string id)
        {
            return null;
        }

        public CampusPhotographySceneLayoutCollection()
        {
        }
    }
}
