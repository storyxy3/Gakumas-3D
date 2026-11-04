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
            this.headTransformHandle = headTransformHandle;
            this.headOriginalPositionXWriteBackPropertyHandle = headOriginalPositionXWriteBackPropertyHandle;
            this.headOriginalPositionYWriteBackPropertyHandle = headOriginalPositionYWriteBackPropertyHandle;
            this.headOriginalPositionZWriteBackPropertyHandle = headOriginalPositionZWriteBackPropertyHandle;
            this.headOriginalRotationXWriteBackPropertyHandle = headOriginalRotationXWriteBackPropertyHandle;
            this.headOriginalRotationYWriteBackPropertyHandle = headOriginalRotationYWriteBackPropertyHandle;
            this.headOriginalRotationZWriteBackPropertyHandle = headOriginalRotationZWriteBackPropertyHandle;
        }
    }
}
