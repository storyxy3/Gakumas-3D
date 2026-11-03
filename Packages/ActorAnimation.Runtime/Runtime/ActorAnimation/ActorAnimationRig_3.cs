namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public class ActorAnimationRig<TJob, TData, TBinder> : RigConstraint<TJob, TData, TBinder> where TJob : struct, IActorAnimationJob where TData : struct, IAnimationJobData, IActorAnimationRigData where TBinder : ActorAnimationJobBinder<TJob, TData>, new()
    {
        public delegate void OnAddRigCallback(ActorAnimationRig<TJob, TData, TBinder> rig);
        public delegate void OnRemoveRigCallback(ActorAnimationRig<TJob, TData, TBinder> rig);
        public static OnAddRigCallback onAddRig;
        public static OnRemoveRigCallback onRemoveRig;
        public ActorAnimationManageData manageData;
        protected IAnimationJob _job;
        protected Animator _animator;
        [CompilerGenerated]
        private bool _003CisInitialized_003Ek__BackingField;
        public IEnumerable<ActorAnimationConstraintTransformBone> constraintTransformBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorSwingDynamicBone> swingDynamicBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorSwingStaticBone> swingStaticBones
        {
            get
            {
                return null;
            }
        }

        public IEnumerable<ActorSwingBreastBone> swingBreastBones
        {
            get
            {
                return null;
            }
        }

        public IAnimationJob job
        {
            get
            {
                return null;
            }
        }

        public Animator animator
        {
            get
            {
                return null;
            }
        }

        public bool isInitialized
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        public void UpdateRig()
        {
        }

        public void Clear()
        {
        }

        public bool Initialize(Animator animator)
        {
            return default(bool);
        }

        public void Destroy()
        {
        }

        public void UpdateManageProperty(Animator animator)
        {
        }

        public void UpdateConstraints()
        {
        }

        public void UpdateConstraintSource(Animator animator)
        {
        }

        public void UpdateSwing()
        {
        }

        public void SetRootTransform(Transform root)
        {
        }

        public virtual void SetInactiveBones(IEnumerable<int> inactiveBones)
        {
        }

        public void RegisterBones(ActorAnimationInitializeData initialData)
        {
        }

        public new void Reset()
        {
        }

        public virtual void ResetDynamicBone()
        {
        }

        public virtual void ResetBreastBone()
        {
        }

        public virtual void ResetDynamicSkin()
        {
        }

        public virtual void ResetTime()
        {
        }

        protected bool CheckChain(ActorSwingChain chain)
        {
            return default(bool);
        }

        public ActorAnimationRig()
        {
        }
    }
}
