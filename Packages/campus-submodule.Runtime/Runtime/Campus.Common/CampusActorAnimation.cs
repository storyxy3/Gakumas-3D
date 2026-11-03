namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Animation;
    using global::VL.IK;

    [ExecuteAlways]
    [DefaultExecutionOrder(-1500)]
    public class CampusActorAnimation : VLActorExtension
    {
        [Tooltip("0.0の場合、モーションの制限が無くなり、無理やり向こうとします。1.0の場合、可能な限りモーションを使用し少しだけ適用されます。0.5はその中間です")]
        [Range(0f, 1f)]
        public float lookAtClampWeight;
        [Range(0f, 1.5f)]
        public float stiffness;
        [Range(1f, 50f)]
        public int maxPullIteration;
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
                return default(Vector3);
            }
        }

        public Quaternion FullBodyIkHeadOriginalRotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        public Vector3 FullBodyIkHeadOriginalForward
        {
            get
            {
                return default(Vector3);
            }
        }

        public CustomLookAtEffector CustomLookAtEffector
        {
            get
            {
                return null;
            }
        }

        public void SetCustomLookAt(Transform t)
        {
        }

        public void SetCustomLookAt(Vector3 pos)
        {
        }

        public void ResetCustomLookAt()
        {
        }

        private void SetLocalCustomLookAtEffector()
        {
        }

        public void SetCustomLookAtEffector(CustomLookAtEffector effector)
        {
        }

        public void SetCampusCustomLookAtEffector(CampusCustomLookAtEffector effector)
        {
        }

        [ContextMenu("SetupCustomLookAtEffector")]
        private void SetupCustomLookAtEffector()
        {
        }

        [ContextMenu("SetupCampusCustomLookAtLimit")]
        private void SetupCampusCustomLookAtLimit()
        {
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
        }

        public void DisableIKGoalForOverride(AvatarIKGoal ikGoal)
        {
        }

        public void SetupIKGoalForOverride(Animator animator, Transform ikGoalEffectorTransform, AvatarIKGoal ikGoal, ActorAnimationIKHandleType handleType)
        {
        }

        public void SetActorLayout(Transform actorLayout)
        {
        }

        public override void Initialize()
        {
        }

        private void DynamicReference()
        {
        }

        public override void Dispose()
        {
        }

        public bool Setup(Transform rootTransform, CampusActorAnimationInitializeData initializeData)
        {
            return default(bool);
        }

        public override void OnUpdate()
        {
        }

        public void SetInactiveBones(IEnumerable<int> inactiveBones)
        {
        }

        public void Reset()
        {
        }

        [ContextMenu("ResetDynamicSkin")]
        public void ResetDynamicSkin()
        {
        }

        public void ResetTime()
        {
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
        }

        public void SetAndEnableJointLimitSetting(CampusActorAnimationJointLimitSetting setting)
        {
        }

        public void DisableJointLimitSetting()
        {
        }

        public CampusActorAnimation()
        {
        }
    }
}
