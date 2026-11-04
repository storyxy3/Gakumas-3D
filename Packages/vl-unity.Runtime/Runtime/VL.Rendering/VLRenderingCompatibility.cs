namespace VL.Rendering
{
    using UnityEngine;
    using UnityEngine.Rendering;
    using UnityEngine.Rendering.Universal;

    // TODO(qa-recon): relocate these APK bodies to RenderingUtility in the separately owned URP fork,
    // then restore the original call targets. APK RVAs: 0xd7d919c and 0xd7d92f8.
    internal static class VLRenderingCompatibility
    {
        internal static void SetGlobalMipBias(CommandBuffer cmd, ref CameraData cameraData, float scale)
        {
            float width = cameraData.cameraTargetDescriptor.width * scale;
            int pixelWidth = cameraData.camera.pixelWidth;
            if (cameraData.camera.allowDynamicResolution) width *= ScalableBufferManager.widthScaleFactor;
            float bias = Mathf.Min(-Mathf.Log(pixelWidth / width, 2f), 0f);
            bias = Mathf.Min(bias, Mathf.Min(cameraData.taaSettings.mipBias, 0f));
            cmd.SetGlobalVector(ShaderPropertyId.globalMipBias, new Vector4(bias, Mathf.Pow(2f, bias), 0f, 0f));
        }

        // APK CameraData.taaSettings.m_FrameInfluence is the second 32-bit field.
        // The URP fork exposes only its complemented public property.
        internal static unsafe float GetFrameInfluence(ref TemporalAA.Settings settings)
        {
            return ((float*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref settings))[1];
        }

        internal static MotionVectorsPersistentData GetMotionVectorData(ref CameraData cameraData)
        {
            return cameraData.camera.TryGetComponent<UniversalAdditionalCameraData>(out var data)
                ? data.motionVectorsPersistentData : null;
        }
    }
}
