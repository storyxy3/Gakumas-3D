namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorSwingJobSeatDynamicCorrection
    {
        public bool enableSeatedDynamicCorrection;
        public ReadOnlyTransformHandle leftUpLeg;
        public ReadOnlyTransformHandle leftLeg;
        public ReadOnlyTransformHandle leftFoot;
        public ReadOnlyTransformHandle rightUpLeg;
        public ReadOnlyTransformHandle rightLeg;
        public ReadOnlyTransformHandle rightFoot;
    }
}
