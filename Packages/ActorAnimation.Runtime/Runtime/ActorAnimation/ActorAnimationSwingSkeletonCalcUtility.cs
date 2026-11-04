namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Mathematics;

    public static class ActorAnimationSwingSkeletonCalcUtility
    {
        public static float GetChainLoopLength(List<ActorSwingDynamicBone> bones, bool isAround)
        {
            float length = 0f;
            for (int i = 0; i < bones.Count; i++)
            {
                if (i + 1 < bones.Count)
                    length += math.length((float3)(bones[i].transform.position - bones[i + 1].transform.position));
                else if (isAround)
                    length += math.length((float3)(bones[i].transform.position - bones[0].transform.position));
            }
            return length;
        }

        public static float GetChainLoopLength(NativeList<float3> positions, bool isAround)
        {
            float length = 0f;
            for (int i = 0; i < positions.Length; i++)
            {
                if (i + 1 < positions.Length)
                    length += math.length(positions[i] - positions[i + 1]);
                else if (isAround)
                    length += math.length(positions[i] - positions[0]);
            }
            return length;
        }
    }
}
