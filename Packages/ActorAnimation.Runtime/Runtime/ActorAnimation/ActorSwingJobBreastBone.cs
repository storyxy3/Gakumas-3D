namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;
    using global::ActorAnimation;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorSwingJobBreastBone
    {
        public ActorSwingJobBreastBoneSetting leftBreastSetting;
        public ActorSwingJobBreastBoneSetting rightBreastSetting;
        public ReadOnlyTransformHandle driven;
        public float damping;
        public float stiffness;
        public float spring;
        public float pendulum;
        public float pendulumRange;
        public float average;
        public ActorSwingJobLimitInfo limit;
        public float rootWeight;
        public bool useArmCorrection;
        public int prewarmCount;
        public void Reset(InitialTransform initialLeftBreastEndTransform, InitialTransform initialRightBreastEndTransform, int prewarmCount)
        {
            leftBreastSetting.boneEndAxis = math.normalize((float3)initialLeftBreastEndTransform.localPosition);
            leftBreastSetting.boneEndLength = math.length((float3)initialLeftBreastEndTransform.localPosition);
            leftBreastSetting.localEndTx = new ActorSwingAffineTransform(initialLeftBreastEndTransform.localPosition, initialLeftBreastEndTransform.localRotation);
            leftBreastSetting.selfEndTx = new ActorSwingAffineTransform(initialLeftBreastEndTransform.position, initialLeftBreastEndTransform.rotation);
            rightBreastSetting.boneEndAxis = math.normalize((float3)initialRightBreastEndTransform.localPosition);
            rightBreastSetting.boneEndLength = math.length((float3)initialRightBreastEndTransform.localPosition);
            rightBreastSetting.localEndTx = new ActorSwingAffineTransform(initialRightBreastEndTransform.localPosition, initialRightBreastEndTransform.localRotation);
            rightBreastSetting.selfEndTx = new ActorSwingAffineTransform(initialRightBreastEndTransform.position, initialRightBreastEndTransform.rotation);
            this.prewarmCount = prewarmCount;
        }
    }
}
