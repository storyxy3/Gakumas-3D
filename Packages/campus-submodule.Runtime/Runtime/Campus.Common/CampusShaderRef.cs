namespace Campus.Common
{
    using global::Campus.Common;
    using global::UnityEngine;

    public class CampusShaderRef : ScriptableObject
    {
        private static CampusShaderRef _instance;
        [SerializeField]
        private Shader _uiBase;
        public static CampusShaderRef Instance
        {
            get
            {
                return null;
            }
        }

        public Shader UIBase
        {
            get
            {
                return null;
            }
        }

        public CampusShaderRef()
        {
        }
    }
}
