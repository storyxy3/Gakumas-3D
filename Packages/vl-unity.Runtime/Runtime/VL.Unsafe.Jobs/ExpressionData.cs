namespace VL.Unsafe.Jobs
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;

    [Serializable]
    public struct ExpressionData
    {
        public const int TYPE_TRANSFORM_POSITION = 0;
        public const int TYPE_TRANSFORM_ROTATION = 1;
        public const int TYPE_TRANSFORM_POSITION_DELTA = 2;
        public const int TYPE_CALC_MUL = 0;
        public TransformStreamHandle outputHandle;
        public TransformStreamHandle targetHandle;
        public TransformStreamHandle outputSubHandle;
        public TransformStreamHandle targetSubHandle;
        public float3 initTargetPosition;
        public int outputTransformType;
        public int transformType;
        public int useLisp;
        public int axisMaskType;
        public int calcType;
        public float3 coefficient;
        public float3 min;
        public float3 max;
        public int3 axisType;
        public math.RotationOrder rotationOrder;
        public quaternion initTargetRotation;
        public quaternion initOutputRotation;
    }
}
