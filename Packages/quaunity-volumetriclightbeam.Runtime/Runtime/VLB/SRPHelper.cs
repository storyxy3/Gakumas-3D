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
                return default(VLB.RenderPipeline);
            }
        }

        private static VLB.RenderPipeline ComputeRenderPipeline()
        {
            return default(VLB.RenderPipeline);
        }

        public static bool IsUsingCustomRenderPipeline()
        {
            return default(bool);
        }

        public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
        {
        }

        public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
        {
        }
    }
}
