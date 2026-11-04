namespace VL.Core
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    public class VLActorController<TModelParts, TDescriptor, TIDescriptor> : VLActorController, IVLActorController<TIDescriptor>, IVLActorController, IVLTransform where TModelParts : VLActorModelParts<TDescriptor> where TDescriptor : VLActorDescriptor, TIDescriptor where TIDescriptor : IVLActorDescriptor
    {
        [SerializeField]
        private VLActorSettings _settings;
        [SerializeField]
        private TDescriptor _descriptor;
        [SerializeField]
        private TModelParts _root;
        [SerializeField]
        private List<TModelParts> _destroyEstimatedParts;
        public VLActorSettings settings
        {
            get
            {
                return _settings;
            }
        }

        public TIDescriptor descriptor
        {
            get
            {
                return _descriptor;
            }
        }

        public TModelParts root
        {
            get
            {
                return _root;
            }
        }

        protected void InitializeField(VLActorSettings settings, TDescriptor descriptor)
        {
            _settings = settings;
            _descriptor = descriptor;
        }

        private bool CheckResourceObjects(IEnumerable<GameObject> resourceObejcts)
        {
            var names = new HashSet<string>();
            int count = 0;
            if (resourceObejcts == null) return false;
            foreach (var resource in resourceObejcts)
            {
                if (resource == null)
                {
                    Debug.LogError("アセットが読み込まれていません");
                    return false;
                }
                if (!names.Add(resource.name))
                {
                    Debug.LogError("指定アセット名が重複しているため生成できません: " + resource.name);
                    return false;
                }
                count++;
            }
            return count > 0;
        }

        protected void AddDestroyParts(TModelParts parts)
        {
            if (_destroyEstimatedParts == null) _destroyEstimatedParts = new List<TModelParts>();
            parts.SetRendererActive(false);
            _destroyEstimatedParts.Add(parts);
        }

        protected bool PreBuild()
        {
            if (descriptor.gameObjects == null)
            {
                Debug.LogError("descripter gameObject not found");
                return false;
            }
            if (CheckResourceObjects(descriptor.gameObjects)) return true;
            OnBuildModelFail();
            if (_settings != null) _settings.OnActorBuilded(false, this);
            return false;
        }

        protected void PostBuild()
        {
            if (_destroyEstimatedParts != null)
            {
                foreach (var parts in _destroyEstimatedParts) VLUtility.DestroyObject(parts.gameObject);
                _destroyEstimatedParts.Clear();
            }
            if (_settings != null) _settings.OnActorBuilded(true, this);
        }

        public bool Build(VLActorSettings settings, TDescriptor descriptor)
        {
            _settings = settings;
            _descriptor = descriptor;
            bool success = PreBuild();
            if (!success) return success;
            BuildModel(descriptor.gameObjects);
            SetupAnimation();
            OnBuildModelSuccess();
            PostBuild();
            return success;
        }

        protected void SetRootParts(TModelParts rootParts)
        {
            _root = rootParts;
        }

        protected SkeletonBone GetSkeleton(Transform trans, bool initialize = false)
        {
            return new SkeletonBone
            {
                name = trans.name,
                position = initialize ? Vector3.zero : trans.localPosition,
                rotation = initialize ? Quaternion.identity : trans.localRotation,
                scale = Vector3.one
            };
        }

        protected SkeletonBone GetSkeleton(DefaultBoneInfo bone)
        {
            return new SkeletonBone
            {
                name = bone.name,
                position = bone.localPosition,
                rotation = bone.localRotation,
                scale = bone.scale
            };
        }

        protected virtual void OnBuildModelFail()
        {
        }

        protected virtual void OnBuildModelSuccess()
        {
        }

        protected virtual void OnActorDestroy()
        {
        }

        protected virtual void CorrectSkeleton(string partsId, GameObject instance)
        {
        }

        private void OnDestroy()
        {
        }

        public override bool IsRendererActive()
        {
            bool active = false;
            if (_children != null)
                foreach (var child in _children) active |= child.rendererActive;
            return active;
        }

        public override void SetRendererActive(bool active)
        {
            base.SetRendererActive(active);
            if (_children == null) return;
            foreach (var child in _children) child.SetRendererActive(active);
        }

        public void SetChildRendererActive(string assetName, bool active)
        {
        }

        public void SetChildRendererActiveFromPartsId(string partsId, bool active)
        {
        }

        public void AllowOcclusionWhenDynamic(bool active)
        {
        }

        public bool TryGetPartsFromAssetName(string assetName, out TModelParts parts)
        {
            if (_childMap != null)
            {
                bool result = _childMap.TryGetValue(assetName, out var value);
                parts = value as TModelParts;
                return result;
            }
            parts = null;
            return false;
        }

        public bool TryGetPartsFromPartsId(string partsId, out TModelParts parts)
        {
            if (_partsIdMap != null)
            {
                bool result = _partsIdMap.TryGetValue(partsId, out var value);
                parts = value as TModelParts;
                return result;
            }
            parts = null;
            return false;
        }

        protected void AddParts(TModelParts parts)
        {
            parts.InitializeBones(_boneNameToTransformMap);
            var links = parts.GetBoneLinkList();
            if (!_childMap.ContainsKey(parts.assetName)) _childMap.Add(parts.assetName, parts);
            parts.transform.localPosition = Vector3.zero;
            parts.transform.localRotation = Quaternion.identity;
            for (int i = 0; i < links.Count; i++)
            {
                var target = links[i].targetBone;
                var rootBone = links[i].rootBone;
                if (!VLUtility.FastStartsWith(target.name, VLActorDefine.ROOT_BONE_NAME))
                    rootBone.SetParent(target, false);
                rootBone.localPosition = Vector3.zero;
                rootBone.localRotation = Quaternion.identity;
                rootBone.localScale = Vector3.one;
            }
            if (!_partsIdMap.ContainsKey(parts.partsId)) _partsIdMap.Add(parts.partsId, parts);
            else Debug.LogError("PartsIDが重複しています:" + parts.partsId);
            _children.Add(parts);
        }

        public static TController Create<TController>(int index)
            where TController : VLActorController<TModelParts, TDescriptor, TIDescriptor>
        {
            var actorObject = new GameObject(string.Format("{0}[{1}]", typeof(TController).Name, index));
            var controller = actorObject.AddComponent<TController>();
            controller._index = index;
            return controller;
        }

        public VLActorController()
        {
        }

        bool VL.IVLActorController.TryGetComponent<T>(out T component)
        {
            return TryGetComponent(out component);
        }
    }
}
