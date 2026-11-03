namespace VL.IK
{
    using global::UnityEngine;
    using global::VL.IK;

    public class LookAtEffector : EffectorBase
    {
        [Range(0f, 1f)]
        public float eyesWeight;
        [Range(0f, 1f)]
        public float headWeight;
        [Range(0f, 1f)]
        public float bodyWeight;
        public LookAtEffector()
        {
        }
    }
}
