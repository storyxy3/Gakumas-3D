namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct CampusActorAnimationFullBodyIKPullPart
    {
        [CompilerGenerated]
        private readonly PropertySceneHandle _003ClookAtClampWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CstiffnessHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CmaxPullIterationHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003ChandDownHandle_003Ek__BackingField;
        public readonly PropertySceneHandle lookAtClampWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003ClookAtClampWeightHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle stiffnessHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CstiffnessHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle maxPullIterationHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CmaxPullIterationHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle handDownHandle
        {
            [CompilerGenerated]
            get
            {
                return _003ChandDownHandle_003Ek__BackingField;
            }
        }

        public CampusActorAnimationFullBodyIKPullPart(Animator animator, Transform reference)
        {
            _003ClookAtClampWeightHandle_003Ek__BackingField = animator.BindSceneProperty(reference, typeof(global::Campus.Common.CampusActorAnimation), "lookAtClampWeight");
            _003CstiffnessHandle_003Ek__BackingField = animator.BindSceneProperty(reference, typeof(global::Campus.Common.CampusActorAnimation), "stiffness");
            _003CmaxPullIterationHandle_003Ek__BackingField = animator.BindSceneProperty(reference, typeof(global::Campus.Common.CampusActorAnimation), "maxPullIteration");
            _003ChandDownHandle_003Ek__BackingField = animator.BindSceneProperty(reference, typeof(global::Campus.Common.CampusActorAnimation), "handDown");
        }

        public ActorAnimationFullBodyIKPullPart ToActorAnimation()
        {
            return new ActorAnimationFullBodyIKPullPart(lookAtClampWeightHandle, stiffnessHandle, maxPullIterationHandle, handDownHandle);
        }
    }
}
