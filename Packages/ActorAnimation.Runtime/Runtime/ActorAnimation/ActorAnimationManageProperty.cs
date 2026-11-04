namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public struct ActorAnimationManageProperty
    {
        public PropertySceneHandle weight;
        public PropertySceneHandle modelingPoseWeight;
        public PropertySceneHandle swingPowerWeight;
        public PropertySceneHandle swingBreastPowerWeight;
        public PropertySceneHandle swingBreastCorrectionPowerWeight;
        public PropertySceneHandle rootWeight;
        public PropertySceneHandle rootHorizontalWeight;
        public PropertySceneHandle rootVerticalWeight;
        public PropertySceneHandle globalForceX;
        public PropertySceneHandle globalForceY;
        public PropertySceneHandle globalForceZ;
        public PropertySceneHandle windDirectionX;
        public PropertySceneHandle windDirectionY;
        public PropertySceneHandle windDirectionZ;
        public PropertySceneHandle windPower;
        public PropertySceneHandle windFluctuation;
        public PropertySceneHandle windWaveAmplitude;
        public PropertySceneHandle windWaveFrequency;
        public PropertySceneHandle windWavePhase;
        public PropertySceneHandle windRangeMax;
        public PropertySceneHandle windRangeMin;
        public PropertySceneHandle windRangeFrequency;
        public PropertySceneHandle windRangePhase;
        public PropertySceneHandle randomPower;
        public PropertySceneHandle randomFluctuation;
        public PropertySceneHandle prewarmCount;
        public bool valid;
        public static ActorAnimationManageProperty Bind(Animator animator, ActorAnimationManageData data)
        {
            var type = data.GetType();
            return new ActorAnimationManageProperty
            {
                weight = animator.BindSceneProperty(data.transform, type, "propertyData.weight"),
                modelingPoseWeight = animator.BindSceneProperty(data.transform, type, "propertyData.modelingPoseWeight"),
                swingPowerWeight = animator.BindSceneProperty(data.transform, type, "propertyData.swingPowerWeight"),
                swingBreastPowerWeight = animator.BindSceneProperty(data.transform, type, "propertyData.swingBreastPowerWeight"),
                swingBreastCorrectionPowerWeight = animator.BindSceneProperty(data.transform, type, "propertyData.swingBreastCorrectionPowerWeight"),
                rootWeight = animator.BindSceneProperty(data.transform, type, "propertyData.rootWeight"),
                rootHorizontalWeight = animator.BindSceneProperty(data.transform, type, "propertyData.rootHorizontalWeight"),
                rootVerticalWeight = animator.BindSceneProperty(data.transform, type, "propertyData.rootVerticalWeight"),
                globalForceX = animator.BindSceneProperty(data.transform, type, "propertyData.globalForce.x"),
                globalForceY = animator.BindSceneProperty(data.transform, type, "propertyData.globalForce.y"),
                globalForceZ = animator.BindSceneProperty(data.transform, type, "propertyData.globalForce.z"),
                windDirectionX = animator.BindSceneProperty(data.transform, type, "propertyData.windDirection.x"),
                windDirectionY = animator.BindSceneProperty(data.transform, type, "propertyData.windDirection.y"),
                windDirectionZ = animator.BindSceneProperty(data.transform, type, "propertyData.windDirection.z"),
                windPower = animator.BindSceneProperty(data.transform, type, "propertyData.windPower"),
                windFluctuation = animator.BindSceneProperty(data.transform, type, "propertyData.windFluctuation"),
                windWaveAmplitude = animator.BindSceneProperty(data.transform, type, "propertyData.windWaveAmplitude"),
                windWaveFrequency = animator.BindSceneProperty(data.transform, type, "propertyData.windWaveFrequency"),
                windWavePhase = animator.BindSceneProperty(data.transform, type, "propertyData.windWavePhase"),
                windRangeMax = animator.BindSceneProperty(data.transform, type, "propertyData.windRangeMax"),
                windRangeMin = animator.BindSceneProperty(data.transform, type, "propertyData.windRangeMin"),
                windRangeFrequency = animator.BindSceneProperty(data.transform, type, "propertyData.windRangeFrequency"),
                windRangePhase = animator.BindSceneProperty(data.transform, type, "propertyData.windRangePhase"),
                randomPower = animator.BindSceneProperty(data.transform, type, "propertyData.randomPower"),
                randomFluctuation = animator.BindSceneProperty(data.transform, type, "propertyData.randomFluctuation"),
                prewarmCount = animator.BindSceneProperty(data.transform, type, "propertyData.prewarmCount"),
                valid = true
            };
        }

        public ActorAnimationManagePropertyData Get(AnimationStream stream)
        {
            if (!valid)
                return new ActorAnimationManagePropertyData(1f, 0f, 1f, 1f, 1f, 1f, 1f, 1f, global::Unity.Mathematics.float3.zero, global::Unity.Mathematics.float3.zero, 0f, 0f, 0f, 1f, 0f, 10f, -10f, 0f, 0f, 0f, 0f, 30);
            return new ActorAnimationManagePropertyData(
                weight.GetFloat(stream),
                modelingPoseWeight.GetFloat(stream),
                swingPowerWeight.GetFloat(stream),
                swingBreastPowerWeight.GetFloat(stream),
                swingBreastCorrectionPowerWeight.GetFloat(stream),
                rootWeight.GetFloat(stream),
                rootHorizontalWeight.GetFloat(stream),
                rootVerticalWeight.GetFloat(stream),
                new global::Unity.Mathematics.float3(globalForceX.GetFloat(stream), globalForceY.GetFloat(stream), globalForceZ.GetFloat(stream)),
                new global::Unity.Mathematics.float3(windDirectionX.GetFloat(stream), windDirectionY.GetFloat(stream), windDirectionZ.GetFloat(stream)),
                windPower.GetFloat(stream),
                windFluctuation.GetFloat(stream),
                windWaveAmplitude.GetFloat(stream),
                windWaveFrequency.GetFloat(stream),
                windWavePhase.GetFloat(stream),
                windRangeMax.GetFloat(stream),
                windRangeMin.GetFloat(stream),
                windRangeFrequency.GetFloat(stream),
                windRangePhase.GetFloat(stream),
                randomPower.GetFloat(stream),
                randomFluctuation.GetFloat(stream),
                prewarmCount.GetInt(stream));
        }
    }
}
