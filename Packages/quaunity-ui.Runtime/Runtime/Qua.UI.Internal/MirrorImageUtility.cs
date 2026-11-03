namespace Qua.UI.Internal
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    internal static class MirrorImageUtility
    {
        [MethodImpl(256)]
        public static bool HasFlag(MirrorImage.MirrorEdge merged, MirrorImage.MirrorEdge flag)
        {
            return default(bool);
        }

        public static void ModifyMirrorVertex(Graphic graphic, MirrorImage.MirrorEdge mirrorEdge, VertexHelper vh)
        {
        }

        private static void AddLine(bool mirrorLeft, bool mirrorRight, List<UIVertex> center, List<UIVertex> side, Vector2 offset, List<UIVertex> output)
        {
        }

        private static void AddInverseVertex(Vector2 pivot, Vector2 rectSize, Vector3 scale, bool inverseLeftRight, bool inverseUpDown, List<UIVertex> source, List<UIVertex> output)
        {
        }

        [MethodImpl(256)]
        private static void VertToTriangles(List<UIVertex> vertexList, List<int> indexList)
        {
        }

        [MethodImpl(256)]
        private static void AddVertex(List<UIVertex> source, List<UIVertex> output, Vector3 offset)
        {
        }

        [MethodImpl(256)]
        private static Quaternion GetInverseRotation(bool inverseUpDown, bool inverseLeftRight)
        {
            return default(Quaternion);
        }
    }
}
