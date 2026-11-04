namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidUpLegSetting
    {
        public static readonly LegDof LegDof = (LegDof)2;
        public static readonly float MuscleConvertCoefficient = -60f;
        public HumanPartDof humanPartDof;
        public float coefficient;
        public ActorAnimationQuartzDriverHumanoidUpLegSetting()
        {
        }
    }
}
