// TODO(qa-recon): Only the rendering registry getter is reconstructed here. Actor registry initialization and actor lifecycle remain skeletons; render consumers need that separate reconstruction.
namespace VL.Core
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Playables;
    using global::UnityEngine.Rendering;
    using global::VL;
    using global::VL.AABB;
    using global::VL.Core;

    [ExecuteAlways]
    public class VLActorController : MonoBehaviour, IVLActorController, IVLTransform
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<VLActorModelParts, IEnumerable<DefaultBoneInfo>> _003C_003E9__6_0;
            public static Func<VLActorModelParts, int> _003C_003E9__79_0;
            public _003C_003Ec()
            {
            }

            internal IEnumerable<DefaultBoneInfo> _003Cget_boneInfos_003Eb__6_0(VLActorModelParts x)
            {
                return null;
            }

            internal int _003CInitializeAABB_003Eb__79_0(VLActorModelParts x)
            {
                return default(int);
            }
        }

        private static ProfilingSampler _scheduleJobSampler;
        private static ProfilingSampler _completeJobSampler;
        private static List<IVLActorController> _actorControllers;
        [SerializeField]
        [HideInInspector]
        protected int _index;
        [SerializeField]
        protected Animator _animator;
        [SerializeField]
        protected Avatar _avatar;
        [SerializeField]
        protected List<VLActorExtension> _extensions;
        [SerializeField]
        protected List<VLActorModelParts> _children;
        [SerializeField]
        protected ChildMapDictionary _childMap;
        [SerializeField]
        protected PartsIdMapDictionary _partsIdMap;
        [SerializeField]
        protected BoneNameToTransformDictionary _boneNameToTransformMap;
        [SerializeField]
        [HideInInspector]
        protected GameObject[] _buildResources;
        [SerializeField]
        [HideInInspector]
        protected Bounds _bounds;
        [SerializeField]
        [HideInInspector]
        protected bool _isDestroyed;
        private JobHandle _jobHandle;
        private AABBJobData _aabbJobData;
        private static ProfilingSampler _aabbScheduleProfilingSampler;
        public static IReadOnlyList<IVLActorController> actorControllers
        {
            get
            {
                return _actorControllers;
            }
        }

        public IEnumerable<DefaultBoneInfo> boneInfos
        {
            get
            {
                return null;
            }
        }

        public string gameObjectName
        {
            get
            {
                return null;
            }
        }

        public int index
        {
            get
            {
                return default(int);
            }
        }

        public Animator animator
        {
            get
            {
                return null;
            }
        }

        public Avatar avatar
        {
            get
            {
                return null;
            }
        }

        public bool isDestroyed
        {
            get
            {
                return default(bool);
            }
        }

        public virtual Bounds bounds
        {
            get
            {
                return default(Bounds);
            }
        }

        public Vector3 position
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Quaternion rotation
        {
            get
            {
                return default(Quaternion);
            }

            set
            {
            }
        }

        public float rotationY
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public Vector3 scale
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 eulerAngles
        {
            get
            {
                return default(Vector3);
            }

            set
            {
            }
        }

        public Vector3 forward
        {
            get
            {
                return default(Vector3);
            }
        }

        public IReadOnlyList<GameObject> GetBuildResources()
        {
            return null;
        }

        public IReadOnlyList<VLActorModelParts> GetModelPartsList()
        {
            return null;
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void Update()
        {
        }

        protected virtual void LateUpdate()
        {
        }

        protected void ScheduleRenderingJobs()
        {
        }

        private void SetupSkinningModels()
        {
        }

        public virtual bool IsRendererActive()
        {
            return default(bool);
        }

        public virtual void SetRendererActive(bool active)
        {
        }

        public virtual void BuildModel(IEnumerable<GameObject> resources)
        {
        }

        protected virtual void InitializeData()
        {
        }

        protected virtual void SetupAnimation()
        {
        }

        protected virtual HumanDescription GetHumanDescription(HumanBone[] human, SkeletonBone[] skeleton)
        {
            return default(HumanDescription);
        }

        public virtual void ResetModel()
        {
        }

        public virtual void ResetTime()
        {
        }

        public virtual void ApplyActorAnimationManagePropertyData(ActorAnimationManagePropertyData propertyData)
        {
        }

        public virtual Vector3 GetAnimatedPosition()
        {
            return default(Vector3);
        }

        public virtual Quaternion GetAnimatedRotation()
        {
            return default(Quaternion);
        }

        public virtual Transform GetHumanBodyBoneTransform(HumanBodyBones hbb)
        {
            return null;
        }

        public bool TryGetBoneTransformByName(string boneName, out Transform t)
        {
            throw null;
        }

        public Transform GetBoneTransformByName(string boneName)
        {
            return null;
        }

        public bool TryGetDefaultBoneInfo(Transform t, out DefaultBoneInfo info)
        {
            throw null;
        }

        public void SetAnimatorBindingToDirector(PlayableDirector director, UnityEngine.Object key)
        {
        }

        public virtual void DestroyActor()
        {
        }

        private void UpdateExtension()
        {
        }

        public T RegisterExtension<T>()
            where T : VLActorExtension
        {
            return null;
        }

        public void UnRegisterExtension<T>()
            where T : VLActorExtension
        {
        }

        public ParentConstraint SetParentConstraint(Transform parent)
        {
            return null;
        }

        public void RemoveParentConstraint()
        {
        }

        protected void InitializeAABB()
        {
        }

        protected void DisposeAABB()
        {
        }

        protected JobHandle ScheduleAABBJob()
        {
            return default(JobHandle);
        }

        protected void RunAABBJob()
        {
        }

        private void ApplyChildAABB(VLActorModelParts child, Bounds localBounds)
        {
        }

        protected void ApplyAABB()
        {
        }

        private void OnDrawGizmosSelected()
        {
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
