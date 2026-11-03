namespace Campus.Common
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.SceneManagement;

    public class CampusLoadSceneParam
    {
        [CompilerGenerated]
        private LoadSceneParameters _003CParameters_003Ek__BackingField;
        [CompilerGenerated]
        private readonly string _003CSceneName_003Ek__BackingField;
        [CompilerGenerated]
        private readonly int _003CSceneBuildIndex_003Ek__BackingField;
        public LoadSceneParameters Parameters
        {
            [CompilerGenerated]
            get
            {
                return default(LoadSceneParameters);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public string SceneName
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public int SceneBuildIndex
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }
        }

        public object SceneNameOrIndex
        {
            get
            {
                return null;
            }
        }

        public bool HasSceneIndex
        {
            get
            {
                return default(bool);
            }
        }

        public CampusLoadSceneParam(string sceneName)
        {
        }

        public CampusLoadSceneParam(int sceneBuildIndex)
        {
        }
    }
}
