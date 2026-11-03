namespace LibTessDotNet
{
    using global::LibTessDotNet;

    internal static class Geom
    {
        public static bool IsWindingInside(WindingRule rule, int n)
        {
            return default(bool);
        }

        public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
        {
            return default(bool);
        }

        public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
        {
            return default(bool);
        }

        public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
        {
            return default(bool);
        }

        public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
        {
            return default(float);
        }

        public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
        {
            return default(float);
        }

        public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
        {
            return default(bool);
        }

        public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
        {
            return default(float);
        }

        public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
        {
            return default(float);
        }

        public static bool EdgeGoesLeft(MeshUtils.Edge e)
        {
            return default(bool);
        }

        public static bool EdgeGoesRight(MeshUtils.Edge e)
        {
            return default(bool);
        }

        public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
        {
            return default(float);
        }

        public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
        {
        }

        public static float Interpolate(float a, float x, float b, float y)
        {
            return default(float);
        }

        private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
        {
        }

        public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
        {
        }
    }
}
