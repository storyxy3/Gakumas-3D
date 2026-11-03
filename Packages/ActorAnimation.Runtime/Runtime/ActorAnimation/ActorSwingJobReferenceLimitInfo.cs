namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ActorSwingJobReferenceLimitInfo
    {
        public bool3 min;
        public bool3 max;
        public int boneIndex;
        public ActorSwingJobReferenceLimitInfo(ReferenceLimitInfo info, int infoBoneIndex)
        {
            this = default;
        }
    }
}
