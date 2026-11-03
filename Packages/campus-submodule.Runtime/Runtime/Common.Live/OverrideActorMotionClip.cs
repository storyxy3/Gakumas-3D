namespace Common.Live
{
    using global::System;
    using global::JetBrains.Annotations;
    using global::VL;

    [Serializable]
    public class OverrideActorMotionClip
    {
        public string clipName;
        [CanBeNull]
        public MotionDefine motionDefine;
        public OverrideActorMotionClip()
        {
        }
    }
}
