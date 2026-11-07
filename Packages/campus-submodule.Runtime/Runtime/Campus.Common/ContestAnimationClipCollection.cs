namespace Campus.Common
{
    using global::System;
    using global::System.Runtime.CompilerServices;
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

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<ContestAnimationClipData, AnimationClip> _003C_003E9__2_1;
            public _003C_003Ec()
            {
            }

            internal AnimationClip _003CGetAnimations_003Eb__2_1(ContestAnimationClipData data)
            {
                return null;
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            public IgnoreFlag flag;
            public _003C_003Ec__DisplayClass2_0()
            {
            }

            internal bool _003CGetAnimations_003Eb__0(ContestAnimationClipData data)
            {
                return default(bool);
            }
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
