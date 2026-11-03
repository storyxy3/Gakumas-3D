namespace Octo.Data
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Octo;
    using global::Octo.Data;
    using global::Octo.Proto;

    internal sealed class DataManager : IDatabase
    {
        private static readonly string Tag;
        public static readonly string DirName;
        internal static readonly string CacheFileName;
        internal readonly string _dataPath;
        private AESCrypt _aes;
        private string[] _tags;
        private Dictionary<string, Item> _assetBundleDictionary;
        private Dictionary<string, Item> _resourceDictionary;
        private readonly int _version;
        [CompilerGenerated]
        private bool _003CIsUsingEmbeddedDb_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CRevision_003Ek__BackingField;
        private string _urlFormat;
        [CompilerGenerated]
        private string _003CAssetBundleUrlFormat_003Ek__BackingField;
        [CompilerGenerated]
        private string _003CResourceUrlFormat_003Ek__BackingField;
        public bool IsUsingEmbeddedDb
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

        public int Revision
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public string AssetBundleUrlFormat
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public string ResourceUrlFormat
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public DataManager(int appId, int version, [Optional] AESCrypt crypt)
        {
        }

        public void Initialize()
        {
        }

        public Error ApplyToDatabase(byte[] downloadedBytes, bool reset)
        {
            return null;
        }

        public Item GetAssetBundleItemByName(string name, bool allowDeleted = false)
        {
            return null;
        }

        public Item GetResourceItemByName(string name, bool allowDeleted = false)
        {
            return null;
        }

        public string[] GetAllAssetBundleNames()
        {
            return null;
        }

        public string[] GetAllResourceNames()
        {
            return null;
        }

        public string GenerateAssetBundleUrl(Item item)
        {
            return null;
        }

        public string GenerateResourceUrl(Item item)
        {
            return null;
        }

        [Conditional("USE_LOCAL_DB")]
        private void ConstructDictionaryWithLocalDatabase()
        {
        }

        public void DeleteData()
        {
        }

        private void Reset()
        {
        }

        private SecureProtoBufDatabase<object /* TODO(qa-recon): octdata Octo.Proto.Database excluded. */> ReadSecureDatabase(string path)
        {
            return null;
        }

        private void ResetAllDependencies(object /* TODO(qa-recon): octdata Octo.Proto.Database excluded. */ db)
        {
        }

        private void SetUrls(object /* TODO(qa-recon): octdata Octo.Proto.Database excluded. */ db)
        {
        }

        private void ConstructDictionary(object /* TODO(qa-recon): octdata Octo.Proto.Database excluded. */ db)
        {
        }

        private void UpdateWithNewData(Dictionary<string, Item> dictionary, object /* TODO(qa-recon): octdata Octo.Proto.Data excluded. */ octodata)
        {
        }

        private static Item GetItemByName(Dictionary<string, Item> dictionary, string name, bool allowDeleted)
        {
            return null;
        }

        private static HashSet<Item> GetItems(Dictionary<string, Item> dictionary, Func<Item, bool> predicate)
        {
            return null;
        }

        private byte[] SerializeDatabase()
        {
            return null;
        }

        private static void Write(object /* TODO(qa-recon): protobuf-net ProtoBuf.ProtoWriter excluded. */ writer, int tag, IEnumerable<Item> items, Dictionary<string, int> tagDictionary)
        {
        }
    }
}
