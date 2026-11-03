namespace VL.Unsafe.Jobs
{
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;

    public struct MuscleExpressionData
    {
        public TransformStreamHandle outputHandle;
        public MuscleHandle targetHandle;
        public int transformType;
        public float coefficient;
        public int axisType;
        public math.RotationOrder rotationOrder;
    }
}
