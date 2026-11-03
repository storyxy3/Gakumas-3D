namespace Campus.Common
{
    using global::System;
    using global::Campus.Common;
    using global::UnityEngine;

    [CreateAssetMenu(fileName = "ContestAnimationClipCollection.asset", menuName = "Campus/Motion/Contest Motion Collection")]
    public class ContestAnimationClipCollection : ScriptableObject
    {
        [Flags]
        public enum IgnoreFlag
        {
            Normal = 1,
            Rehearsal = 2
        }

        public ContestAnimationClipData[] animationClipDatas;
        public AnimationClip[] GetAnimations(IgnoreFlag flag)
        {
            return null;
        }

        public ContestAnimationClipCollection()
        {
        }
    }
}
