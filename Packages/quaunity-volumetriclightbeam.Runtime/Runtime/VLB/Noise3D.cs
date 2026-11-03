namespace VLB
{
    using global::UnityEngine;

    public static class Noise3D
    {
        private static bool ms_IsSupportedChecked;
        private static bool ms_IsSupported;
        private static Texture3D ms_NoiseTexture;
        public static bool isSupported
        {
            get
            {
                return default(bool);
            }
        }

        public static string isNotSupportedString
        {
            get
            {
                return null;
            }
        }

        [RuntimeInitializeOnLoadMethod]
        private static void OnStartUp()
        {
        }

        public static void LoadIfNeeded()
        {
        }
    }
}
