namespace ActorAnimation
{
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public struct ActorAnimationFullBodyIKWriteBack
    {
        public ReadOnlyTransformHandle headTransformHandle;
        public PropertyStreamHandle headOriginalPositionXWriteBackPropertyHandle;
        public PropertyStreamHandle headOriginalPositionYWriteBackPropertyHandle;
        public PropertyStreamHandle headOriginalPositionZWriteBackPropertyHandle;
        public PropertyStreamHandle headOriginalRotationXWriteBackPropertyHandle;
        public PropertyStreamHandle headOriginalRotationYWriteBackPropertyHandle;
        public PropertyStreamHandle headOriginalRotationZWriteBackPropertyHandle;
        public ActorAnimationFullBodyIKWriteBack(Animator animator, ReadOnlyTransformHandle headTransformHandle, PropertyStreamHandle headOriginalPositionXWriteBackPropertyHandle, PropertyStreamHandle headOriginalPositionYWriteBackPropertyHandle, PropertyStreamHandle headOriginalPositionZWriteBackPropertyHandle, PropertyStreamHandle headOriginalRotationXWriteBackPropertyHandle, PropertyStreamHandle headOriginalRotationYWriteBackPropertyHandle, PropertyStreamHandle headOriginalRotationZWriteBackPropertyHandle)
        {
            this = default;
        }
    }
}
