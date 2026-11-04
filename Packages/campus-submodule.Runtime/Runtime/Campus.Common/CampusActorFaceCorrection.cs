// TODO(qa-recon): Selected APK bodies still need reconstruction: .ctor, ClampEuler, LateUpdate, OnDisable.
namespace Campus.Common
{
    using global::UnityEngine;
    using global::VL.FaceSystem;

    [DefaultExecutionOrder(1000)]
    public class CampusActorFaceCorrection : MonoBehaviour
    {
        public VLActorFaceModel faceModel;
        public Transform target;
        [Header("0:under045 1:side090 2:side045r 3:side045l")]
        public AnimationCurve[] curves;
        public int[] blendShapeIndices;
        private float _globalWeight;
        private Vector3 _euler;
        public float globalWeight
        {
            get
            {
                return _globalWeight;
            }

            set
            {
                _globalWeight = value;
            }
        }

        private void OnDisable()
        {
        }

        private Vector3 ClampEuler(Vector3 euler)
        {
            return default(Vector3);
        }

        private void LateUpdate()
        {
        }

        public CampusActorFaceCorrection()
        {
        }
    }
}
