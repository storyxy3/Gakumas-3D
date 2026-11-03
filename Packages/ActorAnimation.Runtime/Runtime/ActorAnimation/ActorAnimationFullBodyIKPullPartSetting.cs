namespace ActorAnimation
{
    using global::UnityEngine;

    public class ActorAnimationFullBodyIKPullPartSetting : MonoBehaviour
    {
        [Range(0f, 1f)]
        public float lookAtClampWeight;
        [Range(0f, 1.5f)]
        public float stiffness;
        [Range(1f, 50f)]
        public int maxPullIteration;
        [Range(-0.2f, 0.2f)]
        public float handDown;
        public ActorAnimationFullBodyIKPullPartSetting()
        {
        }
    }
}
