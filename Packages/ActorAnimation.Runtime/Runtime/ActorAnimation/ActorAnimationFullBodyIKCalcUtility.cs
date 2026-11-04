namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    public static class ActorAnimationFullBodyIKCalcUtility
    {
        public static ActorAnimationIKCorrectionColliderCollisionInfo CalcSphereCollisionInfo(AnimationStream stream, ActorAnimationIKCorrectionJobCollider correctionCollider, Vector3 goalPosition, float goalRadius)
        {
            var position = correctionCollider.referenceHandle.GetPosition(stream);
            var rotation = correctionCollider.referenceHandle.GetRotation(stream);
            var center = position + rotation * (Vector3)correctionCollider.offset;
            return ActorAnimationIKCorrectionColliderCollisionInfo.FromSphereColliderCollision(correctionCollider.radius,
                correctionCollider.dampArea, center, correctionCollider.weight, goalPosition, goalRadius);
        }

        public static ActorAnimationIKCorrectionColliderCollisionInfo CalcCapsuleCollisionInfo(AnimationStream stream, ActorAnimationIKCorrectionJobCollider correctionCollider, Vector3 goalPosition, float goalRadius)
        {
            var rotation = correctionCollider.referenceHandle.GetRotation(stream);
            var position = correctionCollider.referenceHandle.GetPosition(stream);
            var center = position + rotation * (Vector3)correctionCollider.offset;
            float halfLength = correctionCollider.length * 0.5f;
            quaternion orientation = rotation * (Quaternion)quaternion.EulerZXY(math.radians(correctionCollider.rotation));
            Vector3 direction = math.rotate(orientation, (float3)new Vector3(0f, halfLength, 0f));
            Vector3 start = center + direction;
            Vector3 end = center - direction;
            Vector3 spherePosition;
            float radius;
            if (math.dot((float3)(goalPosition - start), (float3)(end - start)) <= 0f)
            {
                spherePosition = start;
                radius = correctionCollider.radius;
            }
            else if (math.dot((float3)(goalPosition - end), (float3)(start - end)) <= 0f)
            {
                spherePosition = end;
                radius = correctionCollider.radiusSub;
            }
            else
            {
                Vector3 segment = end - start;
                Vector3 projected = segment * math.dot((float3)segment, (float3)(goalPosition - start))
                    / (math.length((float3)segment) * math.length((float3)segment));
                float t = math.length((float3)projected) / math.length((float3)segment);
                spherePosition = start + projected;
                radius = math.lerp(correctionCollider.radius, correctionCollider.radiusSub, t);
            }
            return ActorAnimationIKCorrectionColliderCollisionInfo.FromSphereColliderCollision(radius,
                correctionCollider.dampArea, spherePosition, correctionCollider.weight, goalPosition, goalRadius);
        }

        public static bool CalcGoalPosition(ref Vector3 resultGaolPosition, ref ActorAnimationIKCorrectionColliderCollisionInfo info, Vector3 goalPosition, float goalRadius, ref float correctionWeight)
        {
            float distance = Vector3.Distance(goalPosition, info.ColliderPosition);
            if (distance < info.ColliderRadius + goalRadius)
            {
                resultGaolPosition = info.ColliderPosition + (goalPosition - info.ColliderPosition).normalized * (info.ColliderRadius + goalRadius);
                correctionWeight *= info.ColliderWeight;
                return true;
            }
            if (distance < info.ColliderRadius + goalRadius + info.ColliderDampArea)
            {
                resultGaolPosition = info.ColliderPosition + (goalPosition - info.ColliderPosition).normalized * (info.ColliderRadius + goalRadius);
                correctionWeight *= info.ColliderWeight * (1f - (distance - (info.ColliderRadius + goalRadius)) / info.ColliderDampArea);
                return true;
            }
            return false;
        }
    }
}
