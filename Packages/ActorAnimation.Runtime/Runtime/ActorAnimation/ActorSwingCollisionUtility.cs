namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Collections.LowLevel.Unsafe;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    public static class ActorSwingCollisionUtility
    {
        [MethodImpl(256)]
        public unsafe static void CheckDynamicCollision(NativeList<ActorSwingJobStaticBone> staticBones, ActorSwingJobDynamicBone* pChildDynamic, bool enableSeatedDynamicCorrection, ref ActorSwingAffineTransform selfTx, ref ActorSwingAffineTransform childTx)
        {
            CollisionInfo collision = default;
            var statics = (ActorSwingJobStaticBone*)staticBones.GetUnsafeReadOnlyPtr();
            var collider = pChildDynamic->collider;
            byte hits = 0;
            for (int i = 0; i < staticBones.Length; i++, statics++)
            {
                if (!ProcessColliderToCollider(ref collider, ref statics->collider, enableSeatedDynamicCorrection, out var hit)) continue;
                childTx.translation = hit.position + hit.normal * hit.distance;
                childTx.translation = ActorSwingUtility.UpdateSpringPosition(selfTx.translation, childTx.translation, pChildDynamic->boneLength);
                ActorSwingColliderUtility.UpdateCollider(ref collider, childTx.translation, selfTx.translation, selfTx.rotation);
                hits++;
                collision.position = childTx.translation;
                collision.normal = hit.normal;
            }
            collision.hitCheckCount = hits;
            pChildDynamic->collision = collision;
            pChildDynamic->collider = collider;
        }

        [MethodImpl(256)]
        public unsafe static void CheckChainCollision(NativeList<ActorSwingJobStaticBone> staticBones, ActorSwingJobChainBone* pChain, ref ActorSwingAffineTransform selfTx, ref ActorSwingAffineTransform subTx, ActorSwingJobDynamicBone* pDynamicHead, ActorSwingJobDynamicBone* pBone, ActorSwingJobDynamicBone* pSubBone, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, bool enableSeatedDynamicCorrection, bool isCmmnHeightCorrectionNeeded, float inverseHeightCorrectionBoneScale)
        {
            CollisionInfo collision = default;
            var statics = (ActorSwingJobStaticBone*)staticBones.GetUnsafeReadOnlyPtr();
            var collider = pChain->collider;
            byte hits = 0;
            for (int i = 0; i < staticBones.Length; i++, statics++)
            {
                if (!ProcessColliderToCollider(ref collider, ref statics->collider, enableSeatedDynamicCorrection, out var hit)) continue;
                float3 target = hit.position + hit.normal * hit.distance;
                float3 direction = math.normalize(subTx.translation - selfTx.translation);
                float along = Vector3.Dot(direction, target - selfTx.translation);
                var parent = pDynamicHead + pBone->parentIndex;
                var subParent = pDynamicHead + pSubBone->parentIndex;
                float3 cancel = hipsTx.translation * (1f - managePropertyData.rootWeight * parent->rootWeight);
                float3 subCancel = hipsTx.translation * (1f - managePropertyData.rootWeight * subParent->rootWeight);
                if (isCmmnHeightCorrectionNeeded)
                {
                    cancel *= inverseHeightCorrectionBoneScale;
                    subCancel *= inverseHeightCorrectionBoneScale;
                }
                float3 push = target - (selfTx.translation + direction * along);
                float3 self = ActorSwingUtility.UpdateSpringPosition(parent->selfTx.translation + cancel, selfTx.translation + push, pBone->boneLength);
                float3 sub = ActorSwingUtility.UpdateSpringPosition(subParent->selfTx.translation + subCancel, subTx.translation + push, pSubBone->boneLength);
                ActorSwingColliderUtility.UpdateCollider(ref collider, self, sub, selfTx.rotation);
                selfTx.translation = self;
                subTx.translation = sub;
                hits++;
                collision.normal = hit.normal;
                collision.position = collider.fastHitPosition;
            }
            collision.hitCheckCount = hits;
            pChain->collision = collision;
            pChain->collider = collider;
        }

        [MethodImpl(256)]
        private static bool CheckFastCollision(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider)
        {
            if (toCollider.type == ActorSwingColliderType.Plane) return true;
            float3 difference = fromCollider.fastHitPosition - toCollider.fastHitPosition;
            float radius = fromCollider.fastHitRadius + toCollider.fastHitRadius;
            return !(math.lengthsq(difference) > radius * radius); // original: unordered (NaN) counts as a hit (x64 comiss+setbe)
        }

        [MethodImpl(256)]
        public static bool ProcessColliderToCollider(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, bool enableSeatedDynamicCorrection, out HitInfo hitInfo)
        {
            hitInfo = default;
            if (fromCollider.type == ActorSwingColliderType.None || toCollider.type == ActorSwingColliderType.None) return false;
            var fromMask = fromCollider.collisionMask;
            var toMask = toCollider.collisionMask;
            if (enableSeatedDynamicCorrection)
            {
                fromMask &= ~fromCollider.seatDynamicCorrectionDisableCollisionMask;
                toMask &= ~toCollider.seatDynamicCorrectionDisableCollisionMask;
            }
            if ((fromMask & toMask) == 0 || !CheckFastCollision(ref fromCollider, ref toCollider)) return false;
            switch (fromCollider.type)
            {
                case ActorSwingColliderType.Sphere:
                    switch (toCollider.type)
                    {
                        case ActorSwingColliderType.Sphere: return ProcessSphereToSphere(ref fromCollider, ref toCollider, ref hitInfo);
                        case ActorSwingColliderType.Capsule:
                        case ActorSwingColliderType.Line: return ProcessSphereToCapsule(ref fromCollider, ref toCollider, ref hitInfo);
                        case ActorSwingColliderType.Plane: return ProcessSphereToCirclePlane(ref fromCollider, ref toCollider, ref hitInfo);
                    }
                    break;
                case ActorSwingColliderType.Line:
                    switch (toCollider.type)
                    {
                        case ActorSwingColliderType.Sphere: return ProcessCapsuleToSphere(ref fromCollider, ref toCollider, ref hitInfo);
                        case ActorSwingColliderType.Capsule:
                        case ActorSwingColliderType.Line: return ProcessCapsuleToCapsule(ref fromCollider, ref toCollider, ref hitInfo);
                        case ActorSwingColliderType.Plane: return ProcessCapsuleToCirclePlane(ref fromCollider, ref toCollider, ref hitInfo);
                    }
                    break;
            }
            return false;
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToSphere(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionSphereSphere(ref fromCollider, ref toCollider, ref hitInfo);
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToCapsule(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionSphereCapsule(ref fromCollider, ref toCollider, ref hitInfo, false);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToSphere(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionSphereCapsule(ref toCollider, ref fromCollider, ref hitInfo, true);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToCapsule(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionCapsuleCapsule(ref fromCollider, ref toCollider, ref hitInfo);
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToCirclePlane(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionSpherePlane(ref fromCollider, ref toCollider, ref hitInfo);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToCirclePlane(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return CollisionCapsulePlane(ref fromCollider, ref toCollider, ref hitInfo);
        }

        [MethodImpl(256)]
        private static bool CollisionSphereSphere(ref ActorSwingJobCollider sphereA, ref ActorSwingJobCollider sphereB, ref HitInfo hitInfo)
        {
            float3 difference = sphereA.position - sphereB.position;
            float radius = sphereA.float_A + sphereB.float_A;
            float lengthSquared = math.lengthsq(difference);
            if (!(lengthSquared <= radius * radius)) return false;
            float length = math.sqrt(lengthSquared);
            hitInfo.normal = length > 0.00001f ? difference / length : float3.zero;
            hitInfo.position = sphereB.position;
            hitInfo.distance = radius;
            return true;
        }

        [MethodImpl(256)]
        private static bool CollisionSphereCapsule(ref ActorSwingJobCollider sphereCollider, ref ActorSwingJobCollider capsuleCollider, ref HitInfo hitInfo, bool invert)
        {
            float3 axis = capsuleCollider.subPosition - capsuleCollider.position;
            float dot = math.dot(axis, sphereCollider.position - capsuleCollider.position);
            float3 closest = capsuleCollider.position;
            float radius = capsuleCollider.float_A;
            if (!(dot <= 0f))
            {
                float lengthSquared = math.lengthsq(axis);
                float t = 1f;
                closest = capsuleCollider.subPosition;
                if (dot < lengthSquared)
                {
                    t = dot / lengthSquared;
                    closest = capsuleCollider.position + axis * t;
                }
                radius = t * capsuleCollider.float_B + (1f - t) * capsuleCollider.float_A;
            }
            float3 difference = invert ? closest - sphereCollider.position : sphereCollider.position - closest;
            float3 position = invert ? sphereCollider.position : closest;
            radius += sphereCollider.float_A;
            float distanceSquared = math.lengthsq(difference);
            if (!(distanceSquared <= radius * radius)) return false;
            float distance = math.sqrt(distanceSquared);
            hitInfo.normal = distance > 0.00001f ? difference / distance : float3.zero;
            hitInfo.position = position;
            hitInfo.distance = radius;
            return true;
        }

        [MethodImpl(256)]
        private static bool CollisionCapsuleCapsule(ref ActorSwingJobCollider capsuleA, ref ActorSwingJobCollider capsuleB, ref HitInfo hitInfo)
        {
            float3 axisA = capsuleA.subPosition - capsuleA.position;
            float3 axisB = capsuleB.subPosition - capsuleB.position;
            float3 difference = capsuleA.position - capsuleB.position;
            float lengthA = math.lengthsq(axisA);
            float lengthB = math.lengthsq(axisB);
            float3 position = capsuleB.position;
            float radiusA = capsuleA.float_A;
            float radiusB = capsuleB.float_A;
            if (lengthA > 0.00001f || lengthB > 0.00001f)
            {
                float dotB = math.dot(axisB, difference);
                float s;
                float t;
                if (lengthA <= 0.00001f)
                {
                    s = 0f;
                    t = math.clamp(dotB / lengthB, 0f, 1f);
                }
                else
                {
                    float dotA = math.dot(axisA, difference);
                    if (lengthB <= 0.00001f)
                    {
                        s = math.clamp(-dotA / lengthA, 0f, 1f);
                        t = 0f;
                    }
                    else
                    {
                        float cross = math.dot(axisA, axisB);
                        float denominator = lengthA * lengthB - cross * cross;
                        s = denominator > 0.00001f ? math.clamp((cross * dotB - dotA * lengthB) / denominator, 0f, 1f) : 0f;
                        t = (dotB + cross * s) / lengthB;
                        if (t < 0f)
                        {
                            s = math.clamp(-dotA / lengthA, 0f, 1f);
                            t = 0f;
                        }
                        else if (t > 1f)
                        {
                            s = math.clamp((cross - dotA) / lengthA, 0f, 1f);
                            t = 1f;
                        }
                    }
                }
                position = capsuleB.position + axisB * t;
                difference = capsuleA.position + axisA * s - position;
                radiusA = (1f - s) * capsuleA.float_A + s * capsuleA.float_B;
                radiusB = (1f - t) * capsuleB.float_A + t * capsuleB.float_B;
            }
            float radius = radiusB + radiusA;
            float distanceSquared = math.lengthsq(difference);
            if (!(distanceSquared <= radius * radius)) return false;
            float distance = math.sqrt(distanceSquared);
            hitInfo.normal = distance > 0.00001f ? difference / distance : float3.zero;
            hitInfo.position = position;
            hitInfo.distance = radius;
            return true;
        }

        [MethodImpl(256)]
        private static bool CollisionSpherePlane(ref ActorSwingJobCollider sphereA, ref ActorSwingJobCollider planeB, ref HitInfo hitInfo)
        {
            float distance = Vector3.Dot(sphereA.position, planeB.subPosition) - planeB.float_A;
            if (!(distance <= sphereA.float_A)) return false;
            hitInfo.normal = planeB.subPosition;
            hitInfo.position = sphereA.position;
            hitInfo.distance = sphereA.float_A - distance;
            return true;
        }

        [MethodImpl(256)]
        private static bool CollisionCapsulePlane(ref ActorSwingJobCollider capsuleA, ref ActorSwingJobCollider planeB, ref HitInfo hitInfo)
        {
            float distance = Vector3.Dot(capsuleA.position, planeB.subPosition) - planeB.float_A;
            float subDistance = Vector3.Dot(capsuleA.subPosition, planeB.subPosition) - planeB.float_A;
            float3 position = capsuleA.position;
            float radius = capsuleA.float_A;
            if (subDistance < distance)
            {
                distance = subDistance;
                position = capsuleA.subPosition;
                radius = capsuleA.float_B;
            }
            if (!(distance <= radius)) return false;
            hitInfo.normal = planeB.subPosition;
            hitInfo.position = position;
            hitInfo.distance = radius - distance;
            return true;
        }
    }
}
