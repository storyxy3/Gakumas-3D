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
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return rootHandle.IsValid(stream) && rootReferenceHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!rootHandle.IsResolved(stream)) rootHandle.Resolve(stream);
            return rootHandle.IsResolved(stream);
        }

        public void Execute(AnimationStream stream)
        {
            rootReferenceHandle.GetGlobalTR(stream, out var position, out var rotation);
            rootHandle.SetGlobalTR(stream, position, rotation, false);
        }

        public ActorAnimationRootControllerJobLocator(Transform root, Transform rootReference, Animator animator)
        {
            this = default;
            _isActive = true;
            if (root != null && rootReference != null)
            {
                rootHandle = ReadWriteTransformHandle.Bind(animator, root);
                rootReferenceHandle = animator.BindSceneTransform(rootReference);
            }
        }

        public void SetupRootController(Transform root, Transform rootReference, Animator animator)
        {
            rootHandle = ReadWriteTransformHandle.Bind(animator, root);
            rootReferenceHandle = animator.BindSceneTransform(rootReference);
        }
    }
}
