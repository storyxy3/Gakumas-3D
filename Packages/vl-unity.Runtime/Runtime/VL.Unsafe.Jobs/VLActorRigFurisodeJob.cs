namespace VL.Unsafe.Jobs
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;
    using global::VL;
    using global::VL.Unsafe.Jobs;

    [BurstCompile]
    public struct VLActorRigFurisodeJob : IAnimationJob
    {
        public NativeArray<RigFurisodeData> rigs;
        public void ProcessAnimation(AnimationStream stream)
        {
        }

        private unsafe void EvaluateRig(VLActorRigFurisodeBone.VLActorRigFurisodeConnection connection, ref global::UnityEngine.Animations.Rigging.AffineTransform affineTransform, quaternion tarRot, quaternion refARot, quaternion refBRot, RigFurisodeData* r)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }
    }
}
