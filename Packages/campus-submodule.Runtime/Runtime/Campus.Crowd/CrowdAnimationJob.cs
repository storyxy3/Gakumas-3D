namespace Campus.Crowd
{
    using global::Unity.Burst;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;

    [BurstCompile]
    internal struct CrowdAnimationJob : IAnimationJob
    {
        [ReadOnly]
        public NativeReference<Matrix4x4> invRootMatrix;
        [ReadOnly]
        public NativeArray<TransformStreamHandle> transforms;
        [ReadOnly]
        public NativeArray<Matrix4x4> bindPoses;
        [ReadOnly]
        public NativeArray<int> excludeBoundBoneIndexes;
        [ReadOnly]
        public NativeArray<int> volumeBoneIndexes;
        [ReadOnly]
        public NativeArray<Vector3> volumeBoneSizes;
        [WriteOnly]
        public NativeArray<Matrix4x4> matrices;
        [WriteOnly]
        public NativeArray<Matrix4x4> rawMatrices;
        [WriteOnly]
        public NativeArray<Bounds> bounds;
        public void ProcessAnimation(AnimationStream stream)
        {
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }

        private Bounds CalcAnimationBounds(in NativeArray<int> boneIndexes, in NativeArray<Vector3> bonePositions)
        {
            return default(Bounds);
        }
    }
}
