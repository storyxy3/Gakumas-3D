namespace VL.ActorMesh
{
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;

    public struct CombineMeshJob : IJob
    {
        private int _maxVertexCount;
        [ReadOnly]
        private Mesh.MeshDataArray _readMeshArray;
        private Mesh.MeshData _writeMesh;
        public void Execute()
        {
        }
    }
}
