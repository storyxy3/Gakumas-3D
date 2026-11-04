namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    public class CampusActorAnimationIKLookAtEffector
    {
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CeyesWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CheadWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CbodyWeightHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly ReadOnlyTransformHandle _003CreferenceHandle_003Ek__BackingField;
        public PropertySceneHandle eyesWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CeyesWeightHandle_003Ek__BackingField;
            }
        }

        public PropertySceneHandle headWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CheadWeightHandle_003Ek__BackingField;
            }
        }

        public PropertySceneHandle bodyWeightHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CbodyWeightHandle_003Ek__BackingField;
            }
        }

        public ReadOnlyTransformHandle referenceHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CreferenceHandle_003Ek__BackingField;
            }
        }

        public CampusActorAnimationIKLookAtEffector(Animator animator, Transform locator)
        {
            _003CreferenceHandle_003Ek__BackingField = ReadOnlyTransformHandle.Bind(animator, locator);
            _003CeyesWeightHandle_003Ek__BackingField = animator.BindSceneProperty(locator, typeof(global::VL.IK.LookAtEffector), "eyesWeight");
            _003CheadWeightHandle_003Ek__BackingField = animator.BindSceneProperty(locator, typeof(global::VL.IK.LookAtEffector), "headWeight");
            _003CbodyWeightHandle_003Ek__BackingField = animator.BindSceneProperty(locator, typeof(global::VL.IK.LookAtEffector), "bodyWeight");
        }

        public ActorAnimationIKLookAtEffector ToActorAnimation()
        {
            return new ActorAnimationIKLookAtEffector(referenceHandle, eyesWeightHandle, headWeightHandle, bodyWeightHandle);
        }
    }
}
