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

        public ActorAnimationFullBodyIKPullPart(Animator animator, ActorAnimationFullBodyIKPullPartSetting setting)
        {
            _003ClookAtClampWeightHandle_003Ek__BackingField = animator.BindSceneProperty(setting.transform, typeof(ActorAnimationFullBodyIKPullPartSetting), "lookAtClampWeight");
            _003CstiffnessHandle_003Ek__BackingField = animator.BindSceneProperty(setting.transform, typeof(ActorAnimationFullBodyIKPullPartSetting), "stiffness");
            _003CmaxPullIterationHandle_003Ek__BackingField = animator.BindSceneProperty(setting.transform, typeof(ActorAnimationFullBodyIKPullPartSetting), "maxPullIteration");
            _003ChandDownHandle_003Ek__BackingField = animator.BindSceneProperty(setting.transform, typeof(ActorAnimationFullBodyIKPullPartSetting), "handDown");
        }

        public ActorAnimationFullBodyIKPullPart(PropertySceneHandle lookAtClampWeightHandle, PropertySceneHandle stiffnessHandle, PropertySceneHandle maxPullIterationHandle, PropertySceneHandle handDownHandle)
        {
            _003ClookAtClampWeightHandle_003Ek__BackingField = lookAtClampWeightHandle;
            _003CstiffnessHandle_003Ek__BackingField = stiffnessHandle;
            _003CmaxPullIterationHandle_003Ek__BackingField = maxPullIterationHandle;
            _003ChandDownHandle_003Ek__BackingField = handDownHandle;
        }
    }
}
