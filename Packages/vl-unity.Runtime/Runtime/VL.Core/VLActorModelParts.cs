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
                return _assetName;
            }

            protected set
            {
                _assetName = value;
            }
        }

        public string partsId
        {
            get
            {
                return _partsId;
            }

            protected set
            {
                _partsId = value;
            }
        }

        public int boneCount
        {
            get
            {
                return _boneInfos.Count;
            }
        }

        public IEnumerable<DefaultBoneInfo> boneInfos
        {
            get
            {
                return _boneInfos;
            }
        }

        public bool rendererActive
        {
            get
            {
                return _rendererActive;
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
            int layer = gameObject.layer;
            var queue = new Queue<Transform>(32);
            queue.Enqueue(transform);
            for (int count = queue.Count; count > 0; count = queue.Count)
            {
                for (int i = 0; i < count; ++i)
                {
                    var bone = queue.Dequeue();
                    if (!RegisterBone(bone, layer)) Debug.LogWarning("ボーン名が重複しています:" + bone.name, bone);
                    for (int j = 0; j < bone.childCount; ++j) queue.Enqueue(bone.GetChild(j));
                }
            }
        }

        public bool RegisterDefaultBoneInfo(DefaultBoneInfo boneInfo)
        {
            return default(bool);
        }

        private bool RegisterBone(Transform bone, int layer)
        {
            string boneName = bone.name;
            if (_boneMap.ContainsKey(boneName)) return false;
            int index = _boneInfos.Count;
            int instanceID = bone.GetInstanceID();
            var go = bone.gameObject;
            if (layer >= 0) go.layer = layer;
            if (bone.TryGetComponent<Renderer>(out var renderer))
            {
                if (go.activeSelf)
                {
                    renderers.Add(renderer);
                    if (renderer is SkinnedMeshRenderer skinRenderer) skinRenderers.Add(skinRenderer);
                    rendererGameObjects.Add(go);
                }
            }
            else
            {
                _boneInfos.Add(new DefaultBoneInfo(boneName, bone));
                _boneMap.Add(boneName, bone);
                if (_instanceIDToDefaultBoneInfoIndexMap.ContainsKey(instanceID)) Debug.LogError("既にBone名が登録されています:" + boneName);
                else _instanceIDToDefaultBoneInfoIndexMap.Add(instanceID, index);
            }
            OnRegisterBone(in boneName, bone);
            return true;
        }

        private bool ProcessSkinningBones(Transform[] bones, HashSet<Transform> aabbHashSet)
        {
            bool valid = true;
            for (int i = 0; i < bones.Length; ++i)
            {
                var bone = bones[i];
                if (bone == null)
                {
                    Debug.LogError("RendererにBoneが見つかりませんでした");
                    valid = false;
                    continue;
                }
                if (TryGetDefaultBoneInfo(bone, out var info)) bones[i] = info.transform;
                else
                {
                    Debug.LogError("Bone is not existed. Bone:" + bone.name);
                    valid = false;
                }
                aabbHashSet.Add(bone);
            }
            return valid;
        }

        protected bool UpdateSkinnedMeshRenderers()
        {
            defaultRootTransform = null;
            var set = UnityEngine.Pool.HashSetPool<Transform>.Get();
            bool valid;
            if (TryGetComponent(out skinningModel))
            {
                defaultRootTransform = skinningModel.GetRootBone();
                valid = ProcessSkinningBones(skinningModel.GetBones(), set);
                defaultBounds = skinningModel.GetLocalBounds();
            }
            else
            {
                valid = true;
                for (int i = 0; i < renderers.Count; ++i)
                {
                    var renderer = renderers[i];
                    if (renderer is SkinnedMeshRenderer skinRenderer)
                    {
                        skinRenderer.updateWhenOffscreen = false;
                        if (i == 0) defaultRootTransform = skinRenderer.rootBone;
                        var bones = skinRenderer.bones;
                        valid &= ProcessSkinningBones(bones, set);
                        skinRenderer.bones = bones;
                    }
                    else if (renderer is MeshRenderer) set.Add(renderer.transform);
                    if (i == 0) defaultBounds = renderer.localBounds;
                    else defaultBounds.Encapsulate(renderer.localBounds);
                }
            }
            aabbTransform.AddRange(set);
            UnityEngine.Pool.HashSetPool<Transform>.Release(set);
            return valid;
        }

        protected virtual void OnRegisterBone(in string boneName, Transform bone)
        {
        }

        public void InitializeBones(BoneNameToTransformDictionary allBoneNameToTransformMap)
        {
            UpdateRootBoneLinkList(allBoneNameToTransformMap);
            foreach (var bone in _boneInfos) allBoneNameToTransformMap.Add(bone.name, bone.transform);
        }

        private void UpdateRootBoneLinkList(BoneNameToTransformDictionary allBoneNameToTransformMap)
        {
            if (_rootBoneLinkList == null) _rootBoneLinkList = new List<BoneLinkData>();
            else _rootBoneLinkList.Clear();
            if (_tempRootTransBoneList == null) _tempRootTransBoneList = new List<Transform>(8);
            else _tempRootTransBoneList.Clear();
            for (int i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);
                if (VLActorDefine.IsBone(child)) _tempRootTransBoneList.Add(child);
            }
            for (int i = 0; i < _tempRootTransBoneList.Count; i++)
            {
                string connectionName = VLActorDefine.GetConnectionName(_tempRootTransBoneList[i]);
                if (allBoneNameToTransformMap.TryGetValue(connectionName, out var target))
                    _rootBoneLinkList.Add(new BoneLinkData(_tempRootTransBoneList[i], target));
            }
        }

        protected void InitializeMaterials()
        {
        }

        protected void DisposeMaterials()
        {
            if (materials == null) return;
            foreach (var material in materials) material.Dispose();
            materials.Clear();
        }

        protected virtual void OnDestroy()
        {
        }

        public void SetRendererActive(bool active)
        {
            if (_rendererActive == active) return;
            _rendererActive = active;
            foreach (var renderer in renderers) renderer.enabled = active;
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
            info = null;
            if (_instanceIDToDefaultBoneInfoIndexMap == null || _boneInfos == null || t == null) return false;
            if (!_instanceIDToDefaultBoneInfoIndexMap.TryGetValue(t.GetInstanceID(), out int index)) return false;
            if (index < 0 || index >= _boneInfos.Count) return false;
            info = _boneInfos[index];
            return true;
        }

        public List<BoneLinkData> GetBoneLinkList()
        {
            return _rootBoneLinkList;
        }

        public VLActorModelParts()
        {
        }
    }
}
