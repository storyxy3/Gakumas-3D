namespace Campus.Common
{
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "EnvironmentMotionDefine.asset", menuName = "Campus/Environment Motion Define", order = 1101)]
    public class EnvironmentMotionDefine : MotionDefine
    {
        public string animatorPath;
        public EnvironmentMotionDefine()
        {
        }
    }
}
