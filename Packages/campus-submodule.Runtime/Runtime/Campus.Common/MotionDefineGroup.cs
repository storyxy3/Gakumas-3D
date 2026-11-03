namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "MotionDefineGroup.asset", menuName = "Campus/MotionDefineGroup", order = 1200)]
    public class MotionDefineGroup : ScriptableObject
    {
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
