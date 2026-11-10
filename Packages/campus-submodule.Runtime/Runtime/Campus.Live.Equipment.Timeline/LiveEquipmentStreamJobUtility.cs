namespace Campus.Live.Equipment.Timeline
{
    using global::Campus.Live.Equipment;
    using global::Unity.Mathematics;

    public static class LiveEquipmentStreamJobUtility
    {
        private static void UpdateColor(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
            if (animationData.IsFlag(EquipmentValueType.Color))
            {
                var color = animationData.color;
                streamData.color = new global::UnityEngine.Color(color.r > 0.004f ? color.r : 0f,
                    color.g > 0.004f ? color.g : 0f, color.b > 0.004f ? color.b : 0f, color.a > 0.004f ? color.a : 0f);
            }
        }

        private static void UpdateIntensity(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
            streamData.intensity = animationData.IsFlag(EquipmentValueType.Intensity)
                ? (animationData.intensity > 0.004f ? animationData.intensity : 0f) : 1f; // original: NaN -> 0 (DMM 0x2afc2c0)
        }

        private static void UpdateHVRotation(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData, ref LiveEquipmentInitialData initialData)
        {
            var yaw = quaternion.AxisAngle(new float3(0f, 1f, 0f), animationData.v0 * math.PI * 0.5f);
            var pitch = quaternion.AxisAngle(new float3(1f, 0f, 0f), animationData.v1 * -math.PI * 0.5f);
            if (animationData.IsFlag(EquipmentValueType.Position | EquipmentValueType.V3 | EquipmentValueType.Rotate | EquipmentValueType.RotateIgnoreInitialRoll) && animationData.v3 > 0f)
            {
                float3 target;
                if (animationData.IsFlag(EquipmentValueType.Rotate | EquipmentValueType.RotateIgnoreInitialRoll))
                {
                    var rotation = initialData.v0;
                    if (animationData.IsFlag(EquipmentValueType.RotateIgnoreInitialRoll)) RevertRollRotation(ref rotation);
                    var initialRotation = new quaternion(rotation);
                    var lookYaw = math.mul(initialRotation, quaternion.AxisAngle(new float3(0f, 1f, 0f), animationData.lookAtParam.y));
                    var lookPitch = math.mul(initialRotation, quaternion.AxisAngle(new float3(1f, 0f, 0f), animationData.lookAtParam.x));
                    var combined = math.mul(math.mul(math.mul(yaw, pitch), lookYaw), lookPitch);
                    target = math.mul(combined, math.mul(initialRotation, new float3(0f, 1f, 0f))) + initialData.position;
                }
                else target = animationData.position;
                var direction = math.mul(new quaternion(initialData.v0), target - initialData.position);
                float yawAngle = math.atan2(direction.x, direction.z);
                float pitchAngle = math.atan2(math.sqrt(direction.x * direction.x + direction.z * direction.z), direction.y);
                streamData.rotationYaw = math.slerp(yaw, quaternion.AxisAngle(new float3(0f, 1f, 0f), yawAngle), animationData.v3).value;
                streamData.rotationPitch = math.slerp(pitch, quaternion.AxisAngle(new float3(1f, 0f, 0f), pitchAngle), animationData.v3).value;
            }
            else
            {
                if (animationData.IsFlag(EquipmentValueType.Yow)) streamData.rotationYaw = yaw.value;
                if (animationData.IsFlag(EquipmentValueType.Pitch)) streamData.rotationPitch = pitch.value;
            }
        }

        private static void RevertRollRotation(ref float4 initialRotation)
        {
            var inverse = math.inverse(new quaternion(initialRotation));
            if (inverse.Equals(quaternion.identity)) return;
            var up = new float3(0f, 1f, 0f);
            var direction = math.mul(inverse, up);
            var axis = math.cross(up, direction);
            float angle = math.acos(math.clamp(math.dot(math.normalize(direction), up), -1f, 1f));
            initialRotation = math.inverse(quaternion.AxisAngle(math.normalize(axis), angle)).value;
        }

        private static void UpdateBasicRotation(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentStreamData streamData)
        {
            streamData.rotationYaw = quaternion.AxisAngle(new float3(0f, 1f, 0f), animationData.v0 * math.PI * 0.5f).value;
            streamData.rotationPitch = quaternion.AxisAngle(new float3(1f, 0f, 0f), animationData.v1 * -math.PI * 0.5f).value;
            streamData.rotationRoll = quaternion.AxisAngle(new float3(0f, 0f, 1f), animationData.v2 * math.PI * 2f).value;
        }

        public static LiveEquipmentStreamData ConvertNone()
        {
            return default;
        }

        public static LiveEquipmentStreamData ConvertSimple(ref LiveEquipmentAnimationData animationData)
        {
            var stream = new LiveEquipmentStreamData
            {
                intensity = animationData.intensity,
                color = animationData.color,
                time = animationData.bpmTime,
                valueInt = animationData.valueInt,
                valueFloat = animationData.valueFloat,
                position = animationData.position
            };
            return stream;
        }

        public static LiveEquipmentStreamData ConvertBasic(ref LiveEquipmentAnimationData animationData)
        {
            var stream = new LiveEquipmentStreamData
            {
                intensity = animationData.intensity,
                color = animationData.color,
                time = animationData.bpmTime,
                valueInt = animationData.valueInt,
                valueFloat = animationData.valueFloat,
                position = animationData.position
            };
            UpdateBasicRotation(ref animationData, ref stream);
            return stream;
        }

        public static LiveEquipmentStreamData ConvertLight(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            var stream = new LiveEquipmentStreamData { position = animationData.position };
            UpdateColor(ref animationData, ref stream);
            UpdateIntensity(ref animationData, ref stream);
            UpdateHVRotation(ref animationData, ref stream, ref initialData);
            stream.lightParam = animationData.lightParam;
            stream.time = animationData.bpmTime;
            stream.valueInt = animationData.valueInt;
            stream.valueFloat = animationData.valueFloat;
            return stream;
        }

        public static LiveEquipmentStreamData ConvertLaser(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            var stream = new LiveEquipmentStreamData { position = animationData.position };
            UpdateColor(ref animationData, ref stream);
            UpdateIntensity(ref animationData, ref stream);
            UpdateHVRotation(ref animationData, ref stream, ref initialData);
            if (animationData.IsFlag(EquipmentValueType.V2))
                stream.rotationRoll = quaternion.AxisAngle(new float3(0f, 0f, 1f), animationData.v2 * math.PI * 2f).value;
            stream.time = animationData.bpmTime;
            stream.valueInt = animationData.valueInt;
            stream.valueFloat = animationData.valueFloat;
            return stream;
        }

        public static LiveEquipmentStreamData ConvertPsyllium(ref LiveEquipmentAnimationData animationData, ref LiveEquipmentInitialData initialData)
        {
            var stream = new LiveEquipmentStreamData
            {
                intensity = animationData.intensity,
                color = animationData.color,
                time = animationData.bpmTime,
                valueInt = animationData.valueInt,
                valueFloat = animationData.valueFloat,
                position = animationData.position
            };
            if (animationData.valueInt.y == 1) stream.valueInt.x = initialData.valueInt.x;
            return stream;
        }

        public static LiveEquipmentStreamData ConvertDirectionalLight(ref LiveEquipmentAnimationData animationData)
        {
            var stream = new LiveEquipmentStreamData
            {
                intensity = animationData.intensity,
                color = animationData.color,
                time = animationData.bpmTime,
                valueInt = animationData.valueInt,
                valueFloat = animationData.valueFloat,
                position = animationData.position
            };
            stream.rotationYaw = quaternion.EulerXYZ(math.radians(new float3(animationData.v1, animationData.v0, 0f))).value;
            return stream;
        }
    }
}
