namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;

    public class CampusActorAnimationRig : ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, ActorAnimationJobBinder<CampusActorAnimationJob, CampusActorAnimationRigData>>
    {
        public void RegisterBones(CampusActorAnimationInitializeData initialData)
        {
            for (int i = 0; i < initialData.constraintTransformBones.Count; i++)
                data.AddConstraintTransformBone(initialData.constraintTransformBones[i]);
            for (int i = 0; i < initialData.quartzDriverRotationBones.Count; i++)
                data.AddQuartzDriverRotationBone(initialData.quartzDriverRotationBones[i]);
            for (int i = 0; i < initialData.quartzDriverFrillBones.Count; i++)
                data.AddQuartzDriverFrillBone(initialData.quartzDriverFrillBones[i]);
            for (int i = 0; i < initialData.quartzDriverSkirtBones.Count; i++)
                data.AddQuartzDriverSkirtBone(initialData.quartzDriverSkirtBones[i]);
            for (int i = 0; i < initialData.quartzDriverHairBones.Count; i++)
                data.AddQuartzDriverHairBone(initialData.quartzDriverHairBones[i]);
            for (int i = 0; i < initialData.quartzDriverHumanoidHandBones.Count; i++)
                data.AddQuartzDriverHumanoidHandBone(initialData.quartzDriverHumanoidHandBones[i]);
            for (int i = 0; i < initialData.quartzDriverHumanoidSleeveBones.Count; i++)
                data.AddQuartzDriverHumanoidSleeveBone(initialData.quartzDriverHumanoidSleeveBones[i]);
            for (int i = 0; i < initialData.quartzDriverHumanoidUpLegBones.Count; i++)
                data.AddQuartzDriverHumanoidUpLegBone(initialData.quartzDriverHumanoidUpLegBones[i]);
            for (int i = 0; i < initialData.quartzDriverHumanoidArmBones.Count; i++)
                data.AddQuartzDriverHumanoidArmBone(initialData.quartzDriverHumanoidArmBones[i]);
            for (int i = 0; i < initialData.quartzDriverWaistBones.Count; i++)
                data.AddQuartzDriverWaistBone(initialData.quartzDriverWaistBones[i]);
            for (int i = 0; i < initialData.quartzDriverFurisodeBones.Count; i++)
                data.AddQuartzDriverFurisodeBone(initialData.quartzDriverFurisodeBones[i]);
            for (int i = 0; i < initialData.quartzDriverPonchoBones.Count; i++)
                data.AddQuartzDriverPonchoBone(initialData.quartzDriverPonchoBones[i]);
            for (int i = 0; i < initialData.swingDynamicBones.Count; i++)
            {
                var bone = initialData.swingDynamicBones[i];
                bone.UpdateHierarchyDepth();
                bone.UpdateInitialTransform(initialData.initialTransforms[i]);
                data.swingDynamicBones.Add(bone);
            }
            for (int i = 0; i < initialData.swingStaticBones.Count; i++)
                data.swingStaticBones.Add(initialData.swingStaticBones[i]);
            for (int i = 0; i < initialData.swingBreastBones.Count; i++)
            {
                var bone = initialData.swingBreastBones[i];
                bone.UpdateInitialTransform(initialData.initialLeftBreastTransforms[i], initialData.initialRightBreastTransforms[i],
                    initialData.initialLeftBreastEndTransforms[i], initialData.initialRightBreastEndTransforms[i]);
                data.swingBreastBones.Add(bone);
            }
            for (int i = 0; i < initialData.swingChains.Count; i++)
            {
                var chain = initialData.swingChains[i];
                if (CheckChain(chain) && chain != null && chain.chains != null && chain.chains.layers != null)
                {
                    chain.UpdateHierarchyDepth();
                    data.swingChainLayers.AddRange(chain.chains.layers);
                }
            }
            data.leftUpLeg = initialData.leftUpLeg;
            data.leftLeg = initialData.leftLeg;
            data.leftFoot = initialData.leftFoot;
            data.rightUpLeg = initialData.rightUpLeg;
            data.rightLeg = initialData.rightLeg;
            data.rightFoot = initialData.rightFoot;
            data.SetIKSetting(initialData.effectors, initialData.moveReference, initialData.hips, initialData.reference,
                initialData.correctionRightHandGoal, initialData.correctionLeftHandGoal);
            for (int i = 0; i < initialData.iKCorrectionColliders.Count; i++)
                data.AddIKCorrectionCollider(initialData.iKCorrectionColliders[i]);
            data.head = initialData.head;
            data.SetRootLocator(initialData.root, initialData.rootReference);
            data.Sort();
        }

        public override void SetInactiveBones(IEnumerable<int> inactiveBones)
        {
        }

        public override void ResetDynamicBone()
        {
        }

        public override void ResetBreastBone()
        {
        }

        public override void ResetDynamicSkin()
        {
        }

        public override void ResetTime()
        {
        }

        public void UpdateIKCorrectionColliderProperty(Animator animator)
        {
        }

        public CampusActorAnimationRig()
        {
        }
    }
}
