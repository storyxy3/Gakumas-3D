namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverRotationSetting
    {
        public math.RotationOrder rotationOrder;
        public float3 limitMin;
        public float3 limitMax;
        public float3 coefficient;
        public math.RotationOrder connectionAxis;
        public ActorAnimationQuartzDriverRotationDecomposeType decomposeType;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public GameObject referenceBone;
        public ActorAnimationQuartzDriverRotationSetting()
        {
        }
    }
}
