namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::Campus.Rendering.Shaders;
    using global::Unity.Collections;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;
    using global::VL.Rendering;

    [DisallowMultipleRendererFeature("Campus Actor Renderer Feature")]
    public class CampusActorRendererFeature : ScriptableRendererFeature
    {
        private class CampusActorRenderPass : ScriptableRenderPass
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Func<IVLActorController, bool> _003C_003E9__9_0;
                public _003C_003Ec()
                {
                }

                internal bool _003CSetupActorLighting_003Eb__9_0(IVLActorController x)
                {
                    return default(bool);
                }
            }

            public static readonly int ShaderVariablesActorLightingId;
            private static readonly string AdditionalActorLightsKeyword;
            private static readonly string ActorLightCookieKeyword;
            public const uint ActorShaderLayerMask = 4u;
            private List<IVLActorController> _visibleActorControllers;
            private ShaderVariablesActorLighting _constantData;
            public CampusActorRenderPass()
            {
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
            }

            public override void OnCameraCleanup(CommandBuffer cmd)
            {
            }

            private void SetupActorLighting(VLSRPRenderer vlSrpRenderer, IReadOnlyList<IVLActorController> visibleActorControllers, NativeArray<VisibleLight> visibleLights, out bool enableAdditionalActorLight, out bool enableActorLightCookie)
            {
                throw null;
            }
        }

        private CampusActorRenderPass _campusActorRenderPass;
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public CampusActorRendererFeature()
        {
        }
    }
}
