namespace Campus.AnimationRigging
{
    using global::Campus.AnimationRigging;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    public class ActorAnimationAttributeConvertConstraintBinder : AnimationJobBinder<ActorAnimationAttributeConvertConstraintJob, ActorAnimationAttributeConvertConstraintData>
    {
        public override ActorAnimationAttributeConvertConstraintJob Create(Animator animator, ref ActorAnimationAttributeConvertConstraintData data, Component component)
        {
            return default(ActorAnimationAttributeConvertConstraintJob);
        }

        public override void Destroy(ActorAnimationAttributeConvertConstraintJob job)
        {
        }

        public ActorAnimationAttributeConvertConstraintBinder()
        {
        }
    }
}
