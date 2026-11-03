namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidHandSetting
    {
        public static readonly ArmDof ArmDof;
        public static readonly float MuscleConvertCoefficient;
        public HumanPartDof humanPartDof;
        public float coefficient;
        public ActorAnimationQuartzDriverHumanoidHandSetting()
        {
        }
    }
}
