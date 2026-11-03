namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;

    [RequireComponent(typeof(Animator))]
    public class ActorSwingGroup : MonoBehaviour
    {
        public delegate void OnAddGroupCallback(ActorSwingGroup group);
        public delegate void OnRemoveGroupCallback(ActorSwingGroup group);
        public static OnAddGroupCallback onAddGroup;
        public static OnRemoveGroupCallback onRemoveGroup;
        [SerializeField]
        private List<ActorSwingDynamicBone> _dynamicBones;
        [SerializeField]
        private List<ActorSwingStaticBone> _staticBones;
        [SerializeField]
        private List<ActorSwingBreastBone> _breastBones;
        private Dictionary<Transform, int> _parentToChild;
        private Dictionary<Transform, ActorSwingDynamicBone> _workBoneCache;
        private HashSet<int> _chainBoneCache;
        private List<ActorSwingJobDynamicBone> _jobDynamicBones;
        public IEnumerable<ActorSwingDynamicBone> dynamicBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorSwingStaticBone> staticBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorSwingBreastBone> breastBones
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

        public int GetHierarchyDepth(Transform target)
        {
            return default(int);
        }

        public void Initialize()
        {
        }

        public void SetupJob()
        {
        }

        public void RegisterBones(IEnumerable<IActorSwingBone> bones)
        {
        }

        private void RegisterBone(IActorSwingBone bone)
        {
        }

        public ActorSwingGroup()
        {
        }
    }
}
