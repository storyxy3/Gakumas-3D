namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationIKLookAtEffector
    {
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CeyesWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CheadWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CbodyWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ReadOnlyTransformHandle _003CreferenceHandle_003Ek__BackingField;
        public readonly PropertySceneHandle eyesWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly PropertySceneHandle headWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly PropertySceneHandle bodyWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly ReadOnlyTransformHandle referenceHandle
        {
            [CompilerGenerated]
            get
            {
                return default(ReadOnlyTransformHandle);
            }
        }

        public ActorAnimationIKLookAtEffector(Animator animator, Transform locator)
        {
            this = default;
        }

        public ActorAnimationIKLookAtEffector(ReadOnlyTransformHandle referenceHandle, PropertySceneHandle eyesWeightHandle, PropertySceneHandle headWeightHandle, PropertySceneHandle bodyWeightHandle)
        {
            this = default;
        }
    }
}
