namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    public static class ActorSwingColliderUtility
    {
        public static ActorSwingJobCollider ConvertJobCollider(IActorSwingBone bone)
        {
            return default(ActorSwingJobCollider);
        }

        public static void ConvertJobCollider(ref ActorSwingJobCollider jobCollider, IActorSwingBone bone)
        {
        }

        public static void UpdateCollider(ref ActorSwingJobCollider jobCollider, float3 position, float3 subPosition, quaternion rotation)
        {
        }

        public static void UpdateFastHitCollider(ref ActorSwingJobCollider collider)
        {
        }
    }
}
