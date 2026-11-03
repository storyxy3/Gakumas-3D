namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Collections;

    public static class ActorSwingCollisionUtility
    {
        [MethodImpl(256)]
        public unsafe static void CheckDynamicCollision(NativeList<ActorSwingJobStaticBone> staticBones, ActorSwingJobDynamicBone* pChildDynamic, bool enableSeatedDynamicCorrection, ref ActorSwingAffineTransform selfTx, ref ActorSwingAffineTransform childTx)
        {
        }

        [MethodImpl(256)]
        public unsafe static void CheckChainCollision(NativeList<ActorSwingJobStaticBone> staticBones, ActorSwingJobChainBone* pChain, ref ActorSwingAffineTransform selfTx, ref ActorSwingAffineTransform subTx, ActorSwingJobDynamicBone* pDynamicHead, ActorSwingJobDynamicBone* pBone, ActorSwingJobDynamicBone* pSubBone, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, bool enableSeatedDynamicCorrection, bool isCmmnHeightCorrectionNeeded, float inverseHeightCorrectionBoneScale)
        {
        }

        [MethodImpl(256)]
        private static bool CheckFastCollision(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        public static bool ProcessColliderToCollider(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, bool enableSeatedDynamicCorrection, out HitInfo hitInfo)
        {
            throw null;
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToSphere(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToCapsule(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToSphere(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToCapsule(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool ProcessSphereToCirclePlane(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool ProcessCapsuleToCirclePlane(ref ActorSwingJobCollider fromCollider, ref ActorSwingJobCollider toCollider, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool CollisionSphereSphere(ref ActorSwingJobCollider sphereA, ref ActorSwingJobCollider sphereB, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool CollisionSphereCapsule(ref ActorSwingJobCollider sphereCollider, ref ActorSwingJobCollider capsuleCollider, ref HitInfo hitInfo, bool invert)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool CollisionCapsuleCapsule(ref ActorSwingJobCollider capsuleA, ref ActorSwingJobCollider capsuleB, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool CollisionSpherePlane(ref ActorSwingJobCollider sphereA, ref ActorSwingJobCollider planeB, ref HitInfo hitInfo)
        {
            return default(bool);
        }

        [MethodImpl(256)]
        private static bool CollisionCapsulePlane(ref ActorSwingJobCollider capsuleA, ref ActorSwingJobCollider planeB, ref HitInfo hitInfo)
        {
            return default(bool);
        }
    }
}
