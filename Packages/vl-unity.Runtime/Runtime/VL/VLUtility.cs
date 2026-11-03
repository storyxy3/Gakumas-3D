namespace VL
{
    using global::UnityEngine;
    using global::UnityEngine.Experimental.Rendering;

    public static class VLUtility
    {
        public static bool FastStartsWith(string str, string value)
        {
            return default(bool);
        }

        public static void DestroyObject(Object target)
        {
        }

        public static (int, int) GetLimitedResolution(int screenWidth, int screenHeight, Vector2 aspectRatio, int maxBufferPixel, float bufferScale)
        {
            return default((int, int));
        }

        private static (int, int) GetLimitedResolution(int screenWidth, int screenHeight, Vector2 aspectRatio, int maxBufferPixel, float bufferScale, bool firstCall)
        {
            return default((int, int));
        }

        public static int GetEvenNumber(float num)
        {
            return default(int);
        }

        public static GraphicsFormat GetHDRFormat(bool needsAlpha = false, FormatUsage flags = FormatUsage.Blend)
        {
            return default(GraphicsFormat);
        }
    }
}
