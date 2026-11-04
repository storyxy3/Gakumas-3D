namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;
    using global::VL.IK;

    [Serializable]
    public struct CampusActorAnimationRigData : IActorAnimationRigData, IAnimationJobData
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass133_0
        {
            public List<ActorSwingDynamicBone> secondaryDynamicList;
            public Predicate<ActorSwingDynamicBone> _003C_003E9__0;
            public _003C_003Ec__DisplayClass133_0()
            {
            }

            internal bool _003CSortChainLayers_003Eb__0(ActorSwingDynamicBone x)
            {
                return default(bool);
            }
        }

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
        private List<EffectorBase> _effectors;
        [SerializeField]
        private List<ActorAnimationIKCorrectionCollider> _ikCorrectionColliders;
        [SerializeField]
        private ActorAnimationIKCorrectionGoal _rightHandGoal;
        [SerializeField]
        private ActorAnimationIKCorrectionGoal _leftHandGoal;
        [SerializeField]
        private Transform _root;
        [SerializeField]
        private Transform _rootReference;
        [SerializeField]
        private Transform _move;
        [SerializeField]
        private Transform _reference;
        [SerializeField]
        private Transform _hips;
        [SerializeField]
        private Transform _head;
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
                return _constraintTransformBones;
            }
        }

        public List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones
        {
            get
            {
                return _quartzDriverRotationBones;
            }
        }

        public List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones
        {
            get
            {
                return _quartzDriverFrillBones;
            }
        }

        public List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones
        {
            get
            {
                return _quartzDriverSkirtBones;
            }
        }

        public List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones
        {
            get
            {
                return _quartzDriverHairBones;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones
        {
            get
            {
                return _quartzDriverHumanoidHandBones;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones
        {
            get
            {
                return _quartzDriverHumanoidSleeveBones;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones
        {
            get
            {
                return _quartzDriverHumanoidUpLegBones;
            }
        }

        public List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones
        {
            get
            {
                return _quartzDriverHumanoidArmBones;
            }
        }

        public List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones
        {
            get
            {
                return _quartzDriverWaistBones;
            }
        }

        public List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones
        {
            get
            {
                return _quartzDriverFurisodeBones;
            }
        }

        public List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones
        {
            get
            {
                return _quartzDriverPonchoBones;
            }
        }

        public List<ActorSwingDynamicBone> swingDynamicBones
        {
            get
            {
                return _swingDynamicBones;
            }
        }

        public List<ActorSwingStaticBone> swingStaticBones
        {
            get
            {
                return _swingStaticBones;
            }
        }

        public List<ActorSwingBreastBone> swingBreastBones
        {
            get
            {
                return _swingBreastBones;
            }
        }

        public List<ChainLayerInfo> swingChainLayers
        {
            get
            {
                return _swingChainLayers;
            }
        }

        public List<ActorAnimationIKCorrectionCollider> ikCorrectionColliders
        {
            get
            {
                return _ikCorrectionColliders;
            }
        }

        public List<EffectorBase> effectors
        {
            get
            {
                return _effectors;
            }
        }

        public ActorAnimationIKCorrectionGoal rightHandGoal
        {
            get
            {
                return _rightHandGoal;
            }
        }

        public ActorAnimationIKCorrectionGoal leftHandGoal
        {
            get
            {
                return _leftHandGoal;
            }
        }

        public Transform campusActorController
        {
            get
            {
                return _root.parent;
            }
        }

        public Transform root
        {
            get
            {
                return _root;
            }

            set
            {
                _root = value;
            }
        }

        public Transform leftUpLeg
        {
            get
            {
                return _leftUpLeg;
            }

            set
            {
                _leftUpLeg = value;
            }
        }

        public Transform leftLeg
        {
            get
            {
                return _leftLeg;
            }

            set
            {
                _leftLeg = value;
            }
        }

        public Transform leftFoot
        {
            get
            {
                return _leftFoot;
            }

            set
            {
                _leftFoot = value;
            }
        }

        public Transform rightUpLeg
        {
            get
            {
                return _rightUpLeg;
            }

            set
            {
                _rightUpLeg = value;
            }
        }

        public Transform rightLeg
        {
            get
            {
                return _rightLeg;
            }

            set
            {
                _rightLeg = value;
            }
        }

        public Transform rightFoot
        {
            get
            {
                return _rightFoot;
            }

            set
            {
                _rightFoot = value;
            }
        }

        public Transform rootReference
        {
            get
            {
                return _rootReference;
            }
        }

        public Transform move
        {
            get
            {
                return _move;
            }
        }

        public Transform reference
        {
            get
            {
                return _hips.parent;
            }
        }

        public Transform hips
        {
            get
            {
                return _hips;
            }
        }

        public Transform head
        {
            get
            {
                return _head;
            }

            set
            {
                _head = value;
            }
        }

        public bool IsValid()
        {
            return _constraintTransformBones != null &&
                _quartzDriverRotationBones != null &&
                _quartzDriverFrillBones != null &&
                _quartzDriverSkirtBones != null &&
                _quartzDriverHairBones != null &&
                _quartzDriverHumanoidHandBones != null &&
                _quartzDriverHumanoidSleeveBones != null &&
                _quartzDriverHumanoidUpLegBones != null &&
                _quartzDriverHumanoidArmBones != null &&
                _quartzDriverWaistBones != null &&
                _quartzDriverFurisodeBones != null &&
                _quartzDriverPonchoBones != null &&
                _swingDynamicBones != null &&
                _swingStaticBones != null &&
                _swingBreastBones != null &&
                _swingChainLayers != null &&
                _effectors != null &&
                _root != null &&
                _move != null &&
                _reference != null &&
                _hips != null;
        }

        public void SetDefaultValues()
        {
            Clear();
        }

        public void Clear()
        {
            if (_constraintTransformBones == null) _constraintTransformBones = new List<ActorAnimationConstraintTransformBone>(8);
            else _constraintTransformBones.Clear();
            if (_quartzDriverRotationBones == null) _quartzDriverRotationBones = new List<ActorAnimationQuartzDriverRotationBone>(16);
            else _quartzDriverRotationBones.Clear();
            if (_quartzDriverFrillBones == null) _quartzDriverFrillBones = new List<ActorAnimationQuartzDriverFrillBone>(4);
            else _quartzDriverFrillBones.Clear();
            if (_quartzDriverSkirtBones == null) _quartzDriverSkirtBones = new List<ActorAnimationQuartzDriverSkirtBone>(12);
            else _quartzDriverSkirtBones.Clear();
            if (_quartzDriverHairBones == null) _quartzDriverHairBones = new List<ActorAnimationQuartzDriverHairBone>(10);
            else _quartzDriverHairBones.Clear();
            if (_quartzDriverHumanoidHandBones == null) _quartzDriverHumanoidHandBones = new List<ActorAnimationQuartzDriverHumanoidHandBone>(4);
            else _quartzDriverHumanoidHandBones.Clear();
            if (_quartzDriverHumanoidSleeveBones == null) _quartzDriverHumanoidSleeveBones = new List<ActorAnimationQuartzDriverHumanoidSleeveBone>(8);
            else _quartzDriverHumanoidSleeveBones.Clear();
            if (_quartzDriverHumanoidUpLegBones == null) _quartzDriverHumanoidUpLegBones = new List<ActorAnimationQuartzDriverHumanoidUpLegBone>(4);
            else _quartzDriverHumanoidUpLegBones.Clear();
            if (_quartzDriverHumanoidArmBones == null) _quartzDriverHumanoidArmBones = new List<ActorAnimationQuartzDriverHumanoidArmBone>(4);
            else _quartzDriverHumanoidArmBones.Clear();
            if (_quartzDriverWaistBones == null) _quartzDriverWaistBones = new List<ActorAnimationQuartzDriverWaistBone>(2);
            else _quartzDriverWaistBones.Clear();
            if (_quartzDriverFurisodeBones == null) _quartzDriverFurisodeBones = new List<ActorAnimationQuartzDriverFurisodeBone>(4);
            else _quartzDriverFurisodeBones.Clear();
            if (_quartzDriverPonchoBones == null) _quartzDriverPonchoBones = new List<ActorAnimationQuartzDriverPonchoBone>(6);
            else _quartzDriverPonchoBones.Clear();
            if (_swingDynamicBones == null) _swingDynamicBones = new List<ActorSwingDynamicBone>(64);
            else _swingDynamicBones.Clear();
            if (_swingStaticBones == null) _swingStaticBones = new List<ActorSwingStaticBone>(24);
            else _swingStaticBones.Clear();
            if (_swingBreastBones == null) _swingBreastBones = new List<ActorSwingBreastBone>(1);
            else _swingBreastBones.Clear();
            if (_swingChainLayers == null) _swingChainLayers = new List<ChainLayerInfo>(64);
            else _swingChainLayers.Clear();
            if (_effectors == null) _effectors = new List<EffectorBase>(11);
            else _effectors.Clear();
            if (_ikCorrectionColliders == null) _ikCorrectionColliders = new List<ActorAnimationIKCorrectionCollider>(8);
            else _ikCorrectionColliders.Clear();
        }

        public void AddConstraintTransformBone(ActorAnimationConstraintTransformBone bone)
        {
            if (bone == null) return;
            _constraintTransformBones.Add(bone);
        }

        public void AddQuartzDriverRotationBone(ActorAnimationQuartzDriverRotationBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverRotationBones.Add(bone);
        }

        public void AddQuartzDriverFrillBone(ActorAnimationQuartzDriverFrillBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverFrillBones.Add(bone);
        }

        public void AddQuartzDriverSkirtBone(ActorAnimationQuartzDriverSkirtBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverSkirtBones.Add(bone);
        }

        public void AddQuartzDriverHairBone(ActorAnimationQuartzDriverHairBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverHairBones.Add(bone);
        }

        public void AddQuartzDriverHumanoidHandBone(ActorAnimationQuartzDriverHumanoidHandBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverHumanoidHandBones.Add(bone);
        }

        public void AddQuartzDriverHumanoidSleeveBone(ActorAnimationQuartzDriverHumanoidSleeveBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverHumanoidSleeveBones.Add(bone);
        }

        public void AddQuartzDriverHumanoidUpLegBone(ActorAnimationQuartzDriverHumanoidUpLegBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverHumanoidUpLegBones.Add(bone);
        }

        public void AddQuartzDriverHumanoidArmBone(ActorAnimationQuartzDriverHumanoidArmBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverHumanoidArmBones.Add(bone);
        }

        public void AddQuartzDriverWaistBone(ActorAnimationQuartzDriverWaistBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverWaistBones.Add(bone);
        }

        public void AddQuartzDriverFurisodeBone(ActorAnimationQuartzDriverFurisodeBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverFurisodeBones.Add(bone);
        }

        public void AddQuartzDriverPonchoBone(ActorAnimationQuartzDriverPonchoBone bone)
        {
            if (bone == null) return;
            bone.UpdateHierarchyDepth();
            _quartzDriverPonchoBones.Add(bone);
        }

        public void AddIKCorrectionCollider(ActorAnimationIKCorrectionCollider collider)
        {
            if (collider == null) return;
            collider.UpdateHierarchyDepth();
            _ikCorrectionColliders.Add(collider);
        }

        public void SetIKSetting(List<EffectorBase> effectors, Transform move, Transform hips, Transform reference, ActorAnimationIKCorrectionGoal rightHandGoal, ActorAnimationIKCorrectionGoal leftHandGoal)
        {
            _effectors = effectors;
            _move = move;
            _hips = hips;
            _reference = reference;
            _rightHandGoal = rightHandGoal;
            _leftHandGoal = leftHandGoal;
        }

        public void SetRootLocator(Transform root, Transform rootReference)
        {
            _root = root;
            _rootReference = rootReference;
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

        private void SortDynamicBone(out List<ActorSwingDynamicBone> secondaryDynamicLayer)
        {
            throw null;
        }

        private void SortChainLayers(List<ActorSwingDynamicBone> secondaryDynamicList)
        {
        }

        private void SortIKCorrectionCollider()
        {
        }
    }
}
