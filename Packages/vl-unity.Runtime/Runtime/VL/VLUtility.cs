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
            return GetLimitedResolution(screenWidth, screenHeight, aspectRatio, maxBufferPixel, bufferScale, true);
        }

        private static (int, int) GetLimitedResolution(int screenWidth, int screenHeight, Vector2 aspectRatio, int maxBufferPixel, float bufferScale, bool firstCall)
        {
            float width = Mathf.Max(screenWidth * bufferScale, 16f);
            float height = Mathf.Max(screenHeight * bufferScale, 16f);
            bool noAspect = aspectRatio.y <= 0f || aspectRatio.x <= 0f;
            if (!noAspect && (aspectRatio.x > aspectRatio.y) != (width > height))
            {
                if (firstCall)
                {
                    var limited = GetLimitedResolution((int)width, (int)height, aspectRatio, maxBufferPixel, 1f, false);
                    maxBufferPixel = Mathf.Min(limited.Item1, limited.Item2);
                }
                float temp = width;
                width = height;
                height = temp;
            }
            float max = Mathf.Max(width, height);
            if (maxBufferPixel > 0 && max > maxBufferPixel)
            {
                float scale = maxBufferPixel / max;
                width *= scale;
                height *= scale;
            }
            if (!noAspect)
            {
                if (aspectRatio.x > aspectRatio.y) height *= (aspectRatio.y / aspectRatio.x * width) / height;
                else width *= (aspectRatio.x / aspectRatio.y * height) / width;
            }
            int w = (int)width;
            int h = (int)height;
            if (w % 2 == 1) w++;
            if (h % 2 == 1) h++;
            return (w, h);
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
