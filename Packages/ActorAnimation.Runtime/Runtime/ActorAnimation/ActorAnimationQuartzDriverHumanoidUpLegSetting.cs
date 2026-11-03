namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidUpLegSetting
    {
        public static readonly LegDof LegDof;
        public static readonly float MuscleConvertCoefficient;
        public HumanPartDof humanPartDof;
        public float coefficient;
        public ActorAnimationQuartzDriverHumanoidUpLegSetting()
        {
        }
    }
}
