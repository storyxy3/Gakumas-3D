namespace Qua.PolygonUtility
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ClipperLib;
    using global::LibTessDotNet;
    using global::Qua.PolygonUtility;
    using global::UnityEngine;

    public static class PolygonUtility
    {
        public static class Clipper
        {
            private static readonly ClipperLib.Clipper clipper;
            public static Polygon Intersect(Polygon first, Polygon second)
            {
                return default(Polygon);
            }

            public static Polygon Difference(Polygon first, Polygon second)
            {
                return default(Polygon);
            }

            private static Polygon Execute(ClipType clipType, Polygon subject, Polygon clip)
            {
                return default(Polygon);
            }
        }

        public static class LibTess
        {
            private static readonly Tess tess;
            public static void Tessellate(Polygon polygon, List<Vector2> result)
            {
            }
        }

        private static readonly Comparison<Vector2> CompareVectorX;
        private static int _CompareVectorX(Vector2 a, Vector2 b)
        {
            return default(int);
        }

        public static void ConvexHull(List<Vector2> points, List<Vector2> hull)
        {
        }

        public static bool SegmentsIntersect(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, out Vector2 intersection)
        {
            throw null;
        }

        public static bool PointInPolygon(IReadOnlyList<Vector2> points, Vector2 p, bool includeCollinear = false)
        {
            return default(bool);
        }

        public static bool IsCollinear(Vector2 a, Vector2 b, Vector2 p)
        {
            return default(bool);
        }

        public static bool Barycentric(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w)
        {
            throw null;
        }

        private static int ScaleSubtract(float a, float b)
        {
            return default(int);
        }

        private static long CrossProduct(Vector2 a, Vector2 b)
        {
            return default(long);
        }

        private static long CrossProduct(Vector2 a, Vector2 b, Vector2 p)
        {
            return default(long);
        }

        private static long CrossProduct(Vector2 a, Vector2 b, Vector2 pa, Vector2 pb)
        {
            return default(long);
        }
    }
}
