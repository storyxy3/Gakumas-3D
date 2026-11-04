namespace VL.FaceSystem
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Runtime.CompilerServices;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;
    using global::UnityEngine.Rendering;
    using global::VL;
    using global::VL.ActorMesh;
    using global::VL.Core;
    using global::VL.FaceSystem;
    using global::VL.Rendering.Skinning;

    [ExecuteAlways]
    public class VLActorFaceModel : VLSkinningModel
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<BlendShapeData, int, (string blendShapeName, int i)> _003C_003E9__36_0;
            public static Func<(string blendShapeName, int i), string> _003C_003E9__36_1;
            public static Func<(string blendShapeName, int i), int> _003C_003E9__36_2;
            public static Func<BlendShapeData, int, (string, int i)> _003C_003E9__36_3;
            public static Func<(string, int i), string> _003C_003E9__36_4;
            public static Func<IGrouping<string, (string, int i)>, string> _003C_003E9__36_5;
            public static Func<(string, int i), int> _003C_003E9__36_7;
            public static Func<IGrouping<string, (string, int i)>, int[]> _003C_003E9__36_6;
            public _003C_003Ec()
            {
            }

            internal (string, int) _003CSetup_003Eb__36_0(BlendShapeData x, int i)
            {
                return (x.blendShapeName, i);
            }

            internal string _003CSetup_003Eb__36_1((string blendShapeName, int i) x)
            {
                return x.blendShapeName;
            }

            internal int _003CSetup_003Eb__36_2((string blendShapeName, int i) x)
            {
                return x.i;
            }

            internal (string, int) _003CSetup_003Eb__36_3(BlendShapeData x, int i)
            {
                int index = x.blendShapeName.IndexOf('.');
                return (index >= 1 ? x.blendShapeName.Substring(0, index) : "", i);
            }

            internal string _003CSetup_003Eb__36_4((string, int i) t)
            {
                return t.Item1;
            }

            internal string _003CSetup_003Eb__36_5(IGrouping<string, (string, int i)> x)
            {
                return x.Key;
            }

            internal int[] _003CSetup_003Eb__36_6(IGrouping<string, (string, int i)> x)
            {
                return x.Select(_003C_003E9__36_7 ?? (_003C_003E9__36_7 = _003C_003E9._003CSetup_003Eb__36_7)).ToArray();
            }

            internal int _003CSetup_003Eb__36_7((string, int i) t)
            {
                return t.i;
            }
        }

        public const int CustomBlendShapeLength = 4;
        public static readonly string CustomBlendShapeName = "custom_{0}_{1}";
        public Mesh mesh;
        public Material[] sharedMaterials;
        public uint renderingLayerMask;
        public Transform rootBone;
        public Transform[] bones;
        public Matrix4x4[] bindposes;
        public Bounds localBounds;
        public uint[] boneWeightAndIndices;
        [NonReorderable]
        public BlendShapeData[] blendShapes;
        [NonReorderable]
        public BlendShapeWeight blendShapeWeights;
        private VLActorSkinningSystem _system;
        private Dictionary<string, int> _blendShapeNameTable;
        private Dictionary<string, int[]> _geometryBlendShapeNameTable;
        private VLActorFaceBindVertex[] _bindVertices;
        private TransformAccessArray _bindVertexTransformAccessArray;
        private NativeArray<JobUtility.Array2DInfo> _bindVertexArray2DInfos;
        private NativeArray<Vector3> _bindVertexBasePositions;
        private NativeArray<BlendShapeBindVertexData> _bindVertexData;
        private UpdateBlendShapeBindVertexJob _updateBlendShapeBindVertexJob;
        private JobHandle _jobHandle;
        private static readonly ProfilingSampler _blendShapeBindVertexProfilingSampler = new ProfilingSampler("BlendShapeBindVertex");
        public bool isSystemActive
        {
            get
            {
                return _system != null;
            }
        }

        public Bounds bounds
        {
            get
            {
                return _system != null ? _system.bounds : localBounds;
            }
        }

        public int blendShapeLength
        {
            get
            {
                return blendShapes?.Length ?? 0;
            }
        }

        public IReadOnlyList<VLActorFaceBindVertex> bindVertices
        {
            get
            {
                return _bindVertices;
            }
        }

        private void OnEnable()
        {
            Setup();
        }

        private void OnDisable()
        {
            Dispose();
        }

        public void Dispose()
        {
            _jobHandle.Complete();
            _system?.Dispose();
            _system = null;
            if (_bindVertexTransformAccessArray.isCreated) _bindVertexTransformAccessArray.Dispose();
            if (_bindVertexData.IsCreated) _bindVertexData.Dispose();
            if (_bindVertexArray2DInfos.IsCreated) _bindVertexArray2DInfos.Dispose();
            if (_bindVertexBasePositions.IsCreated) _bindVertexBasePositions.Dispose();
        }

        public override Transform GetRootBone()
        {
            return rootBone;
        }

        public override Transform[] GetBones()
        {
            return bones;
        }

        public override Bounds GetLocalBounds()
        {
            return localBounds;
        }

        public void Setup()
        {
            _system = new VLActorSkinningSystem(transform, mesh, rootBone, bones, bindposes, boneWeightAndIndices, localBounds, sharedMaterials, renderingLayerMask, blendShapes);
            _blendShapeNameTable = blendShapes.Select(_003C_003Ec._003C_003E9__36_0 ?? (_003C_003Ec._003C_003E9__36_0 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_0)).ToDictionary((_003C_003Ec._003C_003E9__36_1 ?? (_003C_003Ec._003C_003E9__36_1 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_1)), (_003C_003Ec._003C_003E9__36_2 ?? (_003C_003Ec._003C_003E9__36_2 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_2)));
            _geometryBlendShapeNameTable = blendShapes.Select(_003C_003Ec._003C_003E9__36_3 ?? (_003C_003Ec._003C_003E9__36_3 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_3)).GroupBy(_003C_003Ec._003C_003E9__36_4 ?? (_003C_003Ec._003C_003E9__36_4 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_4)).ToDictionary((_003C_003Ec._003C_003E9__36_5 ?? (_003C_003Ec._003C_003E9__36_5 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_5)), (_003C_003Ec._003C_003E9__36_6 ?? (_003C_003Ec._003C_003E9__36_6 = _003C_003Ec._003C_003E9._003CSetup_003Eb__36_6)));
            SetupBindVertices();
        }

        private unsafe void SetupBindVertices()
        {
            _bindVertices = GetComponentsInChildren<VLActorFaceBindVertex>();
            if (_bindVertexTransformAccessArray.isCreated) _bindVertexTransformAccessArray.Dispose();
            if (_bindVertexData.IsCreated) _bindVertexData.Dispose();
            if (_bindVertexArray2DInfos.IsCreated) _bindVertexArray2DInfos.Dispose();
            if (_bindVertexBasePositions.IsCreated) _bindVertexBasePositions.Dispose();
            _bindVertexTransformAccessArray = new TransformAccessArray(_bindVertices.Length, 1);
            _bindVertexData = new NativeArray<BlendShapeBindVertexData>(_bindVertices.Length * blendShapes.Length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            _bindVertexArray2DInfos = new NativeArray<JobUtility.Array2DInfo>(_bindVertices.Length, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            _bindVertexBasePositions = new NativeArray<Vector3>(_bindVertices.Length, Allocator.Persistent);
            int start = 0;
            for (int i = 0; i < _bindVertices.Length; ++i)
            {
                int vertexIndex = _bindVertices[i].vertexIndex;
                int length = 0;
                for (int j = 0; j < blendShapes.Length; ++j)
                {
                    int index = BinarySearch(blendShapes[j].blendShapeVertices, vertexIndex);
                    if (index >= 0)
                        _bindVertexData[start + length++] = new BlendShapeBindVertexData { blendShapeIndex = j, position = blendShapes[j].blendShapeVertices[index].position };
                }
                _bindVertexTransformAccessArray.Add(_bindVertices[i].transform);
                _bindVertexBasePositions[i] = _bindVertices[i].basePosition;
                _bindVertexArray2DInfos[i] = new JobUtility.Array2DInfo { start = start, length = length };
                start += length;
            }
            fixed (float* weights = &blendShapeWeights.w0.w0)
                _updateBlendShapeBindVertexJob = new UpdateBlendShapeBindVertexJob { bindVertexArray2DInfos = _bindVertexArray2DInfos, bindVertexBasePositions = _bindVertexBasePositions, bindVertexData = _bindVertexData, pBlendShapeWeights = weights };
        }

        private int BinarySearch(BlendShapeLayout[] array, int value)
        {
            if (array == null) throw new ArgumentNullException("array");
            int low = 0;
            int hi = array.Length - 1;
            while (low <= hi)
            {
                int mid = _003CBinarySearch_003Eg__GetMedian_007C38_0(low, hi);
                int comparison = array[mid].vertIndex.CompareTo(value);
                if (comparison == 0) return mid;
                if (comparison < 0) low = mid + 1;
                else hi = mid - 1;
            }
            return ~low;
        }

        private void Update()
        {
            if (_system == null) Setup();
        }

        public override void SetupSkinning()
        {
            using (new ProfilingScope(null, _blendShapeBindVertexProfilingSampler))
            {
                for (int i = 0; i < _bindVertices.Length; ++i)
                {
                    var vertex = _bindVertices[i];
                    if (vertex == null) continue;
                    var info = _bindVertexArray2DInfos[i];
                    Vector3 position = vertex.basePosition;
                    for (int j = info.start; j < info.end; ++j)
                    {
                        var data = _bindVertexData[j];
                        position += data.position * (blendShapeWeights[data.blendShapeIndex] * 0.01f);
                    }
                    vertex.transform.localPosition = position;
                }
            }
            VL.Subsystems.VLSubsystem.RegisterSkinningModel(this);
        }

        internal override void ScheduleSkinning()
        {
            _system?.ScheduleSkinning(ref blendShapeWeights);
        }

        internal override void ApplySkinning(CommandBuffer cmd)
        {
            _jobHandle.Complete();
            _system?.ApplySkinning(cmd);
        }

        public void UpdateSharedMaterials()
        {
            _system?.UpdateSharedMaterials(sharedMaterials);
        }

        public int GetBlendShapeIndex(string blendShapeName)
        {
            if (_blendShapeNameTable != null && _blendShapeNameTable.TryGetValue(blendShapeName, out int index)) return index;
            if (blendShapes == null || string.IsNullOrEmpty(blendShapeName)) return -1;
            for (int i = 0; i < blendShapes.Length; ++i)
                if (blendShapes[i].blendShapeName == blendShapeName) return i;
            return -1;
        }

        public string GetBlendShapeName(int index)
        {
            return blendShapes[index]?.blendShapeName;
        }

        public float GetBlendShapeWeight(int index)
        {
            return blendShapeWeights[index];
        }

        public void SetBlendShapeWeight(int index, float weight)
        {
            blendShapeWeights[index] = weight;
        }

        public IList<int> GetBlendShapeIndicesByGeometry(string geometryName)
        {
            if (_geometryBlendShapeNameTable != null && _geometryBlendShapeNameTable.TryGetValue(geometryName, out var indices)) return indices;
            if (blendShapes == null || string.IsNullOrEmpty(geometryName)) return null;
            var result = new List<int>();
            for (int i = 0; i < blendShapes.Length; ++i)
            {
                int index = blendShapes[i].blendShapeName.IndexOf('.');
                if (index > 0 && geometryName == blendShapes[i].blendShapeName.Substring(0, index)) result.Add(i);
            }
            return result.ToArray();
        }

        public static string GetBlendShapePropertyPath(int index)
        {
            return "blendShapeWeights." + BlendShapeWeight.GetPropertyPath(index);
        }

        public VLActorFaceModel()
        {
        }

        [CompilerGenerated]
        internal static int _003CBinarySearch_003Eg__GetMedian_007C38_0(int low, int hi)
        {
            return low + ((hi - low) >> 1);
        }
    }
}
