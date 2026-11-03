namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorSwingJobDynamicBone
    {
        public bool active;
        public ResetType resetType;
        public DynamicType dynamicType;
        public ActorSwingJobCollider collider;
        public CollisionInfo collision;
        public int depth;
        public int parentIndex;
        public int childIndex;
        public float3 boneAxis;
        public float boneLength;
        public ActorSwingAffineTransform modelingLocalTx;
        public ActorSwingAffineTransform localTx;
        public quaternion defaultRotation;
        public ActorSwingAffineTransform selfTx;
        public ActorSwingAffineTransform parentTx;
        public float3 childSpeed;
        public ReadWriteTransformHandle driven;
        public ReadOnlyTransformHandle parent;
        public float damping;
        public float stiffness;
        public float spring;
        public float pendulum;
        public float pendulumRange;
        public float mass;
        public float axisAddXToY;
        public float axisAddXToZ;
        public float wind;
        public Vector3Property syncPosition;
        public Vector3Property syncRotation;
        public Vector3Property syncColliderPosition;
        public Vector3Property syncColliderSubPosition;
        public Vector3Property syncColliderFastHitPosition;
        public Vector3Property syncCollisionNormal;
        public Vector3Property syncCollisionPosition;
        public IntProperty syncCollisionHitCheckCount;
        public IntProperty syncUseLimit;
        public Vector3Property syncLimitPositive;
        public Vector3Property syncLimitNegative;
        public bool useWindGlobalForce;
        public ActorSwingJobLimitInfo limit;
        public float rootWeight;
        public float seatDynamicCorrection;
        public bool useArmCorrection;
        public int prewarmCount;
        public ActorSwingJobReferenceLimitInfo referenceLimit;
        public ActorSwingJobDynamicBoneCash cachedTransform;
        public void Reset(InitialTransform initialTransform, int prewarmCount)
        {
        }

        public void EnqueueCachedTransform(ActorSwingAffineTransform data)
        {
        }

        public bool IsAlreadyStable()
        {
            return default(bool);
        }
    }
}
