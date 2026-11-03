namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct ActorAnimationFullBodyIKLimbPart
    {
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CtopHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CmiddleHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly TransformStreamHandle _003CendHandle_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CmaximumExtension_003Ek__BackingField;
        [CompilerGenerated]
        private float3 _003ClocalPosition_003Ek__BackingField;
        [CompilerGenerated]
        private float3 _003CgoalPosition_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CgoalWeight_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CgoalPullWeight_003Ek__BackingField;
        [CompilerGenerated]
        private float _003Cstiffness_003Ek__BackingField;
        public readonly TransformStreamHandle topHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformStreamHandle);
            }
        }

        public readonly TransformStreamHandle middleHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformStreamHandle);
            }
        }

        public readonly TransformStreamHandle endHandle
        {
            [CompilerGenerated]
            get
            {
                return default(TransformStreamHandle);
            }
        }

        public float maximumExtension
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float3 localPosition
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

        public float3 goalPosition
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

        public float goalWeight
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float goalPullWeight
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public float stiffness
        {
            [CompilerGenerated]
            readonly get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public ActorAnimationFullBodyIKLimbPart(Animator animator, HumanBodyBones top, HumanBodyBones middle, HumanBodyBones end)
        {
            this = default;
        }
    }
}
