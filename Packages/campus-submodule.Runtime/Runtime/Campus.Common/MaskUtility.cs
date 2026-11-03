namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::Qua.PolygonUtility;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public static class MaskUtility
    {
        public enum ClippingType
        {
            Quad,
            PolygonHull,
            Polygon
        }

        public struct UIPolygon : IDisposable
        {
            public List<PolygonStride> strides;
            public void Dispose()
            {
            }
        }

        public struct PolygonStride : IDisposable
        {
            public Polygon polygon;
            public IReadOnlyList<UIVertexMini> uiVertices;
            public int triIndex;
            public int TriCount
            {
                get
                {
                    return default(int);
                }
            }

            public Vector2 GetUv0(Vector2 p)
            {
                return default(Vector2);
            }

            private bool GetUv0(Vector2 p, int start, int end, out Vector2 uv0)
            {
                throw null;
            }

            public void Dispose()
            {
            }
        }

        public struct UIVertexMini
        {
            public Vector2 position;
            public Vector2 uv0;
            public Vector2 uv1;
        }

        public struct UIQuad
        {
            public Rect position;
            public Rect uv0;
            public Rect uv1;
            public bool IsValid()
            {
                return default(bool);
            }

            public bool Overlaps(UIQuad target)
            {
                return default(bool);
            }

            public void Subtract(Rect rect, List<UIQuad> uIQuads)
            {
            }

            private UIQuad Cut(float xMin, float yMin, float xMax, float yMax)
            {
                return default(UIQuad);
            }

            public UIQuad Intersect(UIQuad target)
            {
                return default(UIQuad);
            }

            private Rect GetUv0Fragment(Rect rect)
            {
                return default(Rect);
            }

            private Rect GetUv1Fragment(Rect rect)
            {
                return default(Rect);
            }

            private static Rect GetUvFragment(Rect rect, Rect position, Rect uv)
            {
                return default(Rect);
            }
        }

        private static readonly Vector2 InvalidUv;
        public static void GetUIQuads(List<UIVertexMini> vertices, List<UIQuad> outputs)
        {
        }

        public static void GetFragmentQuads(IReadOnlyList<UIQuad> sources, IReadOnlyList<UIQuad> targets, List<UIQuad> outputs)
        {
        }

        private static Rect GetEncapsulateRect(IReadOnlyList<UIQuad> quads)
        {
            return default(Rect);
        }

        public static void AddQuads(VertexHelper vh, IReadOnlyList<UIQuad> quads, Graphic graphic)
        {
        }

        private static Rect MinMaxRect(Vector2 min, Vector2 max)
        {
            return default(Rect);
        }

        private static Rect GetInvalidUv()
        {
            return default(Rect);
        }

        private static bool IsInvalidUv(Rect uv)
        {
            return default(bool);
        }

        public static bool NeedHullCheck(Transform transform)
        {
            return default(bool);
        }

        public static ClippingType GetClippingType(Graphic graphic)
        {
            return default(ClippingType);
        }

        public static ClippingType Max(ClippingType a, ClippingType b)
        {
            return default(ClippingType);
        }

        public static void GetUIVertices(VertexHelper vh, Graphic graphic, List<UIVertexMini> outputs)
        {
        }

        public static void SetUIVertices(VertexHelper vh, Graphic graphic, List<UIVertexMini> outputs)
        {
        }

        public static UIPolygon GetUIPolygon(IReadOnlyList<UIVertexMini> uiVertices)
        {
            return default(UIPolygon);
        }

        public static UIPolygon GetSplitUIPolygon(IReadOnlyList<UIVertexMini> uiVertices)
        {
            return default(UIPolygon);
        }

        public static void GetMaskOutput(IReadOnlyList<UIVertexMini> sources, IReadOnlyList<UIVertexMini> targets, bool isHullOnly, List<UIVertexMini> outputs)
        {
        }

        private static void RemoveExclusiveQuads(UIPolygon subject, UIPolygon clip, bool move, List<UIVertexMini> outputs)
        {
        }

        private static void AddUniqPoints(PolygonStride stride, List<Vector2> points)
        {
        }

        private static void AddVertices(PolygonStride stride, List<UIVertexMini> outputs)
        {
        }

        private static void GetIntersects(UIPolygon subject, UIPolygon clip, List<UIVertexMini> outputs)
        {
        }

        private static void GetIntersects(Polygon subject, Polygon clip, List<Vector2> result)
        {
        }

        private static void GetDifferences(UIPolygon subject, UIPolygon clip, List<UIVertexMini> outputs)
        {
        }

        private static void GetDifferences(Polygon subject, Polygon clip, List<Vector2> result)
        {
        }

        private static void AddTriangles(List<Vector2> points, PolygonStride subject, PolygonStride clip, List<UIVertexMini> outputs)
        {
        }

        private static void AddTriangles(List<Vector2> points, PolygonStride subject, List<UIVertexMini> outputs)
        {
        }

        private static bool IsHullOverlap(IReadOnlyList<Vector2> hullA, IReadOnlyList<Vector2> hullB)
        {
            return default(bool);
        }
    }
}
