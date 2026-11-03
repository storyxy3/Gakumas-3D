namespace VL.Animation.Legacy
{
    using global::UnityEngine;
    using global::VL.Animation.Legacy;

    [CreateAssetMenu(menuName = "VL/Animation Clip Player Param", fileName = "AnimationClipPlayerParam.asset", order = 61000)]
    public class VLAnimationClipPlayerParamObject : ScriptableObject
    {
        public VLAnimationClipPlayerParam param;
        public VLAnimationClipPlayerParamObject()
        {
        }
    }
}
