namespace Campus.MobAudience
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<Renderer, bool> _003C_003E9__13_0;
            public static Func<Renderer, bool> _003C_003E9__13_1;
            public static Func<Renderer, MaterialInfo> _003C_003E9__13_2;
            public _003C_003Ec()
            {
            }

            internal bool _003CSetupPenlightSettings_003Eb__13_0(Renderer r)
            {
                return default(bool);
            }

            internal bool _003CSetupPenlightSettings_003Eb__13_1(Renderer r)
            {
                return default(bool);
            }

            internal MaterialInfo _003CSetupPenlightSettings_003Eb__13_2(Renderer r)
            {
                return null;
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
