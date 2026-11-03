namespace VL.Rendering.Skinning
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::UnityEngine.Rendering;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    public class VLSkinningSystem<TStream0, TSkinning> : IDisposable where TStream0 : struct, IStream0 where TSkinning : struct, ISkinning
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<BlendShapeData, int> _003C_003E9__23_0;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ector_003Eb__23_0(BlendShapeData x)
            {
                return default(int);
            }
        }

        public static readonly string RendererName;
        public static readonly int inoutPrevVertices;
        public const int ComputeThreadCount = 64;
        private readonly MeshRenderer _renderer;
        private readonly Mesh _mesh;
        private readonly Transform _rootBone;
        private readonly Bounds _localBounds;
        private readonly GraphicsBuffer _destinationBuffer;
        private readonly GraphicsBuffer _prevBuffer;
        private TransformAccessArray _bonesArray;
        private NativeArray<TStream0> _sourceArray;
        private NativeArray<TStream0> _destinationArray;
        private NativeArray<VertexLayoutStream2> _prevArray;
        private NativeArray<BlendShapeLayout> _blendShapeArray;
        private NativeArray<BlendShapeInfo> _blendShapeInfoArray;
        private NativeArray<int> _blendShapeVertexStarts;
        private NativeArray<int> _blendShapeVertexLengths;
        private NativeArray<TSkinning> _skinArray;
        private NativeArray<Matrix4x4> _bindposesArray;
        private NativeArray<Matrix4x4> _matricesArray;
        private JobHandle _jobHandle;
        public Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        public VLSkinningSystem(Transform parent, Mesh sourceMesh, Transform rootBone, Transform[] bones, Matrix4x4[] bindposes, uint[] boneWeightAndIndices, Bounds localBounds, Material[] materials, uint renderingLayerMask, [Optional] BlendShapeData[] blendShapes)
        {
        }

        public virtual void Dispose()
        {
        }

        public JobHandle ScheduleSkinning(ref BlendShapeWeight blendShapeWeights, [Optional] JobHandle dependency)
        {
            return default(JobHandle);
        }

        public void ApplySkinning(CommandBuffer cmd)
        {
        }

        public void UpdateSharedMaterials(Material[] materials)
        {
        }
    }
}
