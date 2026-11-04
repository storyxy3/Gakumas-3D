namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    public static class ActorAnimationWindUtility
    {
        public static float3 CalcWindPower(float3 jointWorldPosition, ref ActorAnimationManagePropertyData managePropertyData, float time)
        {
            float3 power = float3.zero;
            power += managePropertyData.globalForce;
            power += managePropertyData.windWaveAmplitude * 0.01f
                * math.sin((managePropertyData.windWaveFrequency * time + managePropertyData.windWavePhase) * (2f * math.PI));
            power += managePropertyData.windPower
                * ((noise.cnoise(jointWorldPosition * managePropertyData.windFluctuation * time) * 0.5f + 0.5f) * 0.01f);
            power = math.max(power - managePropertyData.windRangeMin * 0.01f, 0f)
                * (math.sin((managePropertyData.windRangeFrequency * time + managePropertyData.windRangePhase) * (2f * math.PI)) + 1f)
                + managePropertyData.windRangeMin * 0.01f;
            power = math.min(power, managePropertyData.windRangeMax * 0.01f);
            power += noise.cnoise(jointWorldPosition * managePropertyData.randomFluctuation * time) * 0.01f * managePropertyData.randomPower;
            return managePropertyData.windDirection * power;
        }
    }
}
