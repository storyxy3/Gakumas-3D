// TODO(qa-recon): Setup retains a native semantic flag for an additional loop/index immediate; exact compiler correspondence remains unresolved (TASK_D_REPORT.md).
namespace VL.ActorMesh
{
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL.ActorMesh;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    [ExecuteAlways]
    public class VLActorSkinningModel : VLSkinningModel
    {
        public Transform rootBone;
        public Transform[] bones;
        public Bounds localBounds;
        private VLActorSkinningSystem _system;
        private BlendShapeWeight _blendShapeWeights;
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
            _system?.Dispose();
            _system = null;
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

        public override void SetupSkinning()
        {
            VL.Subsystems.VLSubsystem.RegisterSkinningModel(this);
        }

        internal override void ScheduleSkinning()
        {
            _system?.ScheduleSkinning(ref _blendShapeWeights);
        }

        internal override void ApplySkinning(CommandBuffer cmd)
        {
            _system?.ApplySkinning(cmd);
        }

        public void Setup()
        {
            if (!TryGetComponent<SkinnedMeshRenderer>(out var source)) return;
            source.enabled = false;
            var sourceMesh = source.sharedMesh;
            var packed = new uint[sourceMesh.vertexCount * 4];
            ListPool<BoneWeight>.Get(out var weights);
            source.sharedMesh.GetBoneWeights(weights);
            for (int i = 0; i < weights.Count; i++)
            {
                var weight = weights[i];
                packed[i * 4] = VL.VLMeshUtility.PackWeightAndIndex(weight.weight0, weight.boneIndex0);
                packed[i * 4 + 1] = VL.VLMeshUtility.PackWeightAndIndex(weight.weight1, weight.boneIndex1);
                packed[i * 4 + 2] = VL.VLMeshUtility.PackWeightAndIndex(weight.weight2, weight.boneIndex2);
                packed[i * 4 + 3] = VL.VLMeshUtility.PackWeightAndIndex(weight.weight3, weight.boneIndex3);
            }
            ListPool<BoneWeight>.Release(weights);
            rootBone = source.rootBone;
            bones = source.bones;
            localBounds = source.localBounds;
            _system = new VLActorSkinningSystem(transform, source.sharedMesh, rootBone, bones, sourceMesh.bindposes, packed, localBounds, source.sharedMaterials, source.renderingLayerMask);
        }

        private void Update()
        {
            if (_system == null) Setup();
        }

        public VLActorSkinningModel()
        {
        }
    }
}
