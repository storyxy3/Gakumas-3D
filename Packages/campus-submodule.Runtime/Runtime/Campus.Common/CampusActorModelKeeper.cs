namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Octo;
    using global::UnityEngine;

    public class CampusActorModelKeeper : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass5_0
        {
            public CampusActorModelKeeper _003C_003E4__this;
            public Action<int, GameObject, AssetLoaderError> onComplete;
            public _003C_003Ec__DisplayClass5_0()
            {
            }

            internal void _003CLoadAsset_003Eb__0(string assetName)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass5_1
        {
            public int index;
            public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass5_1()
            {
            }

            internal void _003CLoadAsset_003Eb__1(GameObject obj, AssetLoaderError err)
            {
            }

            internal void _003CLoadAsset_003Eb__2(GameObject obj, AssetLoaderError err)
            {
            }
        }

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
