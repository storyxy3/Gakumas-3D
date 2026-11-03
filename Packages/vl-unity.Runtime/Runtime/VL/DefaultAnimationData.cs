namespace VL
{
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "DefaultAnimationData.asset", menuName = "VL/Default Animation Data", order = 70001)]
    public class DefaultAnimationData : ScriptableObject
    {
        public AnimationData[] defaultAnimations;
        public DefaultAnimationData()
        {
        }
    }
}
