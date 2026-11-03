namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;

    public static class AmplifyOcclusionCommon
    {
        public static readonly float[] m_temporalRotations;
        public static readonly float[] m_spatialOffsets;
        public static void CommandBuffer_TemporalFilterDirectionsOffsets(CommandBuffer cb, uint aSampleStep)
        {
        }

        public static bool IsStereoSinglePassEnabled(Camera aCamera)
        {
            return default(bool);
        }

        public static void UpdateGlobalShaderConstants(CommandBuffer cb, ref TargetDesc aTarget, ref CameraData cameraData, bool isDownsample, bool isFilterDownsample)
        {
        }
    }
}
