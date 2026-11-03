namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::VLB;

    public static class MeshGenerator
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_0
        {
            public int numSides;
            public int vertCountSides;
            public Func<int, int> vertSidesStartFromSlide;
            public Func<int, int> vertCenterFromSlide;
            public _003C_003Ec__DisplayClass6_0()
            {
            }

            internal int _003CGenerateConeZ_Radii_DoubleCaps_003Eb__0(int slideID)
            {
                return default(int);
            }

            internal int _003CGenerateConeZ_Radii_DoubleCaps_003Eb__1(int slideID)
            {
                return default(int);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass6_1
        {
            public int[] indices;
            public int ind;
            public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;
            public _003C_003Ec__DisplayClass6_1()
            {
            }

            internal void _003CGenerateConeZ_Radii_DoubleCaps_003Eb__2(int slideID, bool invert)
            {
            }
        }

        private static float GetAngleOffset(int numSides)
        {
            return default(float);
        }

        private static float GetRadiiScale(int numSides)
        {
            return default(float);
        }

        public static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
        {
            return null;
        }

        public static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
        {
            return null;
        }

        public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
        {
            return default(Bounds);
        }
    }
}
