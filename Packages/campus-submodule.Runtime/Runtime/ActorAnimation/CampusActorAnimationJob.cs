namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;
    using global::VL.IK;

    [BurstCompile]
    public struct CampusActorAnimationJob : IActorAnimationJob, IWeightedAnimationJob, IAnimationJob, IActorAnimation, IActorAnimationSwingSkeleton, IActorAnimationFullBodyIK, ICampusActorAnimationLookAtLimit, ICampusActorAnimationJointLimit
    {
        [CompilerGenerated]
        private FloatProperty _003CjobWeight_003Ek__BackingField;
        private NativeArray<ActorAnimationConstraintTransformJobBone> _constraintTransformJobBones;
        private NativeArray<ActorAnimationQuartzDriverRotationJobBone> _quartzDriverRotationJobBones;
        private NativeArray<ActorAnimationQuartzDriverFrillJobBone> _quartzDriverFrillJobBones;
        private NativeArray<ActorAnimationQuartzDriverSkirtJobBone> _quartzDriverSkirtJobBones;
        private NativeArray<ActorAnimationQuartzDriverHairJobBone> _quartzDriverHairJobBones;
        private NativeArray<ActorAnimationQuartzDriverHumanoidHandJobBone> _quartzDriverHumanoidHandJobBones;
        private NativeArray<ActorAnimationQuartzDriverHumanoidSleeveJobBone> _quartzDriverHumanoidSleeveJobBones;
        private NativeArray<ActorAnimationQuartzDriverHumanoidUpLegJobBone> _quartzDriverHumanoidUpLegJobBones;
        private NativeArray<ActorAnimationQuartzDriverHumanoidArmJobBone> _quartzDriverHumanoidArmJobBones;
        private NativeArray<ActorAnimationQuartzDriverWaistJobBone> _quartzDriverWaistJobBones;
        private NativeArray<ActorAnimationQuartzDriverFurisodeJobBone> _quartzDriverFurisodeJobBones;
        private NativeArray<ActorAnimationQuartzDriverPonchoJobBone> _quartzDriverPonchoJobBones;
        private ActorAnimationSwingJobSkeleton _swingJobSkeleton;
        private ActorAnimationFullBodyIKJobSkeleton _fullBodyIKJobSkeleton;
        public ActorAnimationRootControllerJobLocator _rootController;
        public CampusActorAnimationLookAtLimit _lookAtLimit;
        private CampusActorAnimationJointLimit _jointLimit;
        [CompilerGenerated]
        private ActorAnimationManageProperty _003CmanageProperty_003Ek__BackingField;
        public FloatProperty jobWeight
        {
            [CompilerGenerated]
            set
            {
            }

            // TODO(qa-recon): Getter stripped from game metadata; required for C# interface/attribute compilation.
            get
            {
                throw null;
            }
        }

        public NativeArray<ActorAnimationConstraintTransformJobBone> constraintTransformJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationConstraintTransformJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverRotationJobBone> quartzDriverRotationJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverRotationJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverFrillJobBone> quartzDriverFrillJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverFrillJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverSkirtJobBone> quartzDriverSkirtJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverSkirtJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHairJobBone> quartzDriverHairJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverHairJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidHandJobBone> quartzDriverHumanoidHandJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverHumanoidHandJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidSleeveJobBone> quartzDriverHumanoidSleeveJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverHumanoidSleeveJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidUpLegJobBone> quartzDriverHumanoidUpLegJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverHumanoidUpLegJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidArmJobBone> quartzDriverHumanoidArmJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverHumanoidArmJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverWaistJobBone> quartzDriverWaistJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverWaistJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverFurisodeJobBone> quartzDriverFurisodeJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverFurisodeJobBone>);
            }

            set
            {
            }
        }

        public NativeArray<ActorAnimationQuartzDriverPonchoJobBone> quartzDriverPonchoJobBones
        {
            get
            {
                return default(NativeArray<ActorAnimationQuartzDriverPonchoJobBone>);
            }

            set
            {
            }
        }

        public ActorAnimationSwingJobSkeleton swingJobSkeleton
        {
            get
            {
                return default(ActorAnimationSwingJobSkeleton);
            }
        }

        public ActorAnimationFullBodyIKJobSkeleton fullBodyIKJobSkeleton
        {
            get
            {
                return default(ActorAnimationFullBodyIKJobSkeleton);
            }
        }

        public void ProcessAnimation(AnimationStream stream)
        {
        }

        public void ProcessFullBodyIK(AnimationStream stream)
        {
        }

        public void ProcessLookAtLimit(AnimationStream stream)
        {
        }

        public void ProcessJointLimit(AnimationStream stream)
        {
        }

        public void ProcessConstraint(AnimationStream stream)
        {
        }

        public void ProcessQuartzDriver(AnimationStream stream)
        {
        }

        public void ProcessSwingSkeleton(AnimationStream stream)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }

        public void ProcessRoot(AnimationStream stream)
        {
        }

        public void Create<TData>(Animator animator, ref TData rigData)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void CreateConstraint(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateQuartzDriver(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateFullBodyIK(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateSwingSkeleton(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateRoot(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void UpdateConstraintSource<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void UpdateIKCorrectionColliderProperty<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void UpdateManageProperty(ActorAnimationManageProperty manageProperty)
        {
        }

        public void UpdateRigData<TData>(ref TData rigData)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void SetupCustomLookAtEffector(Animator animator, CustomLookAtEffector customLookAtEffector)
        {
            var effector = _fullBodyIKJobSkeleton.customLookAtEffector;
            ReadOnlyTransformHandle reference = default;
            if (customLookAtEffector.target != null)
                reference = ReadOnlyTransformHandle.Bind(animator, customLookAtEffector.transform);
            effector.Setup(reference,
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "useCustomTargetPosition"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "customTargetPosition.x"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "customTargetPosition.y"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "customTargetPosition.z"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "eyesWeight"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "headWeight"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "bodyWeight"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "customUseWeight"),
                animator.BindSceneProperty(customLookAtEffector.transform, typeof(CustomLookAtEffector), "weight"));
            _fullBodyIKJobSkeleton.customLookAtEffector = effector;
        }

        public void SetupCampusLookAtLimit(Animator animator, CampusCustomLookAtEffector campusCustomLookAtEffector, CampusActorAnimationInitializeData initializeData)
        {
            _lookAtLimit = new CampusActorAnimationLookAtLimit(
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "isCustomLookAtLimitEnablePose"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "enableLimitWeight"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "eyeInOutLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "eyeUpLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "eyeDownLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "headLeftRightLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "headFrontLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "headBackLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "headRollLeftRightLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "neckLeftRightLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "neckFrontLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "neckBackLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "neckRollLeftRightLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "bodyLeftRightLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "bodyFrontLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "bodyBackLimit"),
                animator.BindSceneProperty(campusCustomLookAtEffector.transform, typeof(CampusCustomLookAtEffector), "bodyTwistLeftRightLimit"),
                new MuscleHandle((HeadDof)7),
                new MuscleHandle((HeadDof)6),
                new MuscleHandle((HeadDof)9),
                new MuscleHandle((HeadDof)8),
                new MuscleHandle((HeadDof)0),
                new MuscleHandle((HeadDof)1),
                new MuscleHandle((HeadDof)2),
                new MuscleHandle((HeadDof)3),
                new MuscleHandle((HeadDof)4),
                new MuscleHandle((HeadDof)5),
                new MuscleHandle((BodyDof)1),
                new MuscleHandle((BodyDof)0),
                new MuscleHandle((BodyDof)2),
                new MuscleHandle((BodyDof)4),
                new MuscleHandle((BodyDof)3),
                new MuscleHandle((BodyDof)5),
                new MuscleHandle((BodyDof)7),
                new MuscleHandle((BodyDof)6),
                new MuscleHandle((BodyDof)8));
        }

        public void SetupCampusJointLimit(Animator animator)
        {
            _jointLimit = new CampusActorAnimationJointLimit(
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "jointLimitNowLimited"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "jointLimitEyeEnable"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "jointLimitEyeUpLimit"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "jointLimitEyeDownLimit"),
                new MuscleHandle((HeadDof)6), new MuscleHandle((HeadDof)8));
        }

        public void DisposeCustomLookAtEffector()
        {
            _fullBodyIKJobSkeleton.customLookAtEffector.Dispose();
        }

        public void SetEnableSeatedDynamicCorrection(bool enable)
        {
            var correction = _swingJobSkeleton.seatedDynamicCorrection;
            correction.enableSeatedDynamicCorrection = enable;
            _swingJobSkeleton.seatedDynamicCorrection = correction;
        }

        public void DisableIKGoal(AvatarIKGoal ikGoal)
        {
            switch (ikGoal)
            {
                case AvatarIKGoal.LeftFoot: _fullBodyIKJobSkeleton.leftFootEffector = default; break;
                case AvatarIKGoal.RightFoot: _fullBodyIKJobSkeleton.rightFootEffector = default; break;
                case AvatarIKGoal.LeftHand: _fullBodyIKJobSkeleton.leftHandEffector = default; break;
                case AvatarIKGoal.RightHand: _fullBodyIKJobSkeleton.rightHandEffector = default; break;
            }
        }

        public void SetupIKGoalEffector(Animator animator, Transform ikGoalEffectorTransform, AvatarIKGoal ikGoal, ActorAnimationIKHandleType handleType)
        {
            switch (ikGoal)
            {
                case AvatarIKGoal.LeftFoot: _fullBodyIKJobSkeleton.leftFootEffector = new ActorAnimationIKGoalEffector(animator, ikGoalEffectorTransform, AvatarIKGoal.LeftFoot, handleType); break;
                case AvatarIKGoal.RightFoot: _fullBodyIKJobSkeleton.rightFootEffector = new ActorAnimationIKGoalEffector(animator, ikGoalEffectorTransform, AvatarIKGoal.RightFoot, handleType); break;
                case AvatarIKGoal.LeftHand: _fullBodyIKJobSkeleton.leftHandEffector = new ActorAnimationIKGoalEffector(animator, ikGoalEffectorTransform, AvatarIKGoal.LeftHand, handleType); break;
                case AvatarIKGoal.RightHand: _fullBodyIKJobSkeleton.rightHandEffector = new ActorAnimationIKGoalEffector(animator, ikGoalEffectorTransform, AvatarIKGoal.RightHand, handleType); break;
            }
        }

        public void SetActorLayout(Animator animator, Transform actorLayout)
        {
            _rootController.SetupRootController(animator.transform, actorLayout, animator);
        }

        public void ResetTime()
        {
            _swingJobSkeleton.ResetTime();
        }

        public void Destroy()
        {
        }

        public void ApplyActorSwingCmmnHeightCorrection(bool enabled)
        {
            _swingJobSkeleton.isCmmnHeightCorrectionNeeded = enabled;
        }

        private void DestroyIK()
        {
        }

        private void DestroyConstraint()
        {
        }

        private void DestroyQuartzDriver()
        {
        }

        private void DestroySwing()
        {
        }
    }
}
