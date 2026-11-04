namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::Unity.Collections.LowLevel.Unsafe;
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
            if (!(rigData is CampusActorAnimationRigData campusData)) return;
            _fullBodyIKJobSkeleton = default;
            foreach (var effector in campusData.effectors)
            {
                if (effector is IKGoalEffector goal)
                {
                    switch (goal.goal)
                    {
                        case AvatarIKGoal.LeftFoot: _fullBodyIKJobSkeleton.leftFootEffector = new ActorAnimationIKGoalEffector(animator, goal.transform, AvatarIKGoal.LeftFoot, goal.HandleType); break;
                        case AvatarIKGoal.RightFoot: _fullBodyIKJobSkeleton.rightFootEffector = new ActorAnimationIKGoalEffector(animator, goal.transform, AvatarIKGoal.RightFoot, goal.HandleType); break;
                        case AvatarIKGoal.LeftHand: _fullBodyIKJobSkeleton.leftHandEffector = new ActorAnimationIKGoalEffector(animator, goal.transform, AvatarIKGoal.LeftHand, goal.HandleType); break;
                        case AvatarIKGoal.RightHand: _fullBodyIKJobSkeleton.rightHandEffector = new ActorAnimationIKGoalEffector(animator, goal.transform, AvatarIKGoal.RightHand, goal.HandleType); break;
                    }
                }
                else if (effector is IKHintEffector hint)
                {
                    switch (hint.hint)
                    {
                        case AvatarIKHint.LeftKnee: _fullBodyIKJobSkeleton.leftKneeHintEffector = new ActorAnimationIKHintEffector(animator, hint.transform, AvatarIKHint.LeftKnee, hint.HandleType); break;
                        case AvatarIKHint.RightKnee: _fullBodyIKJobSkeleton.rightKneeHintEffector = new ActorAnimationIKHintEffector(animator, hint.transform, AvatarIKHint.RightKnee, hint.HandleType); break;
                        case AvatarIKHint.LeftElbow: _fullBodyIKJobSkeleton.leftElbowHintEffector = new ActorAnimationIKHintEffector(animator, hint.transform, AvatarIKHint.LeftElbow, hint.HandleType); break;
                        case AvatarIKHint.RightElbow: _fullBodyIKJobSkeleton.rightElbowHintEffector = new ActorAnimationIKHintEffector(animator, hint.transform, AvatarIKHint.RightElbow, hint.HandleType); break;
                    }
                }
                else if (effector is IKBodyEffector body)
                    _fullBodyIKJobSkeleton.bodyEffector = new ActorAnimationIKBodyEffector(animator, body.transform, body.HandleType);
                else if (effector is LookAtEffector lookAt)
                    _fullBodyIKJobSkeleton.lookAtEffector = new CampusActorAnimationIKLookAtEffector(animator, lookAt.transform).ToActorAnimation();
            }
            _fullBodyIKJobSkeleton.customLookAtEffector = new ActorAnimationIKCustomLookAtEffector(animator);
            _fullBodyIKJobSkeleton.leftArmLimb = new ActorAnimationFullBodyIKLimbPart(animator, HumanBodyBones.LeftUpperArm, HumanBodyBones.LeftLowerArm, HumanBodyBones.LeftHand);
            _fullBodyIKJobSkeleton.rightArmLimb = new ActorAnimationFullBodyIKLimbPart(animator, HumanBodyBones.RightUpperArm, HumanBodyBones.RightLowerArm, HumanBodyBones.RightHand);
            _fullBodyIKJobSkeleton.leftLegLimb = new ActorAnimationFullBodyIKLimbPart(animator, HumanBodyBones.LeftUpperLeg, HumanBodyBones.LeftLowerLeg, HumanBodyBones.LeftFoot);
            _fullBodyIKJobSkeleton.rightLegLimb = new ActorAnimationFullBodyIKLimbPart(animator, HumanBodyBones.RightUpperLeg, HumanBodyBones.RightLowerLeg, HumanBodyBones.RightFoot);
            _fullBodyIKJobSkeleton.move = new ActorAnimationFullBodyIKMovePart(animator, campusData.move, campusData.hips.parent, campusData.hips);
            _fullBodyIKJobSkeleton.pull = new CampusActorAnimationFullBodyIKPullPart(animator, campusData.root.parent).ToActorAnimation();
            _fullBodyIKJobSkeleton.correctionGoalRightHand = new ActorAnimationIKCorrectionJobGoal(animator, campusData.rightHandGoal);
            _fullBodyIKJobSkeleton.correctionGoalLeftHand = new ActorAnimationIKCorrectionJobGoal(animator, campusData.leftHandGoal);
            _fullBodyIKJobSkeleton.correctionColliders = new NativeArray<ActorAnimationIKCorrectionJobCollider>(8, Allocator.Persistent);
            for (int i = 0; i < campusData.ikCorrectionColliders.Count; i++)
                _fullBodyIKJobSkeleton.correctionColliders[i] = new ActorAnimationIKCorrectionJobCollider(animator, campusData.ikCorrectionColliders[i]);
            _fullBodyIKJobSkeleton.nodAdditiveJob = new ActorAnimationNodAdditiveJob(
                new MuscleHandle((HeadDof)0),
                new MuscleHandle((HeadDof)1),
                new MuscleHandle((HeadDof)2),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveNeckFrontBackWeight"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveNeckLeftRightWeight"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveNeckRollLeftRightWeight"),
                new MuscleHandle((HeadDof)3),
                new MuscleHandle((HeadDof)4),
                new MuscleHandle((HeadDof)5),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveHeadFrontBackWeight"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveHeadLeftRightWeight"),
                animator.BindSceneProperty(animator.transform, typeof(CampusActorAnimation), "nodAdditiveHeadRollLeftRightWeight"));
            _fullBodyIKJobSkeleton.writeBack = new ActorAnimationFullBodyIKWriteBack(
                animator,
                ReadOnlyTransformHandle.Bind(animator, campusData.head),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalPositionX"),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalPositionY"),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalPositionZ"),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalRotationX"),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalRotationY"),
                animator.BindStreamProperty(animator.transform, typeof(CampusActorAnimation), "fullBodyIkHeadOriginalRotationZ"));
        }

        public void CreateSwingSkeleton(Animator animator, IActorAnimationRigData rigData)
        {
            _swingJobSkeleton = new ActorAnimationSwingJobSkeleton
            {
                dynamicBones = new NativeList<ActorSwingJobDynamicBone>(64, Allocator.Persistent),
                staticBones = new NativeList<ActorSwingJobStaticBone>(24, Allocator.Persistent),
                breastBones = new NativeList<ActorSwingJobBreastBone>(1, Allocator.Persistent),
                chainBones = new NativeList<ActorSwingJobChainBone>(64, Allocator.Persistent),
                instanceIDToDynamicBoneIndex = new NativeHashMap<int, int>(64, Allocator.Persistent)
            };
            if (rigData.root != null)
                _swingJobSkeleton.rootHandle = ReadOnlyTransformHandle.Bind(animator, rigData.root);
            if (rigData.hips != null)
            {
                if (rigData is CampusActorAnimationRigData campusData)
                {
                    _swingJobSkeleton.hipsHandle = ReadOnlyTransformHandle.Bind(animator, campusData.move);
                    _swingJobSkeleton.heightCorrectionBoneHandle = ReadOnlyTransformHandle.Bind(animator, campusData.hips);
                }
                else
                {
                    _swingJobSkeleton.hipsHandle = ReadOnlyTransformHandle.Bind(animator, rigData.hips);
                    _swingJobSkeleton.heightCorrectionBoneHandle = ReadOnlyTransformHandle.Bind(animator, rigData.hips);
                }
            }
            rigData.Sort();
            int index = 0;
            foreach (var bone in rigData.swingDynamicBones)
                _swingJobSkeleton.instanceIDToDynamicBoneIndex.Add(bone.transform.GetInstanceID(), index++);
            foreach (var bone in rigData.swingDynamicBones)
            {
                var transform = bone.transform;
                var initial = bone.initialTransform;
                var self = new ActorSwingAffineTransform(initial.position, initial.rotation);
                var parent = transform.parent;
                int parentIndex = -1;
                if (parent != null && !_swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(parent.GetInstanceID(), out parentIndex)) parentIndex = -1;
                int childIndex = -1;
                if (transform.childCount > 0 && !_swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(transform.GetChild(0).GetInstanceID(), out childIndex)) childIndex = -1;
                int referenceIndex = -1;
                if (bone.referenceLimitInfo.bone != null && swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(bone.referenceLimitInfo.bone.transform.GetInstanceID(), out referenceIndex))
                {
                    swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(transform.GetInstanceID(), out int currentIndex);
                    if (currentIndex <= referenceIndex) referenceIndex = -1;
                }
                _swingJobSkeleton.dynamicBones.Add(new ActorSwingJobDynamicBone
                {
                    active = true,
                    resetType = bone.resetType,
                    dynamicType = bone.dynamicType,
                    collider = ActorSwingColliderUtility.ConvertJobCollider(bone),
                    depth = bone.hierarchyDepth,
                    parentIndex = parentIndex,
                    childIndex = childIndex,
                    driven = ReadWriteTransformHandle.Bind(animator, transform),
                    parent = parentIndex == -1 ? default : ReadOnlyTransformHandle.Bind(animator, parent),
                    boneAxis = math.length(initial.localPosition) > 0.00001f ? math.normalize(initial.localPosition) : new float3(1f, 0f, 0f),
                    boneLength = math.length(initial.localPosition),
                    localTx = new ActorSwingAffineTransform(initial.localPosition, initial.localRotation),
                    selfTx = self,
                    modelingLocalTx = new ActorSwingAffineTransform(bone.modelingTransform.localPosition, bone.modelingTransform.localRotation),
                    damping = bone.damping,
                    stiffness = bone.stiffness,
                    spring = bone.spring,
                    pendulum = bone.pendulum,
                    pendulumRange = bone.pendulumRange,
                    mass = bone.mass,
                    axisAddXToY = bone.axisAddXToY,
                    axisAddXToZ = bone.axisAddXToZ,
                    wind = bone.wind,
                    useWindGlobalForce = bone.useWindGlobalForce,
                    limit = new ActorSwingJobLimitInfo(bone.limitInfo),
                    referenceLimit = new ActorSwingJobReferenceLimitInfo(bone.referenceLimitInfo, bone.dynamicType == DynamicType.Swing ? referenceIndex : -1),
                    rootWeight = bone.rootWeight,
                    seatDynamicCorrection = bone.seatDynamicCorrection
                });
            }
            foreach (var bone in rigData.swingStaticBones)
            {
                var transform = bone.transform;
                var parent = transform.parent != null ? ReadOnlyTransformHandle.Bind(animator, transform.parent) : default;
                _swingJobSkeleton.staticBones.Add(new ActorSwingJobStaticBone
                {
                    collider = ActorSwingColliderUtility.ConvertJobCollider(bone),
                    driven = ReadOnlyTransformHandle.Bind(animator, transform),
                    parent = parent
                });
            }
            foreach (var bone in rigData.swingBreastBones)
            {
                _swingJobSkeleton.breastBones.Add(new ActorSwingJobBreastBone
                {
                    driven = ReadOnlyTransformHandle.Bind(animator, bone.transform),
                    leftBreastSetting = new ActorSwingJobBreastBoneSetting(
                        ReadOnlyTransformHandle.Bind(animator, bone.leftLowerArm), ReadWriteTransformHandle.Bind(animator, bone.leftBreast),
                        new ActorSwingAffineTransform(bone.initialLeftTransform.localPosition, bone.initialLeftTransform.localRotation),
                        new ActorSwingAffineTransform(bone.initialLeftEndTransform.localPosition, bone.initialLeftEndTransform.localRotation),
                        new ActorSwingAffineTransform(bone.initialLeftEndTransform.position, bone.initialLeftEndTransform.rotation),
                        new ActorSwingAffineTransform(bone.modelingLeftTransform.localPosition, bone.modelingLeftTransform.localRotation)),
                    rightBreastSetting = new ActorSwingJobBreastBoneSetting(
                        ReadOnlyTransformHandle.Bind(animator, bone.rightLowerArm), ReadWriteTransformHandle.Bind(animator, bone.rightBreast),
                        new ActorSwingAffineTransform(bone.initialRightTransform.localPosition, bone.initialRightTransform.localRotation),
                        new ActorSwingAffineTransform(bone.initialRightEndTransform.localPosition, bone.initialRightEndTransform.localRotation),
                        new ActorSwingAffineTransform(bone.initialRightEndTransform.position, bone.initialRightEndTransform.rotation),
                        new ActorSwingAffineTransform(bone.modelingRightTransform.localPosition, bone.modelingRightTransform.localRotation)),
                    damping = bone.damping,
                    stiffness = bone.stiffness,
                    spring = bone.spring,
                    pendulum = bone.pendulum,
                    pendulumRange = bone.pendulumRange,
                    average = bone.average,
                    useArmCorrection = bone.useArmCorrection,
                    limit = new ActorSwingJobLimitInfo(bone.limitInfo),
                    rootWeight = bone.rootWeight
                });
                var up = CurveConversion.CurveToKeyframes(bone.upCurve, Allocator.Persistent);
                var side = CurveConversion.CurveToKeyframes(bone.sideCurve, Allocator.Persistent);
                _swingJobSkeleton.breastBoneCurve = new ActorSwingJobBreastBoneCurve
                {
                    upCurveData = new AnimationCurveData { length = up.Length },
                    sideCurveData = new AnimationCurveData { length = side.Length },
                    upKeyFrames = up,
                    sideKeyFrames = side
                };
            }
            foreach (var layer in rigData.swingChainLayers)
            {
                if (!layer.active) continue;
                float loopLength = ActorAnimationSwingSkeletonCalcUtility.GetChainLoopLength(layer.bones, layer.around);
                for (int i = 0; i < layer.bones.Count; i++)
                {
                    int next = i + 1;
                    if (i == layer.bones.Count - 1)
                    {
                        if (!layer.around) break;
                        next = 0;
                    }
                    var bone = layer.bones[i];
                    var subBone = layer.bones[next];
                    Vector3 scale = bone.transform.lossyScale;
                    float minimumScale = math.min(scale.x, math.min(scale.y, scale.z));
                    var collider = new ActorSwingJobCollider
                    {
                        active = 1,
                        type = ActorSwingColliderType.Line,
                        collisionMask = bone.dynamicCollider.collisionMask | subBone.dynamicCollider.collisionMask,
                        float_A = minimumScale * layer.radius,
                        float_B = minimumScale * layer.radius,
                        scale = minimumScale
                    };
                    ActorSwingColliderUtility.UpdateCollider(ref collider, bone.initialTransform.position, subBone.initialTransform.position, quaternion.identity);
                    int offset = 0;
                    if (_swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(bone.transform.GetInstanceID(), out int boneIndex)
                        && _swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(subBone.transform.GetInstanceID(), out int subIndex))
                        offset = subIndex - boneIndex;
                    _swingJobSkeleton.chainBones.Add(new ActorSwingJobChainBone
                    {
                        collider = collider,
                        dynamicBoneIndex = boneIndex,
                        chainOffsetIndex = offset,
                        depth = layer.hierarchyDepth,
                        smoothing = layer.smoothing,
                        around = layer.around,
                        initialLoopLength = loopLength
                    });
                }
            }
            _swingJobSkeleton.seatedDynamicCorrection = new ActorSwingJobSeatDynamicCorrection
            {
                leftUpLeg = ReadOnlyTransformHandle.Bind(animator, rigData.leftUpLeg),
                leftLeg = ReadOnlyTransformHandle.Bind(animator, rigData.leftLeg),
                leftFoot = ReadOnlyTransformHandle.Bind(animator, rigData.leftFoot),
                rightUpLeg = ReadOnlyTransformHandle.Bind(animator, rigData.rightUpLeg),
                rightLeg = ReadOnlyTransformHandle.Bind(animator, rigData.rightLeg),
                rightFoot = ReadOnlyTransformHandle.Bind(animator, rigData.rightFoot)
            };
        }

        public void CreateRoot(Animator animator, IActorAnimationRigData rigData)
        {
            if (rigData is CampusActorAnimationRigData campusData)
                _rootController = new ActorAnimationRootControllerJobLocator(campusData.root.parent, campusData.rootReference, animator);
        }

        public unsafe void UpdateConstraintSource<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData
        {
            var jobBone = (ActorAnimationConstraintTransformJobBone*)constraintTransformJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.constraintTransformBones)
            {
                if (bone.isDirty)
                {
                    jobBone->UpdateSource(bone, animator);
                    bone.ResetDirty();
                }
                jobBone++;
            }
        }

        public unsafe void UpdateIKCorrectionColliderProperty<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData
        {
            if (rigData is CampusActorAnimationRigData campusData)
            {
                var jobCollider = (ActorAnimationIKCorrectionJobCollider*)fullBodyIKJobSkeleton.correctionColliders.GetUnsafeReadOnlyPtr();
                foreach (var collider in campusData.ikCorrectionColliders)
                {
                    if (collider.isDirty)
                    {
                        jobCollider->UpdateProperty(collider, animator);
                        collider.ResetDirty();
                    }
                    jobCollider++;
                }
            }
        }

        public void UpdateManageProperty(ActorAnimationManageProperty manageProperty)
        {
            _swingJobSkeleton.manageProperty = manageProperty;
        }

        public unsafe void UpdateRigData<TData>(ref TData rigData)
            where TData : struct, IActorAnimationRigData
        {
            var constraintJob = (ActorAnimationConstraintTransformJobBone*)constraintTransformJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.constraintTransformBones)
            {
                if (bone.isDirty)
                {
                    constraintJob->Update(bone);
                    bone.ResetDirty();
                }
                constraintJob++;
            }
            var rotationJob = (ActorAnimationQuartzDriverRotationJobBone*)quartzDriverRotationJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverRotationBones)
            {
                if (bone.isDirty)
                {
                    rotationJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                rotationJob++;
            }
            var frillJob = (ActorAnimationQuartzDriverFrillJobBone*)quartzDriverFrillJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverFrillBones)
            {
                if (bone.isDirty)
                {
                    frillJob->Update(bone.setting.ConvertToUnity());
                    bone.ResetDirty();
                }
                frillJob++;
            }
            var skirtJob = (ActorAnimationQuartzDriverSkirtJobBone*)quartzDriverSkirtJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverSkirtBones)
            {
                if (bone.isDirty)
                {
                    skirtJob->Update(bone.setting.ConvertToUnity());
                    bone.ResetDirty();
                }
                skirtJob++;
            }
            var hairJob = (ActorAnimationQuartzDriverHairJobBone*)quartzDriverHairJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverHairBones)
            {
                if (bone.isDirty)
                {
                    hairJob->Update(bone.setting.ConvertToUnity());
                    bone.ResetDirty();
                }
                hairJob++;
            }
            var humanoidHandJob = (ActorAnimationQuartzDriverHumanoidHandJobBone*)quartzDriverHumanoidHandJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverHumanoidHandBones)
            {
                if (bone.isDirty)
                {
                    humanoidHandJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                humanoidHandJob++;
            }
            var humanoidSleeveJob = (ActorAnimationQuartzDriverHumanoidSleeveJobBone*)quartzDriverHumanoidSleeveJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverHumanoidSleeveBones)
            {
                if (bone.isDirty)
                {
                    humanoidSleeveJob->Update(bone.setting.ConvertToUnity());
                    bone.ResetDirty();
                }
                humanoidSleeveJob++;
            }
            var humanoidUpLegJob = (ActorAnimationQuartzDriverHumanoidUpLegJobBone*)quartzDriverHumanoidUpLegJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverHumanoidUpLegBones)
            {
                if (bone.isDirty)
                {
                    humanoidUpLegJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                humanoidUpLegJob++;
            }
            var humanoidArmJob = (ActorAnimationQuartzDriverHumanoidArmJobBone*)quartzDriverHumanoidArmJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverHumanoidArmBones)
            {
                if (bone.isDirty)
                {
                    humanoidArmJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                humanoidArmJob++;
            }
            var waistJob = (ActorAnimationQuartzDriverWaistJobBone*)quartzDriverWaistJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverWaistBones)
            {
                if (bone.isDirty)
                {
                    waistJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                waistJob++;
            }
            var furisodeJob = (ActorAnimationQuartzDriverFurisodeJobBone*)quartzDriverFurisodeJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverFurisodeBones)
            {
                if (bone.isDirty)
                {
                    furisodeJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                furisodeJob++;
            }
            var ponchoJob = (ActorAnimationQuartzDriverPonchoJobBone*)quartzDriverPonchoJobBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.quartzDriverPonchoBones)
            {
                if (bone.isDirty)
                {
                    ponchoJob->Update(bone.setting);
                    bone.ResetDirty();
                }
                ponchoJob++;
            }
            var breastJob = (ActorSwingJobBreastBone*)swingJobSkeleton.breastBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.swingBreastBones)
            {
                if (bone.isDirty)
                {
                    breastJob->damping = bone.damping;
                    breastJob->stiffness = bone.stiffness;
                    breastJob->spring = bone.spring;
                    breastJob->pendulum = bone.pendulum;
                    breastJob->pendulumRange = bone.pendulumRange;
                    breastJob->average = bone.average;
                    breastJob->useArmCorrection = bone.useArmCorrection;
                    breastJob->limit = new ActorSwingJobLimitInfo(bone.limitInfo);
                    breastJob->rootWeight = bone.rootWeight;
                    bone.ResetDirty();
                }
                breastJob++;
            }
            var dynamicJob = (ActorSwingJobDynamicBone*)swingJobSkeleton.dynamicBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.swingDynamicBones)
            {
                if (bone.isDirty)
                {
                    int referenceIndex = -1;
                    if (bone.referenceLimitInfo.bone != null && swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(bone.referenceLimitInfo.bone.transform.GetInstanceID(), out referenceIndex))
                    {
                        swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(bone.transform.GetInstanceID(), out int index);
                        if (index <= referenceIndex) referenceIndex = -1;
                    }
                    dynamicJob->damping = bone.damping;
                    dynamicJob->stiffness = bone.stiffness;
                    dynamicJob->spring = bone.spring;
                    dynamicJob->pendulum = bone.pendulum;
                    dynamicJob->pendulumRange = bone.pendulumRange;
                    dynamicJob->mass = bone.mass;
                    dynamicJob->axisAddXToY = bone.axisAddXToY;
                    dynamicJob->axisAddXToZ = bone.axisAddXToZ;
                    dynamicJob->wind = bone.wind;
                    dynamicJob->collision = default;
                    dynamicJob->limit = new ActorSwingJobLimitInfo(bone.limitInfo);
                    dynamicJob->referenceLimit = new ActorSwingJobReferenceLimitInfo(bone.referenceLimitInfo, bone.dynamicType == DynamicType.Swing ? referenceIndex : -1);
                    dynamicJob->rootWeight = bone.rootWeight;
                    dynamicJob->seatDynamicCorrection = bone.seatDynamicCorrection;
                    dynamicJob->collider = ActorSwingColliderUtility.ConvertJobCollider(bone);
                    bone.ResetDirty();
                }
                dynamicJob++;
            }
            var staticJob = (ActorSwingJobStaticBone*)swingJobSkeleton.staticBones.GetUnsafeReadOnlyPtr();
            foreach (var bone in rigData.swingStaticBones)
            {
                if (bone.isDirty)
                {
                    staticJob->collider = ActorSwingColliderUtility.ConvertJobCollider(bone);
                    bone.ResetDirty();
                }
                staticJob++;
            }
            var chainJob = (ActorSwingJobChainBone*)swingJobSkeleton.chainBones.GetUnsafeReadOnlyPtr();
            foreach (var layer in rigData.swingChainLayers)
            {
                if (layer.active)
                {
                    for (int i = 0; i < layer.bones.Count; i++)
                    {
                        if (i == layer.bones.Count - 1 && !layer.around) break;
                        if (layer.isDirty) chainJob->smoothing = layer.smoothing;
                        chainJob++;
                    }
                    layer.ResetDirty();
                }
            }
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
