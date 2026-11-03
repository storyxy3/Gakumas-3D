namespace ActorAnimation
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public class ActorAnimationQuartzDriverWaistSetting
    {
        public float weight;
        public GameObject referenceWaistOffsetBone;
        public GameObject referenceThighOffsetBone;
        public ActorAnimationQuartzDriverWaistSetting()
        {
        }
    }
}
