namespace VL.Core
{
    using global::System;
    using global::System.Linq;
    using global::Unity.Collections;
    using global::UnityEngine.Jobs;
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
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<VLActorModelParts, IEnumerable<DefaultBoneInfo>> _003C_003E9__6_0;
            public static Func<VLActorModelParts, int> _003C_003E9__79_0;
            public _003C_003Ec()
            {
            }

            internal IEnumerable<DefaultBoneInfo> _003Cget_boneInfos_003Eb__6_0(VLActorModelParts x)
            {
                return x.boneInfos;
            }

            internal int _003CInitializeAABB_003Eb__79_0(VLActorModelParts x)
            {
                return x.aabbTransform?.Count ?? 0;
            }
        }

        private static ProfilingSampler _scheduleJobSampler = new ProfilingSampler("ScheduleJob");
        private static ProfilingSampler _completeJobSampler = new ProfilingSampler("CompleteJob");
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
        private static ProfilingSampler _aabbScheduleProfilingSampler = new ProfilingSampler("Schedule AABB");
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
                return _childMap.Values.SelectMany(_003C_003Ec._003C_003E9__6_0 ?? (_003C_003Ec._003C_003E9__6_0 = _003C_003Ec._003C_003E9._003Cget_boneInfos_003Eb__6_0));
            }
        }

        public string gameObjectName
        {
            get
            {
                return gameObject.name;
            }
        }

        public int index
        {
            get
            {
                return _index;
            }
        }

        public Animator animator
        {
            get
            {
                return _animator;
            }
        }

        public Avatar avatar
        {
            get
            {
                return _avatar;
            }
        }

        public bool isDestroyed
        {
            get
            {
                return _isDestroyed;
            }
        }

        public virtual Bounds bounds
        {
            get
            {
                return _bounds;
            }
        }

        public Vector3 position
        {
            get
            {
                return transform.localPosition;
            }

            set
            {
                transform.localPosition = value;
            }
        }

        public Quaternion rotation
        {
            get
            {
                return transform.localRotation;
            }

            set
            {
                transform.localRotation = value;
            }
        }

        public float rotationY
        {
            get
            {
                return transform.localEulerAngles.y;
            }

            set
            {
                transform.localEulerAngles = new Vector3(0, value, 0);
            }
        }

        public Vector3 scale
        {
            get
            {
                return transform.localScale;
            }

            set
            {
                transform.localScale = value;
            }
        }

        public Vector3 eulerAngles
        {
            get
            {
                return transform.localEulerAngles;
            }

            set
            {
                transform.localEulerAngles = value;
            }
        }

        public Vector3 forward
        {
            get
            {
                return transform.forward;
            }
        }

        public IReadOnlyList<GameObject> GetBuildResources()
        {
            return _buildResources;
        }

        public IReadOnlyList<VLActorModelParts> GetModelPartsList()
        {
            return _children;
        }

        protected virtual void OnEnable()
        {
            if (_avatar != null) SetupAnimation();
            if (_actorControllers == null) _actorControllers = new List<IVLActorController>();
            _actorControllers.Add(this);
            InitializeAABB();
            for (int i = 0; i < _extensions.Count; ++i)
            {
                if (_extensions[i] != null && (!_extensions[i].runtimeOnly || Application.isPlaying)) _extensions[i].Initialize();
            }
        }

        protected virtual void OnDisable()
        {
            if (_extensions != null)
                for (int i = 0; i < _extensions.Count; ++i)
                {
                    if (_extensions[i] != null && (!_extensions[i].runtimeOnly || Application.isPlaying)) _extensions[i].Dispose();
                }
            DisposeAABB();
            _actorControllers?.Remove(this);
        }

        protected virtual void Update()
        {
            if (_extensions != null)
                for (int i = 0; i < _extensions.Count; ++i)
                {
                    if (_extensions[i] != null && (!_extensions[i].runtimeOnly || Application.isPlaying)) _extensions[i].OnUpdate();
                }
        }

        protected virtual void LateUpdate()
        {
            if (_extensions != null)
                for (int i = 0; i < _extensions.Count; ++i)
                {
                    if (_extensions[i] != null) _extensions[i].OnLateUpdate();
                }
            ScheduleRenderingJobs();
        }

        protected void ScheduleRenderingJobs()
        {
            using (new ProfilingScope(null, _scheduleJobSampler))
            {
                RunAABBJob();
                ApplyAABB();
                SetupSkinningModels();
            }
        }

        private void SetupSkinningModels()
        {
            if (_children == null) return;
            foreach (var child in _children)
                if (child != null && child.skinningModel != null) child.skinningModel.SetupSkinning();
        }

        public virtual bool IsRendererActive()
        {
            return default(bool);
        }

        public virtual void SetRendererActive(bool active)
        {
            if (_extensions == null) return;
            for (int i = 0; i < _extensions.Count; ++i)
            {
                if (_extensions[i] != null) _extensions[i].OnRendererActiveChanged(active);
            }
        }

        public virtual void BuildModel(IEnumerable<GameObject> resources)
        {
            _buildResources = resources.ToArray();
            InitializeData();
        }

        protected virtual void InitializeData()
        {
            if (_boneNameToTransformMap == null) _boneNameToTransformMap = new BoneNameToTransformDictionary(256);
            else _boneNameToTransformMap.Clear();
            if (_children == null) _children = new List<VLActorModelParts>(8);
            else _children.Clear();
            if (_partsIdMap == null) _partsIdMap = new PartsIdMapDictionary(8);
            else _partsIdMap.Clear();
            if (_childMap == null) _childMap = new ChildMapDictionary(8);
            else _childMap.Clear();
        }

        protected virtual void SetupAnimation()
        {
            if (!TryGetComponent(out _animator)) _animator = gameObject.AddComponent<Animator>();
            _animator.avatar = _avatar;
        }

        protected virtual HumanDescription GetHumanDescription(HumanBone[] human, SkeletonBone[] skeleton)
        {
            return new HumanDescription { human = human, skeleton = skeleton, lowerArmTwist = 0.8f, upperArmTwist = 0.8f, lowerLegTwist = 0.8f, upperLegTwist = 0.8f, armStretch = 0.05f, legStretch = 0.05f, feetSpacing = 0, hasTranslationDoF = false };
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
            return position;
        }

        public virtual Quaternion GetAnimatedRotation()
        {
            return rotation;
        }

        public virtual Transform GetHumanBodyBoneTransform(HumanBodyBones hbb)
        {
            throw new NotImplementedException();
        }

        public bool TryGetBoneTransformByName(string boneName, out Transform t)
        {
            if (_boneNameToTransformMap != null) return _boneNameToTransformMap.TryGetValue(boneName, out t);
            Debug.LogError("初期化されていません");
            t = null;
            return false;
        }

        public Transform GetBoneTransformByName(string boneName)
        {
            TryGetBoneTransformByName(boneName, out var t);
            return t;
        }

        public bool TryGetDefaultBoneInfo(Transform t, out DefaultBoneInfo info)
        {
            if (_children != null)
            {
                foreach (var child in _children)
                    if (child.TryGetDefaultBoneInfo(t, out info)) return true;
            }
            else Debug.LogError("初期化されていません");
            info = null;
            return false;
        }

        public void SetAnimatorBindingToDirector(PlayableDirector director, UnityEngine.Object key)
        {
            director.SetGenericBinding(key, _animator);
        }

        public virtual void DestroyActor()
        {
            if (this == null || transform == null) return;
            _isDestroyed = true;
            if (Application.isPlaying) Destroy(gameObject);
            else
            {
                if (_extensions != null)
                    foreach (var extension in _extensions) extension.Dispose();
                DestroyImmediate(gameObject, true);
            }
        }

        private void UpdateExtension()
        {
            if (_extensions == null) _extensions = new List<VLActorExtension>();
            GetComponents(_extensions);
            _extensions.Sort();
        }

        public T RegisterExtension<T>()
            where T : VLActorExtension
        {
            if (!TryGetComponent<T>(out var component)) component = gameObject.AddComponent<T>();
            UpdateExtension();
            return component;
        }

        public void UnRegisterExtension<T>()
            where T : VLActorExtension
        {
            // APK 3.5.3 at 0x94866b0 skips destruction when TryGetComponent succeeds.
            if (!TryGetComponent<T>(out var component)) DestroyImmediate(component);
            UpdateExtension();
        }

        public ParentConstraint SetParentConstraint(Transform parent)
        {
            var constraint = GetComponent<ParentConstraint>();
            if (constraint == null) constraint = gameObject.AddComponent<ParentConstraint>();
            var source = new ConstraintSource { sourceTransform = parent, weight = 1 };
            if (constraint.sourceCount == 1) constraint.SetSource(0, source);
            else constraint.AddSource(source);
            constraint.SetTranslationOffset(0, Vector3.zero);
            constraint.SetRotationOffset(0, Vector3.zero);
            constraint.locked = true;
            constraint.constraintActive = true;
            return constraint;
        }

        public void RemoveParentConstraint()
        {
            var constraint = GetComponent<ParentConstraint>();
            if (constraint != null)
            {
                if (Application.isPlaying) Destroy(constraint);
                else DestroyImmediate(constraint);
            }
        }

        protected void InitializeAABB()
        {
            DisposeAABB();
            if (_children == null) return;
            int count = _children.Sum(_003C_003Ec._003C_003E9__79_0 ?? (_003C_003Ec._003C_003E9__79_0 = _003C_003Ec._003C_003E9._003CInitializeAABB_003Eb__79_0));
            var data = new NativeArray<AABBData>(_children.Count, Allocator.Persistent);
            var transforms = new TransformAccessArray(count);
            for (int i = 0; i < _children.Count; ++i)
            {
                var child = _children[i];
                var bones = _children[i].aabbTransform;
                if (child == null || bones == null) { data[i] = default; continue; }
                data[i] = new AABBData { aabbCalcType = child.aabbCalcType, positionIndex = transforms.length, positionLength = bones.Count, defaultBounds = child.defaultBounds };
                for (int j = 0; j < bones.Count; ++j) transforms.Add(bones[j]);
            }
            _aabbJobData = new AABBJobData(data, transforms);
        }

        protected void DisposeAABB()
        {
            _aabbJobData.Dispose();
        }

        protected JobHandle ScheduleAABBJob()
        {
            if (_aabbJobData.IsValid())
            {
                using (new ProfilingScope(null, _aabbScheduleProfilingSampler))
                {
                    for (int i = 0; i < _children.Count; ++i)
                    {
                        Matrix4x4 matrix = _children[i].defaultRootTransform != null ? _children[i].defaultRootTransform.localToWorldMatrix : Matrix4x4.identity;
                        _aabbJobData.UpdateLocalToWorldMatrix(i, in matrix);
                    }
                    return _aabbJobData.Schedule();
                }
            }
            return default;
        }

        protected void RunAABBJob()
        {
            if (_aabbJobData.IsValid())
            {
                using (new ProfilingScope(null, _aabbScheduleProfilingSampler))
                {
                    for (int i = 0; i < _children.Count; ++i)
                    {
                        Matrix4x4 matrix = _children[i].defaultRootTransform != null ? _children[i].defaultRootTransform.localToWorldMatrix : Matrix4x4.identity;
                        _aabbJobData.UpdateLocalToWorldMatrix(i, in matrix);
                    }
                    _aabbJobData.Run();
                }
            }
        }

        private void ApplyChildAABB(VLActorModelParts child, Bounds localBounds)
        {
            if (child == null) return;
            var renderers = child.skinRenderers;
            for (int i = 0; i < renderers.Count; ++i) renderers[i].localBounds = localBounds;
        }

        protected void ApplyAABB()
        {
            if (_children == null || !_aabbJobData.IsValid()) return;
            _aabbJobData.Complete();
            bool first = true;
            for (int i = 0; i < _children.Count; ++i)
            {
                if (!_aabbJobData.IsActive(i)) continue;
                if (first) _bounds = _aabbJobData.GetBounds(i);
                else _bounds.Encapsulate(_aabbJobData.GetBounds(i));
                ApplyChildAABB(_children[i], _aabbJobData.GetLocalBounds(i));
                first = false;
            }
        }

        private void OnDrawGizmosSelected()
        {
        }

        public VLActorController()
        {
        }

        bool VL.IVLActorController.TryGetComponent<T>(out T component)
        {
            return TryGetComponent<T>(out component);
        }
    }
}
