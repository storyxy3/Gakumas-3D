namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidHandSetting
    {
        public static readonly ArmDof ArmDof = (ArmDof)6;
        public static readonly float MuscleConvertCoefficient = -66f;
        public HumanPartDof humanPartDof;
        public float coefficient;
        public ActorAnimationQuartzDriverHumanoidHandSetting()
        {
        }
    }
}
