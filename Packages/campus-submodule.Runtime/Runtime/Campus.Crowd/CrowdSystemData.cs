namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CrowdSystemData : IDisposable
    {
        private static readonly int PersonInfoBytesStride = 16;
        private static readonly string UpdatePersonKernel = "UpdatePerson";
        private static readonly int PersonInfoBufferID = Shader.PropertyToID("_PersonInfoBuffer");
        private static readonly int PersonInfoBytesBufferID = Shader.PropertyToID("_PersonInfoBytesBuffer");
        private static readonly int PersonIndexBufferID = Shader.PropertyToID("_PersonIndexBuffer");
        private static readonly int BoundingMinID = Shader.PropertyToID("_BoundingMin");
        private static readonly int NonBillboardPersonCountID = Shader.PropertyToID("_NonBillboardPersonCount");
        private static readonly int VisiblePersonCountID = Shader.PropertyToID("_VisiblePersonCount");
        private static readonly int PenlightInfoBufferID = Shader.PropertyToID("_PenlightInfoBuffer");
        private readonly CrowdData _crowdData;
        private readonly GraphicsBuffer _personInfoBuffer;
        private readonly GraphicsBuffer _animationMatricesBuffer;
        private readonly GraphicsBuffer _personInfoBytesBuffer;
        private readonly GraphicsBuffer _personIndexBuffer;
        private readonly GraphicsBuffer _penlightInfoBuffer;
        private NativeArray<PersonInfo> _personInfos;
        private NativeArray<OctreeInfo> _octreeInfos;
        private NativeArray<uint> _personIndexes;
        private NativeArray<int> _instanceCountsPerSubMesh;
        private NativeReference<int> _billboardInstanceCount;
        [CompilerGenerated]
        private ComputeShader _003CCrowdCompute_003Ek__BackingField;
        [CompilerGenerated]
        private Bounds _003CBounds_003Ek__BackingField;
        [CompilerGenerated]
        private Bounds _003CBaseCellBounds_003Ek__BackingField;
        private int _updatePersonKernelIndex;
        public ComputeShader CrowdCompute
        {
            [CompilerGenerated]
            get
            {
                return _003CCrowdCompute_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCrowdCompute_003Ek__BackingField = value;
            }
        }

        public Bounds Bounds
        {
            [CompilerGenerated]
            get
            {
                return _003CBounds_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CBounds_003Ek__BackingField = value;
            }
        }

        public Bounds BaseCellBounds
        {
            [CompilerGenerated]
            get
            {
                return _003CBaseCellBounds_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CBaseCellBounds_003Ek__BackingField = value;
            }
        }

        public GraphicsBuffer PersonInfoBuffer
        {
            get
            {
                return _personInfoBuffer;
            }
        }

        public GraphicsBuffer AnimationMatricesBuffer
        {
            get
            {
                return _animationMatricesBuffer;
            }
        }

        public GraphicsBuffer PersonInfoBytesBuffer
        {
            get
            {
                return _personInfoBytesBuffer;
            }
        }

        public GraphicsBuffer PersonIndexBuffer
        {
            get
            {
                return _personIndexBuffer;
            }
        }

        public NativeArray<PersonInfo> PersonInfos
        {
            get
            {
                return _personInfos;
            }
        }

        public NativeArray<OctreeInfo> OctreeInfos
        {
            get
            {
                return _octreeInfos;
            }
        }

        public NativeArray<uint> PersonIndexes
        {
            get
            {
                return _personIndexes;
            }
        }

        public NativeArray<int> InstanceCountsPerSubMesh
        {
            get
            {
                return _instanceCountsPerSubMesh;
            }
        }

        public NativeReference<int> BillboardInstanceCount
        {
            get
            {
                return _billboardInstanceCount;
            }
        }

        public int TotalSubMeshInstanceCount
        {
            get
            {
                int count = 0;
                if (_instanceCountsPerSubMesh.IsCreated)
                    for (int i = 0; i < _instanceCountsPerSubMesh.Length; i++) count += _instanceCountsPerSubMesh[i];
                return count;
            }
        }

        public CrowdSystemData(CrowdData crowdData, int subMeshCount, int boneCount, int[] penlightTypeWeights, int[] penlightAmountWeights, Vector4 boundingSphere)
        {
            _crowdData = crowdData;
            if (_crowdData != null)
            {
                var bounds = _crowdData.aabb;
                bounds.Expand(boundingSphere.w * 4f);
                Bounds = bounds;
                BaseCellBounds = _crowdData.version == 0 ? bounds : _crowdData.aabb;
            }
            _instanceCountsPerSubMesh = new NativeArray<int>(subMeshCount, Allocator.Persistent);
            _billboardInstanceCount = new NativeReference<int>(Allocator.Persistent);
            _octreeInfos = new NativeArray<OctreeInfo>(_crowdData.octreeInfos, Allocator.Persistent);
            _personInfos = new NativeArray<PersonInfo>(_crowdData.personInfos, Allocator.Persistent);
            int personCount = _personInfos.Length;
            _personInfoBuffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, personCount, System.Runtime.InteropServices.Marshal.SizeOf<PersonInfo>());
            _personInfoBuffer.SetData(_personInfos);
            _animationMatricesBuffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, 8 * boneCount, System.Runtime.InteropServices.Marshal.SizeOf<float4x4>());
            InitializeBytesBuffer(PersonInfoBytesStride * personCount, out _personInfoBytesBuffer);
            InitializePersonIndexArray(personCount, out _personIndexes);
            InitializeBytesBuffer(_personIndexes.Length, out _personIndexBuffer);
            InitializedPenlightInfoBuffer(in _personInfos, penlightTypeWeights, penlightAmountWeights, out _penlightInfoBuffer);
        }

        public void SetupCompute(ComputeShader computeShader)
        {
            CrowdCompute = computeShader;
            _updatePersonKernelIndex = CrowdCompute.FindKernel(UpdatePersonKernel);
        }

        public void UpdatePersonIndexBuffer(CommandBuffer cmd)
        {
            _personIndexBuffer.SetData(_personIndexes, 0, 0, TotalSubMeshInstanceCount + _billboardInstanceCount.Value);
        }

        public void ComputeUpdatePerson(CommandBuffer cmd)
        {
            if (CrowdCompute == null || _updatePersonKernelIndex < 0 || !_billboardInstanceCount.IsCreated) return;
            int meshCount = TotalSubMeshInstanceCount;
            int visibleCount = meshCount + _billboardInstanceCount.Value;
            if (visibleCount < 1) return;
            cmd.SetComputeIntParam(CrowdCompute, NonBillboardPersonCountID, meshCount);
            SetBoundsMin(cmd, CrowdCompute);
            SetVisiblePersonCount(cmd, CrowdCompute, visibleCount);
            SetPersonBuffers(cmd, CrowdCompute, _updatePersonKernelIndex);
            cmd.DispatchCompute(CrowdCompute, _updatePersonKernelIndex, (visibleCount + 255) / 256, 1, 1);
        }

        public void SetBoundsMin(CommandBuffer cmd, ComputeShader compute)
        {
            if (cmd == null || compute == null) return;
            cmd.SetComputeVectorParam(compute, BoundingMinID, Bounds.min);
        }

        public void SetVisiblePersonCount(CommandBuffer cmd, ComputeShader compute, int visiblePersonCount)
        {
            if (cmd == null || compute == null) return;
            cmd.SetComputeIntParam(compute, VisiblePersonCountID, visiblePersonCount);
        }

        public void SetPersonBuffers(CommandBuffer cmd, ComputeShader compute, int kernelIndex)
        {
            if (cmd == null || compute == null || kernelIndex < 0) return;
            cmd.SetComputeBufferParam(compute, kernelIndex, PersonInfoBufferID, _personInfoBuffer);
            cmd.SetComputeBufferParam(compute, kernelIndex, PersonInfoBytesBufferID, _personInfoBytesBuffer);
            cmd.SetComputeBufferParam(compute, kernelIndex, PersonIndexBufferID, _personIndexBuffer);
        }

        public void SetPenlightBuffers(CommandBuffer cmd, ComputeShader compute, int kernelIndex)
        {
            if (cmd == null || compute == null || kernelIndex < 0) return;
            cmd.SetComputeBufferParam(compute, kernelIndex, PenlightInfoBufferID, _penlightInfoBuffer);
        }

        public void SetPersonInfoBytes(MaterialPropertyBlock mpb)
        {
            mpb?.SetBuffer(PersonInfoBytesBufferID, _personInfoBytesBuffer);
        }

        public void SetBoundsMin(MaterialPropertyBlock mpb)
        {
            mpb?.SetVector(BoundingMinID, Bounds.min);
        }

        public bool EqualData(CrowdData crowdData)
        {
            return _crowdData == crowdData;
        }

        public void Dispose()
        {
            _personInfoBuffer?.Dispose();
            _animationMatricesBuffer?.Dispose();
            _personIndexBuffer?.Dispose();
            _personInfoBytesBuffer?.Dispose();
            _penlightInfoBuffer?.Dispose();
            if (_personInfos.IsCreated) _personInfos.Dispose();
            if (_octreeInfos.IsCreated) _octreeInfos.Dispose();
            if (_personIndexes.IsCreated) _personIndexes.Dispose();
            if (_instanceCountsPerSubMesh.IsCreated) _instanceCountsPerSubMesh.Dispose();
            if (_billboardInstanceCount.IsCreated) _billboardInstanceCount.Dispose();
        }

        private void InitializeBytesBuffer(int count, out GraphicsBuffer buffer)
        {
            buffer = new GraphicsBuffer(GraphicsBuffer.Target.Raw, count, sizeof(uint));
        }

        private void InitializePersonIndexArray(int count, out NativeArray<uint> personInfoArray)
        {
            personInfoArray = new NativeArray<uint>(count, Allocator.Persistent);
            for (int i = 0; i < count; i++) personInfoArray[i] = (uint)i;
        }

        private void InitializedPenlightInfoBuffer(in NativeArray<PersonInfo> personInfos, int[] typeWeights, int[] amountWeights, out GraphicsBuffer buffer)
        {
            buffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured | GraphicsBuffer.Target.Raw, personInfos.Length, sizeof(uint));
            var rand = new Unity.Mathematics.Random { state = 0xD12310CDu };
            var data = new int[personInfos.Length];
            for (int i = 0; i < data.Length; i++)
            {
                uint flags = personInfos[i].flags;
                int type = GetRandomIndex(typeWeights, ref rand);
                int amount = GetRandomIndex(amountWeights, ref rand);
                int right = (type + 1) & 3;
                int left = (flags & (1u << 21)) != 0 ? ((type + 1) << 2) & 12 : 0;
                data[i] = right | left | (type == 0 ? (amount & 15) << 4 : 0);
            }
            buffer.SetData(data);
        }

        private int GetRandomIndex(int[] weights, ref Unity.Mathematics.Random rand)
        {
            int sum = System.Linq.Enumerable.Sum(weights);
            if (sum < 1) return 0;
            int value = rand.NextInt(sum);
            int cumulative = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                int previous = cumulative;
                cumulative += weights[i];
                if (previous <= value && cumulative > value) return i;
            }
            return 0;
        }
    }
}
