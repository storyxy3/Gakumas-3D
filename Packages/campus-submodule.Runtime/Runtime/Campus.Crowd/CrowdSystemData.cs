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
        private static readonly int PersonInfoBytesStride;
        private static readonly string UpdatePersonKernel;
        private static readonly int PersonInfoBufferID;
        private static readonly int PersonInfoBytesBufferID;
        private static readonly int PersonIndexBufferID;
        private static readonly int BoundingMinID;
        private static readonly int NonBillboardPersonCountID;
        private static readonly int VisiblePersonCountID;
        private static readonly int PenlightInfoBufferID;
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
                return null;
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Bounds Bounds
        {
            [CompilerGenerated]
            get
            {
                return default(Bounds);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Bounds BaseCellBounds
        {
            [CompilerGenerated]
            get
            {
                return default(Bounds);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public GraphicsBuffer PersonInfoBuffer
        {
            get
            {
                return null;
            }
        }

        public GraphicsBuffer AnimationMatricesBuffer
        {
            get
            {
                return null;
            }
        }

        public GraphicsBuffer PersonInfoBytesBuffer
        {
            get
            {
                return null;
            }
        }

        public GraphicsBuffer PersonIndexBuffer
        {
            get
            {
                return null;
            }
        }

        public NativeArray<PersonInfo> PersonInfos
        {
            get
            {
                return default(NativeArray<PersonInfo>);
            }
        }

        public NativeArray<OctreeInfo> OctreeInfos
        {
            get
            {
                return default(NativeArray<OctreeInfo>);
            }
        }

        public NativeArray<uint> PersonIndexes
        {
            get
            {
                return default(NativeArray<uint>);
            }
        }

        public NativeArray<int> InstanceCountsPerSubMesh
        {
            get
            {
                return default(NativeArray<int>);
            }
        }

        public NativeReference<int> BillboardInstanceCount
        {
            get
            {
                return default(NativeReference<int>);
            }
        }

        public int TotalSubMeshInstanceCount
        {
            get
            {
                return default(int);
            }
        }

        public CrowdSystemData(CrowdData crowdData, int subMeshCount, int boneCount, int[] penlightTypeWeights, int[] penlightAmountWeights, Vector4 boundingSphere)
        {
        }

        public void SetupCompute(ComputeShader computeShader)
        {
        }

        public void UpdatePersonIndexBuffer(CommandBuffer cmd)
        {
        }

        public void ComputeUpdatePerson(CommandBuffer cmd)
        {
        }

        public void SetBoundsMin(CommandBuffer cmd, ComputeShader compute)
        {
        }

        public void SetVisiblePersonCount(CommandBuffer cmd, ComputeShader compute, int visiblePersonCount)
        {
        }

        public void SetPersonBuffers(CommandBuffer cmd, ComputeShader compute, int kernelIndex)
        {
        }

        public void SetPenlightBuffers(CommandBuffer cmd, ComputeShader compute, int kernelIndex)
        {
        }

        public void SetPersonInfoBytes(MaterialPropertyBlock mpb)
        {
        }

        public void SetBoundsMin(MaterialPropertyBlock mpb)
        {
        }

        public bool EqualData(CrowdData crowdData)
        {
            return default(bool);
        }

        public void Dispose()
        {
        }

        private void InitializeBytesBuffer(int count, out GraphicsBuffer buffer)
        {
            throw null;
        }

        private void InitializePersonIndexArray(int count, out NativeArray<uint> personInfoArray)
        {
            throw null;
        }

        private void InitializedPenlightInfoBuffer(in NativeArray<PersonInfo> personInfos, int[] typeWeights, int[] amountWeights, out GraphicsBuffer buffer)
        {
            throw null;
        }

        private int GetRandomIndex(int[] weights, ref Unity.Mathematics.Random rand)
        {
            return default(int);
        }
    }
}
