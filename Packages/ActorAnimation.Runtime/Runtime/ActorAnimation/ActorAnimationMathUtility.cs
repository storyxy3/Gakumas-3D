// TODO(qa-recon): Selected APK bodies still need reconstruction: AxisrotationToEuler, AxisrotationToQuaternionWithBendRoll, AxisrotationToQuaternionWithMatrix, AxisrotationToQuaternionWithRollBend, EulerToBendroll, EulerToBendrollQuaternionInverse, EulerToBendrollQuaternionInverseYRoll, EulerToBendrollYRoll, FromToRotation.
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
            return math.clamp(degree, minLimit, maxLimit) * coef;
        }

        public static float DualCoefficientConversion(float degree, float innerCoef, float outerCoef, float minLimit, float maxLimit)
        {
            return (innerCoef - outerCoef) * math.clamp(degree, minLimit, maxLimit);
        }

        public static float TripleCoefficientConversion(float degree, float outerMinusCoef, float innerCoef, float outerPlusCoef, float switchMinus, float switchPlus)
        {
            return default(float);
        }

        public static float3 ExchangeArrayFromAxisConnection(float inX, float inY, float inZ, math.RotationOrder axisConnection)
        {
            float x = inX;
            if ((byte)axisConnection >= 2) x = (byte)axisConnection < 4 ? inY : inZ;
            float y;
            switch ((byte)axisConnection)
            {
                case 0: case 5: y = inY; break;
                case 2: case 4: y = inX; break;
                default: y = inZ; break;
            }
            float z;
            switch ((byte)axisConnection)
            {
                case 1: case 4: z = inY; break;
                case 3: case 5: z = inX; break;
                default: z = inZ; break;
            }
            return new float3(x, y, z);
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
            if (degree > 180f) return degree - 360f;
            if (degree < -180f) return degree + 360f;
            return degree;
        }

        public static float3 ToEuler(quaternion q, math.RotationOrder rotSeq)
        {
            float x = q.value.x, y = q.value.y, z = q.value.z, w = q.value.w;
            switch (rotSeq)
            {
                case math.RotationOrder.XYZ:
                    return ThreeAxisRot(-2f*(y*z+w*x), z*z+((w*w-x*x)-y*y), 2f*(x*z-w*y), -2f*(x*y+w*z), ((w*w+x*x)-y*y)-z*z);
                case math.RotationOrder.XZY:
                    return ThreeAxisRot(2f*(y*z-w*x), (y*y+(w*w-x*x))-z*z, -2f*(x*y+w*z), 2f*(x*z-w*y), ((w*w+x*x)-y*y)-z*z);
                case math.RotationOrder.YXZ:
                    return ThreeAxisRot(2f*(x*z-w*y), z*z+((w*w-x*x)-y*y), -2f*(y*z+w*x), 2f*(x*y-w*z), (y*y+(w*w-x*x))-z*z);
                case math.RotationOrder.YZX:
                    return ThreeAxisRot(-2f*(x*z+w*y), ((w*w+x*x)-y*y)-z*z, 2f*(x*y-w*z), -2f*(y*z+w*x), (y*y+(w*w-x*x))-z*z);
                case math.RotationOrder.ZXY:
                    return ThreeAxisRot(-2f*(x*y+w*z), (y*y+(w*w-x*x))-z*z, 2f*(y*z-w*x), -2f*(x*z+w*y), z*z+((w*w-x*x)-y*y));
                case math.RotationOrder.ZYX:
                    return ThreeAxisRot(2f*(x*y-w*z), ((w*w+x*x)-y*y)-z*z, -2f*(x*z+w*y), 2f*(y*z-w*x), z*z+((w*w-x*x)-y*y));
                default: return float3.zero;
            }
        }

        private static float3 ThreeAxisRot(float r11, float r12, float r21, float r31, float r32)
        {
            return new float3(-math.atan2(r31, r32), -math.asin(r21), -math.atan2(r11, r12));
        }

        [MethodImpl(256)]
        public static float3 ToUnityEuler(quaternion q)
        {
            return default(float3);
        }

        public static quaternion ToUnityQuaternion(float3 euler)
        {
            float3 half = euler * 0.017453292f * 0.5f;
            float3 s = math.sin(half);
            float3 c = math.cos(half);
            return new quaternion(
                s.y * s.z * c.x + s.x * c.y * c.z,
                s.y * c.x * c.z - s.z * s.x * c.y,
                s.z * c.x * c.y - s.y * s.x * c.z,
                s.x * (s.y * s.z) + c.x * c.y * c.z);
        }

        public static quaternion ToQuaternion(float3 euler, math.RotationOrder rotSeq)
        {
            if ((byte)rotSeq > 5) return quaternion.identity;

            float3 half = euler * 0.017453292f * 0.5f;
            float3 s = math.sin(half);
            float3 c = math.cos(half);

            switch (rotSeq)
            {
                case math.RotationOrder.XYZ:
                    return new quaternion(s.x*c.y*c.z - s.y*s.z*c.x, s.x*s.z*c.y + s.y*c.x*c.z, s.z*c.x*c.y - s.y*s.x*c.z, s.x*(s.y*s.z) + c.x*c.y*c.z);
                case math.RotationOrder.XZY:
                    return new quaternion(s.y*s.z*c.x + s.x*c.y*c.z, s.x*s.z*c.y + s.y*c.x*c.z, s.z*c.x*c.y - s.y*s.x*c.z, c.x*c.y*c.z - s.x*(s.y*s.z));
                case math.RotationOrder.YXZ:
                    return new quaternion(s.x*c.y*c.z - s.y*s.z*c.x, s.x*s.z*c.y + s.y*c.x*c.z, s.x*s.y*c.z + s.z*c.x*c.y, c.x*c.y*c.z - s.x*(s.y*s.z));
                case math.RotationOrder.YZX:
                    return new quaternion(s.x*c.y*c.z - s.y*s.z*c.x, s.y*c.x*c.z - s.z*s.x*c.y, s.x*s.y*c.z + s.z*c.x*c.y, s.x*(s.y*s.z) + c.x*c.y*c.z);
                case math.RotationOrder.ZXY:
                    return new quaternion(s.y*s.z*c.x + s.x*c.y*c.z, s.y*c.x*c.z - s.z*s.x*c.y, s.z*c.x*c.y - s.y*s.x*c.z, s.x*(s.y*s.z) + c.x*c.y*c.z);
                case math.RotationOrder.ZYX:
                    return new quaternion(s.y*s.z*c.x + s.x*c.y*c.z, s.y*c.x*c.z - s.z*s.x*c.y, s.x*s.y*c.z + s.z*c.x*c.y, c.x*c.y*c.z - s.x*(s.y*s.z));
                default: return quaternion.identity;
            }
        }

        public static quaternion FromToRotation(float3 from, float3 to)
        {
            return default(quaternion);
        }
    }
}
