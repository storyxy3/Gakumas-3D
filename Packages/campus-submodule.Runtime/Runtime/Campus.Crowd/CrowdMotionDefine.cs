namespace Campus.Crowd
{
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "CrowdMotionDefine.asset", menuName = "Campus/CrowdMotionDefine")]
    public class CrowdMotionDefine : MotionDefine
    {
        [SerializeField]
        private AnimationData[] _animationDataArray;
        public override AnimationData this[int index]
        {
            get
            {
                return null;
            }
        }

        public override int count
        {
            get
            {
                return default(int);
            }
        }

        public void SetAnimationData(AnimationData animationData, int index)
        {
        }

        public CrowdMotionDefine()
        {
        }
    }
}
