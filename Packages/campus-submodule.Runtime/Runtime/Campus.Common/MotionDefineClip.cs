namespace Campus.Common
{
    using global::System;
    using global::UnityEngine;
    using global::VL;

    [Serializable]
    public class MotionDefineClip
    {
        [SerializeField]
        private int _clipId;
        [SerializeField]
        private MotionDefine _motionDefine;
        public int ClipId
        {
            get
            {
                return default(int);
            }
        }

        public MotionDefine MotionDefine
        {
            get
            {
                return null;
            }
        }

        public void SetMotionDefine(MotionDefine motionDefine)
        {
        }
    }
}
