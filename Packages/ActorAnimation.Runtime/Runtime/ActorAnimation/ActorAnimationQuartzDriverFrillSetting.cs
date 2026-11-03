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
            return null;
        }

        public ActorAnimationQuartzDriverFrillSetting()
        {
        }
    }
}
