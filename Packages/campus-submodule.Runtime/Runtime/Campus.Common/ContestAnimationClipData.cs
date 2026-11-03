namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [Serializable]
    public class ContestAnimationClipData
    {
        [Tooltip("モーションデータ")]
        public AnimationClip animationClip;
        [Tooltip("スキップされるコンテンツ種別")]
        public ContestAnimationClipCollection.IgnoreFlag ignoreFlag;
        public ContestAnimationClipData()
        {
        }
    }
}
