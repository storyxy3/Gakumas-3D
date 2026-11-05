namespace VLB
{
    public static class ShaderProperties
    {
        public static class SD
        {
            public static readonly int FadeOutFactor = UnityEngine.Shader.PropertyToID("_FadeOutFactor");
            public static readonly int ConeSlopeCosSin = UnityEngine.Shader.PropertyToID("_ConeSlopeCosSin");
            public static readonly int AlphaInside = UnityEngine.Shader.PropertyToID("_AlphaInside");
            public static readonly int AlphaOutside = UnityEngine.Shader.PropertyToID("_AlphaOutside");
            public static readonly int AttenuationLerpLinearQuad = UnityEngine.Shader.PropertyToID("_AttenuationLerpLinearQuad");
            public static readonly int DistanceCamClipping = UnityEngine.Shader.PropertyToID("_DistanceCamClipping");
            public static readonly int FresnelPow = UnityEngine.Shader.PropertyToID("_FresnelPow");
            public static readonly int GlareBehind = UnityEngine.Shader.PropertyToID("_GlareBehind");
            public static readonly int GlareFrontal = UnityEngine.Shader.PropertyToID("_GlareFrontal");
            public static readonly int DrawCap = UnityEngine.Shader.PropertyToID("_DrawCap");
            public static readonly int DepthBlendDistance = UnityEngine.Shader.PropertyToID("_DepthBlendDistance");
            public static readonly int CameraParams = UnityEngine.Shader.PropertyToID("_CameraParams");
            public static readonly int DynamicOcclusionClippingPlaneWS = UnityEngine.Shader.PropertyToID("_DynamicOcclusionClippingPlaneWS");
            public static readonly int DynamicOcclusionClippingPlaneProps = UnityEngine.Shader.PropertyToID("_DynamicOcclusionClippingPlaneProps");
            public static readonly int DynamicOcclusionDepthTexture = UnityEngine.Shader.PropertyToID("_DynamicOcclusionDepthTexture");
            public static readonly int DynamicOcclusionDepthProps = UnityEngine.Shader.PropertyToID("_DynamicOcclusionDepthProps");
            public static readonly int LocalForwardDirection = UnityEngine.Shader.PropertyToID("_LocalForwardDirection");
            public static readonly int TiltVector = UnityEngine.Shader.PropertyToID("_TiltVector");
            public static readonly int AdditionalClippingPlaneWS = UnityEngine.Shader.PropertyToID("_AdditionalClippingPlaneWS");
        }

        public static class HD
        {
            public static readonly int Intensity = UnityEngine.Shader.PropertyToID("_Intensity");
            public static readonly int SideSoftness = UnityEngine.Shader.PropertyToID("_SideSoftness");
            public static readonly int CameraForwardOS = UnityEngine.Shader.PropertyToID("_CameraForwardOS");
            public static readonly int CameraForwardWS = UnityEngine.Shader.PropertyToID("_CameraForwardWS");
            public static readonly int TransformScale = UnityEngine.Shader.PropertyToID("_TransformScale");
            public static readonly int ShadowDepthTexture = UnityEngine.Shader.PropertyToID("_ShadowDepthTexture");
            public static readonly int ShadowProps = UnityEngine.Shader.PropertyToID("_ShadowProps");
            public static readonly int Jittering = UnityEngine.Shader.PropertyToID("_Jittering");
            public static readonly int CookieTexture = UnityEngine.Shader.PropertyToID("_CookieTexture");
            public static readonly int CookieProperties = UnityEngine.Shader.PropertyToID("_CookieProperties");
            public static readonly int CookiePosAndScale = UnityEngine.Shader.PropertyToID("_CookiePosAndScale");
            public static readonly int GlobalCameraBlendingDistance = UnityEngine.Shader.PropertyToID("_VLB_CameraBlendingDistance");
            public static readonly int GlobalJitteringNoiseTex = UnityEngine.Shader.PropertyToID("_VLB_JitteringNoiseTex");
        }

        public static readonly int ConeRadius = UnityEngine.Shader.PropertyToID("_ConeRadius");
        public static readonly int ConeGeomProps = UnityEngine.Shader.PropertyToID("_ConeGeomProps");
        public static readonly int ColorFlat = UnityEngine.Shader.PropertyToID("_ColorFlat");
        public static readonly int DistanceFallOff = UnityEngine.Shader.PropertyToID("_DistanceFallOff");
        public static readonly int NoiseVelocityAndScale = UnityEngine.Shader.PropertyToID("_NoiseVelocityAndScale");
        public static readonly int NoiseParam = UnityEngine.Shader.PropertyToID("_NoiseParam");
        public static readonly int ColorGradientMatrix = UnityEngine.Shader.PropertyToID("_ColorGradientMatrix");
        public static readonly int LocalToWorldMatrix = UnityEngine.Shader.PropertyToID("_LocalToWorldMatrix");
        public static readonly int WorldToLocalMatrix = UnityEngine.Shader.PropertyToID("_WorldToLocalMatrix");
        public static readonly int BlendSrcFactor = UnityEngine.Shader.PropertyToID("_BlendSrcFactor");
        public static readonly int BlendDstFactor = UnityEngine.Shader.PropertyToID("_BlendDstFactor");
        public static readonly int ZTest = UnityEngine.Shader.PropertyToID("_ZTest");
        public static readonly int ParticlesTintColor = UnityEngine.Shader.PropertyToID("_TintColor");
        public static readonly int HDRPExposureWeight = UnityEngine.Shader.PropertyToID("_HDRPExposureWeight");
        public static readonly int GlobalUsesReversedZBuffer = UnityEngine.Shader.PropertyToID("_VLB_UsesReversedZBuffer");
        public static readonly int GlobalNoiseTex3D = UnityEngine.Shader.PropertyToID("_VLB_NoiseTex3D");
        public static readonly int GlobalNoiseCustomTime = UnityEngine.Shader.PropertyToID("_VLB_NoiseCustomTime");
        public static readonly int GlobalDitheringFactor = UnityEngine.Shader.PropertyToID("_VLB_DitheringFactor");
        public static readonly int GlobalDitheringNoiseTex = UnityEngine.Shader.PropertyToID("_VLB_DitheringNoiseTex");
        public static readonly int GlobalNoiseTex2D = UnityEngine.Shader.PropertyToID("_VLB_NoiseTex2D");
    }
}
