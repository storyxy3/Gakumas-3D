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
                return lookAtTarget != null ? lookAtTarget.transform.position : transform.position;
            }
        }

        public ICrowdAnimation AnimationComponent
        {
            get
            {
                if (_animation == null) _animation = GetComponent<ICrowdAnimation>();
                return _animation;
            }
        }

        public ICrowdPenlight CrowdPenlight
        {
            get
            {
                if (_crowdPenlight == null) _crowdPenlight = GetComponent<ICrowdPenlight>();
                return _crowdPenlight;
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
            var reference = transform.Find("Reference");
            if (reference != null) UnityEngine.Object.Destroy(reference.gameObject);
            if (modelData == null) return;
            for (int i = 0; i < modelData.Bones.Length; i++)
            {
                var path = modelData.Bones[i];
                if (!string.IsNullOrEmpty(path))
                {
                    var bindPose = modelData.BindPoses[i];
                    _003CBuildHierarchy_003Eg__Build_007C16_1(transform, path, ref bindPose);
                }
            }
        }

        private void LateUpdate()
        {
            UpdateParameters();
        }

        private void OnDestroy()
        {
            if (_crowd != null) UnityEngine.Object.DestroyImmediate(_crowd);
            UnityEngine.Object.DestroyImmediate(profile);
        }

        private void UpdateParameters()
        {
            if (_crowd == null && !profile.TryGet(out _crowd)) _crowd = profile.Add<Crowd>();
            _crowd.target.Override(this);
        }

        public CrowdVolume()
        {
        }

        [CompilerGenerated]
        internal static Transform _003CBuildHierarchy_003Eg__Create_007C16_0(Transform parent, string goName, ref Matrix4x4 bindPose)
        {
            if (string.IsNullOrEmpty(goName)) return null;
            var child = parent.Find(goName);
            if (child == null)
            {
                var go = new GameObject(goName);
                go.layer = parent.gameObject.layer;
                child = go.transform;
                child.SetPositionAndRotation(bindPose.GetPosition(), bindPose.rotation);
                child.SetParent(parent, false);
            }
            return child;
        }

        [CompilerGenerated]
        internal static void _003CBuildHierarchy_003Eg__Build_007C16_1(Transform parent, string path, ref Matrix4x4 bindPose)
        {
            int separator = path.IndexOf('/');
            if (separator > 0)
            {
                var child = _003CBuildHierarchy_003Eg__Create_007C16_0(parent, path.Substring(0, separator), ref bindPose);
                _003CBuildHierarchy_003Eg__Build_007C16_1(child, path.Substring(separator + 1), ref bindPose);
            }
            else _003CBuildHierarchy_003Eg__Create_007C16_0(parent, path, ref bindPose);
        }
    }
}
