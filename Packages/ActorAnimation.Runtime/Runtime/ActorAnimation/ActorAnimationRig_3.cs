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
                return data.constraintTransformBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones
        {
            get
            {
                return data.quartzDriverRotationBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones
        {
            get
            {
                return data.quartzDriverFrillBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones
        {
            get
            {
                return data.quartzDriverSkirtBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones
        {
            get
            {
                return data.quartzDriverHairBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones
        {
            get
            {
                return data.quartzDriverHumanoidHandBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones
        {
            get
            {
                return data.quartzDriverHumanoidSleeveBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones
        {
            get
            {
                return data.quartzDriverHumanoidUpLegBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones
        {
            get
            {
                return data.quartzDriverHumanoidArmBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones
        {
            get
            {
                return data.quartzDriverWaistBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones
        {
            get
            {
                return data.quartzDriverFurisodeBones;
            }
        }

        public IEnumerable<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones
        {
            get
            {
                return data.quartzDriverPonchoBones;
            }
        }

        public IEnumerable<ActorSwingDynamicBone> swingDynamicBones
        {
            get
            {
                return data.swingDynamicBones;
            }
        }

        public IEnumerable<ActorSwingStaticBone> swingStaticBones
        {
            get
            {
                return data.swingStaticBones;
            }
        }

        public IEnumerable<ActorSwingBreastBone> swingBreastBones
        {
            get
            {
                return data.swingBreastBones;
            }
        }

        public IAnimationJob job
        {
            get
            {
                return isInitialized ? _job : null;
            }
        }

        public Animator animator
        {
            get
            {
                return isInitialized ? _animator : null;
            }
        }

        public bool isInitialized
        {
            [CompilerGenerated]
            get
            {
                return _003CisInitialized_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003CisInitialized_003Ek__BackingField = value;
            }
        }

        private void OnEnable()
        {
            onAddRig?.Invoke(this);
        }

        private void OnDisable()
        {
            onRemoveRig?.Invoke(this);
        }

        public void UpdateRig()
        {
            UpdateManageProperty(animator);
            if (isInitialized) UpdateJob(_job);
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Initialize(Animator animator)
        {
            if (!isInitialized)
            {
                _animator = animator;
                _job = CreateJob(animator);
                UpdateManageProperty(animator);
                isInitialized = true;
            }
            return true;
        }

        public void Destroy()
        {
            if (isInitialized)
            {
                if (_job != null) DestroyJob(_job);
                _job = null;
                isInitialized = false;
            }
        }

        public void UpdateManageProperty(Animator animator)
        {
            if (manageData == null && animator != null)
            {
                var cameras = Camera.allCameras;
                for (int i = 0; i < Camera.allCamerasCount; i++)
                {
                    if (cameras[i].TryGetComponent(out manageData) && _job is IActorAnimationJob animationJob)
                    {
                        animationJob.UpdateManageProperty(ActorAnimationManageProperty.Bind(animator, manageData));
                        return;
                    }
                }
            }
        }

        public void UpdateConstraints()
        {
            if (isInitialized) UpdateJob(_job);
        }

        public void UpdateConstraintSource(Animator animator)
        {
            ( _job as IActorAnimationJob).UpdateConstraintSource(ref data, animator);
        }

        public void UpdateSwing()
        {
            if (isInitialized) UpdateJob(_job);
        }

        public void SetRootTransform(Transform root)
        {
            data.root = root;
        }

        public virtual void SetInactiveBones(IEnumerable<int> inactiveBones)
        {
        }

        public void RegisterBones(ActorAnimationInitializeData initialData)
        {
        }

        public new void Reset()
        {
            ResetDynamicBone();
            ResetBreastBone();
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
            if (chain.chains == null || chain.chains.layers == null) return false;
            for (int layerIndex = 0; layerIndex < chain.chains.layers.Count; layerIndex++)
            {
                var bones = chain.chains.layers[layerIndex].bones;
                for (int boneIndex = 0; boneIndex < bones.Count; boneIndex++)
                {
                    if (bones[boneIndex] == null)
                    {
                        Debug.LogError(string.Format("ChainにDynamicBoneが指定されていない階層があります ({0} Layer={1} Index={2}", chain.name, layerIndex, boneIndex));
                        return false;
                    }
                }
            }
            return true;
        }

        public ActorAnimationRig()
        {
        }
    }
}
