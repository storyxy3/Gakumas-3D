namespace Octo
{
    using global::System.Runtime.CompilerServices;
    using global::Octo;
    using global::UnityEngine;

    public abstract class SetupHelper : MonoBehaviour
    {
        private static SetupHelper _instance;
        public bool autoDbUpdate;
        [SerializeField]
        protected int maximumAvailableDiskSpace;
        [SerializeField]
        protected int expirationDelay;
        [SerializeField]
        protected bool allowDeleted;
        [SerializeField]
        protected bool enableAssetDatabase;
        protected bool _isSetupCompleted;
        [CompilerGenerated]
        private OctoSettings _003CSettings_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsAutoUpdateFinished_003Ek__BackingField;
        public static SetupHelper Instance
        {
            get
            {
                return null;
            }
        }

        public static bool HasInstance
        {
            get
            {
                return default(bool);
            }
        }

        public OctoSettings Settings
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool IsReady
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsAutoUpdateFinished
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public virtual void Awake()
        {
        }

        public virtual void OnBeforeSetup()
        {
        }

        private void Setup()
        {
        }

        public virtual void OnAutoDbUpdate(DownloadError error)
        {
        }

        private void OnDestroy()
        {
        }

        protected SetupHelper()
        {
        }
    }
}
