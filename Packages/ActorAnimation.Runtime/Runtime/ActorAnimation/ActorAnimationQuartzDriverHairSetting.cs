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
            headTranslateCoefficient *= 0.01f;
            headTranslateCoefficient[2] = -headTranslateCoefficient[2];
            float headTranslateMin1 = -headTranslateLimitMax[1];
            float headTranslateMax1 = -headTranslateLimitMin[1];
            headTranslateLimitMin[1] = headTranslateMin1;
            headTranslateLimitMax[1] = headTranslateMax1;
            float headTranslateMin2 = -headTranslateLimitMax[2];
            float headTranslateMax2 = -headTranslateLimitMin[2];
            headTranslateLimitMin[2] = headTranslateMin2;
            headTranslateLimitMax[2] = headTranslateMax2;
            headRotateCoefficient = -headRotateCoefficient;
            float headRotateMin1 = -headRotateLimitMax[1];
            float headRotateMax1 = -headRotateLimitMin[1];
            headRotateLimitMin[1] = headRotateMin1;
            headRotateLimitMax[1] = headRotateMax1;
            float headRotateMin2 = -headRotateLimitMax[2];
            float headRotateMax2 = -headRotateLimitMin[2];
            headRotateLimitMin[2] = headRotateMin2;
            headRotateLimitMax[2] = headRotateMax2;
            neckRotateCoefficient = -neckRotateCoefficient;
            float neckRotateMin1 = -neckRotateLimitMax[1];
            float neckRotateMax1 = -neckRotateLimitMin[1];
            neckRotateLimitMin[1] = neckRotateMin1;
            neckRotateLimitMax[1] = neckRotateMax1;
            float neckRotateMin2 = -neckRotateLimitMax[2];
            float neckRotateMax2 = -neckRotateLimitMin[2];
            neckRotateLimitMin[2] = neckRotateMin2;
            neckRotateLimitMax[2] = neckRotateMax2;
            return this;
        }

        public ActorAnimationQuartzDriverHairSetting()
        {
        }
    }
}
