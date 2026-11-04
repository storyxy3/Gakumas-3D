namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorSwingJobBreastBoneSetting
    {
        public float3 boneEndAxis;
        public float boneEndLength;
        public ActorSwingAffineTransform initialSelfTx;
        public ActorSwingAffineTransform selfEndTx;
        public ActorSwingAffineTransform localEndTx;
        public ActorSwingAffineTransform modelingLocalTx;
        public float3 childSpeed;
        public ReadWriteTransformHandle breast;
        public ReadOnlyTransformHandle lowerArm;
        public ActorSwingJobBreastBoneSetting(ReadOnlyTransformHandle lowerArm, ReadWriteTransformHandle breast, ActorSwingAffineTransform initialSelfTx, ActorSwingAffineTransform localEndTx, ActorSwingAffineTransform selfEndTx, ActorSwingAffineTransform modelingLocalTx)
        {
            this.lowerArm = lowerArm;
            this.breast = breast;
            this.initialSelfTx = initialSelfTx;
            this.localEndTx = localEndTx;
            this.selfEndTx = selfEndTx;
            this.modelingLocalTx = modelingLocalTx;
            boneEndAxis = math.normalize(localEndTx.translation);
            boneEndLength = 0f;
            childSpeed = default;
        }
    }
}
