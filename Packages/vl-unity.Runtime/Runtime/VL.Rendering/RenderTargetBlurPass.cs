namespace VL.Rendering
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::VL.Rendering;

    public class RenderTargetBlurPass : ScriptableRenderPass
    {
        private readonly ProfilingSampler _profilingSampler = new ProfilingSampler("VLSRP Render Target Blur");
        private readonly DownsampleBlur _blur;
        private VLSRPRenderTargetBlur _requester;
        private RTHandle _blurTarget;
        public RenderTargetBlurPass(RenderPassEvent e, Material material)
        {
            renderPassEvent = e;
            _blur = new DownsampleBlur("_RenderTargetBlur", material, 0, 1);
        }

        public void Dispose()
        {
            _blurTarget?.Release();
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (_requester == null && !renderingData.cameraData.camera.TryGetComponent(out _requester)) return;
            var cmd = CommandBufferPool.Get();
            using (new ProfilingScope(cmd, _profilingSampler))
            {
                context.ExecuteCommandBuffer(cmd);
                cmd.Clear();
                var requests = _requester.Requests;
                if (requests != null)
                {
                    foreach (var request in requests)
                    {
                        var descriptor = request.sourceDescriptor;
                        descriptor.width >>= 1;
                        descriptor.height >>= 1;
                        descriptor.msaaSamples = 1;
                        descriptor.graphicsFormat = (UnityEngine.Experimental.Rendering.GraphicsFormat)4;
                        _blur.ApplyBlur(cmd, request.source, descriptor, ref _blurTarget, request.blurSize);
                        Blitter.BlitCameraTexture(cmd, _blurTarget, request.destination);
                    }
                }
                _requester.Clear();
            }
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}
