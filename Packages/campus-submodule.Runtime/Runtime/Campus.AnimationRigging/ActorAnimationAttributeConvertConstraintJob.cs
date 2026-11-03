namespace Campus.AnimationRigging
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Burst;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [BurstCompile]
    public struct ActorAnimationAttributeConvertConstraintJob : IWeightedAnimationJob, IAnimationJob
    {
        public ReadWriteTransformHandle Source;
        public ReadWriteTransformHandle Target;
        public IntProperty SourceAttribute;
        public IntProperty ConnectionAxis;
        public IntProperty WeightCalcType;
        public IntProperty TargetAttribute;
        public Vector3Property Weight;
        public Vector3Property Offset;
        public Vector3Property Min;
        public Vector3Property Max;
        public Vector3 InitialTranslate;
        public Vector3 InitialRotate;
        public Vector3 InitialScale;
        [CompilerGenerated]
        private FloatProperty _003CjobWeight_003Ek__BackingField;
        public FloatProperty jobWeight
        {
            [CompilerGenerated]
            readonly get
            {
                return default(FloatProperty);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }

        public void ProcessAnimation(AnimationStream stream)
        {
        }
    }
}
