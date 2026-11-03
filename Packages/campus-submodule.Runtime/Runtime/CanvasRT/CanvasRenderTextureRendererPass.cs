namespace CanvasRT
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::Campus.Live.Monitor;
    using global::CanvasRT;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class CanvasRenderTextureRendererPass : ScriptableRenderPass
    {
        private static readonly ProfilingSampler _profilingSampler;
        private FilteringSettings _filteringSettings;
        private FilteringSettings _overlayFilteringSettings;
        private RenderStateBlock _renderStateBlock;
        private readonly List<ShaderTagId> _actorShaderTagIds;
        private readonly List<ShaderTagId> _shaderTagIds;
        private UIDrawObjects _actorDrawObjects;
        private CustomRenderPassData _renderPass;
        private CustomSubPassData[] _subPass;
        private VolumeStack _volumeStack;
        private LayerMask _layerMask;
        public CanvasRenderTextureRendererPass(CanvasRenderTextureRendererData data)
        {
        }

        public void Dispose()
        {
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        private void Draw3DImage(ScriptableRenderContext context, ref RenderingData renderingData, CommandBuffer cmd, Monitor3DImage image)
        {
        }

        private void OnRenderCanvasRenderTexture(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
