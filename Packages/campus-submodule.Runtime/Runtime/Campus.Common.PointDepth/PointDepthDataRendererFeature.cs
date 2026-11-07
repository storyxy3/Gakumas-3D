namespace Campus.Common.PointDepth
{
    using global::Campus.Common;
    using global::Campus.Common.PointDepth;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class PointDepthDataRendererFeature : ScriptableRendererFeature
    {
        private class PointDepthDataPass : ScriptableRenderPass
        {
            private readonly int _outputBufferId = Shader.PropertyToID("_OutputBuffer");
            private readonly int _viewportPointId = Shader.PropertyToID("_ViewportPoint");
            private readonly int _kernelIndex;
            private readonly ComputeShader _depthComputeShader;
            public GraphicsBuffer OutputBuffer;
            public Vector2 ViewportPoint;
            public PointDepthDataPass(ComputeShader computeShader)
            {
                profilingSampler = new ProfilingSampler("PointDepthDataPass");
                _depthComputeShader = computeShader;
                renderPassEvent = RenderPassEvent.BeforeRenderingPostProcessing;
                _kernelIndex = _depthComputeShader.FindKernel(PointDepthKernelName);
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
                CommandBuffer cmd = CommandBufferPool.Get();
                using (new ProfilingScope(cmd, profilingSampler))
                {
                    cmd.SetComputeBufferParam(_depthComputeShader, _kernelIndex, _outputBufferId, OutputBuffer);
                    cmd.SetComputeVectorParam(_depthComputeShader, _viewportPointId, ViewportPoint);
                    cmd.DispatchCompute(_depthComputeShader, _kernelIndex, 1, 1, 1);
                }
                context.ExecuteCommandBuffer(cmd);
                CommandBufferPool.Release(cmd);
            }
        }

        public ComputeShader depthComputeShader;
        private PointDepthDataPass _pointDepthDataPass;
        private const string PointDepthKernelName = "GetPointDepthData";
        public override void Create()
        {
            if (SystemInfo.supportsComputeShaders && depthComputeShader != null && depthComputeShader.HasKernel(PointDepthKernelName))
                _pointDepthDataPass = new PointDepthDataPass(depthComputeShader);
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (_pointDepthDataPass == null || renderingData.cameraData.cameraType != CameraType.Game)
                return;
            if (!renderingData.cameraData.camera.TryGetComponent(out PointDepthData pointDepthData))
                return;
            if (!pointDepthData.IsCapture || !pointDepthData.OutputBuffer.IsValid())
                return;
            pointDepthData.IsCapture = false;
            _pointDepthDataPass.ViewportPoint = pointDepthData.ViewportPoint;
            _pointDepthDataPass.OutputBuffer = pointDepthData.OutputBuffer;
            renderer.EnqueuePass(_pointDepthDataPass);
        }

        public PointDepthDataRendererFeature()
        {
        }
    }
}
