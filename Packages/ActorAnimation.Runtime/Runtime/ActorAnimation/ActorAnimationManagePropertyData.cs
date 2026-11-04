namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorAnimationManagePropertyData
    {
        public float weight;
        public float modelingPoseWeight;
        public float swingPowerWeight;
        public float swingBreastPowerWeight;
        public float swingBreastCorrectionPowerWeight;
        public float rootWeight;
        public float rootHorizontalWeight;
        public float rootVerticalWeight;
        public float3 globalForce;
        public float3 windDirection;
        public float windPower;
        public float windFluctuation;
        public float windWaveAmplitude;
        public float windWaveFrequency;
        public float windWavePhase;
        public float windRangeMax;
        public float windRangeMin;
        public float windRangeFrequency;
        public float windRangePhase;
        public float randomPower;
        public float randomFluctuation;
        public int prewarmCount;
        public ActorAnimationManagePropertyData(float weight, float modelingPoseWeight, float swingPowerWeight, float swingBreastPowerWeight, float swingBreastCorrectionPowerWeight, float rootWeight, float rootHorizontalWeight, float rootVerticalWeight, float3 globalForce, float3 windDirection, float windPower, float windFluctuation, float windWaveAmplitude, float windWaveFrequency, float windWavePhase, float windRangeMax, float windRangeMin, float windRangeFrequency, float windRangePhase, float randomPower, float randomFluctuation, int prewarmCount)
        {
            this.weight = weight;
            this.modelingPoseWeight = modelingPoseWeight;
            this.swingPowerWeight = swingPowerWeight;
            this.swingBreastPowerWeight = swingBreastPowerWeight;
            this.swingBreastCorrectionPowerWeight = swingBreastCorrectionPowerWeight;
            this.rootWeight = rootWeight;
            this.rootHorizontalWeight = rootHorizontalWeight;
            this.rootVerticalWeight = rootVerticalWeight;
            this.globalForce = globalForce;
            this.windDirection = windDirection;
            this.windPower = windPower;
            this.windFluctuation = windFluctuation;
            this.windWaveAmplitude = windWaveAmplitude;
            this.windWaveFrequency = windWaveFrequency;
            this.windWavePhase = windWavePhase;
            this.windRangeMax = windRangeMax;
            this.windRangeMin = windRangeMin;
            this.windRangeFrequency = windRangeFrequency;
            this.windRangePhase = windRangePhase;
            this.randomPower = randomPower;
            this.randomFluctuation = randomFluctuation;
            this.prewarmCount = prewarmCount;
        }
    }
}
