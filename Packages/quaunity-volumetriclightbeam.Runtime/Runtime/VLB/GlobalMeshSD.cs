namespace VLB
{
    using global::UnityEngine;

    public static class GlobalMeshSD
    {
        private static Mesh ms_Mesh;
        private static bool ms_DoubleSided;
        public static Mesh Get()
        {
            bool doubleSided = Config.Instance.SD_requiresDoubleSidedMesh;
            if (ms_Mesh == null || ms_DoubleSided != doubleSided)
            {
                Destroy();
                ms_Mesh = MeshGenerator.GenerateConeZ_Radii(1f, 1f, 1f, Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, false, doubleSided);
                ms_Mesh.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
                ms_DoubleSided = doubleSided;
            }
            return ms_Mesh;
        }

        public static void Destroy()
        {
            if (ms_Mesh != null)
            {
                UnityEngine.Object.DestroyImmediate(ms_Mesh);
                ms_Mesh = null;
            }
        }
    }
}
