namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationRigData : IActorAnimationRigData, IAnimationJobData
    {
        [SerializeField]
        private List<ActorAnimationConstraintTransformBone> _constraintTransformBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverRotationBone> _quartzDriverRotationBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverFrillBone> _quartzDriverFrillBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverSkirtBone> _quartzDriverSkirtBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverHairBone> _quartzDriverHairBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverHumanoidHandBone> _quartzDriverHumanoidHandBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverHumanoidSleeveBone> _quartzDriverHumanoidSleeveBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverHumanoidUpLegBone> _quartzDriverHumanoidUpLegBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverHumanoidArmBone> _quartzDriverHumanoidArmBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverWaistBone> _quartzDriverWaistBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverFurisodeBone> _quartzDriverFurisodeBones;
        [SerializeField]
        private List<ActorAnimationQuartzDriverPonchoBone> _quartzDriverPonchoBones;
        [SerializeField]
        private List<ActorSwingDynamicBone> _swingDynamicBones;
        [SerializeField]
        private List<ActorSwingStaticBone> _swingStaticBones;
        [SerializeField]
        private List<ActorSwingBreastBone> _swingBreastBones;
        [SerializeField]
        private List<ChainLayerInfo> _swingChainLayers;
        [SerializeField]
        private Transform _root;
        [SerializeField]
        private Transform _hips;
        [SerializeField]
        private Transform _leftUpLeg;
        [SerializeField]
        private Transform _leftLeg;
        [SerializeField]
        private Transform _leftFoot;
        [SerializeField]
        private Transform _rightUpLeg;
        [SerializeField]
        private Transform _rightLeg;
        [SerializeField]
        private Transform _rightFoot;
        public List<ActorAnimationConstraintTransformBone> constraintTransformBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorSwingDynamicBone> swingDynamicBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorSwingStaticBone> swingStaticBones
        {
            get
            {
                return null;
            }
        }

        public List<ActorSwingBreastBone> swingBreastBones
        {
            get
            {
                return null;
            }
        }

        public List<ChainLayerInfo> swingChainLayers
        {
            get
            {
                return null;
            }
        }

        public Transform root
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Transform hips
        {
            get
            {
                return null;
            }
        }

        public Transform leftUpLeg
        {
            get
            {
                return null;
            }
        }

        public Transform leftLeg
        {
            get
            {
                return null;
            }
        }

        public Transform leftFoot
        {
            get
            {
                return null;
            }
        }

        public Transform rightUpLeg
        {
            get
            {
                return null;
            }
        }

        public Transform rightLeg
        {
            get
            {
                return null;
            }
        }

        public Transform rightFoot
        {
            get
            {
                return null;
            }
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void SetDefaultValues()
        {
        }

        public void Clear()
        {
        }

        public void Sort()
        {
        }

        private void SortQuartzDriverBone()
        {
        }

        private void SortSwingBone()
        {
        }

        private void SortChainLayers(List<ActorSwingDynamicBone> secondaryDynamicList)
        {
        }

        private void SortDynamicBone(out List<ActorSwingDynamicBone> secondaryDynamicLayer)
        {
            throw null;
        }
    }
}
