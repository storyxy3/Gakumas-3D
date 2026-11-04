namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationRootControllerJobLocator
    {
        private bool _isActive;
        public ReadWriteTransformHandle rootHandle;
        public TransformSceneHandle rootReferenceHandle;
        public bool IsActive
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return default(bool);
        }

        public bool Resolve(AnimationStream stream)
        {
            return default(bool);
        }

        public void Execute(AnimationStream stream)
        {
        }

        public ActorAnimationRootControllerJobLocator(Transform root, Transform rootReference, Animator animator)
        {
            this = default;
        }

        public void SetupRootController(Transform root, Transform rootReference, Animator animator)
        {
            rootHandle = ReadWriteTransformHandle.Bind(animator, root);
            rootReferenceHandle = animator.BindSceneTransform(rootReference);
        }
    }
}
