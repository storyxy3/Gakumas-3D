namespace Campus.Live
{
    using global::Campus.Live;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;

    [ExecuteAlways]
    public class CampusRenderInstances : MonoBehaviour
    {
        public struct TransformData
        {
            public Matrix4x4 objectToWorld;
        }

        [BurstCompile]
        private struct UpdateJob : IJobParallelForTransform
        {
            public NativeArray<TransformData> transformData;
            public void Execute(int index, TransformAccess transform)
            {
            }
        }

        private const int MaxRenderInstanceCount = 500;
        private static readonly int CanvasScaleOffset;
        private static readonly int CanvasUVScale;
        private static readonly int BaseInstanceIdOffset;
        [SerializeField]
        private Mesh _mesh;
        [SerializeField]
        private Material _material;
        [SerializeField]
        private Transform _rootTransform;
        [SerializeField]
        private Vector2 _uvScale;
        [SerializeField]
        private Vector2 _startPosition;
        [SerializeField]
        private float _xOffset;
        [SerializeField]
        private float _yOffset;
        [SerializeField]
        [Min(1f)]
        private int _numPerRow;
        [SerializeField]
        private int _monitorSize;
        private TransformAccessArray _transformAccessArray;
        private NativeArray<TransformData> _transformData;
        private UpdateJob _updateJob;
        private RenderParams _renderParams;
        private void OnEnable()
        {
        }

        private void Initialize()
        {
        }

        private void OnDisable()
        {
        }

        private void Dispose()
        {
        }

        private void LateUpdate()
        {
        }

        public CampusRenderInstances()
        {
        }
    }
}
