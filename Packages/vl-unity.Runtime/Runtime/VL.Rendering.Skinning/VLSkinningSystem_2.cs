// TODO(qa-recon): The fully shared generic constructor still differs in an allocation comparison immediate; exact native correspondence remains unresolved (TASK_D_REPORT.md).
namespace VL.Rendering.Skinning
{
    using global::System;
    using global::System.Linq;
    using global::Unity.Mathematics;
    using global::Unity.Collections.LowLevel.Unsafe;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<BlendShapeData, int> _003C_003E9__23_0;
            public _003C_003Ec()
            {
            }

            internal int _003C_002Ector_003Eb__23_0(BlendShapeData x)
            {
                return x.blendShapeVertices.Length;
            }
        }

        public static readonly string RendererName = "VLSkinningRenderer";
        public static readonly int inoutPrevVertices = Shader.PropertyToID("inoutPrevVertices");
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
                return _renderer != null ? _renderer.localBounds : default;
            }
        }

        public unsafe VLSkinningSystem(Transform parent, Mesh sourceMesh, Transform rootBone, Transform[] bones, Matrix4x4[] bindposes, uint[] boneWeightAndIndices, Bounds localBounds, Material[] materials, uint renderingLayerMask, [Optional] BlendShapeData[] blendShapes)
        {
            if (sourceMesh == null)
            {
                Debug.LogError("SourceMeshがnullです");
                return;
            }
            if (!parent.gameObject.scene.IsValid())
            {
                Debug.LogError("不正なシーンから初期化されています");
                return;
            }
            var child = parent.Find(RendererName);
            MeshFilter meshFilter;
            if (child != null)
            {
                var go = child.gameObject;
                meshFilter = go.GetComponent<MeshFilter>();
                _renderer = go.GetComponent<MeshRenderer>();
            }
            else
            {
                var go = new GameObject(RendererName) { layer = parent.gameObject.layer };
                go.transform.SetParent(parent);
                meshFilter = go.AddComponent<MeshFilter>();
                _renderer = go.AddComponent<MeshRenderer>();
            }
            _renderer.sharedMaterials = materials;
            _renderer.renderingLayerMask = renderingLayerMask;
            _sourceArray = new NativeArray<TStream0>(sourceMesh.vertexCount, Allocator.Persistent);
            _mesh = VL.VLMeshUtility.CopyMesh(sourceMesh, _sourceArray.Slice().SliceConvert<byte>());
            _mesh.hideFlags = (HideFlags)52;
            meshFilter.sharedMesh = _mesh;
            _rootBone = rootBone;
            _localBounds = localBounds;
            _mesh.vertexBufferTarget |= GraphicsBuffer.Target.CopyDestination;
            _mesh.MarkDynamic();
            _destinationBuffer = _mesh.GetVertexBuffer(0);
            _destinationArray = new NativeArray<TStream0>(_sourceArray, Allocator.Persistent);
            if (_mesh.HasVertexAttribute(VertexAttribute.TexCoord4))
            {
                _prevArray = new NativeArray<VertexLayoutStream2>(_sourceArray.Length, Allocator.Persistent);
                _prevBuffer = _mesh.GetVertexBuffer(_mesh.GetVertexAttributeStream(VertexAttribute.TexCoord4));
            }
            _bonesArray = new TransformAccessArray(bones);
            _bindposesArray = new NativeArray<Matrix4x4>(bindposes, Allocator.Persistent);
            _matricesArray = new NativeArray<Matrix4x4>(bones.Length, Allocator.Persistent);
            if (boneWeightAndIndices.Length != _destinationArray.Length * 4)
            {
                Debug.LogError("BoneWeightAndIndicesのサイズが合いません");
                return;
            }
            _skinArray = new NativeArray<TSkinning>(_destinationArray.Length, Allocator.Persistent);
            void* source = UnsafeUtility.PinGCArrayAndGetDataAddress(boneWeightAndIndices, out ulong handle);
            UnsafeUtility.MemCpy(_skinArray.GetUnsafePtr(), source, boneWeightAndIndices.Length * 4);
            UnsafeUtility.ReleaseGCObject(handle);
            if (blendShapes != null)
            {
                int count = blendShapes.Sum(_003C_003Ec._003C_003E9__23_0 ?? (_003C_003Ec._003C_003E9__23_0 = _003C_003Ec._003C_003E9._003C_002Ector_003Eb__23_0));
                _blendShapeArray = new NativeArray<BlendShapeLayout>(count, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
                _blendShapeInfoArray = new NativeArray<BlendShapeInfo>(blendShapes.Length, Allocator.Persistent);
                _blendShapeVertexStarts = new NativeArray<int>(blendShapes.Length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
                _blendShapeVertexLengths = new NativeArray<int>(blendShapes.Length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
                int start = 0;
                for (int i = 0; i < blendShapes.Length; i++)
                {
                    _blendShapeVertexStarts[i] = start;
                    var vertices = blendShapes[i].blendShapeVertices;
                    int length = vertices.Length;
                    NativeArray<BlendShapeLayout>.Copy(vertices, 0, _blendShapeArray, start, length);
                    start += length;
                    _blendShapeVertexLengths[i] = length;
                }
            }
        }

        public virtual void Dispose()
        {
            _jobHandle.Complete();
            _destinationBuffer?.Dispose();
            _prevBuffer?.Dispose();
            _prevArray.Dispose();
            _matricesArray.Dispose();
            _sourceArray.Dispose();
            _destinationArray.Dispose();
            _blendShapeArray.Dispose();
            _blendShapeInfoArray.Dispose();
            _blendShapeVertexStarts.Dispose();
            _blendShapeVertexLengths.Dispose();
            _skinArray.Dispose();
            _bonesArray.Dispose();
            _bindposesArray.Dispose();
            if (_mesh != null) UnityEngine.Object.DestroyImmediate(_mesh, true);
        }

        public JobHandle ScheduleSkinning(ref BlendShapeWeight blendShapeWeights, [Optional] JobHandle dependency)
        {
            var rendererWorldToLocal = _renderer != null ? _renderer.transform.worldToLocalMatrix : Matrix4x4.identity;
            _jobHandle.Complete();
            new UpdateMatricesJob { rendererWorldToLocalMatrix = rendererWorldToLocal, bindposesArray = _bindposesArray, matricesArray = _matricesArray }.RunReadOnly(_bonesArray);
            var streamType = typeof(TStream0);
            var skinType = typeof(TSkinning);
            if (!(streamType == typeof(VertexLayoutStreamPNT))) throw new NotSupportedException();
            _jobHandle = new CopyJob<VertexLayoutStreamPNT>
            {
                sourceArray = _sourceArray.Reinterpret<VertexLayoutStreamPNT>(),
                prevArray = _prevArray,
                destinationArray = _destinationArray.Reinterpret<VertexLayoutStreamPNT>()
            }.Schedule(_sourceArray.Length, 64, _jobHandle);
            if (_blendShapeArray.IsCreated)
            {
                int count = 0;
                for (int i = 0; i < _blendShapeVertexStarts.Length; i++)
                {
                    float weight = blendShapeWeights[i] * 0.01f;
                    if (weight >= 0.001f)
                    {
                        _blendShapeInfoArray[count++] = new BlendShapeInfo { start = _blendShapeVertexStarts[i], length = _blendShapeVertexLengths[i], weight = weight };
                    }
                }
                if (!(skinType == typeof(Skinning4))) throw new NotSupportedException();
                _jobHandle = new BlendShapeJob<VertexLayoutStreamPNT>
                {
                    length = count, blendShapeInfoArray = _blendShapeInfoArray, blendShapeArray = _blendShapeArray,
                    destinationArray = _destinationArray.Reinterpret<VertexLayoutStreamPNT>()
                }.Schedule(_jobHandle);
            }
            if (!(streamType == typeof(VertexLayoutStreamPNT)) || !(skinType == typeof(Skinning4))) throw new NotSupportedException();
            _jobHandle = new SkinningJob<VertexLayoutStreamPNT, Skinning4>
            {
                matricesArray = _matricesArray.Reinterpret<float4x4>(),
                skinArray = _skinArray.Reinterpret<Skinning4>(),
                destinationArray = _destinationArray.Reinterpret<VertexLayoutStreamPNT>()
            }.Schedule(_sourceArray.Length, 16, _jobHandle);
            if (_rootBone != null && _renderer != null)
                _renderer.localBounds = AABBUtility.TransformAABB(_localBounds, rendererWorldToLocal * _rootBone.localToWorldMatrix);
            return _jobHandle;
        }

        public void ApplySkinning(CommandBuffer cmd)
        {
            _jobHandle.Complete();
            _destinationBuffer.SetData(_destinationArray);
            _prevBuffer.SetData(_prevArray);
        }

        public void UpdateSharedMaterials(Material[] materials)
        {
            if (_renderer != null) _renderer.sharedMaterials = materials;
        }
    }
}
