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
                return default(TransformStreamHandle);
            }
        }

        public readonly TransformStreamHandle targetHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformStreamHandle);
            }
        }

        public readonly TransformStreamHandle skeletonHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformStreamHandle);
            }
        }

        public float3 moveDelta
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float3);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public ActorAnimationFullBodyIKMovePart(Animator animator, Transform reference, Transform target, Transform skeleton)
        {
            this = default;
        }
    }
}
