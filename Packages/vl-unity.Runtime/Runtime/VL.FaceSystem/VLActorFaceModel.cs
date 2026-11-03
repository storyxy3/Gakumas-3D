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
            public static readonly _003C_003Ec _003C_003E9;
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
                return default((string, int));
            }

            internal string _003CSetup_003Eb__36_1((string blendShapeName, int i) x)
            {
                return null;
            }

            internal int _003CSetup_003Eb__36_2((string blendShapeName, int i) x)
            {
                return default(int);
            }

            internal (string, int) _003CSetup_003Eb__36_3(BlendShapeData x, int i)
            {
                return default((string, int));
            }

            internal string _003CSetup_003Eb__36_4((string, int i) t)
            {
                return null;
            }

            internal string _003CSetup_003Eb__36_5(IGrouping<string, (string, int i)> x)
            {
                return null;
            }

            internal int[] _003CSetup_003Eb__36_6(IGrouping<string, (string, int i)> x)
            {
                return null;
            }

            internal int _003CSetup_003Eb__36_7((string, int i) t)
            {
                return default(int);
            }
        }

        public const int CustomBlendShapeLength = 4;
        public static readonly string CustomBlendShapeName;
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
        private static readonly ProfilingSampler _blendShapeBindVertexProfilingSampler;
        public bool isSystemActive
        {
            get
            {
                return default(bool);
            }
        }

        public Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        public int blendShapeLength
        {
            get
            {
                return default(int);
            }
        }

        public IReadOnlyList<VLActorFaceBindVertex> bindVertices
        {
            get
            {
                return null;
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void Dispose()
        {
        }

        public override Transform GetRootBone()
        {
            return null;
        }

        public override Transform[] GetBones()
        {
            return null;
        }

        public override Bounds GetLocalBounds()
        {
            return default(Bounds);
        }

        public void Setup()
        {
        }

        private void SetupBindVertices()
        {
        }

        private int BinarySearch(BlendShapeLayout[] array, int value)
        {
            return default(int);
        }

        private void Update()
        {
        }

        public override void SetupSkinning()
        {
        }

        internal override void ScheduleSkinning()
        {
        }

        internal override void ApplySkinning(CommandBuffer cmd)
        {
        }

        public void UpdateSharedMaterials()
        {
        }

        public int GetBlendShapeIndex(string blendShapeName)
        {
            return default(int);
        }

        public string GetBlendShapeName(int index)
        {
            return null;
        }

        public float GetBlendShapeWeight(int index)
        {
            return default(float);
        }

        public void SetBlendShapeWeight(int index, float weight)
        {
        }

        public IList<int> GetBlendShapeIndicesByGeometry(string geometryName)
        {
            return null;
        }

        public static string GetBlendShapePropertyPath(int index)
        {
            return null;
        }

        public VLActorFaceModel()
        {
        }

        [CompilerGenerated]
        internal static int _003CBinarySearch_003Eg__GetMedian_007C38_0(int low, int hi)
        {
            return default(int);
        }
    }
}
