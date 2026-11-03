namespace VL.Rendering
{
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    public class DownscaleBuffers
    {
        public static readonly int _LowResDepthTexture;
        public static readonly int _ScreenSpaceShadowmapTexture;
        public static readonly int _DirectReflectionBuffer;
        public static readonly int _TempDirectReflectionBuffer;
        public static readonly int _DirectReflectionAccumulateBuffer;
        public static readonly int _TransparentBuffer;
        public static readonly int _TransparentDepthAttachment;
        public static readonly int _DistortionBuffer;
        public RTHandle depthTexture;
        public RTHandle shadowAndOcclusion;
        public RTHandle directReflection;
        public RTHandle tmpDirectReflection;
        public VLCameraBufferSystem accumulation;
        public RTHandle transparent;
        public RTHandle distortion;
        public void Dispose()
        {
        }

        public DownscaleBuffers()
        {
        }
    }
}
