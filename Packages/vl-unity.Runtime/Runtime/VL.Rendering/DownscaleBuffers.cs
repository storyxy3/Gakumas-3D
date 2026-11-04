namespace VL.Rendering
{
    using global::UnityEngine.Rendering;
    using global::VL.Rendering;

    public class DownscaleBuffers
    {
        public static readonly int _LowResDepthTexture = UnityEngine.Shader.PropertyToID("_LowResDepthTexture");
        public static readonly int _ScreenSpaceShadowmapTexture = UnityEngine.Shader.PropertyToID("_ScreenSpaceShadowmapTexture");
        public static readonly int _DirectReflectionBuffer = UnityEngine.Shader.PropertyToID("_DirectReflectionBuffer");
        public static readonly int _TempDirectReflectionBuffer = UnityEngine.Shader.PropertyToID("_TempDirectReflectionBuffer");
        public static readonly int _DirectReflectionAccumulateBuffer = UnityEngine.Shader.PropertyToID("_DirectReflectionAccumulateBuffer");
        public static readonly int _TransparentBuffer = UnityEngine.Shader.PropertyToID("_TransparentBuffer");
        public static readonly int _TransparentDepthAttachment = UnityEngine.Shader.PropertyToID("_TransparentDepthAttachment");
        public static readonly int _DistortionBuffer = UnityEngine.Shader.PropertyToID("_DistortionBuffer");
        public RTHandle depthTexture = RTHandles.Alloc(_LowResDepthTexture, "_LowResDepthTexture");
        public RTHandle shadowAndOcclusion = RTHandles.Alloc(_ScreenSpaceShadowmapTexture, "_ScreenSpaceShadowmapTexture");
        public RTHandle directReflection = RTHandles.Alloc(_DirectReflectionBuffer, "_DirectReflectionBuffer");
        public RTHandle tmpDirectReflection = RTHandles.Alloc(_TempDirectReflectionBuffer, "_TempDirectReflectionBuffer");
        public VLCameraBufferSystem accumulation = new VLCameraBufferSystem();
        public RTHandle transparent = RTHandles.Alloc(_TransparentBuffer, "_TransparentBuffer");
        public RTHandle distortion = RTHandles.Alloc(_DistortionBuffer, "_DistortionBuffer");
        public void Dispose()
        {
            depthTexture?.Release();
            shadowAndOcclusion?.Release();
            directReflection?.Release();
            tmpDirectReflection?.Release();
            accumulation?.Release();
            transparent?.Release();
            distortion?.Release();
        }

        public DownscaleBuffers()
        {
        }
    }
}
