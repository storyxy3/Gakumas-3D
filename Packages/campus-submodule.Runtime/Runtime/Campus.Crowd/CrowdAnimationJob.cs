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
            int count = transforms.Length - excludeBoundBoneIndexes.Length;
            var boneIndexes = new NativeArray<int>(count, Allocator.Temp);
            var bonePositions = new NativeArray<Vector3>(count, Allocator.Temp);
            for (int input = 0; input < stream.inputStreamCount; input++)
            {
                var inputStream = stream.GetInputStream(input);
                if (inputStream.isValid)
                {
                    int boundIndex = 0;
                    for (int bone = 0; bone < transforms.Length; bone++)
                    {
                        transforms[bone].GetGlobalTR(inputStream, out var position, out var rotation);
                        var matrix = invRootMatrix.Value * Matrix4x4.TRS(position, rotation, Vector3.one);
                        matrices[input * transforms.Length + bone] = matrix * bindPoses[bone];
                        rawMatrices[input * transforms.Length + bone] = matrix;
                        if (!excludeBoundBoneIndexes.Contains(bone))
                        {
                            boneIndexes[boundIndex] = bone;
                            bonePositions[boundIndex] = position;
                            boundIndex++;
                        }
                    }
                    bounds[input] = CalcAnimationBounds(in boneIndexes, in bonePositions);
                }
                else
                {
                    for (int bone = 0; bone < transforms.Length; bone++)
                        matrices[input * transforms.Length + bone] = Matrix4x4.identity;
                    bounds[input] = new Bounds();
                }
            }
            boneIndexes.Dispose();
            bonePositions.Dispose();
        }

        public void ProcessRootMotion(AnimationStream stream)
        {
        }

        private Bounds CalcAnimationBounds(in NativeArray<int> boneIndexes, in NativeArray<Vector3> bonePositions)
        {
            float height = 0f;
            foreach (var position in bonePositions) height += position.y;
            var result = new Bounds(new Vector3(0f, height / bonePositions.Length, 0f), Vector3.zero);
            for (int i = 0; i < boneIndexes.Length; i++)
            {
                var size = Vector3.zero;
                for (int j = 0; j < volumeBoneIndexes.Length; j++)
                {
                    if (boneIndexes[i] == volumeBoneIndexes[j])
                    {
                        size = volumeBoneSizes[j];
                        break;
                    }
                }
                result.Encapsulate(bonePositions[i] - size);
                result.Encapsulate(bonePositions[i] + size);
            }
            return result;
        }
    }
}
