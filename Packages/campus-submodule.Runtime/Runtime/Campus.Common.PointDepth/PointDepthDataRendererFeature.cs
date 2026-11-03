namespace Campus.Common.PointDepth
{
    using global::Campus.Common.PointDepth;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public class PointDepthDataRendererFeature : ScriptableRendererFeature
    {
        private class PointDepthDataPass : ScriptableRenderPass
        {
            private readonly int _outputBufferId;
            private readonly int _viewportPointId;
            private readonly int _kernelIndex;
            private readonly ComputeShader _depthComputeShader;
            public GraphicsBuffer OutputBuffer;
            public Vector2 ViewportPoint;
            public PointDepthDataPass(ComputeShader computeShader)
            {
            }

            public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
            {
            }
        }

        public ComputeShader depthComputeShader;
        private PointDepthDataPass _pointDepthDataPass;
        private const string PointDepthKernelName = "GetPointDepthData";
        public override void Create()
        {
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
        }

        public PointDepthDataRendererFeature()
        {
        }
    }
}
