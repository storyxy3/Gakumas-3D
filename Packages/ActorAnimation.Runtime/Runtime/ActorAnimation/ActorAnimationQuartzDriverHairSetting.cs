namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHairSetting
    {
        public math.RotationOrder translateConnectionAxis;
        public float3 headTranslateCoefficient;
        public float3 headTranslateLimitMin;
        public float3 headTranslateLimitMax;
        public math.RotationOrder rotationOrder;
        public float3 headRotateCoefficient;
        public float3 headRotateLimitMin;
        public float3 headRotateLimitMax;
        public math.RotationOrder rotateConnectionAxis;
        public float3 neckRotateCoefficient;
        public float3 neckRotateLimitMin;
        public float3 neckRotateLimitMax;
        public GameObject referenceHeadBone;
        public GameObject referenceNeckBone;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public ActorAnimationQuartzDriverHairSetting ConvertToUnity()
        {
            return null;
        }

        public ActorAnimationQuartzDriverHairSetting()
        {
        }
    }
}
