namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    public static class ActorAnimationMathUtility
    {
        public static float3 AxisrotationToEuler(float roll, float pitch, float yaw)
        {
            return default(float3);
        }

        public static quaternion AxisrotationToQuaternionWithBendRoll(float roll, float pitch, float yaw)
        {
            return default(quaternion);
        }

        public static Quaternion AxisrotationToQuaternionWithRollBend(float roll, float pitch, float yaw)
        {
            return default(Quaternion);
        }

        public static quaternion AxisrotationToQuaternionWithMatrix(float roll, float pitch, float yaw)
        {
            return default(quaternion);
        }

        public static float SingleCoefficientConversion(float degree, float coef, float minLimit, float maxLimit)
        {
            return default(float);
        }

        public static float DualCoefficientConversion(float degree, float innerCoef, float outerCoef, float minLimit, float maxLimit)
        {
            return default(float);
        }

        public static float TripleCoefficientConversion(float degree, float outerMinusCoef, float innerCoef, float outerPlusCoef, float switchMinus, float switchPlus)
        {
            return default(float);
        }

        public static float3 ExchangeArrayFromAxisConnection(float inX, float inY, float inZ, math.RotationOrder axisConnection)
        {
            return default(float3);
        }

        public static float3 EulerToBendroll(float3 euler)
        {
            return default(float3);
        }

        public static float3 EulerToBendrollYRoll(float3 euler)
        {
            return default(float3);
        }

        public static float3 EulerToBendrollZRoll(float3 euler)
        {
            return default(float3);
        }

        public static float3 EulerToBendrollQuaternionInverse(float3 euler)
        {
            return default(float3);
        }

        public static float3 EulerToBendrollQuaternionInverseYRoll(float3 euler, math.RotationOrder rotationOrder)
        {
            return default(float3);
        }

        public static float FormatRangeDegree(float degree)
        {
            return default(float);
        }

        public static float3 ToEuler(quaternion q, math.RotationOrder rotSeq)
        {
            return default(float3);
        }

        private static float3 ThreeAxisRot(float r11, float r12, float r21, float r31, float r32)
        {
            return default(float3);
        }

        [MethodImpl(256)]
        public static float3 ToUnityEuler(quaternion q)
        {
            return default(float3);
        }

        public static quaternion ToUnityQuaternion(float3 euler)
        {
            return default(quaternion);
        }

        public static quaternion ToQuaternion(float3 euler, math.RotationOrder rotSeq)
        {
            return default(quaternion);
        }

        public static quaternion FromToRotation(float3 from, float3 to)
        {
            return default(quaternion);
        }
    }
}
