namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    public static class ActorSwingColliderUtility
    {
        public static ActorSwingJobCollider ConvertJobCollider(IActorSwingBone bone)
        {
            ActorSwingJobCollider collider = default;
            ConvertJobCollider(ref collider, bone);
            return collider;
        }

        public static void ConvertJobCollider(ref ActorSwingJobCollider jobCollider, IActorSwingBone bone)
        {
            var collider = bone.swingCollider;
            var transform = bone.transform;
            jobCollider.active = (byte)(bone.isActiveAndEnabled ? 1 : 0);
            jobCollider.type = collider.type;
            jobCollider.collisionMask = collider.collisionMask;
            jobCollider.seatDynamicCorrectionDisableCollisionMask = collider is ActorSwingStaticCollider staticCollider ? staticCollider.seatDynamicCorrectionDisableCollisionMask : 0;
            var lossyScale = transform.lossyScale;
            jobCollider.scale = math.min(lossyScale.x, math.min(lossyScale.y, lossyScale.z));
            float3 position = float3.zero;
            float3 subPosition = float3.zero;
            quaternion rotation = quaternion.identity;
            switch (jobCollider.type)
            {
                case ActorSwingColliderType.Sphere:
                    jobCollider.float3_A = collider.vector3_A * jobCollider.scale;
                    jobCollider.float_A = collider.float_A * jobCollider.scale;
                    position = transform.position;
                    rotation = transform.rotation;
                    break;
                case ActorSwingColliderType.Capsule:
                    jobCollider.float_A = collider.float_A * jobCollider.scale;
                    jobCollider.float_B = collider.float_B * jobCollider.scale;
                    float3 center = collider.vector3_A * jobCollider.scale;
                    float3 offset = float3.zero;
                    offset[(int)collider.vector3_B.x] = collider.vector3_B.y * 0.5f * jobCollider.scale - jobCollider.float_A;
                    jobCollider.float3_A = center - offset;
                    jobCollider.float3_B = center + offset;
                    position = transform.position;
                    rotation = transform.rotation;
                    break;
                case ActorSwingColliderType.Line:
                    if (transform.parent != null)
                    {
                        jobCollider.float_A = collider.float_A * jobCollider.scale;
                        jobCollider.float_B = collider.float_B * jobCollider.scale;
                        jobCollider.float3_A = collider.vector3_A;
                        position = transform.position;
                        subPosition = transform.parent.position;
                    }
                    break;
            }
            UpdateCollider(ref jobCollider, position, subPosition, rotation);
        }

        public static void UpdateCollider(ref ActorSwingJobCollider jobCollider, float3 position, float3 subPosition, quaternion rotation)
        {
            switch (jobCollider.type)
            {
                case ActorSwingColliderType.Sphere:
                    jobCollider.position = position + math.mul(rotation, jobCollider.float3_A);
                    break;
                case ActorSwingColliderType.Capsule:
                    jobCollider.position = position + math.mul(rotation, jobCollider.float3_A);
                    jobCollider.subPosition = position + math.mul(rotation, jobCollider.float3_B);
                    break;
                case ActorSwingColliderType.Line:
                    if (jobCollider.float3_A.x > 0f || jobCollider.float3_A.y > 0f)
                    {
                        float3 delta = subPosition - position;
                        float length = math.length(delta);
                        if (length > 0.01f)
                        {
                            float3 direction = delta / length;
                            float firstOffset = math.max(0f, jobCollider.float3_A.x) * jobCollider.scale;
                            float secondOffset = math.max(0f, jobCollider.float3_A.y) * jobCollider.scale;
                            float totalOffset = firstOffset + secondOffset;
                            if (length < totalOffset)
                            {
                                float excess = totalOffset - length;
                                firstOffset = math.max(0f, firstOffset - firstOffset * excess / totalOffset);
                                secondOffset = math.max(0f, secondOffset - secondOffset * excess / (secondOffset + firstOffset));
                            }
                            position += direction * firstOffset;
                            subPosition -= direction * secondOffset;
                        }
                    }
                    jobCollider.position = position;
                    jobCollider.subPosition = subPosition;
                    break;
            }
            UpdateFastHitCollider(ref jobCollider);
        }

        public static void UpdateFastHitCollider(ref ActorSwingJobCollider collider)
        {
            switch (collider.type)
            {
                case ActorSwingColliderType.Capsule:
                case ActorSwingColliderType.Line:
                    float3 delta = collider.position - collider.subPosition;
                    collider.fastHitPosition = collider.subPosition + delta * 0.5f;
                    collider.fastHitRadius = math.length(delta);
                    float radius = math.max(collider.float_A, collider.float_B);
                    collider.fastHitRadius = (collider.fastHitRadius + (radius + radius)) * 0.5f * 1.1f;
                    break;
                case ActorSwingColliderType.Sphere:
                case ActorSwingColliderType.Plane:
                    collider.fastHitPosition = collider.position;
                    collider.fastHitRadius = collider.float_A * 1.1f;
                    break;
            }
        }
    }
}
