namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "MotionDefineGroup.asset", menuName = "Campus/MotionDefineGroup", order = 1200)]
    public class MotionDefineGroup : ScriptableObject
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass7_0
        {
            public int clipId;
            public _003C_003Ec__DisplayClass7_0()
            {
            }

            internal bool _003CGetMotionDefineClip_003Eb__0(MotionDefineClip clip)
            {
                return default(bool);
            }
        }

        [SerializeField]
        private List<MotionDefineClip> _motionDefineClips;
        public List<MotionDefineClip> MotionDefineClips
        {
            get
            {
                return null;
            }
        }

        public void AddClip(MotionDefineClip clip)
        {
        }

        public void RemoveClip(int index)
        {
        }

        public void RemoveAllClips()
        {
        }

        public void UpdateMotionDefineClip(int clipId, MotionDefine motionDefine)
        {
        }

        public MotionDefineClip GetMotionDefineClip(int clipId)
        {
            return null;
        }

        public MotionDefineGroup()
        {
        }
    }
}
