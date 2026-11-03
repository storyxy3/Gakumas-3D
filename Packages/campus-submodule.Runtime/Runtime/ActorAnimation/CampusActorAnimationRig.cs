namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;

    public class CampusActorAnimationRig : ActorAnimationRig<CampusActorAnimationJob, CampusActorAnimationRigData, ActorAnimationJobBinder<CampusActorAnimationJob, CampusActorAnimationRigData>>
    {
        public void RegisterBones(CampusActorAnimationInitializeData initialData)
        {
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
