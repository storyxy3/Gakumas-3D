namespace AmplifyOcclusion
{
    using global::AmplifyOcclusion;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::UnityEngine.Rendering.Universal;
    using global::UnityEngine.XR;

    public static class AmplifyOcclusionCommon
    {
        public static readonly float[] m_temporalRotations = { 60f, 300f, 180f, 240f, 120f, 0f };
        public static readonly float[] m_spatialOffsets = { 0f, 0.5f, 0.25f, 0.75f };
        public static void CommandBuffer_TemporalFilterDirectionsOffsets(CommandBuffer cb, uint aSampleStep)
        {
            float temporalRotation = m_temporalRotations[aSampleStep % 6];
            float temporalOffset = m_spatialOffsets[(aSampleStep / 6) % 4];
            cb.SetGlobalFloat(PropertyID._AO_TemporalDirections, temporalRotation / 360.0f);
            cb.SetGlobalFloat(PropertyID._AO_TemporalOffsets, temporalOffset);
        }

        public static bool IsStereoSinglePassEnabled(Camera aCamera)
        {
            return aCamera.stereoEnabled && XRSettings.eyeTextureDesc.vrUsage == VRTextureUsage.TwoEyes;
        }

        public static void UpdateGlobalShaderConstants(CommandBuffer cb, ref TargetDesc aTarget, ref CameraData cameraData, bool isDownsample, bool isFilterDownsample)
        {
            if (XRSettings.enabled)
            {
                aTarget.fullWidth = (int)(XRSettings.eyeTextureDesc.width * XRSettings.eyeTextureResolutionScale);
                aTarget.fullHeight = (int)(XRSettings.eyeTextureDesc.height * XRSettings.eyeTextureResolutionScale);
            }
            else
            {
                aTarget.fullWidth = cameraData.cameraTargetDescriptor.width;
                aTarget.fullHeight = cameraData.cameraTargetDescriptor.height;
            }
            if (isFilterDownsample)
            {
                aTarget.width = aTarget.fullWidth / 2;
                aTarget.height = aTarget.fullHeight / 2;
            }
            else
            {
                aTarget.width = aTarget.fullWidth;
                aTarget.height = aTarget.fullHeight;
            }
            aTarget.oneOverWidth = 1.0f / aTarget.width;
            aTarget.oneOverHeight = 1.0f / aTarget.height;
            float fovRad = cameraData.camera.fieldOfView * Mathf.Deg2Rad;
            float tanHalfFov = Mathf.Tan(fovRad * 0.5f);
            float invHalfTanFov = 1.0f / tanHalfFov;
            Vector2 focalLen = new Vector2(invHalfTanFov * ((float)aTarget.height / (float)aTarget.width), invHalfTanFov);
            Vector2 invFocalLen = new Vector2(1.0f / focalLen.x, 1.0f / focalLen.y);
            cb.SetGlobalVector(PropertyID._AO_UVToView, new Vector4(invFocalLen.x + invFocalLen.x, invFocalLen.y + invFocalLen.y, -invFocalLen.x, -invFocalLen.y));
            float projScale;
            if (cameraData.camera.orthographic)
                projScale = (float)aTarget.fullHeight / cameraData.camera.orthographicSize;
            else
                projScale = (float)aTarget.fullHeight / (tanHalfFov + tanHalfFov);
            if (isDownsample || isFilterDownsample)
                projScale *= 0.5f;
            cb.SetGlobalFloat(PropertyID._AO_HalfProjScale, projScale * 0.5f);
        }
    }
}
