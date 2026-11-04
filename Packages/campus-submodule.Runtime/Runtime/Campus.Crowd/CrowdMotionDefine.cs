namespace Campus.Crowd
{
    using global::UnityEngine;
    using global::System;
    using global::Qua.Extensions;
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
                return _animationDataArray[index];
            }
        }

        public override int count
        {
            get
            {
                return _animationDataArray.IsNullOrEmpty() ? 0 : _animationDataArray.Length;
            }
        }

        public void SetAnimationData(AnimationData animationData, int index)
        {
            if (_animationDataArray.IsNullOrEmpty()) _animationDataArray = new AnimationData[1];
            if (count <= index) Array.Resize(ref _animationDataArray, index + 1);
            _animationDataArray[index] = animationData;
        }

        public CrowdMotionDefine()
        {
        }
    }
}
