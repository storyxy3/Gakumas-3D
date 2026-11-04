namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverFrillSetting
    {
        public math.RotationOrder rotationOrder;
        public float3 outerMinusCoefficient;
        public float3 innerCoefficient;
        public float3 outerPlusCoefficient;
        public float3 switchMinus;
        public float3 switchPlus;
        public math.RotationOrder connectionAxis;
        public ActorAnimationQuartzDriverRotationDecomposeType decomposeType;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public GameObject referenceBone;
        public ActorAnimationQuartzDriverFrillSetting ConvertToUnity()
        {
            innerCoefficient[0] = -innerCoefficient[0];
            outerMinusCoefficient[0] = -outerMinusCoefficient[0];
            outerPlusCoefficient[0] = -outerPlusCoefficient[0];
            innerCoefficient[1] = -innerCoefficient[1];
            float outerMinusCoefficient1 = -outerPlusCoefficient[1];
            float outerPlusCoefficient1 = -outerMinusCoefficient[1];
            outerMinusCoefficient[1] = outerMinusCoefficient1;
            outerPlusCoefficient[1] = outerPlusCoefficient1;
            float switchMinus1 = -switchPlus[1];
            float switchPlus1 = -switchMinus[1];
            switchMinus[1] = switchMinus1;
            switchPlus[1] = switchPlus1;
            innerCoefficient[2] = -innerCoefficient[2];
            float outerMinusCoefficient2 = -outerPlusCoefficient[2];
            float outerPlusCoefficient2 = -outerMinusCoefficient[2];
            outerMinusCoefficient[2] = outerMinusCoefficient2;
            outerPlusCoefficient[2] = outerPlusCoefficient2;
            float switchMinus2 = -switchPlus[2];
            float switchPlus2 = -switchMinus[2];
            switchMinus[2] = switchMinus2;
            switchPlus[2] = switchPlus2;
            return this;
        }

        public ActorAnimationQuartzDriverFrillSetting()
        {
        }
    }
}
