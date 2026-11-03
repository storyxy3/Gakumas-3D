namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public static class MaskGpuUtility
    {
        [Serializable]
        public struct GpuData
        {
            public Matrix4x4 worldToMask;
            public Vector4 maskRect;
            public Vector4 maskRectUv;
            public Vector4 maskBorder;
            public Vector4 maskBorderUv;
            public Vector2 tileRepeat;
            public Image.Type imageType;
        }

        public static GpuData GetGpuData(GraphicMaskTarget target)
        {
            return default(GpuData);
        }

        public static Vector4 GetMaskRect(Rect rect, Vector4 border)
        {
            return default(Vector4);
        }

        public static Vector2 MaskRepeat(Sprite sprite, Vector4 centralPart)
        {
            return default(Vector2);
        }

        public static Vector4 GetAdjustedBorders(Rect originalRect, Vector4 border, Vector4 adjustedRect)
        {
            return default(Vector4);
        }

        private static Vector4 RectToVector(Rect r)
        {
            return default(Vector4);
        }

        private static Vector4 Divide(Vector4 v, Vector2 s)
        {
            return default(Vector4);
        }

        private static Vector2 Divide(Vector2 v, Vector2 s)
        {
            return default(Vector2);
        }

        private static Vector4 Multiply(Vector4 v, Vector2 s)
        {
            return default(Vector4);
        }

        private static Vector2 Size(Vector4 r)
        {
            return default(Vector2);
        }

        private static Vector4 ApplyBorder(Vector4 v, Vector4 b)
        {
            return default(Vector4);
        }
    }
}
