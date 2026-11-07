namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [BurstCompile]
    public struct ActorAnimationJob : IActorAnimationJob, IWeightedAnimationJob, IAnimationJob, IActorAnimation, IActorAnimationSwingSkeleton
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

        public void ProcessAnimation(AnimationStream stream)
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

        public void UpdateConstraintSource<TData>(ref TData rigData, Animator animator)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void CreateSwingSkeleton(Animator animator, IActorAnimationRigData rigData)
        {
        }

        public void UpdateManageProperty(ActorAnimationManageProperty manageProperty)
        {
        }

        public void UpdateRigData<TData>(ref TData rigData)
            where TData : struct, IActorAnimationRigData
        {
        }

        public void ResetTime()
        {
        }

        public void Destroy()
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
