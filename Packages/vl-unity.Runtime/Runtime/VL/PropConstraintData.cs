namespace VL
{
    using global::System;
    using global::ActorAnimation;

    [Serializable]
    public class PropConstraintData
    {
        public string prop;
        public bool isAdaptScale;
        public bool isFieldConstraint;
        public string[] constraintTargets;
        public ActorAnimationConstraintExecuteType executeType;
    }
}
