namespace Campus.Common
{
    using global::System;
    using global::Cinemachine;
    using global::UnityEngine;
    using global::VL.Rendering;

    public static class CampusSubmoduleInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void BeforeSceneLoad()
        {
            LightmapSettings.lightmapsMode = LightmapsMode.NonDirectional;
            RegisterTryFormats();
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void AfterAssembliesLoaded()
        {
            CinemachineCore.CameraCutEvent.RemoveListener(OnCameraCutChanged);
            CinemachineCore.CameraCutEvent.AddListener(OnCameraCutChanged);
        }

        private static void OnCameraCutChanged(CinemachineBrain brain)
        {
            if (brain.TryGetComponent<VLSRPCameraController>(out var cameraController))
                cameraController.ResetHistory();
        }

        // APK 3.5.3 registers TryFormatInvariant<float/double/DateTime/DateTimeOffset> with Cysharp.Text.Utf16ValueStringBuilder.RegisterTryFormat.
        // ZString is not part of this player (nothing on the live path formats through it), so there is nothing to register.
        public static void RegisterTryFormats()
        {
        }

        private static bool TryFormatInvariant<T>(T value, Span<char> dest, out int written, ReadOnlySpan<char> format)
            where T : struct, IFormattable
        {
            throw null;
        }
    }
}
