namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::Unity.Collections.LowLevel.Unsafe;

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
            if (_job == null) return;
            var animationJob = (CampusActorAnimationJob)_job;
            if (!animationJob.swingJobSkeleton.dynamicBones.IsCreated || !animationJob.swingJobSkeleton.instanceIDToDynamicBoneIndex.IsCreated)
            {
                Debug.LogWarning("データ構造が生成されていません");
                return;
            }
            unsafe
            {
                var bone = (ActorSwingJobDynamicBone*)animationJob.swingJobSkeleton.dynamicBones.GetUnsafePtr();
                for (int i = 0; i < animationJob.swingJobSkeleton.dynamicBones.Length; i++) bone[i].active = true;
                foreach (int id in inactiveBones)
                    if (animationJob.swingJobSkeleton.instanceIDToDynamicBoneIndex.TryGetValue(id, out int index)) bone[index].active = false;
            }
        }

        public override void ResetDynamicBone()
        {
            if (data.swingDynamicBones == null || _job == null) return;
            var animationJob = (CampusActorAnimationJob)_job;
            if (animationJob.swingJobSkeleton.dynamicBones.Length != data.swingDynamicBones.Count)
            {
                Debug.LogWarning("JobとC#の配列サイズがずれています");
                return;
            }
            unsafe
            {
                var ptr = (ActorSwingJobDynamicBone*)animationJob.swingJobSkeleton.dynamicBones.GetUnsafePtr();
                foreach (var bone in data.swingDynamicBones)
                {
                    ptr->Reset(bone.initialTransform, manageData != null ? manageData.propertyData.prewarmCount : 5);
                    ptr++;
                }
            }
        }

        public override void ResetBreastBone()
        {
            if (data.swingBreastBones == null || _job == null) return;
            var animationJob = (CampusActorAnimationJob)_job;
            if (animationJob.swingJobSkeleton.breastBones.Length != data.swingBreastBones.Count)
            {
                Debug.LogWarning("JobとC#の配列サイズがずれています");
                return;
            }
            unsafe
            {
                var ptr = (ActorSwingJobBreastBone*)animationJob.swingJobSkeleton.breastBones.GetUnsafePtr();
                foreach (var bone in data.swingBreastBones)
                {
                    ptr->Reset(bone.initialLeftEndTransform, bone.initialRightEndTransform, manageData != null ? manageData.propertyData.prewarmCount : 5);
                    ptr++;
                }
            }
        }

        public override void ResetDynamicSkin()
        {
            if (data.swingDynamicBones == null || _job == null) return;
            var animationJob = (CampusActorAnimationJob)_job;
            if (animationJob.swingJobSkeleton.dynamicBones.Length != data.swingDynamicBones.Count)
            {
                Debug.LogWarning("JobとC#の配列サイズがずれています");
                return;
            }
            unsafe
            {
                var ptr = (ActorSwingJobDynamicBone*)animationJob.swingJobSkeleton.dynamicBones.GetUnsafePtr();
                foreach (var bone in data.swingDynamicBones)
                {
                    if ((bone.resetType & ResetType.Skin) != 0)
                    ptr->Reset(bone.initialTransform, manageData != null ? manageData.propertyData.prewarmCount : 5);
                    ptr++;
                }
            }
        }

        public override void ResetTime()
        {
            if (data.swingDynamicBones != null && _job != null)
            {
                var animationJob = (CampusActorAnimationJob)_job;
                animationJob.ResetTime();
            }
        }

        public void UpdateIKCorrectionColliderProperty(Animator animator)
        {
            if (_job is CampusActorAnimationJob animationJob)
                animationJob.UpdateIKCorrectionColliderProperty(ref data, animator);
        }

        public CampusActorAnimationRig()
        {
        }
    }
}
