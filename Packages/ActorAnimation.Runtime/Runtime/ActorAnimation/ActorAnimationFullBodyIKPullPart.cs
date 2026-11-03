namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct ActorAnimationFullBodyIKPullPart
    {
        [CompilerGenerated]
        private readonly PropertySceneHandle _003ClookAtClampWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CstiffnessHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CmaxPullIterationHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003ChandDownHandle_003Ek__BackingField;
        public readonly PropertySceneHandle stiffnessHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly PropertySceneHandle maxPullIterationHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public ActorAnimationFullBodyIKPullPart(Animator animator, ActorAnimationFullBodyIKPullPartSetting setting)
        {
            this = default;
        }

        public ActorAnimationFullBodyIKPullPart(PropertySceneHandle lookAtClampWeightHandle, PropertySceneHandle stiffnessHandle, PropertySceneHandle maxPullIterationHandle, PropertySceneHandle handDownHandle)
        {
            this = default;
        }
    }
}
