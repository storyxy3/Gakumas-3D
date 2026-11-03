namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Octo;
    using global::UnityEngine;

    public class CampusActorModelKeeper : MonoBehaviour
    {
        private Dictionary<int, List<string>> _modelAssetMap;
        private Dictionary<string, int> _referenceCountMap;
        private Dictionary<string, AssetKeeper> _assetKeepers;
        private List<AssetKeeper> _reusableAssetKeepers;
        public void Initialize(int modelCacheCount)
        {
        }

        public void LoadAsset(int modelIndex, List<string> assetNames, Action<int, GameObject, AssetLoaderError> onComplete)
        {
        }

        public CampusActorModelKeeper()
        {
        }
    }
}
