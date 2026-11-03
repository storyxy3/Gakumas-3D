namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.InteropServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL.IK;

    [Serializable]
    public class CampusActorAnimationInitializeData
    {
        public List<ActorAnimationConstraintTransformBone> constraintTransformBones;
        public List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones;
        public List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones;
        public List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones;
        public List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones;
        public List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones;
        public List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones;
        public List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones;
        public List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones;
        public List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones;
        public List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones;
        public List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones;
        public List<EffectorBase> effectors;
        public Transform moveReference;
        public Transform hips;
        public Transform head;
        public Transform reference;
        public List<ActorAnimationIKCorrectionCollider> iKCorrectionColliders;
        public ActorAnimationIKCorrectionGoal correctionRightHandGoal;
        public ActorAnimationIKCorrectionGoal correctionLeftHandGoal;
        public List<InitialTransform> initialTransforms;
        public List<InitialTransform> initialLeftBreastTransforms;
        public List<InitialTransform> initialRightBreastTransforms;
        public List<InitialTransform> initialLeftBreastEndTransforms;
        public List<InitialTransform> initialRightBreastEndTransforms;
        public List<ActorSwingDynamicBone> swingDynamicBones;
        public List<ActorSwingStaticBone> swingStaticBones;
        public List<ActorSwingBreastBone> swingBreastBones;
        public List<ActorSwingChain> swingChains;
        public Transform leftUpLeg;
        public Transform leftLeg;
        public Transform leftFoot;
        public Transform rightUpLeg;
        public Transform rightLeg;
        public Transform rightFoot;
        public Transform root;
        public Transform rootReference;
        public CampusActorAnimationInitializeData(List<ActorAnimationConstraintTransformBone> constraintTransformBones, List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones, List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones, List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones, List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones, List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones, List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones, List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones, List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones, List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones, List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones, List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones, List<InitialTransform> initialTransforms, List<ActorSwingDynamicBone> swingDynamicBones, List<ActorSwingStaticBone> swingStaticBones, List<ActorSwingBreastBone> swingBreastBones, List<InitialTransform> initialLeftBreastTransforms, List<InitialTransform> initialRightBreastTransforms, List<InitialTransform> initialLeftBreastEndTransforms, List<InitialTransform> initialRightBreastEndTransforms, List<ActorSwingChain> swingChains, Transform leftUpLeg, Transform leftLeg, Transform leftFoot, Transform rightUpLeg, Transform rightLeg, Transform rightFoot, List<EffectorBase> effectors, Transform moveReference, Transform hips, Transform head, List<ActorAnimationIKCorrectionCollider> iKCorrectionColliders, [Optional] ActorAnimationIKCorrectionGoal correctionRightHandGoal, [Optional] ActorAnimationIKCorrectionGoal correctionLeftHandGoal, [Optional] Transform root, [Optional] Transform rootReference)
        {
        }
    }
}
