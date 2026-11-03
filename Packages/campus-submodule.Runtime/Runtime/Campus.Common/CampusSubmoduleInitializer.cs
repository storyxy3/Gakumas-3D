namespace Campus.Common
{
    using global::System;
    using global::Cinemachine;
    using global::UnityEngine;

    public static class CampusSubmoduleInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void BeforeSceneLoad()
        {
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void AfterAssembliesLoaded()
        {
        }

        private static void OnCameraCutChanged(CinemachineBrain brain)
        {
        }

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
