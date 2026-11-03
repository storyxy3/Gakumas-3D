namespace Campus.AnimationRigging
{
    using global::System;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationAttributeConvertConstraintData : IAnimationJobData
    {
        [SyncSceneToStream]
        public Transform source;
        [SyncSceneToStream]
        public Transform target;
        public Vector3 initialTranslate;
        public Vector3 initialRotate;
        public Vector3 initialScale;
        [SyncSceneToStream]
        public int sourceAttribute;
        [SyncSceneToStream]
        public int connectionAxis;
        [SyncSceneToStream]
        public int weightCalcType;
        [SyncSceneToStream]
        public int targetAttribute;
        [SyncSceneToStream]
        public Vector3 weight;
        [SyncSceneToStream]
        public Vector3 offset;
        [SyncSceneToStream]
        public Vector3 min;
        [SyncSceneToStream]
        public Vector3 max;
        public bool IsValid()
        {
            return default(bool);
        }

        public void SetDefaultValues()
        {
        }
    }
}
