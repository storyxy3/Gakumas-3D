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
                return _003CtopHandle_003Ek__BackingField;
            }
        }

        public readonly TransformStreamHandle middleHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CmiddleHandle_003Ek__BackingField;
            }
        }

        public readonly TransformStreamHandle endHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CendHandle_003Ek__BackingField;
            }
        }

        public float maximumExtension
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CmaximumExtension_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CmaximumExtension_003Ek__BackingField = value;
            }
        }

        public float3 localPosition
        {
            [CompilerGenerated]
            readonly get
            {
                return _003ClocalPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003ClocalPosition_003Ek__BackingField = value;
            }
        }

        public float3 goalPosition
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CgoalPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CgoalPosition_003Ek__BackingField = value;
            }
        }

        public float goalWeight
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CgoalWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CgoalWeight_003Ek__BackingField = value;
            }
        }

        public float goalPullWeight
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CgoalPullWeight_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CgoalPullWeight_003Ek__BackingField = value;
            }
        }

        public float stiffness
        {
            [CompilerGenerated]
            readonly get
            {
                return _003Cstiffness_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003Cstiffness_003Ek__BackingField = value;
            }
        }

        public ActorAnimationFullBodyIKLimbPart(Animator animator, HumanBodyBones top, HumanBodyBones middle, HumanBodyBones end)
        {
            this = default;
            _003CtopHandle_003Ek__BackingField = animator.BindStreamTransform(animator.GetBoneTransform(top));
            _003CmiddleHandle_003Ek__BackingField = animator.BindStreamTransform(animator.GetBoneTransform(middle));
            _003CendHandle_003Ek__BackingField = animator.BindStreamTransform(animator.GetBoneTransform(end));
            _003ClocalPosition_003Ek__BackingField = float3.zero;
            _003CgoalPosition_003Ek__BackingField = float3.zero;
        }
    }
}
