namespace ActorAnimation
{
    using global::UnityEngine;

    public class ActorAnimationLookAtEffectorLocator : MonoBehaviour
    {
        [Range(0f, 1f)]
        public float eyesWeight;
        [Range(0f, 1f)]
        public float headWeight;
        [Range(0f, 1f)]
        public float bodyWeight;
        public ActorAnimationLookAtEffectorLocator()
        {
        }
    }
}
