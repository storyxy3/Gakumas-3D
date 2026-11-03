namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    internal static class TouchDrawerUtils
    {
        private static readonly Vector3[] Corners;
        private static readonly List<Vector2> TouchPositions;
        internal static IReadOnlyList<Vector2> GetTouchPositions()
        {
            return null;
        }

        private static IReadOnlyList<Vector2> GetTouchPositionsFromInputManager()
        {
            return null;
        }

        private static Vector4 GetPadding(Graphic graphic)
        {
            return default(Vector4);
        }

        internal static Vector3[] GetWorldRaycastCorners(Graphic graphic)
        {
            return null;
        }
    }
}
