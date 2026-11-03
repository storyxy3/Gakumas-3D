namespace VL.FaceSystem
{
    using global::System.Collections.Generic;
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
    }
}
