namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ActorAnimation;

    [Serializable]
    public class ActorAnimationInitializeData
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
        public List<InitialTransform> initialTransforms;
        public List<InitialTransform> initialLeftBreastTransforms;
        public List<InitialTransform> initialRightBreastTransforms;
        public List<InitialTransform> initialLeftBreastEndTransforms;
        public List<InitialTransform> initialRightBreastEndTransforms;
        public List<ActorSwingDynamicBone> swingDynamicBones;
        public List<ActorSwingStaticBone> swingStaticBones;
        public List<ActorSwingBreastBone> swingBreastBones;
        public List<ActorSwingChain> swingChains;
        public ActorAnimationInitializeData(IEnumerable<IActorAnimationBone> bones)
        {
        }
    }
}
