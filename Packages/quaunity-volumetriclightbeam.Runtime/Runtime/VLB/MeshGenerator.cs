namespace VLB
{
    using global::UnityEngine;

    public static class MeshGenerator
    {
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
