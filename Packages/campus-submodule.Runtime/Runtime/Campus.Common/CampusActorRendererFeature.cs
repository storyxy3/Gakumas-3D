namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Rendering.Shaders;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;
    using global::VL.Core;
    using global::VL.Rendering;

    // APK 3.5.3: Create 0xDDEC3C4, AddRenderPasses 0xDDEC53C; pass .ctor 0xDDEC420, .cctor 0xDDED6DC,
    // Execute 0xDDEC564, SetupActorLighting 0xDDECC5C, OnCameraCleanup 0xDDED62C, <>c.b__9_0 0xDDED804.
    [DisallowMultipleRendererFeature("Campus Actor Renderer Feature")]
    public class CampusActorRendererFeature : ScriptableRendererFeature
    {
        private class CampusActorRenderPass : ScriptableRenderPass
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
                public static Func<IVLActorController, bool> _003C_003E9__9_0;
                public _003C_003Ec()
                {
                }

                internal bool _003CSetupActorLighting_003Eb__9_0(IVLActorController x)
                {
                    return x.index > 14;
                }
            }

            public static readonly int ShaderVariablesActorLightingId = Shader.PropertyToID("ShaderVariablesActorLighting");
            private static readonly string AdditionalActorLightsKeyword = "_ADDITIONAL_ACTOR_LIGHTS";
            private static readonly string ActorLightCookieKeyword = "_ACTOR_LIGHT_COOKIES";
            public const uint ActorShaderLayerMask = 4u;
            private List<IVLActorController> _visibleActorControllers = new List<IVLActorController>(16);
            private ShaderVariablesActorLighting _constantData;
            public CampusActorRenderPass()
            {
                renderPassEvent = (RenderPassEvent)0;
                profilingSampler = new ProfilingSampler("CampusActorRenderPass");
                _constantData = default;
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
                var actorControllers = VLActorController.actorControllers;
                if (actorControllers == null || actorControllers.Count == 0) return;
                _visibleActorControllers.Clear();
                Matrix4x4 vp = renderingData.cameraData.GetProjectionMatrix(0) * renderingData.cameraData.GetViewMatrix(0);
                var planes = new CameraPlanes(in vp);
                for (int i = 0; i < actorControllers.Count; i++)
                {
                    var actor = actorControllers[i];
                    if (actor.IsRendererActive() && planes.TestAABB(actor.bounds))
                        _visibleActorControllers.Add(actor);
                }
                if (_visibleActorControllers.Count == 0) return;
                var vlSrpRenderer = renderingData.cameraData.renderer as VLSRPRenderer;
                var cmd = CommandBufferPool.Get();
                using (new ProfilingScope(cmd, profilingSampler))
                {
                    SetupActorLighting(vlSrpRenderer, _visibleActorControllers, renderingData.cullResults.visibleLights,
                        out bool enableAdditionalActorLight, out bool enableActorLightCookie);
                    CoreUtils.SetKeyword(cmd, AdditionalActorLightsKeyword, enableAdditionalActorLight);
                    CoreUtils.SetKeyword(cmd, ActorLightCookieKeyword, enableActorLightCookie);
                    ConstantBuffer.PushGlobal(cmd, in _constantData, ShaderVariablesActorLightingId);
                }
                context.ExecuteCommandBuffer(cmd);
                CommandBufferPool.Release(cmd);
            }

            public override void OnCameraCleanup(CommandBuffer cmd)
            {
                CoreUtils.SetKeyword(cmd, AdditionalActorLightsKeyword, false);
                CoreUtils.SetKeyword(cmd, ActorLightCookieKeyword, false);
            }

            private void SetupActorLighting(VLSRPRenderer vlSrpRenderer, IReadOnlyList<IVLActorController> visibleActorControllers, NativeArray<VisibleLight> visibleLights, out bool enableAdditionalActorLight, out bool enableActorLightCookie)
            {
                if (visibleActorControllers.Any(_003C_003Ec._003C_003E9__9_0 ?? (_003C_003Ec._003C_003E9__9_0 = _003C_003Ec._003C_003E9._003CSetupActorLighting_003Eb__9_0)))
                {
                    enableAdditionalActorLight = false;
                    enableActorLightCookie = false;
                    return;
                }
                // Visible lights whose rendering layers include the actor shader layer, in visible-light order, at most 8.
                var lightIndices = ListPool<int>.Get();
                for (int i = 0; i < visibleLights.Length; i++)
                {
                    var additionalData = visibleLights[i].light.GetUniversalAdditionalLightData();
                    if ((additionalData.renderingLayers & ActorShaderLayerMask) != 0) lightIndices.Add(i);
                    if (lightIndices.Count == ShaderVariablesActorLighting.k_ACTOR_LIGHT_COUNT) break;
                }
                var spheres = new NativeArray<BoundingSphere>(lightIndices.Count, Allocator.Temp, NativeArrayOptions.ClearMemory);
                var positions = _constantData.LightPositions;
                var colors = _constantData.LightColors;
                var attenuations = _constantData.LightAttenuations;
                var directions = _constantData.LightDirections;
                var lightData = _constantData.LightData;
                for (int i = 0; i < lightIndices.Count; i++)
                {
                    int visibleLightIndex = lightIndices[i];
                    var additionalData = visibleLights[visibleLightIndex].light.GetUniversalAdditionalLightData();
                    float range = visibleLights[visibleLightIndex].lightType == LightType.Directional ? 1000f : visibleLights[visibleLightIndex].range;
                    var customLightingType = additionalData.customLightingType;
                    int cookieIndex = vlSrpRenderer != null ? vlSrpRenderer.GetLightCookieShaderDataIndex(visibleLightIndex) : -1;
                    UniversalRenderPipeline.InitializeLightConstants_Common(visibleLights, visibleLightIndex,
                        out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel);
                    positions[i] = lightPos;
                    colors[i] = new float4(lightColor.x, lightColor.y, lightColor.z, cookieIndex);
                    attenuations[i] = lightAttenuation;
                    directions[i] = new float4(lightSpotDir.x, lightSpotDir.y, lightSpotDir.z, (float)(int)customLightingType);
                    spheres[i] = new BoundingSphere(new Vector3(lightPos.x, lightPos.y, lightPos.z), range);
                }
                uint4 data = uint4.zero;
                enableAdditionalActorLight = false;
                enableActorLightCookie = false;
                for (int a = 0; a < visibleActorControllers.Count; a++)
                {
                    var actor = visibleActorControllers[a];
                    Bounds bounds = actor.bounds;
                    uint mask = 0;
                    int hits = 0;
                    for (int l = 0; l < spheres.Length; l++)
                    {
                        BoundingSphere sphere = spheres[l];
                        if (AABBUtility.TestSphereAABB(in bounds, in sphere))
                        {
                            hits++;
                            mask |= 1u << l;
                            if (colors[l].w >= 0f) enableActorLightCookie = true;
                        }
                    }
                    if (hits >= 1) enableAdditionalActorLight = true;
                    int index = actor.index;
                    data[index / 4] = (mask << (8 * (index & 3))) | data[index / 4];
                }
                uint lightBits = 0;
                for (int l = 0; l < lightIndices.Count; l++) lightBits |= 1u << (l & 31);
                data.w |= lightBits << 24;
                lightData[0] = data;
                spheres.Dispose();
                ListPool<int>.Release(lightIndices);
            }
        }

        private CampusActorRenderPass _campusActorRenderPass;
        public override void Create()
        {
            _campusActorRenderPass = new CampusActorRenderPass();
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            renderer.EnqueuePass(_campusActorRenderPass);
        }

        public CampusActorRendererFeature()
        {
        }
    }
}
