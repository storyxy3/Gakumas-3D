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
                return _003CeyesWeightHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle headWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CheadWeightHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle bodyWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CbodyWeightHandle_003Ek__BackingField;
            }
        }

        public readonly ReadOnlyTransformHandle referenceHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CreferenceHandle_003Ek__BackingField;
            }
        }

        public ActorAnimationIKLookAtEffector(Animator animator, Transform locator)
        {
            this = default;
        }

        public ActorAnimationIKLookAtEffector(ReadOnlyTransformHandle referenceHandle, PropertySceneHandle eyesWeightHandle, PropertySceneHandle headWeightHandle, PropertySceneHandle bodyWeightHandle)
        {
            _003CreferenceHandle_003Ek__BackingField = referenceHandle;
            _003CeyesWeightHandle_003Ek__BackingField = eyesWeightHandle;
            _003CheadWeightHandle_003Ek__BackingField = headWeightHandle;
            _003CbodyWeightHandle_003Ek__BackingField = bodyWeightHandle;
        }
    }
}
