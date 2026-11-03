namespace VL.Core
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;
    using global::VL.Rendering.Skinning;

    public class VLActorModelParts : MonoBehaviour
    {
        public const int TransformCapacity = 256;
        public const int RendererCapacity = 16;
        [SerializeField]
        private string _assetName;
        [SerializeField]
        private string _partsId;
        [SerializeField]
        protected BoneNameToTransformDictionary _boneMap;
        [SerializeField]
        protected InstanceIDToDefaultBoneInfoIndexDictionary _instanceIDToDefaultBoneInfoIndexMap;
        [SerializeField]
        protected List<DefaultBoneInfo> _boneInfos;
        [SerializeField]
        private List<BoneLinkData> _rootBoneLinkList;
        [SerializeField]
        protected bool _rendererActive;
        public List<Renderer> renderers;
        public List<GameObject> rendererGameObjects;
        public List<SkinnedMeshRenderer> skinRenderers;
        public VLSkinningModel skinningModel;
        public List<MaterialInfo> materials;
        public VLActorAABBCalcType aabbCalcType;
        public List<Transform> aabbTransform;
        protected List<Transform> _tempRootTransBoneList;
        public Bounds defaultBounds;
        public Transform defaultRootTransform;
        public string assetName
        {
            get
            {
                return null;
            }

            protected set
            {
            }
        }

        public string partsId
        {
            get
            {
                return null;
            }

            protected set
            {
            }
        }

        public int boneCount
        {
            get
            {
                return default(int);
            }
        }

        public IEnumerable<DefaultBoneInfo> boneInfos
        {
            get
            {
                return null;
            }
        }

        public bool rendererActive
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize()
        {
        }

        public virtual void Initialize(string partsId, string assetName)
        {
        }

        protected void ProcessBones()
        {
        }

        public bool RegisterDefaultBoneInfo(DefaultBoneInfo boneInfo)
        {
            return default(bool);
        }

        private bool RegisterBone(Transform bone, int layer)
        {
            return default(bool);
        }

        private bool ProcessSkinningBones(Transform[] bones, HashSet<Transform> aabbHashSet)
        {
            return default(bool);
        }

        protected bool UpdateSkinnedMeshRenderers()
        {
            return default(bool);
        }

        protected virtual void OnRegisterBone(in string boneName, Transform bone)
        {
        }

        public void InitializeBones(BoneNameToTransformDictionary allBoneNameToTransformMap)
        {
        }

        private void UpdateRootBoneLinkList(BoneNameToTransformDictionary allBoneNameToTransformMap)
        {
        }

        protected void InitializeMaterials()
        {
        }

        protected void DisposeMaterials()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        public void SetRendererActive(bool active)
        {
        }

        public void AllowOcclusionWhenDynamic(bool active)
        {
        }

        public virtual void SetSortingOrder(int order)
        {
        }

        public bool ContainsBoneName(in string boneName)
        {
            return default(bool);
        }

        public bool TryGetBoneTransformByName(in string boneName, out Transform t)
        {
            throw null;
        }

        public bool TryGetDefaultBoneInfo(Transform t, out DefaultBoneInfo info)
        {
            throw null;
        }

        public List<BoneLinkData> GetBoneLinkList()
        {
            return null;
        }

        public VLActorModelParts()
        {
        }
    }
}
