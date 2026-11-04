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
            if (referenceBone.name.Contains("Left"))
            {
                float minimum = -limitMax[1];
                float maximum = -limitMin[1];
                limitMin[1] = minimum;
                limitMax[1] = maximum;
                innerCoefficient[1] = -innerCoefficient[1];
                outerCoefficient[1] = -outerCoefficient[1];
            }
            innerCoefficient[2] = -innerCoefficient[2];
            outerCoefficient[2] = -outerCoefficient[2];
            float minZ = -limitMax[2];
            float maxZ = -limitMin[2];
            limitMin[2] = minZ;
            limitMax[2] = maxZ;
            return this;
        }

        public ActorAnimationQuartzDriverSkirtSetting()
        {
        }
    }
}
