namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct ActorAnimationFullBodyIKMovePart
    {
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CreferenceHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CtargetHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CskeletonHandle_003Ek__BackingField;
        [CompilerGenerated]
        private float3 _003CmoveDelta_003Ek__BackingField;
        public readonly TransformStreamHandle referenceHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CreferenceHandle_003Ek__BackingField;
            }
        }

        public readonly TransformStreamHandle targetHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CtargetHandle_003Ek__BackingField;
            }
        }

        public readonly TransformStreamHandle skeletonHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CskeletonHandle_003Ek__BackingField;
            }
        }

        public float3 moveDelta
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CmoveDelta_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CmoveDelta_003Ek__BackingField = value;
            }
        }

        public ActorAnimationFullBodyIKMovePart(Animator animator, Transform reference, Transform target, Transform skeleton)
        {
            _003CreferenceHandle_003Ek__BackingField = animator.BindStreamTransform(reference);
            _003CtargetHandle_003Ek__BackingField = animator.BindStreamTransform(target);
            _003CskeletonHandle_003Ek__BackingField = animator.BindStreamTransform(skeleton);
            _003CmoveDelta_003Ek__BackingField = float3.zero;
        }
    }
}
