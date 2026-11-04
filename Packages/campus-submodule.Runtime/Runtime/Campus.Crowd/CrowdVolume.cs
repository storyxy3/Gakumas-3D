// TODO(qa-recon): Selected APK bodies still need reconstruction: <BuildHierarchy>g__Build|16_1, <BuildHierarchy>g__Create|16_0, BuildHierarchy, LateUpdate, OnDestroy, UpdateParameters, get_AnimationComponent, get_CrowdPenlight, get_Position.
namespace Campus.Crowd
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Crowd;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;

    public class CrowdVolume : Volume
    {
        [SerializeField]
        public CrowdModelData modelData;
        [SerializeField]
        public CrowdData crowdData;
        [SerializeField]
        public CrowdColorPreset colorPreset;
        [SerializeField]
        public Transform lookAtTarget;
        [SerializeField]
        [Range(0f, 1f)]
        public float randomLookAtWeight;
        [NonSerialized]
        private Crowd _crowd;
        [NonSerialized]
        private ICrowdAnimation _animation;
        [NonSerialized]
        private ICrowdPenlight _crowdPenlight;
        public Vector3 Position
        {
            get
            {
                return default(Vector3);
            }
        }

        public ICrowdAnimation AnimationComponent
        {
            get
            {
                return null;
            }
        }

        public ICrowdPenlight CrowdPenlight
        {
            get
            {
                return null;
            }
        }

        public Crowd Crowd
        {
            get
            {
                return _crowd;
            }
        }

        public void BuildHierarchy()
        {
        }

        private void LateUpdate()
        {
        }

        private void OnDestroy()
        {
        }

        private void UpdateParameters()
        {
        }

        public CrowdVolume()
        {
        }

        [CompilerGenerated]
        internal static Transform _003CBuildHierarchy_003Eg__Create_007C16_0(Transform parent, string goName, ref Matrix4x4 bindPose)
        {
            return null;
        }

        [CompilerGenerated]
        internal static void _003CBuildHierarchy_003Eg__Build_007C16_1(Transform parent, string path, ref Matrix4x4 bindPose)
        {
        }
    }
}
