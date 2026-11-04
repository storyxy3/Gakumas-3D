namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Playables;
    using global::VL;
    using global::VL.Animation;
    using global::VL.IK;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1500)]
    public class CampusActorAnimation : VLActorExtension
    {
        [Tooltip("0.0の場合、モーションの制限が無くなり、無理やり向こうとします。1.0の場合、可能な限りモーションを使用し少しだけ適用されます。0.5はその中間です")]
        [Range(0f, 1f)]
        public float lookAtClampWeight = 0.5f;
        [Range(0f, 1.5f)]
        public float stiffness = 1f;
        [Range(1f, 50f)]
        public int maxPullIteration = 5;
        [Range(-0.2f, 0.2f)]
        public float handDown;
        [SerializeField]
        private CampusActorAnimationRig _actorAnimationRig;
        [SerializeField]
        private IAnimationPlayer _animationPlayer;
        [SerializeField]
        [HideInInspector]
        private Transform _rootTransform;
        [SerializeField]
        [HideInInspector]
        private CampusActorAnimationInitializeData _initializeData;
        private CampusActorAnimationBuilder _builder;
        private List<IActorAnimationBone> _componentCaches;
        [SerializeField]
        private CustomLookAtEffector _customLookAtEffector;
        [Range(-1f, 1f)]
        public float nodAdditiveNeckFrontBackWeight;
        [Range(-1f, 1f)]
        public float nodAdditiveNeckLeftRightWeight;
        [Range(-1f, 1f)]
        public float nodAdditiveNeckRollLeftRightWeight;
        [Range(-1f, 1f)]
        public float nodAdditiveHeadFrontBackWeight;
        [Range(-1f, 1f)]
        public float nodAdditiveHeadLeftRightWeight;
        [Range(-1f, 1f)]
        public float nodAdditiveHeadRollLeftRightWeight;
        public float fullBodyIkHeadOriginalPositionX;
        public float fullBodyIkHeadOriginalPositionY;
        public float fullBodyIkHeadOriginalPositionZ;
        public float fullBodyIkHeadOriginalRotationX;
        public float fullBodyIkHeadOriginalRotationY;
        public float fullBodyIkHeadOriginalRotationZ;
        public bool isCustomLookAtLimitEnablePose;
        private bool _customLookAtEffectorInitialized;
        [SerializeField]
        private CampusActorAnimationJointLimitSetting jointLimitSetting;
        public bool jointLimitNowLimited;
        public bool jointLimitEyeEnable;
        [Range(0f, 2f)]
        public float jointLimitEyeUpLimit;
        [Range(0f, -2f)]
        public float jointLimitEyeDownLimit;
        public Vector3 FullBodyIkHeadOriginalPosition
        {
            get
            {
                return new Vector3(fullBodyIkHeadOriginalPositionX, fullBodyIkHeadOriginalPositionY, fullBodyIkHeadOriginalPositionZ);
            }
        }

        public Quaternion FullBodyIkHeadOriginalRotation
        {
            get
            {
                return Quaternion.Euler(fullBodyIkHeadOriginalRotationX, fullBodyIkHeadOriginalRotationY, fullBodyIkHeadOriginalRotationZ);
            }
        }

        public Vector3 FullBodyIkHeadOriginalForward
        {
            get
            {
                return FullBodyIkHeadOriginalRotation * Vector3.forward;
            }
        }

        public CustomLookAtEffector CustomLookAtEffector
        {
            get
            {
                return _customLookAtEffector;
            }
        }

        public void SetCustomLookAt(Transform t)
        {
            SetLocalCustomLookAtEffector();
            _customLookAtEffector.target = t;
            _customLookAtEffector.useCustomTargetPosition = false;
            _customLookAtEffector.customTargetPosition = Vector3.zero;
            SetupCustomLookAtEffector();
        }

        public void SetCustomLookAt(Vector3 pos)
        {
            SetLocalCustomLookAtEffector();
            _customLookAtEffector.target = null;
            _customLookAtEffector.customTargetPosition = pos;
            _customLookAtEffector.useCustomTargetPosition = true;
            SetupCustomLookAtEffector();
        }

        public void ResetCustomLookAt()
        {
            _customLookAtEffectorInitialized = false;
            _customLookAtEffector = null;
            SetupCustomLookAtEffector();
        }

        private void SetLocalCustomLookAtEffector()
        {
            if (!TryGetComponent(out _customLookAtEffector))
                _customLookAtEffector = gameObject.AddComponent<CustomLookAtEffector>();
        }

        public void SetCustomLookAtEffector(CustomLookAtEffector effector)
        {
            _customLookAtEffectorInitialized = false;
            _customLookAtEffector = effector;
            SetupCustomLookAtEffector();
        }

        public void SetCampusCustomLookAtEffector(CampusCustomLookAtEffector effector)
        {
            _customLookAtEffectorInitialized = false;
            _customLookAtEffector = effector;
            SetupCustomLookAtEffector();
            SetupCampusCustomLookAtLimit();
        }

        [ContextMenu("SetupCustomLookAtEffector")]
        private void SetupCustomLookAtEffector()
        {
            if (_customLookAtEffectorInitialized) return;
            if (!_builder.playable.IsValid())
            {
                Debug.LogError("FullBodyIK:Playableが初期化されていません");
                return;
            }
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            if (_customLookAtEffector == null) job.DisposeCustomLookAtEffector();
            else
            {
                job.SetupCustomLookAtEffector(_animationPlayer.animator, _customLookAtEffector);
                _customLookAtEffectorInitialized = true;
            }
            _builder.playable.SetJobData(job);
        }

        [ContextMenu("SetupCampusCustomLookAtLimit")]
        private void SetupCampusCustomLookAtLimit()
        {
            if (!_customLookAtEffectorInitialized || _customLookAtEffector == null) return;
            if (!_builder.playable.IsValid())
            {
                Debug.LogError("CustomLookAtEffector:Playableが初期化されていません");
                return;
            }
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            if (_customLookAtEffector is CampusCustomLookAtEffector effector)
                job.SetupCampusLookAtLimit(_animationPlayer.animator, effector, _initializeData);
            _builder.playable.SetJobData(job);
        }

        [ContextMenu("SetupCampusJointLimitSetting")]
        public void SetupCampusJointLimitSetting()
        {
        }

        [ContextMenu("DisableJointLimitSettingParam")]
        public void DisableJointLimitSettingParam()
        {
        }

        public void SetEnableIKCollider(bool enable)
        {
        }

        public void SetEnableSeatedDynamicCorrection(bool enable)
        {
            if (!_builder.playable.IsValid()) return;
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            job.SetEnableSeatedDynamicCorrection(enable);
            _builder.playable.SetJobData(job);
        }

        public void DisableIKGoalForOverride(AvatarIKGoal ikGoal)
        {
            if (!_builder.playable.IsValid()) return;
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            job.DisableIKGoal(ikGoal);
            _builder.playable.SetJobData(job);
        }

        public void SetupIKGoalForOverride(Animator animator, Transform ikGoalEffectorTransform, AvatarIKGoal ikGoal, ActorAnimationIKHandleType handleType)
        {
            if (!_builder.playable.IsValid()) return;
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            job.SetupIKGoalEffector(animator, ikGoalEffectorTransform, ikGoal, handleType);
            _builder.playable.SetJobData(job);
        }

        public void SetActorLayout(Transform actorLayout)
        {
            if (!_builder.playable.IsValid())
            {
                Debug.LogError("ActorLayout:Playableが初期化されていません");
                return;
            }
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            job.SetActorLayout(_animationPlayer.animator, actorLayout);
            _builder.playable.SetJobData(job);
        }

        public override void Initialize()
        {
            if (_initializeData == null || !TryGetComponent(out _animationPlayer) || !_animationPlayer.initialized) return;
            if (!TryGetComponent(out _actorAnimationRig))
                _actorAnimationRig = gameObject.AddComponent<CampusActorAnimationRig>();
            var animator = _animationPlayer.animator;
            if (animator.avatar == null || !animator.avatar.isHuman)
            {
                Debug.LogError("Avatarが正しくありません");
                return;
            }
            DynamicReference();
            _actorAnimationRig.Clear();
            _actorAnimationRig.RegisterBones(_initializeData);
            _actorAnimationRig.SetRootTransform(_rootTransform);
            _actorAnimationRig.Initialize(_animationPlayer.animator);
            _builder = new CampusActorAnimationBuilder();
            _builder.Build(_animationPlayer.animator, _animationPlayer.GetPlayableGraph(), _actorAnimationRig);
        }

        private void DynamicReference()
        {
            var head = controller.GetBoneTransformByName("Head");
            var neck = controller.GetBoneTransformByName("Neck");
            if (head && neck)
            {
                foreach (var bone in _initializeData.quartzDriverHairBones)
                {
                    bone.setting.referenceHeadBone = head.gameObject;
                    bone.setting.referenceNeckBone = neck.gameObject;
                }
            }
        }

        public override void Dispose()
        {
            if (_actorAnimationRig != null)
            {
                _actorAnimationRig.Destroy();
                _actorAnimationRig = null;
            }
            if (_builder != null && _animationPlayer != null)
            {
                _builder.Destroy(_animationPlayer.GetPlayableGraph());
                _builder = null;
            }
        }

        public bool Setup(Transform rootTransform, CampusActorAnimationInitializeData initializeData)
        {
            _rootTransform = rootTransform;
            _initializeData = initializeData;
            Dispose();
            Initialize();
            return true;
        }

        public override void OnUpdate()
        {
            _builder?.Update();
            if (_actorAnimationRig != null && _actorAnimationRig.job != null) _actorAnimationRig.UpdateRig();
        }

        public void SetInactiveBones(IEnumerable<int> inactiveBones)
        {
            if (_actorAnimationRig != null) _actorAnimationRig.SetInactiveBones(inactiveBones);
        }

        public void Reset()
        {
            if (_actorAnimationRig != null) _actorAnimationRig.Reset();
        }

        [ContextMenu("ResetDynamicSkin")]
        public void ResetDynamicSkin()
        {
            if (_actorAnimationRig != null) _actorAnimationRig.ResetDynamicSkin();
        }

        public void ResetTime()
        {
            if (_actorAnimationRig != null)
            {
                var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
                job.ResetTime();
                _builder.playable.SetJobData(job);
            }
        }

        public void SetNodAdditiveNeckFrontBack(float weight)
        {
        }

        public void SetNodAdditiveNeckLeftRight(float weight)
        {
        }

        public void SetNodAdditiveNeckRollLeftRight(float weight)
        {
        }

        public void SetNodAdditiveHeadFrontBack(float weight)
        {
        }

        public void SetNodAdditiveHeadLeftRight(float weight)
        {
        }

        public void SetNodAdditiveHeadRollLeftRight(float weight)
        {
        }

        public void ClearNodAdditive()
        {
        }

        public void ApplyActorSwingCmmnHeightCorrection(bool enable)
        {
            if (!_builder.playable.IsValid()) return;
            var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
            job.ApplyActorSwingCmmnHeightCorrection(enable);
            _builder.playable.SetJobData(job);
        }

        public void SetAndEnableJointLimitSetting(CampusActorAnimationJointLimitSetting setting)
        {
            jointLimitSetting = setting;
            jointLimitEyeEnable = setting.eyeLimitEnable;
            jointLimitEyeUpLimit = setting.eyeUpLimit;
            jointLimitEyeDownLimit = setting.eyeDownLimit;
            if (_builder != null && _builder.playable.IsValid())
            {
                var job = _builder.playable.GetJobData<CampusActorAnimationJob>();
                job.SetupCampusJointLimit(_animationPlayer.animator);
                _builder.playable.SetJobData(job);
            }
        }

        public void DisableJointLimitSetting()
        {
            jointLimitSetting = null;
            jointLimitEyeEnable = false;
            jointLimitEyeUpLimit = 0f;
            jointLimitEyeDownLimit = 0f;
        }

        public CampusActorAnimation()
        {
        }
    }
}
