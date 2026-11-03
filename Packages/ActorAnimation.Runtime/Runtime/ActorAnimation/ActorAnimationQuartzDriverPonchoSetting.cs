namespace ActorAnimation
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverPonchoSetting
    {
        public float lerpCoefficient;
        public float innerLimit;
        public float outerLimit;
        public float3 axisWay;
        public GameObject referenceArmBone;
        public GameObject referencePonchoOffsetBone;
        public GameObject referenceArmOffsetBone;
        public GameObject referenceBodyOffsetBone;
        public GameObject referenceInnerOffsetBone;
        public GameObject referenceOuterOffsetBone;
        public ActorAnimationQuartzDriverPonchoSetting()
        {
        }
    }
}
