namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;

    [Serializable]
    public struct InitialTransform
    {
        public float3 localPosition;
        public quaternion localRotation;
        public float3 position;
        public quaternion rotation;
    }
}
