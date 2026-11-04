namespace VL.Core
{
    using global::System;
    using global::UnityEngine;

    [Serializable]
    public struct BoneLinkData
    {
        public Transform rootBone;
        public Transform targetBone;
        public BoneLinkData(Transform rootBone, Transform targetBone)
        {
            this.rootBone = rootBone;
            this.targetBone = targetBone;
        }
    }
}
