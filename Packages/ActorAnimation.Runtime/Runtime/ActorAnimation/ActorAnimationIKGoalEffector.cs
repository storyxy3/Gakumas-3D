namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationIKGoalEffector
    {
        [CompilerGenerated]
        private readonly AvatarIKGoal _003Cgoal_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ActorAnimationIKHandleType _003ChandleType_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ReadOnlyTransformHandle _003CreferenceAnimationHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformSceneHandle _003CreferenceSceneHandle_003Ek__BackingField;
        public readonly AvatarIKGoal goal
        {
            [CompilerGenerated]
            get
            {
                return default(AvatarIKGoal);
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

        public ActorAnimationIKGoalEffector(Animator animator, Transform locator, AvatarIKGoal goalParts, ActorAnimationIKHandleType handleType)
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

        public Quaternion GetRotation(AnimationStream stream)
        {
            return default(Quaternion);
        }

        public Vector3 GetLocalScale(AnimationStream stream)
        {
            return default(Vector3);
        }
    }
}
