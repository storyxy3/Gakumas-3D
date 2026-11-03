namespace VL
{
    using global::System.Runtime.InteropServices;
    using global::Unity.Collections;
    using global::UnityEngine;

    public static class VLMeshUtility
    {
        public static readonly int g_FirstVert;
        public static readonly int g_VertCount;
        public static readonly int g_Weight;
        public static readonly int inVertices;
        public static readonly int inoutVertices;
        public static readonly int inSkins;
        public static readonly int inMatrices;
        public static readonly int inBlendShapeVertices;
        public static uint PackWeightAndIndex(float weight, int index)
        {
            return default(uint);
        }

        public static Mesh CopyMesh(Mesh srcMesh, [Optional] NativeSlice<byte> vertexBuffer0)
        {
            return null;
        }

        public static Mesh CreateBoxMesh()
        {
            return null;
        }
    }
}
