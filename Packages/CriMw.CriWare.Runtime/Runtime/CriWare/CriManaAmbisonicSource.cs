namespace CriWare
{
    using global::CriWare;
    using global::UnityEngine;

    public class CriManaAmbisonicSource : CriMonoBehaviour
    {
        private CriAtomEx3dSource atomEx3DsourceForAmbisonics;
        private Vector3 ambisonicSourceOrientationFront;
        private Vector3 ambisonicSourceOrientationTop;
        private Vector3 lastEulerOfAmbisonicSource;
        public override void CriInternalUpdate()
        {
        }

        public override void CriInternalLateUpdate()
        {
        }

        protected override void OnEnable()
        {
        }

        private void ForceUpdateAmbisonicSourceOrientation()
        {
        }

        private void UpdateAmbisonicSourceOrientation()
        {
        }

        private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler)
        {
        }

        public CriManaAmbisonicSource()
        {
        }
    }
}
