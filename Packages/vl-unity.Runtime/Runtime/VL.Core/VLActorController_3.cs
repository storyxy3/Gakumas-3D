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
        }

        private bool CheckResourceObjects(IEnumerable<GameObject> resourceObejcts)
        {
            return default(bool);
        }

        protected void AddDestroyParts(TModelParts parts)
        {
        }

        protected bool PreBuild()
        {
            return default(bool);
        }

        protected void PostBuild()
        {
        }

        public bool Build(VLActorSettings settings, TDescriptor descriptor)
        {
            return default(bool);
        }

        protected void SetRootParts(TModelParts rootParts)
        {
        }

        protected SkeletonBone GetSkeleton(Transform trans, bool initialize = false)
        {
            return default(SkeletonBone);
        }

        protected SkeletonBone GetSkeleton(DefaultBoneInfo bone)
        {
            return default(SkeletonBone);
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
            return default(bool);
        }

        public override void SetRendererActive(bool active)
        {
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
        }

        public static TController Create<TController>(int index)
            where TController : VLActorController<TModelParts, TDescriptor, TIDescriptor>
        {
            return null;
        }

        public VLActorController()
        {
        }

        bool VL.IVLActorController.TryGetComponent<T>(out T component)
        {
            throw null;
        }
    }
}
