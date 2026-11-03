namespace VL
{
    using global::UnityEngine;

    [AddComponentMenu("")]
    public class VLActorRigBone : MonoBehaviour
    {
        [SerializeField]
        private Transform _target;
        public Transform target
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public VLActorRigBone()
        {
        }
    }
}
