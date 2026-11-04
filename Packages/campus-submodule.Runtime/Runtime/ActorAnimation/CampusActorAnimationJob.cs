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
                _003CjobWeight_003Ek__BackingField = value;
            }

            // TODO(qa-recon): Getter stripped from game metadata; required for C# interface/attribute compilation.
            get
            {
                return _003CjobWeight_003Ek__BackingField;
            }
        }

        public NativeArray<ActorAnimationConstraintTransformJobBone> constraintTransformJobBones
        {
            get
            {
                return _constraintTransformJobBones;
            }

            set
            {
                _constraintTransformJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverRotationJobBone> quartzDriverRotationJobBones
        {
            get
            {
                return _quartzDriverRotationJobBones;
            }

            set
            {
                _quartzDriverRotationJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverFrillJobBone> quartzDriverFrillJobBones
        {
            get
            {
                return _quartzDriverFrillJobBones;
            }

            set
            {
                _quartzDriverFrillJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverSkirtJobBone> quartzDriverSkirtJobBones
        {
            get
            {
                return _quartzDriverSkirtJobBones;
            }

            set
            {
                _quartzDriverSkirtJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHairJobBone> quartzDriverHairJobBones
        {
            get
            {
                return _quartzDriverHairJobBones;
            }

            set
            {
                _quartzDriverHairJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidHandJobBone> quartzDriverHumanoidHandJobBones
        {
            get
            {
                return _quartzDriverHumanoidHandJobBones;
            }

            set
            {
                _quartzDriverHumanoidHandJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidSleeveJobBone> quartzDriverHumanoidSleeveJobBones
        {
            get
            {
                return _quartzDriverHumanoidSleeveJobBones;
            }

            set
            {
                _quartzDriverHumanoidSleeveJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidUpLegJobBone> quartzDriverHumanoidUpLegJobBones
        {
            get
            {
                return _quartzDriverHumanoidUpLegJobBones;
            }

            set
            {
                _quartzDriverHumanoidUpLegJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverHumanoidArmJobBone> quartzDriverHumanoidArmJobBones
        {
            get
            {
                return _quartzDriverHumanoidArmJobBones;
            }

            set
            {
                _quartzDriverHumanoidArmJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverWaistJobBone> quartzDriverWaistJobBones
        {
            get
            {
                return _quartzDriverWaistJobBones;
            }

            set
            {
                _quartzDriverWaistJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverFurisodeJobBone> quartzDriverFurisodeJobBones
        {
            get
            {
                return _quartzDriverFurisodeJobBones;
            }

            set
            {
                _quartzDriverFurisodeJobBones = value;
            }
        }

        public NativeArray<ActorAnimationQuartzDriverPonchoJobBone> quartzDriverPonchoJobBones
        {
            get
            {
                return _quartzDriverPonchoJobBones;
            }

            set
            {
                _quartzDriverPonchoJobBones = value;
            }
        }

        public ActorAnimationSwingJobSkeleton swingJobSkeleton
        {
            get
            {
                return _swingJobSkeleton;
            }
        }

        public ActorAnimationFullBodyIKJobSkeleton fullBodyIKJobSkeleton
        {
            get
            {
                return _fullBodyIKJobSkeleton;
            }
        }

        public void ProcessAnimation(AnimationStream stream)
        {
            if (!stream.isValid || !quartzDriverRotationJobBones.IsCreated) return;
            ProcessFullBodyIK(stream);
            ProcessLookAtLimit(stream);
            ProcessJointLimit(stream);
            ProcessConstraint(stream);
            ProcessQuartzDriver(stream);
            ProcessSwingSkeleton(stream);
        }

        public void ProcessFullBodyIK(AnimationStream stream)
        {
            this.ProcessFullBodyIK(stream, ref _fullBodyIKJobSkeleton);
        }

        public void ProcessLookAtLimit(AnimationStream stream)
        {
            if (_lookAtLimit.IsValid(stream))
                this.ProcessLookAtLimit(stream, ref _lookAtLimit);
        }

        public void ProcessJointLimit(AnimationStream stream)
        {
            if (_jointLimit.IsValid(stream))
                this.ProcessJointLimit(stream, ref _jointLimit);
        }

        public void ProcessConstraint(AnimationStream stream)
        {
            this.ProcessConstraintParts(stream, constraintTransformJobBones);
        }

        public void ProcessQuartzDriver(AnimationStream stream)
        {
            this.ProcessQuartzDriverParts(stream, quartzDriverRotationJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverFrillJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverSkirtJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverHairJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverHumanoidHandJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverHumanoidSleeveJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverHumanoidUpLegJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverHumanoidArmJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverWaistJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverFurisodeJobBones);
            this.ProcessQuartzDriverParts(stream, quartzDriverPonchoJobBones);
        }

        public void ProcessSwingSkeleton(AnimationStream stream)
        {
            this.ProcessSwingSkeleton(stream, ref _swingJobSkeleton);
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
            ProcessRoot(stream);
        }

        public void ProcessRoot(AnimationStream stream)
        {
            this.ProcessRoot(stream, ref _rootController);
        }

        public void Create<TData>(Animator animator, ref TData rigData)
            where TData : struct, IActorAnimationRigData
        {
            CreateFullBodyIK(animator, rigData);
            CreateConstraint(animator, rigData);
            CreateQuartzDriver(animator, rigData);
            CreateSwingSkeleton(animator, rigData);
            CreateRoot(animator, rigData);
        }

        public void CreateConstraint(Animator animator, IActorAnimationRigData rigData)
        {
            constraintTransformJobBones = new NativeArray<ActorAnimationConstraintTransformJobBone>(8, Allocator.Persistent);
            for (int i = 0; i < rigData.constraintTransformBones.Count; i++)
                _constraintTransformJobBones[i] = new ActorAnimationConstraintTransformJobBone(rigData.constraintTransformBones[i], animator);
        }

        public void CreateQuartzDriver(Animator animator, IActorAnimationRigData rigData)
        {
            quartzDriverRotationJobBones = new NativeArray<ActorAnimationQuartzDriverRotationJobBone>(16, Allocator.Persistent);
            quartzDriverFrillJobBones = new NativeArray<ActorAnimationQuartzDriverFrillJobBone>(4, Allocator.Persistent);
            quartzDriverSkirtJobBones = new NativeArray<ActorAnimationQuartzDriverSkirtJobBone>(12, Allocator.Persistent);
            quartzDriverHairJobBones = new NativeArray<ActorAnimationQuartzDriverHairJobBone>(10, Allocator.Persistent);
            quartzDriverHumanoidHandJobBones = new NativeArray<ActorAnimationQuartzDriverHumanoidHandJobBone>(4, Allocator.Persistent);
            quartzDriverHumanoidSleeveJobBones = new NativeArray<ActorAnimationQuartzDriverHumanoidSleeveJobBone>(8, Allocator.Persistent);
            quartzDriverHumanoidUpLegJobBones = new NativeArray<ActorAnimationQuartzDriverHumanoidUpLegJobBone>(4, Allocator.Persistent);
            quartzDriverHumanoidArmJobBones = new NativeArray<ActorAnimationQuartzDriverHumanoidArmJobBone>(4, Allocator.Persistent);
            quartzDriverWaistJobBones = new NativeArray<ActorAnimationQuartzDriverWaistJobBone>(2, Allocator.Persistent);
            quartzDriverFurisodeJobBones = new NativeArray<ActorAnimationQuartzDriverFurisodeJobBone>(4, Allocator.Persistent);
            quartzDriverPonchoJobBones = new NativeArray<ActorAnimationQuartzDriverPonchoJobBone>(6, Allocator.Persistent);
            for (int i = 0; i < rigData.quartzDriverRotationBones.Count; i++)
            {
                var bone = rigData.quartzDriverRotationBones[i];
                _quartzDriverRotationJobBones[i] = new ActorAnimationQuartzDriverRotationJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverFrillBones.Count; i++)
            {
                var bone = rigData.quartzDriverFrillBones[i];
                _quartzDriverFrillJobBones[i] = new ActorAnimationQuartzDriverFrillJobBone(bone.setting.ConvertToUnity(), bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverSkirtBones.Count; i++)
            {
                var bone = rigData.quartzDriverSkirtBones[i];
                _quartzDriverSkirtJobBones[i] = new ActorAnimationQuartzDriverSkirtJobBone(bone.setting.ConvertToUnity(), bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverHairBones.Count; i++)
            {
                var bone = rigData.quartzDriverHairBones[i];
                _quartzDriverHairJobBones[i] = new ActorAnimationQuartzDriverHairJobBone(bone.setting.ConvertToUnity(), bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverHumanoidHandBones.Count; i++)
            {
                var bone = rigData.quartzDriverHumanoidHandBones[i];
                _quartzDriverHumanoidHandJobBones[i] = new ActorAnimationQuartzDriverHumanoidHandJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverHumanoidSleeveBones.Count; i++)
            {
                var bone = rigData.quartzDriverHumanoidSleeveBones[i];
                _quartzDriverHumanoidSleeveJobBones[i] = new ActorAnimationQuartzDriverHumanoidSleeveJobBone(bone.setting.ConvertToUnity(), bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverHumanoidUpLegBones.Count; i++)
            {
                var bone = rigData.quartzDriverHumanoidUpLegBones[i];
                _quartzDriverHumanoidUpLegJobBones[i] = new ActorAnimationQuartzDriverHumanoidUpLegJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverHumanoidArmBones.Count; i++)
            {
                var bone = rigData.quartzDriverHumanoidArmBones[i];
                _quartzDriverHumanoidArmJobBones[i] = new ActorAnimationQuartzDriverHumanoidArmJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverWaistBones.Count; i++)
            {
                var bone = rigData.quartzDriverWaistBones[i];
                _quartzDriverWaistJobBones[i] = new ActorAnimationQuartzDriverWaistJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverFurisodeBones.Count; i++)
            {
                var bone = rigData.quartzDriverFurisodeBones[i];
                _quartzDriverFurisodeJobBones[i] = new ActorAnimationQuartzDriverFurisodeJobBone(bone.setting, bone.transform, animator);
            }
            for (int i = 0; i < rigData.quartzDriverPonchoBones.Count; i++)
            {
                var bone = rigData.quartzDriverPonchoBones[i];
                _quartzDriverPonchoJobBones[i] = new ActorAnimationQuartzDriverPonchoJobBone(bone.setting, bone.transform, animator);
            }
        }

        public void CreateFullBodyIK(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateSwingSkeleton(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void CreateRoot(Animator animator, IActorAnimationRigData rigData)
        {
            if (rigData is CampusActorAnimationRigData campusData)
                _rootController = new ActorAnimationRootControllerJobLocator(campusData.root.parent, campusData.rootReference, animator);
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
            _swingJobSkeleton.manageProperty = manageProperty;
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
            DestroyIK();
            DestroyConstraint();
            DestroyQuartzDriver();
            DestroySwing();
        }

        public void ApplyActorSwingCmmnHeightCorrection(bool enabled)
        {
            _swingJobSkeleton.isCmmnHeightCorrectionNeeded = enabled;
        }

        private void DestroyIK()
        {
            if (fullBodyIKJobSkeleton.correctionColliders.IsCreated)
                fullBodyIKJobSkeleton.correctionColliders.Dispose();
        }

        private void DestroyConstraint()
        {
            if (constraintTransformJobBones.IsCreated)
                constraintTransformJobBones.Dispose();
        }

        private void DestroyQuartzDriver()
        {
            if (quartzDriverRotationJobBones.IsCreated)
                quartzDriverRotationJobBones.Dispose();
            if (quartzDriverFrillJobBones.IsCreated)
                quartzDriverFrillJobBones.Dispose();
            if (quartzDriverSkirtJobBones.IsCreated)
                quartzDriverSkirtJobBones.Dispose();
            if (quartzDriverHairJobBones.IsCreated)
                quartzDriverHairJobBones.Dispose();
            if (quartzDriverHumanoidHandJobBones.IsCreated)
                quartzDriverHumanoidHandJobBones.Dispose();
            if (quartzDriverHumanoidSleeveJobBones.IsCreated)
                quartzDriverHumanoidSleeveJobBones.Dispose();
            if (quartzDriverHumanoidUpLegJobBones.IsCreated)
                quartzDriverHumanoidUpLegJobBones.Dispose();
            if (quartzDriverHumanoidArmJobBones.IsCreated)
                quartzDriverHumanoidArmJobBones.Dispose();
            if (quartzDriverWaistJobBones.IsCreated)
                quartzDriverWaistJobBones.Dispose();
            if (quartzDriverFurisodeJobBones.IsCreated)
                quartzDriverFurisodeJobBones.Dispose();
            if (quartzDriverPonchoJobBones.IsCreated)
                quartzDriverPonchoJobBones.Dispose();
        }

        private void DestroySwing()
        {
            if (swingJobSkeleton.dynamicBones.IsCreated) swingJobSkeleton.dynamicBones.Dispose();
            if (swingJobSkeleton.staticBones.IsCreated) swingJobSkeleton.staticBones.Dispose();
            if (swingJobSkeleton.breastBones.IsCreated) swingJobSkeleton.breastBones.Dispose();
            swingJobSkeleton.breastBoneCurve.Dispose();
            if (swingJobSkeleton.chainBones.IsCreated) swingJobSkeleton.chainBones.Dispose();
            if (swingJobSkeleton.instanceIDToDynamicBoneIndex.IsCreated) swingJobSkeleton.instanceIDToDynamicBoneIndex.Dispose();
        }
    }
}
