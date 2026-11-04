namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverHumanoidArmSetting
    {
        public static readonly ArmDof ArmDof = (ArmDof)4;
        public static readonly float MuscleConvertCoefficient = -90f;
        public HumanPartDof humanPartDof;
        public float coefficient;
        public ActorAnimationQuartzDriverHumanoidArmSetting()
        {
        }
    }
}
