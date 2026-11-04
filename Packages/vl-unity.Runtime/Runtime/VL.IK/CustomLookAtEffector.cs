namespace VL.IK
{
    using global::UnityEngine;

    public class CustomLookAtEffector : MonoBehaviour
    {
        public Transform target;
        [Range(0f, 1f)]
        public float customUseWeight = 1;
        [Range(0f, 1f)]
        public float weight = 1;
        [Range(0f, 1f)]
        public float eyesWeight = 0.2f;
        [Range(0f, 1f)]
        public float headWeight = 0.7f;
        [Range(0f, 1f)]
        public float bodyWeight = 0.1f;
        public bool useCustomTargetPosition;
        public Vector3 customTargetPosition;
        public CustomLookAtEffector()
        {

        }
    }
}
