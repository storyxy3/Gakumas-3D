namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverFurisodeSetting
    {
        public GameObject referenceFurisodeOffsetBone;
        public GameObject referenceSpineBone;
        public GameObject referenceForearmBone;
        public GameObject referenceHandBone;
        public float3 backWay;
        public float apexAngle;
        public float coefficient;
        public float min;
        public float max;
        public ActorAnimationQuartzDriverFurisodeSetting()
        {
        }
    }
}
