namespace Octo
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Octo;

    [Serializable]
    public class OctoFullSettings : IOctoSettings
    {
        [CompilerGenerated]
        private string _003CUrl_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CAppId_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CClientSecretKey_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CAesKey_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CA_003Ek__BackingField;
        [CompilerGenerated]
        private CachingType _003CCachingType_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CVersion_003Ek__BackingField;
        private IUnloadHandler _unloadHandler;
        [CompilerGenerated]
        private int _003CMaxParallelDownload_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CMaxParallelLoad_003Ek__BackingField;
        [CompilerGenerated]
        private long _003CMaximumAvailableDiskSpace_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CExpirationDelay_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CAllowDeleted_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CEnableAssetDatabase_003Ek__BackingField;
        [CompilerGenerated]
        private AssetLoader.LoadPriority _003CAssetLoaderPriority_003Ek__BackingField;
        public string Url
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

        public int AppId
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public string ClientSecretKey
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

        public string AesKey
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

        public string A
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

        public CachingType CachingType
        {
            [CompilerGenerated]
            get
            {
                return default(CachingType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int Version
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public IUnloadHandler UnloadHandler
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int MaxParallelDownload
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int MaxParallelLoad
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public long MaximumAvailableDiskSpace
        {
            [CompilerGenerated]
            get
            {
                return default(long);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public int ExpirationDelay
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool AllowDeleted
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool EnableAssetDatabase
        {
            [CompilerGenerated]
            set
            {
            }
        }

        public AssetLoader.LoadPriority AssetLoaderPriority
        {
            [CompilerGenerated]
            get
            {
                return default(AssetLoader.LoadPriority);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public OctoFullSettings()
        {
        }

        public OctoFullSettings(OctoSettings settings)
        {
        }
    }
}
