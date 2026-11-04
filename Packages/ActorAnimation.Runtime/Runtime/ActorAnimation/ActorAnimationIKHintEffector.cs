namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationIKHintEffector
    {
        [CompilerGenerated]
        private readonly AvatarIKHint _003Chint_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ActorAnimationIKHandleType _003ChandleType_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ReadOnlyTransformHandle _003CreferenceAnimationHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformSceneHandle _003CreferenceSceneHandle_003Ek__BackingField;
        public readonly AvatarIKHint hint
        {
            [CompilerGenerated]
            get
            {
                return _003Chint_003Ek__BackingField;
            }
        }

        public readonly ActorAnimationIKHandleType handleType
        {
            [CompilerGenerated]
            get
            {
                return _003ChandleType_003Ek__BackingField;
            }
        }

        public readonly ReadOnlyTransformHandle referenceAnimationHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CreferenceAnimationHandle_003Ek__BackingField;
            }
        }

        public readonly TransformSceneHandle referenceSceneHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CreferenceSceneHandle_003Ek__BackingField;
            }
        }

        public ActorAnimationIKHintEffector(Animator animator, Transform locator, AvatarIKHint hintParts, ActorAnimationIKHandleType handleType)
        {
            _003CreferenceAnimationHandle_003Ek__BackingField = ReadOnlyTransformHandle.Bind(animator, locator);
            _003CreferenceSceneHandle_003Ek__BackingField = animator.BindSceneTransform(locator);
            _003Chint_003Ek__BackingField = hintParts;
            _003ChandleType_003Ek__BackingField = handleType;
        }

        public bool IsValid(AnimationStream stream)
        {
            switch (handleType)
            {
                case (ActorAnimationIKHandleType)0: return referenceAnimationHandle.IsValid(stream);
                case (ActorAnimationIKHandleType)1: return referenceSceneHandle.IsValid(stream);
                default: return false;
            }
        }

        public Vector3 GetPosition(AnimationStream stream)
        {
            switch (handleType)
            {
                case (ActorAnimationIKHandleType)0: return referenceAnimationHandle.GetPosition(stream);
                case (ActorAnimationIKHandleType)1: return referenceSceneHandle.GetPosition(stream);
                default: return Vector3.zero;
            }
        }

        public Vector3 GetLocalScale(AnimationStream stream)
        {
            switch (handleType)
            {
                case (ActorAnimationIKHandleType)0: return referenceAnimationHandle.GetLocalScale(stream);
                case (ActorAnimationIKHandleType)1: return referenceSceneHandle.GetLocalScale(stream);
                default: return Vector3.one;
            }
        }
    }
}
