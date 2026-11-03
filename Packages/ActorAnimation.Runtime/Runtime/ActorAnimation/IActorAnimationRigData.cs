namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    public interface IActorAnimationRigData : IAnimationJobData
    {
        List<ActorAnimationConstraintTransformBone> constraintTransformBones { get; }

        List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones { get; }

        List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones { get; }

        List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones { get; }

        List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones { get; }

        List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones { get; }

        List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones { get; }

        List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones { get; }

        List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones { get; }

        List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones { get; }

        List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones { get; }

        List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones { get; }

        List<ActorSwingDynamicBone> swingDynamicBones { get; }

        List<ActorSwingStaticBone> swingStaticBones { get; }

        List<ActorSwingBreastBone> swingBreastBones { get; }

        List<ChainLayerInfo> swingChainLayers { get; }

        Transform root { get; set; }

        Transform hips { get; }

        Transform leftUpLeg { get; }

        Transform leftLeg { get; }

        Transform leftFoot { get; }

        Transform rightUpLeg { get; }

        Transform rightLeg { get; }

        Transform rightFoot { get; }

        void Sort();
        void Clear();
    }
}
