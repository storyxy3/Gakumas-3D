namespace VL.IK
{
    using global::UnityEngine;

    public class CustomLookAtEffector : MonoBehaviour
    {
        public Transform target;
        [Range(0f, 1f)]
        public float customUseWeight;
        [Range(0f, 1f)]
        public float weight;
        [Range(0f, 1f)]
        public float eyesWeight;
        [Range(0f, 1f)]
        public float headWeight;
        [Range(0f, 1f)]
        public float bodyWeight;
        public bool useCustomTargetPosition;
        public Vector3 customTargetPosition;
        public CustomLookAtEffector()
        {
        }
    }
}
