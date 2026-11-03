namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class MultiCameraMaskPass : ScriptableRenderPass
    {
        private readonly ProfilingSampler _profilingSampler;
        private Material _maskMaterial;
        private Camera _camera;
        private VLMultiCamera.MultiCameraData _multiCameraData;
        public MultiCameraMaskPass(int index, Material material)
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
