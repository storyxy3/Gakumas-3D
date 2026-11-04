namespace VLB
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VLB;

    public static class SRPHelper
    {
        private static bool m_IsRenderPipelineCached;
        private static VLB.RenderPipeline m_RenderPipelineCached;
        public static VLB.RenderPipeline projectRenderPipeline
        {
            get
            {
                if (!m_IsRenderPipelineCached)
                {
                    m_RenderPipelineCached = ComputeRenderPipeline();
                    m_IsRenderPipelineCached = true;
                }
                return m_RenderPipelineCached;
            }
        }

        private static VLB.RenderPipeline ComputeRenderPipeline()
        {
            var pipeline = GraphicsSettings.defaultRenderPipeline;
            if (pipeline)
            {
                string name = pipeline.GetType().ToString();
                if (name.Contains("Universal") || name.Contains("Lightweight"))
                    return VLB.RenderPipeline.URP;
                if (name.Contains("HD"))
                    return VLB.RenderPipeline.HDRP;
            }
            return VLB.RenderPipeline.BuiltIn;
        }

        public static bool IsUsingCustomRenderPipeline()
        {
            return RenderPipelineManager.currentPipeline != null || GraphicsSettings.defaultRenderPipeline != null;
        }

        public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
        {
        }

        public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
        {
        }
    }
}
