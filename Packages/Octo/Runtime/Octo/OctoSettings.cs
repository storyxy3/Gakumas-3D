namespace Octo
{
    using global::System;
    using global::Octo;
    using global::UnityEngine;

    [Serializable]
    public sealed class OctoSettings : ScriptableObject, IOctoSettings
    {
        [Header("url for database update.")]
        public string url;
        public int appId;
        public string clientSecretKey;
        public string aesKey;
        public string a;
        public CachingType cachingType;
        public int version;
        [Header("AssetBundle.Unload parameter (Recommended:true)")]
        public bool unloadAll;
        [Header("0 means to use default.")]
        public int maxParallelDownload;
        [Header("0 means to use default.")]
        public int maxParallelLoad;
        string Octo.IOctoSettings.Url
        {
            get
            {
                return null;
            }
        }

        int Octo.IOctoSettings.AppId
        {
            get
            {
                return default(int);
            }
        }

        string Octo.IOctoSettings.ClientSecretKey
        {
            get
            {
                return null;
            }
        }

        string Octo.IOctoSettings.AesKey
        {
            get
            {
                return null;
            }
        }

        string Octo.IOctoSettings.A
        {
            get
            {
                return null;
            }
        }

        CachingType Octo.IOctoSettings.CachingType
        {
            get
            {
                return default(CachingType);
            }
        }

        int Octo.IOctoSettings.Version
        {
            get
            {
                return default(int);
            }
        }

        IUnloadHandler Octo.IOctoSettings.UnloadHandler
        {
            get
            {
                return null;
            }
        }

        int Octo.IOctoSettings.MaxParallelDownload
        {
            get
            {
                return default(int);
            }
        }

        int Octo.IOctoSettings.MaxParallelLoad
        {
            get
            {
                return default(int);
            }
        }

        public OctoSettings()
        {
        }
    }
}
