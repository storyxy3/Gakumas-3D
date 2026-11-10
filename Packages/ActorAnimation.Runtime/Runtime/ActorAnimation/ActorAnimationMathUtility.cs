namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    public static class ActorAnimationMathUtility
    {
        public static float3 AxisrotationToEuler(float roll, float pitch, float yaw)
        {
            var x = Matrix4x4.identity;
            x.m00 = 1f;
            x.m11 = math.cos(roll);
            x.m12 = -math.sin(roll);
            x.m21 = math.sin(roll);
            x.m22 = math.cos(roll);
            var y = Matrix4x4.identity;
            y.m00 = math.cos(pitch);
            y.m02 = math.sin(pitch);
            y.m11 = 1f;
            y.m20 = -math.sin(pitch);
            y.m22 = math.cos(pitch);
            var z = Matrix4x4.identity;
            z.m00 = math.cos(yaw);
            z.m01 = -math.sin(yaw);
            z.m10 = math.sin(yaw);
            z.m11 = math.cos(yaw);
            z.m22 = 1f;
            var matrix = z * y * x;
            float rollAngle = math.atan2(matrix[9], matrix[10]);
            float pitchAngle = math.asin(-matrix[8]);
            float yawAngle = math.atan2(matrix[4], matrix[0]);
            return new float3(rollAngle, pitchAngle, yawAngle) * 57.29578f;
        }

        public static quaternion AxisrotationToQuaternionWithBendRoll(float roll, float pitch, float yaw)
        {
            float pitchTangent = math.tan(pitch * 0.5f);
            float yawTangent = math.tan(yaw * -0.5f);
            float scale = 2f / (pitchTangent * pitchTangent + yawTangent * yawTangent + 1f);
            var bendRotation = FromToRotation(new float3(1f, 0f, 0f), new float3(scale - 1f, scale * yawTangent, scale * pitchTangent));
            var rollRotation = ToUnityQuaternion(new float3(roll * -57.29578f, 0f, 0f));
            return math.mul(rollRotation, bendRotation);
        }

        public static Quaternion AxisrotationToQuaternionWithRollBend(float roll, float pitch, float yaw)
        {
            float pitchTangent = math.tan(pitch * 0.5f);
            float yawTangent = math.tan(yaw * -0.5f);
            float scale = 2f / (pitchTangent * pitchTangent + yawTangent * yawTangent + 1f);
            var bendRotation = FromToRotation(new float3(1f, 0f, 0f), new float3(scale - 1f, scale * yawTangent, scale * pitchTangent));
            var rollRotation = ToUnityQuaternion(new float3(roll * -57.29578f, 0f, 0f));
            return math.mul(bendRotation, rollRotation);
        }

        public static quaternion AxisrotationToQuaternionWithMatrix(float roll, float pitch, float yaw)
        {
            var x = Matrix4x4.identity;
            x.m00 = 1f;
            x.m11 = math.cos(roll);
            x.m12 = -math.sin(roll);
            x.m21 = math.sin(roll);
            x.m22 = math.cos(roll);
            var y = Matrix4x4.identity;
            y.m00 = math.cos(pitch);
            y.m02 = math.sin(pitch);
            y.m11 = 1f;
            y.m20 = -math.sin(pitch);
            y.m22 = math.cos(pitch);
            var z = Matrix4x4.identity;
            z.m00 = math.cos(yaw);
            z.m01 = -math.sin(yaw);
            z.m10 = math.sin(yaw);
            z.m11 = math.cos(yaw);
            z.m22 = 1f;
            var matrix = z * y * x;
            return matrix.rotation;
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
            return degree * innerCoef + math.min(degree - switchMinus, 0f) * outerMinusCoef + math.max(degree - switchPlus, 0f) * outerPlusCoef;
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
            var direction = math.mul(ToUnityQuaternion(euler), new float3(1f, 0f, 0f));
            float pitch = -2f * math.atan2(direction.z, direction.x + 1f);
            float yaw = 2f * math.atan2(direction.y, direction.x + 1f);
            return new float3(euler.x, pitch * 57.29578f, yaw * 57.29578f);
        }

        public static float3 EulerToBendrollYRoll(float3 euler)
        {
            var direction = math.mul(ToQuaternion(euler, math.RotationOrder.YXZ), new float3(0f, 1f, 0f));
            float pitch = 2f * math.atan2(direction.z, direction.y + 1f);
            float yaw = -2f * math.atan2(direction.x, direction.y + 1f);
            return new float3(euler.y, pitch * 57.29578f, yaw * 57.29578f);
        }

        public static float3 EulerToBendrollZRoll(float3 euler)
        {
            var direction = math.mul(ToQuaternion(euler, math.RotationOrder.YXZ), new float3(0f, 0f, 1f));
            float pitch = -2f * math.atan2(direction.x, direction.z + 1f);
            float yaw = 2f * math.atan2(direction.y, direction.z + 1f);
            return new float3(euler.z, pitch * 57.29578f, yaw * 57.29578f);
        }

        public static float3 EulerToBendrollQuaternionInverse(float3 euler)
        {
            var direction = math.mul(ToUnityQuaternion(euler), new float3(1f, 0f, 0f));
            float pitch = -2f * math.atan2(direction.z, direction.x + 1f);
            float yaw = 2f * math.atan2(direction.y, direction.x + 1f);
            Quaternion twist = math.mul(ToUnityQuaternion(euler), math.inverse(FromToRotation(new float3(1f, 0f, 0f), direction)));
            twist.ToAngleAxis(out float angle, out Vector3 twistAxis);
            float roll = angle * 0.017453292f;
            if (math.dot((float3)twistAxis, direction) < 0f) roll = -roll;
            return new float3(roll, pitch, yaw) * 57.29578f;
        }

        public static float3 EulerToBendrollQuaternionInverseYRoll(float3 euler, math.RotationOrder rotationOrder)
        {
            var direction = math.mul(ToQuaternion(euler, rotationOrder), new float3(0f, 1f, 0f));
            float pitch = 2f * math.atan2(direction.z, direction.y + 1f);
            float yaw = -2f * math.atan2(direction.x, direction.y + 1f);
            Quaternion twist = math.mul(ToUnityQuaternion(euler), math.inverse(FromToRotation(new float3(0f, 1f, 0f), direction)));
            twist.ToAngleAxis(out float angle, out Vector3 twistAxis);
            float roll = angle * 0.017453292f;
            if (math.dot((float3)twistAxis, direction) < 0f) roll = -roll;
            return new float3(roll, pitch, yaw) * 57.29578f;
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
            // APK 3.5.3 0x657cb30: reorder ThreeAxisRot output into XYZ components.
            switch (rotSeq)
            {
                case math.RotationOrder.XYZ:
                    return ThreeAxisRot(-2f*(y*z+w*x), z*z+((w*w-x*x)-y*y), 2f*(x*z-w*y), -2f*(x*y+w*z), ((w*w+x*x)-y*y)-z*z).zyx;
                case math.RotationOrder.XZY:
                    return ThreeAxisRot(2f*(y*z-w*x), (y*y+(w*w-x*x))-z*z, -2f*(x*y+w*z), 2f*(x*z-w*y), ((w*w+x*x)-y*y)-z*z).zxy;
                case math.RotationOrder.YXZ:
                    return ThreeAxisRot(2f*(x*z-w*y), z*z+((w*w-x*x)-y*y), -2f*(y*z+w*x), 2f*(x*y-w*z), (y*y+(w*w-x*x))-z*z).yzx;
                case math.RotationOrder.YZX:
                    return ThreeAxisRot(-2f*(x*z+w*y), ((w*w+x*x)-y*y)-z*z, 2f*(x*y-w*z), -2f*(y*z+w*x), (y*y+(w*w-x*x))-z*z).xzy;
                case math.RotationOrder.ZXY:
                    return ThreeAxisRot(-2f*(x*y+w*z), (y*y+(w*w-x*x))-z*z, 2f*(y*z-w*x), -2f*(x*z+w*y), z*z+((w*w-x*x)-y*y)).yxz;
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
            float x = q.value.x, y = q.value.y, z = q.value.z, w = q.value.w;
            float yaw = math.atan2(-2f * (x * z + w * y), z * z + ((w * w - x * x) - y * y));
            float pitch = math.asin(2f * (y * z - w * x));
            float roll = math.atan2(-2f * (x * y + w * z), (y * y + (w * w - x * x)) - z * z);
            return new float3(pitch, yaw, roll) * -57.29578f;
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
            float cosine = math.dot(math.normalizesafe(from), math.normalizesafe(to));
            if (cosine >= 1f) return quaternion.identity;
            if (cosine <= -1f)
            {
                var axis = math.cross(from, new float3(1f, 0f, 0f));
                if (math.lengthsq(axis) < 1e-10f) axis = math.cross(from, new float3(0f, 1f, 0f));
                return quaternion.AxisAngle(axis, math.PI);
            }
            return quaternion.AxisAngle(math.normalizesafe(math.cross(from, to)), math.acos(cosine));
        }
    }
}
