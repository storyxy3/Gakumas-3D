namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverSkirtSetting
    {
        public math.RotationOrder rotationOrder;
        public float3 innerCoefficient;
        public float3 outerCoefficient;
        public float3 limitMin;
        public float3 limitMax;
        public math.RotationOrder connectionAxis;
        public GameObject referenceBone;
        public ActorAnimationQuartzDriverSkirtSetting ConvertToUnity()
        {
            return null;
        }

        public ActorAnimationQuartzDriverSkirtSetting()
        {
        }
    }
}
