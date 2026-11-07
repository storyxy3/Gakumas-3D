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
                return _003CUrl_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CUrl_003Ek__BackingField = value;
            }
        }

        public int AppId
        {
            [CompilerGenerated]
            get
            {
                return _003CAppId_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAppId_003Ek__BackingField = value;
            }
        }

        public string ClientSecretKey
        {
            [CompilerGenerated]
            get
            {
                return _003CClientSecretKey_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CClientSecretKey_003Ek__BackingField = value;
            }
        }

        public string AesKey
        {
            [CompilerGenerated]
            get
            {
                return _003CAesKey_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAesKey_003Ek__BackingField = value;
            }
        }

        public string A
        {
            [CompilerGenerated]
            get
            {
                return _003CA_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CA_003Ek__BackingField = value;
            }
        }

        public CachingType CachingType
        {
            [CompilerGenerated]
            get
            {
                return _003CCachingType_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CCachingType_003Ek__BackingField = value;
            }
        }

        public int Version
        {
            [CompilerGenerated]
            get
            {
                return _003CVersion_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CVersion_003Ek__BackingField = value;
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
                return _003CMaxParallelDownload_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CMaxParallelDownload_003Ek__BackingField = value;
            }
        }

        public int MaxParallelLoad
        {
            [CompilerGenerated]
            get
            {
                return _003CMaxParallelLoad_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CMaxParallelLoad_003Ek__BackingField = value;
            }
        }

        public long MaximumAvailableDiskSpace
        {
            [CompilerGenerated]
            get
            {
                return _003CMaximumAvailableDiskSpace_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CMaximumAvailableDiskSpace_003Ek__BackingField = value;
            }
        }

        public int ExpirationDelay
        {
            [CompilerGenerated]
            get
            {
                return _003CExpirationDelay_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CExpirationDelay_003Ek__BackingField = value;
            }
        }

        public bool AllowDeleted
        {
            [CompilerGenerated]
            get
            {
                return _003CAllowDeleted_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAllowDeleted_003Ek__BackingField = value;
            }
        }

        public bool EnableAssetDatabase
        {
            [CompilerGenerated]
            set
            {
                _003CEnableAssetDatabase_003Ek__BackingField = value;
            }
        }

        public AssetLoader.LoadPriority AssetLoaderPriority
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetLoaderPriority_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAssetLoaderPriority_003Ek__BackingField = value;
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
