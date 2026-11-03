namespace Octo.Asset
{
    using global::Octo;
    using global::Octo.Asset;
    using global::UnityEngine;

    internal sealed class AssetBundleOperator : IAssetOperator
    {
        private static readonly string Tag;
        private AssetBundleData _assetBundleData;
        private bool _isUnloaded;
        private string[] _allAssetNames;
        public string Name
        {
            get
            {
                return null;
            }
        }

        public bool IsStreamedSceneAssetBundle
        {
            get
            {
                return default(bool);
            }
        }

        private string[] AllAssetNames
        {
            get
            {
                return null;
            }
        }

        internal AssetBundleOperator(AssetBundleData assetBundleData)
        {
        }

        public LoadRequest<T> LoadAssetAsync<T>()
            where T : Object
        {
            return null;
        }

        public LoadRequest<T> LoadAssetAsync<T>(string assetName)
            where T : Object
        {
            return null;
        }

        public T[] LoadAllAssets<T>()
            where T : Object
        {
            return null;
        }

        public void Unload(bool force = false)
        {
        }

        private LoadRequest<T> CreateLoadRequest<T>(AssetBundleRequest abr)
            where T : Object
        {
            return null;
        }

        private bool IsAlreadyUnload()
        {
            return default(bool);
        }
    }
}
