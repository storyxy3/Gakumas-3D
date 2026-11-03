namespace Campus.Common.Extensions
{
    using global::DG.Tweening;
    using global::UnityEngine;

    public static class RectTransformExtensions
    {
        private static readonly Vector3[] WorldCorners;
        public static Rect GetWorldRect(this RectTransform target)
        {
            return default(Rect);
        }

        public static float GetOffsetLeft(this RectTransform target)
        {
            return default(float);
        }

        public static void SetOffsetLeft(this RectTransform target, float value)
        {
        }

        public static float GetOffsetBottom(this RectTransform target)
        {
            return default(float);
        }

        public static void SetOffsetBottom(this RectTransform target, float value)
        {
        }

        public static float GetOffsetRight(this RectTransform target)
        {
            return default(float);
        }

        public static void SetOffsetRight(this RectTransform target, float value)
        {
        }

        public static void SetOffsetTop(this RectTransform target, float value)
        {
        }

        public static Tween DOOffsetBottom(this RectTransform target, float value, float duration)
        {
            return null;
        }

        public static void ResetAnchorAndPivot(this RectTransform target, Vector2 basePoint)
        {
        }

        public static Tween DOResetAnchorAndPivot(this RectTransform target, Vector2 basePoint, float duration)
        {
            return null;
        }
    }
}
