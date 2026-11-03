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
                return default(AvatarIKHint);
            }
        }

        public readonly ActorAnimationIKHandleType handleType
        {
            [CompilerGenerated]
            get
            {
                return default(ActorAnimationIKHandleType);
            }
        }

        public readonly ReadOnlyTransformHandle referenceAnimationHandle
        {
            [CompilerGenerated]
            get
            {
                return default(ReadOnlyTransformHandle);
            }
        }

        public readonly TransformSceneHandle referenceSceneHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformSceneHandle);
            }
        }

        public ActorAnimationIKHintEffector(Animator animator, Transform locator, AvatarIKHint hintParts, ActorAnimationIKHandleType handleType)
        {
            this = default;
        }

        public bool IsValid(AnimationStream stream)
        {
            return default(bool);
        }

        public Vector3 GetPosition(AnimationStream stream)
        {
            return default(Vector3);
        }

        public Vector3 GetLocalScale(AnimationStream stream)
        {
            return default(Vector3);
        }
    }
}
