namespace Campus.Common.GoboLight
{
    using global::System.Collections.Generic;
    using global::Campus.Common.GoboLight;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;

    [RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
    [ExecuteAlways]
    public class GoboLightController : MonoBehaviour
    {
        public int splitU;
        public int splitV;
        [HideInInspector]
        public int meshDivide;
        public List<GoboLight> lights;
        private bool _isDirty;
        private MeshFilter _meshFilter;
        private Mesh _mesh;
        private JobHandle _jobHandle;
        private NativeArray<GoboData> _data;
        private NativeArray<LightData> _lightData;
        private TransformAccessArray _transformAccessArray;
        private NativeArray<float4> _sourceVertices;
        private NativeArray<float3> _sourceUVs;
        private NativeArray<VertexLayout> _vertexData;
        private NativeArray<ushort> _indexData;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void DisposeArray()
        {
        }

        private void UpdateJob()
        {
        }

        private void LateUpdate()
        {
        }

        public GoboLightController()
        {
        }
    }
}
