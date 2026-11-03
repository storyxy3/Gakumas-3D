namespace ActorAnimation
{
    using global::System;
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
        }
    }
}
