namespace VL
{
    using global::UnityEngine;
    using global::VL;

    public interface IVLCameraController : IVLTransform
    {
        Camera mainCamera { get; }

        RenderTexture targetTexture { get; }

        RenderTexture capturedTexture { get; }

        Ray GetCameraRay();
        int GetCameraLayerMask();
    }
}
