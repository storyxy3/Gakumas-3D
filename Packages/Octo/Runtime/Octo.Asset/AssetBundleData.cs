namespace Octo.Asset
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Octo.Asset;
    using global::Octo.Data;
    using global::UnityEngine;

    internal sealed class AssetBundleData
    {
        public AssetBundleLoadRequest request;
        [CompilerGenerated]
        private Item _003CRawData_003Ek__BackingField;
        [CompilerGenerated]
        private AssetBundle _003CAssetBundle_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CReferenceCount_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsUnloadRequested_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsUnloaded_003Ek__BackingField;
        private List<AssetBundleRequest> _loadingRequestList;
        public string AssetBundleName
        {
            get
            {
                return null;
            }
        }

        public Item RawData
        {
            [CompilerGenerated]
            get
            {
                return _003CRawData_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CRawData_003Ek__BackingField = value;
            }
        }

        public bool IsRequestCompleted
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsAssetLoading
        {
            get
            {
                return default(bool);
            }
        }

        public AssetBundle AssetBundle
        {
            [CompilerGenerated]
            get
            {
                return _003CAssetBundle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CAssetBundle_003Ek__BackingField = value;
            }
        }

        public int ReferenceCount
        {
            [CompilerGenerated]
            get
            {
                return _003CReferenceCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CReferenceCount_003Ek__BackingField = value;
            }
        }

        public bool IsUnloadRequested
        {
            [CompilerGenerated]
            get
            {
                return _003CIsUnloadRequested_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CIsUnloadRequested_003Ek__BackingField = value;
            }
        }

        public bool IsUnloaded
        {
            [CompilerGenerated]
            get
            {
                return _003CIsUnloaded_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsUnloaded_003Ek__BackingField = value;
            }
        }

        public AssetBundleData(Item item)
        {
        }

        private void AddLoadingRequest(AssetBundleRequest request)
        {
        }

        public AssetBundleRequest LoadAssetAsync<T>(string name)
        {
            return null;
        }

        public void OnLoadRequestCompleted(AssetBundleRequest abr)
        {
        }

        public void AddReference()
        {
        }

        public int RemoveReference()
        {
            return default(int);
        }

        public void ClearReference()
        {
        }

        public void UnloadAssetBundle(bool unloadAllLoadedObjects)
        {
        }
    }
}
