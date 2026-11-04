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
            renderPassEvent = RenderPassEvent.AfterRenderingOpaques;
            _maskMaterial = material;
            _profilingSampler = new ProfilingSampler(string.Format("MultiCameraMask({0})", index + 1));
        }

        public void Setup(Camera camera, VLMultiCamera.MultiCameraData data)
        {
            _camera = camera;
            _multiCameraData = data;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                if (_multiCameraData.maskRenderer != null && _maskMaterial != null)
                    cmd.DrawRenderer(_multiCameraData.maskRenderer, _maskMaterial);
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
