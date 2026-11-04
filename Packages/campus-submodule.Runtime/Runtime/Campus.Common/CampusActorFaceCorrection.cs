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
        private float _globalWeight = 1f;
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
            if (blendShapeIndices == null) return;
            for (int i = 0; i < blendShapeIndices.Length; i++)
                if (blendShapeIndices[i] >= 0) faceModel.SetBlendShapeWeight(blendShapeIndices[i], 0f);
        }

        private Vector3 ClampEuler(Vector3 euler)
        {
            if (euler.x > 180f) euler.x -= 360f;
            if (euler.y > 180f) euler.y -= 360f;
            if (euler.z > 180f) euler.z -= 360f;
            return euler;
        }

        private void LateUpdate()
        {
            if (target == null) return;
            _euler = Vector3.zero;
            var cameraRotation = Quaternion.identity;
            if (global::VL.VLCameraController.HasInstance) cameraRotation = global::VL.VLCameraController.Instance.rotation;
            else if (Camera.main != null) cameraRotation = Camera.main.transform.rotation;
            var facing = cameraRotation * Quaternion.AngleAxis(180f, Vector3.up);
            _euler = ClampEuler((Quaternion.Inverse(target.rotation) * facing).eulerAngles);
            for (int i = 0; i < curves.Length; i++)
            {
                if (curves[i] == null || blendShapeIndices[i] < 0) continue;
                float value;
                switch (i)
                {
                    case 0:
                        value = -_euler.x;
                        break;
                    case 1:
                        value = Mathf.Abs(_euler.y) * (Mathf.Clamp(Mathf.Abs(_euler.x) - 45f, 0f, 45f) / -45f + 1f);
                        break;
                    case 2:
                    case 3:
                        value = _euler.y * (Mathf.Clamp(Mathf.Abs(_euler.x) - 45f, 0f, 45f) / -45f + 1f);
                        break;
                    default:
                        throw new global::System.ArgumentOutOfRangeException();
                }
                float weight = Mathf.Clamp01(curves[i].Evaluate(value));
                faceModel.SetBlendShapeWeight(blendShapeIndices[i], _globalWeight * weight * 100f);
            }
        }

        public CampusActorFaceCorrection()
        {
        }
    }
}
