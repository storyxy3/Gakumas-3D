namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct ActorAnimationIKCorrectionJobGoal
    {
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CenableHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CradiusHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CoffsetXHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CoffsetYHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CoffsetZHandle_003Ek__BackingField;
        public readonly PropertySceneHandle enableHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CenableHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle radiusHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CradiusHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle offsetXHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CoffsetXHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle offsetYHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CoffsetYHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle offsetZHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CoffsetZHandle_003Ek__BackingField;
            }
        }

        public ActorAnimationIKCorrectionJobGoal(Animator animator, ActorAnimationIKCorrectionGoal correctionGoal)
        {
            this = default;
            if (correctionGoal == null) return;
            _003CenableHandle_003Ek__BackingField = animator.BindSceneProperty(correctionGoal.transform, typeof(ActorAnimationIKCorrectionGoal), "enable");
            _003CradiusHandle_003Ek__BackingField = animator.BindSceneProperty(correctionGoal.transform, typeof(ActorAnimationIKCorrectionGoal), "radius");
            _003CoffsetXHandle_003Ek__BackingField = animator.BindSceneProperty(correctionGoal.transform, typeof(ActorAnimationIKCorrectionGoal), "offset.x");
            _003CoffsetYHandle_003Ek__BackingField = animator.BindSceneProperty(correctionGoal.transform, typeof(ActorAnimationIKCorrectionGoal), "offset.y");
            _003CoffsetZHandle_003Ek__BackingField = animator.BindSceneProperty(correctionGoal.transform, typeof(ActorAnimationIKCorrectionGoal), "offset.z");
        }
    }
}
