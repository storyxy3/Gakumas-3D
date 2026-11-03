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
            return default(ActorAnimationManageProperty);
        }

        public ActorAnimationManagePropertyData Get(AnimationStream stream)
        {
            return default(ActorAnimationManagePropertyData);
        }
    }
}
