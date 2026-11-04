namespace Campus.MobAudience
{
    using global::System;
    using global::System.Linq;
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
            public int MobActorIndex = -1;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<Renderer, bool> _003C_003E9__13_0;
            public static Func<Renderer, bool> _003C_003E9__13_1;
            public static Func<Renderer, MaterialInfo> _003C_003E9__13_2;
            public _003C_003Ec()
            {
            }

            internal bool _003CSetupPenlightSettings_003Eb__13_0(Renderer r)
            {
                return r != null && r.sharedMaterial != null;
            }

            internal bool _003CSetupPenlightSettings_003Eb__13_1(Renderer r)
            {
                return r != null;
            }

            internal MaterialInfo _003CSetupPenlightSettings_003Eb__13_2(Renderer r)
            {
                return new MaterialInfo(r.sharedMaterial, r, 0, null);
            }
        }

        private static readonly int PenlightColorID = Shader.PropertyToID("_PenlightColor");
        private static readonly int PenlightProjectionUvID = Shader.PropertyToID("_PenlightProjectionUV");
        private static readonly string UseColorProjectionKeyword = "_USE_COLOR_PROJECTION";
        private static readonly Color DefaultColor = new Color(4f, 4f, 4f, 0f);
        [SerializeField]
        private MobPenlightSetting[] penlightSettings;
        private RuntimeMobPenlightSetting[] _runtimeMobPenlightSettings;
        private readonly DefaultAudiencePenlight _defaultAudiencePenlight = new DefaultAudiencePenlight(DefaultColor);
        private Dictionary<int, int> _overrides;
        private AudiencePenlightVolume _penlightVolume;
        private void OnEnable()
        {
            RenderPipelineManager.beginCameraRendering += UpdatePenlightParams;
            SetupPenlightSettings();
        }

        private void OnDisable()
        {
            CleanupPenlightSettings();
            RenderPipelineManager.beginCameraRendering -= UpdatePenlightParams;
        }

        private void SetupPenlightSettings()
        {
            CleanupPenlightSettings();
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(penlightSettings)) return;
            List<MobPenlightSetting> settings = null;
            foreach (var setting in penlightSettings)
            {
                if (setting == null || setting.Actor == null || global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(setting.PenlightRenderers) || setting.MobActorIndex < 0) continue;
                if (!setting.PenlightRenderers.Any(_003C_003Ec._003C_003E9__13_0 ?? (_003C_003Ec._003C_003E9__13_0 = _003C_003Ec._003C_003E9._003CSetupPenlightSettings_003Eb__13_0))) continue;
                if (settings == null) settings = new List<MobPenlightSetting>();
                settings.Add(setting);
            }
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(settings)) return;
            _runtimeMobPenlightSettings = new RuntimeMobPenlightSetting[settings.Count];
            for (int i = 0; i < _runtimeMobPenlightSettings.Length; i++)
            {
                var setting = settings[i];
                _runtimeMobPenlightSettings[i] = new RuntimeMobPenlightSetting
                {
                    MobActorIndex = setting.MobActorIndex,
                    ColorTableIndex = setting.ColorTableIndex,
                    Actor = setting.Actor,
                    MaterialInfos = setting.PenlightRenderers
                        .Where(_003C_003Ec._003C_003E9__13_1 ?? (_003C_003Ec._003C_003E9__13_1 = _003C_003Ec._003C_003E9._003CSetupPenlightSettings_003Eb__13_1))
                        .Select(_003C_003Ec._003C_003E9__13_2 ?? (_003C_003Ec._003C_003E9__13_2 = _003C_003Ec._003C_003E9._003CSetupPenlightSettings_003Eb__13_2)).ToArray()
                };
            }
        }

        private void CleanupPenlightSettings()
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_runtimeMobPenlightSettings)) return;
            foreach (var setting in _runtimeMobPenlightSettings)
            {
                if (setting == null) continue;
                foreach (var material in setting.MaterialInfos) material?.Dispose();
            }
            _runtimeMobPenlightSettings = null;
        }

        private void UpdatePenlightParams(ScriptableRenderContext context, Camera camera)
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(_runtimeMobPenlightSettings)) return;
            var stack = VolumeManager.instance.stack;
            var component = stack.GetComponent<AudiencePenlightVolumeComponent>();
            _penlightVolume = component.target.value != null ? component.target.value : _penlightVolume;
            var penlight = _penlightVolume != null ? _penlightVolume.AudiencePenlight : _defaultAudiencePenlight;
            CalcPenlightParams(penlight, stack, out var projectionParams, out var projectionUV, out var colorTableSize);
            foreach (var setting in _runtimeMobPenlightSettings)
            {
                foreach (var material in setting.MaterialInfos)
                {
                    material.InitializeProperty();
                    material.SetKeyword(UseColorProjectionKeyword, penlight.UseColorProjection);
                    if (penlight.UseColorProjection) UpdateProjectionParams(setting, material, projectionParams, projectionUV);
                    else UpdateColorTableParams(setting, material, penlight, colorTableSize);
                    material.ApplyProperty();
                }
            }
        }

        private void CalcPenlightParams(IAudiencePenlight penlight, VolumeStack stack, out float4 projectionParams, out float4 projectionUV, out int colorTableSize)
        {
            projectionParams = default;
            projectionUV = default;
            colorTableSize = 0;
            if (penlight == null) return;
            if (penlight.UseColorProjection)
            {
                var crowd = stack.GetComponent<global::Campus.Crowd.Crowd>().target.value;
                if (crowd == null || crowd.crowdData == null) return;
                var bounds = crowd.crowdData.aabb;
                var reciprocalSize = new float2(1f / (bounds.extents.x * 2f), 1f / (bounds.extents.z * 2f));
                projectionParams = new float4((bounds.center.x - bounds.extents.x) * reciprocalSize.x, (bounds.center.z - bounds.extents.z) * reciprocalSize.y, reciprocalSize.x, reciprocalSize.y);
                var min = penlight.ProjectionUvRectMin;
                var max = penlight.ProjectionUvRectMax;
                projectionUV = new float4(max.x - min.x, max.y - min.y, min.x, min.y);
            }
            else colorTableSize = Mathf.Min(penlight.ColorTable?.Length ?? 0, 8);
        }

        private void UpdateProjectionParams(RuntimeMobPenlightSetting setting, MaterialInfo materialInfo, float4 projectionParams, float4 projectionUV)
        {
            float3 position = setting.Actor.position;
            float2 uv = math.saturate(position.xz * projectionParams.zw - projectionParams.xy);
            uv = math.saturate(projectionUV.zw + projectionUV.xy * uv);
            materialInfo.SetVector(PenlightProjectionUvID, new Vector4(uv.x, uv.y, 0f, 0f));
        }

        private void UpdateColorTableParams(RuntimeMobPenlightSetting setting, MaterialInfo materialInfo, IAudiencePenlight penlight, int colorTableSize)
        {
            int index = setting.ColorTableIndex;
            if (!global::Qua.Extensions.IDictionaryExtensions.IsNullOrEmpty(_overrides) && _overrides.TryGetValue(setting.MobActorIndex, out var value)) index = value;
            Vector4 color = DefaultColor;
            if (colorTableSize > 0 && penlight.ColorTable != null) color = penlight.ColorTable[Mathf.Max(index, 0) % colorTableSize];
            materialInfo.SetVector(PenlightColorID, color);
        }

        public void ClearOverrides()
        {
            _overrides?.Clear();
        }

        public void SetOverrides(params MobAudiencePenlightOverride[] penlightOverrides)
        {
            if (global::Qua.Extensions.IEnumerableExtensions.IsNullOrEmpty(penlightOverrides)) return;
            if (_overrides == null) _overrides = new Dictionary<int, int>();
            foreach (var item in penlightOverrides)
            {
                if (_overrides.ContainsKey(item.TargetMobIndex)) _overrides[item.TargetMobIndex] = item.OverrideColorTableIndex;
                else _overrides.Add(item.TargetMobIndex, item.OverrideColorTableIndex);
            }
        }

        public MobAudiencePenlightController()
        {
        }
    }
}
