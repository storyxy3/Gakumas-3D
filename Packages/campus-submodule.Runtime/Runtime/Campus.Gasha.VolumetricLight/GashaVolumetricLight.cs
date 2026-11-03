namespace Campus.Gasha.VolumetricLight
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Gasha;
    using global::Campus.Gasha.VolumetricLight;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VLB;

    [ExecuteAlways]
    public class GashaVolumetricLight : MonoBehaviour
    {
        public class GashaVolumetricLightParam
        {
            public RarityType rarityType;
            public bool isReversal;
            public GashaVolumetricLightParam()
            {
            }
        }

        [Serializable]
        public class RarityTimelineKeyValue
        {
            public RarityType rarityType;
            public PlayableDirector director;
            public RarityTimelineKeyValue()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass13_0
        {
            public RarityType rarityType;
            public _003C_003Ec__DisplayClass13_0()
            {
            }

            internal bool _003CGetRarityDirector_003Eb__0(RarityTimelineKeyValue x)
            {
                return default(bool);
            }
        }

        public VolumetricLightBeamSD volumetricLightBeamSD;
        public RarityTimelineKeyValue[] rarityTimelineTable;
        public PlayableDirector reversalDirector;
        public GameObject rootObject;
        public GameObject lens;
        [CanBeNull]
        private GashaVolumetricLightParam _param;
        public void Bind(GashaVolumetricLightParam param)
        {
        }

        public void Prepare()
        {
        }

        public void LightUp()
        {
        }

        public void LightDown()
        {
        }

        private void ShowLens(bool show)
        {
        }

        private PlayableDirector GetRarityDirector(RarityType rarityType)
        {
            return null;
        }

        public void TryPlayReversal()
        {
        }

        public void SetActive(bool active)
        {
        }

        public GashaVolumetricLight()
        {
        }
    }
}
