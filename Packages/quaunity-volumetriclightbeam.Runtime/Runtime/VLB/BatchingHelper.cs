namespace VLB
{
    using global::UnityEngine;

    public static class BatchingHelper
    {
        public static bool forceEnableDepthBlend
        {
            get
            {
                var mode = Config.Instance.GetActualRenderingMode(ShaderMode.SD);
                return mode == RenderingMode.GPUInstancing || mode == RenderingMode.SRPBatcher;
            }
        }

        public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
        {
            material.enableInstancing = enableGpuInstancing;
        }
    }
}
