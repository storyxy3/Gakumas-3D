namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;

    [Serializable]
    public struct ReferenceLimitInfo
    {
        public ActorSwingDynamicBone bone;
        public bool3 min;
        public bool3 max;
    }
}
