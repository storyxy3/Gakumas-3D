namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorSwingJobStaticBone
    {
        public ActorSwingJobCollider collider;
        public ReadOnlyTransformHandle driven;
        public ReadOnlyTransformHandle parent;
    }
}
