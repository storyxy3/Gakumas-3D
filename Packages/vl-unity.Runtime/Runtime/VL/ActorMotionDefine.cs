namespace VL
{
    using global::System.Collections.Generic;
    using global::UnityEngine;
    using global::VL;

    [CreateAssetMenu(fileName = "ActorMotionDefine.asset", menuName = "VL/Actor Motion Define", order = 70001)]
    public class ActorMotionDefine : MotionDefine
    {
        public AnimationData faceAnimation;
        [Tooltip("Propコンストレイント設定")]
        public List<PropConstraintData> propConstraints;
        [Tooltip("座り用揺れもの補正有効")]
        public bool enableSeatedDynamicCorrection;
        public override int count
        {
            get
            {
                return faceAnimation == null || faceAnimation.clip == null ? 1 : 2;
            }
        }

        public override AnimationData this[int index]
        {
            get
            {
                return index == 1 ? faceAnimation : baseAnimation;
            }
        }

        public ActorMotionDefine()
        {
        }
    }
}
