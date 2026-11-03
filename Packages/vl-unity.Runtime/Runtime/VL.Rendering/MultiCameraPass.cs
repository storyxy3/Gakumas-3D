namespace VL.Rendering
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class MultiCameraPass : ScriptableRenderPass
    {
        public const int SubCameraStencilMask = 24;
        private RenderStateBlock _stateBlock;
        private FilteringSettings _filteringSettings;
        private List<ShaderTagId> _shaderTagIds;
        private readonly ProfilingSampler _profilingSampler;
        private Camera _camera;
        private VLMultiCamera.MultiCameraData _multiCameraData;
        public MultiCameraPass(int index, int stencilId, RenderPassEvent passEvent, DrawMultiCameraPass.Settings settings)
        {
        }

        public void Setup(Camera camera, VLMultiCamera.MultiCameraData data)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
