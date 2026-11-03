namespace Campus.MobAudience
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.AudiencePenlight;
    using global::Campus.MobAudience;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.Core;

    [ExecuteAlways]
    public class MobAudiencePenlightController : MonoBehaviour
    {
        [Serializable]
        public class MobPenlightSetting
        {
            public int MobActorIndex;
            public int ColorTableIndex;
            public Transform Actor;
            public Renderer[] PenlightRenderers;
            public MobPenlightSetting()
            {
            }
        }

        private class RuntimeMobPenlightSetting
        {
            public int MobActorIndex;
            public int ColorTableIndex;
            public Transform Actor;
            public MaterialInfo[] MaterialInfos;
            public RuntimeMobPenlightSetting()
            {
            }
        }

        private static readonly int PenlightColorID;
        private static readonly int PenlightProjectionUvID;
        private static readonly string UseColorProjectionKeyword;
        private static readonly Color DefaultColor;
        [SerializeField]
        private MobPenlightSetting[] penlightSettings;
        private RuntimeMobPenlightSetting[] _runtimeMobPenlightSettings;
        private readonly DefaultAudiencePenlight _defaultAudiencePenlight;
        private Dictionary<int, int> _overrides;
        private AudiencePenlightVolume _penlightVolume;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void SetupPenlightSettings()
        {
        }

        private void CleanupPenlightSettings()
        {
        }

        private void UpdatePenlightParams(ScriptableRenderContext context, Camera camera)
        {
        }

        private void CalcPenlightParams(IAudiencePenlight penlight, VolumeStack stack, out float4 projectionParams, out float4 projectionUV, out int colorTableSize)
        {
            throw null;
        }

        private void UpdateProjectionParams(RuntimeMobPenlightSetting setting, MaterialInfo materialInfo, float4 projectionParams, float4 projectionUV)
        {
        }

        private void UpdateColorTableParams(RuntimeMobPenlightSetting setting, MaterialInfo materialInfo, IAudiencePenlight penlight, int colorTableSize)
        {
        }

        public void ClearOverrides()
        {
        }

        public void SetOverrides(params MobAudiencePenlightOverride[] penlightOverrides)
        {
        }

        public MobAudiencePenlightController()
        {
        }
    }
}
